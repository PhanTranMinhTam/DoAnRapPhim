using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class GheDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public GheDAL()
        {
            strConn = Settings.Default.strConn;
        }
        public DataTable LayTatCaGheTheoPhongChieu(string maPhongChieu)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                // Query để lấy dữ liệu khách hàng
                string query = "SELECT * FROM Ghe where maPhongChieu = @maPhongChieu";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@maPhongChieu", maPhongChieu);
                DataTable dataTable = new DataTable();
                conn.Open();
                adapter.Fill(dataTable);
                conn.Close();

                return dataTable;
            }
        }
        public void CapNhatTrangThaiGhe(string maGhe, string maPhongChieu, int trangThai)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                // Câu lệnh SQL để cập nhật trạng thái ghế
                string query = "UPDATE Ghe SET trangThai = @trangThai WHERE maGhe = @maGhe AND maPhongChieu = @maPhongChieu";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maGhe", maGhe);
                    cmd.Parameters.AddWithValue("@maPhongChieu", maPhongChieu);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);

                    conn.Open();
                    cmd.ExecuteNonQuery(); // Thực hiện lệnh cập nhật
                    conn.Close();
                }
            }
        }
        public void CapNhatLoaiGhe(string maGhe, string loaiGhe, string maPhongChieu)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string query = "UPDATE Ghe SET LoaiGhe = @LoaiGhe WHERE MaGhe = @MaGhe and maPhongChieu = @maPhongChieu";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoaiGhe", loaiGhe);
                    cmd.Parameters.AddWithValue("@MaGhe", maGhe);
                    cmd.Parameters.AddWithValue("@maPhongChieu", maPhongChieu);

                    conn.Open();
                    cmd.ExecuteNonQuery(); // Thực hiện lệnh cập nhật
                    conn.Close();
                }
            }
        }
        public DataTable LayDanhSachGheDaDat(string maPhongChieu, string maLichChieu)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string query = @"
                    SELECT 
                        g.maGhe,
                        g.maPhongChieu,
                        g.cots,
                        g.hang,
                        g.loaiGhe,
                        g.trangThai,
                        g.gia,
                        CASE 
                            WHEN ct.maGhe IS NOT NULL THEN N'Đã đặt'
                            ELSE N'Chưa đặt'
                        END AS trangThaiDat
                    FROM 
                        Ghe g
                    LEFT JOIN 
                        CT_Ve ct ON g.maGhe = ct.maGhe AND ct.maLichChieu = @maLichChieu
                    WHERE 
                        g.maPhongChieu = @maPhongChieu
                    ORDER BY 
                        g.maGhe";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@maPhongChieu", maPhongChieu);
                    adapter.SelectCommand.Parameters.AddWithValue("@maLichChieu", maLichChieu);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public DataTable LayGheTheoMa(string maGhe)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string query = "SELECT * FROM Ghe WHERE maGhe = @maGhe";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@maGhe", maGhe);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }
    }
}
