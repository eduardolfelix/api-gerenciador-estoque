using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GerEstoque.Core.Models;

namespace GerEstoque.Api.Repositories.GenericRepository
{
    public interface IGenericRepository <TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> List();
        Task Add(TEntity entity);
        Task AddMultiple(IEnumerable<TEntity> entityList);
        Task<TEntity> GetById(Guid id);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveById(TEntity entity);
        Task<int> SaveChanges();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
    }
}