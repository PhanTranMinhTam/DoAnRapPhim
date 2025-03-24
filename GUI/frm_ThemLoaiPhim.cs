using BUL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThemLoaiPhim : Form
    {
        private LoaiPhimBUL loaiPhimBUL;

        public frm_ThemLoaiPhim()
        {
            InitializeComponent();
            loaiPhimBUL = new LoaiPhimBUL();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maLoai = loaiPhimBUL.layMaTuDong(); // Gọi hàm lấy mã tự động
            string tenLoai = txt_TenLP.Text;
            string moTa = txt_MoTa.Text;

            // Kiểm tra ràng buộc tên loại phim
            if (string.IsNullOrWhiteSpace(tenLoai))
            {
                MessageBox.Show("Tên loại phim không được để trống!");
                return;
            }

            // Thêm loại phim mới
            bool isAdded = loaiPhimBUL.ThemLoaiPhim(tenLoai, moTa); // Gọi phương thức thêm

            if (isAdded)
            {
                MessageBox.Show("Thêm loại phim thành công!");

                // Tải lại dữ liệu (nếu cần thiết)
                //LoadLoaiPhimData(); 

                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm loại phim.");
            }
        }

        private void frm_ThemLoaiPhim_Load(object sender, EventArgs e)
        {
            string maLoai = loaiPhimBUL.layMaTuDong();
            txt_MaLP.Text = maLoai;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
