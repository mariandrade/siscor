using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Segmento
    {
        public Segmento()
        {
            Produto = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Produto> Produto { get; set; }
    }
}
