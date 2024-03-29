USE [master]
GO
/****** Object:  Database [Clickasa.Pessoa]    Script Date: 31/05/2018 22:07:30 ******/
CREATE DATABASE [Clickasa.Pessoa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clickasa.Pessoa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Clickasa.Pessoa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clickasa.Pessoa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Clickasa.Pessoa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Clickasa.Pessoa] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clickasa.Pessoa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clickasa.Pessoa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clickasa.Pessoa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clickasa.Pessoa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Clickasa.Pessoa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clickasa.Pessoa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET RECOVERY FULL 
GO
ALTER DATABASE [Clickasa.Pessoa] SET  MULTI_USER 
GO
ALTER DATABASE [Clickasa.Pessoa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clickasa.Pessoa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clickasa.Pessoa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clickasa.Pessoa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clickasa.Pessoa] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Clickasa.Pessoa', N'ON'
GO
ALTER DATABASE [Clickasa.Pessoa] SET QUERY_STORE = OFF
GO
USE [Clickasa.Pessoa]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Clickasa.Pessoa]
GO
/****** Object:  Table [dbo].[Contato]    Script Date: 31/05/2018 22:07:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contato](
	[Id] [nvarchar](128) NOT NULL,
	[IdPessoa] [nvarchar](128) NOT NULL,
	[IdContatoTipo] [int] NOT NULL,
	[DataCriacao] [datetime] NOT NULL,
	[CriadoPor] [nvarchar](128) NOT NULL,
	[Valor] [nvarchar](max) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataEdicao] [datetime] NULL,
	[EditadoPor] [nvarchar](128) NULL,
 CONSTRAINT [PK_Contato] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContatoTipo]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContatoTipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ContatoTipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documento]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documento](
	[Id] [nvarchar](128) NOT NULL,
	[IdDocumentoTipo] [int] NOT NULL,
	[IdPessoa] [nvarchar](128) NOT NULL,
	[Dados] [varbinary](max) NOT NULL,
	[DataCriacao] [datetime] NOT NULL,
	[CriadoPor] [nvarchar](128) NULL,
	[Ativo] [bit] NOT NULL,
	[DataEdicao] [datetime] NULL,
	[EditadoPor] [nvarchar](128) NULL,
 CONSTRAINT [PK_Documento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentoTipo]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentoTipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DocumentoTipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[Id] [nvarchar](128) NOT NULL,
	[IdPessoa] [nvarchar](128) NOT NULL,
	[IdEnderecoTipo] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
	[DataCriacao] [datetime] NOT NULL,
	[CriadoPor] [nchar](10) NULL,
	[Logradouro] [nvarchar](max) NULL,
	[Numero] [int] NULL,
	[Complemento] [nvarchar](max) NULL,
	[Bairro] [nvarchar](max) NULL,
	[Cidade] [nvarchar](max) NULL,
	[Cep] [varchar](10) NULL,
	[Latitude] [decimal](12, 9) NULL,
	[Longitude] [decimal](12, 9) NULL,
	[Ativo] [bit] NOT NULL,
	[DataEdicao] [datetime] NULL,
	[EditadoPor] [nvarchar](128) NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnderecoTipo]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnderecoTipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EnderecoTipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](30) NOT NULL,
	[Sigla] [nchar](2) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[Id] [nvarchar](128) NOT NULL,
	[IdPessoaTipo] [int] NOT NULL,
	[DataCriacao] [datetime] NOT NULL,
	[CriadoPor] [nvarchar](128) NULL,
	[Ativo] [bit] NOT NULL,
	[DataEdicao] [datetime] NULL,
	[EditadoPor] [nvarchar](128) NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PessoaFisica]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PessoaFisica](
	[Id] [nvarchar](128) NOT NULL,
	[IdPessoa] [nvarchar](128) NOT NULL,
	[Nome] [nvarchar](max) NOT NULL,
	[Cpf] [varchar](20) NULL,
	[Rg] [varchar](20) NULL,
	[Cnh] [varchar](20) NULL,
	[DataNascimento] [date] NOT NULL,
	[Sexo] [nchar](1) NOT NULL,
 CONSTRAINT [PK_PessoaFisica] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PessoaJuridica]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PessoaJuridica](
	[Id] [nvarchar](128) NOT NULL,
	[IdPessoa] [nvarchar](128) NOT NULL,
	[RazaoSocial] [nchar](10) NOT NULL,
	[IE] [nchar](10) NULL,
	[IM] [nchar](10) NULL,
	[Fantasia] [nchar](10) NULL,
	[CNPJ] [nchar](10) NOT NULL,
	[RamoAtividade] [nchar](10) NULL,
 CONSTRAINT [PK_PessoaJuridica] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PessoaTipo]    Script Date: 31/05/2018 22:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PessoaTipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PessoaTipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ContatoTipo] ON 

INSERT [dbo].[ContatoTipo] ([Id], [Descricao]) VALUES (1, N'Telefone Residencial')
INSERT [dbo].[ContatoTipo] ([Id], [Descricao]) VALUES (2, N'Telefone Comercial')
INSERT [dbo].[ContatoTipo] ([Id], [Descricao]) VALUES (3, N'Email')
SET IDENTITY_INSERT [dbo].[ContatoTipo] OFF
SET IDENTITY_INSERT [dbo].[DocumentoTipo] ON 

INSERT [dbo].[DocumentoTipo] ([Id], [Descricao]) VALUES (1, N'RG')
INSERT [dbo].[DocumentoTipo] ([Id], [Descricao]) VALUES (2, N'CPF')
INSERT [dbo].[DocumentoTipo] ([Id], [Descricao]) VALUES (3, N'')
SET IDENTITY_INSERT [dbo].[DocumentoTipo] OFF
SET IDENTITY_INSERT [dbo].[EnderecoTipo] ON 

INSERT [dbo].[EnderecoTipo] ([Id], [Descricao]) VALUES (1, N'Residencial')
INSERT [dbo].[EnderecoTipo] ([Id], [Descricao]) VALUES (2, N'Comercial')
SET IDENTITY_INSERT [dbo].[EnderecoTipo] OFF
SET IDENTITY_INSERT [dbo].[PessoaTipo] ON 

INSERT [dbo].[PessoaTipo] ([Id], [Descricao]) VALUES (1, N'Pessoa Física')
INSERT [dbo].[PessoaTipo] ([Id], [Descricao]) VALUES (2, N'Pessoa Jurídica')
SET IDENTITY_INSERT [dbo].[PessoaTipo] OFF
ALTER TABLE [dbo].[Contato] ADD  CONSTRAINT [DF_Contato_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Contato] ADD  CONSTRAINT [DF_Contato_DataCriacao]  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Contato] ADD  CONSTRAINT [DF_Contato_Ativo]  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[Documento] ADD  CONSTRAINT [DF_Documento_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Documento] ADD  CONSTRAINT [DF_Documento_DataCriacao]  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Endereco] ADD  CONSTRAINT [DF_Endereco_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Endereco] ADD  CONSTRAINT [DF_Endereco_DataCriacao]  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Pessoa] ADD  CONSTRAINT [DF_Pessoa_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Pessoa] ADD  CONSTRAINT [DF_Pessoa_DataCriacao]  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Pessoa] ADD  CONSTRAINT [DF_Pessoa_Ativo]  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[PessoaFisica] ADD  CONSTRAINT [DF_PessoaFisica_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[PessoaJuridica] ADD  CONSTRAINT [DF_PessoaJuridica_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Contato]  WITH CHECK ADD  CONSTRAINT [FK_Contato_ContatoTipo] FOREIGN KEY([IdContatoTipo])
REFERENCES [dbo].[ContatoTipo] ([Id])
GO
ALTER TABLE [dbo].[Contato] CHECK CONSTRAINT [FK_Contato_ContatoTipo]
GO
ALTER TABLE [dbo].[Contato]  WITH CHECK ADD  CONSTRAINT [FK_Contato_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[Contato] CHECK CONSTRAINT [FK_Contato_Pessoa]
GO
ALTER TABLE [dbo].[Documento]  WITH CHECK ADD  CONSTRAINT [FK_Documento_DocumentoTipo] FOREIGN KEY([IdDocumentoTipo])
REFERENCES [dbo].[DocumentoTipo] ([Id])
GO
ALTER TABLE [dbo].[Documento] CHECK CONSTRAINT [FK_Documento_DocumentoTipo]
GO
ALTER TABLE [dbo].[Documento]  WITH CHECK ADD  CONSTRAINT [FK_Documento_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[Documento] CHECK CONSTRAINT [FK_Documento_Pessoa]
GO
ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_EnderecoTipo] FOREIGN KEY([IdEnderecoTipo])
REFERENCES [dbo].[EnderecoTipo] ([Id])
GO
ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_EnderecoTipo]
GO
ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Estado] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Estado] ([Id])
GO
ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Estado]
GO
ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Pessoa]
GO
ALTER TABLE [dbo].[Pessoa]  WITH CHECK ADD  CONSTRAINT [FK_Pessoa_PessoaTipo] FOREIGN KEY([IdPessoaTipo])
REFERENCES [dbo].[PessoaTipo] ([Id])
GO
ALTER TABLE [dbo].[Pessoa] CHECK CONSTRAINT [FK_Pessoa_PessoaTipo]
GO
ALTER TABLE [dbo].[PessoaFisica]  WITH CHECK ADD  CONSTRAINT [FK_PessoaFisica_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[PessoaFisica] CHECK CONSTRAINT [FK_PessoaFisica_Pessoa]
GO
ALTER TABLE [dbo].[PessoaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_PessoaJuridica_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[PessoaJuridica] CHECK CONSTRAINT [FK_PessoaJuridica_Pessoa]
GO
USE [master]
GO
ALTER DATABASE [Clickasa.Pessoa] SET  READ_WRITE 
GO
