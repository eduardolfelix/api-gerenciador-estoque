using System;
using System.Collections.Generic;
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

        public async Task AddAsync(Categoria categoria)
        {
            await _gerEstoqueContext.Categorias.AddAsync(categoria);
        }

        public Task AddMultipleAsync(IEnumerable<Categoria> entityList)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _gerEstoqueContext.Dispose();
        }

        public async Task<Categoria> GetByIdAsync(Guid id)
        {
            return await _gerEstoqueContext.Categorias.FindAsync(id);
        }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _gerEstoqueContext.Categorias.ToListAsync();
        }

        public void Remove(Categoria categoria)
        {
            _gerEstoqueContext.Categorias.Remove(categoria);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _gerEstoqueContext.SaveChangesAsync();
        }

        public void Update(Categoria categoria)
        {
            _gerEstoqueContext.Categorias.Update(categoria);
        }
        
    }
}