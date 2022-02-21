using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerEstoque.Api.Repositories.GenericRepository;
using GerEstoque.Core.Models;

namespace GerEstoque.Api.Repositories.CategoriaRepository
{
    public interface ICategoriaRepository : IGenericRepository<Categoria>
    {
    }
}