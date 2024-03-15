use SchoolEdu_Database;

create table NhanVien (
	MaGV nvarchar(30) not null primary key,
	TenGV nvarchar(30) not null,
	NgaySinh date,
	GioiTinh nvarchar(30) not null,
	DiaChi nvarchar(30) not null,
	MatKhau nvarchar(30) not null,
	VaiTro nvarchar(30) not null;
);

create table MONHOC
(
	MaMH nvarchar(30) not null primary key,
	TenMH nvarchar(30) not null,
	SoTC int,
);

create table LOP
(
	MaLop nvarchar(30) not null primary key,
	Khoa nvarchar(30) not null,
	Nganh nvarchar(30) not null,
	Nienkhoa nvarchar(30) not null,
	MaGV nvarchar(30) not null,
	constraint FK_MaGV foreign key (MaGV) references NhanVien(MaGV),
);

create table SINHVIEN
(
	MaSV nvarchar(30) not null primary key,
	TenSV nvarchar(30) not null,
	NgaySinh date,
	GioiTinh nvarchar(30),
	DiaChi nvarchar(30),
	MatKhau nvarchar(30),
	MaLop nvarchar(30) not null,
	constraint FK_MaLop foreign key (MaLop) references LOP(MaLop),
);

create table DiemSV
(
	MaSV nvarchar(30) not null,
	MaMH nvarchar(30) not null,
	primary key (MaSV, MaMH),
	LanThi int,
	DiemQT float,
	DiemThi float,
	CaThi nvarchar(30),
	NgayThi date,
	constraint FK_MaSV foreign key (MaSV) references SINHVIEN(MaSV),
	constraint FK_MaMH foreign key (MaMH) references MONHOC(MaMH),
);

create table GVMH
(
	MaGV nvarchar(30) not null,
	MaMH nvarchar(30) not null,
	primary key(MaGV, MaMH),
	Ngaybd date,
	Phonghoc nvarchar(30),
	CaHoc nvarchar(30),
	constraint FK_MaGV2 foreign key (MaGV) references NhanVien(MaGV),
	constraint FK_MaMH2 foreign key (MaMH) references MONHOC(MaMH),
);

create table SVMH
(
	MaSV nvarchar(30) not null,
	MaMH nvarchar(30) not null,
	primary key(MaSV, MaMH),
	Ngaybatdau date,
	Ngayketthuc date,
	SoTC int,
	constraint FK_MaSV1 foreign key (MaSV) references SINHVIEN(MaSV),
	constraint FK_MaMH3 foreign key (MaMH) references MONHOC(MaMH),
);