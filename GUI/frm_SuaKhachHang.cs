using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_SuaKhachHang : Form
    {
        private KhachHangBUL khachHangBUL;
        private KhachHangDTO khachHang;
        public frm_SuaKhachHang(KhachHangDTO KhachHang)
        {
            InitializeComponent();
            khachHangBUL = new KhachHangBUL();
            this.khachHang = KhachHang;
            txt_MaKH.Text = KhachHang.MaKhachHang;
            txt_MaKH.Enabled = false;
            txt_TenKH.Text = KhachHang.TenKhachHang;
            txt_DiaChi.Text = KhachHang.DiaChi;
            txt_Email.Text = KhachHang.Email;
            txt_SDT.Text = KhachHang.SDT;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            khachHang.MaKhachHang = txt_MaKH.Text.Trim();
            khachHang.TenKhachHang = txt_TenKH.Text.Trim();
            khachHang.DiaChi = txt_DiaChi.Text.Trim();
            khachHang.Email = txt_Email.Text.Trim();
            khachHang.SDT = txt_SDT.Text.Trim();

            // Gọi phương thức sửa nhân viên từ lớp BUL
            bool isSuccess = khachHangBUL.SuaKhachHang(khachHang);

            // Kiểm tra kết quả và hiển thị thông báo
            if (isSuccess)
            {
                MessageBox.Show("Sửa khách hàng thành công!");
                this.DialogResult = DialogResult.OK; // Trả về OK nếu sửa thành công
                this.Close(); // Đóng form
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại!");
            }
        }
    }
}
