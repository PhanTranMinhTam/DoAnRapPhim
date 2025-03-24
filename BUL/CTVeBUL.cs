using DAL;
using DTO;
using System.Collections.Generic;

namespace BUL
{
    public class CTVeBUL
    {
        CTVeDAL ctVeDAL = new CTVeDAL();
        public bool themCTVe(CTVeDTO cTVe)
        {
            return ctVeDAL.themCTVe(cTVe);
        }
        //public bool themCTVe(string maHD, string maLichChieu, List<string> danhSachMaGhe)
        //{
        //    // Gọi phương thức themCTVe từ DAL
        //    return ctVeDAL.themCTVe(maHD, maLichChieu, danhSachMaGhe);
        //}
        public string taoMaHoaDon()
        {
            return ctVeDAL.taoMaHoaDon();
        }
        public List<string> LayDanhSachGheDaDat(string maLichChieu)
        {
            // Gọi phương thức từ DAL để lấy danh sách ghế đã đặt
            List<string> danhSachGheDaDat = ctVeDAL.LayDanhSachGheDaDat(maLichChieu);

            // Xử lý logic nếu cần trước khi trả về danh sách
            return danhSachGheDaDat;
        }
    }
}
