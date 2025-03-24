using DAL;
using DTO;
using System.Data;

namespace BUL
{
    public class DichVuBUL
    {
        DichVuDAL dvDAL = new DichVuDAL();
        public bool capNhatSoLuongMon(string maDoAn, int soLuong)
        {
            return dvDAL.capNhatSoLuongMon(maDoAn, soLuong);
        }
        public DataTable getDichVu()
        {
            return dvDAL.getDichVu();
        }

        public bool themDichVu(DichVuDTO dv, out string errorMessage)
        {
            return dvDAL.themDichVu(dv, out errorMessage);
        }


        public string taoMaDoAn()
        {
            return dvDAL.taoMaDoAn();
        }

        public DichVuDTO layThongTinDVTheoMa(string maDoAn)
        {
            return dvDAL.layThongTinDVTheoMa(maDoAn);
        }

        public bool xoaDichVu(string maDoAn)
        {
            return dvDAL.xoaDichVu(maDoAn);
        }

        public bool suaDichVu(DichVuDTO dv, out string errorMessage)
        {
            return dvDAL.suaDichVu(dv, out errorMessage);
        }


        public int laySoLuongMon(string maDoAn)
        {
            return dvDAL.laySoLuongMon(maDoAn);
        }


    }
}
