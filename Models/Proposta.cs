using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Proposta
    {
        public Proposta()
        {
            Titular = new HashSet<Titular>();
        }

        public string Id { get; set; }
        public string IdCliente { get; set; }
        public string IdParceiro { get; set; }
        public string IdCotacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? DataEdicao { get; set; }
        public string EditadoPor { get; set; }

        public Cliente IdClienteNavigation { get; set; }
        public ICollection<Titular> Titular { get; set; }
    }
}
