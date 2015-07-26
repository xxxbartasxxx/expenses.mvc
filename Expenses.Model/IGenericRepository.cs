using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Expenses.Model
{
    public interface IGenericRepository<TEntity>  where TEntity: IEntity
    {
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Delete(object id);
        void Update(TEntity entity);
        TEntity GetById(object id);
    }
}
