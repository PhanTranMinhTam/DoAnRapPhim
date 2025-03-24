using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLKhachHang : Form
    {
        KhachHangBUL khachhangBUL;
        List<KhachHangDTO> danhSachKhachHang;
        public frm_QLKhachHang()
        {
            InitializeComponent();
            khachhangBUL = new KhachHangBUL();
            loadData();
        }
        public void loadData()
        {
            //dgv_LichChieu.AutoGenerateColumns = false;
            danhSachKhachHang = khachhangBUL.getKhachHang();
            dgv_KhachHang.DataSource = danhSachKhachHang;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemKhachHang frm = new frm_ThemKhachHang();
            frm.Show();
            frm.FormClosed += (s, ev) =>
            {
                loadData();
            };
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.SelectedRows.Count > 0)
            {
                // Lấy thông tin nhân viên từ dòng đã chọn
                KhachHangDTO selectedKhachHang = dgv_KhachHang.SelectedRows[0].DataBoundItem as KhachHangDTO;

                // Khởi tạo form sửa nhân viên với thông tin đã chọn
                frm_SuaKhachHang form = new frm_SuaKhachHang(selectedKhachHang);

                // Hiển thị form và kiểm tra kết quả
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại dữ liệu hiển thị nếu sửa thành công
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.SelectedRows.Count > 0)
            {
                // Lấy mã khách hàng từ dòng được chọn trong DataGridView
                string maKhachHang = dgv_KhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bool result = khachhangBUL.XoaKhachHang(maKhachHang);

                    if (result)
                    {
                        MessageBox.Show("Xóa khách hàng thành công.");
                        // Cập nhật lại danh sách khách hàng trên DataGridView
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
            }
        }

        private void txt_TimKiem_TextChange(object sender, EventArgs e)
        {
            string tukhoa = txt_TimKiem.Text.Trim().ToLower();

            if (danhSachKhachHang != null)
            {
                List<KhachHangDTO> ketQua = (from kh in danhSachKhachHang
                                             where kh.MaKhachHang.ToLower().Contains(tukhoa) ||
                                                   kh.TenKhachHang.ToLower().Contains(tukhoa) ||
                                                   kh.DiaChi.ToLower().Contains(tukhoa) ||
                                                   kh.Email.ToLower().Contains(tukhoa) ||
                                                   kh.SDT.ToLower().Contains(tukhoa)
                                             select kh).ToList();

                // Bind the filtered data to the DataGridView
                dgv_KhachHang.DataSource = ketQua;
            }
            else
            {
                dgv_KhachHang.DataSource = null;
                MessageBox.Show("Danh sách khách hàng đang trống hoặc không thể tìm thấy.");
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_TimKiem.Text.Trim().ToLower();

            if (dgv_KhachHang.DataSource != null)
            {
                List<KhachHangDTO> ketQua = (from kh in danhSachKhachHang
                                             where kh.MaKhachHang.ToLower().Contains(tukhoa) ||
                                                   kh.TenKhachHang.ToLower().Contains(tukhoa) ||
                                                   kh.DiaChi.ToLower().Contains(tukhoa) ||
                                                   kh.Email.ToLower().Contains(tukhoa) ||
                                                   kh.SDT.ToLower().Contains(tukhoa)
                                             select kh).ToList();

                // Bind the filtered data to the DataGridView
                dgv_KhachHang.DataSource = ketQua;
            }
            else
            {
                dgv_KhachHang.DataSource = null;
                MessageBox.Show("Danh sách khách hàng đang trống hoặc không thể tìm thấy.");
            }
        }
    }
}
