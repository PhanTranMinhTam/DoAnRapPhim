namespace DTO
{
    public class DoanhThuDTO : HoaDoninfoDTO
    {
        public int STT { get; set; }
        public DoanhThuDTO(HoaDoninfoDTO hd, int stt)
        {
            this.STT = stt;
            this.MaHD = hd.MaHD;
            this.NgayBan = hd.NgayBan;
            this.TongTien = hd.TongTien;
            this.MaKM = hd.MaKM;
        }
    }
}
