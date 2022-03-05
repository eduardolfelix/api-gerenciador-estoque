using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GerEstoque.Api.Contexts;
using GerEstoque.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GerEstoque.Api.Repositories.GenericRepository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly GerEstoqueContext _gerEstoqueContext;
        protected readonly DbSet<TEntity> DbSet;
        public GenericRepository(GerEstoqueContext gerEstoqueContext)
        {
            _gerEstoqueContext = gerEstoqueContext;
            DbSet = gerEstoqueContext.Set<TEntity>();
        }

        public virtual async Task Add(TEntity entity)
        {
            _gerEstoqueContext.Add(entity);
            await SaveChanges();
        }

        public virtual async Task AddMultiple(IEnumerable<TEntity> entityList)
        {
            _gerEstoqueContext.AddRange(entityList);
            await SaveChanges();
        }

        public void Dispose()
        {
            _gerEstoqueContext?.Dispose();
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            var lResult = await this.Find(x => x.Id == id);
            return lResult.FirstOrDefault();
        }

        public virtual async Task<IEnumerable<TEntity>> List()
        {
            var lResult = await DbSet.ToListAsync();
            return lResult;
        }

        public virtual async void Remove(TEntity entity)
        {
            var remove = DbSet.Remove(entity);
            await SaveChanges();
        }

        public virtual async void RemoveById(TEntity entity)
        {
            var remove = await this.GetById(entity.Id);
            DbSet.Remove(remove);
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await _gerEstoqueContext.SaveChangesAsync();
        }

        public virtual async void Update(TEntity entity)
        {
            try
            {
                _gerEstoqueContext.Entry(entity).State = EntityState.Modified;
                DbSet.Update(entity);
                await SaveChanges();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}