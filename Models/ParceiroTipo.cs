using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class ParceiroTipo
    {
        public ParceiroTipo()
        {
            Parceiro = new HashSet<Parceiro>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Parceiro> Parceiro { get; set; }
    }
}
