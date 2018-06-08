using System;
using System.Collections.Generic;

namespace SisCor.Models
{
    public partial class DocumentoTipo
    {
        public DocumentoTipo()
        {
            Documento = new HashSet<Documento>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Documento> Documento { get; set; }
    }
}
