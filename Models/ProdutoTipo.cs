using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class ProdutoTipo
    {
        public ProdutoTipo()
        {
            Produto = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Produto> Produto { get; set; }
    }
}
