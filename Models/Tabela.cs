using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class Tabela
    {
        public Tabela()
        {
            Preco = new HashSet<Preco>();
        }

        public string Id { get; set; }
        public string Descricao { get; set; }
        public string IdProduto { get; set; }
        public int IdTabelaTipo { get; set; }

        public Produto IdProdutoNavigation { get; set; }
        public TabelaTipo IdTabelaTipoNavigation { get; set; }
        public ICollection<Preco> Preco { get; set; }
    }
}
