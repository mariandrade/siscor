using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Titular
    {
        public Titular()
        {
            Dependente = new HashSet<Dependente>();
        }

        public string Id { get; set; }
        public string IdProposta { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }

        public Proposta IdPropostaNavigation { get; set; }
        public ICollection<Dependente> Dependente { get; set; }
    }
}
