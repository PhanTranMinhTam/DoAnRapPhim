using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThemNhanVien : Form
    {
        private NhanVienBUL nhanvienBUL;

        public frm_ThemNhanVien()
        {
            InitializeComponent();
            nhanvienBUL = new NhanVienBUL();
            txt_mnv.Enabled = false; // Không cho nhập mã nhân viên
            txt_mnv.Text = GenerateMaNhanVien(); // Tự động sinh mã nhân viên
        }

        public NhanVienDTO AddedNhanVien { get; private set; } // Thêm thuộc tính để lưu nhân viên đã thêm

        private void btn_huy_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các ô nhập
            this.txt_tennhanvien.Clear();
            this.txt_diachi.Clear();
            this.txt_email.Clear();
            this.txt_sdt.Clear();
            txt_mnv.Text = GenerateMaNhanVien(); // Tạo mã mới
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường TextBox
            string maNhanVien = txt_mnv.Text.Trim(); // Sử dụng mã tự sinh
            string tenNhanVien = txt_tennhanvien.Text.Trim();
            string diaChi = txt_diachi.Text.Trim();
            string email = txt_email.Text.Trim();
            string soDienThoai = txt_sdt.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(tenNhanVien))
            {
                MessageBox.Show("Tên nhân viên không được để trống.");
                return;
            }

            NhanVienDTO nhanVien = new NhanVienDTO
            {
                MaNhanVien = maNhanVien, // Sử dụng mã tự sinh
                TenNhanVien = tenNhanVien,
                DiaChi = diaChi,
                Email = email,
                SoDienThoai = soDienThoai
            };

            // Gọi hàm BLL
            string errorMessage;
            bool success = nhanvienBUL.ThemNhanVien(nhanVien, out errorMessage);

            if (success)
            {
                MessageBox.Show("Thêm nhân viên thành công.");
                // Xử lý cập nhật giao diện nếu cần
            }
            else
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GenerateMaNhanVien()
        {
            int maxMaNV = nhanvienBUL.GetMaxMaNhanVien();
            int newMaNV = maxMaNV + 1;
            return "NV" + newMaNV.ToString().PadLeft(3, '0');
        }

        private void frm_ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

    }
}
