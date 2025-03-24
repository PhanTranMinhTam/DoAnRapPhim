using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QRCode : Form
    {
        public frm_QRCode(Image qrImage, string soTien)
        {
            InitializeComponent();
            pictureBox_QR.Image = qrImage;
            // Chuyển đổi chuỗi số tiền sang decimal sau khi đã xử lý
            if (decimal.TryParse(soTien, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal soTienDecimal))
            {
                lb_SoTien.Text = string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:#,##0} VNĐ", soTienDecimal);
            }
            else
            {
                MessageBox.Show("Lỗi: Giá trị 'Tổng cộng' không hợp lệ.");
                lb_SoTien.Text = "N/A";
            }
        }
    }
}
