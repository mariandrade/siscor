using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Cotacao
    {
        public string Id { get; set; }
        public string IdCliente { get; set; }
        public string Uri { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public string CriadoPor { get; set; }

        public Cliente IdClienteNavigation { get; set; }
    }
}
