using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class KhachHangDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public KhachHangDAL()
        {
            strConn = Settings.Default.strConn;
        }
        public DataTable getKhachHang()
        {
            // Querying LoaiPhim using LINQ
            var query = from khachHang in db.KhachHangs
                        select new
                        {
                            khachHang.maKhachHang,
                            khachHang.tenKhachHang,
                            khachHang.diaChi,
                            khachHang.email,
                            khachHang.SDT
                        };

            // Converting the LINQ query results to a DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maKhachHang");
            dt.Columns.Add("tenKhachHang");
            dt.Columns.Add("diaChi");
            dt.Columns.Add("email");
            dt.Columns.Add("sDT");

            foreach (var item in query)
            {
                dt.Rows.Add(item.maKhachHang, item.tenKhachHang, item.diaChi, item.email, item.SDT);
            }

            return dt;
        }
        public DataTable LayTatCaKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                // Query để lấy dữ liệu khách hàng
                string query = "SELECT MaKhachHang, TenKhachHang, DiaChi, Email, SDT FROM KhachHang";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                conn.Open();
                adapter.Fill(dataTable);
                conn.Close();

                return dataTable;
            }
        }
        public string layMaTuDong()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                // Lấy mã khách hàng cuối cùng
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 MaKhachHang FROM KhachHang ORDER BY MaKhachHang DESC", conn);
                object result = cmd.ExecuteScalar();

                // Nếu chưa có khách hàng nào thì mã bắt đầu từ "KH001"
                if (result == null)
                {
                    return "KH001";
                }

                string lastMaKhachHang = result.ToString();

                // Tách phần số từ mã khách hàng cuối cùng
                string numberPart = lastMaKhachHang.Substring(2); // Bỏ đi phần "KH"

                // Tăng số lên 1
                int newNumber = int.Parse(numberPart) + 1;

                return "KH" + newNumber.ToString("D3"); // "D3" để đảm bảo có 3 chữ số
            }
        }

        public bool ThemKhachHang(KhachHangDTO khachHang)
        {
            try
            {
                KhachHang newKhachHang = new KhachHang
                {
                    maKhachHang = khachHang.MaKhachHang,
                    tenKhachHang = khachHang.TenKhachHang,
                    diaChi = khachHang.DiaChi,
                    email = khachHang.Email,
                    SDT = khachHang.SDT
                };
                db.KhachHangs.InsertOnSubmit(newKhachHang);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Sửa thông tin khách hàng
        public bool CheckMaKhachHang(string maKhachHang)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool SuaKhachHang(KhachHangDTO khachHang)
        {
            try
            {
                KhachHang suaKhachHang = db.KhachHangs.SingleOrDefault(lp => lp.maKhachHang == khachHang.MaKhachHang);
                {
                    suaKhachHang.maKhachHang = khachHang.MaKhachHang;
                    suaKhachHang.tenKhachHang = khachHang.TenKhachHang;
                    suaKhachHang.diaChi = khachHang.DiaChi;
                    suaKhachHang.email = khachHang.Email;
                    suaKhachHang.SDT = khachHang.SDT;
                };
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool XoaKhachHang(string maKhachHang)
        {
            try
            {
                KhachHang xoaKhachHang = db.KhachHangs.SingleOrDefault(lp => lp.maKhachHang == maKhachHang);
                db.KhachHangs.DeleteOnSubmit(xoaKhachHang);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Tìm kiếm khách hàng theo số điện thoại
        public KhachHangDTO layKhachHangTheoSDT(string sdt)
        {
            KhachHang query = db.KhachHangs.SingleOrDefault(kh => kh.SDT == sdt);
            if (query != null)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    MaKhachHang = query.maKhachHang,
                    TenKhachHang = query.tenKhachHang,
                    DiaChi = query.diaChi,
                    Email = query.email,
                    SDT = query.SDT
                };
                return khachHang;
            }
            return null;
        }
    }
}
