using GerEstoque.Api.Mappings;
using GerEstoque.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GerEstoque.Api.Contexts
{
    public class GerEstoqueContext : DbContext
    {
        public GerEstoqueContext(DbContextOptions<GerEstoqueContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategoriaMap());
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new MovimentacaoMap());
        }
    }
}