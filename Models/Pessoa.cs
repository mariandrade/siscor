using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            Cliente = new HashSet<Cliente>();
            Contato = new HashSet<Contato>();
            Documento = new HashSet<Documento>();
            Endereco = new HashSet<Endereco>();
            Parceiro = new HashSet<Parceiro>();
            PessoaFisica = new HashSet<PessoaFisica>();
            PessoaJuridica = new HashSet<PessoaJuridica>();
        }

        public string Id { get; set; }
        public int IdPessoaTipo { get; set; }
        public DateTime DataCriacao { get; set; }
        public string CriadoPor { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? DataEdicao { get; set; }
        public string EditadoPor { get; set; }

        public PessoaTipo IdPessoaTipoNavigation { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Contato> Contato { get; set; }
        public ICollection<Documento> Documento { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Parceiro> Parceiro { get; set; }
        public ICollection<PessoaFisica> PessoaFisica { get; set; }
        public ICollection<PessoaJuridica> PessoaJuridica { get; set; }
    }
}
