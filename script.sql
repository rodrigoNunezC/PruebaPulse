USE [PruebaPulse]
GO
/****** Object:  Table [dbo].[Estado_Invitado]    Script Date: 08-05-2019 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Invitado](
	[Nombre] [varchar](100) NULL,
	[Id] [int] NOT NULL,
 CONSTRAINT [PK_Estado_Invitado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 08-05-2019 16:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento](
	[Titulo] [varchar](100) NULL,
	[Descripcion] [varchar](500) NULL,
	[FechaInicio] [date] NULL,
	[CreadoPor] [uniqueidentifier] NULL,
	[Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invitado]    Script Date: 08-05-2019 16:20:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invitado](
	[Id] [uniqueidentifier] NOT NULL,
	[Correo] [varchar](100) NULL,
	[EventoId] [uniqueidentifier] NULL,
	[EstadoId] [int] NULL,
 CONSTRAINT [PK_Invitado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 08-05-2019 16:20:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombres] [varchar](100) NULL,
	[ApellidoPaterno] [varchar](100) NULL,
	[Correo] [varchar](100) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Estado_Invitado] ([Nombre], [Id]) VALUES (N'Sin Selección', 1)
INSERT [dbo].[Estado_Invitado] ([Nombre], [Id]) VALUES (N'Asistire', 2)
INSERT [dbo].[Estado_Invitado] ([Nombre], [Id]) VALUES (N'No Asistire', 3)
INSERT [dbo].[Evento] ([Titulo], [Descripcion], [FechaInicio], [CreadoPor], [Id]) VALUES (N'Reunion de avance de proyecto', N'Se hablara del tema test1', CAST(N'2019-05-08' AS Date), N'401ad98b-ddde-41a4-89df-8bca94169253', N'94b04b4c-c9de-4be4-8ebf-8ca69692ab06')
INSERT [dbo].[Invitado] ([Id], [Correo], [EventoId], [EstadoId]) VALUES (N'8f7a6081-f921-4ceb-a9bc-92a613c78534', N'marcelo.a@gmail.com', N'94b04b4c-c9de-4be4-8ebf-8ca69692ab06', 1)
INSERT [dbo].[Usuario] ([Id], [Nombres], [ApellidoPaterno], [Correo]) VALUES (N'401ad98b-ddde-41a4-89df-8bca94169253', N'Rodrigo Alejandro', N'Nuñez', N'r.nunezcabrera@gmail.com')
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Usuario] FOREIGN KEY([CreadoPor])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Usuario]
GO
ALTER TABLE [dbo].[Invitado]  WITH CHECK ADD  CONSTRAINT [FK_Invitado_Estado_Invitado1] FOREIGN KEY([EstadoId])
REFERENCES [dbo].[Estado_Invitado] ([Id])
GO
ALTER TABLE [dbo].[Invitado] CHECK CONSTRAINT [FK_Invitado_Estado_Invitado1]
GO
ALTER TABLE [dbo].[Invitado]  WITH CHECK ADD  CONSTRAINT [FK_Invitado_Evento] FOREIGN KEY([EventoId])
REFERENCES [dbo].[Evento] ([Id])
GO
ALTER TABLE [dbo].[Invitado] CHECK CONSTRAINT [FK_Invitado_Evento]
GO
