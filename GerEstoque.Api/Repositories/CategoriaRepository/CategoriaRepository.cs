using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GerEstoque.Api.Contexts;
using GerEstoque.Api.Persistance.Repositories;
using GerEstoque.Api.Repositories.GenericRepository;
using GerEstoque.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GerEstoque.Api.Repositories.CategoriaRepository
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        public CategoriaRepository(GerEstoqueContext gerEstoqueContext) : base(gerEstoqueContext)
        {
        }

        public async Task Add(Categoria categoria)
        {
            await _gerEstoqueContext.Categorias.AddAsync(categoria);
        }

        public async Task AddMultiple(IEnumerable<Categoria> categoria)
        {
            await _gerEstoqueContext.AddRangeAsync(categoria);
        }

        public void Dispose()
        {
            _gerEstoqueContext.Dispose();
        }

        public Task<IEnumerable<Categoria>> Find(Expression<Func<Categoria, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<Categoria> GetById(Guid id)
        {
            return await _gerEstoqueContext.Categorias.FindAsync(id);
        }

        public async Task<IEnumerable<Categoria>> List()
        {
            return await _gerEstoqueContext.Categorias.ToListAsync();
        }

        public void Remove(Categoria categoria)
        {
            _gerEstoqueContext.Categorias.Remove(categoria);
        }

        public void RemoveById(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChanges()
        {
            return await _gerEstoqueContext.SaveChangesAsync();
        }

        public void Update(Categoria categoria)
        {
            _gerEstoqueContext.Categorias.Update(categoria);
        }
        
    }
}