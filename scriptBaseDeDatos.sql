USE [HotelGrandario]
GO
/****** Object:  Table [dbo].[DetallesFactura]    Script Date: 10/29/2019 20:28:44 ******/
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
INSERT [dbo].[DetallesFactura] ([nro_factura], [tipo_factura], [id_articulo], [cantidad], [precio_historico]) VALUES (1, 2, 1, 1, 350)
INSERT [dbo].[DetallesFactura] ([nro_factura], [tipo_factura], [id_articulo], [cantidad], [precio_historico]) VALUES (1, 2, 4, 1, 70)
INSERT [dbo].[DetallesFactura] ([nro_factura], [tipo_factura], [id_articulo], [cantidad], [precio_historico]) VALUES (2, 1, 3, 1, 120)
INSERT [dbo].[DetallesFactura] ([nro_factura], [tipo_factura], [id_articulo], [cantidad], [precio_historico]) VALUES (3, 1, 2, 2, 80)
INSERT [dbo].[DetallesFactura] ([nro_factura], [tipo_factura], [id_articulo], [cantidad], [precio_historico]) VALUES (4, 1, 5, 1, 50)
INSERT [dbo].[DetallesFactura] ([nro_factura], [tipo_factura], [id_articulo], [cantidad], [precio_historico]) VALUES (4, 1, 4, 1, 70)
INSERT [dbo].[DetallesFactura] ([nro_factura], [tipo_factura], [id_articulo], [cantidad], [precio_historico]) VALUES (5, 1, 7, 1, 300)
/****** Object:  Table [dbo].[Barrios]    Script Date: 10/29/2019 20:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre]) VALUES (0, N'Centro')
INSERT [dbo].[Barrios] ([id_barrio], [nombre]) VALUES (1, N'Costanera')
INSERT [dbo].[Barrios] ([id_barrio], [nombre]) VALUES (2, N'Norte')
INSERT [dbo].[Barrios] ([id_barrio], [nombre]) VALUES (3, N'Sur')
INSERT [dbo].[Barrios] ([id_barrio], [nombre]) VALUES (4, N'Farbias')
INSERT [dbo].[Barrios] ([id_barrio], [nombre]) VALUES (5, N'Salgueiro')
/****** Object:  Table [dbo].[TiposFactura]    Script Date: 10/29/2019 20:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposFactura](
	[id_tipo] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposFactura] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TiposFactura] ([id_tipo], [descripcion]) VALUES (1, N'Tipo A')
INSERT [dbo].[TiposFactura] ([id_tipo], [descripcion]) VALUES (2, N'Tipo B')
/****** Object:  Table [dbo].[Tipos]    Script Date: 10/29/2019 20:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipos](
	[id_tipo] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipos] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Tipos] ([id_tipo], [nombre]) VALUES (1, N'Comida')
INSERT [dbo].[Tipos] ([id_tipo], [nombre]) VALUES (2, N'Bebida')
INSERT [dbo].[Tipos] ([id_tipo], [nombre]) VALUES (3, N'Ocio')
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 10/29/2019 20:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[patente] [int] NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[color] [varchar](10) NOT NULL,
	[dni_cliente] [int] NOT NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[patente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/29/2019 20:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Usuarios] ([id_usu], [usuario], [password], [apellido], [nombre], [nroDni], [fechaNac], [calle], [nroCalle], [id_barrio]) VALUES (1, N'benja', N'asd123', N'Leonardi', N'Benjamin', N'41483454', CAST(0x6E220B00 AS Date), N'Miguel Juarez', 958, 1)
INSERT [dbo].[Usuarios] ([id_usu], [usuario], [password], [apellido], [nombre], [nroDni], [fechaNac], [calle], [nroCalle], [id_barrio]) VALUES (2, N'marcos', N'asd123', N'Solis', N'Marcos', N'29567841', CAST(0x19FA0A00 AS Date), N'Almada', 1015, 2)
INSERT [dbo].[Usuarios] ([id_usu], [usuario], [password], [apellido], [nombre], [nroDni], [fechaNac], [calle], [nroCalle], [id_barrio]) VALUES (3, N'mariana', N'asd123', N'Potosi', N'Mariana', N'35971645', CAST(0xA8180B00 AS Date), N'San Martin', 333, 3)
INSERT [dbo].[Usuarios] ([id_usu], [usuario], [password], [apellido], [nombre], [nroDni], [fechaNac], [calle], [nroCalle], [id_barrio]) VALUES (4, N'colo23', N'asd123', N'Rorikstead', N'Lucas', N'39456874', CAST(0x631F0B00 AS Date), N'Tenenbaum', 785, 4)
INSERT [dbo].[Usuarios] ([id_usu], [usuario], [password], [apellido], [nombre], [nroDni], [fechaNac], [calle], [nroCalle], [id_barrio]) VALUES (5, N'julian', N'asd123', N'Benegas Lane', N'Julian', N'40922182', CAST(0x6D210B00 AS Date), N'San Jeronimo', 167, 0)
/****** Object:  Table [dbo].[Articulos]    Script Date: 10/29/2019 20:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (1, N'Fideos', N'Con Salsa', 350, 1)
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (2, N'Coca Cola', N'Sin Azucar', 80, 2)
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (3, N'Cartas', N'Españolas', 120, 3)
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (4, N'Agua', N'Sin Gas', 70, 2)
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (5, N'Galletas', N'Integrales', 50, 1)
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (6, N'Red Bull', N'Te da alas', 65, 2)
INSERT [dbo].[Articulos] ([id_art], [nombre], [descripcion], [precioUnitario], [id_tipo]) VALUES (7, N'Canelones', N'Con Salsa', 300, 1)
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/29/2019 20:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Clientes] ([id_cliente], [apellidos], [nombres], [nro_dni], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, N'Leonardi', N'Benjamin', 41483454, CAST(0xF3340B00 AS Date), N'Calle 11', 11, 1)
INSERT [dbo].[Clientes] ([id_cliente], [apellidos], [nombres], [nro_dni], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (2, N'Almeda', N'Dario', 34841697, CAST(0xC3000B00 AS Date), N'Sin nombre', 1000, 0)
INSERT [dbo].[Clientes] ([id_cliente], [apellidos], [nombres], [nro_dni], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (3, N'Rojas', N'Celeste', 30479513, CAST(0x0CFA0A00 AS Date), N'Limonero', 254, 2)
/****** Object:  Table [dbo].[Estadias]    Script Date: 10/29/2019 20:28:44 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Estadias] ([nro_estadia], [fecha_inicio], [fecha_fun], [cant_huespedes], [nro_habitacion], [id_cliente], [id_usu]) VALUES (1, CAST(0x2E3E0B00 AS Date), CAST(0x383E0B00 AS Date), 1, 7, 2, 1)
INSERT [dbo].[Estadias] ([nro_estadia], [fecha_inicio], [fecha_fun], [cant_huespedes], [nro_habitacion], [id_cliente], [id_usu]) VALUES (1, CAST(0xBB3F0B00 AS Date), CAST(0xC53F0B00 AS Date), 2, 4, 1, 2)
INSERT [dbo].[Estadias] ([nro_estadia], [fecha_inicio], [fecha_fun], [cant_huespedes], [nro_habitacion], [id_cliente], [id_usu]) VALUES (1, CAST(0xDA3F0B00 AS Date), CAST(0xE43F0B00 AS Date), 2, 5, 2, 3)
INSERT [dbo].[Estadias] ([nro_estadia], [fecha_inicio], [fecha_fun], [cant_huespedes], [nro_habitacion], [id_cliente], [id_usu]) VALUES (1, CAST(0xFA3F0B00 AS Date), CAST(0x04400B00 AS Date), 3, 6, 3, 4)
INSERT [dbo].[Estadias] ([nro_estadia], [fecha_inicio], [fecha_fun], [cant_huespedes], [nro_habitacion], [id_cliente], [id_usu]) VALUES (1, CAST(0x1A400B00 AS Date), CAST(0x24400B00 AS Date), 1, 7, 2, 5)
INSERT [dbo].[Estadias] ([nro_estadia], [fecha_inicio], [fecha_fun], [cant_huespedes], [nro_habitacion], [id_cliente], [id_usu]) VALUES (1, CAST(0x3D400B00 AS Date), CAST(0x3F400B00 AS Date), 2, 2, 1, 1)
/****** Object:  Table [dbo].[Facturas]    Script Date: 10/29/2019 20:28:44 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Facturas] ([id_factura], [tipo_factura], [fecha_factura], [nro_estadia], [fecha_inicio_estadia], [total], [id_usu]) VALUES (1, 1, CAST(0xF3340B00 AS Date), 1, CAST(0x42360B00 AS Date), 1500, 1)
INSERT [dbo].[Facturas] ([id_factura], [tipo_factura], [fecha_factura], [nro_estadia], [fecha_inicio_estadia], [total], [id_usu]) VALUES (1, 2, CAST(0x50400B00 AS Date), 1, CAST(0x3D400B00 AS Date), 420, 5)
INSERT [dbo].[Facturas] ([id_factura], [tipo_factura], [fecha_factura], [nro_estadia], [fecha_inicio_estadia], [total], [id_usu]) VALUES (2, 1, CAST(0x50400B00 AS Date), 1, CAST(0xBA3D0B00 AS Date), 120, 4)
INSERT [dbo].[Facturas] ([id_factura], [tipo_factura], [fecha_factura], [nro_estadia], [fecha_inicio_estadia], [total], [id_usu]) VALUES (3, 1, CAST(0x50400B00 AS Date), 1, CAST(0x643F0B00 AS Date), 160, 3)
INSERT [dbo].[Facturas] ([id_factura], [tipo_factura], [fecha_factura], [nro_estadia], [fecha_inicio_estadia], [total], [id_usu]) VALUES (4, 1, CAST(0x50400B00 AS Date), 1, CAST(0x843F0B00 AS Date), 120, 5)
INSERT [dbo].[Facturas] ([id_factura], [tipo_factura], [fecha_factura], [nro_estadia], [fecha_inicio_estadia], [total], [id_usu]) VALUES (5, 1, CAST(0x50400B00 AS Date), 1, CAST(0x3D400B00 AS Date), 300, 3)
/****** Object:  ForeignKey [FK_Articulos_Tipos]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Tipos] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[Tipos] ([id_tipo])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Tipos]
GO
/****** Object:  ForeignKey [FK_Clientes_Barrios]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Barrios]
GO
/****** Object:  ForeignKey [FK_Estadias_Clientes]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Estadias]  WITH CHECK ADD  CONSTRAINT [FK_Estadias_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Estadias] CHECK CONSTRAINT [FK_Estadias_Clientes]
GO
/****** Object:  ForeignKey [FK_Estadias_Usuario]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Estadias]  WITH CHECK ADD  CONSTRAINT [FK_Estadias_Usuario] FOREIGN KEY([id_usu])
REFERENCES [dbo].[Usuarios] ([id_usu])
GO
ALTER TABLE [dbo].[Estadias] CHECK CONSTRAINT [FK_Estadias_Usuario]
GO
/****** Object:  ForeignKey [FK_Facturas_Estadias]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Facturas]  WITH NOCHECK ADD  CONSTRAINT [FK_Facturas_Estadias] FOREIGN KEY([nro_estadia], [fecha_inicio_estadia])
REFERENCES [dbo].[Estadias] ([nro_estadia], [fecha_inicio])
GO
ALTER TABLE [dbo].[Facturas] NOCHECK CONSTRAINT [FK_Facturas_Estadias]
GO
/****** Object:  ForeignKey [FK_Facturas_TiposFactura]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_TiposFactura] FOREIGN KEY([tipo_factura])
REFERENCES [dbo].[TiposFactura] ([id_tipo])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_TiposFactura]
GO
/****** Object:  ForeignKey [FK_Facturas_Usuario]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Usuario] FOREIGN KEY([id_usu])
REFERENCES [dbo].[Usuarios] ([id_usu])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Usuario]
GO
/****** Object:  ForeignKey [FK_idBarrio]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_idBarrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_idBarrio]
GO
/****** Object:  ForeignKey [FK_Vehiculos_Vehiculos]    Script Date: 10/29/2019 20:28:44 ******/
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Vehiculos] FOREIGN KEY([patente])
REFERENCES [dbo].[Vehiculos] ([patente])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Vehiculos]
GO
