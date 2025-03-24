using BUL;
using DTO;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_SuaDichVu : Form
    {
        DichVuBUL dichVuBUL;
        string maDoAn;
        string defaultImagePath = @"Resources\init_image.jpg";
        public frm_SuaDichVu(string maDoAn)
        {
            InitializeComponent();
            this.maDoAn = maDoAn;
            dichVuBUL = new DichVuBUL();
            loadData();
            txt_MaDoAn.Enabled = false;
            //pic_HinhAnh.ImageLocation = defaultImagePath;
            pic_HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        public void loadData()
        {
            DichVuDTO dichVuDTO = dichVuBUL.layThongTinDVTheoMa(maDoAn);
            txt_MaDoAn.Text = dichVuDTO.MaDoAn;
            txt_TenMon.Text = dichVuDTO.TenDoAn;
            txt_DonGia.Text = dichVuDTO.DonGia.ToString();
            txt_SoLuong.Text = dichVuDTO.SoLuong.ToString();
            if (dichVuDTO.HinhAnh != null)
            {
                pic_HinhAnh.ImageLocation = dichVuDTO.HinhAnh;
                pic_HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                if (File.Exists(defaultImagePath))
                {
                    pic_HinhAnh.ImageLocation = defaultImagePath;
                    pic_HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Hình ảnh mặc định không tồn tại.");
                }
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

        private void btn_NhapLai_Click(object sender, System.EventArgs e)
        {
            txt_TenMon.Text = "";
            txt_DonGia.Text = "";
            pic_HinhAnh.ImageLocation = defaultImagePath;
            errorProvider1.Clear();
            txt_TenMon.Focus();
        }

        private void btn_ChonHinh_Click(object sender, System.EventArgs e)
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

        private void btn_Luu_Click(object sender, System.EventArgs e)
        {
            if (kiemTraNhap() == true)
            {
                DichVuDTO dichVuDTO = new DichVuDTO();
                dichVuDTO.MaDoAn = txt_MaDoAn.Text;
                dichVuDTO.TenDoAn = txt_TenMon.Text;
                dichVuDTO.DonGia = double.Parse(txt_DonGia.Text);
                dichVuDTO.HinhAnh = Path.Combine("Resources", "DichVu", Path.GetFileName(pic_HinhAnh.ImageLocation));
                dichVuDTO.SoLuong = txt_SoLuong.Text == "" ? 0 : int.Parse(txt_SoLuong.Text);
                dichVuDTO.TrangThai = 1;
                string errorMessage;

                bool kq = dichVuBUL.suaDichVu(dichVuDTO, out errorMessage);

                if (kq)
                {
                    MessageBox.Show("Sửa dịch vụ thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Sửa dịch vụ thất bại: {errorMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
