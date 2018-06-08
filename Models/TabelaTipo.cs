using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class TabelaTipo
    {
        public TabelaTipo()
        {
            Tabela = new HashSet<Tabela>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Tabela> Tabela { get; set; }
    }
}
