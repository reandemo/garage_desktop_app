
CREATE TABLE [dbo].[garage_tbl_body_type](
	[body_type_id] [nvarchar](50) NOT NULL,
	[branch_code] [nvarchar](100) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[is_active] [bit] NOT NULL,
	[inputdate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_garage_tbl_body_type_1] PRIMARY KEY CLUSTERED 
(
	[body_type_id] ASC,
	[branch_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[garage_tbl_brand]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[garage_tbl_brand](
	[brand_id] [nvarchar](50) NOT NULL,
	[branch_code] [nvarchar](100) NOT NULL,
	[title] [nvarchar](100) NOT NULL,
	[is_active] [bit] NOT NULL,
	[inputdate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_garage_tbl_brand_1] PRIMARY KEY CLUSTERED 
(
	[brand_id] ASC,
	[branch_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[garage_tbl_color]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[garage_tbl_color](
	[color_id] [nvarchar](50) NOT NULL,
	[branch_code] [nvarchar](100) NOT NULL,
	[title] [nvarchar](100) NOT NULL,
	[is_active] [bit] NOT NULL,
	[inputdate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_garage_tbl_color] PRIMARY KEY CLUSTERED 
(
	[color_id] ASC,
	[branch_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[garage_tbl_customer]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[garage_tbl_customer](
	[cus_id] [nvarchar](50) NOT NULL,
	[branch_code] [nvarchar](50) NOT NULL,
	[customer_type] [nvarchar](20) NULL,
	[cus_name] [nvarchar](250) NULL,
	[company_name] [nvarchar](250) NULL,
	[phone] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[gender] [nvarchar](20) NULL,
	[dob] [date] NULL,
	[address] [nvarchar](500) NULL,
	[tax_number] [nvarchar](100) NULL,
	[is_active] [bit] NULL,
	[remark] [nvarchar](500) NULL,
	[inputter] [nvarchar](50) NULL,
	[inputdate] [datetime2](0) NULL,
	[updater] [nvarchar](50) NULL,
	[updatedate] [datetime2](0) NULL,
 CONSTRAINT [PK_garage_tbl_customer] PRIMARY KEY CLUSTERED 
(
	[cus_id] ASC,
	[branch_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[garage_tbl_drive_type]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[garage_tbl_drive_type](
	[drive_type_id] [nvarchar](50) NOT NULL,
	[branch_code] [nvarchar](100) NOT NULL,
	[title] [nvarchar](250) NOT NULL,
	[is_active] [bit] NOT NULL,
	[remark] [nvarchar](250) NULL,
	[inputdate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_garage_tbl_drive_type_1] PRIMARY KEY CLUSTERED 
(
	[drive_type_id] ASC,
	[branch_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[garage_tbl_fuel_type]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[garage_tbl_fuel_type](
	[fuel_id] [nvarchar](50) NOT NULL,
	[branch_code] [nvarchar](100) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[is_active] [bit] NOT NULL,
	[inputdate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_garage_tbl_fuel_type_1] PRIMARY KEY CLUSTERED 
(
	[fuel_id] ASC,
	[branch_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[garage_tbl_models]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[garage_tbl_models](
	[model_id] [nvarchar](50) NOT NULL,
	[brand_id] [nvarchar](50) NOT NULL,
	[year_id] [nvarchar](50) NULL,
	[title] [nvarchar](100) NOT NULL,
	[is_active] [bit] NOT NULL,
	[inputdate] [datetime2](0) NOT NULL,
	[branch_code] [nvarchar](100) NULL,
 CONSTRAINT [PK_garage_tbl_models_1] PRIMARY KEY CLUSTERED 
(
	[model_id] ASC,
	[brand_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[garage_tbl_transmission]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[garage_tbl_transmission](
	[transmission_id] [nvarchar](50) NOT NULL,
	[branch_code] [nvarchar](100) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[is_active] [bit] NOT NULL,
	[inputdate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_garage_tbl_transmission_1] PRIMARY KEY CLUSTERED 
(
	[transmission_id] ASC,
	[branch_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[garage_tbl_year]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[garage_tbl_year](
	[year_id] [nvarchar](50) NOT NULL,
	[branch_code] [nvarchar](100) NOT NULL,
	[title] [nvarchar](4) NOT NULL,
	[is_active] [bit] NOT NULL,
	[inputdate] [datetime2](0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginHistory]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginHistory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Email] [nvarchar](100) NULL,
	[LoginTime] [datetime] NOT NULL,
	[ComputerName] [nvarchar](100) NULL,
	[UserName] [nvarchar](100) NULL,
	[IpAddress] [nvarchar](50) NULL,
	[AppVersion] [nvarchar](30) NULL,
	[Status] [nvarchar](20) NULL,
	[Remark] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_branches]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_branches](
	[branch_code] [nvarchar](10) NOT NULL,
	[parent_branch_code] [nvarchar](10) NULL,
	[branch_name] [nvarchar](150) NOT NULL,
	[branch_short_name] [nvarchar](50) NULL,
	[is_head_office] [bit] NOT NULL,
	[is_active] [bit] NOT NULL,
	[inputter] [nvarchar](222) NOT NULL,
	[created_at] [datetime2](0) NOT NULL,
	[updated_at] [datetime2](0) NULL,
 CONSTRAINT [PK_sys_branches] PRIMARY KEY CLUSTERED 
(
	[branch_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_languages]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_languages](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[language_code] [nvarchar](10) NOT NULL,
	[culture_code] [nvarchar](20) NOT NULL,
	[language_name] [nvarchar](100) NOT NULL,
	[native_name] [nvarchar](100) NOT NULL,
	[resource_file] [nvarchar](255) NULL,
	[flag_icon] [nvarchar](255) NULL,
	[sort_order] [int] NOT NULL,
	[is_default] [bit] NOT NULL,
	[is_active] [bit] NOT NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_running_numbers]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_running_numbers](
	[branch_code] [nvarchar](20) NOT NULL,
	[document_type] [nvarchar](50) NOT NULL,
	[current_number] [int] NOT NULL,
	[format_type] [nvarchar](20) NOT NULL,
	[prefix] [nvarchar](20) NULL,
	[padding] [int] NOT NULL,
	[separator] [nvarchar](5) NULL,
	[description] [nvarchar](250) NULL,
	[is_active] [bit] NOT NULL,
 CONSTRAINT [PK_sys_running_numbers] PRIMARY KEY CLUSTERED 
(
	[branch_code] ASC,
	[document_type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_running_numbers_template]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_running_numbers_template](
	[document_type] [nvarchar](50) NOT NULL,
	[format_type] [nvarchar](20) NOT NULL,
	[prefix] [nvarchar](20) NULL,
	[padding] [int] NOT NULL,
	[separator] [nvarchar](5) NULL,
	[description] [nvarchar](250) NULL,
	[is_active] [bit] NOT NULL,
 CONSTRAINT [PK_sys_running_numbers_template] PRIMARY KEY CLUSTERED 
(
	[document_type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_user_logins]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_user_logins](
	[session_id] [uniqueidentifier] NOT NULL,
	[user_id] [nvarchar](20) NOT NULL,
	[username] [nvarchar](100) NOT NULL,
	[branch_code] [nvarchar](20) NOT NULL,
	[profile_id] [nvarchar](20) NOT NULL,
	[access_token] [nvarchar](max) NULL,
	[refresh_token] [nvarchar](max) NULL,
	[login_time] [datetime2](0) NOT NULL,
	[token_expired_at] [datetime2](0) NULL,
	[last_sync] [datetime2](0) NULL,
	[is_active] [bit] NOT NULL,
	[created_at] [datetime2](0) NOT NULL,
	[updated_at] [datetime2](0) NULL,
 CONSTRAINT [PK_sys_user_logins] PRIMARY KEY CLUSTERED 
(
	[session_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_user_permissions]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_user_permissions](
	[permission_id] [uniqueidentifier] NOT NULL,
	[profile_id] [nvarchar](20) NOT NULL,
	[module_code] [nvarchar](50) NOT NULL,
	[permission_code] [nvarchar](50) NOT NULL,
	[is_allowed] [bit] NOT NULL,
	[created_at] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_sys_user_permissions] PRIMARY KEY CLUSTERED 
(
	[permission_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_user_profiles]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_user_profiles](
	[profile_id] [nvarchar](20) NOT NULL,
	[profile_name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](500) NULL,
	[is_active] [bit] NOT NULL,
	[created_at] [datetime2](0) NOT NULL,
	[updated_at] [datetime2](0) NULL,
 CONSTRAINT [PK_sys_user_profiles] PRIMARY KEY CLUSTERED 
(
	[profile_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sysconstants]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysconstants](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[con_id] [nvarchar](50) NOT NULL,
	[con_display] [nvarchar](100) NOT NULL,
	[con_line] [nvarchar](50) NOT NULL,
	[disable] [bit] NOT NULL,
 CONSTRAINT [PK_sysconstants] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemLogs]    Script Date: 30/07/2026 1:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemLogs](
	[LogId] [bigint] IDENTITY(1,1) NOT NULL,
	[LogDate] [datetime2](7) NOT NULL,
	[LogLevel] [nvarchar](20) NOT NULL,
	[Title] [nvarchar](200) NULL,
	[Message] [nvarchar](max) NULL,
	[ExceptionType] [nvarchar](500) NULL,
	[StackTrace] [nvarchar](max) NULL,
	[Source] [nvarchar](500) NULL,
	[MachineName] [nvarchar](100) NULL,
	[UserName] [nvarchar](100) NULL,
	[ApplicationName] [nvarchar](100) NULL,
	[SqlStatement] [nvarchar](max) NULL,
	[Parameters] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[LogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000001', N'0001', N'Sedan', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000002', N'0001', N'Hatchback', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000003', N'0001', N'Coupe', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000004', N'0001', N'Convertible', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000005', N'0001', N'Wagon', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000006', N'0001', N'SUV', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000007', N'0001', N'Crossover', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000008', N'0001', N'Pickup', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000009', N'0001', N'Van', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000010', N'0001', N'Minivan', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000011', N'0001', N'MPV', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000012', N'0001', N'Jeep', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000013', N'0001', N'Truck', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000014', N'0001', N'Bus', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000015', N'0001', N'Roadster', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000016', N'0001', N'Fastback', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000017', N'0001', N'Liftback', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000018', N'0001', N'Targa', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000019', N'0001', N'Limousine', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_body_type] ([body_type_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BT000020', N'0001', N'Microcar', 1, CAST(N'2026-07-27T00:47:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000001', N'0001', N'Abarth', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000002', N'0001', N'Acura', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000003', N'0001', N'Alfa Romeo', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000004', N'0001', N'Aston Martin', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000005', N'0001', N'Audi', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000006', N'0001', N'Bentley', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000007', N'0001', N'BMW', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000008', N'0001', N'Bugatti', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000009', N'0001', N'Buick', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000010', N'0001', N'BYD', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000011', N'0001', N'Cadillac', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000012', N'0001', N'Changan', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000013', N'0001', N'Chevrolet', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000014', N'0001', N'Chery', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000015', N'0001', N'Chrysler', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000016', N'0001', N'Citroën', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000017', N'0001', N'Cupra', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000018', N'0001', N'Dacia', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000019', N'0001', N'Daewoo', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000020', N'0001', N'Daihatsu', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000021', N'0001', N'Dodge', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000022', N'0001', N'Dongfeng', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000023', N'0001', N'Ferrari', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000024', N'0001', N'Fiat', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000025', N'0001', N'Ford', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000026', N'0001', N'Geely', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000027', N'0001', N'Genesis', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000028', N'0001', N'GMC', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000029', N'0001', N'Great Wall', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000030', N'0001', N'Haval', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000031', N'0001', N'Honda', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000032', N'0001', N'Hyundai', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000033', N'0001', N'Infiniti', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000034', N'0001', N'Isuzu', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000035', N'0001', N'Jaguar', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000036', N'0001', N'Jeep', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000037', N'0001', N'Kia', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000038', N'0001', N'Koenigsegg', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000039', N'0001', N'Lamborghini', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000040', N'0001', N'Lancia', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000041', N'0001', N'Land Rover', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000042', N'0001', N'Lexus', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000043', N'0001', N'Lincoln', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000044', N'0001', N'Lotus', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000045', N'0001', N'Lucid', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000046', N'0001', N'Maserati', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000047', N'0001', N'Mazda', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000048', N'0001', N'McLaren', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000049', N'0001', N'Mercedes-Benz', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000050', N'0001', N'MG', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000051', N'0001', N'Mini', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000052', N'0001', N'Mitsubishi', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000053', N'0001', N'Nissan', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000054', N'0001', N'Opel', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000055', N'0001', N'Peugeot', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000056', N'0001', N'Polestar', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000057', N'0001', N'Pontiac', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000058', N'0001', N'Porsche', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000059', N'0001', N'Proton', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000060', N'0001', N'Ram', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000061', N'0001', N'Renault', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000062', N'0001', N'Rolls-Royce', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000063', N'0001', N'Saab', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000064', N'0001', N'Seat', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000065', N'0001', N'Škoda', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000066', N'0001', N'Smart', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000067', N'0001', N'Subaru', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000068', N'0001', N'Suzuki', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000069', N'0001', N'Tata', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000070', N'0001', N'Tesla', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000071', N'0001', N'Toyota', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000072', N'0001', N'VinFast', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000073', N'0001', N'Volkswagen', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000074', N'0001', N'Volvo', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000075', N'0001', N'Wuling', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000076', N'0001', N'XPeng', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_brand] ([brand_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'BR000077', N'0001', N'Zeekr', 1, CAST(N'2026-07-27T00:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000001', N'0001', N'Black', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000002', N'0001', N'White', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000003', N'0001', N'Silver', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000004', N'0001', N'Gray', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000005', N'0001', N'Red', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000006', N'0001', N'Blue', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000007', N'0001', N'Green', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000008', N'0001', N'Yellow', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000009', N'0001', N'Orange', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000010', N'0001', N'Brown', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000011', N'0001', N'Beige', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000012', N'0001', N'Gold', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000013', N'0001', N'Purple', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000014', N'0001', N'Pink', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000015', N'0001', N'Maroon', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000016', N'0001', N'Burgundy', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000017', N'0001', N'Bronze', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000018', N'0001', N'Champagne', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000019', N'0001', N'Copper', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000020', N'0001', N'Pearl White', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000021', N'0001', N'Pearl Black', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000022', N'0001', N'Metallic Silver', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000023', N'0001', N'Metallic Gray', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000024', N'0001', N'Metallic Blue', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000025', N'0001', N'Metallic Red', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000026', N'0001', N'Sky Blue', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000027', N'0001', N'Navy Blue', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000028', N'0001', N'Dark Green', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000029', N'0001', N'Light Green', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000030', N'0001', N'Ivory', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000031', N'0001', N'Cream', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000032', N'0001', N'Turquoise', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000033', N'0001', N'Teal', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000034', N'0001', N'Charcoal', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000035', N'0001', N'Gunmetal', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000036', N'0001', N'Matte Black', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000037', N'0001', N'Matte Gray', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000038', N'0001', N'Matte White', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000039', N'0001', N'Olive Green', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_color] ([color_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'CL000040', N'0001', N'Wine Red', 1, CAST(N'2026-07-27T00:43:39.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000019', N'0201', N'RETAIL', N'dfdf', NULL, NULL, NULL, N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, NULL, N'2', CAST(N'2026-07-28T23:28:20.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000020', N'0201', N'RETAIL', N'dfdf', NULL, NULL, NULL, N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, NULL, N'2', CAST(N'2026-07-28T23:28:25.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000021', N'0201', N'RETAIL', N'dfdf', NULL, N'', N'', N'Female', CAST(N'2026-07-16' AS Date), NULL, NULL, 1, N'', N'2', CAST(N'2026-07-28T23:29:35.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000022', N'0201', N'RETAIL', N'dfdfdf', NULL, N'', N'', N'Female', CAST(N'2026-07-09' AS Date), NULL, NULL, 1, N'sdfdf', N'2', CAST(N'2026-07-28T23:30:03.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000023', N'0201', N'RETAIL', N'dfdf', NULL, N'', N'', N'Female', CAST(N'2026-07-15' AS Date), NULL, NULL, 1, N'sdfsdfsdf', N'2', CAST(N'2026-07-28T23:30:13.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000024', N'0201', N'RETAIL', N'testing love', NULL, N'010 500 313', N'', N'Male', CAST(N'2026-07-16' AS Date), NULL, NULL, 1, N'xcvcv', N'garage@gmail.com', CAST(N'2026-07-28T23:31:47.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-28T23:32:53.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000025', N'0201', N'RETAIL', N'dfdf', NULL, N'23222', N'', N'Male', CAST(N'2026-07-22' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-28T23:39:24.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000026', N'0201', N'RETAIL', N'sdf', NULL, N'eeee', N'', N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:10:24.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:10:38.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000027', N'0201', N'RETAIL', N'sdfsdf', NULL, N'010m 4500313', N'', N'Female', CAST(N'2026-07-17' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:11:24.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:11:37.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000028', N'0201', N'RETAIL', N'sdfsdf', NULL, N'33333', N'', N'Male', CAST(N'2026-07-17' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:13:52.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000029', N'0201', N'RETAIL', N'sdfsdf', NULL, N'eee', N'', N'Male', CAST(N'2026-07-16' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:14:34.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:14:55.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000030', N'0201', N'RETAIL', N'home working', NULL, N'010 500 313', N'', N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'Remarks', N'garage@gmail.com', CAST(N'2026-07-29T00:15:17.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000031', N'0201', N'RETAIL', N'sdfsdf', NULL, N'3333', N'', N'Female', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:17:08.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000032', N'0201', N'RETAIL', N'ssssdfdf', NULL, N'sdfsdf', N'', N'Female', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:21:25.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:21:38.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000033', N'0201', N'RETAIL', N'sdfsdf', NULL, N'sdfe3434', N'', N'Female', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'34343sss', N'garage@gmail.com', CAST(N'2026-07-29T00:23:48.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000034', N'0201', N'RETAIL', N'dfdf', NULL, N'sdf', N'ss', N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:27:12.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:27:20.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000035', N'0201', N'RETAIL', N'sdfsdf', NULL, N'33222', N'', N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'sdfsdf', N'garage@gmail.com', CAST(N'2026-07-29T00:27:58.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000036', N'0201', N'RETAIL', N'sdfsdf', NULL, N'3333', N'', N'Female', CAST(N'2026-07-17' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:29:15.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000037', N'0201', N'RETAIL', N'sdfsdf', NULL, N'333', N'', N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:31:36.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000038', N'0201', N'RETAIL', N'sdfsdf', NULL, N'sdfsd', N'', N'Male', CAST(N'2026-07-03' AS Date), NULL, NULL, 1, N'ssdfsdf', N'garage@gmail.com', CAST(N'2026-07-29T00:31:59.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000039', N'0201', N'RETAIL', N'sdfsdf', NULL, N'010500313ss', N'', N'Female', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'sdfsdf', N'garage@gmail.com', CAST(N'2026-07-29T00:35:08.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000040', N'0201', N'RETAIL', N'weqweqwe', NULL, N'2323111772727272111', N'', N'Male', CAST(N'2026-07-09' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:36:48.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:37:01.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000041', N'0201', N'RETAIL', N'sdfsdf', NULL, N'010500131212', N'', N'Female', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:38:24.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:38:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000042', N'0201', N'RETAIL', N'asdasd', NULL, N'221224444', N'', N'Female', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:41:12.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:41:17.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000043', N'0201', N'RETAIL', N'sdfsdwwws', NULL, N'333333', N'', N'Male', CAST(N'2026-07-02' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T00:50:43.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000044', N'0201', N'RETAIL', N'sdfsdf', NULL, N'dsdsdsd', N'', N'Female', CAST(N'2026-07-08' AS Date), NULL, NULL, 1, N'erer', N'garage@gmail.com', CAST(N'2026-07-29T00:55:34.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T00:55:38.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000045', N'0201', N'RETAIL', N'sdfsdds', NULL, N'3333', N'', N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T01:03:20.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000046', N'0201', N'RETAIL', N'dfdfdf', NULL, N'343434', N'', N'Male', CAST(N'2026-07-17' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T01:03:50.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000047', N'0201', N'RETAIL', N'ssdf3eew', NULL, N'33343434', N'', N'Male', CAST(N'2026-07-11' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T01:12:05.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T01:12:09.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000048', N'0201', N'RETAIL', N'asdasd', NULL, N'221223', N'', N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T01:18:15.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000049', N'0201', N'RETAIL', N'sdfsdf', NULL, N'343434', N'', N'Male', CAST(N'2026-07-10' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T01:22:28.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T01:22:32.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000050', N'0201', N'RETAIL', N'dsfsdf', NULL, N'34w43244', N'', N'Male', CAST(N'2026-07-04' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T01:25:10.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000051', N'0201', N'RETAIL', N'dfdfs', NULL, N'sdfsdf', N'', N'Male', CAST(N'2026-07-15' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T01:32:28.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T01:33:00.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000052', N'0201', N'RETAIL', N'testing', NULL, N'09999999', N'', N'Male', CAST(N'2000-07-23' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T01:34:23.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T01:34:34.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000053', N'0201', N'RETAIL', N'sdfsdf', NULL, N'33333', N'', N'Male', CAST(N'2026-07-16' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T09:50:09.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000054', N'0201', N'RETAIL', N'sss', NULL, N'ss', N'ss', N'Male', CAST(N'2026-07-09' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T22:13:23.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T22:13:30.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_customer] ([cus_id], [branch_code], [customer_type], [cus_name], [company_name], [phone], [email], [gender], [dob], [address], [tax_number], [is_active], [remark], [inputter], [inputdate], [updater], [updatedate]) VALUES (N'CUS000055', N'0201', N'RETAIL', N'ertert', NULL, N'eee', N'rr', N'Male', CAST(N'2026-07-04' AS Date), NULL, NULL, 1, N'', N'garage@gmail.com', CAST(N'2026-07-29T23:59:54.0000000' AS DateTime2), N'garage@gmail.com', CAST(N'2026-07-29T23:59:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_drive_type] ([drive_type_id], [branch_code], [title], [is_active], [remark], [inputdate]) VALUES (N'DT000001', N'0001', N'Front-Wheel Drive (FWD)', 1, N'ប្រព័ន្ធបើកបរកង់មុខ', CAST(N'2026-07-28T16:32:16.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_drive_type] ([drive_type_id], [branch_code], [title], [is_active], [remark], [inputdate]) VALUES (N'DT000002', N'0001', N'Rear-Wheel Drive (RWD)', 1, N'ប្រព័ន្ធបើកបរកង់ក្រោយ', CAST(N'2026-07-28T16:32:16.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_drive_type] ([drive_type_id], [branch_code], [title], [is_active], [remark], [inputdate]) VALUES (N'DT000003', N'0001', N'All-Wheel Drive (AWD)', 1, N'ប្រព័ន្ធបើកបរកង់ទាំងអស់', CAST(N'2026-07-28T16:32:16.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_drive_type] ([drive_type_id], [branch_code], [title], [is_active], [remark], [inputdate]) VALUES (N'DT000004', N'0001', N'Four-Wheel Drive (4WD)', 1, N'ប្រព័ន្ធបើកបរ ៤ កង់', CAST(N'2026-07-28T16:32:16.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_drive_type] ([drive_type_id], [branch_code], [title], [is_active], [remark], [inputdate]) VALUES (N'DT000005', N'0001', N'Part-Time 4WD', 1, N'ប្រព័ន្ធបើកបរ ៤ កង់ ប្រើពេលចាំបាច់', CAST(N'2026-07-28T16:32:16.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_drive_type] ([drive_type_id], [branch_code], [title], [is_active], [remark], [inputdate]) VALUES (N'DT000006', N'0001', N'Full-Time 4WD', 1, N'ប្រព័ន្ធបើកបរ ៤ កង់ ប្រើជានិច្ច', CAST(N'2026-07-28T16:32:16.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000001', N'0001', N'Gasoline', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000002', N'0001', N'Diesel', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000003', N'0001', N'Electric', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000004', N'0001', N'Hybrid', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000005', N'0001', N'Plug-in Hybrid', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000006', N'0001', N'Hydrogen', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000007', N'0001', N'CNG', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000008', N'0001', N'LPG', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000009', N'0001', N'Flex Fuel', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_fuel_type] ([fuel_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'FL000010', N'0001', N'Biodiesel', 1, CAST(N'2026-07-27T00:46:59.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000001', N'BR000071', NULL, N'Corolla', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000002', N'BR000071', NULL, N'Camry', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000003', N'BR000071', NULL, N'Yaris', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000004', N'BR000071', NULL, N'Hilux', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000005', N'BR000071', NULL, N'Fortuner', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000006', N'BR000071', NULL, N'Land Cruiser', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000007', N'BR000071', NULL, N'Prado', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000008', N'BR000071', NULL, N'RAV4', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000009', N'BR000071', NULL, N'Highlander', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000010', N'BR000071', NULL, N'Vios', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000011', N'BR000031', NULL, N'Civic', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000012', N'BR000031', NULL, N'Accord', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000013', N'BR000031', NULL, N'City', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000014', N'BR000031', NULL, N'CR-V', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000015', N'BR000031', NULL, N'HR-V', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000016', N'BR000031', NULL, N'BR-V', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000017', N'BR000031', NULL, N'Pilot', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000018', N'BR000031', NULL, N'Jazz', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000019', N'BR000025', NULL, N'Ranger', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000020', N'BR000025', NULL, N'Everest', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000021', N'BR000025', NULL, N'Focus', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000022', N'BR000025', NULL, N'Fiesta', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000023', N'BR000025', NULL, N'Explorer', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000024', N'BR000025', NULL, N'Mustang', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000025', N'BR000053', NULL, N'Almera', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000026', N'BR000053', NULL, N'Navara', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000027', N'BR000053', NULL, N'Patrol', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000028', N'BR000053', NULL, N'X-Trail', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000029', N'BR000053', NULL, N'Terra', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000030', N'BR000053', NULL, N'Sunny', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000031', N'BR000052', NULL, N'L200', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000032', N'BR000052', NULL, N'Pajero', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000033', N'BR000052', NULL, N'Montero Sport', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000034', N'BR000052', NULL, N'Outlander', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000035', N'BR000052', NULL, N'Xpander', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000036', N'BR000052', NULL, N'Mirage', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000037', N'BR000047', NULL, N'Mazda2', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000038', N'BR000047', NULL, N'Mazda3', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000039', N'BR000047', NULL, N'Mazda6', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000040', N'BR000047', NULL, N'CX-3', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000041', N'BR000047', NULL, N'CX-5', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000042', N'BR000047', NULL, N'CX-9', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000043', N'BR000047', NULL, N'BT-50', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000044', N'BR000032', NULL, N'Accent', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000045', N'BR000032', NULL, N'Elantra', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000046', N'BR000032', NULL, N'Sonata', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000047', N'BR000032', NULL, N'Tucson', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000048', N'BR000032', NULL, N'Santa Fe', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000049', N'BR000032', NULL, N'Palisade', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000050', N'BR000037', NULL, N'Picanto', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000051', N'BR000037', NULL, N'Rio', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000052', N'BR000037', NULL, N'Cerato', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000053', N'BR000037', NULL, N'Sportage', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000054', N'BR000037', NULL, N'Sorento', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000055', N'BR000037', NULL, N'Carnival', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000056', N'BR000034', NULL, N'D-Max', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000057', N'BR000034', NULL, N'MU-X', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000058', N'BR000013', NULL, N'Colorado', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000059', N'BR000013', NULL, N'Trailblazer', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000060', N'BR000013', NULL, N'Captiva', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000061', N'BR000007', NULL, N'3 Series', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000062', N'BR000007', NULL, N'5 Series', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000063', N'BR000007', NULL, N'7 Series', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000064', N'BR000007', NULL, N'X1', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000065', N'BR000007', NULL, N'X3', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000066', N'BR000007', NULL, N'X5', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000067', N'BR000049', NULL, N'A-Class', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000068', N'BR000049', NULL, N'C-Class', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000069', N'BR000049', NULL, N'E-Class', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000070', N'BR000049', NULL, N'S-Class', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000071', N'BR000049', NULL, N'GLA', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000072', N'BR000049', NULL, N'GLE', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000073', N'BR000005', NULL, N'A3', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000074', N'BR000005', NULL, N'A4', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000075', N'BR000005', NULL, N'A6', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000076', N'BR000005', NULL, N'Q3', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000077', N'BR000005', NULL, N'Q5', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000078', N'BR000005', NULL, N'Q7', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000079', N'BR000042', NULL, N'ES', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000080', N'BR000042', NULL, N'RX', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000081', N'BR000042', NULL, N'NX', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000082', N'BR000042', NULL, N'LX', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000083', N'BR000070', NULL, N'Model 3', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000084', N'BR000070', NULL, N'Model S', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000085', N'BR000070', NULL, N'Model X', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_models] ([model_id], [brand_id], [year_id], [title], [is_active], [inputdate], [branch_code]) VALUES (N'MD000086', N'BR000070', NULL, N'Model Y', 1, CAST(N'2026-07-27T00:45:01.0000000' AS DateTime2), N'0001')
GO
INSERT [dbo].[garage_tbl_transmission] ([transmission_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'TR000001', N'0001', N'Manual', 1, CAST(N'2026-07-27T00:47:24.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_transmission] ([transmission_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'TR000002', N'0001', N'Automatic', 1, CAST(N'2026-07-27T00:47:24.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_transmission] ([transmission_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'TR000003', N'0001', N'CVT', 1, CAST(N'2026-07-27T00:47:24.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_transmission] ([transmission_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'TR000004', N'0001', N'Dual-Clutch (DCT)', 1, CAST(N'2026-07-27T00:47:24.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_transmission] ([transmission_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'TR000005', N'0001', N'Automated Manual (AMT)', 1, CAST(N'2026-07-27T00:47:24.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_transmission] ([transmission_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'TR000006', N'0001', N'Semi-Automatic', 1, CAST(N'2026-07-27T00:47:24.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_transmission] ([transmission_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'TR000007', N'0001', N'Tiptronic', 1, CAST(N'2026-07-27T00:47:24.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_transmission] ([transmission_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'TR000008', N'0001', N'e-CVT', 1, CAST(N'2026-07-27T00:47:24.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000001', N'0001', N'1990', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000002', N'0001', N'1991', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000003', N'0001', N'1992', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000004', N'0001', N'1993', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000005', N'0001', N'1994', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000006', N'0001', N'1995', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000007', N'0001', N'1996', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000008', N'0001', N'1997', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000009', N'0001', N'1998', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000010', N'0001', N'1999', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000011', N'0001', N'2000', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000012', N'0001', N'2001', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000013', N'0001', N'2002', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000014', N'0001', N'2003', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000015', N'0001', N'2004', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000016', N'0001', N'2005', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000017', N'0001', N'2006', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000018', N'0001', N'2007', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000019', N'0001', N'2008', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000020', N'0001', N'2009', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000021', N'0001', N'2010', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000022', N'0001', N'2011', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000023', N'0001', N'2012', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000024', N'0001', N'2013', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000025', N'0001', N'2014', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000026', N'0001', N'2015', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000027', N'0001', N'2016', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000028', N'0001', N'2017', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000029', N'0001', N'2018', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000030', N'0001', N'2019', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000031', N'0001', N'2020', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000032', N'0001', N'2021', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000033', N'0001', N'2022', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000034', N'0001', N'2023', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000035', N'0001', N'2024', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000036', N'0001', N'2025', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000037', N'0001', N'2026', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000038', N'0001', N'2027', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000039', N'0001', N'2028', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000040', N'0001', N'2029', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000041', N'0001', N'2030', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000042', N'0001', N'2031', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000043', N'0001', N'2032', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000044', N'0001', N'2033', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000045', N'0001', N'2034', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[garage_tbl_year] ([year_id], [branch_code], [title], [is_active], [inputdate]) VALUES (N'YR000046', N'0001', N'2035', 1, CAST(N'2026-07-27T00:46:44.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_branches] ([branch_code], [parent_branch_code], [branch_name], [branch_short_name], [is_head_office], [is_active], [inputter], [created_at], [updated_at]) VALUES (N'BR01', N'HO', N'Branch 01', N'BR01', 0, 1, N'SYSTEM', CAST(N'2026-07-03T15:02:22.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_branches] ([branch_code], [parent_branch_code], [branch_name], [branch_short_name], [is_head_office], [is_active], [inputter], [created_at], [updated_at]) VALUES (N'BR02', N'HO', N'Branch 02', N'BR02', 0, 1, N'SYSTEM', CAST(N'2026-07-03T15:02:22.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_branches] ([branch_code], [parent_branch_code], [branch_name], [branch_short_name], [is_head_office], [is_active], [inputter], [created_at], [updated_at]) VALUES (N'HO', NULL, N'Head Office', N'HO', 1, 1, N'SYSTEM', CAST(N'2026-07-03T15:02:22.0000000' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[sys_languages] ON 
GO
INSERT [dbo].[sys_languages] ([id], [language_code], [culture_code], [language_name], [native_name], [resource_file], [flag_icon], [sort_order], [is_default], [is_active], [created_at], [updated_at]) VALUES (1, N'en', N'en-US', N'English', N'English', N'Strings.en-US.resx', N'us.png', 1, 0, 1, CAST(N'2026-07-03T15:45:11.3600000' AS DateTime2), CAST(N'2026-07-03T15:45:11.3600000' AS DateTime2))
GO
INSERT [dbo].[sys_languages] ([id], [language_code], [culture_code], [language_name], [native_name], [resource_file], [flag_icon], [sort_order], [is_default], [is_active], [created_at], [updated_at]) VALUES (2, N'km', N'km-KH', N'Khmer', N'ខ្មែរ', N'Strings.km-KH.resx', N'kh.png', 2, 1, 1, CAST(N'2026-07-03T15:45:11.3600000' AS DateTime2), CAST(N'2026-07-03T15:45:11.3600000' AS DateTime2))
GO
INSERT [dbo].[sys_languages] ([id], [language_code], [culture_code], [language_name], [native_name], [resource_file], [flag_icon], [sort_order], [is_default], [is_active], [created_at], [updated_at]) VALUES (3, N'zh', N'zh-CN', N'Chinese', N'简体中文', N'Strings.zh-CN.resx', N'cn.png', 3, 0, 1, CAST(N'2026-07-03T15:45:11.3600000' AS DateTime2), CAST(N'2026-07-03T15:45:11.3600000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[sys_languages] OFF
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'001', N'CUSTOMER', 36, N'2', N'CUS', 6, N'', N'Customer Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'0201', N'CUSTOMER', 55, N'2', N'CUS', 6, N'', N'Customer Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B001', N'coding', 0, N'9', N'SUP', 6, N'', N'coding', 0)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B001', N'Computer', 0, N'9', N'SUP', 6, N'', N'Computer', 0)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B001', N'CUSTOMER', 29, N'2', N'CUS', 6, N'', N'Customer Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B001', N'INVOICE', 18, N'9', N'INV', 8, N'-', N'Invoice Number', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B001', N'PRODUCT', 17, N'2', N'PRD', 6, N'', N'Product Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B001', N'PURCHASE', 0, N'1', N'', 6, N'-', N'Purchase Number', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B001', N'SUPPLIER', 0, N'2', N'SUP', 6, N'', N'Supplier Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B002', N'coding', 0, N'9', N'SUP', 6, N'', N'coding', 0)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B002', N'Computer', 0, N'9', N'SUP', 6, N'', N'Computer', 0)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B002', N'CUSTOMER', 6, N'2', N'CUS', 6, N'', N'Customer Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B002', N'INVOICE', 0, N'9', N'INV', 8, N'-', N'Invoice Number', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B002', N'PRODUCT', 0, N'2', N'PRD', 6, N'', N'Product Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B002', N'PURCHASE', 0, N'1', N'', 6, N'-', N'Purchase Number', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B002', N'SUPPLIER', 0, N'2', N'SUP', 6, N'', N'Supplier Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B00335', N'coding', 0, N'9', N'SUP', 6, N'', N'coding', 0)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B00335', N'Computer', 0, N'9', N'SUP', 6, N'', N'Computer', 0)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B00335', N'CUSTOMER', 23, N'2', N'CUS', 6, N'', N'Customer Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B00335', N'INVOICE', 0, N'9', N'INV', 8, N'-', N'Invoice Number', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B00335', N'PRODUCT', 0, N'2', N'PRD', 6, N'', N'Product Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B00335', N'PURCHASE', 0, N'1', N'', 6, N'-', N'Purchase Number', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B00335', N'SUPPLIER', 0, N'2', N'SUP', 6, N'', N'Supplier Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B005', N'coding', 0, N'9', N'SUP', 6, N'', N'coding', 0)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B005', N'Computer', 0, N'9', N'SUP', 6, N'', N'Computer', 0)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B005', N'CUSTOMER', 20, N'2', N'CUS', 6, N'', N'Customer Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B005', N'INVOICE', 0, N'9', N'INV', 8, N'-', N'Invoice Number', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B005', N'PRODUCT', 0, N'2', N'PRD', 6, N'', N'Product Code', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B005', N'PURCHASE', 0, N'1', N'', 6, N'-', N'Purchase Number', 1)
GO
INSERT [dbo].[sys_running_numbers] ([branch_code], [document_type], [current_number], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'B005', N'SUPPLIER', 0, N'2', N'SUP', 6, N'', N'Supplier Code', 1)
GO
INSERT [dbo].[sys_running_numbers_template] ([document_type], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'CUSTOMER', N'2', N'CUS', 6, N'', N'Customer Code', 1)
GO
INSERT [dbo].[sys_running_numbers_template] ([document_type], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'INVOICE', N'9', N'INV', 8, N'-', N'Invoice Number', 1)
GO
INSERT [dbo].[sys_running_numbers_template] ([document_type], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'PRODUCT', N'2', N'PRD', 6, N'', N'Product Code', 1)
GO
INSERT [dbo].[sys_running_numbers_template] ([document_type], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'PURCHASE', N'1', N'', 6, N'-', N'Purchase Number', 1)
GO
INSERT [dbo].[sys_running_numbers_template] ([document_type], [format_type], [prefix], [padding], [separator], [description], [is_active]) VALUES (N'SUPPLIER', N'2', N'SUP', 6, N'', N'Supplier Code', 1)
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b026824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'DASH', N'VIEW', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b126824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'CUST', N'VIEW', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b226824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'CUST', N'ADD', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b326824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'CUST', N'EDIT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b426824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'CUST', N'DEL', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b526824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'CUST', N'PRINT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b626824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'CUST', N'EXPORT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b726824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'VEH', N'VIEW', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b826824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'VEH', N'ADD', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'b926824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'VEH', N'EDIT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'ba26824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'VEH', N'DEL', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'bb26824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'VEH', N'PRINT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'bc26824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'VEH', N'EXPORT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'bd26824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'BOOK', N'VIEW', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'be26824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'BOOK', N'ADD', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'bf26824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'BOOK', N'EDIT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c026824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'BOOK', N'DEL', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c126824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'BOOK', N'APPROVE', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c226824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'BOOK', N'CANCEL', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c326824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'BOOK', N'PRINT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c426824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'JOBC', N'VIEW', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c526824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'JOBC', N'ADD', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c626824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'JOBC', N'EDIT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c726824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'JOBC', N'APPROVE', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_permissions] ([permission_id], [profile_id], [module_code], [permission_code], [is_allowed], [created_at]) VALUES (N'c826824d-b476-f111-a52d-e4c767ea88cc', N'ADM', N'JOBC', N'PRINT', 1, CAST(N'2026-07-03T14:53:40.0000000' AS DateTime2))
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'ACC', N'Accountant', N'Financial reports and accounting', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'ADM', N'Administrator', N'Full system access', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'CAS', N'Cashier', N'Invoice and payment processing', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'GST', N'Guest', N'Read-only access', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'MEC', N'Mechanic', N'Repair and maintenance', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'MGR', N'Branch Manager', N'Manage branch operations', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'OWN', N'Owner', N'Business owner', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'REC', N'Reception', N'Customer registration and booking', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'STK', N'Store Keeper', N'Inventory and spare parts management', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
INSERT [dbo].[sys_user_profiles] ([profile_id], [profile_name], [description], [is_active], [created_at], [updated_at]) VALUES (N'SUP', N'Workshop Supervisor', N'Workshop supervision', 1, CAST(N'2026-07-03T14:50:51.0000000' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[sysconstants] ON 
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (34, N'STATUS', N'Active', N'A', 0)
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (35, N'STATUS', N'Inactive', N'I', 0)
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (36, N'GENDER', N'Male', N'M', 0)
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (37, N'GENDER', N'Female', N'F', 0)
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (38, N'PAYMENT_METHOD', N'Cash', N'CASH', 0)
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (39, N'PAYMENT_METHOD', N'Card', N'CARD', 0)
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (40, N'PAYMENT_METHOD', N'QR Payment', N'QR', 0)
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (41, N'CUSTOMER_TYPE', N'Member', N'MEMBER', 0)
GO
INSERT [dbo].[sysconstants] ([id], [con_id], [con_display], [con_line], [disable]) VALUES (42, N'CUSTOMER_TYPE', N'Walk-in', N'WALKIN', 0)
GO
SET IDENTITY_INSERT [dbo].[sysconstants] OFF
GO
SET IDENTITY_INSERT [dbo].[SystemLogs] ON 
GO
INSERT [dbo].[SystemLogs] ([LogId], [LogDate], [LogLevel], [Title], [Message], [ExceptionType], [StackTrace], [Source], [MachineName], [UserName], [ApplicationName], [SqlStatement], [Parameters]) VALUES (13, CAST(N'2026-07-28T22:48:03.8900000' AS DateTime2), N'Information', N'User Login', N'User ID     : 2
Email       : garage@gmail.com
Branch Code : 0201
System Code : GARAGE

User logged in successfully.
', NULL, NULL, NULL, N'JOINCODER-SV', N'REAN-Demo', N'Store_Online', NULL, NULL)
GO
INSERT [dbo].[SystemLogs] ([LogId], [LogDate], [LogLevel], [Title], [Message], [ExceptionType], [StackTrace], [Source], [MachineName], [UserName], [ApplicationName], [SqlStatement], [Parameters]) VALUES (14, CAST(N'2026-07-28T22:48:19.2833333' AS DateTime2), N'Information', N'User Login', N'User ID     : 2
Email       : garage@gmail.com
Branch Code : 0201
System Code : GARAGE

User logged in successfully.
', NULL, NULL, NULL, N'JOINCODER-SV', N'REAN-Demo', N'Store_Online', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[SystemLogs] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_garage_tbl_body_type_title]    Script Date: 30/07/2026 1:12:56 AM ******/
ALTER TABLE [dbo].[garage_tbl_body_type] ADD  CONSTRAINT [UQ_garage_tbl_body_type_title] UNIQUE NONCLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_garage_tbl_colors_title]    Script Date: 30/07/2026 1:12:56 AM ******/
ALTER TABLE [dbo].[garage_tbl_color] ADD  CONSTRAINT [UQ_garage_tbl_colors_title] UNIQUE NONCLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_garage_tbl_drive_type_title]    Script Date: 30/07/2026 1:12:56 AM ******/
ALTER TABLE [dbo].[garage_tbl_drive_type] ADD  CONSTRAINT [UQ_garage_tbl_drive_type_title] UNIQUE NONCLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_garage_tbl_fuel_type_title]    Script Date: 30/07/2026 1:12:56 AM ******/
ALTER TABLE [dbo].[garage_tbl_fuel_type] ADD  CONSTRAINT [UQ_garage_tbl_fuel_type_title] UNIQUE NONCLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_garage_tbl_models]    Script Date: 30/07/2026 1:12:56 AM ******/
ALTER TABLE [dbo].[garage_tbl_models] ADD  CONSTRAINT [UQ_garage_tbl_models] UNIQUE NONCLUSTERED 
(
	[brand_id] ASC,
	[title] ASC,
	[year_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_garage_tbl_transmission_title]    Script Date: 30/07/2026 1:12:56 AM ******/
ALTER TABLE [dbo].[garage_tbl_transmission] ADD  CONSTRAINT [UQ_garage_tbl_transmission_title] UNIQUE NONCLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_garage_tbl_year_title]    Script Date: 30/07/2026 1:12:56 AM ******/
ALTER TABLE [dbo].[garage_tbl_year] ADD  CONSTRAINT [UQ_garage_tbl_year_title] UNIQUE NONCLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_sysconstants]    Script Date: 30/07/2026 1:12:56 AM ******/
ALTER TABLE [dbo].[sysconstants] ADD  CONSTRAINT [UQ_sysconstants] UNIQUE NONCLUSTERED 
(
	[con_id] ASC,
	[con_line] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[garage_tbl_body_type] ADD  CONSTRAINT [DF_garage_tbl_body_type_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_body_type] ADD  CONSTRAINT [DF_garage_tbl_body_type_inputdate]  DEFAULT (sysdatetime()) FOR [inputdate]
GO
ALTER TABLE [dbo].[garage_tbl_brand] ADD  CONSTRAINT [DF_garage_tbl_brand_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_brand] ADD  CONSTRAINT [DF_garage_tbl_brand_inputdate]  DEFAULT (sysdatetime()) FOR [inputdate]
GO
ALTER TABLE [dbo].[garage_tbl_color] ADD  CONSTRAINT [DF_garage_tbl_colors_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_color] ADD  CONSTRAINT [DF_garage_tbl_colors_inputdate]  DEFAULT (sysdatetime()) FOR [inputdate]
GO
ALTER TABLE [dbo].[garage_tbl_customer] ADD  CONSTRAINT [DF_garage_tbl_customer_customer_type]  DEFAULT ('RETAIL') FOR [customer_type]
GO
ALTER TABLE [dbo].[garage_tbl_customer] ADD  CONSTRAINT [DF_garage_tbl_customer_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_customer] ADD  CONSTRAINT [DF_garage_tbl_customer_inputdate]  DEFAULT (getdate()) FOR [inputdate]
GO
ALTER TABLE [dbo].[garage_tbl_drive_type] ADD  CONSTRAINT [DF_garage_tbl_drive_type_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_drive_type] ADD  CONSTRAINT [DF_garage_tbl_drive_type_inputdate]  DEFAULT (sysdatetime()) FOR [inputdate]
GO
ALTER TABLE [dbo].[garage_tbl_fuel_type] ADD  CONSTRAINT [DF_garage_tbl_fuel_type_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_fuel_type] ADD  CONSTRAINT [DF_garage_tbl_fuel_type_inputdate]  DEFAULT (sysdatetime()) FOR [inputdate]
GO
ALTER TABLE [dbo].[garage_tbl_models] ADD  CONSTRAINT [DF_garage_tbl_models_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_models] ADD  CONSTRAINT [DF_garage_tbl_models_inputdate]  DEFAULT (sysdatetime()) FOR [inputdate]
GO
ALTER TABLE [dbo].[garage_tbl_transmission] ADD  CONSTRAINT [DF_garage_tbl_transmission_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_transmission] ADD  CONSTRAINT [DF_garage_tbl_transmission_inputdate]  DEFAULT (sysdatetime()) FOR [inputdate]
GO
ALTER TABLE [dbo].[garage_tbl_year] ADD  CONSTRAINT [DF_garage_tbl_year_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[garage_tbl_year] ADD  CONSTRAINT [DF_garage_tbl_year_inputdate]  DEFAULT (sysdatetime()) FOR [inputdate]
GO
ALTER TABLE [dbo].[sys_branches] ADD  DEFAULT ((0)) FOR [is_head_office]
GO
ALTER TABLE [dbo].[sys_branches] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[sys_branches] ADD  DEFAULT (sysdatetime()) FOR [created_at]
GO
ALTER TABLE [dbo].[sys_languages] ADD  DEFAULT ((0)) FOR [sort_order]
GO
ALTER TABLE [dbo].[sys_languages] ADD  DEFAULT ((0)) FOR [is_default]
GO
ALTER TABLE [dbo].[sys_languages] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[sys_running_numbers] ADD  DEFAULT ((0)) FOR [current_number]
GO
ALTER TABLE [dbo].[sys_running_numbers] ADD  DEFAULT ('0') FOR [format_type]
GO
ALTER TABLE [dbo].[sys_running_numbers] ADD  DEFAULT ((6)) FOR [padding]
GO
ALTER TABLE [dbo].[sys_running_numbers] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[sys_running_numbers_template] ADD  DEFAULT ('0') FOR [format_type]
GO
ALTER TABLE [dbo].[sys_running_numbers_template] ADD  DEFAULT ((6)) FOR [padding]
GO
ALTER TABLE [dbo].[sys_running_numbers_template] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[sys_user_logins] ADD  DEFAULT (newsequentialid()) FOR [session_id]
GO
ALTER TABLE [dbo].[sys_user_logins] ADD  DEFAULT (sysdatetime()) FOR [login_time]
GO
ALTER TABLE [dbo].[sys_user_logins] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[sys_user_logins] ADD  DEFAULT (sysdatetime()) FOR [created_at]
GO
ALTER TABLE [dbo].[sys_user_permissions] ADD  DEFAULT (newsequentialid()) FOR [permission_id]
GO
ALTER TABLE [dbo].[sys_user_permissions] ADD  DEFAULT ((1)) FOR [is_allowed]
GO
ALTER TABLE [dbo].[sys_user_permissions] ADD  DEFAULT (sysdatetime()) FOR [created_at]
GO
ALTER TABLE [dbo].[sys_user_profiles] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[sys_user_profiles] ADD  DEFAULT (sysdatetime()) FOR [created_at]
GO
ALTER TABLE [dbo].[sysconstants] ADD  DEFAULT ((0)) FOR [disable]
GO
ALTER TABLE [dbo].[SystemLogs] ADD  DEFAULT (getdate()) FOR [LogDate]
GO
