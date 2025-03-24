namespace DTO
{
    public class PhongChieuDTO
    {
        public string MaPhongChieu { get; set; }
        public string TenPhongChieu { get; set; }
        public int? SoLuongGhe { get; set; }

        public PhongChieuDTO()
        {
            MaPhongChieu = "";
            TenPhongChieu = "";
            SoLuongGhe = 0;
        }

        public PhongChieuDTO(string maPhongChieu, string tenPhongChieu, int soLuongGhe)
        {
            MaPhongChieu = maPhongChieu;
            TenPhongChieu = tenPhongChieu;
            SoLuongGhe = soLuongGhe;
        }
    }
}
