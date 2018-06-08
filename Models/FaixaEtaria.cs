using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class FaixaEtaria
    {
        public FaixaEtaria()
        {
            Preco = new HashSet<Preco>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Preco> Preco { get; set; }
    }
}
