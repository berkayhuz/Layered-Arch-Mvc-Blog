using HuzlabBlog.Data.Repositories.Absbractions;
using HuzlabBlog.Core.Entities;

namespace HuzlabBlog.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IBaseEntity, new();

        Task<int> SaveAsync();
        int Save();
    }
}
