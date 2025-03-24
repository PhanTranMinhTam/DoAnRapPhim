using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ChucVuDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();

        public ChucVuDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public List<ChucVuDTO> LayDanhSachChucVu()
        {
            List<ChucVuDTO> lstChucVu = new List<ChucVuDTO>();
            IQueryable<ChucVuDTO> chucVu = from cv in db.ChucVus
                                           select new ChucVuDTO
                                           {
                                               MaChucVu = cv.maChucVu,
                                               TenChucVu = cv.tenChucVu
                                           };
            lstChucVu = chucVu.ToList();
            return lstChucVu;
        }


        public List<string> layMaChucVuTheoTenDangNhap(string tenDangNhap)
        {
            List<string> maChucVu = (from tk in db.TaiKhoans
                                     join nvcv in db.NhanVien_ChucVus on tk.tenDangNhap equals nvcv.tenDangNhap
                                     where tk.tenDangNhap == tenDangNhap
                                     select nvcv.maChucVu).ToList();
            return maChucVu;
        }

        public string taoMaChucVu()
        {
            string maChucVu = "";
            string query = (from cv in db.ChucVus
                            orderby cv.maChucVu descending
                            select cv.maChucVu).FirstOrDefault();
            if (query != null)
            {
                int so = int.Parse(query.Substring(2)) + 1;
                if (so < 10)
                {
                    maChucVu = "CV00" + so;
                }
                else
                {
                    maChucVu = "CV0" + so;
                }
            }
            else
            {
                maChucVu = "CV001";
            }
            return maChucVu;
        }

        public bool themChucVu(ChucVuDTO chucVu)
        {
            try
            {
                ChucVu cv = new ChucVu();
                cv.maChucVu = chucVu.MaChucVu;
                cv.tenChucVu = chucVu.TenChucVu;
                db.ChucVus.InsertOnSubmit(cv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaChucVu(string maChucVu)
        {
            try
            {
                ChucVu cv = db.ChucVus.Where(t => t.maChucVu == maChucVu).FirstOrDefault();
                db.ChucVus.DeleteOnSubmit(cv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaChucVu(ChucVuDTO chucVu)
        {
            try
            {
                ChucVu cv = db.ChucVus.Where(t => t.maChucVu == chucVu.MaChucVu).FirstOrDefault();
                cv.tenChucVu = chucVu.TenChucVu;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
