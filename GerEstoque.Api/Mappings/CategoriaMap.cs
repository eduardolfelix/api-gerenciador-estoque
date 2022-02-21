using GerEstoque.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerEstoque.Api.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(30).IsRequired();
            builder.HasMany(x => x.Produtos).WithOne(x => x.Categoria);
            builder.ToTable("Categorias");
        }
    }
}