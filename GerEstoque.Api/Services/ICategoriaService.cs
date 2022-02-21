using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerEstoque.Core.Models;

namespace GerEstoque.Api.Services
{
    public interface ICategoriaService
    {
         Task<IEnumerable<Categoria>> ListAsync();
         Task<Categoria> GetByIdAsync(Guid id);
         Task<Categoria> AddAsync(Categoria categoria);
    }
}