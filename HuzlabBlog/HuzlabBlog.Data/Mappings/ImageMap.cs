using HuzlabBlog.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HuzlabBlog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("5783A0A4-0C35-4F26-A466-05636F9FEE2C"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "Berkay Huz",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
