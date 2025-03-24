using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThemKhuyenMai : Form
    {
        private KhuyenMaiBUL khuyenMaiBUL;
        public KhuyenMaiDTO AddedKhuyenMai { get; private set; }
        public frm_ThemKhuyenMai()
        {
            InitializeComponent();
            khuyenMaiBUL = new KhuyenMaiBUL();
            txtMaKM.Enabled = false;
            txtMaKM.Text = GenerateMaKM();
        }
        private string GenerateMaKM()
        {
            int maxMaKM = khuyenMaiBUL.GetMaxMaKhuyenMai();
            int newMaKM = maxMaKM + 1;
            return "KM" + newMaKM.ToString().PadLeft(3, '0');
        }
        private void frm_ThemKhuyenMai_Load(object sender, System.EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, System.EventArgs e)
        {
            // Lấy dữ liệu từ giao diện
            string maKhuyenMai = txtMaKM.Text.Trim();
            string tenKhuyenMai = txtenKM.Text.Trim();
            string phantramText = txtphantram.Text.Trim();
            decimal? phantram = null;
            if (decimal.TryParse(phantramText, out decimal parsedPhantram))
            {
                phantram = parsedPhantram;
            }

            DateTime? thoiGianBD = dpk_db.Value;
            DateTime? thoiGianKT = dpk_KT.Value;

            int trangthai = rdochuaphathanh.Checked ? 0 : (rdophathanh.Checked ? 1 : -1);

            if (trangthai == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái khuyến mãi!");
                return;
            }

            // Tạo đối tượng DTO
            KhuyenMaiDTO khuyenMai = new KhuyenMaiDTO
            {
                MaKM = maKhuyenMai,
                TenKM = tenKhuyenMai,
                PhanTramKM = phantram,
                ThoiGianBD = thoiGianBD,
                ThoiGianKT = thoiGianKT,
                TrangThai = trangthai
            };

            // Gọi phương thức thêm khuyến mãi từ lớp BUL
            bool isSuccess = khuyenMaiBUL.ThemKhuyenMai(khuyenMai);

            // Kiểm tra kết quả
            if (isSuccess)
            {
                MessageBox.Show("Thêm khuyến mãi thành công!");
                this.DialogResult = DialogResult.OK; // Trả về kết quả thành công
                this.Close(); // Đóng form
            }
            else
            {
                MessageBox.Show("Thêm khuyến mãi thất bại!");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtenKM.Text = "";
            txtphantram.Text = "";
            dpk_db.Value = DateTime.Now;
            dpk_KT.Value = DateTime.Now;
            rdochuaphathanh.Checked = false;
            rdophathanh.Checked = false;
        }
    }
}
