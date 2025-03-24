using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class CTVeDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public CTVeDAL()
        {
            strConn = Settings.Default.strConn;
        }
        public string taoMaHoaDon()
        {
            string maHD = "HD";
            CT_Ve query = db.CT_Ves.OrderByDescending(x => x.maHD).FirstOrDefault();
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
        public bool themCTVe(CTVeDTO ct)
        {
            try
            {
                CT_Ve ctVe = new CT_Ve();
                ctVe.maHD = ct.MaHD;
                ctVe.maGhe = ct.MaGhe;
                ctVe.maLichChieu = ct.MaLichChieu;

                db.CT_Ves.InsertOnSubmit(ctVe);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public bool themCTVe(string maHD, string maLichChieu, List<string> danhSachMaGhe)
        //{
        //    try
        //    {
        //        // Lặp qua danh sách mã ghế và thêm từng mã ghế vào bảng CT_Ve
        //        foreach (string maGhe in danhSachMaGhe)
        //        {
        //            CT_Ve ctVe = new CT_Ve();
        //            ctVe.maHD = maHD;
        //            ctVe.maGhe = maGhe;
        //            ctVe.maLichChieu = maLichChieu;

        //            db.CT_Ves.InsertOnSubmit(ctVe);
        //        }

        //        // Lưu thay đổi vào database
        //        db.SubmitChanges();

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public List<string> LayDanhSachGheDaDat(string maLichChieu)
        {
            List<string> danhSachGheDaDat = new List<string>();

            // Câu truy vấn lấy mã ghế đã đặt theo mã lịch chiếu
            string query = "SELECT MaGhe FROM CT_Ve WHERE MaLichChieu = @MaLichChieu";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaLichChieu", maLichChieu);

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Đọc mã ghế từ kết quả truy vấn và thêm vào danh sách
                    string maGhe = reader["MaGhe"].ToString();
                    danhSachGheDaDat.Add(maGhe);
                }

                conn.Close();

            }

            return danhSachGheDaDat;
        }
    }
}
