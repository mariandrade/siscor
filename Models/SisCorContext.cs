using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SisCor.Models
{
    public partial class SisCorContext : DbContext
    {
        public SisCorContext()
        {
        }

        public SisCorContext(DbContextOptions<SisCorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<ContatoTipo> ContatoTipo { get; set; }
        public virtual DbSet<Cotacao> Cotacao { get; set; }
        public virtual DbSet<Dependente> Dependente { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<DocumentoTipo> DocumentoTipo { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<EnderecoTipo> EnderecoTipo { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<FaixaEtaria> FaixaEtaria { get; set; }
        public virtual DbSet<Parceiro> Parceiro { get; set; }
        public virtual DbSet<ParceiroTipo> ParceiroTipo { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaFisica> PessoaFisica { get; set; }
        public virtual DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public virtual DbSet<PessoaTipo> PessoaTipo { get; set; }
        public virtual DbSet<Preco> Preco { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutoTipo> ProdutoTipo { get; set; }
        public virtual DbSet<Proposta> Proposta { get; set; }
        public virtual DbSet<Segmento> Segmento { get; set; }
        public virtual DbSet<Tabela> Tabela { get; set; }
        public virtual DbSet<TabelaTipo> TabelaTipo { get; set; }
        public virtual DbSet<Titular> Titular { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\;Database=SisCor;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdPessoa)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Pessoa");
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CriadoPor)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataEdicao).HasColumnType("datetime");

                entity.Property(e => e.Descricao).IsRequired();

                entity.Property(e => e.EditadoPor).HasMaxLength(128);

                entity.Property(e => e.IdPessoa)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdContatoTipoNavigation)
                    .WithMany(p => p.Contato)
                    .HasForeignKey(d => d.IdContatoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contato_ContatoTipo");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.Contato)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contato_Pessoa");
            });

            modelBuilder.Entity<ContatoTipo>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cotacao>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CriadoPor)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Cotacao)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cotacao_Cliente");
            });

            modelBuilder.Entity<Dependente>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Altura).HasMaxLength(5);

                entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                entity.Property(e => e.Endereco).HasMaxLength(10);

                entity.Property(e => e.IdTitular)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Nome).IsRequired();

                entity.Property(e => e.Peso).HasMaxLength(5);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.IdTitularNavigation)
                    .WithMany(p => p.Dependente)
                    .HasForeignKey(d => d.IdTitular)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependente_Titular");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CriadoPor)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Dados).IsRequired();

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataEdicao).HasColumnType("datetime");

                entity.Property(e => e.EditadoPor).HasMaxLength(128);

                entity.Property(e => e.IdPessoa)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdDocumentoTipoNavigation)
                    .WithMany(p => p.Documento)
                    .HasForeignKey(d => d.IdDocumentoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documento_DocumentoTipo");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.Documento)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documento_Pessoa");
            });

            modelBuilder.Entity<DocumentoTipo>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CriadoPor).HasMaxLength(10);

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataEdicao).HasColumnType("datetime");

                entity.Property(e => e.EditadoPor).HasMaxLength(128);

                entity.Property(e => e.IdPessoa)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.HasOne(d => d.IdEnderecoTipoNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.IdEnderecoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Endereco_EnderecoTipo");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Endereco_Estado");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Endereco_Pessoa");
            });

            modelBuilder.Entity<EnderecoTipo>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<FaixaEtaria>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Parceiro>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdPessoa)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdParceiroTipoNavigation)
                    .WithMany(p => p.Parceiro)
                    .HasForeignKey(d => d.IdParceiroTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Parceiro_ParceiroTipo");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.Parceiro)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Parceiro_Pessoa");
            });

            modelBuilder.Entity<ParceiroTipo>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CriadoPor)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataEdicao).HasColumnType("datetime");

                entity.Property(e => e.EditadoPor).HasMaxLength(128);

                entity.HasOne(d => d.IdPessoaTipoNavigation)
                    .WithMany(p => p.Pessoa)
                    .HasForeignKey(d => d.IdPessoaTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pessoa_PessoaTipo");
            });

            modelBuilder.Entity<PessoaFisica>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cnh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.IdPessoa)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NascidoVivo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nome).IsRequired();

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.PessoaFisica)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PessoaFisica_Pessoa");
            });

            modelBuilder.Entity<PessoaJuridica>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("CNPJ")
                    .HasMaxLength(10);

                entity.Property(e => e.Fantasia).HasMaxLength(10);

                entity.Property(e => e.IdPessoa)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Ie)
                    .HasColumnName("IE")
                    .HasMaxLength(10);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(10);

                entity.Property(e => e.RamoAtividade).HasMaxLength(10);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.PessoaJuridica)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PessoaJuridica_Pessoa");
            });

            modelBuilder.Entity<PessoaTipo>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Preco>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CriadoPor)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.DataEdicao).HasColumnType("datetime");

                entity.Property(e => e.EditadoPor).HasMaxLength(128);

                entity.Property(e => e.IdTabela)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdFaixaEtariaNavigation)
                    .WithMany(p => p.Preco)
                    .HasForeignKey(d => d.IdFaixaEtaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preco_FaixaEtaria");

                entity.HasOne(d => d.IdTabelaNavigation)
                    .WithMany(p => p.Preco)
                    .HasForeignKey(d => d.IdTabela)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preco_Tabela");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CriadoPor)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataEdicao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EditadorPor).HasMaxLength(128);

                entity.Property(e => e.IdParceiro)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdParceiroNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.IdParceiro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto_Parceiro");

                entity.HasOne(d => d.IdProdutoTipoNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.IdProdutoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto_ProdutoTipo");

                entity.HasOne(d => d.IdSegmentoNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.IdSegmento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto_Segmento");
            });

            modelBuilder.Entity<ProdutoTipo>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Proposta>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CriadoPor)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.DataEdicao).HasColumnType("datetime");

                entity.Property(e => e.EditadoPor).HasMaxLength(128);

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.IdCotacao).HasMaxLength(128);

                entity.Property(e => e.IdParceiro)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Proposta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proposta_Cliente");
            });

            modelBuilder.Entity<Segmento>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Tabela>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.IdProduto)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.Tabela)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tabela_Produto");

                entity.HasOne(d => d.IdTabelaTipoNavigation)
                    .WithMany(p => p.Tabela)
                    .HasForeignKey(d => d.IdTabelaTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tabela_TabelaTipo");
            });

            modelBuilder.Entity<TabelaTipo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Titular>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                entity.Property(e => e.IdProposta)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Nome).IsRequired();

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.IdPropostaNavigation)
                    .WithMany(p => p.Titular)
                    .HasForeignKey(d => d.IdProposta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Titular_Proposta");
            });
        }
    }
}
