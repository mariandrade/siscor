using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Preco
    {
        public string Id { get; set; }
        public decimal Valor { get; set; }
        public string IdTabela { get; set; }
        public int IdFaixaEtaria { get; set; }
        public DateTime DataCriacao { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? DataEdicao { get; set; }
        public string EditadoPor { get; set; }
        public bool? Ativo { get; set; }

        public FaixaEtaria IdFaixaEtariaNavigation { get; set; }
        public Tabela IdTabelaNavigation { get; set; }
    }
}
