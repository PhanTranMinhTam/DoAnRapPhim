using System.Windows.Forms;

namespace GUI
{
    public partial class uc_TaiKhoan : UserControl
    {
        public uc_TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_DangNhap frm = new frm_DangNhap();
                frm.Show();
                this.ParentForm.Hide();
            }
        }


        public void loadThongTinHoTen(string tenNhanVien)
        {
            lb_HoTen.Text = tenNhanVien;
        }

        public void loadThongTinChucVu(string chucVu)
        {
            lb_ChucVu.Text = chucVu;
        }
    }
}
