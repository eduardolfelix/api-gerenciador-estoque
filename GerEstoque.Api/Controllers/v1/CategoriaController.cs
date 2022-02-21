using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerEstoque.Api.Contexts;
using GerEstoque.Api.Services;
using GerEstoque.Core.Constants;
using GerEstoque.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerEstoque.Api.Controllers.v1
{
    [Route(Versions.VersionV1)]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
        [HttpGet(Endpoints.Categorias.BaseCategoriaEndpoint)]
        public async Task<ActionResult<IEnumerable<Categoria>>>GetAllAsync(){
            try
            {
                return Ok(await _categoriaService.ListAsync());
            }
            catch (Exception ex)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError,$"Erro: {ex.Message}");
            }
        }
        // [HttpPost(Endpoints.Categorias.BaseCategoriaEndpoint)]
        // public async Task<ActionResult<IEnumerable<Categoria>>>PostAsync(Guid id){
        //     try
        //     {
        //         return Ok(await _categoriaService. );
        //     }
        //     catch (Exception ex)
        //     {
                
        //         return StatusCode(StatusCodes.Status500InternalServerError,$"Erro: {ex.Message}");
        //     }
        // }
    }
}