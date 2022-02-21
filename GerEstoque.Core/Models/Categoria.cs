using System;
using System.Collections.Generic;

namespace GerEstoque.Core.Models
{
    public class Categoria : Entity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}