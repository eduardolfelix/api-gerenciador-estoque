using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerEstoque.Api.Repositories.CategoriaRepository;
using GerEstoque.Core.Models;

namespace GerEstoque.Api.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public Task<Categoria> AddAsync(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public async Task<Categoria> GetByIdAsync(Guid id)
        {
            return await _categoriaRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _categoriaRepository.ListAsync();
        }
    }
}