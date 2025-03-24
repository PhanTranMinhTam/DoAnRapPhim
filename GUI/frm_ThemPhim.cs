using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace GUI
{
    public partial class frm_ThemPhim : Form
    {
        private PhimBUL phimBUL;
        public PhimDTO AddedPhim { get; private set; }
        public frm_ThemPhim()
        {
            InitializeComponent();
            phimBUL = new PhimBUL();
            txt_ma.Enabled = false;
            txt_ma.Text = GenerateMaPhim();
            loadComboboxData();
        }

        private void loadComboboxData()
        {
            List<PhimDTO> dsLoaiPhim = phimBUL.GetLoaiPhimCombo(); // Lấy danh sách loại phim
            cbo_loaiphim.DataSource = dsLoaiPhim; // Gán dữ liệu cho ComboBox
            cbo_loaiphim.DisplayMember = "TenLoaiPhim"; // Tên hiển thị
            cbo_loaiphim.ValueMember = "maLoaiPhim"; // Giá trị lưu
        }

        private void btn_chon_Click(object sender, System.EventArgs e)
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

        private void btn_huy_Click(object sender, System.EventArgs e)
        {
            this.txt_ma.Clear();
            this.txt_tenphim.Clear();
            this.txt_noidung.Clear();
            this.txt_quocgia.Clear();
            this.txt_thoiluong.Clear();
            this.txt_daodien.Clear();
            //txt_ma.Text = GenerateMaPhim(); // Tạo mã mới
        }

        private void btn_hoantat_Click(object sender, System.EventArgs e)
        {
            PhimDTO phim = new PhimDTO
            {
                MaPhim = txt_ma.Text,
                TenPhim = txt_tenphim.Text,
                MaLoaiPhim = cbo_loaiphim.SelectedValue.ToString(),
                ThoiLuong = int.Parse(txt_thoiluong.Text),
                DaoDien = txt_daodien.Text,
                QuocGia = txt_quocgia.Text,
                NoiDung = txt_noidung.Text,
                HinhAnh = Path.Combine("Resources", "Phim", Path.GetFileName(pic_HinhAnh.ImageLocation)),
                NgayChieu = pc_ngaychieu.Value,
                NgayKT = pc_ngayKT.Value
            };

            // Thêm phim vào cơ sở dữ liệu
            if (phimBUL.ThemPhim(phim))
            {
                MessageBox.Show("Thêm phim thành công!");
                AddedPhim = phim;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm phim.");
            }
        }

        private string GenerateMaPhim()
        {
            int maxMaPhim = phimBUL.GetMaxMaPhim();
            int newMaPhim = maxMaPhim + 1;
            return "PH" + newMaPhim.ToString().PadLeft(3, '0');
        }

        private void frm_ThemPhim_Load(object sender, EventArgs e)
        {

        }
    }
}
