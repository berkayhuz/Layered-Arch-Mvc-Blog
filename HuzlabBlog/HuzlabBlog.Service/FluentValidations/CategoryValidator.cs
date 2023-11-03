using FluentValidation;
using HuzlabBlog.Entities.Entities;

namespace HuzlabBlog.Service.FluentValidations
{
	public class CategoryValidator : AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(x => x.Name)
				.NotEmpty()
				.NotNull()
				.MinimumLength(3)
				.MaximumLength(150)
				.WithName("Başlık");
		}
	}
}
