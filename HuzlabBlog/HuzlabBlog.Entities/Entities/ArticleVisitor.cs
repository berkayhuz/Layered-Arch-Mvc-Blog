using HuzlabBlog.Core.Entities;

namespace HuzlabBlog.Entities.Entities
{
    public class ArticleVisitor : IBaseEntity
    {
        public ArticleVisitor() { }

        public ArticleVisitor(Guid articleId, int visitorId)
        {
            ArticleId = articleId;
            VisitorId = visitorId;
        }

        public Guid ArticleId { get; set; }
        public Article Article { get; set; }
        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
