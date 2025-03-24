using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
namespace DAL
{
    public class DuDoanDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public DuDoanDAL()
        {
            strConn = Settings.Default.strConn;
        }
        public List<InputModel> GetMovieData(int takeCount = 20)
        {
            IQueryable<InputModel> data = from hoaDon in db.HoaDons
                                          join khachHang in db.KhachHangs on hoaDon.maKH equals khachHang.maKhachHang
                                          join ctVe in db.CT_Ves on hoaDon.maHD equals ctVe.maHD
                                          join lichChieu in db.LichChieus on ctVe.maLichChieu equals lichChieu.maLichChieu
                                          join phim in db.Phims on lichChieu.maPhim equals phim.maPhim
                                          join phimLoai in db.Phim_LoaiPhims on phim.maPhim equals phimLoai.maPhim
                                          join loaiPhim in db.LoaiPhims on phimLoai.maLoai equals loaiPhim.maLoai
                                          where khachHang.maKhachHang != null && khachHang.NgaySinh != null
                                          select new InputModel
                                          {
                                              Tuoi = (float)(DateTime.Now.Year - khachHang.NgaySinh.Value.Year -
                                                             (DateTime.Now.DayOfYear < khachHang.NgaySinh.Value.DayOfYear ? 1 : 0)),
                                              TenLoaiPhim = loaiPhim.tenLoai,
                                              TenPhim = phim.tenPhim
                                          };

            // Loại bỏ các bản ghi trùng lặp dựa trên tất cả các trường của InputModel
            List<InputModel> distinctData = data.Distinct().Take(takeCount).ToList();

            return distinctData;
        }

        public async Task<List<InputModel>> GetMovieDataAsync(int takeCount = 5)
        {
            await Task.Delay(10);
            return GetMovieData(takeCount);
        }
    }
}
