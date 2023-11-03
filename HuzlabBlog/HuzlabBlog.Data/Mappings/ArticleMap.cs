using HuzlabBlog.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HuzlabBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Core Deneme Makalesi 1",
                CreatedBy = "Berkay Huz",
                Content = "Deneme Content",
                ViewCount = 15,
                CategoryId = Guid.Parse("6F679BE0-CA72-4DFC-B2BF-66E375F9CBC0"),
                ImageId = Guid.Parse("5783A0A4-0C35-4F26-A466-05636F9FEE2C"),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("B3402EC4-AB10-4F89-BD4A-9D95B601316F")
            });

            builder.Property(x => x.Title);
            builder.Property(x => x.Title)
                .IsRequired(false);
        }
    }
}
