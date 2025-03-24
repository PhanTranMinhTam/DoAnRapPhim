using BUL;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_ChonDichVu : UserControl
    {
        private PictureBox pictureBoxService;
        private Label lblServiceName;
        private Label lblServicePrice;
        private Button btnSelectService;
        private Button btnIncreaseQuantity;
        private Button btnDecreaseQuantity;
        private Label lblQuantity;
        private string maDoAn;
        private int quantity = 1;
        private DichVuBUL dichVuBUL = new DichVuBUL();
        public event Func<string, int> LaySoLuongDaThem; // Thêm sự kiện để lấy số lượng đã thêm
        public event EventHandler<ServiceSelectedEventArgs> ServiceSelected;

        public uc_ChonDichVu()
        {
            InitializeComponent();
            InitializeServiceControls();
        }

        private void InitializeServiceControls()
        {
            // Tạo Panel chứa các thành phần
            Panel pnl_Service = new Panel
            {
                Size = new Size(200, 380),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Tạo PictureBox hiển thị hình ảnh dịch vụ
            pictureBoxService = new PictureBox
            {
                Size = new Size(200, 200),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Tạo Label hiển thị tên dịch vụ
            lblServiceName = new Label
            {
                AutoSize = false,
                Text = "Tên Dịch Vụ",
                Location = new Point(0, 210),
                Size = new Size(200, 30),
                Font = new Font("Arial", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Tạo Label hiển thị giá dịch vụ
            lblServicePrice = new Label
            {
                AutoSize = false,
                Text = "Giá: 0 VNĐ",
                Location = new Point(0, 240),
                Size = new Size(200, 30),
                Font = new Font("Arial", 12),
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Tạo Button chọn dịch vụ
            btnSelectService = new Button
            {
                Text = "Chọn món",
                Location = new Point(10, 330),
                Size = new Size(180, 40),
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.Orange,
                ForeColor = Color.White
            };
            btnSelectService.Click += BtnSelectService_Click;

            // Tạo Button tăng số lượng
            btnIncreaseQuantity = new Button
            {
                Text = "+",
                Location = new Point(158, 285),
                Size = new Size(30, 30),
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.LightGray
            };
            btnIncreaseQuantity.Click += BtnIncreaseQuantity_Click;

            // Tạo Button giảm số lượng
            btnDecreaseQuantity = new Button
            {
                Text = "-",
                Location = new Point(10, 285),
                Size = new Size(30, 30),
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.LightGray
            };
            btnDecreaseQuantity.Click += BtnDecreaseQuantity_Click;

            // Tạo Label hiển thị số lượng
            lblQuantity = new Label
            {
                AutoSize = false,
                Text = quantity.ToString(),
                Location = new Point(83, 285),
                Size = new Size(30, 30),
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Thêm các thành phần vào Panel
            pnl_Service.Controls.Add(pictureBoxService);
            pnl_Service.Controls.Add(lblServiceName);
            pnl_Service.Controls.Add(lblServicePrice);
            pnl_Service.Controls.Add(btnSelectService);
            pnl_Service.Controls.Add(btnIncreaseQuantity);
            pnl_Service.Controls.Add(btnDecreaseQuantity);
            pnl_Service.Controls.Add(lblQuantity);

            // Thêm Panel vào UserControl
            this.Controls.Add(pnl_Service);
        }

        public void SetServiceDetails(string serviceName, decimal servicePrice, string imagePath, string maDoAn)
        {
            lblServiceName.Text = serviceName;
            lblServicePrice.Text = servicePrice.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
            pictureBoxService.Image = Image.FromFile(imagePath);
            this.maDoAn = maDoAn;
        }


        private void BtnSelectService_Click(object sender, EventArgs e)
        {
            // Kiểm tra số lượng còn lại
            int soLuongConLai = dichVuBUL.laySoLuongMon(maDoAn);

            // Kiểm tra số lượng đã thêm
            int soLuongDaThem = LaySoLuongDaThem?.Invoke(maDoAn) ?? 0;

            if (quantity + soLuongDaThem > soLuongConLai)
            {
                MessageBox.Show("Số lượng không đủ. Vui lòng chọn số lượng ít hơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi sự kiện ServiceSelected
            ServiceSelected?.Invoke(this, new ServiceSelectedEventArgs
            {
                MaDoAn = maDoAn,
                TenDoAn = lblServiceName.Text,
                SoLuong = quantity,
                DonGia = decimal.Parse(lblServicePrice.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("vi-VN"))
            });

            // Reset số lượng về 1
            ResetQuantity();
        }

        private void BtnIncreaseQuantity_Click(object sender, EventArgs e)
        {
            quantity++;
            lblQuantity.Text = quantity.ToString();
        }

        private void BtnDecreaseQuantity_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
            }
        }

        public void ResetQuantity()
        {
            quantity = 1;
            lblQuantity.Text = quantity.ToString();
        }
    }

    public class ServiceSelectedEventArgs : EventArgs
    {
        public string MaDoAn { get; set; }
        public string TenDoAn { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}