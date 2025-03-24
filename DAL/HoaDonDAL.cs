using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class HoaDonDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public HoaDonDAL()
        {
            strConn = Settings.Default.strConn;
        }
        public string taoMaHoaDon()
        {
            string maHD = "HD";
            HoaDon query = db.HoaDons.OrderByDescending(x => x.maHD).FirstOrDefault();
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
        public bool themHoaDon(HoaDonDTO hd)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.maHD = hd.MaHD;
                hoaDon.maNV = hd.MaNV;
                hoaDon.maKH = hd.MaKH;
                hoaDon.ngayBan = hd.NgayBan;
                hoaDon.tongTien = hd.TongTien;
                hoaDon.maKhuyenMai = hd.MaKM;

                db.HoaDons.InsertOnSubmit(hoaDon);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Dictionary<string, double> TinhTongDoanhThuTheoThang()
        {
            Dictionary<string, double> doanhThuTheoThang = new Dictionary<string, double>();

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
                SELECT FORMAT(NgayBan, 'MM-yyyy') AS Thang, SUM(TongTien) AS TongDoanhThu
                FROM HoaDon
                GROUP BY FORMAT(NgayBan, 'MM-yyyy')
                ORDER BY FORMAT(NgayBan, 'MM-yyyy')";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string thang = reader["Thang"].ToString();
                    double tongDoanhThu = Convert.ToDouble(reader["TongDoanhThu"]);
                    doanhThuTheoThang[thang] = tongDoanhThu;
                }

                reader.Close();
            }

            return doanhThuTheoThang;
        }
        public DataTable GetDanhSachHoaDon()
        {
            DataTable dtHoaDon = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
            SELECT 
                hd.MaHD, 
                nv.tenNhanVien, 
                kh.tenKhachHang, 
                hd.NgayBan, 
                hd.TongTien, 
                hd.MaKhuyenMai
            FROM HoaDon hd
            INNER JOIN NhanVien nv ON hd.maNV = nv.maNhanVien
            INNER JOIN KhachHang kh ON hd.maKH = kh.MaKhachHang";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtHoaDon);
            }

            return dtHoaDon;
        }
        public DataTable GetDanhSachHoaDonTheoTenPhim(string maPhim)
        {
            DataTable dtHoaDon = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
                SELECT 
                    hd.MaHD, 
                    nv.tenNhanVien, 
                    kh.tenKhachHang, 
                    hd.NgayBan, 
                    hd.TongTien, 
                    hd.MaKhuyenMai
                FROM HoaDon hd
                LEFT JOIN NhanVien nv ON hd.maNV = nv.maNhanVien
                LEFT JOIN KhachHang kh ON hd.maKH = kh.MaKhachHang
                LEFT JOIN CT_Ve ct ON hd.MaHD = ct.MaHD
                LEFT JOIN LichChieu lc ON ct.MaLichChieu = lc.MaLichChieu
                LEFT JOIN Phim p ON lc.MaPhim = p.MaPhim
                WHERE p.maPhim = @MaPhim
                GROUP BY hd.MaHD, nv.tenNhanVien, kh.tenKhachHang, hd.NgayBan, hd.TongTien, hd.MaKhuyenMai";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPhim", maPhim);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtHoaDon);
            }

            return dtHoaDon;
        }
        public DataTable GetDanhSachHoaDonTheoThang(int thang, int nam)
        {
            DataTable dtHoaDon = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
                SELECT 
                    hd.MaHD, 
                    nv.tenNhanVien, 
                    kh.tenKhachHang, 
                    hd.NgayBan, 
                    hd.TongTien, 
                    hd.MaKhuyenMai
                FROM HoaDon hd
                INNER JOIN NhanVien nv ON hd.maNV = nv.maNhanVien
                INNER JOIN KhachHang kh ON hd.maKH = kh.MaKhachHang
                INNER JOIN (
                    SELECT DISTINCT MaHD, MaLichChieu 
                    FROM CT_Ve
                ) AS ct ON hd.MaHD = ct.MaHD
                INNER JOIN LichChieu lc ON ct.MaLichChieu = lc.MaLichChieu
                INNER JOIN Phim p ON lc.MaPhim = p.MaPhim
                WHERE MONTH(hd.NgayBan) = @thang
                AND YEAR(hd.NgayBan) = @nam";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@thang", thang);
                command.Parameters.AddWithValue("@nam", nam);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtHoaDon);
            }

            return dtHoaDon;
        }
        public DataTable LayDanhSachHoaDonTheoTenPhimVaThangNam(string maPhim, int thang, int nam)
        {
            DataTable dtHoaDon = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
                 SELECT 
                    hd.MaHD, 
                    nv.tenNhanVien, 
                    kh.tenKhachHang, 
                    hd.NgayBan, 
                    hd.TongTien, 
                    hd.MaKhuyenMai
                FROM HoaDon hd
                INNER JOIN NhanVien nv ON hd.maNV = nv.maNhanVien
                INNER JOIN KhachHang kh ON hd.maKH = kh.MaKhachHang
                INNER JOIN (
                    SELECT DISTINCT MaHD, MaLichChieu 
                    FROM CT_Ve
                ) AS ct ON hd.MaHD = ct.MaHD
                INNER JOIN LichChieu lc ON ct.MaLichChieu = lc.MaLichChieu
                INNER JOIN Phim p ON lc.MaPhim = p.MaPhim
                WHERE MONTH(hd.NgayBan) = @thang
                AND YEAR(hd.NgayBan) = @nam 
                And p.maPhim = @MaPhim";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPhim", maPhim);
                command.Parameters.AddWithValue("@thang", thang);
                command.Parameters.AddWithValue("@nam", nam);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtHoaDon);
            }

            return dtHoaDon;
        }
        public decimal TinhTongDoanhThuTheoThang(int thang, int nam)
        {
            decimal tongDoanhThu = 0;
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
            SELECT SUM(TongTien) 
            FROM HoaDon 
            WHERE MONTH(NgayBan) = @thang AND YEAR(NgayBan) = @nam";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@thang", thang);
                command.Parameters.AddWithValue("@nam", nam);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    tongDoanhThu = Convert.ToDecimal(result);
                }
            }
            return tongDoanhThu;
        }
        public decimal TinhTongDoanhThu()
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = "SELECT SUM(TongTien) FROM HoaDon";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                // Sử dụng ?? để đảm bảo giá trị không phải là null
                return Convert.ToDecimal(command.ExecuteScalar() ?? 0);
            }
        }
        public decimal TinhTongDoanhThuTheoTenPhim(string maPhim)
        {
            decimal tongDoanhThu = 0;
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
            SELECT SUM(DISTINCT hd.tongTien) AS TongDoanhThu
            FROM HoaDon hd
            LEFT JOIN CT_Ve ct ON hd.MaHD = ct.MaHD
            LEFT JOIN LichChieu lc ON ct.MaLichChieu = lc.MaLichChieu
            LEFT JOIN Phim p ON lc.MaPhim = p.MaPhim
            WHERE p.MaPhim = @maPhim";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maPhim", maPhim);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    tongDoanhThu = Convert.ToDecimal(result);
                }
            }
            return tongDoanhThu;
        }


        public decimal TinhTongDoanhThuTheoTenPhimVaThangNam(string maPhim, int thang, int nam)
        {
            decimal tongDoanhThu = 0;
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
            SELECT SUM(DISTINCT hd.tongTien)
            FROM HoaDon hd
            INNER JOIN CT_Ve ct ON hd.MaHD = ct.MaHD
            INNER JOIN LichChieu lc ON ct.MaLichChieu = lc.MaLichChieu
            INNER JOIN Phim p ON lc.MaPhim = p.MaPhim
            WHERE p.maPhim = @MaPhim
            AND MONTH(hd.NgayBan) = @thang
            AND YEAR(hd.NgayBan) = @nam";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPhim", maPhim);
                command.Parameters.AddWithValue("@thang", thang);
                command.Parameters.AddWithValue("@nam", nam);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    tongDoanhThu = Convert.ToDecimal(result);
                }
            }
            return tongDoanhThu;
        }
        public DataTable LayTongDoanhThuTheoThang(int nam)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = @"
                SELECT MONTH(hd.NgayBan) AS Thang, SUM(DISTINCT hd.TongTien) AS DoanhThu
                FROM HoaDon hd
                WHERE YEAR(hd.NgayBan) = @Nam
                GROUP BY MONTH(hd.NgayBan)
                ORDER BY Thang";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nam", nam);

                SqlDataAdapter da = new SqlDataAdapter(command);

                connection.Open();
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable LayDanhSachDoanhThu()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string query = @"
            SELECT 
                HD.MaHD, 
                HD.ngayBan, 
                HD.TongTien, 
                HD.MaKhuyenMai, 
                Sum(tongTien) AS TongDoanhThu, 
                NV.tenNhanVien
            FROM HoaDon HD
            LEFT JOIN NhanVien NV ON HD.MaNV = NV.tenNhanVien
            group by hd.maHD, hd.ngayBan, HD.tongTien, hd.maKhuyenMai, NV.tenNhanVien";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                }
                catch (SqlException ex)
                {
                    // Log lỗi nếu cần
                    throw new Exception("Lỗi khi lấy danh sách doanh thu từ cơ sở dữ liệu.", ex);
                }
                finally
                {
                    conn.Close();
                }

                return dataTable;
            }
        }
        public int GetTongSoVe()
        {
            int tongSoVe = 0;

            string query = "SELECT COUNT(maGhe) AS tongSoVe FROM CT_Ve";

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();

                    if (result != null)
                    {
                        tongSoVe = Convert.ToInt32(result);
                    }
                }
            }

            return tongSoVe;
        }
        public int GetTongSoVeTheoPhim(string maPhim)
        {
            int tongSoVe = 0;

            string query = @"
            SELECT COUNT(cv.maGhe) AS tongSoVe
            FROM Phim p
            JOIN LichChieu lc ON p.maPhim = lc.maPhim
            JOIN CT_Ve cv ON lc.maLichChieu = cv.maLichChieu
            WHERE p.maPhim = @maPhim
            GROUP BY p.maPhim";

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maPhim", maPhim);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();

                    if (result != null)
                    {
                        tongSoVe = Convert.ToInt32(result);
                    }
                }
            }

            return tongSoVe;
        }
        public DataTable Top5PhimDoanhThuTheoThangNam(int nam, int thang)
        {
            string query = @"
            WITH DoanhThuPhim AS (
                SELECT 
                    P.tenPhim,
                    YEAR(H.ngayBan) AS Nam,
                    MONTH(H.ngayBan) AS Thang,
                    SUM(DISTINCT H.tongTien) AS DoanhThu
                FROM 
                    HoaDon H
                JOIN CT_Ve CTV ON H.maHD = CTV.maHD
                JOIN LichChieu LC ON CTV.maLichChieu = LC.maLichChieu
                JOIN Phim P ON LC.maPhim = P.maPhim
                GROUP BY 
                    P.tenPhim, YEAR(H.ngayBan), MONTH(H.ngayBan)
            )
            SELECT TOP 5
                tenPhim,
                Nam,
                Thang,
                DoanhThu
            FROM 
                DoanhThuPhim
            WHERE 
                Nam = @nam AND Thang = @thang
            ORDER BY 
                DoanhThu DESC;";

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nam", nam);
                    command.Parameters.AddWithValue("@thang", thang);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public DataTable Top5PhimDoanhThu()
        {
            string query = @"
            WITH DoanhThuPhim AS (
                SELECT 
                    P.tenPhim,
                    MONTH( H.ngayBan) AS Thang,
                    SUM(DISTINCT H.tongTien) AS TongDoanhThu
                FROM 
                    Phim P
                INNER JOIN 
                    LichChieu LC ON P.maPhim = LC.maPhim
                INNER JOIN 
                    CT_Ve CTV ON LC.maLichChieu = CTV.maLichChieu
                INNER JOIN 
                    HoaDon H ON CTV.maHD = H.maHD
                GROUP BY 
                    P.tenPhim, MONTH(H.ngayBan)
            )
            SELECT TOP 5
                tenPhim,
                Thang,
                TongDoanhThu
            FROM 
                DoanhThuPhim
            ORDER BY 
                TongDoanhThu DESC;";

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public DataTable DoanhThuTheoLoaiPhim(string maLoaiPhim)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    LP.maLoai AS LoaiPhim,
                    COUNT(CTV.maGhe) AS SoLuongVeBanRa,
                    SUM(DISTINCT H.tongTien) AS TongDoanhThu
                FROM 
                    CT_Ve CTV
                JOIN 
                    HoaDon H ON CTV.maHD = H.maHD
                JOIN 
                    LichChieu LC ON CTV.maLichChieu = LC.maLichChieu
                JOIN 
                    Phim P ON LC.maPhim = P.maPhim
                JOIN 
                    Phim_LoaiPhim PLP ON P.maPhim = PLP.maPhim
                JOIN 
                    LoaiPhim LP ON PLP.maLoai = LP.maLoai
                WHERE 
                    LP.maLoai = @maLoaiPhim
                GROUP BY 
                    LP.maLoai
                ORDER BY 
                    TongDoanhThu DESC;";

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maLoaiPhim", maLoaiPhim);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
