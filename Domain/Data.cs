using System.Collections.Generic;
using System.Linq;
using SisCor.Models;

namespace SisCor.Domain
{
    public class Data
    {
        public IEnumerable<Navbar> navbarItems()
        {
            var menu = new List<Navbar>
            {
                new Navbar
                {
                    Id = 1,
                    nameOption = "Vendas",
                    imageClass = "fa fa-usd fa-fw",
                    area = "Cadastro",
                    controller = "Vendas",
                    action = "Index",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 0
                },

                new Navbar
                {
                    Id = 2,
                    nameOption = "Pagamentos",
                    imageClass = "fa fa-credit-card",
                    area = "Cadastro",
                    controller = "Parcelas",
                    action = "Index",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 0
                },
                 new Navbar
                {
                    Id = 3,
                    nameOption = "Pagamento de Comissões",
                    imageClass = "fa fa-money fa-fw",
                    area = "Cadastro",
                    controller = "ParcelaComissao",
                    action = "Index",
                    Grupos= "Administrador,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 0
                },
                  new Navbar
                {
                    Id = 5,
                    nameOption = "Recebimento de Comissões",
                    imageClass = "fa fa-money fa-fw",
                    area = "Cadastro",
                    controller = "ParcelaComissaoInterna",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 0
                },
                 new Navbar
                {
                    Id = 4,
                    nameOption = "Empréstimos",
                    imageClass = "fa fa-money fa-fw",
                    area = "Cadastro",
                    controller = "Emprestimos",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 0
                },
                new Navbar
                {
                    Id = 100,
                    nameOption = "Cadastro",
                    imageClass = "fa fa-tasks fa-fw",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = true,
                    parentId = 0
                },
                new Navbar
                {
                    Id = 101,
                    nameOption = "Cargos",
                    area = "Cadastro",
                    controller = "Cargos",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 100
                },

                new Navbar
                {
                    Id = 103,
                    nameOption = "Metas",
                    area = "Cadastro",
                    controller = "Metas",
                    action = "Index",
                    Grupos= "Administrador,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                new Navbar
                {
                    Id = 102,
                    nameOption = "Clientes",
                    area = "Cadastro",
                    controller = "Clientes",
                    action = "Index",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                new Navbar
                {
                    Id = 112,
                    nameOption = "Cotas",
                    area = "Cadastro",
                    controller = "Cotas",
                    action = "Index",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },

                new Navbar
                {
                    Id = 113,
                    nameOption = "Ramos",
                    area = "Cadastro",
                    controller = "Ramos",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 100
                },

                new Navbar
                {
                    Id = 104,
                    nameOption = "Administradoras",
                    area = "Cadastro",
                    controller = "Empresas",
                    action = "Index",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                new Navbar
                {
                    Id = 105,
                    nameOption = "Funcionários",
                    area = "Cadastro",
                    controller = "Funcionarios",
                    action = "Index",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                new Navbar
                {
                    Id = 106,
                    nameOption = "Grupos",
                    area = "Cadastro",
                    controller = "Grupos",
                    action = "Index",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                new Navbar
                {
                    Id = 107,
                    nameOption = "Segmentos",
                    area = "Cadastro",
                    controller = "Segmentos",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 100
                },

                new Navbar
                {
                    Id = 108,
                    nameOption = "Fornecedores",
                    area = "Cadastro",
                    controller = "Fornecedores",
                    action = "Index",
                    Grupos= "Administrador,Funcionario,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },

                new Navbar
                {
                    Id = 110,
                    nameOption = "Tabelas",
                    area = "Cadastro",
                    controller = "Tabelas",
                    action = "Index",
                    Grupos= "Administrador,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                 new Navbar
                {
                    Id = 111,
                    nameOption = "Comissões",
                    area = "Cadastro",
                    controller = "Comissao",
                    action = "Index",
                    Grupos= "Administrador,Administrador Filiais",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                  new Navbar
                {
                    Id = 114,
                    nameOption = "Comissões Internas",
                    imageClass = "fa fa-money fa-fw",
                    area = "Cadastro",
                    controller = "ComissoesInternas",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                new Navbar
                {
                    Id = 200,
                    nameOption = "Gerenciamento",
                    imageClass = "fa fa-wrench fa-fw",
                    Grupos= "Administrador",
                    status = true,
                    isParent = true,
                    parentId = 0
                },
                 new Navbar
                {
                    Id = 202,
                    nameOption = "Grupos",
                    area = "Gerenciamento",
                    controller = "Grupos",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 200
                },
                new Navbar
                {
                    Id = 201,
                    nameOption = "Usuários",
                    area = "Gerenciamento",
                    controller = "Usuarios",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 200
                },
                new Navbar
                {
                    Id = 109,
                    nameOption = "VendaStatus",
                    area = "Cadastro",
                    controller = "VendaStatus",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 100
                },
                new Navbar
                {
                    Id = 500,
                    nameOption = "Relatórios",
                    imageClass = "fa fa-bar-chart-o fa-fw",
                    Grupos= "Administrador",
                    status = true,
                    isParent = true,
                    parentId = 0
                },
                new Navbar
                {
                    Id = 501,
                    nameOption = "Recebimento de Comissões",
                    area = "Relatorios",
                    controller = "RecebimentoComissoes",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 500
                },
                 new Navbar
                {
                    Id = 502,
                    nameOption = "Pagamento de Comissões",
                    area = "Relatorios",
                    controller = "PagamentoComissoes",
                    action = "Index",
                    Grupos= "Administrador",
                    status = true,
                    isParent = false,
                    parentId = 500
                },    
            };

            return menu.ToList();
        }
    }
}