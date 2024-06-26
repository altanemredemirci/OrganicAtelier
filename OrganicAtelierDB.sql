USE [master]
GO
/****** Object:  Database [OrganicAtelier]    Script Date: 22.06.2024 12:39:42 ******/
CREATE DATABASE [OrganicAtelier]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OrganicAtelier', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDERS\MSSQL\DATA\OrganicAtelier.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OrganicAtelier_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDERS\MSSQL\DATA\OrganicAtelier_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OrganicAtelier] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OrganicAtelier].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OrganicAtelier] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OrganicAtelier] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OrganicAtelier] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OrganicAtelier] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OrganicAtelier] SET ARITHABORT OFF 
GO
ALTER DATABASE [OrganicAtelier] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OrganicAtelier] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OrganicAtelier] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OrganicAtelier] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OrganicAtelier] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OrganicAtelier] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OrganicAtelier] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OrganicAtelier] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OrganicAtelier] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OrganicAtelier] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OrganicAtelier] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OrganicAtelier] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OrganicAtelier] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OrganicAtelier] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OrganicAtelier] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OrganicAtelier] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [OrganicAtelier] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OrganicAtelier] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OrganicAtelier] SET  MULTI_USER 
GO
ALTER DATABASE [OrganicAtelier] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OrganicAtelier] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OrganicAtelier] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OrganicAtelier] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OrganicAtelier] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OrganicAtelier] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [OrganicAtelier] SET QUERY_STORE = OFF
GO
USE [OrganicAtelier]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Abouts]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abouts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Abouts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Text] [nvarchar](2000) NULL,
	[Writer] [nvarchar](200) NULL,
	[Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Name] [nvarchar](100) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Comment] [nvarchar](2000) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](200) NULL,
	[Address] [nvarchar](100) NULL,
	[Phone] [nvarchar](13) NULL,
	[Email] [nvarchar](300) NULL,
	[Location] [nvarchar](max) NULL,
	[Twitter] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Instagram] [nvarchar](max) NULL,
	[LinkedIn] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Features]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Features](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Description] [nvarchar](300) NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Features] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mails]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](200) NULL,
	[Subject] [nvarchar](100) NULL,
	[Message] [nvarchar](500) NULL,
	[Read] [bit] NOT NULL,
	[SendDate] [datetime2](7) NOT NULL,
	[Reply] [bit] NOT NULL,
 CONSTRAINT [PK_Mails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetail]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_ProductDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Weight] [decimal](18, 2) NOT NULL,
	[Unit] [decimal](18, 2) NOT NULL,
	[Image] [nvarchar](200) NULL,
	[Status] [bit] NOT NULL,
	[IsPopular] [bit] NOT NULL,
	[ProductTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sliders]    Script Date: 22.06.2024 12:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sliders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title1] [nvarchar](100) NULL,
	[Title2] [nvarchar](100) NULL,
	[Description1] [nvarchar](200) NULL,
	[Description2] [nvarchar](200) NULL,
	[ImageUrl1] [nvarchar](max) NULL,
	[ImageUrl2] [nvarchar](max) NULL,
	[Page] [nvarchar](30) NULL,
 CONSTRAINT [PK_Sliders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240622093557_CreateDatabase', N'8.0.6')
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Title], [Description], [Image]) VALUES (5, N'Biz Kimiz?', N'Organik Atelier profesyonellerin yönettiği, kurumsallığı hedeflemiş bir firmadır. Gücünü, kurucu ortaklarının ve çalışanlarının "doğa” ve "insan” sevgisinden alır.', N'20240603104433440.png')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Title], [ImageUrl], [Text], [Writer], [Date]) VALUES (1, N'Sürdürülebilirlik Nedir?', N'blog-1.jpg', N'Sürdürülebilirlik, genellikle gelecek nesillerin kendi ihtiyaçlarını karşılama kabiliyetinden ödün vermeden kendi ihtiyaçlarımızı karşılamak olarak tanımlanır. Kaynakların sınırlı olduğunun bilinmesi esastır. Ayrıca kaynakların kullanılma biçimlerinin uzun vadeli sonuçlarının da akıllıca değerlendirilmesi gerekir.', N'Uğur Sevilgen', CAST(N'1996-07-09T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Blogs] ([Id], [Title], [ImageUrl], [Text], [Writer], [Date]) VALUES (3, N'Organik Tarım Nasıl Yapılır?', N'blog-2.jpg', N'Organik tarım yapılması için öncelikle arazinin belirli özelliklere sahip olması gerekir. Arazinin çöp depolama alanlarından, canlıların sağlığı üzerinde olumsuz etkiler bırakabilecek maddeler içeren akarsulardan ve yer altı sularından uzak olması gerekir. Aynı zamanda yakın çevrede işlek anayollar ve maden işletmeleri de olmamalıdır.', N'Fırat Pekgöz', CAST(N'2023-10-10T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Blogs] ([Id], [Title], [ImageUrl], [Text], [Writer], [Date]) VALUES (4, N'Nelere Dikkat Edilmelidir?', N'blog-3.jpg', N'Organik tarım yaparken dikkat edilmesi gereken önemli noktalar şu şekilde sıralanabilir:

Toprağa zarar verebilecek kimyasal maddelerin kullanılmaması
Genetiği değiştirilmiş tohumlardan uzak durulması
Zararlılar ve hastalıklarla mücadele ederken doğaya zarar veren kalıcı kimyasal maddeler kullanılmaması
Ürünlerin sertifikasyonunun ve etiketlendirmesinin yapılması', N'Ege Yüksel', CAST(N'2022-11-22T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Title], [Name], [ImageUrl], [Comment]) VALUES (1, N'Tamamen Doğal', N'Furkan Ertekin', N'testimonial-2.jpg', N'Meyvelerin tadının yoğunluğunu hissediyorsunuz.')
INSERT [dbo].[Clients] ([Id], [Title], [Name], [ImageUrl], [Comment]) VALUES (2, N'Bayıldımm!', N'Enes İpek', N'testimonial-3.jpg', N'Bundan sonra yeni adresim burası.')
INSERT [dbo].[Clients] ([Id], [Title], [Name], [ImageUrl], [Comment]) VALUES (3, N'Muazzam', N'Şeyma Yol', N'testimonial-1.jpg', N'Tadı damağınızda kalacak.')
INSERT [dbo].[Clients] ([Id], [Title], [Name], [ImageUrl], [Comment]) VALUES (4, N'Böyle bir şey yok!', N'Ege Yüksel', N'testimonial-3.jpg', N'Ananaslar çok taze geldi.')
INSERT [dbo].[Clients] ([Id], [Title], [Name], [ImageUrl], [Comment]) VALUES (5, N'Denemeden karar vermemek lazımmış.', N'Uğur Sevilgen', N'20240527124311299.png', N'Bu güzel deneyim için Organic Atelier''e teşekkür ederim. ')
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [Text], [Address], [Phone], [Email], [Location], [Twitter], [Facebook], [Instagram], [LinkedIn]) VALUES (1, N'Bize ulaşabileceğin çağrı merkezimiz 7/24 hizmet vermektedir. Sosyal medya hesaplarımızı takip etmeyi unutmayın.', N'Büyükdere Cd. No:147, 34394 Şişli/İstanbul', N'444 22 33', N'info@organicatelier.com', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3007.947648573269!2d29.010370812532802!3d41.07013697122234!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab6451778cd5b%3A0xcfafcdd628eef4c1!2zRXNlbnRlcGUsIELDvHnDvGtkZXJlIENkLiBObzoxNDcsIDM0Mzk0IMWeacWfbGkvxLBzdGFuYnVs!5e0!3m2!1str!2str!4v1716145068609!5m2!1str!2str" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade', N'https://x.com', N'https://fb.com', N'https://instagram.com', N'https://linkedin.com')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([Id], [Title], [Description], [ImageUrl]) VALUES (1, N'Sürdürülebilirliği Hedefler', N'Bilinçli üreticilerin ürünlerini sizinle buluşturarak sağlıklı ve sürdürülebilir bir geleceği sizlerle beraber yaratmayı hedefliyoruz.', N'icon-1.png')
INSERT [dbo].[Features] ([Id], [Title], [Description], [ImageUrl]) VALUES (2, N'Özenle Seçer', N'İlkelerimizle örtüşen yerel üretici ve organik tarım yapan çiftlikleri buluyor, aracısız tedarik ettiğimiz ürünleri gıda mühendislerimizin kontrolleri ile seçiyoruz.', N'icon-2.png')
INSERT [dbo].[Features] ([Id], [Title], [Description], [ImageUrl]) VALUES (3, N'Kalite Süreci', N'Taze gıdada ise her ürün için farklı kriterler uygulayarak size taptaze ulaştırmak için paketliyor, tüm bu kalite denetimlerini düzenli olarak uyguluyoruz.', N'icon-3.png')
SET IDENTITY_INSERT [dbo].[Features] OFF
GO
SET IDENTITY_INSERT [dbo].[Mails] ON 

INSERT [dbo].[Mails] ([Id], [Name], [Email], [Subject], [Message], [Read], [SendDate], [Reply]) VALUES (1, N'Feyruze Toprak Sevilgen', N'feyruzet@gmail.com', N'Ürünleriniz Hk.', N'Siparişim tarafıma eksik ulaştı.', 0, CAST(N'2024-06-01T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Mails] ([Id], [Name], [Email], [Subject], [Message], [Read], [SendDate], [Reply]) VALUES (2, N'Abdoulrazak Traore', N'Traore@abdoulrazak.com', N'Meyve', N'Bana muz yolla.', 1, CAST(N'2024-05-20T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Mails] ([Id], [Name], [Email], [Subject], [Message], [Read], [SendDate], [Reply]) VALUES (3, N'Furkan Ertekin', N'furkane@gmail.com', N'Teşekkürler.', N'Ürünlerin hepsi çok iyi durumda teşekkür ederim.', 1, CAST(N'2023-12-10T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Mails] ([Id], [Name], [Email], [Subject], [Message], [Read], [SendDate], [Reply]) VALUES (4, N'Songül Süzgün', N'songul@outlook.com', N'Kargolama Hk.', N'Siparişim elime hala ulaşmadı.', 0, CAST(N'2023-10-10T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Mails] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductDetail] ON 

INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (1, N'Organik olarak yetiştirilen, üretiminde hiçbir ilaç ve kimyasal kullanılmayan, üreticisinden verilmiş öneri ile içi kadar dış kabuklarını da değerlendirilebileceğiniz sıkmalık portakal, hiçbir kimyasala maruz kalmadan topraktan sofranıza ulaşıyor.', 3)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (2, N'Kimyasal katkı barındırmayan, tat yoğunluğu yüksek ve aroma kalitesi bakımından oldukça zengin olan yerli muz, Organic Atelier tarafından organik tarım esaslarına bağlı kalınarak üretilmektedir.', 5)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (3, N'Yeşil zemin üzerinde hafif donuk tonlarına sahip olan Granny Smith elma, sert yapısı, ekşiliği ve bol sulu olma özelliği ile ön plana çıkmaktadır.', 7)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (4, N'Kıpkırmızı rengi ve lezzetli aroması ile bilinen Scarlet elma, Organic Atelier ile meyve tabaklarınıza ulaşıyor.', 6)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (5, N'Evet mis gibi çilek. Hiç merak etmeyin; ne hormonlu, ne GDO’lu ne de pestisitli. Diğer meyve ve sebzelerimizden hiçbir farkı yok.', 8)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (6, N'Bütün dünyada misafirperverliğin sembolü olarak bilinen ananas dolu dolu içeriğiyle mucizevi bir meyve olarak görülmektedir. Demir, kalsiyum, A, B ve C vitaminleri yanı sıra, lif bakımından zengindir. ', 10)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (7, N'Erken mevsimde hasat edilen yatak limonlar, esnek ve ince kabuklu dinlenmiş limon olarak Organic Atelier''de!', 12)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (8, N'Salatası, çorbası, mezesi, kızartması ya da o çok sevilen tarator mu desek bilemedik. ', 13)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (9, N'İnce ince kıyılmış hali ile her yemeğin başlangıcı olan soğanı, halka halka dilimleyip fırın yemeklerine katabilir, yarım ay şeklinde doğrayarak salatada, piyazda tercih edebilirsiniz. ', 14)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (11, N'Adı da tadı da bir başka, yemeğe doyulmaz organik köy domatesi! En sevilen sebzelerde başı çeken domatesinizi sabah - akşam demeden günün her vaktinde tüketebilir, isteğinize göre onunla pratik ve lezzetli tarifler oluşturabilirsiniz.', 15)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (12, N'Sizin için özenle hazırlanmış, temizlenmiş.', 17)
INSERT [dbo].[ProductDetail] ([Id], [Description], [ProductId]) VALUES (13, N'Her daim taze, iri yapraklı.', 18)
SET IDENTITY_INSERT [dbo].[ProductDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (3, N'Portakal Sıkmalık', CAST(24.90 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240605110715348.png', 1, 0, 1)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (5, N'Organik Yerli Muz', CAST(64.90 AS Decimal(18, 2)), CAST(750.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240603135018312.png', 1, 1, 1)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (6, N'Elma Scarlet', CAST(38.90 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240603135052377.png', 0, 0, 1)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (7, N'Elma Granny', CAST(42.90 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240603235912555.png', 1, 0, 1)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (8, N'Organik Çilek', CAST(59.90 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240603235927417.png', 1, 1, 1)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (10, N'Ananas', CAST(99.90 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240604000041076.png', 1, 0, 1)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (12, N'Organik Yatak Limon', CAST(24.90 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240604000140613.png', 1, 0, 2)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (13, N'Organik Havuç', CAST(44.90 AS Decimal(18, 2)), CAST(750.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240604000155665.png', 1, 1, 2)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (14, N'Organik Kuru Soğan', CAST(17.90 AS Decimal(18, 2)), CAST(750.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240604000217518.png', 1, 0, 2)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (15, N'Organik Köy Domatesi', CAST(54.90 AS Decimal(18, 2)), CAST(750.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240604000230722.png', 1, 0, 2)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (17, N'Lolorosso Marul', CAST(64.90 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240603235853646.png', 1, 1, 3)
INSERT [dbo].[Products] ([Id], [Title], [Price], [Weight], [Unit], [Image], [Status], [IsPopular], [ProductTypeId]) VALUES (18, N'Fesleğen', CAST(59.90 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'20240603235625103.png', 1, 0, 3)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([Id], [Name], [Status]) VALUES (1, N'Meyve', 1)
INSERT [dbo].[ProductTypes] ([Id], [Name], [Status]) VALUES (2, N'Sebze', 1)
INSERT [dbo].[ProductTypes] ([Id], [Name], [Status]) VALUES (3, N'Yeşillikler ve Otlar', 1)
INSERT [dbo].[ProductTypes] ([Id], [Name], [Status]) VALUES (11, N'Kuruyemiş', 1)
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [Title1], [Title2], [Description1], [Description2], [ImageUrl1], [ImageUrl2], [Page]) VALUES (1, N'Temiz Dünya, Sağlıklı Gıda', N'İnsana, Hayvana ve Doğaya Faydalı', N'Sürdürülebilir tarım politikalarını izliyor, sağlığı öncelik olarak alıyoruz.', N'Misyonumuz doğayı karşımıza alarak değil, yanımıza alarak üretim yapmak ve insanlara sürdürülebilir gıda üretimi için başka bir seçenek olmadığını göstermek. ', N'carousel-1.jpg', N'carousel-2.jpg', N'Index')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
GO
/****** Object:  Index [IX_ProductDetail_ProductId]    Script Date: 22.06.2024 12:39:43 ******/
CREATE NONCLUSTERED INDEX [IX_ProductDetail_ProductId] ON [dbo].[ProductDetail]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_ProductTypeId]    Script Date: 22.06.2024 12:39:43 ******/
CREATE NONCLUSTERED INDEX [IX_Products_ProductTypeId] ON [dbo].[Products]
(
	[ProductTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductDetail]  WITH CHECK ADD  CONSTRAINT [FK_ProductDetail_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductDetail] CHECK CONSTRAINT [FK_ProductDetail_Products_ProductId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductTypes_ProductTypeId] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductTypes_ProductTypeId]
GO
USE [master]
GO
ALTER DATABASE [OrganicAtelier] SET  READ_WRITE 
GO
