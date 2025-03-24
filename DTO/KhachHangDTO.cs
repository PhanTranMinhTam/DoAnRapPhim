namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }

        public KhachHangDTO()
        {
        }
        public KhachHangDTO(string maKhachHang, string tenKhachHang, string diaChi, string email, string sDT)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            Email = email;
            SDT = sDT;
        }
    }
}
