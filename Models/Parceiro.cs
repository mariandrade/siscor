using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Parceiro
    {
        public Parceiro()
        {
            Produto = new HashSet<Produto>();
        }

        public string Id { get; set; }
        public string Descricao { get; set; }
        public string IdPessoa { get; set; }
        public int IdParceiroTipo { get; set; }

        public ParceiroTipo IdParceiroTipoNavigation { get; set; }
        public Pessoa IdPessoaNavigation { get; set; }
        public ICollection<Produto> Produto { get; set; }
    }
}
