using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Dependente
    {
        public string Id { get; set; }
        public string IdTitular { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string NomeMae { get; set; }

        public Titular IdTitularNavigation { get; set; }
    }
}
