using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class LichChieuBUL
    {
        LichChieuDAL lichChieuDAL;
        public LichChieuBUL()
        {
            lichChieuDAL = new LichChieuDAL();
        }

        public DataTable getLichChieu()
        {
            return lichChieuDAL.getLichChieu();
        }

        public LichChieuDetailDTO layThongTinLichChieuTheoMa(string maLichChieu)
        {
            return lichChieuDAL.layThongTinLichChieuTheoMa(maLichChieu);
        }


        //public bool themLichChieu(LichChieuDTO lichChieu)
        //{
        //    return lichChieuDAL.themLichChieu(lichChieu);
        //}


        public bool themLichChieu(LichChieuDTO lichChieu, out string errorMessage)
        {
            return lichChieuDAL.themLichChieu(lichChieu, out errorMessage);
        }


        public bool xoaLichChieu(string maLichChieu)
        {
            return lichChieuDAL.xoaLichChieu(maLichChieu);
        }

        public string layMaLichChieu()
        {
            return lichChieuDAL.layMaLichChieu();
        }

        public bool suaLichChieu(LichChieuDTO lichChieu, out string errorMessage)
        {
            return lichChieuDAL.suaLichChieu(lichChieu, out errorMessage);
        }


        // Phương thức lấy thời gian chiếu theo mã phim
        public List<Tuple<TimeSpan, TimeSpan>> GetThoiGianChieuByMaPhim(string maPhim)
        {
            return lichChieuDAL.GetThoiGianChieuByMaPhim(maPhim);
        }

        public List<LichChieuDTO> layLichChieuTheoMaPhim(string maPhim)
        {
            return lichChieuDAL.layLichChieuByMaPhim(maPhim);
        }

    }
}
