USE [master]
GO
/****** Object:  Database [HotelGrandario]    Script Date: 29/10/2019 13:01:52 ******/
CREATE DATABASE [HotelGrandario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelGrandario', FILENAME = N'D:\Proyectos\VSCSharp\SistemaHotel\BDD\HotelGrandario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HotelGrandario_log', FILENAME = N'D:\Proyectos\VSCSharp\SistemaHotel\BDD\HotelGrandario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HotelGrandario] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelGrandario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelGrandario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelGrandario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelGrandario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelGrandario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelGrandario] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelGrandario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelGrandario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelGrandario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelGrandario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelGrandario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelGrandario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelGrandario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelGrandario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelGrandario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelGrandario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HotelGrandario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelGrandario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelGrandario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelGrandario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelGrandario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelGrandario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelGrandario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelGrandario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HotelGrandario] SET  MULTI_USER 
GO
ALTER DATABASE [HotelGrandario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelGrandario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelGrandario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelGrandario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HotelGrandario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HotelGrandario] SET QUERY_STORE = OFF
GO
USE [HotelGrandario]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[id_art] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[precioUnitario] [int] NOT NULL,
	[id_tipo] [int] NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[id_art] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[nro_dni] [int] NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[calle] [varchar](50) NOT NULL,
	[nro_calle] [int] NULL,
	[id_barrio] [int] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesFactura]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesFactura](
	[nro_factura] [int] NOT NULL,
	[tipo_factura] [int] NOT NULL,
	[id_articulo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_historico] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estadias]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estadias](
	[nro_estadia] [int] NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_fun] [date] NULL,
	[cant_huespedes] [int] NOT NULL,
	[nro_habitacion] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_usu] [int] NOT NULL,
 CONSTRAINT [PK_Estadias] PRIMARY KEY CLUSTERED 
(
	[nro_estadia] ASC,
	[fecha_inicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[id_factura] [int] NOT NULL,
	[tipo_factura] [int] NOT NULL,
	[fecha_factura] [date] NOT NULL,
	[nro_estadia] [int] NOT NULL,
	[fecha_inicio_estadia] [date] NOT NULL,
	[total] [float] NOT NULL,
	[id_usu] [int] NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC,
	[tipo_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos](
	[id_tipo] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipos] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposFactura]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposFactura](
	[id_tipo] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposFactura] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 29/10/2019 13:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usu] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[nroDni] [nchar](8) NOT NULL,
	[fechaNac] [date] NULL,
	[calle] [varchar](50) NULL,
	[nroCalle] [int] NULL,
	[id_barrio] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (1, N'Fideos', N'Con Salsa', 350, 1)
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (2, N'Coca Cola', N'Sin Azucar', 80, 2)
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (3, N'Cartas', N'Españolas', 120, 3)
INSERT [dbo].[Barrios] ([id_barrio], [nombre]) VALUES (1, N'Costanera')
INSERT [dbo].[Clientes] ([id_cliente], [apellidos], [nombres], [nro_dni], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, N'Leonardi', N'Benjamin', 41483454, CAST(N'2011-11-11' AS Date), N'Calle 11', 11, 1)
INSERT [dbo].[Estadias] ([nro_estadia], [fecha_inicio], [fecha_fun], [cant_huespedes], [nro_habitacion], [id_cliente], [id_usu]) VALUES (1, CAST(N'2019-10-10' AS Date), CAST(N'2019-10-12' AS Date), 2, 2, 1, 1)
INSERT [dbo].[Facturas] ([id_factura], [tipo_factura], [fecha_factura], [nro_estadia], [fecha_inicio_estadia], [total], [id_usu]) VALUES (1, 1, CAST(N'2011-11-11' AS Date), 1, CAST(N'2012-10-11' AS Date), 1500, 1)
INSERT [dbo].[Tipos] ([id_tipo], [nombre]) VALUES (1, N'Comida')
INSERT [dbo].[Tipos] ([id_tipo], [nombre]) VALUES (2, N'Bebida')
INSERT [dbo].[Tipos] ([id_tipo], [nombre]) VALUES (3, N'Ocio')
INSERT [dbo].[TiposFactura] ([id_tipo], [descripcion]) VALUES (1, N'Tipo A')
INSERT [dbo].[TiposFactura] ([id_tipo], [descripcion]) VALUES (2, N'Tipo B')
INSERT [dbo].[Usuarios] ([id_usu], [usuario], [password], [apellido], [nombre], [nroDni], [fechaNac], [calle], [nroCalle], [id_barrio]) VALUES (1, N'benja', N'asd123', N'Leonardi', N'Benjamin', N'41483454', CAST(N'1998-11-18' AS Date), N'Miguel Juarez', 958, 1)
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Tipos] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[Tipos] ([id_tipo])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Tipos]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Barrios]
GO
ALTER TABLE [dbo].[Estadias]  WITH CHECK ADD  CONSTRAINT [FK_Estadias_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Estadias] CHECK CONSTRAINT [FK_Estadias_Clientes]
GO
ALTER TABLE [dbo].[Estadias]  WITH CHECK ADD  CONSTRAINT [FK_Estadias_Usuario] FOREIGN KEY([id_usu])
REFERENCES [dbo].[Usuarios] ([id_usu])
GO
ALTER TABLE [dbo].[Estadias] CHECK CONSTRAINT [FK_Estadias_Usuario]
GO
ALTER TABLE [dbo].[Facturas]  WITH NOCHECK ADD  CONSTRAINT [FK_Facturas_Estadias] FOREIGN KEY([nro_estadia], [fecha_inicio_estadia])
REFERENCES [dbo].[Estadias] ([nro_estadia], [fecha_inicio])
GO
ALTER TABLE [dbo].[Facturas] NOCHECK CONSTRAINT [FK_Facturas_Estadias]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_TiposFactura] FOREIGN KEY([tipo_factura])
REFERENCES [dbo].[TiposFactura] ([id_tipo])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_TiposFactura]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Usuario] FOREIGN KEY([id_usu])
REFERENCES [dbo].[Usuarios] ([id_usu])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Usuario]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_idBarrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_idBarrio]
GO
USE [master]
GO
ALTER DATABASE [HotelGrandario] SET  READ_WRITE 
GO
