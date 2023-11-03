using HuzlabBlog.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HuzlabBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("6F679BE0-CA72-4DFC-B2BF-66E375F9CBC0"),
                Name = "ASP.NET Core",
                CreatedDate = DateTime.Now,
                CreatedBy = "Berkay Huz",
                IsDeleted = false
            });
        }
    }
}
