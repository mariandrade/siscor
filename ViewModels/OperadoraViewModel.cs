using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisCor.ViewModels
{
    public class OperadoraViewModel
    {

        public string Descricao{ get; set; }
        public string RazaoSocial { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
        public string Fantasia { get; set; }
        public int CNPJ { get; set; }
        public string RamoAtividade { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int CEP { get; set; }
        public int IdEstado { get; set; }
        public int IdParceiroTipo { get; set; }
        public bool Ativo { get; set; }

        public SelectList Estados { get; set; }
    }
}
