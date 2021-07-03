use master
go
CREATE DATABASE QL_NHASACH
go
use QL_NHASACH

create table TAIKHOAN
(
	tentk char(30) primary key,
	matkhau char(30),
	hoten nvarchar(50),
	chucvu nvarchar(20),
	gioitinh nvarchar(3),
	ngaysinh date,
)


create table CHUDE
(
	macd int identity(1,1) primary key,
	tencd nvarchar(50),

)

create table NHAXUATBAN
(
	manxb int identity(1,1) primary key,
	tennxb nvarchar(50),

)

create table TACGIA
(
	matg int identity(1,1) primary key,
	tentg nvarchar(50),
)

create table SACH
(
	masach int primary key,
	tensach nvarchar(50),
	gia int,
	soluong int,
	mota nvarchar(max),
	macd int,
	manxb int,
	matg int,
)



create table HOADON
(
	mahd int   primary key,
	nguoiban char(30),
	khachmua char(12),
	ngaymua char(50),
	tongtien int,
)

create table CHITIETHOADON
(
	mahd int not null,
	masach int not null,
	soluong int,
	thanhtien int,
)





alter table TAIKHOAN
add constraint chk_gt check (gioitinh=N'Nam' or gioitinh=N'Nữ')


alter table SACH
add constraint fk_1 foreign key(macd) references CHUDE(macd)

alter table SACH
add constraint fk_2 foreign key(manxb) references NHAXUATBAN(manxb)

alter table SACH
add constraint fk_3 foreign key(matg) references TACGIA(matg)

alter table HOADON
add constraint fk_4 foreign key(nguoiban) references TAIKHOAN(tentk)

alter table CHITIETHOADON
add constraint pk_5 primary key(mahd)

alter table CHITIETHOADON
add constraint fk_5 foreign key(mahd) references HOADON(mahd)

alter table CHITIETHOADON
add constraint fk_6 foreign key(masach) references SACH(masach)






set dateformat dmy
insert into TAIKHOAN values
('taivo', '123', N'Võ Hồ Tấn Tài',N'Quản lý', N'Nam', '18/12/2000'),
('baole1010', '101000', N'Lê Quốc Bảo',N'Quản lý', N'Nam', '10/10/2000')



insert into CHUDE values
( N'Văn học'),
( N'Huyền bí giả tưởng'),
(  N'Kinh điển'),
( N'Trinh thám'),
( N'Tản văn'),
( N'Tiểu sử'),
( N'Âm nhạc'),
( N'Tâm linh'),
( N'Khoa học'),
( N'Kỹ năng làm việc'),
( N'Tài chính'),
( N'Du ký')

insert into NHAXUATBAN values
(N'NXB Kim Đồng'),
(N'NXB Trẻ'),
(N'NXB Tổng hợp TpHCM'),
(N'NXB Chính trị quốc gia sự thật'),
(N'NXB Giáo dục'),
(N'NXB Hội nhà văn'),
(N'NXB Tư pháp'),
(N'NXB Thông tin và Truyền thông'),
(N'NXB Lao động'),
(N'NXB Giao thông vận tải'),
(N'NXB ĐH quốc gia Hà Nội')

insert into TACGIA values
( N'Ernest Miller Hemingway'),
(N'John Ronald Reuel Tolkien'),
( N'Victor Hugo'),
(N'Arthur Conan Doyle'),
(N'Miêu Công Tử'),
(N'Hermann Hesse'),
(N'Benjamin Graham'),
(N'Jack Kerouac')

insert into HOADON values 
(1,'baole1010','070345662','01/01/2020',20000)






