namespace DTO
{
    public class LoaiPhimDTO
    {
        public string MaLoaiPhim { get; set; }
        public string TenLoaiPhim { get; set; }
        public string MoTa { get; set; }
        public LoaiPhimDTO(string maLoaiPhim, string tenLoaiPhim, string moTa)
        {
            MaLoaiPhim = maLoaiPhim;
            TenLoaiPhim = tenLoaiPhim;
            MoTa = moTa;
        }
    }
}
