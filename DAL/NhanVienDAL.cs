using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace DAL
{
    public class NhanVienDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public NhanVienDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public DataTable getNhanVien()
        {
            var query = from nhanVien in db.NhanViens
                        select new
                        {
                            nhanVien.maNhanVien,
                            nhanVien.tenNhanVien,
                            nhanVien.diaChi,
                            nhanVien.email,
                            nhanVien.SDT,
                        };

            // Tạo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maNhanVien");
            dt.Columns.Add("tenNhanVien");
            dt.Columns.Add("diaChi");
            dt.Columns.Add("email");
            dt.Columns.Add("SDT");

            foreach (var item in query)
            {
                dt.Rows.Add(item.maNhanVien, item.tenNhanVien, item.diaChi, item.email, item.SDT);
            }

            return dt;
        }
        public int getMaxMaNhanVien()
        {
            System.Collections.Generic.List<string> maNhanViens = db.NhanViens
                .Select(nv => nv.maNhanVien)
                .ToList();
            int maxMaNhanVien = maNhanViens
                .Where(mnv => !string.IsNullOrEmpty(mnv) && mnv.Length > 2)
                .Select(mnv => int.Parse(mnv.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();
            return maxMaNhanVien;
        }

        //public bool themNhanVien(NhanVienDTO nhanVien)
        //{
        //    // Chuyển đổi từ NhanVienDTO sang NhanVien (entity)
        //    NhanVien newNhanVien = new NhanVien
        //    {
        //        maNhanVien = nhanVien.MaNhanVien,
        //        tenNhanVien = nhanVien.TenNhanVien,
        //        diaChi = nhanVien.DiaChi,
        //        email = nhanVien.Email,
        //        SDT = nhanVien.SoDienThoai
        //    };

        //    // Thêm nhân viên vào ngữ cảnh
        //    db.NhanViens.InsertOnSubmit(newNhanVien);

        //    try
        //    {
        //        db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
        //        return true; // Trả về true nếu thành công
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý lỗi nếu có (ghi log, thông báo, v.v.)
        //        Console.WriteLine("Lỗi khi thêm nhân viên: " + ex.Message);
        //        return false; // Trả về false nếu có lỗi
        //    }
        //}

        public bool themNhanVien(NhanVienDTO nhanVien, out string errorMessage)
        {
            errorMessage = null;

            // Chuyển đổi từ NhanVienDTO sang NhanVien (entity)
            NhanVien newNhanVien = new NhanVien
            {
                maNhanVien = nhanVien.MaNhanVien,
                tenNhanVien = nhanVien.TenNhanVien,
                diaChi = nhanVien.DiaChi,
                email = nhanVien.Email,
                SDT = nhanVien.SoDienThoai
            };

            // Thêm nhân viên vào ngữ cảnh
            db.NhanViens.InsertOnSubmit(newNhanVien);

            try
            {
                db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                return true; // Trả về true nếu thành công
            }
            catch (SqlException ex)
            {
                // Kiểm tra lỗi trùng SDT dựa trên mã lỗi SQL
                if (ex.Number == 2627 || ex.Number == 2601) // Mã lỗi cho ràng buộc UNIQUE
                {
                    errorMessage = "Số điện thoại đã tồn tại. Vui lòng nhập số khác.";
                }
                else
                {
                    errorMessage = "Lỗi cơ sở dữ liệu: " + ex.Message;
                }

                return false; // Trả về false nếu có lỗi
            }
            catch (Exception ex)
            {
                errorMessage = "Lỗi không xác định: " + ex.Message;
                return false;
            }
        }


        public bool suaNhanVien(NhanVienDTO nhanVien, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                // Tìm nhân viên cần sửa
                NhanVien suanhanvien = db.NhanViens.SingleOrDefault(lp => lp.maNhanVien == nhanVien.MaNhanVien);

                if (suanhanvien == null)
                {
                    errorMessage = "Nhân viên không tồn tại.";
                    return false;
                }

                // Cập nhật thông tin nhân viên
                suanhanvien.tenNhanVien = nhanVien.TenNhanVien;
                suanhanvien.diaChi = nhanVien.DiaChi;
                suanhanvien.email = nhanVien.Email;
                suanhanvien.SDT = nhanVien.SoDienThoai;

                // Lưu thay đổi
                db.SubmitChanges();
                return true;
            }
            catch (SqlException ex)
            {
                // Kiểm tra lỗi trùng SDT dựa trên mã lỗi SQL
                if (ex.Number == 2627 || ex.Number == 2601) // Mã lỗi cho ràng buộc UNIQUE
                {
                    errorMessage = "Số điện thoại đã tồn tại. Vui lòng nhập số khác.";
                }
                else
                {
                    errorMessage = "Lỗi cơ sở dữ liệu: " + ex.Message;
                }

                return false;
            }
            catch (Exception ex)
            {
                errorMessage = "Lỗi không xác định: " + ex.Message;
                return false;
            }
        }


        public bool xoaNhanVien(string maNhanVien)
        {
            try
            {
                // Tìm nhân viên trong cơ sở dữ liệu dựa trên mã nhân viên
                NhanVien nhanVien = db.NhanViens.SingleOrDefault(nv => nv.maNhanVien == maNhanVien);

                if (nhanVien != null)
                {
                    // Xóa nhân viên nếu tìm thấy
                    db.NhanViens.DeleteOnSubmit(nhanVien);
                    db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    return true; // Trả về true nếu xóa thành công
                }
                return false; // Trả về false nếu không tìm thấy nhân viên
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (ghi log, thông báo lỗi, v.v.)
                Console.WriteLine("Lỗi khi xóa nhân viên: " + ex.Message);
                return false;
            }
        }

        //Lấy tên nhân viên trong bảng NhanVien theo username từ bảng TaiKhoan
        public string layTenNhanVienTheoUsername(string username)
        {
            IQueryable<string> query = from nv in db.NhanViens
                                       join tk in db.TaiKhoans on nv.maNhanVien equals tk.maNhanVien
                                       where tk.tenDangNhap == username
                                       select nv.tenNhanVien;
            return query.FirstOrDefault();
        }

    }
}
