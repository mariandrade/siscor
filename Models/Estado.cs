using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Endereco = new HashSet<Endereco>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
    }
}
