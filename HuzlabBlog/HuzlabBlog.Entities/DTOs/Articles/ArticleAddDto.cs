using HuzlabBlog.Entities.DTOs.Categories;
using Microsoft.AspNetCore.Http;

namespace HuzlabBlog.Entities.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public IList<CategoryDto> Categories { get; set; }
		public IFormFile Photo { get; set; }
    }
}
