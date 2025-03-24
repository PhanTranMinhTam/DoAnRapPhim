namespace DTO
{
    public class InputModel
    {
        public string TenLoaiPhim { get; set; }
        public float Tuoi { get; set; }
        public string TenPhim { get; set; }

        public InputModel() { }

        public InputModel(string tenLoaiPhim, float tuoi, string tenPhim)
        {
            TenLoaiPhim = tenLoaiPhim;
            Tuoi = tuoi;
            TenPhim = tenPhim;
        }
    }

}
