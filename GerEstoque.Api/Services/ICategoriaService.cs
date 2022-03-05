using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerEstoque.Core.Models;

namespace GerEstoque.Api.Services
{
    public interface ICategoriaService
    {
         Task<IEnumerable<Categoria>> List();
         Task<Categoria> GetById(Guid id);
         Task<Categoria> Add(Categoria categoria);
    }
}