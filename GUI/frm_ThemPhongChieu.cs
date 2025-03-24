using BUL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThemPhongChieu : Form
    {
        private PhongChieuBUL phongchieuBUL;
        public frm_ThemPhongChieu()
        {
            InitializeComponent();
            phongchieuBUL = new PhongChieuBUL();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maPhongChieu = phongchieuBUL.layMaTuDong();
            string tenPhongChieu = txt_TenPC.Text;
            int soLuongGhe;

            // Kiểm tra nếu số lượng ghế là số hợp lệ
            if (!int.TryParse(txt_SoLuongGhe.Text, out soLuongGhe))
            {
                MessageBox.Show("Số lượng ghế phải là một số hợp lệ!");
                return;
            }

            // Kiểm tra ràng buộc tên phòng chiếu
            if (string.IsNullOrWhiteSpace(tenPhongChieu))
            {
                MessageBox.Show("Tên phòng chiếu không được để trống!");
                return;
            }

            // Thêm phòng chiếu mới
            bool isAdded = phongchieuBUL.ThemPhongChieu(tenPhongChieu, soLuongGhe);

            if (isAdded)
            {
                MessageBox.Show("Thêm phòng chiếu thành công!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm phòng chiếu.");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThemPhongChieu_Load(object sender, EventArgs e)
        {
            string maPC = phongchieuBUL.layMaTuDong();
            txt_MaPC.Text = maPC;
        }
    }
}
