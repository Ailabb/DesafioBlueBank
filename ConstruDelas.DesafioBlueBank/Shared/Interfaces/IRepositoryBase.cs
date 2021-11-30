using Shared.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Shared.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        TEntity GetById(Guid id);
        void Update(TEntity product);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null);
        void Remove(Guid id);
    }
}
