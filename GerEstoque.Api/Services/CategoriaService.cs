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

        public async Task<Categoria> Add(Categoria categoria)
        {
            await _categoriaRepository.Add(categoria);
            return categoria;
        }

        public async Task<Categoria> GetById(Guid id)
        {
            return await _categoriaRepository.GetById(id);
        }

        public async Task<IEnumerable<Categoria>> List()
        {
            return await _categoriaRepository.List();
        }
    }
}