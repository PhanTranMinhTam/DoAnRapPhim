using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace GUI
{
    public partial class frm_SuaPhim : Form
    {
        private PhimBUL phimBUL; // Biến để gọi các phương thức từ lớp BUL
        private PhimDTO phim; // Biến để lưu thông tin phim

        public frm_SuaPhim(PhimDTO phim)
        {
            InitializeComponent();
            phimBUL = new PhimBUL();
            this.phim = phim; // Lưu thông tin phim vào biến

            // Điền thông tin vào các TextBox
            txt_ma.Text = phim.MaPhim; // Không cho sửa mã phim
            txt_ma.Enabled = false; // Không cho chỉnh sửa mã phim
            txt_tenphim.Text = phim.TenPhim;
            txt_thoiluong.Text = phim.ThoiLuong.ToString();
            txt_daodien.Text = phim.DaoDien;
            txt_quocgia.Text = phim.QuocGia;
            txt_noidung.Text = phim.NoiDung;
            pic_HinhAnh.ImageLocation = phim.HinhAnh;
            dtp_ngaychieu.Value = phim.NgayChieu;
            dtp_ngayKT.Value = phim.NgayKT;
            loadComboboxData();
        }
        private void loadComboboxData()
        {
            List<PhimDTO> dsLoaiPhim = phimBUL.GetLoaiPhimCombo(); // Lấy danh sách loại phim
            cbo_loaiphim.DataSource = dsLoaiPhim; // Gán dữ liệu cho ComboBox
            cbo_loaiphim.DisplayMember = "TenLoaiPhim"; // Tên hiển thị
            cbo_loaiphim.ValueMember = "maLoaiPhim"; // Giá trị lưu
        }





        private void btn_chon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(sourceFilePath);
                string maDoAn = txt_ma.Text;
                string targetDirectory = Path.Combine(Application.StartupPath, "Resources", "Phim");
                string targetFilePath = Path.Combine(targetDirectory, maDoAn + fileExtension);

                // Ensure the Resources/DichVu directory exists
                Directory.CreateDirectory(targetDirectory);

                // Copy the file to the Resources/DichVu directory with the new name
                File.Copy(sourceFilePath, targetFilePath, true);

                // Update the picture box to show the selected image
                pic_HinhAnh.ImageLocation = targetFilePath;
            }
        }

        private void frm_SuaPhim_Load(object sender, EventArgs e)
        {
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_tenphim.Clear();
            txt_thoiluong.Clear();
            txt_daodien.Clear();
            txt_quocgia.Clear();
            txt_noidung.Clear();
        }

        private void btn_hoantat_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin phim từ các trường TextBox
            phim.TenPhim = txt_tenphim.Text.Trim();

            // Khai báo biến tạm để lưu giá trị thời lượng phim
            int thoiLuong;

            // Kiểm tra và cập nhật thời lượng phim
            if (int.TryParse(txt_thoiluong.Text.Trim(), out thoiLuong))
            {
                phim.ThoiLuong = thoiLuong; // Gán giá trị thời lượng mới
            }
            else
            {
                MessageBox.Show("Thời lượng phim không hợp lệ. Vui lòng nhập một số nguyên hợp lệ.");
                return; // Dừng phương thức nếu thời lượng không hợp lệ
            }

            phim.DaoDien = txt_daodien.Text.Trim();
            phim.QuocGia = txt_quocgia.Text.Trim();
            phim.NoiDung = txt_noidung.Text.Trim();
            phim.HinhAnh = Path.Combine("Resources", "Phim", Path.GetFileName(pic_HinhAnh.ImageLocation));
            phim.NgayChieu = dtp_ngaychieu.Value;
            phim.NgayKT = dtp_ngayKT.Value;

            // Gọi phương thức sửa phim từ lớp BUL
            bool isSuccess = phimBUL.SuaPhim(phim);

            // Kiểm tra kết quả và hiển thị thông báo
            if (isSuccess)
            {
                MessageBox.Show("Sửa phim thành công!");
                this.DialogResult = DialogResult.OK; // Trả về OK nếu sửa thành công
                this.Close(); // Đóng form
            }
            else
            {
                MessageBox.Show("Sửa phim thất bại!");
            }
        }
    }
}
