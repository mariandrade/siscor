using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class PessoaJuridica
    {
        public string Id { get; set; }
        public string IdPessoa { get; set; }
        public string RazaoSocial { get; set; }
        public string Ie { get; set; }
        public string Im { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string RamoAtividade { get; set; }

        public Pessoa IdPessoaNavigation { get; set; }
    }
}
