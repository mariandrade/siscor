using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class ContatoTipo
    {
        public ContatoTipo()
        {
            Contato = new HashSet<Contato>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Contato> Contato { get; set; }
    }
}
