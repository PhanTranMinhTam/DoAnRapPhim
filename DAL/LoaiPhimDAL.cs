using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class LoaiPhimDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public LoaiPhimDAL()
        {
            strConn = Settings.Default.strConn;
        }
        public DataTable getLoaiPhim()
        {
            // Querying LoaiPhim using LINQ
            var query = from loaiPhim in db.LoaiPhims
                        select new
                        {
                            loaiPhim.maLoai,
                            loaiPhim.tenLoai,
                            loaiPhim.moTa
                        };

            // Converting the LINQ query results to a DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maLoai");
            dt.Columns.Add("tenLoai");
            dt.Columns.Add("moTa");

            foreach (var item in query)
            {
                dt.Rows.Add(item.maLoai, item.tenLoai, item.moTa);
            }

            return dt;
        }
        public DataTable LayTatCaLoaiPhim()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string query = "SELECT MaLoai, TenLoai, MoTa FROM LoaiPhim";

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
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 maLoai FROM LoaiPhim ORDER BY maLoai DESC", conn);
                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    return "LP001";
                }

                string lastMaLoaiPhim = result.ToString();

                // Tách phần số từ mã loại phim cuối cùng
                string numberPart = lastMaLoaiPhim.Substring(2); // Bỏ đi phần "LP"

                // Tăng số lên 1
                int newNumber = int.Parse(numberPart) + 1;

                return "LP" + newNumber.ToString("D3"); // "D3" để đảm bảo có 3 chữ số
            }
        }

        public bool ThemLoaiPhim(LoaiPhimDTO loaiPhim)
        {
            try
            {
                LoaiPhim newLoaiPhim = new LoaiPhim
                {
                    maLoai = loaiPhim.MaLoaiPhim,
                    tenLoai = loaiPhim.TenLoaiPhim,
                    moTa = loaiPhim.MoTa
                };
                db.LoaiPhims.InsertOnSubmit(newLoaiPhim);
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
        public bool CheckMaLoaiPhim(string maLoaiPhim)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LoaiPhim WHERE MaLoai = @MaLoai";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoai", maLoaiPhim);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool SuaLoaiPhim(LoaiPhimDTO loaiPhim)
        {
            try
            {
                LoaiPhim suaLoaiPhim = db.LoaiPhims.SingleOrDefault(lp => lp.maLoai == loaiPhim.MaLoaiPhim);
                {
                    suaLoaiPhim.maLoai = loaiPhim.MaLoaiPhim;
                    suaLoaiPhim.tenLoai = loaiPhim.TenLoaiPhim;
                    suaLoaiPhim.moTa = loaiPhim.MoTa;
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
        public bool XoaLoaiPhim(string maLoai)
        {
            try
            {
                LoaiPhim xoaLoaiPhim = db.LoaiPhims.SingleOrDefault(lp => lp.maLoai == maLoai);
                db.LoaiPhims.DeleteOnSubmit(xoaLoaiPhim);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
