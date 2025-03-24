using DAL;
using DTO;
using System.Data;

namespace BUL
{
    public class PhanQuyenBUL
    {
        PhanQuyenDAL phanQuyenDAL;

        public PhanQuyenBUL()
        {
            phanQuyenDAL = new PhanQuyenDAL();
        }

        public DataTable layDanhSachQuyen(string maChucVu)
        {
            return phanQuyenDAL.layDanhSachQuyen(maChucVu);
        }


        public DataTable getDSQuyen()
        {
            return phanQuyenDAL.getDSQuyen();
        }

        public bool themQuyen(PhanQuyenDTO phanQuyen)
        {
            return phanQuyenDAL.themQuyen(phanQuyen);
        }

        public bool xoaQuyen(string maChucVu, string maManHinh)
        {
            return phanQuyenDAL.xoaQuyen(maChucVu, maManHinh);
        }

        public bool suaQuyen(PhanQuyenDTO phanQuyen)
        {
            return phanQuyenDAL.suaQuyen(phanQuyen);
        }
    }
}
