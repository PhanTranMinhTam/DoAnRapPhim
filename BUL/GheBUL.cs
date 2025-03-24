using DAL;
using DTO;
using System;
using System.Data;

namespace BUL
{
    public class GheBUL
    {
        GheDAL gheDAL;

        public GheBUL()
        {
            gheDAL = new GheDAL();
        }
        public DataTable LayTatCaGheTheoPhongChieu(string maPhongChieu)
        {
            return gheDAL.LayTatCaGheTheoPhongChieu(maPhongChieu);
        }
        public void CapNhatTrangThaiGhe(string maGhe, string maPhongChieu, int trangThai)
        {
            // Gọi hàm từ lớp DAL để cập nhật trạng thái ghế
            gheDAL.CapNhatTrangThaiGhe(maGhe, maPhongChieu, trangThai);
        }
        public void CapNhatLoaiGhe(string maGhe, string loaiGhe, string maPhongChieu)
        {
            // Gọi DAL để lưu dữ liệu vào cơ sở dữ liệu
            gheDAL.CapNhatLoaiGhe(maGhe, loaiGhe, maPhongChieu);
        }
        public DataTable LayDanhSachGheDaDat(string maPhongChieu, string maLichChieu)
        {
            // Gọi hàm LayDanhSachGheDaDat từ lớp GheDAL
            return gheDAL.LayDanhSachGheDaDat(maPhongChieu, maLichChieu);
        }

        public GheDTO LayGheTheoMa(string maGhe)
        {
            GheDTO ghe = null;
            GheDAL gheDAL = new GheDAL();
            DataTable dt = gheDAL.LayGheTheoMa(maGhe);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Lấy dòng đầu tiên
                ghe = new GheDTO
                {
                    maGhe = row["MaGhe"].ToString(),
                    maPhongChieu = row["MaPhongChieu"].ToString(),
                    cot = Convert.ToInt32(row["Cots"]),
                    hang = row["Hang"].ToString(),
                    loaiGhe = row["LoaiGhe"].ToString(),
                    trangThai = Convert.ToInt32(row["TrangThai"]),
                    Gia = Convert.ToDecimal(row["Gia"])
                };
            }

            return ghe;
        }
    }
}
