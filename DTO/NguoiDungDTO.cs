namespace DTO
{
    public class NguoiDungDTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int? HoatDong { get; set; }
        public string MaNhanVien { get; set; }

        public NguoiDungDTO()
        {
            TenDangNhap = string.Empty;
            MatKhau = string.Empty;
            HoatDong = 0;
        }

        public NguoiDungDTO(string tenDangNhap, string matKhau, int hoatDong)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            HoatDong = hoatDong;
        }
    }
}
