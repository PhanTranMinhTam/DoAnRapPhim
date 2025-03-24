//using BUL;
//using System;
//using System.Data;
//using System.Drawing;
//using System.Windows.Forms;

//namespace GUI
//{
//    public partial class frm_ChonMon : Form
//    {
//        private DichVuBUL dichVuBUL;

//        public frm_ChonMon()
//        {
//            InitializeComponent();
//            dichVuBUL = new DichVuBUL();
//            LoadServices();
//            //Ẩn cột mã đồ ăn
//            dgv_ThongTinDatMon.Columns["MaDoAn"].Visible = false;
//        }

//        private void LoadServices()
//        {
//            panel_Menu.Controls.Clear();
//            this.Controls.Add(panel_Menu);
//            DataTable dtServices = dichVuBUL.getDichVu();

//            int x = 10;
//            int y = 10;
//            int margin = 10;
//            int itemsPerRow = 3;
//            int currentItem = 0;

//            foreach (DataRow row in dtServices.Rows)
//            {
//                // Tạo `UserControl` cho từng sản phẩm
//                uc_ChonDichVu serviceControl = new uc_ChonDichVu();
//                serviceControl.SetServiceDetails(
//                    row["TenDoAn"].ToString(),
//                    Convert.ToDecimal(row["DonGia"]),
//                    row["HinhAnh"].ToString(),
//                    row["MaDoAn"].ToString()
//                );

//                // Đăng ký sự kiện ServiceSelected
//                serviceControl.ServiceSelected += ServiceControl_ServiceSelected;

//                // Đặt vị trí cho `UserControl` và thêm vào panel chứa
//                serviceControl.Location = new Point(x, y);
//                panel_Menu.Controls.Add(serviceControl);

//                // Tính toán vị trí của sản phẩm tiếp theo
//                currentItem++;
//                if (currentItem % itemsPerRow == 0)
//                {
//                    x = 10;
//                    y += serviceControl.Height + margin;
//                }
//                else
//                {
//                    x += serviceControl.Width + margin;
//                }
//            }
//        }

//        private void ServiceControl_ServiceSelected(object sender, ServiceSelectedEventArgs e)
//        {
//            bool itemExists = false;

//            // Kiểm tra xem mã đồ ăn đã tồn tại trong dgv_ThongTinDatMon hay chưa
//            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
//            {
//                if (row.Cells["MaDoAn"].Value.ToString() == e.MaDoAn)
//                {
//                    // Cập nhật số lượng và thành tiền
//                    int currentQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
//                    row.Cells["SoLuong"].Value = currentQuantity + e.SoLuong;
//                    row.Cells["ThanhTien"].Value = (currentQuantity + e.SoLuong) * e.DonGia;
//                    itemExists = true;
//                    break;
//                }
//            }

//            // Nếu mã đồ ăn chưa tồn tại, thêm dòng mới
//            if (!itemExists)
//            {
//                dgv_ThongTinDatMon.Rows.Add(e.MaDoAn, e.TenDoAn, e.SoLuong, e.DonGia, e.SoLuong * e.DonGia);
//            }

//            // Cập nhật lb_TongTien
//            UpdateTotalPrice();
//        }

//        private void UpdateTotalPrice()
//        {
//            decimal totalPrice = 0;
//            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
//            {
//                totalPrice += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
//            }
//            lb_TongTien.Text = totalPrice.ToString() + " VNĐ";
//        }

//        private void btn_Xoa_Click(object sender, EventArgs e)
//        {
//            // Xóa dòng được chọn, cho phép xóa nhiều dòng cùng lúc
//            if (dgv_ThongTinDatMon.SelectedRows.Count > 0)
//            {
//                foreach (DataGridViewRow row in dgv_ThongTinDatMon.SelectedRows)
//                {
//                    dgv_ThongTinDatMon.Rows.Remove(row);
//                }
//            }

//            // Cập nhật lại tổng tiền
//            UpdateTotalPrice();


//        }
//    }
//}




using BUL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ChonMon : Form
    {
        private DichVuBUL dichVuBUL;

        public frm_ChonMon()
        {
            InitializeComponent();
            dichVuBUL = new DichVuBUL();
            LoadServices();
            //Ẩn cột mã đồ ăn
            dgv_ThongTinDatMon.Columns["MaDoAn"].Visible = false;

            this.Resize += (s, e) => LoadServices();
        }

        private void LoadServices()
        {
            panel_Menu.Controls.Clear();
            DataTable dtServices = dichVuBUL.getDichVu();

            int margin = 10;
            int currentItem = 0;
            int controlWidth = 200;  // Chiều rộng của `uc_ChonDichVu`
            int controlHeight = 380; // Chiều cao của `uc_ChonDichVu`

            int itemsPerRow = Math.Max(1, panel_Menu.Width / (controlWidth + margin)); // Tính số lượng item trên mỗi dòng dựa trên chiều rộng của panel

            int x = margin;
            int y = margin;

            foreach (DataRow row in dtServices.Rows)
            {
                // Tạo `UserControl` cho từng dịch vụ
                uc_ChonDichVu serviceControl = new uc_ChonDichVu();
                serviceControl.SetServiceDetails(
                    row["TenDoAn"].ToString(),
                    Convert.ToDecimal(row["DonGia"]),
                    row["HinhAnh"].ToString(),
                    row["MaDoAn"].ToString()
                );

                // Đăng ký sự kiện ServiceSelected
                serviceControl.ServiceSelected += ServiceControl_ServiceSelected;

                // Đặt vị trí cho `UserControl` và thêm vào panel chứa
                serviceControl.Location = new Point(x, y);
                panel_Menu.Controls.Add(serviceControl);

                // Tính toán vị trí của sản phẩm tiếp theo
                currentItem++;
                if (currentItem % itemsPerRow == 0)
                {
                    x = margin;
                    y += controlHeight + margin;
                }
                else
                {
                    x += controlWidth + margin;
                }
            }
        }


        private void ServiceControl_ServiceSelected(object sender, ServiceSelectedEventArgs e)
        {
            bool itemExists = false;

            // Kiểm tra xem mã đồ ăn đã tồn tại trong dgv_ThongTinDatMon hay chưa
            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
            {
                if (row.Cells["MaDoAn"].Value.ToString() == e.MaDoAn)
                {
                    // Cập nhật số lượng và thành tiền
                    int currentQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = currentQuantity + e.SoLuong;
                    row.Cells["ThanhTien"].Value = (currentQuantity + e.SoLuong) * e.DonGia;
                    itemExists = true;
                    break;
                }
            }

            // Nếu mã đồ ăn chưa tồn tại, thêm dòng mới
            if (!itemExists)
            {
                dgv_ThongTinDatMon.Rows.Add(e.MaDoAn, e.TenDoAn, e.SoLuong, e.DonGia, e.SoLuong * e.DonGia);
            }

            // Cập nhật lb_TongTien
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
            {
                totalPrice += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
            }
            lb_TongTien.Text = totalPrice.ToString() + " VNĐ";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Xóa dòng được chọn, cho phép xóa nhiều dòng cùng lúc
            if (dgv_ThongTinDatMon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_ThongTinDatMon.SelectedRows)
                {
                    dgv_ThongTinDatMon.Rows.Remove(row);
                }
            }

            // Cập nhật lại tổng tiền
            UpdateTotalPrice();


        }
    }
}







