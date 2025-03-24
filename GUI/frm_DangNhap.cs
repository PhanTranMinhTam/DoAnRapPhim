using BUL;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        NguoiDungBUL bul;
        public frm_DangNhap()
        {
            InitializeComponent();
            bul = new NguoiDungBUL();

            //Không thay đổi kích thước form

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            txt_TenDangNhap.Text = "huuminh";
            txt_MatKhau.Text = "1";


        }

        private void frm_DangNhap_Load(object sender, System.EventArgs e)
        {
            txt_TenDangNhap.Focus();
        }

        private void cb_HienThiMK_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cb_HienThiMK.Checked == true)
            {
                txt_MatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

        private void btn_CauHinh_Click(object sender, System.EventArgs e)
        {
            frm_CauHinh frm = new frm_CauHinh();
            frm.Pre = this;
            frm.Show();
            this.Hide();
        }

        private void btn_DangNhap_Click(object sender, System.EventArgs e)
        {
            if (txt_TenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập " + lb_TenDangNhap.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenDangNhap.Focus();
                return;
            }

            if (txt_MatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập " + lb_MatKhau.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhau.Focus();
                return;
            }

            // Kiểm tra tài khoản và mật khẩu
            string username = txt_TenDangNhap.Text;
            string password = txt_MatKhau.Text;
            NguoiDungDTO user = new NguoiDungDTO { TenDangNhap = username, MatKhau = password };
            NhanVienInfo nhanVienInfo = bul.isValid(user);
            if (nhanVienInfo == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenDangNhap.Focus();
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Main frm = new frm_Main(username, nhanVienInfo.MaNhanVien, nhanVienInfo.TenNhanVien, nhanVienInfo.ChucVu);
                frm.Show();
                this.Hide();
            }
        }

        private void btn_NhapLai_Click(object sender, System.EventArgs e)
        {
            txt_MatKhau.Text = "";
            txt_TenDangNhap.Text = "";
            txt_TenDangNhap.Focus();
        }

        private void lb_DoiMatKhau_Click(object sender, System.EventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau();
            frm.Pre = this;
            frm.Show();
            this.Hide();
        }
    }
}
