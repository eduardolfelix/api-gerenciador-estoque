using GerEstoque.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerEstoque.Api.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.Preco).IsRequired();

            builder.HasOne(x  => x.Categoria)
                    .WithMany(x => x.Produtos)
                    .HasForeignKey(x => x.CategoriaId)
                    .IsRequired();
            builder.HasMany(x => x.Movimentacoes).WithOne(x => x.Produto);
            
            builder.ToTable("Produtos");
        }
    }
}