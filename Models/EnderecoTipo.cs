using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class EnderecoTipo
    {
        public EnderecoTipo()
        {
            Endereco = new HashSet<Endereco>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
    }
}
