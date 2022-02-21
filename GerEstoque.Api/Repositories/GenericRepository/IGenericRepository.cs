using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerEstoque.Core.Models;

namespace GerEstoque.Api.Repositories.GenericRepository
{
    public interface IGenericRepository <TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> ListAsync();
        Task AddAsync(TEntity entity);
        Task AddMultipleAsync(IEnumerable<TEntity> entityList);
        Task<TEntity> GetByIdAsync(Guid id);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        Task<int> SaveChangesAsync();
    }
}