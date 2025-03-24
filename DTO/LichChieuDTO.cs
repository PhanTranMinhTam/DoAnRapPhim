using System;
using System.Collections.Generic;

namespace DTO
{
    public class LichChieuDTO
    {
        //public string MaLichChieu { get; set; }
        //public string MaPhim { get; set; }
        //public string MaPhongChieu { get; set; }
        //public DateTime? NgayChieu { get; set; }
        //public TimeSpan? GioBatDau { get; set; }
        //public TimeSpan? GioKetThuc { get; set; }

        public string MaLichChieu { get; set; }
        public string MaPhim { get; set; }
        public string MaPhongChieu { get; set; }
        public DateTime? NgayChieu { get; set; }
        public TimeSpan? GioBatDau { get; set; }
        public TimeSpan? GioKetThuc { get; set; }
        public string PhongChieu { get; set; } // New property for aggregated rooms
        public string MaLichChieuAgg { get; set; } // New property for aggregated schedule IDs
        public Dictionary<string, string> PhongChieuToMaLichChieu { get; set; } // Map rooms to schedule IDs

        public string DisplayText => $"{GioBatDau:hh\\:mm} - {GioKetThuc:hh\\:mm}";

        //public string GioChieu
        //{
        //    get
        //    {
        //        if (GioBatDau.HasValue && GioKetThuc.HasValue)
        //        {
        //            return $"{GioBatDau.Value:hh\\:mm} - {GioKetThuc.Value:hh\\:mm}";
        //        }
        //        return string.Empty;
        //    }
        //}
    }
}
