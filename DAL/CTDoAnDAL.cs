using DTO;
using System.Linq;

namespace DAL
{
    public class CTDoAnDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public CTDoAnDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public string taoMaHoaDon()
        {
            string maHD = "HD";
            CT_DoAn query = db.CT_DoAns.OrderByDescending(x => x.maHD).FirstOrDefault();
            if (query != null)
            {
                int so = int.Parse(query.maHD.Substring(2)) + 1;
                if (so < 10)
                {
                    maHD += "00" + so;
                }
                else if (so < 100)
                {
                    maHD += "0" + so;
                }
                else
                {
                    maHD += so;
                }
            }
            else
            {
                maHD += "001";
            }
            return maHD;
        }

        public bool themCTDoAn(CTDoAnDTO ct)
        {
            try
            {
                CT_DoAn ctDoAn = new CT_DoAn();
                ctDoAn.maHD = ct.MaHD;
                ctDoAn.maDoAn = ct.MaDoAn;
                ctDoAn.soLuong = ct.SoLuong;
                ctDoAn.thanhTien = ct.ThanhTien;

                db.CT_DoAns.InsertOnSubmit(ctDoAn);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



        //public List<CTDoAnDTO> layDanhSachCTDoAn()
        //{
        //    IQueryable<CTDoAnDTO> query = from ct in db.CT_DoAns
        //                                  select new CTDoAnDTO
        //                                  {
        //                                      MaHD = ct.maHD,
        //                                      MaDoAn = ct.maDoAn,
        //                                      SoLuong = ct.soLuong,
        //                                      ThanhTien = ct.thanhTien
        //                                  };
        //    return query.ToList();
        //}

    }
}
