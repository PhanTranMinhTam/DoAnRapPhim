create database QL_RAPCHIEUPHIM
use QL_RAPCHIEUPHIM

CREATE TABLE ChucVu (
    maChucVu VARCHAR(10) PRIMARY KEY,
    tenChucVu NVARCHAR(255)
);

CREATE TABLE NhanVien (
    maNhanVien VARCHAR(10) PRIMARY KEY,
    tenNhanVien NVARCHAR(255),
    diaChi NVARCHAR(255),
    email NVARCHAR(255),
    SDT NVARCHAR(15)
);

CREATE TABLE TaiKhoan (
    tenDangNhap NVARCHAR(255) PRIMARY KEY,
    pass NVARCHAR(255),
    hoatDong INT,
    maNhanVien VARCHAR(10),
    FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);

CREATE TABLE NhanVien_ChucVu (
	tenDangNhap NVARCHAR(255),
    maChucVu VARCHAR(10),
    PRIMARY KEY (maChucVu, tenDangNhap),
    FOREIGN KEY (maChucVu) REFERENCES ChucVu(maChucVu),
    FOREIGN KEY (tenDangNhap) REFERENCES TaiKhoan(tenDangNhap)
);

CREATE TABLE DM_ManHinh (
    maManHinh VARCHAR(10) PRIMARY KEY,
    tenManHinh NVARCHAR(255)
);

CREATE TABLE PhanQuyen (
    maChucVu VARCHAR(10),
    maManHinh VARCHAR(10),
    coQuyen INT,
);

CREATE TABLE KhachHang (
    maKhachHang VARCHAR(10) PRIMARY KEY,
    tenKhachHang NVARCHAR(255),
    diaChi NVARCHAR(255),
    email NVARCHAR(255),
    SDT NVARCHAR(15)
);

CREATE TABLE KhuyenMai (
    maKhuyenMai VARCHAR(10) PRIMARY KEY,
    tenKM NVARCHAR(255),
    thoiGianBD DATE,
    thoiGianKT DATE,
    phanTramKhuyenMai DECIMAL(5, 2),
    trangThai INT
);

CREATE TABLE HoaDon (
    maHD VARCHAR(10) PRIMARY KEY,
    maNV VARCHAR(10),
    maKH VARCHAR(10),
    ngayBan DATE,
    tongTien DECIMAL(18, 2),
    maKhuyenMai VARCHAR(10),
    FOREIGN KEY (maNV) REFERENCES NhanVien(maNhanVien),
    FOREIGN KEY (maKH) REFERENCES KhachHang(maKhachHang),
	FOREIGN KEY (maKhuyenMai) REFERENCES KhuyenMai(maKhuyenMai)
);

CREATE TABLE DoAn (
    maDoAn VARCHAR(10) PRIMARY KEY,
    tenDoAn NVARCHAR(255),
    donGia DECIMAL(18, 2),
    hinhAnh NVARCHAR(255),
    trangThai INT,
	soLuong INT
);

CREATE TABLE CT_DoAn (
    maHD VARCHAR(10),
    maDoAn VARCHAR(10),
    soLuong INT,
    thanhTien DECIMAL(18, 2),
    PRIMARY KEY (maHD, maDoAn),
    FOREIGN KEY (maHD) REFERENCES HoaDon(maHD),
    FOREIGN KEY (maDoAn) REFERENCES DoAn(maDoAn)
);

CREATE TABLE PhongChieu (
    maPhongChieu VARCHAR(10) PRIMARY KEY,
    tenPhongChieu NVARCHAR(255),
    soLuongGhe INT
);

CREATE TABLE LoaiPhim (
    maLoai VARCHAR(10) PRIMARY KEY,
    tenLoai NVARCHAR(255),
    moTa NVARCHAR(MAX)
);

CREATE TABLE Phim (
    maPhim VARCHAR(10) PRIMARY KEY,
    tenPhim NVARCHAR(255),
    thoiLuong INT,
    daoDien NVARCHAR(255),
    quocGia NVARCHAR(255),
    noiDung NVARCHAR(MAX),
    hinhAnh NVARCHAR(255),
    ngayChieu DATE,
    ngayKT DATE,
    trangThai INT
);

CREATE TABLE Phim_LoaiPhim (
    maPhim VARCHAR(10),
    maLoai VARCHAR(10),
    PRIMARY KEY (maPhim, maLoai),
    FOREIGN KEY (maPhim) REFERENCES Phim(maPhim),
    FOREIGN KEY (maLoai) REFERENCES LoaiPhim(maLoai)
);

CREATE TABLE LichChieu (
    maLichChieu VARCHAR(10) PRIMARY KEY,
    maPhim VARCHAR(10),
    maPhongChieu VARCHAR(10),
    ngayChieu DATE,
    gioBD TIME,
    gioKT TIME,
	FOREIGN KEY (maPhongChieu) REFERENCES PhongChieu(maPhongChieu),
    FOREIGN KEY (maPhim) REFERENCES Phim(maPhim)
);

CREATE TABLE Ghe (
    maGhe VARCHAR(10) PRIMARY KEY,
    maPhongChieu VARCHAR(10),
	cots VARCHAR(5),
	hang VARCHAR(5),
    loaiGhe NVARCHAR(50),
    trangThai INT,
	gia DECIMAL(18, 2),
    FOREIGN KEY (maPhongChieu) REFERENCES PhongChieu(maPhongChieu)
);

CREATE TABLE CT_Ve (
    maHD VARCHAR(10),
    maGhe VARCHAR(10),
    maLichChieu VARCHAR(10),
    PRIMARY KEY (maHD, maGhe, maLichChieu),
    FOREIGN KEY (maHD) REFERENCES HoaDon(maHD),
    FOREIGN KEY (maGhe) REFERENCES Ghe(maGhe),
    FOREIGN KEY (maLichChieu) REFERENCES LichChieu(maLichChieu)
);

INSERT INTO ChucVu (maChucVu, tenChucVu)
VALUES
('CV001', N'Quản lý'),
('CV002', N'Nhân viên bán vé'),
('CV003', N'Nhân viên quản lý phim')

select * from ChucVu

INSERT INTO NhanVien (maNhanVien, tenNhanVien, diaChi, email, SDT)
VALUES
('NV001', N'Nguyễn Hữu Minh', N'TP.HCM', 'nguyenhuu@gmail.com', '0901234567'),
('NV002', N'Trần Thị Lan', N'Hà Nội', 'tranlan@gmail.com', '0912345678'),
('NV003', N'Lê Quốc Đạt', N'Đà Nẵng', 'lequocdat@gmail.com', '0923456789'),
('NV004', N'Phạm Ngọc Bích', N'Hải Phòng', 'phamngocbich@gmail.com', '0934567890'),
('NV005', N'Hoàng Văn Hoàng', N'Cần Thơ', 'hoangvanhoang@gmail.com', '0945678901'),
('NV006', N'Ngô Thị Hồng', N'Nha Trang', 'ngothihong@gmail.com', '0956789012'),
('NV007', N'Lý Minh Anh', N'Huế', 'lyminhanh@gmail.com', '0967890123'),
('NV008', N'Đặng Hữu Tài', N'Biên Hòa', 'danghuutai@gmail.com', '0978901234'),
('NV009', N'Nguyễn Thanh Sơn', N'Vũng Tàu', 'nguyenthanhson@gmail.com', '0989012345'),
('NV010', N'Trần Kim Chi', N'Bình Dương', 'trankimchi@gmail.com', '0990123456');

select * from NhanVien

INSERT INTO TaiKhoan (tenDangNhap, pass, hoatDong, maNhanVien)
VALUES
('huuminh', 'Pass@123', 1, 'NV001'),
('thilan', 'Lan#4567', 1, 'NV002'),
('quocdat', 'Dat$8901', 0, 'NV003'),
('ngocbich', 'Bich*234', 1, 'NV004'),
('vanhoang', 'Hoang&567', 0, 'NV005'),
('thihong', 'Hong@890', 1, 'NV006'),
('minhanh', 'Anh%3456', 0, 'NV007'),
('huutai', 'Tai!6789', 1, 'NV008'),
('thanhson', 'Son#0123', 0, 'NV009'),
('kimchi', 'Chi&4567', 1, 'NV010');

select * from TaiKhoan

INSERT INTO NhanVien_ChucVu (tenDangNhap, maChucVu)
VALUES
('huuminh', 'CV001'),
('thilan', 'CV002'),
('quocdat', 'CV003'),
('ngocbich', 'CV002'),
('vanhoang', 'CV002'),
('thihong', 'CV003'),
('minhanh', 'CV003'),
('huutai', 'CV002'),
('thanhson', 'CV003'),
('kimchi', 'CV002');

select * from NhanVien_ChucVu 

INSERT INTO DM_ManHinh (maManHinh, tenManHinh)
VALUES
('MH001', 'frm_QLNhanVien'),
('MH002', 'frm_QLKhuyenMai'),
('MH003', 'frm_QLPhim'),
('MH004', 'frm_QLVe'),
('MH005', 'frm_QLPhongChieu'),
('MH006', 'frm_QLLoaiPhim'),
('MH007', 'frm_ThongKe'),
('MH008', 'frm_QLDichVu'),
('MH009', 'frm_QLLichChieu'),
('MH010', 'frm_QLNguoiDung');

select * from DM_ManHinh 

INSERT INTO KhachHang (maKhachHang, tenKhachHang, diaChi, email, SDT)
VALUES
('KH001', N'Phạm Văn Minh', N'Hồ Chí Minh', 'phamvanm@gmail.com', '0905678901'),
('KH002', N'Nguyễn Thị Ngọc', N'Hà Nội', 'nguyenthim@gmail.com', '0916789012'),
('KH003', N'Trần Văn Oanh', N'Đà Nẵng', 'tranvano@gmail.com', '0927890123'),
('KH004', N'Lê Thị Phương', N'Hải Phòng', 'lethip@gmail.com', '0938901234'),
('KH005', N'Hoàng Văn Quang', N'Cần Thơ', 'hoangvanq@gmail.com', '0949012345'),
('KH006', N'Ngô Thị Rạng', N'Nha Trang', 'ngothir@gmail.com', '0950123456'),
('KH007', N'Lý Văn Sơn', N'Huế', 'lyvans@gmail.com', '0961234567'),
('KH008', N'Đặng Thị Thanh', N'Biên Hòa', 'dangthit@gmail.com', '0972345678'),
('KH009', N'Nguyễn Văn Út', N'Vũng Tàu', 'nguyenvanu@gmail.com', '0983456789'),
('KH010', N'Trần Thị Vân', N'Bình Dương', 'tranthiv@gmail.com', '0994567890');

select * from KhachHang

INSERT INTO KhuyenMai (maKhuyenMai, tenKM, thoiGianBD, thoiGianKT, phanTramKhuyenMai, trangThai)
VALUES
('KM001', N'Khuyến mãi 10%', '2024-01-01', '2024-01-31', 0.10, 1),
('KM002', N'Khuyến mãi 20%', '2024-02-01', '2024-02-28', 0.20, 1),
('KM003', N'Khuyến mãi 15%', '2024-03-01', '2024-03-31', 0.15, 0),
('KM004', N'Khuyến mãi 5%', '2024-04-01', '2024-04-30', 0.05, 1),
('KM005', N'Khuyến mãi 50%', '2024-05-01', '2024-05-31', 0.50, 0),
('KM006', N'Khuyến mãi 30%', '2024-06-01', '2024-06-30', 0.30, 1),
('KM007', N'Khuyến mãi 40%', '2024-07-01', '2024-07-31', 0.40, 0),
('KM008', N'Khuyến mãi 25%', '2024-08-01', '2024-08-31', 0.25, 1),
('KM009', N'Khuyến mãi 35%', '2024-09-01', '2024-09-30', 0.35, 1),
('KM010', N'Khuyến mãi 45%', '2024-10-01', '2024-10-31', 0.45, 0);

select * from KhuyenMai

INSERT INTO PhongChieu (maPhongChieu, tenPhongChieu, soLuongGhe)
VALUES
('PC001', N'Phòng Chiếu 1', 30),
('PC002', N'Phòng Chiếu 2', 20),
('PC003', N'Phòng Chiếu 3', 20),
('PC004', N'Phòng Chiếu 4', 25),
('PC005', N'Phòng Chiếu 5', 35)

select * from PhongChieu

INSERT INTO LoaiPhim (maLoai, tenLoai, moTa)
VALUES
('LP001', N'Hành Động', N'Phim hành động với nhiều pha hành động kịch tính.'),
('LP002', N'Hài Hước', N'Phim hài hước mang lại tiếng cười cho khán giả.'),
('LP003', N'Tâm Lý', N'Phim tâm lý, cảm xúc sâu sắc về cuộc sống.'),
('LP004', N'Kinh Dị', N'Phim kinh dị với nhiều tình huống gây sợ hãi.'),
('LP005', N'Hoạt Hình', N'Phim hoạt hình dành cho trẻ em và người lớn.'),
('LP006', N'Khoa Học Viễn Tưởng', N'Phim khoa học viễn tưởng với những yếu tố giả tưởng.'),
('LP007', N'Tình Cảm', N'Phim tình cảm với những câu chuyện tình yêu lãng mạn.'),
('LP008', N'Hồi Hộp', N'Phim hồi hộp, căng thẳng với nhiều bất ngờ.'),
('LP009', N'Tài Liệu', N'Phim tài liệu khám phá những chủ đề thực tế.'),
('LP010', N'Ca Nhạc', N'Phim ca nhạc, nhảy múa với các bài hát hấp dẫn.');

select * from LoaiPhim

INSERT INTO Phim (maPhim, tenPhim, thoiLuong, daoDien, quocGia, noiDung, hinhAnh, ngayChieu, ngayKT, trangThai)
VALUES
('PH001', N'Em Chưa 18', 100, N'Erik Nguyễn', N'Việt Nam', N'Một bộ phim hài lãng mạn xoay quanh câu chuyện tình yêu thú vị giữa một cô gái trẻ và một người đàn ông lớn tuổi.', N'em_chua_18.jpg', '2024-01-01', '2024-01-31', 1),
('PH002', N'Tình Người Duyên Ma', 110, N'Victor Vũ', N'Việt Nam', N'Một câu chuyện tình yêu bi kịch giữa con người và thế giới tâm linh.', N'tinh_nguoi_duyen_ma.jpg', '2024-02-01', '2024-02-28', 1),
('PH003', N'Nhà Bà Nữ', 120, N'Huỳnh Đông', N'Việt Nam', N'Câu chuyện về một gia đình truyền thống tại Sài Gòn với những tình huống hài hước và sâu sắc.', N'nha_ba_nu.jpg', '2024-03-01', '2024-03-31', 1),
('PH004', N'The Conjuring', 112, N'James Wan', N'Mỹ', N'Một gia đình phải đối mặt với những hiện tượng kỳ bí khi chuyển đến một ngôi nhà mới.', N'the_conjuring.jpg', '2024-04-01', '2024-04-30', 1),
('PH005', N'Interstellar', 169, N'Christopher Nolan', N'Mỹ', N'Một cuộc hành trình xuyên không gian và thời gian để tìm kiếm một hành tinh mới cho nhân loại.', N'interstellar.jpg', '2024-06-01', '2024-06-30', 1),
('PH006', N'Bố Già', 120, N'Trấn Thành', N'Việt Nam', N'Một bộ phim hài cảm động xoay quanh mối quan hệ giữa cha và con, khám phá những khó khăn trong cuộc sống gia đình.', N'bo_gia.jpg', '2024-06-01', '2024-06-30', 1),
('PH007', N'Fast & Furious 10', 140, N'Louis Leterrier', N'Mỹ', N'Một bộ phim hành động về cuộc chiến giữa các băng nhóm, với những pha đua xe tốc độ và tình bạn bền chặt.', N'fast_furious_10.jpg', '2024-07-01', '2024-07-31', 1),
('PH008', N'John Wick: Chapter 4', 169, N'Chad Stahelski', N'Mỹ', N'Một cuộc chiến không ngừng nghỉ của John Wick khi anh tìm cách thoát khỏi tổ chức tội phạm.', N'john_wick_4.jpg', '2024-01-01', '2024-01-31', 1),
('PH009', N'Hồn Papa, Da Con Gái', 120, N'Nguyễn Hữu Tiến', N'Việt Nam', N'Một bộ phim hài lãng mạn về tình cha con và những khó khăn trong cuộc sống.', N'hon_papa_da_con_gai.jpg', '2024-09-01', '2024-09-30', 1),
('PH010', N'Người Bất Tử', 130, N'Nguyễn Phan Quang Bình', N'Việt Nam', N'Một câu chuyện kỳ bí về cuộc sống và tình yêu kéo dài qua nhiều thế kỷ.', N'nguoi_bat_tu.jpg', '2024-10-01', '2024-10-31', 1);

select * from Phim

INSERT INTO Phim_LoaiPhim (maPhim, maLoai)
VALUES
('PH001', 'LP002'), 
('PH002', 'LP003'), 
('PH003', 'LP002'), 
('PH004', 'LP004'), 
('PH005', 'LP006'), 
('PH006', 'LP002'), 
('PH007', 'LP001'), 
('PH008', 'LP001'), 
('PH009', 'LP002'), 
('PH010', 'LP003'); 

select * from Phim_LoaiPhim

INSERT INTO LichChieu (maLichChieu, maPhim, maPhongChieu, ngayChieu, gioBD, gioKT)
VALUES
('LC001', 'PH001', 'PC001', '2025-01-01', '19:00', '21:00'),
('LC002', 'PH002', 'PC002', '2025-02-01', '20:00', '21:30'),
('LC003', 'PH003', 'PC003', '2024-10-21', '18:30', '20:00'),
('LC004', 'PH004', 'PC004', '2025-04-01', '21:00', '22:30'),
('LC005', 'PH005', 'PC005', '2024-12-25', '17:45', '18:30'),
('LC006', 'PH006', 'PC001', '2024-12-19', '16:00', '18:00'),
('LC007', 'PH007', 'PC003', '2024-11-30', '15:00', '16:30'),
('LC008', 'PH008', 'PC004', '2024-12-30', '14:00', '15:30'),
('LC009', 'PH009', 'PC002', '2024-12-01', '13:00', '14:00'),
('LC010', 'PH010', 'PC001', '2024-11-01', '12:00', '13:30');
select * from LichChieu

INSERT INTO Ghe (maGhe, maPhongChieu, cots, hang, loaiGhe, trangThai)
VALUES
-- Phòng Chiếu 1
('G001', 'PC001', 'A1', '1', N'VIP', 0),
('G002', 'PC001', 'A2', '1', N'VIP', 0),
('G003', 'PC001', 'A3', '1', N'VIP', 0),
('G004', 'PC001', 'A4', '1', N'VIP', 0),
('G005', 'PC001', 'A5', '1', N'VIP', 0),
('G006', 'PC001', 'B1', '2', N'Thường', 0),
('G007', 'PC001', 'B2', '2', N'Thường', 0),
('G008', 'PC001', 'B3', '2', N'Thường', 0),
('G009', 'PC001', 'B4', '2', N'Thường', 0),
('G010', 'PC001', 'B5', '2', N'Thường', 0),
('G011', 'PC001', 'C1', '3', N'Thường', 0),
('G012', 'PC001', 'C2', '3', N'Thường', 0),
('G013', 'PC001', 'C3', '3', N'Thường', 0),
('G014', 'PC001', 'C4', '3', N'Thường', 0),
('G015', 'PC001', 'C5', '3', N'Thường', 0),
('G016', 'PC001', 'C6', '3', N'Thường', 0),
('G017', 'PC001', 'C7', '3', N'Thường', 0),
('G018', 'PC001', 'C8', '3', N'Thường', 0),
('G019', 'PC001', 'C9', '3', N'Thường', 0),
('G020', 'PC001', 'C10', '3', N'Thường', 0),
('G021', 'PC001', 'D1', '4', N'Thường', 0),
('G022', 'PC001', 'D2', '4', N'Thường', 0),
('G023', 'PC001', 'D3', '4', N'Thường', 0),
('G024', 'PC001', 'D4', '4', N'Thường', 0),
('G025', 'PC001', 'D5', '4', N'Thường', 0),
('G026', 'PC001', 'D6', '4', N'Thường', 0),
('G027', 'PC001', 'D7', '4', N'Thường', 0),
('G028', 'PC001', 'D8', '4', N'Thường', 0),
('G029', 'PC001', 'D9', '4', N'Thường', 0),
('G030', 'PC001', 'D10', '4', N'Thường', 0),
--Phong chieu 2
('G031', 'PC002', 'A1', '1', N'VIP', 0),
('G032', 'PC002', 'A2', '1', N'VIP', 0),
('G033', 'PC002', 'A3', '1', N'VIP', 0),
('G034', 'PC002', 'A4', '1', N'VIP', 0),
('G035', 'PC002', 'A5', '1', N'VIP', 0),
('G036', 'PC002', 'B1', '2', N'Thường', 0),
('G037', 'PC002', 'B2', '2', N'Thường', 0),
('G038', 'PC002', 'B3', '2', N'Thường', 0),
('G039', 'PC002', 'B4', '2', N'Thường', 0),
('G040', 'PC002', 'B5', '2', N'Thường', 0),
('G041', 'PC002', 'C1', '3', N'Thường', 0),
('G042', 'PC002', 'C2', '3', N'Thường', 0),
('G043', 'PC002', 'C3', '3', N'Thường', 0),
('G044', 'PC002', 'C4', '3', N'Thường', 0),
('G045', 'PC002', 'C5', '3', N'Thường', 0),
('G046', 'PC002', 'D1', '4', N'Thường', 0),
('G047', 'PC002', 'D2', '4', N'Thường', 0),
('G048', 'PC002', 'D3', '4', N'Thường', 0),
('G049', 'PC002', 'D4', '4', N'Thường', 0),
('G050', 'PC002', 'D5', '4', N'Thường', 0),
--Phong chieu 3
('G051', 'PC003', 'A1', '1', N'VIP', 0),
('G052', 'PC003', 'A2', '1', N'VIP', 0),
('G053', 'PC003', 'A3', '1', N'VIP', 0),
('G054', 'PC003', 'A4', '1', N'VIP', 0),
('G055', 'PC003', 'A5', '1', N'VIP', 0),
('G056', 'PC003', 'B1', '2', N'VIP', 0),
('G057', 'PC003', 'B2', '2', N'VIP', 0),
('G058', 'PC003', 'B3', '2', N'VIP', 0),
('G059', 'PC003', 'B4', '2', N'VIP', 0),
('G060', 'PC003', 'B5', '2', N'VIP', 0),
('G061', 'PC003', 'C1', '3', N'Thường', 0),
('G062', 'PC003', 'C2', '3', N'Thường', 0),
('G063', 'PC003', 'C3', '3', N'Thường', 0),
('G064', 'PC003', 'C4', '3', N'Thường', 0),
('G065', 'PC003', 'C5', '3', N'Thường', 0),
('G066', 'PC003', 'C6', '3', N'Thường', 0),
('G067', 'PC003', 'C7', '3', N'Thường', 0),
('G068', 'PC003', 'C8', '3', N'Thường', 0),
('G069', 'PC003', 'C9', '3', N'Thường', 0),
('G070', 'PC003', 'C10', '3', N'Thường', 0),
--Phong chieu 4
('G071', 'PC004', 'A1', '1', N'VIP', 0),
('G072', 'PC004', 'A2', '1', N'VIP', 0),
('G073', 'PC004', 'A3', '1', N'VIP', 0),
('G074', 'PC004', 'A4', '1', N'VIP', 0),
('G075', 'PC004', 'A5', '1', N'VIP', 0),
('G076', 'PC004', 'B1', '2', N'Thường', 0),
('G077', 'PC004', 'B2', '2', N'Thường', 0),
('G078', 'PC004', 'B3', '2', N'Thường', 0),
('G079', 'PC004', 'B4', '2', N'Thường', 0),
('G080', 'PC004', 'B5', '2', N'Thường', 0),
('G081', 'PC004', 'C1', '3', N'Thường', 0),
('G082', 'PC004', 'C2', '3', N'Thường', 0),
('G083', 'PC004', 'C3', '3', N'Thường', 0),
('G084', 'PC004', 'C4', '3', N'Thường', 0),
('G085', 'PC004', 'C5', '3', N'Thường', 0),
('G086', 'PC004', 'C6', '3', N'Thường', 0),
('G087', 'PC004', 'C7', '3', N'Thường', 0),
('G088', 'PC004', 'C8', '3', N'Thường', 0),
('G089', 'PC004', 'C9', '3', N'Thường', 0),
('G090', 'PC004', 'C10', '3', N'Thường', 0),
('G091', 'PC004', 'D1', '4', N'Thường', 0),
('G092', 'PC004', 'D2', '4', N'Thường', 0),
('G093', 'PC004', 'D3', '4', N'Thường', 0),
('G094', 'PC004', 'D4', '4', N'Thường', 0),
('G095', 'PC004', 'D5', '4', N'Thường', 0),
--Phong chieu 5
('G096', 'PC005', 'A1', '1', N'VIP', 0),
('G097', 'PC005', 'A2', '1', N'VIP', 0),
('G098', 'PC005', 'A3', '1', N'VIP', 0),
('G099', 'PC005', 'A4', '1', N'VIP', 0),
('G100', 'PC005', 'A5', '1', N'VIP', 0),
('G101', 'PC005', 'B1', '2', N'Thường', 0),
('G102', 'PC005', 'B2', '2', N'Thường', 0),
('G103', 'PC005', 'B3', '2', N'Thường', 0),
('G104', 'PC005', 'B4', '2', N'Thường', 0),
('G105', 'PC005', 'B5', '2', N'Thường', 0),
('G106', 'PC005', 'C1', '3', N'Thường', 0),
('G107', 'PC005', 'C2', '3', N'Thường', 0),
('G108', 'PC005', 'C3', '3', N'Thường', 0),
('G109', 'PC005', 'C4', '3', N'Thường', 0),
('G110', 'PC005', 'C5', '3', N'Thường', 0),
('G111', 'PC005', 'C6', '3', N'Thường', 0),
('G112', 'PC005', 'C7', '3', N'Thường', 0),
('G113', 'PC005', 'C8', '3', N'Thường', 0),
('G114', 'PC005', 'C9', '3', N'Thường', 0),
('G115', 'PC005', 'C10', '3', N'Thường', 0),
('G116', 'PC005', 'D1', '4', N'Thường', 0),
('G117', 'PC005', 'D2', '4', N'Thường', 0),
('G118', 'PC005', 'D3', '4', N'Thường', 0),
('G119', 'PC005', 'D4', '4', N'Thường', 0),
('G120', 'PC005', 'D5', '4', N'Thường', 0);

select * from Ghe

INSERT INTO DoAn (maDoAn, tenDoAn, donGia, hinhAnh, trangThai)
VALUES
('DA001', N'Bắp rang', 50.00, 'images/popcorn.jpg', 1),
('DA002', N'Pepsi', 30.00, 'images/pepsi.jpg', 1),
('DA003', N'Nachos', 40.00, 'images/nachos.jpg', 1),
('DA004', N'Nước ngọt', 25.00, 'images/softdrink.jpg', 1),
('DA005', N'Hot Dog', 35.00, 'images/hotdog.jpg', 1),
('DA006', N'Kẹo', 15.00, 'images/candy.jpg', 1),
('DA007', N'Sô cô la', 20.00, 'images/chocolate.jpg', 1),
('DA008', N'Kem', 45.00, 'images/icecream.jpg', 1),
('DA009', N'Khoai tây chiên', 30.00, 'images/fries.jpg', 1),
('DA010', N'Pizza miếng', 60.00, 'images/pizza.jpg', 1);

ALTER TABLE NhanVien
ADD CONSTRAINT UC_SDT UNIQUE (SDT);

ALTER TABLE DoAn
ADD CONSTRAINT CK_SoLuong_GT0 CHECK (soLuong > 0);


-- 1. Create Trigger to Enforce ngayChieu Constraints
GO
CREATE TRIGGER trg_ValidateNgayChieu
ON LichChieu
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Phim p ON i.maPhim = p.maPhim
        WHERE i.ngayChieu < p.ngayChieu OR i.ngayChieu > p.ngayKT
    )
    BEGIN
        RAISERROR ('Ngày chiếu của lịch chiếu phải nằm trong khoảng thời gian ngày chiếu và 
		ngày kết của bảng phim.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END

