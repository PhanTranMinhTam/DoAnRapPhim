using BUL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLPhongChieu : Form
    {
        PhongChieuBUL phongChieuBUL;
        List<PhongChieuDTO> danhSachPhongChieu;
        public frm_QLPhongChieu()
        {
            InitializeComponent();
            phongChieuBUL = new PhongChieuBUL();
            loadData();
        }

        public void loadData()
        {
            danhSachPhongChieu = phongChieuBUL.getPhongChieu();
            dgv_PhongChieu.DataSource = danhSachPhongChieu;
        }
        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            frm_ThemPhongChieu frm = new frm_ThemPhongChieu();
            frm.Show();
            frm.FormClosed += (s, ev) =>
            {
                loadData();
            };
        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            if (dgv_PhongChieu.SelectedRows.Count > 0)
            {
                // Lấy thông tin nhân viên từ dòng đã chọn
                PhongChieuDTO selectedPhongChieu = dgv_PhongChieu.SelectedRows[0].DataBoundItem as PhongChieuDTO;

                // Khởi tạo form sửa nhân viên với thông tin đã chọn
                frm_SuaPhongChieu form = new frm_SuaPhongChieu(selectedPhongChieu);

                // Hiển thị form và kiểm tra kết quả
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại dữ liệu hiển thị nếu sửa thành công
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu để sửa!");
            }
        }

        private void btn_Xoa_Click(object sender, System.EventArgs e)
        {
            if (dgv_PhongChieu.SelectedRows.Count > 0)
            {
                // Lấy mã loại phim từ dòng được chọn trong DataGridView
                string maPhongChieu = dgv_PhongChieu.SelectedRows[0].Cells["MaPhongChieu"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng chiếu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Gọi BUL để xóa loại phim
                    bool result = phongChieuBUL.XoaPhongChieu(maPhongChieu);

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

        private void txt_TimKiem_TextChange(object sender, System.EventArgs e)
        {
            string tukhoa = txt_TimKiem.Text.Trim().ToLower();

            if (danhSachPhongChieu != null)
            {
                List<PhongChieuDTO> ketQua = (from pc in danhSachPhongChieu
                                              where pc.MaPhongChieu.ToLower().Contains(tukhoa) ||
                                                    pc.TenPhongChieu.ToLower().Contains(tukhoa) ||
                                                    pc.SoLuongGhe.ToString().Contains(tukhoa)
                                              select pc).ToList();

                // Bind the filtered data to the DataGridView
                dgv_PhongChieu.DataSource = ketQua;
            }
            else
            {
                dgv_PhongChieu.DataSource = null;
                MessageBox.Show("Danh sách phòng chiếu đang trống hoặc không thể tìm thấy.");
            }
        }
    }
}
