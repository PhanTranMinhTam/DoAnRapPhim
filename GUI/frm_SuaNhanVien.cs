using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_SuaNhanVien : Form
    {
        private NhanVienBUL nhanvienBUL;
        private NhanVienDTO nhanVien; // Biến để lưu thông tin nhân viên

        public frm_SuaNhanVien(NhanVienDTO nhanVien)
        {
            InitializeComponent();
            nhanvienBUL = new NhanVienBUL();
            this.nhanVien = nhanVien; // Lưu thông tin nhân viên vào biến

            // Điền thông tin vào các TextBox
            txt_mnv.Text = nhanVien.MaNhanVien; // Không cho sửa mã nhân viên
            txt_mnv.Enabled = false; // Không cho chỉnh sửa mã nhân viên
            txt_tennhanvien.Text = nhanVien.TenNhanVien;
            txt_diachi.Text = nhanVien.DiaChi;
            txt_email.Text = nhanVien.Email;
            txt_sdt.Text = nhanVien.SoDienThoai;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.txt_tennhanvien.Clear();
            this.txt_diachi.Clear();
            this.txt_email.Clear();
            this.txt_sdt.Clear();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            nhanVien.TenNhanVien = txt_tennhanvien.Text.Trim();
            nhanVien.DiaChi = txt_diachi.Text.Trim();
            nhanVien.Email = txt_email.Text.Trim();
            nhanVien.SoDienThoai = txt_sdt.Text.Trim();

            // Gọi phương thức sửa nhân viên từ lớp BLL
            string errorMessage;
            bool isSuccess = nhanvienBUL.SuaNhanVien(nhanVien, out errorMessage);

            // Kiểm tra kết quả và hiển thị thông báo
            if (isSuccess)
            {
                MessageBox.Show("Sửa nhân viên thành công!");
                this.DialogResult = DialogResult.OK; // Trả về OK nếu sửa thành công
                this.Close(); // Đóng form
            }
            else
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_SuaNhanVien_Load(object sender, EventArgs e)
        {

        }

    }
}
