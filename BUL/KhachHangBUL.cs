using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class KhachHangBUL
    {
        KhachHangDAL khachhangDAL;

        public KhachHangBUL()
        {
            khachhangDAL = new KhachHangDAL();
        }
        public List<KhachHangDTO> getKhachHang()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();

            DataTable dt = khachhangDAL.getKhachHang();
            foreach (DataRow dr in dt.Rows)
            {
                // Khởi tạo đối tượng KhachHangDTO với tất cả các tham số
                KhachHangDTO khachhang = new KhachHangDTO(
                    dr["maKhachHang"].ToString(),
                    dr["tenKhachHang"].ToString(),
                    dr["diaChi"].ToString(),
                    dr["email"].ToString(),
                    dr["SDT"].ToString()
                );

                list.Add(khachhang);
            }
            return list;
        }
        public string layMaTuDong()
        {
            return khachhangDAL.layMaTuDong(); // Gọi phương thức từ DAL để lấy mã tự động
        }
        public DataTable LayTatCaKhachHang()
        {
            return khachhangDAL.LayTatCaKhachHang();
        }
        public bool ThemKhachHang(string tenKhachHang, string diaChi, string email, string sdt)
        {
            string maKhachHang = khachhangDAL.layMaTuDong(); // Lấy mã khách hàng tự động
            KhachHangDTO khachHangMoi = new KhachHangDTO(maKhachHang, tenKhachHang, diaChi, email, sdt);
            return khachhangDAL.ThemKhachHang(khachHangMoi);
        }
        public bool SuaKhachHang(KhachHangDTO khachHang)
        {
            // Kiểm tra mã khách hàng có tồn tại không
            if (!khachhangDAL.CheckMaKhachHang(khachHang.MaKhachHang))
            {
                throw new Exception("Mã khách hàng không tồn tại");
            }
            return khachhangDAL.SuaKhachHang(khachHang);
        }
        public bool XoaKhachHang(string maKhachHang)
        {
            return khachhangDAL.XoaKhachHang(maKhachHang);
        }

        public KhachHangDTO layKhachHangTheoSDT(string sdt)
        {
            return khachhangDAL.layKhachHangTheoSDT(sdt);
        }
    }
}
