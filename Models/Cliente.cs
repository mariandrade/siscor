using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Cotacao = new HashSet<Cotacao>();
            Proposta = new HashSet<Proposta>();
        }

        public string Id { get; set; }
        public string IdPessoa { get; set; }

        public Pessoa IdPessoaNavigation { get; set; }
        public ICollection<Cotacao> Cotacao { get; set; }
        public ICollection<Proposta> Proposta { get; set; }
    }
}
