using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class NhanVienChucVuDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();

        public NhanVienChucVuDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public List<NhanVienChucVuDTO> LayDanhSachNhanVienChucVu()
        {
            List<NhanVienChucVuDTO> lstNhanVienChucVu = new List<NhanVienChucVuDTO>();
            IQueryable<NhanVienChucVuDTO> nhanVienChucVu = from nvcv in db.NhanVien_ChucVus
                                                           select new NhanVienChucVuDTO
                                                           {
                                                               TenDangNhap = nvcv.tenDangNhap,
                                                               MaChucVu = nvcv.maChucVu
                                                           };
            lstNhanVienChucVu = nhanVienChucVu.ToList();
            return lstNhanVienChucVu;
        }

        //public List<string> layMaChucVuTheoTenDangNhap(string tenDangNhap)
        //{
        //    List<string> maChucVu = (from nvcv in db.NhanVien_ChucVus
        //                             where nvcv.tenDangNhap == tenDangNhap
        //                             select nvcv.maChucVu).ToList();
        //    return maChucVu;
        //}

        public bool themNhanVienChucVu(NhanVienChucVuDTO nhanVienChucVu)
        {
            try
            {
                NhanVien_ChucVu nvcv = new NhanVien_ChucVu();
                nvcv.tenDangNhap = nhanVienChucVu.TenDangNhap;
                nvcv.maChucVu = nhanVienChucVu.MaChucVu;
                db.NhanVien_ChucVus.InsertOnSubmit(nvcv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNhanVienChucVu(string tenDangNhap, string maChucVu)
        {
            try
            {
                NhanVien_ChucVu nvcv = db.NhanVien_ChucVus.Single(x => x.tenDangNhap == tenDangNhap && x.maChucVu == maChucVu);
                db.NhanVien_ChucVus.DeleteOnSubmit(nvcv);
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaNhanVienChucVu(NhanVienChucVuDTO nhanVienChucVu)
        {
            try
            {
                NhanVien_ChucVu nvcv = db.NhanVien_ChucVus.Single(x => x.tenDangNhap == nhanVienChucVu.TenDangNhap);
                nvcv.maChucVu = nhanVienChucVu.MaChucVu;
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
