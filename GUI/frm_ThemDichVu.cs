using BUL;
using DTO;
using System;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThemDichVu : Form
    {
        DichVuBUL dichVuBUL;
        // Đặt hình ảnh mặc định
        string defaultImagePath = @"Resources\init_image.jpg";  // Đường dẫn chuỗi
        public frm_ThemDichVu()
        {
            InitializeComponent();
            dichVuBUL = new DichVuBUL();
            txt_MaDoAn.Text = dichVuBUL.taoMaDoAn();
            txt_MaDoAn.Enabled = false;
            txt_TenMon.Focus();


            if (File.Exists(defaultImagePath))
            {
                pic_HinhAnh.ImageLocation = defaultImagePath;  // Sử dụng ImageLocation để load ảnh từ đường dẫn
                pic_HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Hình ảnh mặc định không tồn tại.");
            }
        }

        public bool kiemTraNhap()
        {
            if (txt_TenMon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn");
                return false;
            }
            if (txt_DonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                return false;
            }
            if (pic_HinhAnh.ImageLocation == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh");
                return false;
            }
            return true;
        }

        private void btn_ChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(sourceFilePath);
                string maDoAn = txt_MaDoAn.Text;
                string targetDirectory = Path.Combine(Application.StartupPath, "Resources", "DichVu");
                string targetFilePath = Path.Combine(targetDirectory, maDoAn + fileExtension);

                // Ensure the Resources/DichVu directory exists
                Directory.CreateDirectory(targetDirectory);

                // Copy the file to the Resources/DichVu directory with the new name
                File.Copy(sourceFilePath, targetFilePath, true);

                // Update the picture box to show the selected image
                pic_HinhAnh.ImageLocation = targetFilePath;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (kiemTraNhap())
            {
                DichVuDTO dichVuDTO = new DichVuDTO
                {
                    MaDoAn = txt_MaDoAn.Text,
                    TenDoAn = txt_TenMon.Text,
                    DonGia = double.Parse(txt_DonGia.Text),
                    HinhAnh = Path.Combine("Resources", "DichVu", Path.GetFileName(pic_HinhAnh.ImageLocation)),
                    TrangThai = 1,
                    SoLuong = int.Parse(txt_SoLuong.Text) // Thêm kiểm tra số lượng
                };

                string errorMessage;
                bool kq = dichVuBUL.themDichVu(dichVuDTO, out errorMessage);

                if (kq)
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Thêm dịch vụ thất bại: {errorMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                errorProvider1.SetError(txt_DonGia, "Chỉ được nhập số");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TenMon.Text = "";
            txt_DonGia.Text = "";
            pic_HinhAnh.ImageLocation = defaultImagePath;
            errorProvider1.Clear();
            txt_TenMon.Focus();
        }
    }
}