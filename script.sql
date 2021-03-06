USE [QLtinhoc]
GO
/****** Object:  Table [dbo].[tblCahoc]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCahoc](
	[MaCa] [char](10) NOT NULL,
	[TenCa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblCahoc] PRIMARY KEY CLUSTERED 
(
	[MaCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChucdanh]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChucdanh](
	[MaChucDanh] [char](10) NOT NULL,
	[TenChucDanh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblChucdanh] PRIMARY KEY CLUSTERED 
(
	[MaChucDanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChuyenmon]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChuyenmon](
	[MaChuyenMon] [char](10) NOT NULL,
	[TenChuyenMon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblChuyenmon] PRIMARY KEY CLUSTERED 
(
	[MaChuyenMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCoquan]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCoquan](
	[MaCQ] [char](10) NOT NULL,
	[TenCQ] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tblCoquan] PRIMARY KEY CLUSTERED 
(
	[MaCQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiaovien]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaovien](
	[MaGV] [char](10) NOT NULL,
	[TenGV] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](15) NOT NULL,
	[MaChucDanh] [char](10) NOT NULL,
	[MaChuyenMon] [char](10) NOT NULL,
	[MaCQ] [char](10) NOT NULL,
	[MaTrinhDo] [char](10) NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[Anh] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblGiaovien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiaovienMonhoc]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaovienMonhoc](
	[MaGV] [char](10) NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[XepLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblGiaovienMonhoc] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHocvien]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHocvien](
	[MaHocVien] [char](10) NOT NULL,
	[TenHocVien] [nvarchar](50) NOT NULL,
	[MaLop] [char](10) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[MaNghe] [char](10) NOT NULL,
	[DienThoai] [nvarchar](15) NOT NULL,
	[NgayNopHocPhi] [datetime] NOT NULL,
	[Diem] [float] NOT NULL,
 CONSTRAINT [PK_tblHocvien] PRIMARY KEY CLUSTERED 
(
	[MaHocVien] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLophoc]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLophoc](
	[MaLop] [char](10) NOT NULL,
	[TenLop] [nvarchar](50) NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[MaGV] [char](10) NOT NULL,
	[NgayBD] [datetime] NOT NULL,
	[NgayKT] [datetime] NOT NULL,
	[MaCa] [char](10) NOT NULL,
	[MaThoiGian] [char](10) NOT NULL,
	[MaPhong] [char](10) NOT NULL,
	[SiSo] [int] NOT NULL,
 CONSTRAINT [PK_tblLophoc] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMonhoc]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonhoc](
	[MaMon] [char](10) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[HocPhi] [float] NOT NULL,
 CONSTRAINT [PK_tblMonhoc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNghenghiep]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNghenghiep](
	[MaNghe] [char](10) NOT NULL,
	[TenNghe] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNghenghiep] PRIMARY KEY CLUSTERED 
(
	[MaNghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhonghoc]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhonghoc](
	[MaPhong] [char](10) NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblPhonghoc] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThoigian]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThoigian](
	[MaThoiGian] [char](10) NOT NULL,
	[TenThoiGian] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblThoigian] PRIMARY KEY CLUSTERED 
(
	[MaThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTrinhdo]    Script Date: 07/10/2020 2:39:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTrinhdo](
	[MaTrinhDo] [char](10) NOT NULL,
	[TenTrinhDo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTrinhdo] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblCahoc] ([MaCa], [TenCa]) VALUES (N'001       ', N'sáng')
INSERT [dbo].[tblCahoc] ([MaCa], [TenCa]) VALUES (N'002       ', N'chiều')
INSERT [dbo].[tblChucdanh] ([MaChucDanh], [TenChucDanh]) VALUES (N'001       ', N'giáo vien chủ nhiệm')
INSERT [dbo].[tblChucdanh] ([MaChucDanh], [TenChucDanh]) VALUES (N'002       ', N'trợ giảng')
INSERT [dbo].[tblChucdanh] ([MaChucDanh], [TenChucDanh]) VALUES (N'003       ', N'học việc')
INSERT [dbo].[tblChuyenmon] ([MaChuyenMon], [TenChuyenMon]) VALUES (N'001       ', N'tin học')
INSERT [dbo].[tblChuyenmon] ([MaChuyenMon], [TenChuyenMon]) VALUES (N'002       ', N'tiếng anh')
INSERT [dbo].[tblCoquan] ([MaCQ], [TenCQ], [DiaChi], [DienThoai]) VALUES (N'001       ', N'hvnh', N'chùa bộc', N'090909090')
INSERT [dbo].[tblGiaovien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaChucDanh], [MaChuyenMon], [MaCQ], [MaTrinhDo], [MaMon], [Anh]) VALUES (N'001       ', N'kt', CAST(N'1998-07-06T00:00:00.000' AS DateTime), N'Nữ', N'hhb', N'099090909', N'001       ', N'001       ', N'001       ', N'001       ', N'001       ', N'C:\Users\ADMIN\OneDrive\Desktop\70325117_483269959196092_4248168512004030464_o.jpg')
INSERT [dbo].[tblGiaovien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaChucDanh], [MaChuyenMon], [MaCQ], [MaTrinhDo], [MaMon], [Anh]) VALUES (N'002       ', N'abc', CAST(N'1993-08-06T00:00:00.000' AS DateTime), N'Nam', N'abcdxyz', N'1231231', N'002       ', N'001       ', N'001       ', N'001       ', N'002       ', N'C:\Users\ADMIN\OneDrive\Desktop\18157749_1930308687244181_5585382017642227792_n.jpg')
INSERT [dbo].[tblGiaovien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaChucDanh], [MaChuyenMon], [MaCQ], [MaTrinhDo], [MaMon], [Anh]) VALUES (N'003       ', N'abcd', CAST(N'1984-07-06T00:00:00.000' AS DateTime), N'Nam', N'123123asdád', N'123213123', N'001       ', N'001       ', N'001       ', N'001       ', N'001       ', N'C:\Users\ADMIN\OneDrive\Desktop\71134886_483267009196387_5492852903422984192_o.jpg')
INSERT [dbo].[tblHocvien] ([MaHocVien], [TenHocVien], [MaLop], [NgaySinh], [GioiTinh], [DiaChi], [MaNghe], [DienThoai], [NgayNopHocPhi], [Diem]) VALUES (N'001       ', N'faafd', N'001       ', CAST(N'1986-05-04T00:00:00.000' AS DateTime), N'Nữ', N'1213dd', N'001       ', N'123', CAST(N'2019-05-04T00:00:00.000' AS DateTime), 10)
INSERT [dbo].[tblHocvien] ([MaHocVien], [TenHocVien], [MaLop], [NgaySinh], [GioiTinh], [DiaChi], [MaNghe], [DienThoai], [NgayNopHocPhi], [Diem]) VALUES (N'002       ', N'ád', N'001       ', CAST(N'1984-05-04T00:00:00.000' AS DateTime), N'Nữ', N'ád', N'001       ', N'123123', CAST(N'2023-06-05T00:00:00.000' AS DateTime), 9)
INSERT [dbo].[tblHocvien] ([MaHocVien], [TenHocVien], [MaLop], [NgaySinh], [GioiTinh], [DiaChi], [MaNghe], [DienThoai], [NgayNopHocPhi], [Diem]) VALUES (N'003       ', N'âss', N'001       ', CAST(N'1988-06-05T00:00:00.000' AS DateTime), N'Nữ', N'â', N'001       ', N'123123213', CAST(N'2023-07-07T00:00:00.000' AS DateTime), 8)
INSERT [dbo].[tblLophoc] ([MaLop], [TenLop], [MaMon], [MaGV], [NgayBD], [NgayKT], [MaCa], [MaThoiGian], [MaPhong], [SiSo]) VALUES (N'001       ', N'tin học', N'001       ', N'001       ', CAST(N'2019-09-06T00:00:00.000' AS DateTime), CAST(N'2021-06-05T00:00:00.000' AS DateTime), N'002       ', N'001       ', N'001       ', 3)
INSERT [dbo].[tblLophoc] ([MaLop], [TenLop], [MaMon], [MaGV], [NgayBD], [NgayKT], [MaCa], [MaThoiGian], [MaPhong], [SiSo]) VALUES (N'002       ', N'tiếng anh', N'002       ', N'001       ', CAST(N'2027-04-08T00:00:00.000' AS DateTime), CAST(N'2024-05-06T00:00:00.000' AS DateTime), N'001       ', N'002       ', N'001       ', 0)
INSERT [dbo].[tblMonhoc] ([MaMon], [TenMon], [HocPhi]) VALUES (N'001       ', N'tiếng anh', 1000000)
INSERT [dbo].[tblMonhoc] ([MaMon], [TenMon], [HocPhi]) VALUES (N'002       ', N'tin học', 10000000)
INSERT [dbo].[tblNghenghiep] ([MaNghe], [TenNghe]) VALUES (N'001       ', N'sinh viên')
INSERT [dbo].[tblPhonghoc] ([MaPhong], [TenPhong], [DiaChi]) VALUES (N'001       ', N'tin học', N'd108')
INSERT [dbo].[tblThoigian] ([MaThoiGian], [TenThoiGian]) VALUES (N'001       ', N'sáng')
INSERT [dbo].[tblThoigian] ([MaThoiGian], [TenThoiGian]) VALUES (N'002       ', N'chiều')
INSERT [dbo].[tblThoigian] ([MaThoiGian], [TenThoiGian]) VALUES (N'003       ', N'tối')
INSERT [dbo].[tblTrinhdo] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'001       ', N'thạc sĩ')
INSERT [dbo].[tblTrinhdo] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'002       ', N'giáo sư')
INSERT [dbo].[tblTrinhdo] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'003       ', N'thực tập')
INSERT [dbo].[tblTrinhdo] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'004       ', N'tiến sĩ')
ALTER TABLE [dbo].[tblGiaovien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaovien_tblChucdanh] FOREIGN KEY([MaChucDanh])
REFERENCES [dbo].[tblChucdanh] ([MaChucDanh])
GO
ALTER TABLE [dbo].[tblGiaovien] CHECK CONSTRAINT [FK_tblGiaovien_tblChucdanh]
GO
ALTER TABLE [dbo].[tblGiaovien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaovien_tblChuyenmon] FOREIGN KEY([MaChuyenMon])
REFERENCES [dbo].[tblChuyenmon] ([MaChuyenMon])
GO
ALTER TABLE [dbo].[tblGiaovien] CHECK CONSTRAINT [FK_tblGiaovien_tblChuyenmon]
GO
ALTER TABLE [dbo].[tblGiaovien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaovien_tblCoquan] FOREIGN KEY([MaCQ])
REFERENCES [dbo].[tblCoquan] ([MaCQ])
GO
ALTER TABLE [dbo].[tblGiaovien] CHECK CONSTRAINT [FK_tblGiaovien_tblCoquan]
GO
ALTER TABLE [dbo].[tblGiaovien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaovien_tblMonhoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMonhoc] ([MaMon])
GO
ALTER TABLE [dbo].[tblGiaovien] CHECK CONSTRAINT [FK_tblGiaovien_tblMonhoc]
GO
ALTER TABLE [dbo].[tblGiaovien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaovien_tblTrinhdo] FOREIGN KEY([MaTrinhDo])
REFERENCES [dbo].[tblTrinhdo] ([MaTrinhDo])
GO
ALTER TABLE [dbo].[tblGiaovien] CHECK CONSTRAINT [FK_tblGiaovien_tblTrinhdo]
GO
ALTER TABLE [dbo].[tblGiaovienMonhoc]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaovienMonhoc_tblGiaovien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[tblGiaovien] ([MaGV])
GO
ALTER TABLE [dbo].[tblGiaovienMonhoc] CHECK CONSTRAINT [FK_tblGiaovienMonhoc_tblGiaovien]
GO
ALTER TABLE [dbo].[tblGiaovienMonhoc]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaovienMonhoc_tblMonhoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMonhoc] ([MaMon])
GO
ALTER TABLE [dbo].[tblGiaovienMonhoc] CHECK CONSTRAINT [FK_tblGiaovienMonhoc_tblMonhoc]
GO
ALTER TABLE [dbo].[tblHocvien]  WITH CHECK ADD  CONSTRAINT [FK_tblHocvien_tblLophoc] FOREIGN KEY([MaLop])
REFERENCES [dbo].[tblLophoc] ([MaLop])
GO
ALTER TABLE [dbo].[tblHocvien] CHECK CONSTRAINT [FK_tblHocvien_tblLophoc]
GO
ALTER TABLE [dbo].[tblHocvien]  WITH CHECK ADD  CONSTRAINT [FK_tblHocvien_tblNghenghiep] FOREIGN KEY([MaNghe])
REFERENCES [dbo].[tblNghenghiep] ([MaNghe])
GO
ALTER TABLE [dbo].[tblHocvien] CHECK CONSTRAINT [FK_tblHocvien_tblNghenghiep]
GO
ALTER TABLE [dbo].[tblLophoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLophoc_tblCahoc] FOREIGN KEY([MaCa])
REFERENCES [dbo].[tblCahoc] ([MaCa])
GO
ALTER TABLE [dbo].[tblLophoc] CHECK CONSTRAINT [FK_tblLophoc_tblCahoc]
GO
ALTER TABLE [dbo].[tblLophoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLophoc_tblGiaovien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[tblGiaovien] ([MaGV])
GO
ALTER TABLE [dbo].[tblLophoc] CHECK CONSTRAINT [FK_tblLophoc_tblGiaovien]
GO
ALTER TABLE [dbo].[tblLophoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLophoc_tblMonhoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMonhoc] ([MaMon])
GO
ALTER TABLE [dbo].[tblLophoc] CHECK CONSTRAINT [FK_tblLophoc_tblMonhoc]
GO
ALTER TABLE [dbo].[tblLophoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLophoc_tblPhonghoc] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tblPhonghoc] ([MaPhong])
GO
ALTER TABLE [dbo].[tblLophoc] CHECK CONSTRAINT [FK_tblLophoc_tblPhonghoc]
GO
ALTER TABLE [dbo].[tblLophoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLophoc_tblThoigian] FOREIGN KEY([MaThoiGian])
REFERENCES [dbo].[tblThoigian] ([MaThoiGian])
GO
ALTER TABLE [dbo].[tblLophoc] CHECK CONSTRAINT [FK_tblLophoc_tblThoigian]
GO
