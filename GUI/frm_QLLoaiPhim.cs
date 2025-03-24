using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLLoaiPhim : Form
    {

        LoaiPhimBUL loaiphimBUL;
        List<LoaiPhimDTO> danhSachLoaiPhim;
        public frm_QLLoaiPhim()
        {
            InitializeComponent();
            loaiphimBUL = new LoaiPhimBUL();
            loadData();
        }

        public void loadData()
        {
            danhSachLoaiPhim = loaiphimBUL.getLoaiPhim();
            dgv_LoaiPhim.DataSource = danhSachLoaiPhim;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemLoaiPhim frm = new frm_ThemLoaiPhim();
            //nếu form đóng thì load lại dữ liệu
            frm.Show();
            frm.FormClosed += (s, ev) =>
            {
                loadData();
            };
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_LoaiPhim.SelectedRows.Count > 0)
            {
                // Lấy mã loại phim từ dòng được chọn trong DataGridView
                string maLoaiPhim = dgv_LoaiPhim.SelectedRows[0].Cells["maLoaiPhim"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phim này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Gọi BUL để xóa loại phim
                    bool result = loaiphimBUL.XoaLoaiPhim(maLoaiPhim);

                    if (result)
                    {
                        MessageBox.Show("Xóa loại phim thành công.");
                        // Cập nhật lại danh sách loại phim trên DataGridView
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại phim thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại phim để xóa.");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_LoaiPhim.SelectedRows.Count > 0)
            {
                // Lấy thông tin nhân viên từ dòng đã chọn
                LoaiPhimDTO selectedLoaiPhim = dgv_LoaiPhim.SelectedRows[0].DataBoundItem as LoaiPhimDTO;

                // Khởi tạo form sửa nhân viên với thông tin đã chọn
                frm_SuaLoaiPhim form = new frm_SuaLoaiPhim(selectedLoaiPhim);

                // Hiển thị form và kiểm tra kết quả
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại dữ liệu hiển thị nếu sửa thành công
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phim để sửa!");
            }
        }

        private void txt_TimKiem_TextChange(object sender, EventArgs e)
        {
            string tukhoa = txt_TimKiem.Text.Trim().ToLower();

            if (danhSachLoaiPhim != null)
            {
                List<LoaiPhimDTO> ketQua = (from nv in danhSachLoaiPhim
                                            where nv.MaLoaiPhim.ToLower().Contains(tukhoa) ||
                                                  nv.TenLoaiPhim.ToLower().Contains(tukhoa) ||
                                                  nv.MoTa.ToLower().Contains(tukhoa)
                                            select nv).ToList();

                // Bind the filtered data to the DataGridView
                dgv_LoaiPhim.DataSource = ketQua;
            }
            else
            {
                dgv_LoaiPhim.DataSource = null;
                MessageBox.Show("Danh sách loại phim đang trống hoặc không thể tìm thấy.");
            }
        }
    }
}
