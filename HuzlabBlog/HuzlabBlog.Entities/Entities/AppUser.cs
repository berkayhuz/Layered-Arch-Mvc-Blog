using HuzlabBlog.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace HuzlabBlog.Entities.Entities
{
    public class AppUser : IdentityUser<Guid>, IBaseEntity
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? ImageId {  get; set; } = Guid.Parse("5783A0A4-0C35-4F26-A466-05636F9FEE2C");
		public Image Image {  get; set; }
        public ICollection<Article> Articles {  get; set; }
    }
}
