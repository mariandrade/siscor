using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Documento
    {
        public string Id { get; set; }
        public int IdDocumentoTipo { get; set; }
        public string IdPessoa { get; set; }
        public byte[] Dados { get; set; }
        public DateTime DataCriacao { get; set; }
        public string CriadoPor { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataEdicao { get; set; }
        public string EditadoPor { get; set; }

        public DocumentoTipo IdDocumentoTipoNavigation { get; set; }
        public Pessoa IdPessoaNavigation { get; set; }
    }
}
