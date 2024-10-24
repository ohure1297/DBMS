USE [C:\USERS\ADMIN\DBMS\QLCUAHANGTUCHON\BIN\DEBUG\QLCUAHANG.MDF]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSPham] [nvarchar](10) NOT NULL,
	[TenSPham] [nvarchar](50) NOT NULL,
	[HinhAnh] [nvarchar](50) NOT NULL,
	[NhaSanXuat] [nvarchar](50) NOT NULL,
	[GiaBan] [int] NOT NULL,
	[TonKho] [int] NOT NULL,
	[DaBan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DanhSachSanPham]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DanhSachSanPham]
	AS SELECT MaSPham, TenSPham, HinhAnh, NhaSanXuat, GiaBan FROM SANPHAM
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](20) NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[SDT] [nvarchar](20) NOT NULL,
	[DChi] [nvarchar](20) NOT NULL,
	[AnhDaiDien] [nvarchar](100) NULL,
	[MKhau] [nvarchar](50) NOT NULL,
	[NgTuyenDung] [date] NOT NULL,
	[ChucVu] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ThongTinNhanVien]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[ThongTinNhanVien] as
SELECT MaNV, HoTen, GioiTinh, NgaySinh, SDT, DChi, NgTuyenDung, ChucVu FROM NHANVIEN
GO
/****** Object:  Table [dbo].[CALAMVIEC]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALAMVIEC](
	[MaCaLamViec] [nvarchar](10) NOT NULL,
	[ThGianBDau] [time](7) NOT NULL,
	[ThGianKThuc] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCaLamViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETDONNHAP]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDONNHAP](
	[MaDonNhap] [nvarchar](10) NOT NULL,
	[MaSPham] [nvarchar](10) NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[GiaNhap] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonNhap] ASC,
	[MaSPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONGVIEC]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGVIEC](
	[MaCViec] [nvarchar](10) NOT NULL,
	[TenCViec] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONNHAP]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONNHAP](
	[MaDonNhap] [nvarchar](10) NOT NULL,
	[NgNhap] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](40) NULL,
	[NgayXuat] [date] NOT NULL,
	[TongTien] [int] NOT NULL,
	[TienKhachDua] [int] NOT NULL,
	[TienThoi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LAMVIEC]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAMVIEC](
	[MaNV] [nvarchar](10) NOT NULL,
	[MaCViec] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHOMSANPHAM]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMSANPHAM](
	[MaNhom] [nvarchar](10) NOT NULL,
	[TenNhom] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANLOAI]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANLOAI](
	[MaSPham] [nvarchar](10) NOT NULL,
	[MaNhom] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THAMGIA]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMGIA](
	[MaNV] [nvarchar](10) NOT NULL,
	[MaCa] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINHOADON]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINHOADON](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaSPham] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XUATHOADON]    Script Date: 10/22/2024 9:07:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XUATHOADON](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CALAMVIEC] ([MaCaLamViec], [ThGianBDau], [ThGianKThuc]) VALUES (N'CA01', CAST(N'07:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[CALAMVIEC] ([MaCaLamViec], [ThGianBDau], [ThGianKThuc]) VALUES (N'CA02', CAST(N'12:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[CALAMVIEC] ([MaCaLamViec], [ThGianBDau], [ThGianKThuc]) VALUES (N'CA03', CAST(N'17:00:00' AS Time), CAST(N'22:00:00' AS Time))
GO
INSERT [dbo].[CONGVIEC] ([MaCViec], [TenCViec]) VALUES (N'1', N'LauDon')
GO
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD001', N'Nguyen Van A', CAST(N'2024-10-01' AS Date), 100000, 150000, 50000)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD002', N'Tran Thi B', CAST(N'2024-10-02' AS Date), 200000, 200000, 0)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD003', NULL, CAST(N'2024-10-03' AS Date), 150000, 200000, 50000)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD004', NULL, CAST(N'2024-10-04' AS Date), 300000, 350000, 50000)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD005', N'Ngo Van E', CAST(N'2024-10-05' AS Date), 250000, 250000, 0)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD006', NULL, CAST(N'2024-10-06' AS Date), 120000, 150000, 30000)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD007', N'Nguyen Van G', CAST(N'2024-10-07' AS Date), 400000, 450000, 50000)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD008', NULL, CAST(N'2024-10-08' AS Date), 500000, 600000, 100000)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD009', N'Le Thi I', CAST(N'2024-10-09' AS Date), 220000, 220000, 0)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenKhachHang], [NgayXuat], [TongTien], [TienKhachDua], [TienThoi]) VALUES (N'HD010', N'Pham Van J', CAST(N'2024-10-10' AS Date), 180000, 200000, 20000)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV001', N'Nguyen Van A', N'Nam', CAST(N'1990-01-15' AS Date), N'0912345678', N'Ha Noi', NULL, N'pass123', CAST(N'2020-01-05' AS Date), N'Nhan Vien')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV002', N'Tran Thi B', N'Nu', CAST(N'1992-04-22' AS Date), N'0987654321', N'Ho Chi Minh', NULL, N'pass456', CAST(N'2020-03-15' AS Date), N'Truong Phong')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV003', N'Le Van C', N'Nam', CAST(N'1985-11-30' AS Date), N'0933333333', N'Da Nang', NULL, N'pass789', CAST(N'2019-06-01' AS Date), N'Nhan Vien')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV004', N'Pham Thi D', N'Nu', CAST(N'1988-07-07' AS Date), N'0900000000', N'Hai Phong', NULL, N'password1', CAST(N'2021-09-20' AS Date), N'Ke Toan')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV005', N'Nguyen Van E', N'Nam', CAST(N'1993-10-12' AS Date), N'0944444444', N'Can Tho', NULL, N'password2', CAST(N'2022-02-14' AS Date), N'Nhan Vien')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV006', N'Do Thi F', N'Nu', CAST(N'1995-05-18' AS Date), N'0922222222', N'Hue', NULL, N'password3', CAST(N'2022-11-05' AS Date), N'Nhan Vien')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV007', N'Hoang Van G', N'Nam', CAST(N'1980-12-01' AS Date), N'0977777777', N'Nha Trang', NULL, N'password4', CAST(N'2018-08-10' AS Date), N'Giam Doc')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV008', N'Vu Thi H', N'Nu', CAST(N'1994-09-25' AS Date), N'0966666666', N'Ha Noi', NULL, N'password5', CAST(N'2023-01-25' AS Date), N'Nhan Vien')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV009', N'Pham Van I', N'Nam', CAST(N'1989-03-20' AS Date), N'0955555555', N'Quang Ninh', NULL, N'password6', CAST(N'2021-05-30' AS Date), N'Nhan Vien')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV010', N'Tran Thi J', N'Nu', CAST(N'1991-08-13' AS Date), N'0911223344', N'Vinh', NULL, N'password7', CAST(N'2020-10-10' AS Date), N'Pho Giam Doc')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV011', N'Vo Ngoc K', N'Nu', CAST(N'1987-09-11' AS Date), N'0922335566', N'Vung Tau', NULL, N'password8', CAST(N'2021-03-06' AS Date), N'Tro ly')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DChi], [AnhDaiDien], [MKhau], [NgTuyenDung], [ChucVu]) VALUES (N'NV012', N'Tran Van L', N'Nam', CAST(N'1993-06-18' AS Date), N'0966443377', N'Binh Dinh', NULL, N'password9', CAST(N'2022-08-11' AS Date), N'Nhan Vien')
GO
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR01', N'Thực phẩm tươi sống')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR02', N'Thực phẩm đóng gói')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR03', N'Đồ khô')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR04', N'Đồ đông lạnh')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR05', N'Vệ sinh cá nhân')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR06', N'Vệ sinh nhà cửa')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR07', N'Đồ dùng gia đình')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR08', N'Đồ uống')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR09', N'Đồ dùng văn phòng')
INSERT [dbo].[NHOMSANPHAM] ([MaNhom], [TenNhom]) VALUES (N'GR10', N'Đồ dùng trẻ em')
GO
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP001', N'GR01')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP002', N'GR01')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP003', N'GR01')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP004', N'GR01')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP005', N'GR01')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP006', N'GR02')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP007', N'GR02')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP008', N'GR02')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP009', N'GR02')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP010', N'GR02')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP011', N'GR03')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP012', N'GR03')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP013', N'GR03')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP014', N'GR03')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP015', N'GR03')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP016', N'GR04')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP017', N'GR04')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP018', N'GR04')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP019', N'GR04')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP020', N'GR04')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP021', N'GR05')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP022', N'GR05')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP023', N'GR05')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP024', N'GR05')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP025', N'GR05')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP026', N'GR06')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP027', N'GR06')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP028', N'GR06')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP029', N'GR06')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP030', N'GR06')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP031', N'GR07')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP032', N'GR07')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP033', N'GR07')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP034', N'GR07')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP035', N'GR07')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP036', N'GR08')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP037', N'GR08')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP038', N'GR08')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP039', N'GR08')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP040', N'GR08')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP041', N'GR09')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP042', N'GR09')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP043', N'GR09')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP044', N'GR09')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP045', N'GR09')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP046', N'GR10')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP047', N'GR10')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP048', N'GR10')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP049', N'GR10')
INSERT [dbo].[PHANLOAI] ([MaSPham], [MaNhom]) VALUES (N'SP050', N'GR10')
GO
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP001', N'Rau xà lách', N'rauxalach.jpg', N'Công ty Nông sản ABC', 10000, 100, 20)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP002', N'Bí đỏ', N'bido.jpg', N'Công ty Nông sản XYZ', 12000, 150, 50)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP003', N'Bắp cải', N'bapcai.jpg', N'Công ty Nông sản ABC', 9000, 80, 30)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP004', N'Thịt gà', N'thitga.jpg', N'Trại Gà Đồng Nai', 60000, 200, 100)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP005', N'Thịt heo', N'thitheo.jpg', N'Trại Heo Miền Tây', 80000, 180, 90)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP006', N'Mì gói', N'migoi.jpg', N'Công ty Thực phẩm Acecook', 5000, 500, 200)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP007', N'Cá hộp', N'cahop.jpg', N'Công ty Thực phẩm Vissan', 20000, 300, 100)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP008', N'Pate', N'pate.jpg', N'Công ty Thực phẩm Minh Anh', 25000, 200, 70)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP009', N'Thịt hộp', N'thithop.jpg', N'Công ty Thực phẩm Hạ Long', 35000, 180, 60)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP010', N'Bánh gạo', N'banhgao.jpg', N'Công ty Thực phẩm Orion', 15000, 400, 150)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP011', N'Gạo trắng', N'gaotrang.jpg', N'Công ty Gạo Việt', 12000, 500, 150)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP012', N'Mè đen', N'meden.jpg', N'Công ty Hạt dinh dưỡng', 30000, 200, 50)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP013', N'Đậu xanh', N'dauxanh.jpg', N'Công ty Đậu Việt', 25000, 300, 120)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP014', N'Đậu phộng', N'dauphong.jpg', N'Công ty Hạt dinh dưỡng', 20000, 250, 80)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP015', N'Nấm khô', N'namkho.jpg', N'Công ty Nấm Khánh Hòa', 40000, 100, 40)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP016', N'Tôm đông lạnh', N'tomdonglanh.jpg', N'Công ty Thủy sản ABC', 100000, 100, 30)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP017', N'Cá thu đông lạnh', N'cathudonglanh.jpg', N'Công ty Thủy sản XYZ', 120000, 80, 40)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP018', N'Mực đông lạnh', N'mucdonglanh.jpg', N'Công ty Thủy sản ABC', 150000, 60, 20)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP019', N'Bò viên đông lạnh', N'boviendonglanh.jpg', N'Công ty Thực phẩm Minh Anh', 90000, 120, 50)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP020', N'Xúc xích đông lạnh', N'xucxichdonglanh.jpg', N'Công ty Thực phẩm Hạ Long', 80000, 150, 60)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP021', N'Kem đánh răng', N'kemdanhrang.jpg', N'Công ty Colgate', 30000, 200, 100)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP022', N'Bàn chải đánh răng', N'banchaidanhtrang.jpg', N'Công ty Oral-B', 20000, 250, 90)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP023', N'Xà phòng tắm', N'xaphong.jpg', N'Công ty Lifebuoy', 15000, 400, 200)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP024', N'Dầu gội đầu', N'daugoi.jpg', N'Công ty Pantene', 70000, 300, 130)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP025', N'Khăn giấy ướt', N'khangiayuot.jpg', N'Công ty Unicharm', 50000, 200, 70)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP026', N'Nước lau sàn', N'nuoclausan.jpg', N'Công ty Sunlight', 40000, 150, 50)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP027', N'Nước rửa chén', N'nuocruachen.jpg', N'Công ty Sunlight', 30000, 180, 60)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP028', N'Chổi lau nhà', N'choilaunha.jpg', N'Công ty Vệ sinh ABC', 80000, 100, 30)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP029', N'Bột giặt', N'botgiat.jpg', N'Công ty Omo', 90000, 200, 80)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP030', N'Nước xịt kính', N'nuocxitkinh.jpg', N'Công ty Sunlight', 45000, 120, 40)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP031', N'Túi đựng rác', N'tuidungrac.jpg', N'Công ty Toshiba', 1500000, 80, 40)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP032', N'Pin', N'pin.jpg', N'Công ty Philips', 1200000, 90, 35)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP033', N'Băng keo', N'bangkeo.jpg', N'Công ty Sunhouse', 500000, 100, 45)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP034', N'Móc dán tường', N'mocdantuong.jpg', N'Công ty Rinnai', 1000000, 70, 30)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP035', N'Hộp đựng thực phẩm', N'hopdungthucpham.jpg', N'Công ty Kangaroo', 400000, 150, 60)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP036', N'Nước ngọt Coca-Cola', N'nuocngotcocacola.jpg', N'Coca-Cola', 10000, 500, 200)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP037', N'Nước ngọt Pepsi', N'nuocngotpepsi.jpg', N'PepsiCo', 10000, 400, 180)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP038', N'Nước cam ép', N'nuoccam.jpg', N'Công ty Thực phẩm ABC', 20000, 300, 120)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP039', N'Sữa tươi', N'suatuoi.jpg', N'Công ty Vinamilk', 15000, 250, 90)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP040', N'Nước khoáng Lavie', N'nuockhoanglavie.jpg', N'Công ty Lavie', 8000, 400, 150)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP041', N'Bút bi', N'butbi.jpg', N'Công ty Thiên Long', 5000, 1000, 500)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP042', N'Sổ tay', N'sotay.jpg', N'Công ty Văn phòng phẩm ABC', 20000, 300, 100)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP043', N'Giấy A4', N'giayA4.jpg', N'Công ty PaperOne', 50000, 400, 150)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP044', N'Bìa còng', N'biacong.jpg', N'Công ty Thiên Long', 30000, 200, 80)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP045', N'Kẹp giấy', N'kepgiay.jpg', N'Công ty Văn phòng phẩm ABC', 10000, 500, 200)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP046', N'Tã em bé', N'taembe.jpg', N'Công ty Huggies', 150000, 300, 120)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP047', N'Bình sữa', N'binhsua.jpg', N'Công ty Pigeon', 50000, 150, 50)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP048', N'Khăn ướt em bé', N'khanembe.jpg', N'Công ty Unicharm', 40000, 200, 70)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP049', N'Yếm em bé', N'yemembe.jpg', N'Công ty Pigeon', 30000, 180, 60)
INSERT [dbo].[SANPHAM] ([MaSPham], [TenSPham], [HinhAnh], [NhaSanXuat], [GiaBan], [TonKho], [DaBan]) VALUES (N'SP050', N'Xe tập đi', N'xetapdi.jpg', N'Công ty ABC', 200000, 100, 40)
GO
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV001', N'CA01')
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV002', N'CA01')
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV003', N'CA01')
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV005', N'CA02')
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV006', N'CA02')
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV008', N'CA02')
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV009', N'CA03')
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV011', N'CA03')
INSERT [dbo].[THAMGIA] ([MaNV], [MaCa]) VALUES (N'NV012', N'CA03')
GO
INSERT [dbo].[XUATHOADON] ([MaHoaDon], [MaNV]) VALUES (N'HD001', N'NV001')
INSERT [dbo].[XUATHOADON] ([MaHoaDon], [MaNV]) VALUES (N'HD002', N'NV002')
INSERT [dbo].[XUATHOADON] ([MaHoaDon], [MaNV]) VALUES (N'HD003', N'NV002')
INSERT [dbo].[XUATHOADON] ([MaHoaDon], [MaNV]) VALUES (N'HD004', N'NV005')
INSERT [dbo].[XUATHOADON] ([MaHoaDon], [MaNV]) VALUES (N'HD005', N'NV005')
INSERT [dbo].[XUATHOADON] ([MaHoaDon], [MaNV]) VALUES (N'HD006', N'NV005')
INSERT [dbo].[XUATHOADON] ([MaHoaDon], [MaNV]) VALUES (N'HD007', N'NV006')
GO
ALTER TABLE [dbo].[CHITIETDONNHAP]  WITH CHECK ADD FOREIGN KEY([MaDonNhap])
REFERENCES [dbo].[DONNHAP] ([MaDonNhap])
GO
ALTER TABLE [dbo].[CHITIETDONNHAP]  WITH CHECK ADD FOREIGN KEY([MaSPham])
REFERENCES [dbo].[SANPHAM] ([MaSPham])
GO
ALTER TABLE [dbo].[LAMVIEC]  WITH CHECK ADD FOREIGN KEY([MaCViec])
REFERENCES [dbo].[CONGVIEC] ([MaCViec])
GO
ALTER TABLE [dbo].[LAMVIEC]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHANLOAI]  WITH CHECK ADD FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMSANPHAM] ([MaNhom])
GO
ALTER TABLE [dbo].[PHANLOAI]  WITH CHECK ADD FOREIGN KEY([MaSPham])
REFERENCES [dbo].[SANPHAM] ([MaSPham])
GO
ALTER TABLE [dbo].[THAMGIA]  WITH CHECK ADD FOREIGN KEY([MaCa])
REFERENCES [dbo].[CALAMVIEC] ([MaCaLamViec])
GO
ALTER TABLE [dbo].[THAMGIA]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[THONGTINHOADON]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[THONGTINHOADON]  WITH CHECK ADD FOREIGN KEY([MaSPham])
REFERENCES [dbo].[SANPHAM] ([MaSPham])
GO
ALTER TABLE [dbo].[XUATHOADON]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[XUATHOADON]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[CHITIETDONNHAP]  WITH CHECK ADD CHECK  (([GiaNhap]>(0)))
GO
ALTER TABLE [dbo].[CHITIETDONNHAP]  WITH CHECK ADD CHECK  (([SoLuongNhap]>(0)))
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD CHECK  (([TienKhachDua]>(0)))
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD CHECK  (([TienThoi]>=(0)))
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD CHECK  (([TongTien]>(0)))
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD CHECK  (([GioiTinh]='Nu' OR [GioiTinh]='Nam'))
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD CHECK  (([DaBan]>(0)))
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD CHECK  (([GiaBan]>(0)))
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD CHECK  (([TonKho]>(0)))
GO
ALTER TABLE [dbo].[THONGTINHOADON]  WITH CHECK ADD CHECK  (([DonGia]>(0)))
GO
ALTER TABLE [dbo].[THONGTINHOADON]  WITH CHECK ADD CHECK  (([SoLuong]>(0)))
GO
ALTER TABLE [dbo].[THONGTINHOADON]  WITH CHECK ADD CHECK  (([ThanhTien]>(0)))
GO
