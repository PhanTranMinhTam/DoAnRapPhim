using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class HoaDonBUL
    {
        HoaDonDAL hdDAL = new HoaDonDAL();

        public string taoMaHoaDon()
        {
            return hdDAL.taoMaHoaDon();
        }

        public bool themHoaDon(HoaDonDTO hd)
        {
            return hdDAL.themHoaDon(hd);
        }

        public Dictionary<string, double> LayTongDoanhThuTheoThang()
        {
            return hdDAL.TinhTongDoanhThuTheoThang();
        }
        public DataTable LayDanhSachHoaDon()
        {
            return hdDAL.GetDanhSachHoaDon();
        }
        public DataTable LayDanhSachHoaDonTheoTenPhim(string tenPhim)
        {
            if (string.IsNullOrWhiteSpace(tenPhim))
            {
                throw new ArgumentException("Tên phim không được để trống.");
            }

            return hdDAL.GetDanhSachHoaDonTheoTenPhim(tenPhim);
        }
        public DataTable LayDanhSachHoaDonTheoThang(int thang, int nam)
        {
            return hdDAL.GetDanhSachHoaDonTheoThang(thang, nam);
        }
        public DataTable LayDanhSachHoaDonTheoTenPhimVaThangNam(string tenPhim, int thang, int nam)
        {
            return hdDAL.LayDanhSachHoaDonTheoTenPhimVaThangNam(tenPhim, thang, nam);
        }
        public decimal TinhTongDoanhThuTheoThang(int thang, int nam)
        {
            return hdDAL.TinhTongDoanhThuTheoThang(thang, nam);
        }

        // Phương thức tính tổng doanh thu cho tất cả hóa đơn
        public decimal TinhTongDoanhThu()
        {
            return hdDAL.TinhTongDoanhThu();
        }

        // Phương thức tính tổng doanh thu theo tên phim
        public decimal TinhTongDoanhThuTheoTenPhim(string tenPhim)
        {
            return hdDAL.TinhTongDoanhThuTheoTenPhim(tenPhim);
        }

        // Phương thức tính tổng doanh thu theo tên phim, tháng và năm
        public decimal TinhTongDoanhThuTheoTenPhimVaThangNam(string tenPhim, int thang, int nam)
        {
            return hdDAL.TinhTongDoanhThuTheoTenPhimVaThangNam(tenPhim, thang, nam);
        }
        public DataTable LayTongDoanhThuTheoThang(int nam)
        {
            return hdDAL.LayTongDoanhThuTheoThang(nam);
        }
        public DataTable LayDanhSachDoanhThu()
        {
            try
            {
                return hdDAL.LayDanhSachDoanhThu();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi hoặc log
                throw ex;
            }
        }
        public int LayTongSoVe()
        {
            return hdDAL.GetTongSoVe();
        }
        public int LayTongSoVeTheoPhim(string maPhim)
        {
            return hdDAL.GetTongSoVeTheoPhim(maPhim);
        }
        public DataTable Top5PhimDoanhThuTheoThangNam(int nam, int thang)
        {
            return hdDAL.Top5PhimDoanhThuTheoThangNam(nam, thang);
        }
        public DataTable Top5PhimDoanhThu()
        {
            return hdDAL.Top5PhimDoanhThu();
        }
        public DataTable DoanhThuTheoLoaiPhim(string maLoaiPhim)
        {
            return hdDAL.DoanhThuTheoLoaiPhim(maLoaiPhim);
        }
    }
}
