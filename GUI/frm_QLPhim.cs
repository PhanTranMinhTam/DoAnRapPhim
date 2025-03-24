using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace GUI
{
    public partial class frm_QLPhim : Form
    {
        PhimBUL phimBUL;
        List<PhimDTO> danhSachPhim;
        public frm_QLPhim()
        {
            InitializeComponent();
            phimBUL = new PhimBUL();
            loadData();

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            {
                frm_ThemPhim form = new frm_ThemPhim();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
            }
        }

        public void loadData()
        {

            danhSachPhim = phimBUL.getPhim();
            dgv_Phim.AutoGenerateColumns = false;
            dgv_Phim.DataSource = danhSachPhim;
            //dgv_Phim.Columns["maLoaiPhim"].Visible = false;
            //dgv_Phim.Columns["trangThai"].Visible = false;
        }

        private void txt_TimKiem_TextChange(object sender, EventArgs e)
        {
            // Kiểm tra xem danh sách phim có được khởi tạo không
            if (danhSachPhim == null)
            {
                MessageBox.Show("Danh sách phim chưa được khởi tạo.");
                return;
            }

            string tuKhoa = txt_TimKiem.Text.Trim().ToLower();

            // Tìm kiếm phim trong danh sách
            List<PhimDTO> ketQuaTimKiem = danhSachPhim
                .Where(phim =>
                    (phim.MaPhim != null && phim.MaPhim.ToLower().Contains(tuKhoa)) ||
                    (phim.TenPhim != null && phim.TenPhim.ToLower().Contains(tuKhoa)) ||
                    (phim.DaoDien != null && phim.DaoDien.ToLower().Contains(tuKhoa)) ||
                    (phim.QuocGia != null && phim.QuocGia.ToLower().Contains(tuKhoa)) ||
                    (phim.TenLoaiPhim != null && phim.TenLoaiPhim.ToLower().Contains(tuKhoa)))
                .ToList();

            dgv_Phim.DataSource = ketQuaTimKiem;
        }


        private void frm_QLPhim_Load(object sender, EventArgs e)
        {

        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin phim được chọn từ DataGridView
            if (dgv_Phim.SelectedRows.Count > 0)
            {
                // Lấy thông tin phim từ dòng đã chọn
                PhimDTO selectedPhim = dgv_Phim.SelectedRows[0].DataBoundItem as PhimDTO;

                // Kiểm tra xem có phim nào được chọn không
                if (selectedPhim != null)
                {
                    // Khởi tạo form sửa phim với thông tin đã chọn
                    frm_SuaPhim form = new frm_SuaPhim(selectedPhim);

                    // Hiển thị form và kiểm tra kết quả
                    if (form.ShowDialog() == DialogResult.OK)
                    {

                        loadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phim để sửa!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgv_Phim.SelectedRows.Count > 0)
            {
                // Lấy mã nhân viên từ dòng được chọn
                string maphim = dgv_Phim.SelectedRows[0].Cells["maPhim"].Value.ToString();

                // Xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phim này không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức xóa nhân viên từ lớp BUL
                    bool isSuccess = phimBUL.xoaPhim(maphim);

                    // Kiểm tra kết quả và hiển thị thông báo
                    if (isSuccess)
                    {
                        MessageBox.Show("Xóa phim thành công!");
                        loadData(); // Tải lại dữ liệu hiển thị
                    }
                    else
                    {
                        MessageBox.Show("Xóa phim thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim để xóa.");
            }
        }

        private void dgv_Phim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin phim được chọn từ DataGridView
            if (dgv_Phim.SelectedRows.Count > 0)
            {
                // Lấy thông tin phim từ dòng đã chọn
                PhimDTO selectedPhim = dgv_Phim.SelectedRows[0].DataBoundItem as PhimDTO;

                // Kiểm tra xem có phim nào được chọn không
                if (selectedPhim != null)
                {
                    // Khởi tạo form xem chi tiết phim với thông tin đã chọn
                    frm_ChiTietPhim form = new frm_ChiTietPhim(selectedPhim);
                    form.ShowDialog();
                }
            }
        }
    }
}
