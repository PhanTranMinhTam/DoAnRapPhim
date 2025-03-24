using DAL;
using DTO;
using System.Collections.Generic;

namespace BUL
{
    public class NhanVienChucVuBUL
    {
        NhanVienChucVuDAL nhanVienChucVuDAL;

        public NhanVienChucVuBUL()
        {
            nhanVienChucVuDAL = new NhanVienChucVuDAL();
        }

        public List<NhanVienChucVuDTO> LayDanhSachNhanVienChucVu()
        {
            return nhanVienChucVuDAL.LayDanhSachNhanVienChucVu();
        }

        public bool themNhanVienChucVu(NhanVienChucVuDTO nhanVienChucVu)
        {
            return nhanVienChucVuDAL.themNhanVienChucVu(nhanVienChucVu);
        }

        public bool xoaNhanVienChucVu(string tenDangNhap, string maChucVu)
        {
            return nhanVienChucVuDAL.xoaNhanVienChucVu(tenDangNhap, maChucVu);
        }
        public bool suaNhanVienChucVu(NhanVienChucVuDTO nhanVienChucVu)
        {
            return nhanVienChucVuDAL.suaNhanVienChucVu(nhanVienChucVu);
        }
    }
}
