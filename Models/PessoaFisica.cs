using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class PessoaFisica
    {
        public string Id { get; set; }
        public string IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cnh { get; set; }
        public string NascidoVivo { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string NomeMae { get; set; }

        public Pessoa IdPessoaNavigation { get; set; }
    }
}
