using BUL;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{

    public partial class frm_ThemKhachHang : Form
    {
        private KhachHangBUL khachhangBUL;
        public event EventHandler<KhachHangDTO> KhachHangAdded;
        public frm_ThemKhachHang()
        {
            InitializeComponent();
            khachhangBUL = new KhachHangBUL();
        }

        public frm_ThemKhachHang(string soDienThoai) : this()
        {
            txt_SDT.Text = soDienThoai; // Điền sẵn số điện thoại
        }


        private bool IsValidPhoneNumber(string sdt)
        {
            return sdt.All(char.IsDigit) && sdt.Length == 10; // Kiểm tra chỉ chứa số và ít nhất 10 ký tự
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }
        private void btn_Huy_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string tenKH = txt_TenKH.Text;
            string diaChi = txt_DiaChi.Text;
            string email = txt_Email.Text;
            string sdt = txt_SDT.Text;

            // Kiểm tra ràng buộc email
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            // Kiểm tra ràng buộc số điện thoại
            if (string.IsNullOrWhiteSpace(sdt) || !IsValidPhoneNumber(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            // Thêm khách hàng mới
            bool isAdded = khachhangBUL.ThemKhachHang(tenKH, diaChi, email, sdt);

            if (isAdded)
            {
                MessageBox.Show("Thêm khách hàng thành công!");

                // Lấy thông tin khách hàng vừa thêm
                KhachHangDTO khachHang = khachhangBUL.layKhachHangTheoSDT(sdt);

                // Phát sự kiện KhachHangAdded
                KhachHangAdded?.Invoke(this, khachHang);

                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm khách hàng.");
            }
        }

        private void frm_ThemKhachHang_Load(object sender, System.EventArgs e)
        {
            string maKH = khachhangBUL.layMaTuDong();
            txt_MaKH.Text = maKH;
        }

    }
}
