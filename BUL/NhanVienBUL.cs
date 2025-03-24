using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class NhanVienBUL
    {
        private NhanVienDAL nhanvienDAL;

        public NhanVienBUL()
        {
            nhanvienDAL = new NhanVienDAL();
        }

        public List<NhanVienDTO> getNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();

            DataTable dt = nhanvienDAL.getNhanVien();
            foreach (DataRow dr in dt.Rows)
            {
                NhanVienDTO nhanvien = new NhanVienDTO
                {
                    MaNhanVien = dr["maNhanVien"].ToString(),
                    TenNhanVien = dr["tenNhanVien"].ToString(),
                    DiaChi = dr["diaChi"].ToString(),
                    Email = dr["email"].ToString(),
                    SoDienThoai = dr["SDT"].ToString()
                };
                list.Add(nhanvien);
            }
            return list;
        }


        public int GetMaxMaNhanVien()
        {
            return nhanvienDAL.getMaxMaNhanVien();
        }

        public bool ThemNhanVien(NhanVienDTO nhanVien, out string errorMessage)
        {
            // Gọi hàm DAL và trả kết quả cùng thông báo lỗi
            return nhanvienDAL.themNhanVien(nhanVien, out errorMessage);
        }


        public bool SuaNhanVien(NhanVienDTO nhanVien, out string errorMessage)
        {
            return nhanvienDAL.suaNhanVien(nhanVien, out errorMessage);
        }



        public bool xoaNhanVien(string maNhanVien)
        {
            return nhanvienDAL.xoaNhanVien(maNhanVien);
        }

        public string layTenNhanVienTheoUsername(string username)
        {
            return nhanvienDAL.layTenNhanVienTheoUsername(username);
        }
    }
}
