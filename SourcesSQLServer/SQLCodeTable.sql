create database QuanLyDiem
use QuanLyDiem
go

create table KHOA
(
	MAKHOA varchar(10) primary key not null,
	TENKHOA nvarchar(20),
)
go

create table LOP
(
	MALOP varchar(10) primary key not null,
	TENLOP nvarchar(30),
	MAKHOA varchar(10) not null,
	KHOA nvarchar(20),

	foreign key(MAKHOA) references KHOA(MAKHOA)
)
go

create table SINHVIEN
(
	MASV varchar(10)  primary key not null, 
	HoSV nvarchar(30) ,
	TENSV nvarchar(10),
	PHAI nvarchar(7),
	NGAYSINH datetime,
	NOISINH nvarchar (20),
	MALOP varchar(10) not null,

	foreign key(MALOP) references LOP(MALOP)
)
go

create table MONHOC
(
	MAMH varchar(10) primary key not null ,
	TENMH nvarchar(30),
	SOTIET_LT int,
	SOTIET_TH int,
)
go

create table GIANGVIEN
(
	MAGV varchar(10) primary key not null ,
	MAKHOA varchar(10) not null,
	HOGV nvarchar(30) ,
	TENGV nvarchar(10),

	foreign key(MAKHOA) references KHOA(MAKHOA)
)
GO

create table LOPTINCHI
(
	MALTC varchar(10) primary key not null,
	MAGV varchar(10) not null,
	HOCKY int,
	NIENKHOA int,
	MAMH varchar(10) not null,
	MAKHOA varchar(10) not null,
	MALOP varchar(10) not null,
	NHOM nvarchar(20),
	SOSV int,

	foreign key(MAKHOA) references KHOA(MAKHOA),
	foreign key(MAMH) references MONHOC(MAMH),
	foreign key(MAGV) references GIANGVIEN(MAGV)

	
)
go

create table DIEM
(
	MALTC varchar(10)  not null,
	MASV varchar(10)   not null,
	DIEM_QT float,
	DIEM_GK float,
	DIEM_CK float,

	foreign key(MALTC) references LOPTINCHI(MALTC),
	foreign key(MASV) references SINHVIEN(MASV)
)
go

SET DATEFORMAT DMY

INSERT INTO KHOA VALUES
('CNTT',N'CÔNG NGHỆ THÔNG TIN'),
('QTKD',N'QUẢN TRỊ KINH DOANH'),
('LUAT',N'LUẬT')

INSERT INTO MONHOC VALUES
('LTM',N'LẬP TRÌNH MẠNG',45,30),
('BMM',N'BẢO MẬT MẠNG',45,30),
('NMM',N'NHẬP MÔN MẠNG',45,30),
('LDS',N'LUẬT DÂN SỰ',45,0),
('LKT',N'LUẬT KINH TẾ',45,0),
('LHC',N'LUẬT HÀNH CHÍNH',30,0),
('XSTK',N'XÁC SUẤT THỐNG KÊ',45,30),
('QTKN',N'QUẢN TRỊ KHỞI NGHIỆP',45,0),
('QTDN',N'QUẢN TRỊ DOANH NGHIỆP',45,0)

INSERT INTO LOP VALUES
('MMT', N'MẠNG MÁY TÍNH', 'CNTT', N'CÔNG NGHỆ THÔNG TIN'),
('KTPM', N'KỸ THUẬT PHẦN MỀM', 'CNTT', N'CÔNG NGHỆ THÔNG TIN'),
('LLD', N'LUẬT LAO ĐỘNG', 'LUAT', N'LUẬT'),
('LHS', N'LUẬT HÌNH SỰ', 'LUAT', N'LUẬT'),
('QTNL', N'QUẢN TRỊ NHÂN LỰC', 'QTKD', N'QUẢN TRỊ KINH DOANH'),
('QLKS', N'QUẢN LÝ KHÁCH SẠN', 'QTKD', N'QUẢN TRỊ KINH DOANH')

INSERT INTO GIANGVIEN VALUES
('GV01','CNTT',N'NGUYỄN VĂN',N'MẠNH'),
('GV02','CNTT',N'MAI THỊ',N'ĐÀO'),
('GV03','LUAT',N'PHAN CÔNG',N'DANH'),
('GV04','LUAT',N'LÊ XUÂN',N'OANH'),
('GV05','QTKD',N'TRẦN VĂN',N'THÁI'),
('GV06','QTKD',N'TRƯƠNG NGỌC',N'ÁNH')

INSERT INTO LOPTINCHI VALUES
('LTC01', 'GV01', 1, 2022, 'BMM', 'CNTT', 'MMT', N'10', 30),
('LTC02', 'GV02', 2, 2022, 'LTM', 'CNTT', 'KTPM', N'14', 30),
('LTC03', 'GV03', 1, 2022, 'LDS', 'LUAT', 'LLD', N'8', 25),
('LTC04', 'GV04', 2, 2022, 'LKT', 'LUAT', 'LHS', N'9', 30),
('LTC05', 'GV05', 1, 2022, 'XSTK', 'QTKD', 'QTNL', N'16', 25),
('LTC06', 'GV06', 2, 2022, 'QTDN', 'QTKD', 'QLKS', N'18', 30)



INSERT INTO SINHVIEN VALUES
('SV01',N'NGUYỄN PHONG',N'TÚ','NAM','1/9/2001',N'TÂY NINH','MMT'),
('SV02',N'LÊ TIỂU',N'LONG','NAM','10/9/2001',N'ĐỒNG THÁP','MMT'),
('SV03',N'NGÔ TRẦN',N'ĐÔ','NAM','23/8/2001',N'BÌNH ĐỊNH','KTPM'),
('SV04',N'NGUYỄN HỒNG',N'CẨM','NỮ','8/3/2001',N'TP.HCM','KTPM'),
('SV05',N'LÊ TÚ',N'ANH','NỮ','5/5/2001',N'LÂM ĐỒNG','LLD'),
('SV06',N'PHAN THỊ',N'ĐÀO','NỮ','6/8/2001',N'BÌNH THUẬN','LLD'),
('SV07',N'ĐOÀN XUÂN',N'PHONG','NAM','24/2/2001',N'PHÚ YÊN','LHS'),
('SV08',N'PHAN VĂN',N'SĨ','NAM','28/4/2001',N'BÌNH DƯƠNG','LHS'),
('SV09',N'MAI HOÀNG',N'VIỆT','NAM','12/7/2001',N'AN GIANG','QTNL'),
('SV10',N'MAI HOÀNG',N'NAM','NAM','12/8/2001',N'CÀ MAU','QTNL'),
('SV11',N'NGUYỄN HOA',N'MAI','NỮ','21/3/2001',N'HUẾ','QLKS'),
('SV12',N'PHẠM THỊ',N'LAN','NỮ','26/11/2001',N'ĐÀ NẴNG','QLKS')

INSERT INTO DIEM VALUES
('LTC01','SV01',8.0,7.0,8.0),
('LTC02','SV03',8.5,7.0,8.5),
('LTC03','SV05',9.0,9.0,9.0),
('LTC04','SV07',6.0,7.9,6.9),
('LTC05','SV09',7.3,6.5,8.7),
('LTC06','SV11',6.9,6.5,7.6)


