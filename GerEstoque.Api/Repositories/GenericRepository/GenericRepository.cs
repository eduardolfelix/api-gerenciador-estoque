using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerEstoque.Api.Contexts;
using GerEstoque.Core.Models;

namespace GerEstoque.Api.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly GerEstoqueContext _gerEstoqueContext;
        public GenericRepository(GerEstoqueContext gerEstoqueContext)
        {
            _gerEstoqueContext = gerEstoqueContext;
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            _gerEstoqueContext.Add(entity);
            await SaveChangesAsync();
        }

        public virtual async Task AddMultipleAsync(IEnumerable<TEntity> entityList)
        {
            _gerEstoqueContext.AddRange(entityList);
            await SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}