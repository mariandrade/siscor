using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Contato
    {
        public string Id { get; set; }
        public string IdPessoa { get; set; }
        public int IdContatoTipo { get; set; }
        public DateTime DataCriacao { get; set; }
        public string CriadoPor { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? DataEdicao { get; set; }
        public string EditadoPor { get; set; }

        public ContatoTipo IdContatoTipoNavigation { get; set; }
        public Pessoa IdPessoaNavigation { get; set; }
    }
}
