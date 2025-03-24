using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLKhuyenMai : Form
    {
        KhuyenMaiBUL khuyenmaiBUL;
        List<KhuyenMaiDTO> danhSachkhuyenmai;
        public frm_QLKhuyenMai()
        {
            InitializeComponent();
            khuyenmaiBUL = new KhuyenMaiBUL();
            loadData();
        }
        public void loadData()
        {
            //dgv_LichChieu.AutoGenerateColumns = false;
            danhSachkhuyenmai = khuyenmaiBUL.GetKhuyenMai();
            dgv_khuyenmai.DataSource = danhSachkhuyenmai;
            dgv_khuyenmai.Columns["trangThai"].Visible = false;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_khuyenmai.SelectedRows.Count > 0)
            {
                // Lấy mã từ dòng được chọn
                string makm = dgv_khuyenmai.SelectedRows[0].Cells["maKM"].Value.ToString();

                // Xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này không?", "Xóa khuyến mãi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức xóa từ lớp BUL
                    bool isSuccess = khuyenmaiBUL.xoaKhuyenMai(makm);

                    // Kiểm tra kết quả và hiển thị thông báo
                    if (isSuccess)
                    {
                        MessageBox.Show("Xóa khuyến mãi thành công!");
                        loadData(); // Tải lại dữ liệu hiển thị
                    }
                    else
                    {
                        MessageBox.Show("Xóa khuyến mãi thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khuyến mãi để xóa.");
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemKhuyenMai frm = new frm_ThemKhuyenMai();
            frm.Show();
            frm.FormClosed += (s, ev) =>
            {
                loadData();
            };
        }

        private void frm_QLKhuyenMai_Load(object sender, EventArgs e)
        {

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm và chuyển thành chữ thường
            string tuKhoa = txt_TimKiem.Text.Trim().ToLower();

            // Tìm kiếm trong danh sách khuyến mãi
            List<KhuyenMaiDTO> ketQuaTimKiem = danhSachkhuyenmai
                .Where(km =>
                    km.MaKM.ToLower().Contains(tuKhoa) ||  // Tìm theo mã khuyến mãi
                    km.TenKM.ToLower().Contains(tuKhoa) ||       // Tìm theo tên khuyến mãi
                    (km.ThoiGianBD.HasValue && km.ThoiGianBD.Value.ToString("yyyy-MM-dd").Contains(tuKhoa)) || // Ngày bắt đầu
                    (km.ThoiGianKT.HasValue && km.ThoiGianKT.Value.ToString("yyyy-MM-dd").Contains(tuKhoa)) || // Ngày kết thúc
                    (km.PhanTramKM.HasValue && km.PhanTramKM.Value.ToString().Contains(tuKhoa))  // Phần trăm khuyến mãi
                )
                .ToList();

            // Cập nhật DataGridView với kết quả tìm kiếm
            dgv_khuyenmai.DataSource = ketQuaTimKiem;
        }
    }
}
