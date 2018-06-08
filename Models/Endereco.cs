using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Endereco
    {
        public string Id { get; set; }
        public string IdPessoa { get; set; }
        public int IdEnderecoTipo { get; set; }
        public int IdEstado { get; set; }
        public DateTime DataCriacao { get; set; }
        public string CriadoPor { get; set; }
        public string Logradouro { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataEdicao { get; set; }
        public string EditadoPor { get; set; }

        public EnderecoTipo IdEnderecoTipoNavigation { get; set; }
        public Estado IdEstadoNavigation { get; set; }
        public Pessoa IdPessoaNavigation { get; set; }
    }
}
