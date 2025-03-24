using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace GUI
{
    public partial class frm_QLNhanVien : Form
    {
        NhanVienBUL nhanvienBUL;
        List<NhanVienDTO> danhSachNhanVien;

        public frm_QLNhanVien()
        {
            InitializeComponent();
            nhanvienBUL = new NhanVienBUL();
            loadData();
        }

        public void loadData()
        {
            danhSachNhanVien = nhanvienBUL.getNhanVien();
            dgv_NhanVien.DataSource = danhSachNhanVien;
        }


        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_TimKiem.Text.Trim().ToLower();

            List<NhanVienDTO> ketQuaTimKiem = danhSachNhanVien
                .Where(nv =>
                    nv.MaNhanVien.ToLower().Contains(tuKhoa) ||
                    nv.TenNhanVien.ToLower().Contains(tuKhoa) ||
                    nv.DiaChi.ToLower().Contains(tuKhoa) ||
                    nv.Email.ToLower().Contains(tuKhoa) ||
                    nv.SoDienThoai.ToLower().Contains(tuKhoa))
                .ToList();

            dgv_NhanVien.DataSource = ketQuaTimKiem;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            {
                frm_ThemNhanVien form = new frm_ThemNhanVien();
                form.Show();
                form.FormClosed += (s, ev) =>
                {
                    loadData();
                };
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhân viên được chọn từ DataGridView
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                // Lấy thông tin nhân viên từ dòng đã chọn
                NhanVienDTO selectedNhanVien = dgv_NhanVien.SelectedRows[0].DataBoundItem as NhanVienDTO;

                // Khởi tạo form sửa nhân viên với thông tin đã chọn
                frm_SuaNhanVien form = new frm_SuaNhanVien(selectedNhanVien);

                // Hiển thị form và kiểm tra kết quả
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại dữ liệu hiển thị nếu sửa thành công
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
            }
        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                // Lấy mã nhân viên từ dòng được chọn
                string maNhanVien = dgv_NhanVien.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();

                // Xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức xóa nhân viên từ lớp BUL
                    bool isSuccess = nhanvienBUL.xoaNhanVien(maNhanVien);

                    // Kiểm tra kết quả và hiển thị thông báo
                    if (isSuccess)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        loadData(); // Tải lại dữ liệu hiển thị
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
            }
        }
    }
}
