using DAL;
using DTO;
using System.Collections.Generic;

namespace BUL
{
    public class NguoiDungBUL
    {
        NguoiDungDAL dal;

        public NguoiDungBUL()
        {
            dal = new NguoiDungDAL();
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

        public List<NguoiDungDTO> layDanhSachNguoiDung()
        {
            return dal.layDanhSachNguoiDung();
        }

        public NhanVienInfo isValid(NguoiDungDTO nguoiDung)
        {
            //nguoiDung.MatKhau = HashPassword(nguoiDung.MatKhau);
            return dal.isValid(nguoiDung);
        }

        public bool KiemTraMatKhauCu(string tenDangNhap, string matKhau)
        {
            string hashPassword = HashPassword(matKhau);
            return dal.KiemTraMatKhauCu(tenDangNhap, hashPassword);
        }

        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            string hashedPassword = HashPassword(matKhauMoi);
            return dal.DoiMatKhau(tenDangNhap, hashedPassword);
        }

        public bool themNguoiDung(NguoiDungDTO nguoiDung)
        {
            nguoiDung.MatKhau = HashPassword(nguoiDung.MatKhau);
            return dal.themNguoiDung(nguoiDung);
        }

        public bool xoaNguoiDung(string tenDangNhap)
        {
            return dal.xoaNguoiDung(tenDangNhap);
        }

        public bool suaNguoiDung(NguoiDungDTO nguoiDung)
        {
            nguoiDung.MatKhau = HashPassword(nguoiDung.MatKhau);
            return dal.suaNguoiDung(nguoiDung);
        }
    }
}
