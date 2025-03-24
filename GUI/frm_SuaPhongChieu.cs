using BUL;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_SuaPhongChieu : Form
    {
        private PhongChieuBUL phongChieuBUL;
        private PhongChieuDTO phongChieu;
        public frm_SuaPhongChieu(PhongChieuDTO PhongChieu)
        {
            InitializeComponent();
            phongChieuBUL = new PhongChieuBUL();
            this.phongChieu = PhongChieu;
            txt_MaPC.Text = PhongChieu.MaPhongChieu;
            txt_MaPC.Enabled = false;
            txt_TenPC.Text = PhongChieu.TenPhongChieu;
            txt_SoLuongGhe.Text = PhongChieu.SoLuongGhe.ToString();
        }

        private void btn_Luu_Click(object sender, System.EventArgs e)
        {
            phongChieu.MaPhongChieu = txt_MaPC.Text.Trim();
            phongChieu.TenPhongChieu = txt_TenPC.Text.Trim();
            int soLuongGhe;
            if (int.TryParse(txt_SoLuongGhe.Text.Trim(), out soLuongGhe))
            {
                phongChieu.SoLuongGhe = soLuongGhe;
            }
            else
            {
                MessageBox.Show("Số lượng ghế không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            // Gọi phương thức sửa nhân viên từ lớp BUL
            bool isSuccess = phongChieuBUL.SuaPhongChieu(phongChieu);

            // Kiểm tra kết quả và hiển thị thông báo
            if (isSuccess)
            {
                MessageBox.Show("Sửa phòng chiếu thành công!");
                this.DialogResult = DialogResult.OK; // Trả về OK nếu sửa thành công
                this.Close(); // Đóng form
            }
            else
            {
                MessageBox.Show("Sửa phòng chiếu thất bại!");
            }
        }

        private void btn_Huy_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
