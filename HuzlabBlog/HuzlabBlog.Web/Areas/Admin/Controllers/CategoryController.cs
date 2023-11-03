using AutoMapper;
using FluentValidation;
using HuzlabBlog.Entities.DTOs.Categories;
using HuzlabBlog.Entities.Entities;
using HuzlabBlog.Service.Consts;
using HuzlabBlog.Service.Extensions;
using HuzlabBlog.Service.Services.Abstractions;
using HuzlabBlog.Web.ResultMessages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace HuzlabBlog.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Authorize(Roles = $"{RoleConsts.SuperAdmin}, {RoleConsts.Admin}")]
    public class CategoryController : Controller
	{
		private readonly ICategoryService categoryService;
		private readonly IValidator<Category> validator;
		private readonly IToastNotification toast;
		private readonly IMapper mapper;

		public CategoryController(ICategoryService categoryService,IToastNotification toast, IValidator<Category> validator, IMapper mapper)
        {
			this.validator = validator;
			this.mapper = mapper;
			this.toast = toast;
			this.categoryService = categoryService;
		}

        public async Task<IActionResult> Index()
		{
			var categories = await categoryService.GetAllCategoriesNonDeleted();
			return View(categories);
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
		{
			var map = mapper.Map<Category>(categoryAddDto);
			var result = await validator.ValidateAsync(map);

			if (result.IsValid)
			{
				await categoryService.CreateCategoryAsync(categoryAddDto);
				toast.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });
				return RedirectToAction("Index", "Category", new { Area = "Admin" });
			}

			result.AddToModelState(this.ModelState);
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddWithAjax([FromBody] CategoryAddDto categoryAddDto)
		{
			var map = mapper.Map<Category>(categoryAddDto);
			var result = await validator.ValidateAsync(map);

			if (result.IsValid)
			{
				await categoryService.CreateCategoryAsync(categoryAddDto);
				toast.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });
				return Json(Messages.Category.Add(categoryAddDto.Name));
			}
			else
			{
				toast.AddErrorToastMessage(result.Errors.First().ErrorMessage,  new ToastrOptions { Title = "İşlem Başarısız" });
				return Json (result.Errors.First().ErrorMessage);
			}
		}

		[HttpGet]
		public async Task<IActionResult> Update(Guid categoryId)
		{
			var category = await categoryService.GetCategoryByGuid(categoryId);
			var map = mapper.Map<Category, CategoryUpdateDto>(category);

			return View(new CategoryUpdateDto() { Id = category.Id, Name = category.Name });
		}
		[HttpPost]
		public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
		{
			var map = mapper.Map<Category>(categoryUpdateDto);
			var result = await validator.ValidateAsync(map);

			if (result.IsValid)
			{
				var name = await categoryService.UpdateCategoryAsync(categoryUpdateDto);
				toast.AddSuccessToastMessage(Messages.Category.Update(name), new ToastrOptions { Title = "İşlem Başarılı" });
				return RedirectToAction("Index", "Category", new { Area = "Admin" });
			}

			result.AddToModelState(this.ModelState);
			return View();
		}
		public async Task<IActionResult> Delete(Guid categoryId)
		{
			var name = await categoryService.SafeDeleteCategoryAsync(categoryId);
			toast.AddSuccessToastMessage(Messages.Category.Delete(name), new ToastrOptions()
			{
				Title = "İşlem Başarılı"
			});

			return RedirectToAction("Index", "Category", new { Area = "Admin" });
		}
        public async Task<IActionResult> DeletedCategory()
        {
            var categories = await categoryService.GetAllCategoriesDeleted();
            return View(categories);
        }
        public async Task<IActionResult> UndoDelete(Guid categoryId)
        {
            var name = await categoryService.UndoDeleteCategoryAsync(categoryId);
            toast.AddSuccessToastMessage(Messages.Category.Delete(name), new ToastrOptions() { Title = "İşlem Başarılı" });

            return RedirectToAction("Index", "Category", new { Area = "Admin" });
        }
    }
}
