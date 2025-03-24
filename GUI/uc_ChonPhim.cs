using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_ChonPhim : UserControl
    {
        private Panel pnlChonPhim;
        private PictureBox pbHinhAnh;
        private Label lblTenPhim;
        private Label lblNamSanXuat;
        private Button btnChonPhim;
        private string maPhim;

        public event EventHandler<string> MovieSelected;


        public uc_ChonPhim()
        {
            InitializeComponent();
            InitializePhimControls();
        }

        private void InitializePhimControls()
        {
            pnlChonPhim = new Panel
            {
                Size = new System.Drawing.Size(500, 400),
                BorderStyle = BorderStyle.FixedSingle
            };

            pbHinhAnh = new PictureBox
            {
                Size = new System.Drawing.Size(210, 260),
                Location = new System.Drawing.Point(2, 0),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            lblTenPhim = new Label
            {
                AutoSize = false,
                Text = "Tên Phim",
                Location = new System.Drawing.Point(10, 280),
                Size = new System.Drawing.Size(200, 30),
                Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            lblNamSanXuat = new Label
            {
                AutoSize = false,
                Text = "Năm sản xuất: 2021",
                Location = new System.Drawing.Point(10, 320),
                Size = new System.Drawing.Size(200, 30),
                Font = new System.Drawing.Font("Arial", 12),
                ForeColor = System.Drawing.Color.Red,
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnChonPhim = new Button
            {
                Text = "Chọn Phim",
                Location = new System.Drawing.Point(10, 355),
                Size = new System.Drawing.Size(200, 40),
                Font = new System.Drawing.Font("Arial", 12),
                BackColor = System.Drawing.Color.FromArgb(0, 192, 192),
                ForeColor = System.Drawing.Color.White
            };

            pnlChonPhim.Controls.Add(pbHinhAnh);
            pnlChonPhim.Controls.Add(lblTenPhim);
            pnlChonPhim.Controls.Add(lblNamSanXuat);
            pnlChonPhim.Controls.Add(btnChonPhim);
            this.Controls.Add(pnlChonPhim);

            btnChonPhim.Click += BtnChonPhim_Click;
        }

        private void BtnChonPhim_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show("Mã Phim: " + maPhim, "Thông tin phim vừa chọn");
            MovieSelected?.Invoke(this, maPhim);
            //frm_HienThiGhe frm = new frm_HienThiGhe(maPhim);
            //frm.Show();
        }

        public void SetMovieInfo(PhimDTO movie)
        {
            maPhim = movie.MaPhim; // Lưu trữ maPhim
            lblTenPhim.Text = movie.TenPhim;
            lblNamSanXuat.Text = "Ngày chiếu: " + movie.NgayChieu.Year;
            pbHinhAnh.Image = Image.FromFile(movie.HinhAnh);
        }
    }
}