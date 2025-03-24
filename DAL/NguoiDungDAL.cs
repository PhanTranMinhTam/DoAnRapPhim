using DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace DAL
{
    public class NguoiDungDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();

        public NguoiDungDAL()
        {
            strConn = Settings.Default.strConn;
        }

        private string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //public bool isValid(NguoiDungDTO nguoiDung)
        //{
        //    strConn = Settings.Default.strConn;
        //    SqlConnection conn = new SqlConnection(strConn);
        //    if (conn.State == ConnectionState.Closed)
        //        conn.Open();

        //    string sql = "Select count(*) from TaiKhoan where tenDangNhap ='" + nguoiDung.TenDangNhap + "' and pass = '" + nguoiDung.MatKhau + "'";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    int so = (int)cmd.ExecuteScalar();
        //    if (conn.State == ConnectionState.Open)
        //        conn.Close();
        //    if (so == 0)
        //        return false;
        //    return true;
        //}

        public List<NguoiDungDTO> layDanhSachNguoiDung()
        {
            List<NguoiDungDTO> lstNguoiDung = new List<NguoiDungDTO>();
            IQueryable<NguoiDungDTO> query = from tk in db.TaiKhoans
                                             select new NguoiDungDTO
                                             {
                                                 TenDangNhap = tk.tenDangNhap,
                                                 MatKhau = tk.pass,
                                                 HoatDong = tk.hoatDong,
                                                 MaNhanVien = tk.maNhanVien

                                             };
            lstNguoiDung = query.ToList();
            return lstNguoiDung;
        }

        public NhanVienInfo isValid(NguoiDungDTO nguoiDung)
        {
            //IQueryable<NhanVienInfo> query = from tk in db.TaiKhoans
            //                                 join nv in db.NhanViens on tk.maNhanVien equals nv.maNhanVien
            //                                 join nvcv in db.NhanVien_ChucVus on tk.tenDangNhap equals nvcv.tenDangNhap
            //                                 join cv in db.ChucVus on nvcv.maChucVu equals cv.maChucVu
            //                                 where tk.tenDangNhap == nguoiDung.TenDangNhap &&
            //                                       tk.pass == nguoiDung.MatKhau &&
            //                                       tk.hoatDong == 1
            //                                 select new NhanVienInfo
            //                                 {
            //                                     MaNhanVien = nv.maNhanVien,
            //                                     TenNhanVien = nv.tenNhanVien,
            //                                     ChucVu = cv.tenChucVu
            //                                 };

            //return query.FirstOrDefault();
            // Tìm tài khoản theo tên đăng nhập
            TaiKhoan taiKhoan = db.TaiKhoans.SingleOrDefault(tk => tk.tenDangNhap == nguoiDung.TenDangNhap);

            if (taiKhoan == null)
            {
                return null; // Không tìm thấy tài khoản
            }

            // Mã hóa mật khẩu người dùng nhập
            string hashedInputPassword = HashPassword(nguoiDung.MatKhau);

            // So sánh mật khẩu đã mã hóa và kiểm tra trạng thái hoạt động
            if (taiKhoan.pass == hashedInputPassword && taiKhoan.hoatDong == 1)
            {
                // Truy vấn thông tin nhân viên và chức vụ
                NhanVienInfo nhanVienInfo = (from tk in db.TaiKhoans
                                             join nv in db.NhanViens on tk.maNhanVien equals nv.maNhanVien
                                             join nvcv in db.NhanVien_ChucVus on tk.tenDangNhap equals nvcv.tenDangNhap
                                             join cv in db.ChucVus on nvcv.maChucVu equals cv.maChucVu
                                             where tk.tenDangNhap == nguoiDung.TenDangNhap
                                             select new NhanVienInfo
                                             {
                                                 MaNhanVien = nv.maNhanVien,
                                                 TenNhanVien = nv.tenNhanVien,
                                                 ChucVu = cv.tenChucVu
                                             }).FirstOrDefault();

                return nhanVienInfo; // Trả về thông tin nhân viên bao gồm chức vụ
            }

            return null; // Mật khẩu không khớp hoặc tài khoản không hoạt động
        }

        //Đổi mật khẩu kiểm tra tên đăng nhập và mật khẩu cũ có đúng không
        public bool KiemTraMatKhauCu(string tenDangNhap, string matKhau)
        {
            IQueryable<TaiKhoan> query = from tk in db.TaiKhoans
                                         where tk.tenDangNhap == tenDangNhap &&
                                               tk.pass == matKhau
                                         select tk;

            return query.Count() > 0;
        }

        //Đổi mật khẩu
        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.tenDangNhap == tenDangNhap);
            tk.pass = matKhauMoi;
            db.SubmitChanges();
            return true;
        }

        public bool themNguoiDung(NguoiDungDTO nguoiDung)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.tenDangNhap = nguoiDung.TenDangNhap;
                tk.pass = nguoiDung.MatKhau;
                tk.hoatDong = nguoiDung.HoatDong;
                tk.maNhanVien = nguoiDung.MaNhanVien;

                db.TaiKhoans.InsertOnSubmit(tk);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNguoiDung(string tenDangNhap)
        {
            try
            {
                TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.tenDangNhap == tenDangNhap);
                if (tk != null)
                {
                    tk.hoatDong = 0;
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaNguoiDung(NguoiDungDTO nguoiDung)
        {
            try
            {
                TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.tenDangNhap == nguoiDung.TenDangNhap);
                tk.pass = nguoiDung.MatKhau;
                tk.hoatDong = nguoiDung.HoatDong;
                tk.maNhanVien = nguoiDung.MaNhanVien;

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
