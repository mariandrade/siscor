using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Produto
    {
        public Produto()
        {
            Tabela = new HashSet<Tabela>();
        }

        public string Id { get; set; }
        public string Descricao { get; set; }
        public string IdParceiro { get; set; }
        public int IdSegmento { get; set; }
        public int IdProdutoTipo { get; set; }
        public bool? Ativo { get; set; }
        public string CriadoPor { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEdicao { get; set; }
        public string EditadorPor { get; set; }

        public Parceiro IdParceiroNavigation { get; set; }
        public ProdutoTipo IdProdutoTipoNavigation { get; set; }
        public Segmento IdSegmentoNavigation { get; set; }
        public ICollection<Tabela> Tabela { get; set; }
    }
}
