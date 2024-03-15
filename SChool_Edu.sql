use SchoolEdu_Database;

create table GIAOVIEN (
	MaGV nvarchar not null primary key,
	TenGV nvarchar not null,
	NgaySinh date,
	GioiTinh nvarchar not null,
	DiaChi nvarchar not null,
	MatKhau nvarchar not null,
	VaiTro nvarchar not null;
);

create table MONHOC
(
	MaMH nvarchar not null primary key,
	TenMH nvarchar not null,
	SoTC int,
);

create table LOP
(
	MaLop nvarchar not null primary key,
	Khoa nvarchar not null,
	Nganh nvarchar not null,
	Nienkhoa nvarchar not null,
	MaGV nvarchar not null,
	constraint FK_MaGV foreign key (MaGV) references NhanVien(MaGV),
);

create table SINHVIEN
(
	MaSV nvarchar not null primary key,
	TenSV nvarchar not null,
	NgaySinh date,
	GioiTinh nvarchar,
	DiaChi nvarchar,
	MatKhau nvarchar,
	MaLop nvarchar not null,
	constraint FK_MaLop foreign key (MaLop) references LOP(MaLop),
);

create table DiemSV
(
	MaSV nvarchar not null,
	MaMH nvarchar not null,
	primary key (MaSV, MaMH),
	LanThi int,
	DiemQT float,
	DiemThi float,
	CaThi nvarchar,
	NgayThi date,
	constraint FK_MaSV foreign key (MaSV) references SINHVIEN(MaSV),
	constraint FK_MaMH foreign key (MaMH) references MONHOC(MaMH),
);

create table GVMH
(
	MaGV nvarchar not null,
	MaMH nvarchar not null,
	primary key(MaGV, MaMH),
	Ngaybd date,
	Phonghoc nvarchar,
	CaHoc nvarchar,
	constraint FK_MaGV2 foreign key (MaGV) references NhanVien(MaGV),
	constraint FK_MaMH2 foreign key (MaMH) references MONHOC(MaMH),
);

create table SVMH
(
	MaSV nvarchar not null,
	MaMH nvarchar not null,
	primary key(MaSV, MaMH),
	Ngaybatdau date,
	Ngayketthuc date,
	SoTC int,
	constraint FK_MaSV1 foreign key (MaSV) references SINHVIEN(MaSV),
	constraint FK_MaMH3 foreign key (MaMH) references MONHOC(MaMH),
);