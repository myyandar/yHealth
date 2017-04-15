using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    public abstract class yHealthRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<yHealthDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected yHealthRepositoryBase(IDbContextProvider<yHealthDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class yHealthRepositoryBase<TEntity> : yHealthRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected yHealthRepositoryBase(IDbContextProvider<yHealthDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
