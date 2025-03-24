using BUL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frm_ThongKe : Form
    {
        private HoaDonBUL hoaDonBUL;
        private PhimBUL phimBUL;
        private LoaiPhimBUL loaiPhimBUL;
        private DoanhThuBUL doanhThuBUL;
        string hoTenNhanVien;
        public frm_ThongKe(string hoTenNhanVien)
        {
            InitializeComponent();
            QL_RAPPHIMDataContext context = new QL_RAPPHIMDataContext();
            doanhThuBUL = new DoanhThuBUL(context);
            hoaDonBUL = new HoaDonBUL();
            phimBUL = new PhimBUL();
            loaiPhimBUL = new LoaiPhimBUL();
            loadComboBoxPhim();
            loadComboBoxThang();
            loadComboBoxNam();
            loadComboBoxLoaiPhim();
            LoadChartData();
            this.hoTenNhanVien = hoTenNhanVien;
        }


        void loadComboBoxPhim()
        {
            DataTable dtPhim = phimBUL.LayTatCaPhim();

            // Thêm dòng "Tất cả" vào DataTable
            DataRow newRow = dtPhim.NewRow();
            newRow["TenPhim"] = "Tất cả";
            newRow["MaPhim"] = 0;
            dtPhim.Rows.InsertAt(newRow, 0);

            cbo_Phim.DataSource = dtPhim;
            cbo_Phim.DisplayMember = "TenPhim";
            cbo_Phim.ValueMember = "MaPhim";
            cbo_Phim.SelectedIndex = -1;
        }
        void loadComboBoxLoaiPhim()
        {
            DataTable dtLoaiPhim = loaiPhimBUL.LayTatCaLoaiPhim();

            // Thêm dòng "Tất cả" vào DataTable
            DataRow newRow = dtLoaiPhim.NewRow();
            newRow["TenLoai"] = "Không";
            newRow["MaLoai"] = 0;
            dtLoaiPhim.Rows.InsertAt(newRow, 0);

            cbo_LoaiPhim.DataSource = dtLoaiPhim;
            cbo_LoaiPhim.DisplayMember = "TenLoai";
            cbo_LoaiPhim.ValueMember = "MaLoai";
            cbo_LoaiPhim.SelectedIndex = -1;
        }
        void loadComboBoxThang()
        {
            cbo_Thang.Items.Clear();

            for (int i = 1; i <= 12; i++)
            {
                cbo_Thang.Items.Add(i.ToString());
            }

            cbo_Thang.SelectedIndex = -1;
        }
        void loadComboBoxNam()
        {
            cbo_Nam.Items.Clear();

            // Thêm các năm từ 2000 đến 2100 vào ComboBox
            for (int i = 2000; i <= 2100; i++)
            {
                cbo_Nam.Items.Add(i.ToString());
            }

            cbo_Nam.SelectedIndex = -1;
        }
        private void LoadHoaDon()
        {
            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDon();
        }

        //private void cbo_Phim_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string maPhimChon = cbo_Phim.SelectedValue?.ToString();

        //    // Kiểm tra xem mã phim có phải là "0" không (tương ứng với "Tất cả")
        //    if (maPhimChon == "0")
        //    {
        //        // Kiểm tra xem tháng và năm đã được chọn chưa
        //        if (cbo_Thang.SelectedIndex != -1 && cbo_Nam.SelectedIndex != -1)
        //        {
        //            // Nếu tháng và năm đã chọn, hiển thị Top 5 phim theo tháng và năm
        //            int thang = Convert.ToInt32(cbo_Thang.SelectedItem.ToString());
        //            int nam = Convert.ToInt32(cbo_Nam.SelectedItem.ToString());
        //            dgv_Top5.DataSource = hoaDonBUL.Top5PhimDoanhThuTheoThangNam(nam, thang);
        //        }
        //        else
        //        {
        //            // Nếu không chọn tháng và năm, hiển thị Top 5 phim toàn bộ
        //            dgv_Top5.DataSource = hoaDonBUL.Top5PhimDoanhThu();
        //        }

        //        // Hiển thị tổng doanh thu và hóa đơn toàn bộ hoặc theo tháng và năm
        //        if (cbo_Thang.SelectedIndex != -1 && cbo_Nam.SelectedIndex != -1)
        //        {
        //            int thang = Convert.ToInt32(cbo_Thang.SelectedItem.ToString());
        //            int nam = Convert.ToInt32(cbo_Nam.SelectedItem.ToString());
        //            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThang(thang, nam);
        //            decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoThang(thang, nam);
        //            lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
        //        }
        //        else
        //        {
        //            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDon();
        //            decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThu();
        //            lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
        //        }

        //        // Cập nhật tổng số vé khi chọn "Tất cả"
        //        int tongVe = hoaDonBUL.LayTongSoVe();
        //        lbl_SoVe.Text = "Tổng số vé: " + tongVe.ToString();
        //    }
        //    else if (!string.IsNullOrEmpty(maPhimChon))
        //    {
        //        // Nếu đã chọn phim, lọc hóa đơn theo mã phim
        //        if (cbo_Thang.SelectedIndex != -1 && cbo_Nam.SelectedIndex != -1)
        //        {
        //            // Nếu tháng và năm đã chọn, lọc theo phim, tháng và năm
        //            int thang = Convert.ToInt32(cbo_Thang.SelectedItem.ToString());
        //            int nam = Convert.ToInt32(cbo_Nam.SelectedItem.ToString());
        //            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoTenPhimVaThangNam(maPhimChon, thang, nam);

        //            // Tính tổng doanh thu theo phim, tháng và năm
        //            decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoTenPhimVaThangNam(maPhimChon, thang, nam);
        //            lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
        //        }
        //        else
        //        {
        //            // Nếu chưa chọn tháng và năm, hiển thị hóa đơn theo mã phim
        //            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoTenPhim(maPhimChon);

        //            // Tính tổng doanh thu theo mã phim
        //            decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoTenPhim(maPhimChon);
        //            lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
        //        }

        //        // Cập nhật tổng số vé cho phim đã chọn
        //        int tongSoVe = hoaDonBUL.LayTongSoVeTheoPhim(maPhimChon);
        //        lbl_SoVe.Text = "Số vé đã bán: " + tongSoVe.ToString();
        //    }
        //}

        //private void cbo_Thang_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string maPhimChon = cbo_Phim.SelectedValue?.ToString();

        //    // Kiểm tra xem tháng và năm có được chọn chưa
        //    if (cbo_Thang.SelectedIndex != -1 && cbo_Nam.SelectedIndex != -1)
        //    {
        //        int thang = Convert.ToInt32(cbo_Thang.SelectedItem.ToString());
        //        int nam = Convert.ToInt32(cbo_Nam.SelectedItem.ToString());

        //        // Kiểm tra nếu chọn "Tất cả" phim
        //        if (maPhimChon == "0")
        //        {
        //            // Hiển thị danh sách hóa đơn theo tháng
        //            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThang(thang, nam);
        //            decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoThang(thang, nam);
        //            lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
        //            //dgv_Top5.DataSource = hoaDonBUL.Top5PhimDoanhThu(nam, thang);
        //        }
        //        else if (!string.IsNullOrEmpty(maPhimChon))
        //        {
        //            // Nếu đã chọn phim, lọc theo phim, tháng và năm
        //            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoTenPhimVaThangNam(maPhimChon, thang, nam);
        //            decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoTenPhimVaThangNam(maPhimChon, thang, nam);
        //            lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
        //            if (maPhimChon == "0")
        //            {
        //                dgv_Top5.DataSource = hoaDonBUL.Top5PhimDoanhThuTheoThangNam(nam, thang);
        //            }
        //        }
        //    }
        //}


        //private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string maPhimChon = cbo_Phim.SelectedValue?.ToString();

        //    // Kiểm tra xem tháng và năm có được chọn chưa
        //    if (cbo_Thang.SelectedIndex != -1 && cbo_Nam.SelectedIndex != -1)
        //    {
        //        int thang = Convert.ToInt32(cbo_Thang.SelectedItem.ToString());
        //        int nam = Convert.ToInt32(cbo_Nam.SelectedItem.ToString());

        //        // Gọi LoadChartData để cập nhật biểu đồ
        //        LoadChartData();

        //        // Kiểm tra nếu chọn "Tất cả" phim
        //        if (maPhimChon == "0")
        //        {
        //            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThang(thang, nam);
        //            decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoThang(thang, nam);
        //            lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
        //            //dgv_Top5.DataSource = hoaDonBUL.Top5PhimDoanhThu(nam, thang);
        //        }
        //        else if (!string.IsNullOrEmpty(maPhimChon))
        //        {
        //            // Nếu đã chọn phim, lọc theo phim, tháng và năm
        //            dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoTenPhimVaThangNam(maPhimChon, thang, nam);
        //            decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoTenPhimVaThangNam(maPhimChon, thang, nam);
        //            lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
        //            if (maPhimChon == "0")
        //            {
        //                dgv_Top5.DataSource = hoaDonBUL.Top5PhimDoanhThuTheoThangNam(nam, thang);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        // Chỉ cần load biểu đồ khi chọn năm, nếu chưa chọn tháng thì không hiển thị dữ liệu chi tiết
        //        LoadChartData();
        //    }
        //}

        private void cbo_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKeVaTop5();
        }

        private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKeVaTop5();
        }

        private void cbo_Phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKeVaTop5();
        }

        private void CapNhatThongKeVaTop5()
        {
            string maPhimChon = cbo_Phim.SelectedValue?.ToString();

            // Kiểm tra xem mã phim có phải là "0" không (tương ứng với "Tất cả")
            if (maPhimChon == "0")
            {
                // Kiểm tra xem tháng và năm đã được chọn chưa
                if (cbo_Thang.SelectedIndex != -1 && cbo_Nam.SelectedIndex != -1)
                {
                    int thang = Convert.ToInt32(cbo_Thang.SelectedItem.ToString());
                    int nam = Convert.ToInt32(cbo_Nam.SelectedItem.ToString());

                    // Hiển thị Top 5 phim theo tháng và năm
                    dgv_Top5.DataSource = hoaDonBUL.Top5PhimDoanhThuTheoThangNam(nam, thang);

                    // Hiển thị danh sách hóa đơn và tổng doanh thu theo tháng và năm
                    dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThang(thang, nam);
                    decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoThang(thang, nam);
                    lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
                    LoadChartData();
                }
                else
                {
                    // Hiển thị Top 5 phim toàn bộ
                    dgv_Top5.DataSource = hoaDonBUL.Top5PhimDoanhThu();

                    // Hiển thị danh sách hóa đơn và tổng doanh thu toàn bộ
                    dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDon();
                    decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThu();
                    lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
                }

                // Cập nhật tổng số vé khi chọn "Tất cả"
                int tongVe = hoaDonBUL.LayTongSoVe();
                lbl_SoVe.Text = "Tổng số vé: " + tongVe.ToString();
            }
            else if (!string.IsNullOrEmpty(maPhimChon))
            {
                // Nếu đã chọn phim, lọc hóa đơn theo mã phim
                if (cbo_Thang.SelectedIndex != -1 && cbo_Nam.SelectedIndex != -1)
                {
                    int thang = Convert.ToInt32(cbo_Thang.SelectedItem.ToString());
                    int nam = Convert.ToInt32(cbo_Nam.SelectedItem.ToString());

                    // Hiển thị danh sách hóa đơn và tổng doanh thu theo phim, tháng và năm
                    dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoTenPhimVaThangNam(maPhimChon, thang, nam);
                    decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoTenPhimVaThangNam(maPhimChon, thang, nam);
                    lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
                }
                else
                {
                    // Hiển thị danh sách hóa đơn và tổng doanh thu theo mã phim
                    dgv_ThongKe.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoTenPhim(maPhimChon);
                    decimal tongDoanhThu = hoaDonBUL.TinhTongDoanhThuTheoTenPhim(maPhimChon);
                    lbl_TongDoanhThu.Text = string.Format("Tổng doanh thu: {0} VND", tongDoanhThu.ToString("N0"));
                }

                // Cập nhật tổng số vé cho phim đã chọn
                int tongSoVe = hoaDonBUL.LayTongSoVeTheoPhim(maPhimChon);
                lbl_SoVe.Text = "Số vé đã bán: " + tongSoVe.ToString();
            }
        }

        private void cbo_LoaiPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoaiPhim = cbo_LoaiPhim.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maLoaiPhim))
            {
                // Lấy dữ liệu từ BUL
                DataTable dt = hoaDonBUL.DoanhThuTheoLoaiPhim(maLoaiPhim);

                // Tính tổng số vé bán ra và tổng doanh thu
                int soLuongVe = 0;
                decimal tongDoanhThu = 0;

                foreach (DataRow row in dt.Rows)
                {
                    soLuongVe += Convert.ToInt32(row["SoLuongVeBanRa"]);
                    tongDoanhThu += Convert.ToDecimal(row["TongDoanhThu"]);
                }

                // Hiển thị thông tin lên label
                lbl_SoVe.Text = $"Số vé bán ra: {soLuongVe}";
                lbl_TongDoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:N0} VND";
            }
            else
            {
                // Nếu không chọn loại phim hợp lệ, xóa thông tin hiển thị
                lbl_SoVe.Text = "Số vé bán ra: 0";
                lbl_TongDoanhThu.Text = "Tổng doanh thu: 0 VND";
            }
        }

        private void LoadChartData()
        {
            int nam = Convert.ToInt32(cbo_Nam.SelectedItem);
            DataTable dt = hoaDonBUL.LayTongDoanhThuTheoThang(nam);

            chartDoanhThu.Series.Clear();
            Series series = new Series
            {
                Name = "Doanh Thu",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.Int32
            };
            chartDoanhThu.Series.Add(series);

            // Đảm bảo chỉ có tối đa 12 cột (ứng với 12 tháng)
            foreach (DataRow row in dt.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                if (thang >= 1 && thang <= 12)
                {
                    decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);
                    series.Points.AddXY(thang, doanhThu);
                }
            }

            // Điều chỉnh sơ đồ bên trong mà không thay đổi kích thước Chart
            chartDoanhThu.ChartAreas[0].InnerPlotPosition.Width = 100;
            chartDoanhThu.ChartAreas[0].InnerPlotPosition.Height = 85;
            chartDoanhThu.ChartAreas[0].InnerPlotPosition.X = 20;
            chartDoanhThu.ChartAreas[0].InnerPlotPosition.Y = 5;

            chartDoanhThu.ChartAreas[0].AxisX.Minimum = 0;
            chartDoanhThu.ChartAreas[0].AxisX.Maximum = 13;
            chartDoanhThu.ChartAreas[0].AxisX.Interval = 0;

            chartDoanhThu.ChartAreas[0].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh Thu (VND)";
            chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}";

            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add(string.Format("Doanh Thu Năm {0}", nam));
        }

        //private void btn_Xuat_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Lấy tháng và năm từ TextBox
        //        int month = Convert.ToInt32(cbo_Thang.SelectedItem);
        //        int year = Convert.ToInt32(cbo_Nam.SelectedItem);

        //        // Kiểm tra tháng và năm hợp lệ
        //        if (month < 1 || month > 12)
        //        {
        //            MessageBox.Show("Tháng phải nằm trong khoảng từ 1 đến 12.");
        //            return;
        //        }

        //        if (year <= 0)
        //        {
        //            MessageBox.Show("Năm không hợp lệ.");
        //            return;
        //        }

        //        // Lấy dữ liệu doanh thu
        //        List<DoanhThuDTO> doanhThuList = doanhThuBUL.GetDoanhThuByMonth(month, year);
        //        if (doanhThuList == null || doanhThuList.Count == 0)
        //        {
        //            MessageBox.Show("Không có dữ liệu cho tháng và năm này.");
        //            return;
        //        }

        //        // Xuất dữ liệu ra Excel
        //        string fileName = string.Empty;
        //        bool isPrintPreview = false;  // Set true nếu bạn muốn hiển thị bản xem trước

        //        // Giả sử bạn có một lớp ExcelExport để xuất dữ liệu
        //        ExcelExport excelExport = new ExcelExport(new QL_RAPPHIMDataContext());
        //        excelExport.ExportDoanhThu(doanhThuList, ref fileName, isPrintPreview);

        //        // Hiển thị thông báo thành công
        //        MessageBox.Show("Dữ liệu đã được xuất thành công!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
        //    }
        //}


        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tháng và năm từ ComboBox
                int month = Convert.ToInt32(cbo_Thang.SelectedItem);
                int year = Convert.ToInt32(cbo_Nam.SelectedItem);

                // Kiểm tra tháng và năm hợp lệ
                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Tháng phải nằm trong khoảng từ 1 đến 12.");
                    return;
                }

                if (year <= 0)
                {
                    MessageBox.Show("Năm không hợp lệ.");
                    return;
                }

                // Lấy dữ liệu doanh thu
                List<DoanhThuDTO> doanhThuList = doanhThuBUL.GetDoanhThuByMonth(month, year);
                if (doanhThuList == null || doanhThuList.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho tháng và năm này.");
                    return;
                }

                // Xuất dữ liệu ra Excel
                string fileName = string.Empty;
                bool isPrintPreview = false; // Set true nếu bạn muốn hiển thị bản xem trước

                // Gọi phương thức ExportDoanhThu và truyền thêm tên nhân viên
                ExcelExport excelExport = new ExcelExport(new QL_RAPPHIMDataContext());
                excelExport.ExportDoanhThu(doanhThuList, ref fileName, isPrintPreview, hoTenNhanVien);

                // Hiển thị thông báo thành công
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }



        //// Phương thức chuyển đổi DataTable thành List<DoanhThuDTO>
        //private List<DoanhThuDTO> ConvertDataTableToDoanhThuDTOList(DataTable dataTable)
        //{
        //    int stt = 1;
        //    List<DoanhThuDTO> doanhThuList = new List<DoanhThuDTO>();

        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        //doanhThuList.Add(new DoanhThuDTO 
        //        //{
        //        //    STT = stt++,
        //        //    MaHD = row["MaHD"].ToString(),
        //        //    NgayBan = row["NgayBan"] != DBNull.Value ? (DateTime?)row["NgayBan"] : null,
        //        //    TongTien = Convert.ToDecimal(row["TongTien"]),
        //        //    MaKM = row["MaKhuyenMai"]?.ToString(),
        //        //    TongDoanhThu = Convert.ToDecimal(row["TongDoanhThu"]),
        //        //    TenNV = row["tenNhanVien"]?.ToString()
        //        //});
        //    }

        //    return doanhThuList;
        //}

    }
}
