using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class PhongChieuDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public PhongChieuDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public DataTable getPhongChieu()
        {
            var query = from phongChieu in db.PhongChieus
                        select new
                        {
                            phongChieu.maPhongChieu,
                            phongChieu.tenPhongChieu,
                            phongChieu.soLuongGhe
                        };

            // Converting the LINQ query results to a DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maPhongChieu");
            dt.Columns.Add("tenPhongChieu");
            dt.Columns.Add("soLuongGhe");

            foreach (var item in query)
            {
                dt.Rows.Add(item.maPhongChieu, item.tenPhongChieu, item.soLuongGhe);
            }

            return dt;
        }
        public DataTable LayTatCaPhongChieu()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                // Query để lấy dữ liệu khách hàng
                string query = "SELECT MaPhongChieu, TenPhongchieu, SoLuongGhe FROM PhongChieu";

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

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 MaPhongChieu FROM PhongChieu ORDER BY MaPhongChieu DESC", conn);
                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    return "PC001";
                }

                string lastMaPhongChieu = result.ToString();

                string numberPart = lastMaPhongChieu.Substring(2);

                // Tăng số lên 1
                int newNumber = int.Parse(numberPart) + 1;

                return "PC" + newNumber.ToString("D3"); // "D3" để đảm bảo có 3 chữ số
            }
        }

        public bool ThemPhongChieu(PhongChieuDTO phongChieu)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    PhongChieu newPhongChieu = new PhongChieu
                    {
                        maPhongChieu = phongChieu.MaPhongChieu,
                        tenPhongChieu = phongChieu.TenPhongChieu,
                        soLuongGhe = phongChieu.SoLuongGhe
                    };
                    db.PhongChieus.InsertOnSubmit(newPhongChieu);
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
        //Sửa thông tin Phòng chiếu
        public bool CheckMaPhongChieu(string maPhongChieu)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM PhongChieu WHERE MaPhongChieu = @MaPhongChieu";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhongChieu", maPhongChieu);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool SuaPhongChieu(PhongChieuDTO phongChieu)
        {
            try
            {
                PhongChieu suaPhongChieu = db.PhongChieus.SingleOrDefault(lp => lp.maPhongChieu == phongChieu.MaPhongChieu);
                {
                    suaPhongChieu.maPhongChieu = phongChieu.MaPhongChieu;
                    suaPhongChieu.tenPhongChieu = phongChieu.TenPhongChieu;
                    suaPhongChieu.soLuongGhe = phongChieu.SoLuongGhe;
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
        public bool XoaPhongChieu(string maPhongChieu)
        {
            try
            {
                PhongChieu xoaPhongChieu = db.PhongChieus.SingleOrDefault(lp => lp.maPhongChieu == maPhongChieu);
                db.PhongChieus.DeleteOnSubmit(xoaPhongChieu);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //lấy danh sách phòng chiếu theo gioBD, gioKT
        //public List<string> GetPhongChieuByThoiGian(TimeSpan gioBD, TimeSpan gioKT)
        //{
        //    IQueryable<string> query = from lc in db.LichChieus
        //                               where lc.gioBD == gioBD && lc.gioKT == gioKT
        //                               select lc.maPhongChieu;

        //    return query.Distinct().ToList();
        //}

        public List<PhongChieuDTO> GetPhongChieuByThoiGian(TimeSpan gioBD, TimeSpan gioKT)
        {
            IQueryable<PhongChieuDTO> query = from lc in db.LichChieus
                                              join pc in db.PhongChieus on lc.maPhongChieu equals pc.maPhongChieu
                                              where lc.gioBD == gioBD && lc.gioKT == gioKT
                                              select new PhongChieuDTO
                                              {
                                                  MaPhongChieu = pc.maPhongChieu,
                                                  TenPhongChieu = pc.tenPhongChieu,
                                                  SoLuongGhe = pc.soLuongGhe
                                              };

            return query.Distinct().ToList();
        }

        //lấy danh sách phòng chiếu
        public List<PhongChieuDTO> layDanhSachPhongChieu(string maPhim, string maLichChieu)
        {
            IQueryable<PhongChieuDTO> query = from lichChieu in db.LichChieus
                                              join phongChieu in db.PhongChieus on lichChieu.maPhongChieu equals phongChieu.maPhongChieu
                                              where lichChieu.maPhim == maPhim && lichChieu.maLichChieu == maLichChieu
                                              select new PhongChieuDTO
                                              {
                                                  MaPhongChieu = phongChieu.maPhongChieu,
                                                  TenPhongChieu = phongChieu.tenPhongChieu
                                                  // Các thuộc tính khác của phòng chiếu
                                              };

            return query.ToList();
        }
    }
}
