





CREATE DATABASE QUANLYNHANSU
ON 
( 
  name = quanlynhansu,
  size = 100,
  filegrowth = 10,
  maxsize = 2GB,
  filename = 'D:\TEST.mdf'
)
log on
(
  name = QLNS_log,
  size = 200,
  filegrowth = 20,
  maxsize = Unlimited,
  filename = 'D:\TEST.ldf'
)


USE QUANLYNHANSU 
GO

insert into LoaiHopDong(maLoaiHopDong, tenLHD) values ('HDLA', 'Hợp đồng lao động')
insert into HopDongLaoDong(maSoHopDong, maNV, ghichu) values ('HD001', 'NV001', '')
insert into ChiTietHopDongLaoDong(maSoHopDongLaoDong, maLanHD, ngayBD, maLoaiHopDong, ngayBD, ngayKT, maPhongBan, maChucvu, mucLuong, anTrua, tongLuong, nguoiKi, maCV)
values ('HD001', 'L001', '10/15/2017', 'HDLD', '12/30/2017', '1/1/2020', 'PgHC', 'KT', '5000000', '1500000', '', 'Giám đốc nhân sự', 'NV010');
insert into SoBHYT(maSBHYT, maNV, ngaycap, manoicap, giatri) 
values ('1001', 'NV001', '1/1/2020', '29', '720000')
select * from ChiTietHopDongLaoDong
