using System;

namespace GerEstoque.Core.Models
{
    public class Movimentacao
    {
        public Guid Id { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMovimentacao { get; set; }
    }
}