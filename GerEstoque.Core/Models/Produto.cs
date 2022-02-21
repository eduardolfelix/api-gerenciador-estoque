using System;
using System.Collections.Generic;

namespace GerEstoque.Core.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}