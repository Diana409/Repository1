USE [master]
GO
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 12/02/2016 11:53:35 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'×LtüÉÕ	÷j)<¯A6~äuÁò äù{«)>ò', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 12/02/2016 11:53:35 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'¾D«}''(mØD^aP`GûÂ÷ n¸LG
Z«¾Q', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/****** Object:  Login [Adm]    Script Date: 12/02/2016 11:53:35 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Adm] WITH PASSWORD=N'!Õ³tÂ1þ=S·Û[=ñä>±øá¢²z¢', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Adm] DISABLE
GO
/****** Object:  Login [Admin123]    Script Date: 12/02/2016 11:53:35 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Admin123] WITH PASSWORD=N'æ	k|bìÂVÈD¾¼EAÆëÂX­æ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Admin123] DISABLE
GO
/****** Object:  Login [BUILTIN\Пользователи]    Script Date: 12/02/2016 11:53:35 ******/
CREATE LOGIN [BUILTIN\Пользователи] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [Dmitrov]    Script Date: 12/02/2016 11:53:35 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Dmitrov] WITH PASSWORD=N')F1ÚNêì3áÁÎYKd;¼]%4¼ýV', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Dmitrov] DISABLE
GO
/****** Object:  Login [Dolina]    Script Date: 12/02/2016 11:53:35 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Dolina] WITH PASSWORD=N'ÓÔïÑg¨Þ`RN|ÖNºh=}ô|öâ&×²`', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Dolina] DISABLE
GO
/****** Object:  Login [Gribov]    Script Date: 12/02/2016 11:53:36 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Gribov] WITH PASSWORD=N'ªÑT4(ÀÎ{9ãlºi÷Øê@çR*ÛêÑ''', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Gribov] DISABLE
GO
/****** Object:  Login [HOME-2\Диана]    Script Date: 12/02/2016 11:53:36 ******/
CREATE LOGIN [HOME-2\Диана] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [Ivanov]    Script Date: 12/02/2016 11:53:36 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Ivanov] WITH PASSWORD=N'óë·-æ@ís«&ûl¿Z<g¡`¼õÇ)]ì®', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Ivanov] DISABLE
GO
/****** Object:  Login [NT AUTHORITY\NETWORK SERVICE]    Script Date: 12/02/2016 11:53:36 ******/
CREATE LOGIN [NT AUTHORITY\NETWORK SERVICE] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT AUTHORITY\система]    Script Date: 12/02/2016 11:53:36 ******/
CREATE LOGIN [NT AUTHORITY\система] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT SERVICE\MSSQLSERVER]    Script Date: 12/02/2016 11:53:36 ******/
CREATE LOGIN [NT SERVICE\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [Petrov]    Script Date: 12/02/2016 11:53:36 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Petrov] WITH PASSWORD=N'*¾ñ`
 °<´ÀT¿}?ÜÉ¦çt°Ô¢¤', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Petrov] DISABLE
GO
/****** Object:  Login [Smirnov]    Script Date: 12/02/2016 11:53:36 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Smirnov] WITH PASSWORD=N'ÿÞAÅÍ>ð
!´|óÃtÆ|È;8»1§W', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Smirnov] DISABLE
GO
/****** Object:  Login [Titova]    Script Date: 12/02/2016 11:53:36 ******/
/* For security reasons the login is created disabled and with a random password. */
CREATE LOGIN [Titova] WITH PASSWORD=N'úìì(àcgû$8xn[<ücë¨[', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Titova] DISABLE
GO
USE [SalesBuns]
GO
/****** Object:  User [Adm]    Script Date: 12/02/2016 11:53:35 ******/
CREATE USER [Adm] FOR LOGIN [Adm] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Dolina]    Script Date: 12/02/2016 11:53:35 ******/
CREATE USER [Dolina] FOR LOGIN [Dolina] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Gribov]    Script Date: 12/02/2016 11:53:35 ******/
CREATE USER [Gribov] FOR LOGIN [Gribov] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Petrov]    Script Date: 12/02/2016 11:53:35 ******/
CREATE USER [Petrov] FOR LOGIN [Petrov] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Smirnov]    Script Date: 12/02/2016 11:53:35 ******/
CREATE USER [Smirnov] FOR LOGIN [Smirnov] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Role [Director]    Script Date: 12/02/2016 11:53:35 ******/
CREATE ROLE [Director] AUTHORIZATION [dbo]
GO
/****** Object:  Role [Manager]    Script Date: 12/02/2016 11:53:35 ******/
CREATE ROLE [Manager] AUTHORIZATION [dbo]
GO
/****** Object:  Table [dbo].[TypesBuns]    Script Date: 12/02/2016 11:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TypesBuns](
	[id_typesBuns] [int] IDENTITY(1,1) NOT NULL,
	[typeBuns_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_typesBuns] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[typeBuns_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[typeBuns_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[typeBuns_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[typeBuns_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TypesBuns] ON
INSERT [dbo].[TypesBuns] ([id_typesBuns], [typeBuns_name]) VALUES (2, N'Булочки')
INSERT [dbo].[TypesBuns] ([id_typesBuns], [typeBuns_name]) VALUES (4, N'Печенье')
INSERT [dbo].[TypesBuns] ([id_typesBuns], [typeBuns_name]) VALUES (5, N'Пироги')
INSERT [dbo].[TypesBuns] ([id_typesBuns], [typeBuns_name]) VALUES (3, N'Пирожки')
INSERT [dbo].[TypesBuns] ([id_typesBuns], [typeBuns_name]) VALUES (1, N'Слойки')
SET IDENTITY_INSERT [dbo].[TypesBuns] OFF
/****** Object:  Table [dbo].[Clients]    Script Date: 12/02/2016 11:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clients](
	[id_clients] [int] IDENTITY(1,1) NOT NULL,
	[client_surname] [varchar](50) NOT NULL,
	[client_name] [varchar](50) NOT NULL,
	[client_patronymic] [varchar](50) NOT NULL,
	[client_phone] [nvarchar](50) NULL,
 CONSTRAINT [PK__Clients__677F38831920BF5C] PRIMARY KEY CLUSTERED 
(
	[id_clients] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON
INSERT [dbo].[Clients] ([id_clients], [client_surname], [client_name], [client_patronymic], [client_phone]) VALUES (1, N'Розница', N'', N'', N'')
INSERT [dbo].[Clients] ([id_clients], [client_surname], [client_name], [client_patronymic], [client_phone]) VALUES (2, N'Арофеева', N'Мария', N'Сергеевна', N'121-212 -  -')
INSERT [dbo].[Clients] ([id_clients], [client_surname], [client_name], [client_patronymic], [client_phone]) VALUES (3, N'Епифанцев', N'Дмитрий', N'Олегович', N'8-800-55-35-35')
INSERT [dbo].[Clients] ([id_clients], [client_surname], [client_name], [client_patronymic], [client_phone]) VALUES (4, N'Летающий-Бизон', N'Аппа', N'Аангович', N'   -    -  -')
INSERT [dbo].[Clients] ([id_clients], [client_surname], [client_name], [client_patronymic], [client_phone]) VALUES (7, N'Семенов', N'Максим', N'Викторович', N'   -    -  -')
INSERT [dbo].[Clients] ([id_clients], [client_surname], [client_name], [client_patronymic], [client_phone]) VALUES (8, N'Яков', N'Сергей', N'Генадьевич', N'121-212 -  -')
SET IDENTITY_INSERT [dbo].[Clients] OFF
/****** Object:  Table [dbo].[Managers]    Script Date: 12/02/2016 11:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Managers](
	[id_managers] [int] IDENTITY(1,1) NOT NULL,
	[manager_surname] [varchar](50) NOT NULL,
	[manager_name] [varchar](50) NOT NULL,
	[manager_patronymic] [varchar](50) NOT NULL,
	[manager_dateOfBirth] [date] NOT NULL,
	[manager_login] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_managers] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Managers] ON
INSERT [dbo].[Managers] ([id_managers], [manager_surname], [manager_name], [manager_patronymic], [manager_dateOfBirth], [manager_login]) VALUES (1, N'Смирнов', N'Моисей', N'Яковлевич', CAST(0x10EC0A00 AS Date), N'Smirnov')
INSERT [dbo].[Managers] ([id_managers], [manager_surname], [manager_name], [manager_patronymic], [manager_dateOfBirth], [manager_login]) VALUES (2, N'Долина', N'Анна', N'Алексеевна', CAST(0xF9070B00 AS Date), N'Dolina')
INSERT [dbo].[Managers] ([id_managers], [manager_surname], [manager_name], [manager_patronymic], [manager_dateOfBirth], [manager_login]) VALUES (3, N'Петров', N'Павел', N'Панфилович', CAST(0xF2060B00 AS Date), N'Petrov')
SET IDENTITY_INSERT [dbo].[Managers] OFF
/****** Object:  StoredProcedure [dbo].[TypesBuns_Update]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TypesBuns_Update] (
@typeBunsId int,
@typeBuns nvarchar(50))
AS
BEGIN
SET NOCOUNT ON
UPDATE [TypesBuns]
SET 
typeBuns_name = @typeBuns
WHERE id_typesBuns = @typeBunsId
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[TypesBuns_Select]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TypesBuns_Select](@typesBunsId int = NULL)
AS
BEGIN
SET NOCOUNT ON
SELECT id_typesBuns As [№],
typeBuns_name As[Тип изделия]
FROM [TypesBuns]
WHERE
@typesBunsId IS NULL OR dbo.TypesBuns.id_typesBuns=@typesBunsId
END
GO
/****** Object:  StoredProcedure [dbo].[TypesBuns_Insert]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TypesBuns_Insert] (
@typeBuns nvarchar(50))
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [TypesBuns] (
typeBuns_name)
VALUES (
@typeBuns)
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[TypesBuns_Delete]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TypesBuns_Delete] (@typesBunsId int = NULL)
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[TypesBuns]
WHERE id_typesBuns = @typesBunsId
RETURN @@ERROR
END
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/02/2016 11:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id_orders] [int] IDENTITY(1,1) NOT NULL,
	[id_clients] [int] NULL,
	[id_managers] [int] NOT NULL,
	[cost] [money] NULL,
	[order_date] [date] NOT NULL,
	[deliveryTime] [date] NOT NULL,
	[done] [bit] NOT NULL,
 CONSTRAINT [PK__Orders__6219333D1CF15040] PRIMARY KEY CLUSTERED 
(
	[id_orders] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (1, 1, 2, 537.0000, CAST(0x083C0B00 AS Date), CAST(0x083C0B00 AS Date), 1)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (2, 1, 1, 111.0000, CAST(0x183B0B00 AS Date), CAST(0x153C0B00 AS Date), 1)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (4, 3, 1, 56.0000, CAST(0xFA3A0B00 AS Date), CAST(0xFA3A0B00 AS Date), 1)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (5, 1, 3, 760.0000, CAST(0x41360B00 AS Date), CAST(0x42360B00 AS Date), 1)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (7, 2, 2, 1020.0000, CAST(0xF3340B00 AS Date), CAST(0xF3340B00 AS Date), 1)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (8, 1, 2, 40.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (10, 1, 2, 20.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (12, 1, 1, 28.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (14, 1, 2, 100.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (15, 1, 2, 28.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (16, 1, 1, 20.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (17, 4, 1, 1278.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 1)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (18, 3, 2, 68.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (19, 3, 3, 40.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (20, 3, 2, 94.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (21, 2, 2, 28.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (26, 4, 2, 40.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (27, 7, 2, 40.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (29, 3, 2, 90.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (30, 3, 2, 28.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (31, 3, 2, 40.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
INSERT [dbo].[Orders] ([id_orders], [id_clients], [id_managers], [cost], [order_date], [deliveryTime], [done]) VALUES (32, 3, 2, 40.0000, CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date), 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  StoredProcedure [dbo].[Managers_Update]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Managers_Update] (
@managersId int,
@surname nvarchar(50),
@name nvarchar(50),
@patronymic nvarchar(50),
@dateOfBirth date)
AS
BEGIN
SET NOCOUNT ON
Update [Managers]
SET
manager_surname = @surname,
manager_name = @name,
manager_patronymic = @patronymic,
manager_dateOfBirth = @dateOfBirth
WHERE id_managers = @managersId
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Managers_Select]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Managers_Select](@ManagersId int = NULL)
AS
BEGIN
SET NOCOUNT ON
SELECT  id_managers AS [№], manager_surname AS Фамилия, manager_name AS Имя, manager_patronymic AS Отчество, 
               manager_dateOfBirth AS [Дата рождения]
FROM [dbo].[Managers]
WHERE
@ManagersId IS NULL OR dbo.Managers.id_managers = @ManagersId
END
GO
/****** Object:  StoredProcedure [dbo].[Managers_Insert]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Managers_Insert] (
@surname nvarchar(50),
@name nvarchar(50),
@patronymic nvarchar(50),
@dateOfBirth date)
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [Managers] (
manager_surname,
manager_name,
manager_patronymic,
manager_dateOfBirth)
VALUES (
@surname,
@name,
@patronymic,
@dateOfBirth)
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Managers_Delete]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Managers_Delete] (@managerId int = NULL)
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[Managers]
WHERE id_Managers = @managerId
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Clients_Update]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clients_Update] (
@clientsId int,
@surname nvarchar(50),
@name nvarchar(50),
@patronymic nvarchar(50),
@phone nvarchar(50)= NULL)
AS
BEGIN
SET NOCOUNT ON
Update [Clients] 
SET
client_surname = @surname,
client_name = @name,
client_patronymic = @patronymic,
client_phone = @phone
WHERE id_clients = @clientsId
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Clients_Select]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clients_Select](@clientsId int = NULL)
AS
BEGIN
SET NOCOUNT ON
SELECT id_clients AS [№], client_surname AS Фамилия, client_name AS Имя, client_patronymic AS Отчество, client_phone AS Телефон
FROM [dbo].[Clients]
WHERE 
@clientsId IS NULL OR dbo.Clients.id_clients=@clientsId
END
GO
/****** Object:  StoredProcedure [dbo].[Clients_Insert]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clients_Insert] (
@surname nvarchar(50),
@name nvarchar(50),
@patronymic nvarchar(50),
@phone nvarchar(50)= NULL)
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [Clients] (
client_surname,
client_name,
client_patronymic,
client_phone)
VALUES (
@surname,
@name,
@patronymic,
@phone)
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Clients_Delete]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clients_Delete] (@clientId int = NULL)
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[Clients]
WHERE id_clients = @clientId
RETURN @@ERROR
END
GO
/****** Object:  Table [dbo].[Buns]    Script Date: 12/02/2016 11:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Buns](
	[id_buns] [int] IDENTITY(1,1) NOT NULL,
	[id_typeBuns] [int] NOT NULL,
	[buns_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_buns] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[buns_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[buns_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[buns_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[buns_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Buns] ON
INSERT [dbo].[Buns] ([id_buns], [id_typeBuns], [buns_name]) VALUES (1, 1, N'с изюмом')
INSERT [dbo].[Buns] ([id_buns], [id_typeBuns], [buns_name]) VALUES (2, 1, N'с курицей')
INSERT [dbo].[Buns] ([id_buns], [id_typeBuns], [buns_name]) VALUES (3, 2, N'с мясом')
INSERT [dbo].[Buns] ([id_buns], [id_typeBuns], [buns_name]) VALUES (4, 3, N'с картошкой')
INSERT [dbo].[Buns] ([id_buns], [id_typeBuns], [buns_name]) VALUES (5, 5, N'сладкий')
INSERT [dbo].[Buns] ([id_buns], [id_typeBuns], [buns_name]) VALUES (6, 4, N'Лорд огня')
INSERT [dbo].[Buns] ([id_buns], [id_typeBuns], [buns_name]) VALUES (8, 4, N'Юбилейное')
INSERT [dbo].[Buns] ([id_buns], [id_typeBuns], [buns_name]) VALUES (9, 3, N'Капустница')
SET IDENTITY_INSERT [dbo].[Buns] OFF
/****** Object:  StoredProcedure [dbo].[Buns_Update]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Buns_Update] (
@bunsId int,
@typeBunsId int,
@name nvarchar(50)
)
AS
BEGIN
SET NOCOUNT ON
UPDATE [Buns]
SET 
id_typeBuns = @typeBunsId,
buns_name = @name
WHERE id_buns = @bunsId
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Buns_Select]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Buns_Select] (
@bunsId int = NULL,
@typeBunsId int = NULL)
AS
BEGIN
SET NOCOUNT ON
SELECT
dbo.Buns.id_buns As [№],
dbo.Buns.buns_name As [Наименование],
dbo.TypesBuns.typeBuns_name As [Тип изделия]
FROM dbo.Buns
LEFT OUTER JOIN dbo.TypesBuns ON dbo.TypesBuns.id_typesBuns=dbo.Buns.id_typeBuns
WHERE
(@bunsId IS NULL OR dbo.Buns.id_buns = @bunsId) AND
(@typeBunsId IS NULL OR dbo.TypesBuns.id_typesBuns = @typeBunsId)
END
GO
/****** Object:  StoredProcedure [dbo].[Buns_Insert]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Buns_Insert] (
@typeBunsId int,
@name nvarchar(50)
)
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [Buns] (
id_typeBuns,
buns_name)
VALUES (
@typeBunsId,
@name)
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Buns_Delete]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Buns_Delete] (@bunsId int = NULL)
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [Buns]
WHERE [id_buns] = @bunsId
RETURN @@ERROR
END
GO
/****** Object:  Table [dbo].[Price]    Script Date: 12/02/2016 11:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Price](
	[id_price] [int] IDENTITY(1,1) NOT NULL,
	[id_buns] [int] NOT NULL,
	[price] [money] NOT NULL,
	[price_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_price] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Price] ON
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (1, 1, 123.0000, CAST(0x883A0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (2, 2, 15.0000, CAST(0x883A0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (3, 2, 37.0000, CAST(0x563B0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (4, 3, 45.0000, CAST(0x793B0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (5, 4, 42.0000, CAST(0x013B0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (6, 3, 32.0000, CAST(0x983B0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (7, 4, 28.0000, CAST(0x983B0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (8, 5, 28.0000, CAST(0x993B0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (10, 1, 20.0000, CAST(0xF63B0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (12, 6, 500.0000, CAST(0x273C0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (13, 9, 20.0000, CAST(0x213C0B00 AS Date))
INSERT [dbo].[Price] ([id_price], [id_buns], [price], [price_date]) VALUES (14, 8, 45.0000, CAST(0x213C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Price] OFF
/****** Object:  Trigger [OrdersTrUpdate]    Script Date: 12/02/2016 11:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[OrdersTrUpdate] 
   ON  [dbo].[Orders]
   after UPDATE
AS 
BEGIN
	
	if exists (select *
				from				
				 dbo.Orders inner join 
				inserted 
				on orders.id_orders=inserted.id_orders
				where 
				orders.order_date>inserted.deliveryTime)
		begin

			print 'Дата сдачи заказа должна быть позже даты совершения заказа'
			rollback transaction
			end
		else
		begin transaction
			update dbo.Orders
			set orders.deliveryTime=inserted.deliveryTime
			from dbo.Orders inner join 
			inserted on orders.id_orders=inserted.id_orders
		COMMIT TRANSACTION				
	
END
GO
/****** Object:  Trigger [OrdersTrInsert]    Script Date: 12/02/2016 11:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[OrdersTrInsert] 
   ON  [dbo].[Orders]
   after Insert
AS 
BEGIN
	
	if exists (select *
				from				
				 dbo.Orders inner join 
				inserted 
				on orders.id_orders=inserted.id_orders
				where 
				orders.order_date>inserted.deliveryTime)
		begin

			print 'Дата сдачи заказа должна быть позже даты совершения заказа'
			rollback transaction
			end
		else
		begin transaction
			update dbo.Orders
			set orders.deliveryTime=inserted.deliveryTime
			from dbo.Orders inner join 
			inserted on orders.id_orders=inserted.id_orders
		COMMIT TRANSACTION				
	
END
GO
/****** Object:  StoredProcedure [dbo].[Orders_Update]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Orders_Update] (
@ordersId int,
@managersId int,
@clientsId int = NULL,
@orderDate date,
@cost money = null,
@done bit = NULL,
@deliveryTime date = NULL
)
AS
BEGIN
SET NOCOUNT ON
Update [Orders] 
SET
id_clients = @clientsId,
id_managers = @managersId,
order_date = @orderDate,
deliveryTime = @deliveryTime,
done = @done
WHERE id_orders = @ordersId AND ((@cost Is NOT null)AND(cost=@cost))
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Orders_Select]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Orders_Select](
@ordersId int = NULL)
AS
BEGIN
SET NOCOUNT ON
SELECT
[dbo].[Orders].id_orders As [№],
[dbo].[Managers].manager_surname+' '+[dbo].[Managers].manager_name+' '+[dbo].[Managers].manager_patronymic As [ФИО менеджера],
 dbo.Clients.client_surname+' '+[dbo].[Clients].client_name+' '+[dbo].[Clients].client_patronymic As [ФИОклиента],
[dbo].[Orders].order_date As [дата заказа],
[dbo].[Orders].cost As [Стоимость],
[dbo].[Orders].done As [Выполнено],
[dbo].[Orders].deliveryTime As [Дата сдачи]

FROM [dbo].[Orders]
LEFT JOIN [dbo].[Managers] ON [dbo].[Managers].id_managers=[dbo].[Orders].id_managers 
LEFT JOIN dbo.Clients ON dbo.Orders.id_clients=dbo.Clients.id_clients
WHERE
(@ordersId IS NULL OR [dbo].[Orders].id_orders = @ordersId)
END
GO
/****** Object:  StoredProcedure [dbo].[Orders_Insert]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Orders_Insert] (
@managersId int,
@clientsId int = NULL,
@orderDate date,
@cost MONEY  = NULL,
@done bit = NULL,
@deliveryTime date = NULL
)
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [Orders] (
id_clients,
id_managers,
cost,
order_date,
deliveryTime,
done)
VALUES (
@clientsId,
@managersId,
@cost,
@orderDate,
@deliveryTime,
@done )
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Orders_Delete]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Orders_Delete] (@orderId int = NULL)
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[Orders]
WHERE id_orders = @orderId
RETURN @@ERROR
END
GO
/****** Object:  View [dbo].[PriceBuns]    Script Date: 12/02/2016 11:53:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PriceBuns]
AS
SELECT dbo.Price.price AS Цена, dbo.Buns.id_buns
FROM  dbo.Price INNER JOIN
               dbo.Buns ON dbo.Price.id_buns = dbo.Buns.id_buns
WHERE (dbo.Price.price_date =
                   (SELECT MAX(price_date) AS maxDate
                    FROM   dbo.Price AS price2
                    WHERE (id_buns = dbo.Price.id_buns)))
GROUP BY dbo.Price.id_buns, dbo.Price.price, dbo.Buns.id_buns
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[12] 2[29] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Price"
            Begin Extent = 
               Top = 5
               Left = 105
               Bottom = 146
               Right = 311
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Buns"
            Begin Extent = 
               Top = 7
               Left = 556
               Bottom = 130
               Right = 762
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PriceBuns'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PriceBuns'
GO
/****** Object:  StoredProcedure [dbo].[Price_Update]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Price_Update] (
@priceId int,
@bunsId int,
@cost money,
@dateInstallationCost date
)
AS
BEGIN
SET NOCOUNT ON
UPDATE [Price] 
SET
id_buns = @bunsId,
price = @cost,
price_date = @dateInstallationCost
WHERE id_price = @priceId
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Price_Select]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Price_Select](
@priceId int = NULL,
@bunsId int = NULL)
AS
BEGIN
SET NOCOUNT ON
SELECT dbo.Price.id_price AS [№], dbo.TypesBuns.typeBuns_name AS [Тип изделия], dbo.Buns.buns_name AS Изделие, dbo.Price.price AS Цена, 
               dbo.Price.price_date AS [Дата установки]
FROM  dbo.Price INNER JOIN
               dbo.Buns ON dbo.Price.id_buns = dbo.Buns.id_buns INNER JOIN
               dbo.TypesBuns ON dbo.Buns.id_typeBuns = dbo.TypesBuns.id_typesBuns AND dbo.Buns.id_typeBuns = dbo.TypesBuns.id_typesBuns
WHERE
(@priceId IS NULL OR [dbo].[Price].id_price = @priceId) AND
(@bunsId IS NULL OR [dbo].[Buns].id_buns = @bunsId)
END
GO
/****** Object:  StoredProcedure [dbo].[Price_Insert]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Price_Insert] (
@bunsId int,
@cost money,
@dateInstallationCost date
)
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [Price] (
id_buns,
price,
price_date)
VALUES (
@bunsId,
@cost,
@dateInstallationCost)
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[Price_Delete]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Price_Delete] (@priceId int = NULL)
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[Price]
WHERE id_price = @priceId
RETURN @@ERROR
END
GO
/****** Object:  Table [dbo].[OrdersBuns]    Script Date: 12/02/2016 11:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersBuns](
	[id_ordersBuns] [int] IDENTITY(1,1) NOT NULL,
	[id_buns] [int] NOT NULL,
	[id_orders] [int] NOT NULL,
	[quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ordersBuns] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OrdersBuns] ON
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (1, 2, 1, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (2, 6, 1, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (4, 2, 2, 3)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (6, 5, 4, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (13, 5, 5, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (14, 3, 5, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (16, 6, 5, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (17, 4, 5, 5)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (21, 1, 16, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (23, 1, 17, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (24, 3, 17, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (25, 2, 17, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (26, 1, 17, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (27, 1, 17, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (29, 6, 17, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (30, 1, 17, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (31, 4, 18, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (33, 1, 18, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (34, 6, 7, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (35, 1, 7, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (36, 1, 8, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (38, 1, 20, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (39, 2, 20, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (40, 5, 21, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (41, 1, 26, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (42, 1, 27, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (43, 4, 15, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (46, 1, 10, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (47, 8, 29, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (48, 5, 12, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (49, 4, 30, 1)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (50, 1, 31, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (51, 1, 32, 2)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (53, 1, 14, 5)
INSERT [dbo].[OrdersBuns] ([id_ordersBuns], [id_buns], [id_orders], [quantity]) VALUES (56, 1, 19, 2)
SET IDENTITY_INSERT [dbo].[OrdersBuns] OFF
/****** Object:  Trigger [OrdersBunsTrUpdate]    Script Date: 12/02/2016 11:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[OrdersBunsTrUpdate] 
   ON  [dbo].[OrdersBuns]
   after UPDATE
AS 
BEGIN										
	/*IF exists (SELECT dbo.OrdersBuns.id_orders, SUM(dbo.OrdersBuns.quantity * dbo.Price.price) AS priceOrder
			FROM  dbo.OrdersBuns INNER JOIN
				   dbo.Price ON dbo.OrdersBuns.id_buns = dbo.Price.id_buns
			WHERE dbo.Price.price_date =
					   (SELECT MAX(price_date) AS maxDate
						FROM   dbo.Price AS price2
						WHERE (id_buns = dbo.Price.id_buns)
						)
			GROUP BY dbo.OrdersBuns.id_orders)
						
	BEGIN
		print 'Возможно не указана цена у булочного изделия'
		rollback transaction
		end													
	ELSE
	begin transaction
		update dbo.Orders
		set orders.cost=(
			SELECT dbo.OrdersBuns.id_orders, SUM(dbo.OrdersBuns.quantity * dbo.Price.price) AS priceOrder
			FROM  dbo.OrdersBuns INNER JOIN
				   dbo.Price ON dbo.OrdersBuns.id_buns = dbo.Price.id_buns
			WHERE dbo.OrdersBuns.id_orders=dbo.Orders.id_orders AND dbo.Price.price_date =
					   (SELECT MAX(price_date) AS maxDate
						FROM   dbo.Price AS price2
						WHERE (id_buns = dbo.Price.id_buns))
			GROUP BY dbo.OrdersBuns.id_orders)*/
			
			Create table #CostTable  (id_costTable  int ,priceCost int )
			Insert #CostTable 
			SELECT dbo.OrdersBuns.id_orders, SUM(dbo.OrdersBuns.quantity * dbo.Price.price) AS priceOrder
			FROM  dbo.OrdersBuns INNER JOIN
				   dbo.Price ON dbo.OrdersBuns.id_buns = dbo.Price.id_buns
			WHERE dbo.Price.price_date =
					   (SELECT MAX(price_date) AS maxDate
						FROM   dbo.Price AS price2
						WHERE (id_buns = dbo.Price.id_buns))
			GROUP BY dbo.OrdersBuns.id_orders
			
			
			update dbo.Orders
			set orders.cost = #CostTable.priceCost
			from  dbo.Orders inner join  #CostTable ON dbo.Orders.id_orders=#CostTable.id_costTable
			
			
	
	/*COMMIT TRANSACTION*/				 
END
GO
/****** Object:  Trigger [OrdersBunsTrInsert]    Script Date: 12/02/2016 11:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[OrdersBunsTrInsert] 
   ON  [dbo].[OrdersBuns]
   after Insert
AS 
BEGIN
			
			Create table #CostTable  (id_costTable  int ,priceCost int )
			Insert #CostTable 
			SELECT dbo.OrdersBuns.id_orders, SUM(dbo.OrdersBuns.quantity * dbo.Price.price) AS priceOrder
			FROM  dbo.OrdersBuns INNER JOIN
				   dbo.Price ON dbo.OrdersBuns.id_buns = dbo.Price.id_buns
			WHERE dbo.Price.price_date =
					   (SELECT MAX(price_date) AS maxDate
						FROM   dbo.Price AS price2
						WHERE (id_buns = dbo.Price.id_buns))
			GROUP BY dbo.OrdersBuns.id_orders
			
			
			update dbo.Orders
			set orders.cost = #CostTable.priceCost
			from  dbo.Orders inner join  #CostTable ON dbo.Orders.id_orders=#CostTable.id_costTable
					 
END
GO
/****** Object:  StoredProcedure [dbo].[OrdersBuns_Update]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrdersBuns_Update] (
@ordersBunsId int,
@bunsId int,
@ordersId int,
@quantity int
)
AS
BEGIN
SET NOCOUNT ON
Update [OrdersBuns]
SET
id_buns = @bunsId,
id_orders = @ordersId,
quantity =  @quantity
WHERE id_ordersBuns = @ordersBunsId
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[OrdersBuns_Select]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrdersBuns_Select](
@ordersId int = NULL, @ordersBunsId int = NULL)
AS
BEGIN
SET NOCOUNT ON
SELECT dbo.OrdersBuns.id_ordersBuns, TypesBuns.typeBuns_name AS [Тип изделия], dbo.Buns.buns_name AS Изделие, dbo.Price.price AS Цена, 
               dbo.OrdersBuns.quantity AS Количество
FROM  dbo.OrdersBuns INNER JOIN
               dbo.Price ON dbo.OrdersBuns.id_buns = dbo.Price.id_buns INNER JOIN
               dbo.Buns ON dbo.OrdersBuns.id_buns = dbo.Buns.id_buns AND dbo.Price.id_buns = dbo.Buns.id_buns INNER JOIN
               dbo.TypesBuns ON dbo.Buns.id_typeBuns = dbo.TypesBuns.id_typesBuns AND dbo.Buns.id_typeBuns = dbo.TypesBuns.id_typesBuns
WHERE (dbo.Price.price_date =
                   (
						SELECT MAX(price_date) AS maxDate
						FROM   dbo.Price AS price2
						WHERE (id_buns = dbo.Price.id_buns)
                    )
       )AND (@ordersId IS NULL OR dbo.OrdersBuns.id_orders = @ordersId)AND (@ordersBunsId IS NULL OR dbo.OrdersBuns.id_ordersBuns = @ordersBunsId)
GROUP BY dbo.Price.id_buns, dbo.Price.price, dbo.TypesBuns.typeBuns_name, dbo.Buns.buns_name, dbo.OrdersBuns.quantity, dbo.OrdersBuns.id_ordersBuns

END
GO
/****** Object:  StoredProcedure [dbo].[OrdersBuns_Insert]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrdersBuns_Insert] (
@bunsId int,
@ordersId int,
@quantity int
)
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [OrdersBuns] (
id_buns,
id_orders,
quantity )
VALUES (
@bunsId,
@ordersId,
@quantity )
RETURN @@ERROR
END
GO
/****** Object:  StoredProcedure [dbo].[OrdersBuns_Delete]    Script Date: 12/02/2016 11:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrdersBuns_Delete] (@orderBunsId int = NULL, @ordersId int = null)
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[OrdersBuns]
WHERE  id_ordersBuns = @orderBunsId OR id_orders = @ordersId
RETURN @@ERROR
END
GO
/****** Object:  ForeignKey [FK__Buns__id_typeBun__0AD2A005]    Script Date: 12/02/2016 11:53:33 ******/
ALTER TABLE [dbo].[Buns]  WITH CHECK ADD FOREIGN KEY([id_typeBuns])
REFERENCES [dbo].[TypesBuns] ([id_typesBuns])
GO
/****** Object:  ForeignKey [FK__Buns__id_typeBun__73BA3083]    Script Date: 12/02/2016 11:53:33 ******/
ALTER TABLE [dbo].[Buns]  WITH CHECK ADD FOREIGN KEY([id_typeBuns])
REFERENCES [dbo].[TypesBuns] ([id_typesBuns])
GO
/****** Object:  ForeignKey [FK__Orders__id_clien__1ED998B2]    Script Date: 12/02/2016 11:53:33 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__id_clien__1ED998B2] FOREIGN KEY([id_clients])
REFERENCES [dbo].[Clients] ([id_clients])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__id_clien__1ED998B2]
GO
/****** Object:  ForeignKey [FK__Orders__id_manag__1FCDBCEB]    Script Date: 12/02/2016 11:53:33 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__id_manag__1FCDBCEB] FOREIGN KEY([id_managers])
REFERENCES [dbo].[Managers] ([id_managers])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__id_manag__1FCDBCEB]
GO
/****** Object:  ForeignKey [FK__OrdersBun__id_bu__74AE54BC]    Script Date: 12/02/2016 11:53:33 ******/
ALTER TABLE [dbo].[OrdersBuns]  WITH CHECK ADD FOREIGN KEY([id_buns])
REFERENCES [dbo].[Buns] ([id_buns])
GO
/****** Object:  ForeignKey [FK__OrdersBun__id_or__25869641]    Script Date: 12/02/2016 11:53:33 ******/
ALTER TABLE [dbo].[OrdersBuns]  WITH CHECK ADD  CONSTRAINT [FK__OrdersBun__id_or__25869641] FOREIGN KEY([id_orders])
REFERENCES [dbo].[Orders] ([id_orders])
GO
ALTER TABLE [dbo].[OrdersBuns] CHECK CONSTRAINT [FK__OrdersBun__id_or__25869641]
GO
/****** Object:  ForeignKey [FK__Price__id_buns__1273C1CD]    Script Date: 12/02/2016 11:53:33 ******/
ALTER TABLE [dbo].[Price]  WITH CHECK ADD FOREIGN KEY([id_buns])
REFERENCES [dbo].[Buns] ([id_buns])
GO
