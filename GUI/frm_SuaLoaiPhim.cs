using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_SuaLoaiPhim : Form
    {
        private LoaiPhimBUL loaiPhimBUL;
        private LoaiPhimDTO loaiPhim;
        public frm_SuaLoaiPhim(LoaiPhimDTO loaiPhim)
        {
            InitializeComponent();
            loaiPhimBUL = new LoaiPhimBUL();
            this.loaiPhim = loaiPhim;
            txt_MaLP.Text = loaiPhim.MaLoaiPhim;
            txt_MaLP.Enabled = false;
            txt_TenLP.Text = loaiPhim.TenLoaiPhim;
            txt_MoTa.Text = loaiPhim.MoTa;

        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            loaiPhim.MaLoaiPhim = txt_MaLP.Text.Trim();
            loaiPhim.TenLoaiPhim = txt_TenLP.Text.Trim();
            loaiPhim.MoTa = txt_MoTa.Text.Trim();

            // Gọi phương thức sửa nhân viên từ lớp BUL
            bool isSuccess = loaiPhimBUL.SuaLoaiPhim(loaiPhim);

            // Kiểm tra kết quả và hiển thị thông báo
            if (isSuccess)
            {
                MessageBox.Show("Sửa loại phim thành công!");
                this.DialogResult = DialogResult.OK; // Trả về OK nếu sửa thành công
                this.Close(); // Đóng form
            }
            else
            {
                MessageBox.Show("Sửa loại phim thất bại!");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
