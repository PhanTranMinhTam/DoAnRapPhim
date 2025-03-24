using System;

namespace DTO
{
    public class KhuyenMaiDTO
    {
        public string MaKM { get; set; }
        public string TenKM { get; set; }
        public DateTime? ThoiGianBD { get; set; }
        public DateTime? ThoiGianKT { get; set; }
        public decimal? PhanTramKM { get; set; }
        public int? TrangThai { get; set; }
    }
}
