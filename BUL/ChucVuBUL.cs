using DAL;
using DTO;
using System.Collections.Generic;

namespace BUL
{
    public class ChucVuBUL
    {
        ChucVuDAL chucVuDAL;

        public ChucVuBUL()
        {
            chucVuDAL = new ChucVuDAL();
        }

        public List<ChucVuDTO> LayDanhSachChucVu()
        {
            return chucVuDAL.LayDanhSachChucVu();
        }

        public List<string> layMaChucVuTheoTenDangNhap(string tenDangNhap)
        {
            return chucVuDAL.layMaChucVuTheoTenDangNhap(tenDangNhap);
        }

        public string taoMaChucVu()
        {
            return chucVuDAL.taoMaChucVu();
        }

        public bool themChucVu(ChucVuDTO chucVu)
        {
            return chucVuDAL.themChucVu(chucVu);
        }

        public bool suaChucVu(ChucVuDTO chucVu)
        {
            return chucVuDAL.suaChucVu(chucVu);
        }

        public bool xoaChucVu(string maChucVu)
        {
            return chucVuDAL.xoaChucVu(maChucVu);
        }
    }
}
