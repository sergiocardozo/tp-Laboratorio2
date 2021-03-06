CREATE DATABASE [DBPlayForFun]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 16/11/2020 00:35:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE [DBPlayForFun]
GO
CREATE TABLE [dbo].[CLIENTES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idSocio] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
insert into CLIENTES values ('1','Pato','Abbondanzieri');
insert into CLIENTES values ('2','Flaco', 'Schiavi');
insert into CLIENTES values ('3','Patron', 'Bermudez');
insert into CLIENTES values ('4','Hugo', 'Ibarra');
insert into CLIENTES values ('5', 'Sebastian', 'Batagglia');
insert into CLIENTES values ('6', 'Chicho', 'Serna');
insert into CLIENTES values ('7', 'Guillermo', 'Schelotto');
insert into CLIENTES values ('8', 'Anibal', 'Matellan');
insert into CLIENTES values ('9', 'Martin', 'Palermo');
insert into CLIENTES values ('10', 'Roman', 'Riquelme');
insert into CLIENTES values ('11', 'Chelo', 'Delgado');
insert into CLIENTES values ('12', 'Oscar', 'Cordoba');
insert into CLIENTES values ('13', 'Nicolas', 'Burdisso');
insert into CLIENTES values ('14', 'Clemente', 'Rodriguez');
insert into CLIENTES values ('15', 'Chipi', 'Barijho');
insert into CLIENTES values ('16', 'Carlos', 'Bianchi');
insert into CLIENTES values ('17', 'Cristian', 'Ledesma');
insert into CLIENTES values ('18', 'Jose', 'Calvo');
insert into CLIENTES values ('19', 'Cristian', 'Traverso');
insert into CLIENTES values ('20', 'Cesar', 'La Paglia');
insert into CLIENTES values ('21', 'Javier', 'Villarreal');
GO
/****** Object:  Table [dbo].[TIPOVIDEOJUEGO]    Script Date: 16/11/2020 00:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOVIDEOJUEGO](
	[IDTipoJuego] [int] IDENTITY(1,1) NOT NULL,
	[NombreTipoVideoJuego] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TIPOVIDEOJUEGO] PRIMARY KEY CLUSTERED 
(
	[IDTipoJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
insert into TIPOVIDEOJUEGO values ('Accion');
insert into TIPOVIDEOJUEGO values ('Deportes');
insert into TIPOVIDEOJUEGO values ('Rol');
insert into TIPOVIDEOJUEGO values ('Estrategia');
insert into TIPOVIDEOJUEGO values ('Clasicos');
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 16/11/2020 00:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
insert into USUARIOS values ('sergio','sergio','Sergio','Cardozo');
insert into USUARIOS values ('fede','fede','Federico','Davila');
insert into USUARIOS values ('mauri','mauri','Mauricio','Cerizza');
insert into USUARIOS values ('lucas','lucas','Lucas','Rodriguez');
insert into USUARIOS values ('eze','eze','Ezequiel','Oggioni');
GO
/****** Object:  Table [dbo].[VENTAS]    Script Date: 16/11/2020 00:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTAS](
	[IDVentas] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NOT NULL,
	[IDJuego] [int] NOT NULL,
	[FechaVenta] [datetime] NOT NULL,
	[GananciaVenta] [float] NOT NULL,
 CONSTRAINT [PK_VENTAS] PRIMARY KEY CLUSTERED 
(
	[IDVentas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VIDEOJUEGOS]    Script Date: 16/11/2020 00:36:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIDEOJUEGOS](
	[IDVideoJuego] [int] IDENTITY(1,1) NOT NULL,
	[NombreVideoJuego] [varchar](max) NOT NULL,
	[Precio] [float] NOT NULL,
	[Stock] [int] NOT NULL,
	[IDTipoVideoJuego] [int] NOT NULL,
 CONSTRAINT [PK_VIDEOJUEGOS] PRIMARY KEY CLUSTERED 
(
	[IDVideoJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
insert into VIDEOJUEGOS values ('ASSASSIN´S CREED CHRONICLES PS4 (1*)',9999.99,10,4);
insert into VIDEOJUEGOS values ('DRAGON BALL Z XENOVERSE 1+2 PS4 (2*)',2699.99,4,1);
insert into VIDEOJUEGOS values ('DEVIL MAY CRY 5 PS4 (2*)',2699.99,1,1);
insert into VIDEOJUEGOS values ('UNCHARTED REMASTERED PS4 (1*)',2699.99,2,1);
insert into VIDEOJUEGOS values ('FIFA 20 -PS5',7999.99,3,2);
insert into VIDEOJUEGOS values ('WATCHDOGS LEGION - PS4 FISICO',9999.99,3,1);
insert into VIDEOJUEGOS values ('FIFA 21 - PS4',9999.99,5,2);
insert into VIDEOJUEGOS values ('THE LAST OF US: PARTE II - PS4 FISICO',4399.99,5,1);
insert into VIDEOJUEGOS values ('ASSASSIN`S CREED VALHALLA',1499.99,5,3);
insert into VIDEOJUEGOS values ('CALL OF DUTY BLACK OPS COLD WAR',6999.99,3,1);
insert into VIDEOJUEGOS values ('BLOODBORNE',1499.99,1,2);
insert into VIDEOJUEGOS values ('GRAN TURISMO SPORT',9999.99,10,4);
insert into VIDEOJUEGOS values ('FIFA 21',4899.99,6,2);
insert into VIDEOJUEGOS values ('MORTAL KOMBAT ULTIMATE',9999.99,2,1);
insert into VIDEOJUEGOS values ('GTA V',2399.99,2,1);
insert into VIDEOJUEGOS values ('CALL OF DUTY MODERN WARFARE',6999.99,5,1);
insert into VIDEOJUEGOS values ('MARIO BROSS FAMILY',999.99,4,5);

