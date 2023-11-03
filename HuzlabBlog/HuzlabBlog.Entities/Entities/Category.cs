using HuzlabBlog.Core.Entities;

namespace HuzlabBlog.Entities.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            
        }
        public Category(string name, string createdBy)
        {
            CreatedBy = createdBy;
            Name = name;
        }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
