using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class PessoaTipo
    {
        public PessoaTipo()
        {
            Pessoa = new HashSet<Pessoa>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Pessoa> Pessoa { get; set; }
    }
}
