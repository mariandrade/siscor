using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SisCor.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContatoTipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoTipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoTipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Sigla = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaixaEtaria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixaEtaria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParceiroTipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParceiroTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaTipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoTipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segmento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segmento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaTipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdPessoaTipo = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CriadoPor = table.Column<string>(maxLength: 128, nullable: false),
                    Ativo = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    DataEdicao = table.Column<DateTime>(type: "datetime", nullable: true),
                    EditadoPor = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_PessoaTipo",
                        column: x => x.IdPessoaTipo,
                        principalTable: "PessoaTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdPessoa = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdPessoa = table.Column<string>(maxLength: 128, nullable: false),
                    IdContatoTipo = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CriadoPor = table.Column<string>(maxLength: 128, nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    DataEdicao = table.Column<DateTime>(type: "datetime", nullable: true),
                    EditadoPor = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_ContatoTipo",
                        column: x => x.IdContatoTipo,
                        principalTable: "ContatoTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdDocumentoTipo = table.Column<int>(nullable: false),
                    IdPessoa = table.Column<string>(maxLength: 128, nullable: false),
                    Dados = table.Column<byte[]>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CriadoPor = table.Column<string>(maxLength: 128, nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime", nullable: true),
                    EditadoPor = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documento_DocumentoTipo",
                        column: x => x.IdDocumentoTipo,
                        principalTable: "DocumentoTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documento_Pessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdPessoa = table.Column<string>(maxLength: 128, nullable: false),
                    IdEnderecoTipo = table.Column<int>(nullable: false),
                    IdEstado = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CriadoPor = table.Column<string>(maxLength: 10, nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(12, 9)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(12, 9)", nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime", nullable: true),
                    EditadoPor = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_EnderecoTipo",
                        column: x => x.IdEnderecoTipo,
                        principalTable: "EnderecoTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endereco_Estado",
                        column: x => x.IdEstado,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endereco_Pessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parceiro",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    IdPessoa = table.Column<string>(maxLength: 128, nullable: false),
                    IdParceiroTipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parceiro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parceiro_ParceiroTipo",
                        column: x => x.IdParceiroTipo,
                        principalTable: "ParceiroTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parceiro_Pessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdPessoa = table.Column<string>(maxLength: 128, nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Rg = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Cnh = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NascidoVivo = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: true),
                    Sexo = table.Column<string>(maxLength: 1, nullable: false),
                    NomeMae = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaFisica_Pessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdPessoa = table.Column<string>(maxLength: 128, nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 10, nullable: false),
                    IE = table.Column<string>(maxLength: 10, nullable: true),
                    IM = table.Column<string>(maxLength: 10, nullable: true),
                    Fantasia = table.Column<string>(maxLength: 10, nullable: true),
                    CNPJ = table.Column<string>(maxLength: 10, nullable: false),
                    RamoAtividade = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaJuridica_Pessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cotacao",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdCliente = table.Column<string>(maxLength: 128, nullable: false),
                    Uri = table.Column<string>(unicode: false, nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CriadoPor = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotacao_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proposta",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdCliente = table.Column<string>(maxLength: 128, nullable: false),
                    IdParceiro = table.Column<string>(maxLength: 128, nullable: false),
                    IdCotacao = table.Column<string>(maxLength: 128, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(maxLength: 128, nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime", nullable: true),
                    EditadoPor = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proposta_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    Descricao = table.Column<string>(maxLength: 128, nullable: false),
                    IdParceiro = table.Column<string>(maxLength: 128, nullable: false),
                    IdSegmento = table.Column<int>(nullable: false),
                    IdProdutoTipo = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    CriadoPor = table.Column<string>(maxLength: 128, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DataEdicao = table.Column<DateTime>(type: "datetime", nullable: true),
                    EditadorPor = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Parceiro",
                        column: x => x.IdParceiro,
                        principalTable: "Parceiro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_ProdutoTipo",
                        column: x => x.IdProdutoTipo,
                        principalTable: "ProdutoTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_Segmento",
                        column: x => x.IdSegmento,
                        principalTable: "Segmento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Titular",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdProposta = table.Column<string>(maxLength: 128, nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Sexo = table.Column<string>(maxLength: 1, nullable: false),
                    Endereco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Titular_Proposta",
                        column: x => x.IdProposta,
                        principalTable: "Proposta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tabela",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    Descricao = table.Column<string>(maxLength: 128, nullable: false),
                    IdProduto = table.Column<string>(maxLength: 128, nullable: false),
                    IdTabelaTipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabela_Produto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tabela_TabelaTipo",
                        column: x => x.IdTabelaTipo,
                        principalTable: "TabelaTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dependente",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    IdTitular = table.Column<string>(maxLength: 128, nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Sexo = table.Column<string>(maxLength: 1, nullable: false),
                    Endereco = table.Column<string>(maxLength: 10, nullable: true),
                    Peso = table.Column<string>(maxLength: 5, nullable: true),
                    Altura = table.Column<string>(maxLength: 5, nullable: true),
                    NomeMae = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependente_Titular",
                        column: x => x.IdTitular,
                        principalTable: "Titular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Preco",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false, defaultValueSql: "(newid())"),
                    Valor = table.Column<decimal>(nullable: false),
                    IdTabela = table.Column<string>(maxLength: 128, nullable: false),
                    IdFaixaEtaria = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(maxLength: 128, nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime", nullable: true),
                    EditadoPor = table.Column<string>(maxLength: 128, nullable: true),
                    Ativo = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preco_FaixaEtaria",
                        column: x => x.IdFaixaEtaria,
                        principalTable: "FaixaEtaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Preco_Tabela",
                        column: x => x.IdTabela,
                        principalTable: "Tabela",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdPessoa",
                table: "Cliente",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_IdContatoTipo",
                table: "Contato",
                column: "IdContatoTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_IdPessoa",
                table: "Contato",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Cotacao_IdCliente",
                table: "Cotacao",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Dependente_IdTitular",
                table: "Dependente",
                column: "IdTitular");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_IdDocumentoTipo",
                table: "Documento",
                column: "IdDocumentoTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_IdPessoa",
                table: "Documento",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdEnderecoTipo",
                table: "Endereco",
                column: "IdEnderecoTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdEstado",
                table: "Endereco",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdPessoa",
                table: "Endereco",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Parceiro_IdParceiroTipo",
                table: "Parceiro",
                column: "IdParceiroTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Parceiro_IdPessoa",
                table: "Parceiro",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_IdPessoaTipo",
                table: "Pessoa",
                column: "IdPessoaTipo");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFisica_IdPessoa",
                table: "PessoaFisica",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaJuridica_IdPessoa",
                table: "PessoaJuridica",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Preco_IdFaixaEtaria",
                table: "Preco",
                column: "IdFaixaEtaria");

            migrationBuilder.CreateIndex(
                name: "IX_Preco_IdTabela",
                table: "Preco",
                column: "IdTabela");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdParceiro",
                table: "Produto",
                column: "IdParceiro");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdProdutoTipo",
                table: "Produto",
                column: "IdProdutoTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdSegmento",
                table: "Produto",
                column: "IdSegmento");

            migrationBuilder.CreateIndex(
                name: "IX_Proposta_IdCliente",
                table: "Proposta",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_IdProduto",
                table: "Tabela",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_IdTabelaTipo",
                table: "Tabela",
                column: "IdTabelaTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Titular_IdProposta",
                table: "Titular",
                column: "IdProposta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Cotacao");

            migrationBuilder.DropTable(
                name: "Dependente");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "PessoaJuridica");

            migrationBuilder.DropTable(
                name: "Preco");

            migrationBuilder.DropTable(
                name: "ContatoTipo");

            migrationBuilder.DropTable(
                name: "Titular");

            migrationBuilder.DropTable(
                name: "DocumentoTipo");

            migrationBuilder.DropTable(
                name: "EnderecoTipo");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "FaixaEtaria");

            migrationBuilder.DropTable(
                name: "Tabela");

            migrationBuilder.DropTable(
                name: "Proposta");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "TabelaTipo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Parceiro");

            migrationBuilder.DropTable(
                name: "ProdutoTipo");

            migrationBuilder.DropTable(
                name: "Segmento");

            migrationBuilder.DropTable(
                name: "ParceiroTipo");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "PessoaTipo");
        }
    }
}
