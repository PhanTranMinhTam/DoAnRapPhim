using BUL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_DoiMatKhau : Form
    {
        NguoiDungBUL nguoiDungBUL;
        public Form Pre;
        public frm_DoiMatKhau()
        {
            InitializeComponent();
            nguoiDungBUL = new NguoiDungBUL();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đầy đủ thông tin
            if (txt_TenDangNhap.Text == "" || txt_MatKhauCu.Text == "" || txt_MatKhauMoi.Text == "" || txt_XacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra tên đăng nhập và mật khẩu cũ có đúng không
            if (!nguoiDungBUL.KiemTraMatKhauCu(txt_TenDangNhap.Text, txt_MatKhauCu.Text))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra mật khẩu mới và xác nhận mật khẩu có trùng nhau không
            if (txt_MatKhauMoi.Text != txt_XacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Đổi mật khẩu
            if (nguoiDungBUL.DoiMatKhau(txt_TenDangNhap.Text, txt_MatKhauMoi.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Pre.Show(); // Show the previous form (frm_DangNhap)
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = "";
            txt_MatKhauCu.Text = "";
            txt_MatKhauMoi.Text = "";
            txt_XacNhanMatKhau.Text = "";
        }
    }
}
