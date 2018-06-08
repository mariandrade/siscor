﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SisCor.Models;

namespace SisCor.Migrations
{
    [DbContext(typeof(SisCorContext))]
    [Migration("20180608184456_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SisCor.Models.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<string>("IdPessoa")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SisCor.Models.Contato", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<bool?>("Ativo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("CriadoPor")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DataEdicao")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("EditadoPor")
                        .HasMaxLength(128);

                    b.Property<int>("IdContatoTipo");

                    b.Property<string>("IdPessoa")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("IdContatoTipo");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("SisCor.Models.ContatoTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("ContatoTipo");
                });

            modelBuilder.Entity("SisCor.Models.Cotacao", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<bool>("Ativo");

                    b.Property<string>("CriadoPor")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("IdCliente")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Uri")
                        .IsRequired()
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("Cotacao");
                });

            modelBuilder.Entity("SisCor.Models.Dependente", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<string>("Altura")
                        .HasMaxLength(5);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Endereco")
                        .HasMaxLength(10);

                    b.Property<string>("IdTitular")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NomeMae");

                    b.Property<string>("Peso")
                        .HasMaxLength(5);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.HasIndex("IdTitular");

                    b.ToTable("Dependente");
                });

            modelBuilder.Entity("SisCor.Models.Documento", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<bool>("Ativo");

                    b.Property<string>("CriadoPor")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<byte[]>("Dados")
                        .IsRequired();

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DataEdicao")
                        .HasColumnType("datetime");

                    b.Property<string>("EditadoPor")
                        .HasMaxLength(128);

                    b.Property<int>("IdDocumentoTipo");

                    b.Property<string>("IdPessoa")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("IdDocumentoTipo");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("SisCor.Models.DocumentoTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("DocumentoTipo");
                });

            modelBuilder.Entity("SisCor.Models.Endereco", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("CriadoPor")
                        .HasMaxLength(10);

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DataEdicao")
                        .HasColumnType("datetime");

                    b.Property<string>("EditadoPor")
                        .HasMaxLength(128);

                    b.Property<int>("IdEnderecoTipo");

                    b.Property<int>("IdEstado");

                    b.Property<string>("IdPessoa")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<decimal?>("Latitude")
                        .HasColumnType("decimal(12, 9)");

                    b.Property<string>("Logradouro");

                    b.Property<decimal?>("Longitude")
                        .HasColumnType("decimal(12, 9)");

                    b.Property<int?>("Numero");

                    b.HasKey("Id");

                    b.HasIndex("IdEnderecoTipo");

                    b.HasIndex("IdEstado");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SisCor.Models.EnderecoTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("EnderecoTipo");
                });

            modelBuilder.Entity("SisCor.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("SisCor.Models.FaixaEtaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("FaixaEtaria");
                });

            modelBuilder.Entity("SisCor.Models.Parceiro", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("IdParceiroTipo");

                    b.Property<string>("IdPessoa")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("IdParceiroTipo");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Parceiro");
                });

            modelBuilder.Entity("SisCor.Models.ParceiroTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("ParceiroTipo");
                });

            modelBuilder.Entity("SisCor.Models.Pessoa", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<bool?>("Ativo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("CriadoPor")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DataEdicao")
                        .HasColumnType("datetime");

                    b.Property<string>("EditadoPor")
                        .HasMaxLength(128);

                    b.Property<int>("IdPessoaTipo");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoaTipo");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("SisCor.Models.PessoaFisica", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<string>("Cnh")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Cpf")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("IdPessoa")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("NascidoVivo")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NomeMae");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("PessoaFisica");
                });

            modelBuilder.Entity("SisCor.Models.PessoaJuridica", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnName("CNPJ")
                        .HasMaxLength(10);

                    b.Property<string>("Fantasia")
                        .HasMaxLength(10);

                    b.Property<string>("IdPessoa")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Ie")
                        .HasColumnName("IE")
                        .HasMaxLength(10);

                    b.Property<string>("Im")
                        .HasColumnName("IM")
                        .HasMaxLength(10);

                    b.Property<string>("RamoAtividade")
                        .HasMaxLength(10);

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("PessoaJuridica");
                });

            modelBuilder.Entity("SisCor.Models.PessoaTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("PessoaTipo");
                });

            modelBuilder.Entity("SisCor.Models.Preco", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<bool?>("Ativo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("CriadoPor")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataEdicao")
                        .HasColumnType("datetime");

                    b.Property<string>("EditadoPor")
                        .HasMaxLength(128);

                    b.Property<int>("IdFaixaEtaria");

                    b.Property<string>("IdTabela")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("IdFaixaEtaria");

                    b.HasIndex("IdTabela");

                    b.ToTable("Preco");
                });

            modelBuilder.Entity("SisCor.Models.Produto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<bool?>("Ativo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("CriadoPor")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DataEdicao")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("EditadorPor")
                        .HasMaxLength(128);

                    b.Property<string>("IdParceiro")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("IdProdutoTipo");

                    b.Property<int>("IdSegmento");

                    b.HasKey("Id");

                    b.HasIndex("IdParceiro");

                    b.HasIndex("IdProdutoTipo");

                    b.HasIndex("IdSegmento");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SisCor.Models.ProdutoTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("ProdutoTipo");
                });

            modelBuilder.Entity("SisCor.Models.Proposta", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<string>("CriadoPor")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataEdicao")
                        .HasColumnType("datetime");

                    b.Property<string>("EditadoPor")
                        .HasMaxLength(128);

                    b.Property<string>("IdCliente")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("IdCotacao")
                        .HasMaxLength(128);

                    b.Property<string>("IdParceiro")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("Proposta");
                });

            modelBuilder.Entity("SisCor.Models.Segmento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Segmento");
                });

            modelBuilder.Entity("SisCor.Models.Tabela", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("IdProduto")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("IdTabelaTipo");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto");

                    b.HasIndex("IdTabelaTipo");

                    b.ToTable("Tabela");
                });

            modelBuilder.Entity("SisCor.Models.TabelaTipo", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("TabelaTipo");
                });

            modelBuilder.Entity("SisCor.Models.Titular", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Endereco");

                    b.Property<string>("IdProposta")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.HasIndex("IdProposta");

                    b.ToTable("Titular");
                });

            modelBuilder.Entity("SisCor.Models.Cliente", b =>
                {
                    b.HasOne("SisCor.Models.Pessoa", "IdPessoaNavigation")
                        .WithMany("Cliente")
                        .HasForeignKey("IdPessoa")
                        .HasConstraintName("FK_Cliente_Pessoa");
                });

            modelBuilder.Entity("SisCor.Models.Contato", b =>
                {
                    b.HasOne("SisCor.Models.ContatoTipo", "IdContatoTipoNavigation")
                        .WithMany("Contato")
                        .HasForeignKey("IdContatoTipo")
                        .HasConstraintName("FK_Contato_ContatoTipo");

                    b.HasOne("SisCor.Models.Pessoa", "IdPessoaNavigation")
                        .WithMany("Contato")
                        .HasForeignKey("IdPessoa")
                        .HasConstraintName("FK_Contato_Pessoa");
                });

            modelBuilder.Entity("SisCor.Models.Cotacao", b =>
                {
                    b.HasOne("SisCor.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Cotacao")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK_Cotacao_Cliente");
                });

            modelBuilder.Entity("SisCor.Models.Dependente", b =>
                {
                    b.HasOne("SisCor.Models.Titular", "IdTitularNavigation")
                        .WithMany("Dependente")
                        .HasForeignKey("IdTitular")
                        .HasConstraintName("FK_Dependente_Titular");
                });

            modelBuilder.Entity("SisCor.Models.Documento", b =>
                {
                    b.HasOne("SisCor.Models.DocumentoTipo", "IdDocumentoTipoNavigation")
                        .WithMany("Documento")
                        .HasForeignKey("IdDocumentoTipo")
                        .HasConstraintName("FK_Documento_DocumentoTipo");

                    b.HasOne("SisCor.Models.Pessoa", "IdPessoaNavigation")
                        .WithMany("Documento")
                        .HasForeignKey("IdPessoa")
                        .HasConstraintName("FK_Documento_Pessoa");
                });

            modelBuilder.Entity("SisCor.Models.Endereco", b =>
                {
                    b.HasOne("SisCor.Models.EnderecoTipo", "IdEnderecoTipoNavigation")
                        .WithMany("Endereco")
                        .HasForeignKey("IdEnderecoTipo")
                        .HasConstraintName("FK_Endereco_EnderecoTipo");

                    b.HasOne("SisCor.Models.Estado", "IdEstadoNavigation")
                        .WithMany("Endereco")
                        .HasForeignKey("IdEstado")
                        .HasConstraintName("FK_Endereco_Estado");

                    b.HasOne("SisCor.Models.Pessoa", "IdPessoaNavigation")
                        .WithMany("Endereco")
                        .HasForeignKey("IdPessoa")
                        .HasConstraintName("FK_Endereco_Pessoa");
                });

            modelBuilder.Entity("SisCor.Models.Parceiro", b =>
                {
                    b.HasOne("SisCor.Models.ParceiroTipo", "IdParceiroTipoNavigation")
                        .WithMany("Parceiro")
                        .HasForeignKey("IdParceiroTipo")
                        .HasConstraintName("FK_Parceiro_ParceiroTipo");

                    b.HasOne("SisCor.Models.Pessoa", "IdPessoaNavigation")
                        .WithMany("Parceiro")
                        .HasForeignKey("IdPessoa")
                        .HasConstraintName("FK_Parceiro_Pessoa");
                });

            modelBuilder.Entity("SisCor.Models.Pessoa", b =>
                {
                    b.HasOne("SisCor.Models.PessoaTipo", "IdPessoaTipoNavigation")
                        .WithMany("Pessoa")
                        .HasForeignKey("IdPessoaTipo")
                        .HasConstraintName("FK_Pessoa_PessoaTipo");
                });

            modelBuilder.Entity("SisCor.Models.PessoaFisica", b =>
                {
                    b.HasOne("SisCor.Models.Pessoa", "IdPessoaNavigation")
                        .WithMany("PessoaFisica")
                        .HasForeignKey("IdPessoa")
                        .HasConstraintName("FK_PessoaFisica_Pessoa");
                });

            modelBuilder.Entity("SisCor.Models.PessoaJuridica", b =>
                {
                    b.HasOne("SisCor.Models.Pessoa", "IdPessoaNavigation")
                        .WithMany("PessoaJuridica")
                        .HasForeignKey("IdPessoa")
                        .HasConstraintName("FK_PessoaJuridica_Pessoa");
                });

            modelBuilder.Entity("SisCor.Models.Preco", b =>
                {
                    b.HasOne("SisCor.Models.FaixaEtaria", "IdFaixaEtariaNavigation")
                        .WithMany("Preco")
                        .HasForeignKey("IdFaixaEtaria")
                        .HasConstraintName("FK_Preco_FaixaEtaria");

                    b.HasOne("SisCor.Models.Tabela", "IdTabelaNavigation")
                        .WithMany("Preco")
                        .HasForeignKey("IdTabela")
                        .HasConstraintName("FK_Preco_Tabela");
                });

            modelBuilder.Entity("SisCor.Models.Produto", b =>
                {
                    b.HasOne("SisCor.Models.Parceiro", "IdParceiroNavigation")
                        .WithMany("Produto")
                        .HasForeignKey("IdParceiro")
                        .HasConstraintName("FK_Produto_Parceiro");

                    b.HasOne("SisCor.Models.ProdutoTipo", "IdProdutoTipoNavigation")
                        .WithMany("Produto")
                        .HasForeignKey("IdProdutoTipo")
                        .HasConstraintName("FK_Produto_ProdutoTipo");

                    b.HasOne("SisCor.Models.Segmento", "IdSegmentoNavigation")
                        .WithMany("Produto")
                        .HasForeignKey("IdSegmento")
                        .HasConstraintName("FK_Produto_Segmento");
                });

            modelBuilder.Entity("SisCor.Models.Proposta", b =>
                {
                    b.HasOne("SisCor.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Proposta")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK_Proposta_Cliente");
                });

            modelBuilder.Entity("SisCor.Models.Tabela", b =>
                {
                    b.HasOne("SisCor.Models.Produto", "IdProdutoNavigation")
                        .WithMany("Tabela")
                        .HasForeignKey("IdProduto")
                        .HasConstraintName("FK_Tabela_Produto");

                    b.HasOne("SisCor.Models.TabelaTipo", "IdTabelaTipoNavigation")
                        .WithMany("Tabela")
                        .HasForeignKey("IdTabelaTipo")
                        .HasConstraintName("FK_Tabela_TabelaTipo");
                });

            modelBuilder.Entity("SisCor.Models.Titular", b =>
                {
                    b.HasOne("SisCor.Models.Proposta", "IdPropostaNavigation")
                        .WithMany("Titular")
                        .HasForeignKey("IdProposta")
                        .HasConstraintName("FK_Titular_Proposta");
                });
#pragma warning restore 612, 618
        }
    }
}