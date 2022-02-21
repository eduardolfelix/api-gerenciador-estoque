using GerEstoque.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerEstoque.Api.Mappings
{
    public class MovimentacaoMap : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).HasMaxLength(200).IsRequired();
            builder.Property(x => x.DataMovimentacao).IsRequired();

            builder.HasOne(x => x.Produto)
                    .WithMany(x => x.Movimentacoes)
                    .HasForeignKey(x => x.ProdutoId)
                    .IsRequired();
            
            builder.ToTable("Movimentacoes");
        }
    }
}