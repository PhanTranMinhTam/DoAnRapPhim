using BUL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Utilities;
using VietQRHelper;
namespace GUI
{

    public partial class frm_QLBanVe : Form
    {
        //private FlowLayoutPanel flpMovies;
        private PhimBUL phimBUL;
        private DateTimePicker dtp_PhimTheoNgay;
        private DichVuBUL dichVuBUL;
        private CTDoAnBUL cTDoAnBUL;
        private KhachHangBUL khachHangBUL;
        private HoaDonBUL hoaDonBUL;
        private KhuyenMaiBUL khuyenMaiBUL;
        private NhanVienBUL nhanVienBUL;
        private DuDoanBUL duDoanBUL;
        private PhongChieuBUL phongChieuBUL;
        private GheBUL gheBUL;
        private CTVeBUL cTVeBUL;
        private LichChieuBUL lichChieuBUL;
        private string maPhim;
        private Button selectedButton; // Store the currently selected button (seat)
        public event EventHandler<string> SeatSelected;
        private List<string> danhSachGheDaDat = new List<string>();
        private List<CTDoAnDTO> danhSachMonAnDaChon = new List<CTDoAnDTO>();
        private List<string> danhSachTenGheDaChon = new List<string>();
        string GheDaDat;
        string maKH;
        string username;
        string maNhanVien;
        decimal? phanTramKM;


        private enum PaymentType
        {
            TicketsOnly,
            FoodOnly,
            Both
        }

        private PaymentType currentPaymentType;

        public frm_QLBanVe(string username, string maNhanVien)
        {
            InitializeComponent();
            //InitializeMoviePanel();
            //InitializeDatePicker();
            duDoanBUL = new DuDoanBUL();
            phimBUL = new PhimBUL();
            dichVuBUL = new DichVuBUL();
            cTDoAnBUL = new CTDoAnBUL();
            khachHangBUL = new KhachHangBUL();
            hoaDonBUL = new HoaDonBUL();
            khuyenMaiBUL = new KhuyenMaiBUL();
            nhanVienBUL = new NhanVienBUL();
            LoadMovies();
            LoadLoaiPhim();
            LoadServices();
            //Ẩn cột mã đồ ăn
            dgv_ThongTinDatMon.Columns["MaDoAn"].Visible = false;

            this.Resize += (s, e) => LoadServices();

            phongChieuBUL = new PhongChieuBUL();
            gheBUL = new GheBUL();
            cTVeBUL = new CTVeBUL();
            lichChieuBUL = new LichChieuBUL();
            //uc_Ghe uc_GheControl = new uc_Ghe();

            // Subscribe to the SeatClicked event
            uc_Ghe1.SeatClicked += Uc_Ghe_SeatClicked;
            uc_Ghe1.TotalPriceChanged += UpdateTotalPrice;

            // Add the control to the form (or panel)
            panel_ManHinhGhe.Controls.Add(uc_Ghe1);

            //LoadPhongChieu();


            this.username = username;

            txt_TenNV.Text = nhanVienBUL.layTenNhanVienTheoUsername(username);
            this.maNhanVien = maNhanVien;

            cbo_ChonKhuyenMai.SelectedIndex = -1;

            dtp_NgayLap.Value = DateTime.Now;
            btn_InVe.Enabled = false;
            InHoaDonMonAn.Enabled = false;

        }

        #region setuptab
        public void setCurrentTab(int index)
        {
            switch (tab_QLDatVe.SelectedIndex)
            {
                case 0:
                    indicator.Left = btn_ChonPhim.Right - btn_ChonPhim.Width;
                    break;
                case 1:
                    indicator.Left = btn_ChonGhe.Right - btn_ChonGhe.Width;
                    break;
                case 2:
                    indicator.Left = btn_ChonMon.Right - btn_ChonMon.Width;
                    break;
                case 3:
                    indicator.Left = btn_ThanhToan.Right - btn_ThanhToan.Width;
                    break;
            }
        }

        private void tab_QLDatVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCurrentTab(tab_QLDatVe.SelectedIndex);
        }

        private void btn_ChonPhim_Click(object sender, EventArgs e)
        {
            tab_QLDatVe.SetPage(0);
        }

        private void btn_ChonGhe_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem đã chọn phim chưa, nếu chưa thì thông báo và không cho chuyển tab
            if (string.IsNullOrEmpty(maPhim))
            {
                MessageBox.Show("Vui lòng chọn phim trước khi chọn ghế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tab_QLDatVe.SetPage(1);

        }

        private void btn_ChonMon_Click(object sender, EventArgs e)
        {
            tab_QLDatVe.SetPage(2);
            currentPaymentType = PaymentType.FoodOnly;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            tab_QLDatVe.SetPage(3);
            loadPanelVeXemPhim();
            loadComboboxKhuyenMai();
            cb_IsNonMember.Checked = true;
            btn_ThemKhachHang.Visible = false;
        }

        #endregion setuptab

        #region ChonPhim

        //private void InitializeMoviePanel()
        //{
        //    flpMovies = new FlowLayoutPanel
        //    {
        //        //Dock = DockStyle.Fill,
        //        Size = new System.Drawing.Size(1300, 900),
        //        Location = new System.Drawing.Point(0, 68),
        //        AutoScroll = true,
        //        FlowDirection = FlowDirection.LeftToRight,
        //    };
        //    this.Controls.Add(flpMovies);
        //}
        private void InitializeDatePicker()
        {
            dtp_PhimTheoNgay = new DateTimePicker
            {
                Location = new System.Drawing.Point(10, 10),
                Format = DateTimePickerFormat.Short
            };
            dtp_PhimNgay.ValueChanged += new EventHandler(dtp_PhimNgay_ValueChanged);
            this.Controls.Add(dtp_PhimNgay);
        }
        private void LoadMovies()
        {
            List<PhimDTO> movies = phimBUL.getPhim();
            foreach (PhimDTO movie in movies)
            {
                uc_ChonPhim movieControl = new uc_ChonPhim();
                movieControl.SetMovieInfo(movie);
                movieControl.MovieSelected += MovieControl_MovieSelected;
                flowLayoutPanel1.Controls.Add(movieControl);
            }
        }

        private void MovieControl_MovieSelected(object sender, string maPhimChon)
        {
            tab_QLDatVe.SetPage(1);
            maPhim = maPhimChon;
            loadThongTinPhim();
            cbo_SuatChieu.DataSource = lichChieuBUL.layLichChieuTheoMaPhim(maPhim);
            cbo_SuatChieu.DisplayMember = "DisplayText"; // Use the custom property for display
            cbo_SuatChieu.ValueMember = "MaLichChieuAgg"; // Use the aggregated schedule IDs as the value
            cbo_SuatChieu.SelectedIndex = -1;
        }


        private void LoadMoviesByLoaiPhim()
        {
            string selectedTypeId = cbo_loaiPhim.SelectedValue.ToString(); // Lấy giá trị MaLoai đã chọn

            // Lấy danh sách phim và lọc theo loại phim
            List<PhimDTO> movies;

            if (selectedTypeId == "0") // Nếu "Tất cả loại phim" được chọn
            {
                movies = phimBUL.getPhim(); // Lấy tất cả phim
            }
            else
            {
                movies = phimBUL.getPhimByLoai(selectedTypeId);
            }

            // Xóa các điều khiển phim hiện tại trước khi thêm mới
            flowLayoutPanel1.Controls.Clear();

            // Thêm từng phim vào flpMovies
            foreach (PhimDTO movie in movies)
            {
                uc_ChonPhim movieControl = new uc_ChonPhim();
                movieControl.SetMovieInfo(movie);
                flowLayoutPanel1.Controls.Add(movieControl);
            }
        }

        private void dtp_PhimNgay_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtp_PhimNgay.Value.Date; // Lấy ngày từ DateTimePicker (chỉ phần ngày, không lấy giờ)
            List<PhimDTO> movies = phimBUL.getPhim(); // Lấy danh sách phim gốc

            // Lọc danh sách phim theo ngày phát hành
            List<PhimDTO> filteredMovies = movies.Where(movie => movie.NgayChieu.Date == selectedDate).ToList();

            // Xóa các phim hiện tại trong giao diện
            //this.Controls.Clear();

            // Thêm các phim đã lọc vào giao diện
            foreach (PhimDTO movie in filteredMovies)
            {
                uc_ChonPhim movieControl = new uc_ChonPhim();
                movieControl.SetMovieInfo(movie);
                flowLayoutPanel1.Controls.Add(movieControl);
            }
        }
        private void LoadLoaiPhim()
        {
            List<PhimDTO> loaiPhimList = phimBUL.getLoaiPhim();

            // Tạo một đối tượng PhimDTO để đại diện cho tùy chọn "Tất cả"
            PhimDTO allMoviesOption = new PhimDTO
            {
                MaLoaiPhim = "ALL", // Có thể đặt mã tùy chọn này tùy ý
                TenLoaiPhim = "Tất cả" // Tên hiển thị cho tùy chọn "Tất cả"
            };

            // Thêm tùy chọn "Tất cả" vào danh sách
            loaiPhimList.Insert(0, allMoviesOption); // Thêm vào đầu danh sách

            // Gán danh sách loại phim vào ComboBox
            cbo_loaiPhim.DataSource = loaiPhimList;
            cbo_loaiPhim.DisplayMember = "TenLoaiPhim";
            cbo_loaiPhim.ValueMember = "MaLoaiPhim";
        }


        private void txt_TimKiem_TextChange(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.ToLower();
            List<PhimDTO> movies = phimBUL.getPhim();

            // Lọc danh sách phim theo từ khóa
            List<PhimDTO> filteredMovies = movies.Where(movie =>
                movie.TenPhim.ToLower().Contains(keyword)).ToList();

            // Xóa các phim hiện tại trong giao diện
            flowLayoutPanel1.Controls.Clear();

            // Thêm phim đã lọc vào giao diện
            foreach (PhimDTO movie in filteredMovies)
            {
                uc_ChonPhim movieControl = new uc_ChonPhim();
                movieControl.SetMovieInfo(movie);
                flowLayoutPanel1.Controls.Add(movieControl);
            }
        }

        private void cbo_loaiPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra giá trị đã chọn
            string selectedValue = cbo_loaiPhim.SelectedValue?.ToString();

            if (selectedValue == "ALL")
            {
                // Nếu chọn "Tất cả", tải tất cả phim
                LoadMovies();
            }
            else
            {
                // Nếu chọn loại phim cụ thể, gọi phương thức để lọc theo loại đó
                LoadMoviesByLoaiPhim();
            }
        }

        #endregion ChonPhim

        #region ChonMon
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
                serviceControl.LaySoLuongDaThem += ServiceControl_LaySoLuongDaThem;

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

        private int ServiceControl_LaySoLuongDaThem(string maDoAn)
        {
            int quantity = 0;
            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
            {
                if (row.Cells["MaDoAn"].Value.ToString() == maDoAn)
                {
                    quantity += Convert.ToInt32(row.Cells["SoLuong"].Value);
                }
            }
            return quantity;
        }


        private void ServiceControl_ServiceSelected(object sender, ServiceSelectedEventArgs e)
        {
            // Kiểm tra số lượng còn lại
            int soLuongConLai = dichVuBUL.laySoLuongMon(e.MaDoAn);

            // Kiểm tra số lượng đã thêm
            int soLuongDaThem = ServiceControl_LaySoLuongDaThem(e.MaDoAn);

            if (e.SoLuong + soLuongDaThem > soLuongConLai)
            {
                MessageBox.Show("Số lượng không đủ. Vui lòng chọn số lượng ít hơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool itemExists = false;

            // Kiểm tra xem mã đồ ăn đã tồn tại trong dgv_ThongTinDatMon hay chưa
            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
            {
                if (row.Cells["MaDoAn"].Value.ToString() == e.MaDoAn)
                {
                    // Cập nhật số lượng và thành tiền
                    int currentQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = currentQuantity + e.SoLuong;
                    row.Cells["ThanhTien"].Value = ((currentQuantity + e.SoLuong) * e.DonGia).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
                    itemExists = true;
                    break;
                }
            }

            // Nếu mã đồ ăn chưa tồn tại, thêm dòng mới
            if (!itemExists)
            {
                dgv_ThongTinDatMon.Rows.Add(e.MaDoAn, e.TenDoAn, e.SoLuong, e.DonGia.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN")), (e.SoLuong * e.DonGia).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN")));
            }

            //Update danh sách món đã chọn
            UpdateDanhSachMonAnDaChon();

            // Cập nhật lb_TongTien
            UpdateTotalPrice();
        }

        private void UpdateDanhSachMonAnDaChon()
        {
            danhSachMonAnDaChon.Clear(); // Xóa danh sách cũ

            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
            {
                if (row.Cells["MaDoAn"].Value != null)
                {
                    CTDoAnDTO selectedService = new CTDoAnDTO
                    {
                        MaDoAn = row.Cells["MaDoAn"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        ThanhTien = decimal.Parse(row.Cells["ThanhTien"].Value.ToString(), NumberStyles.Currency, CultureInfo.CreateSpecificCulture("vi-VN"))
                    };

                    danhSachMonAnDaChon.Add(selectedService);
                }
            }
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
            {
                totalPrice += decimal.Parse(row.Cells["ThanhTien"].Value.ToString(), NumberStyles.Currency, CultureInfo.CreateSpecificCulture("vi-VN"));
            }
            lb_TongTien.Text = totalPrice.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
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

            // Cập nhật lại danh sách món ăn đã chọn
            UpdateDanhSachMonAnDaChon();

            // Cập nhật lại tổng tiền
            UpdateTotalPrice();
        }

        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
            tab_QLDatVe.SetPage(3);
            loadPanelVeXemPhim();
            cb_IsNonMember.Checked = true;
            btn_ThemKhachHang.Visible = false;
        }

        #endregion ChonMon

        #region ChonGhe
        //UC_ChonGhe
        private void Uc_Ghe_SeatClicked(string seatInfo)
        {
            // Giả sử mã ghế là phần thứ ba sau dấu cách
            string maGhe = seatInfo.Split(' ')[2];
            string tenGhe = seatInfo.Split(' ')[5];
            // Kiểm tra nếu mã ghế đã có trong danh sách ghế đã đặt
            if (danhSachGheDaDat.Contains(maGhe))
            {
                // Nếu có, thì bỏ chọn và xóa mã ghế khỏi danh sách
                danhSachGheDaDat.Remove(maGhe);
                danhSachTenGheDaChon.Remove(tenGhe);
                //MessageBox.Show("Bỏ chọn ghế: " + maGhe);
            }
            else
            {
                // Nếu chưa có, thì thêm vào danh sách
                danhSachGheDaDat.Add(maGhe);
                danhSachTenGheDaChon.Add(tenGhe);
                //MessageBox.Show("Chọn ghế: " + maGhe);
            }
        }
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button seatButton = sender as Button;
            if (seatButton != null)
            {
                string maGhe = seatButton.Tag?.ToString(); // Lấy mã ghế từ Tag của nút
                SeatSelected?.Invoke(this, maGhe); // Kích hoạt sự kiện với mã ghế
            }

        }
        private void Uc_Ghe_SeatSelected(object sender, string maGhe)
        {
            selectedButton = (sender as UserControl)?.Controls[maGhe] as Button; // Chọn nút ghế
            if (!string.IsNullOrEmpty(maGhe))
            {
                selectedButton.Tag = maGhe; // Gán mã ghế để dùng trong `btn_Dat_Click`
            }
        }
        public void loadThongTinPhim()
        {
            PhimDTO phim = phimBUL.getPhimByMaPhim(maPhim);
            lbTenPhim.Text = phim.TenPhim;
            pic_HinhPhim.ImageLocation = phim.HinhAnh;
            dt_NgayChieu.Value = DateTime.Now;
            lb_GioChieu.Text = "";
        }

        private void ShowSeatInfo(string seatDetails)
        {
            // Tách maGhe ra khỏi chuỗi seatDetails
            string[] seatInfoParts = seatDetails.Split(new[] { " - " }, StringSplitOptions.None);
            string maGhe = seatInfoParts[0].Replace("Mã ghế ", "");

            // Tạo chuỗi seatInfoWithoutMaGhe để tìm và xóa dòng tương ứng
            string seatInfoWithoutMaGhe = string.Join(" - ", seatInfoParts, 1, seatInfoParts.Length - 1);

            // Kiểm tra nếu ghế đã có trong lb_Ghe
            if (lb_Ghe.Text.Contains(seatInfoWithoutMaGhe))
            {
                // Nếu có, bỏ ghế ra khỏi lb_Ghe và cập nhật lại
                lb_Ghe.Text = lb_Ghe.Text.Replace(seatInfoWithoutMaGhe + Environment.NewLine, "").Replace(seatInfoWithoutMaGhe, "");
                lb_Ghe.Text = string.Join(Environment.NewLine, lb_Ghe.Text
                    .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));

            }
            else
            {
                // Nếu lb_Ghe không rỗng, thêm dòng mới
                if (!string.IsNullOrEmpty(lb_Ghe.Text))
                {
                    lb_Ghe.Text += Environment.NewLine; // Dòng mới
                }

                // Thêm chi tiết ghế mà không bao gồm Mã ghế
                lb_Ghe.Text += seatInfoWithoutMaGhe;
            }

            // Cập nhật lại GheDaDat với maGhe
            GheDaDat = maGhe;
        }
        private void UpdateTotalPrice(decimal totalPrice)
        {
            lb_TongTienGhe.Text = totalPrice.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
        }

        public List<GheDTO> ConvertDataTableToGheDTOList(DataTable dt)
        {
            List<GheDTO> seats = new List<GheDTO>();

            foreach (DataRow row in dt.Rows)
            {
                GheDTO seat = new GheDTO
                {
                    maGhe = row["MaGhe"].ToString(),
                    maPhongChieu = row["MaPhongChieu"].ToString(),
                    cot = Convert.ToInt32(row["Cots"]),
                    hang = row["Hang"].ToString(),
                    loaiGhe = row["LoaiGhe"].ToString(),
                    trangThai = Convert.ToInt32(row["TrangThai"]),
                    Gia = Convert.ToDecimal(row["Gia"])
                };
                seats.Add(seat);
            }
            return seats;
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            // Xóa danh sách ghế đã chọn
            danhSachGheDaDat.Clear();
            danhSachTenGheDaChon.Clear(); // Xóa danh sách tên ghế đã chọn

            // Xóa nội dung của label hiển thị ghế đã chọn
            lb_Ghe.Text = "";

            // Reset tổng giá
            uc_Ghe1.ResetTotalPrice();

            PhongChieuDTO selectedPhongChieu = (PhongChieuDTO)cbo_PhongChieu.SelectedItem;

            if (selectedPhongChieu != null)
            {
                DataTable dtSeats = gheBUL.LayTatCaGheTheoPhongChieu(selectedPhongChieu.MaPhongChieu);

                if (dtSeats.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy ghế cho phòng chiếu đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<GheDTO> seats = ConvertDataTableToGheDTOList(dtSeats);

                uc_Ghe gheControl = panel_ManHinhGhe.Controls.OfType<uc_Ghe>().FirstOrDefault();
                if (gheControl != null)
                {
                    //// Hủy đăng ký các sự kiện cũ để tránh đăng ký nhiều lần
                    gheControl.SeatClicked -= ShowSeatInfo;
                    gheControl.TotalPriceChanged -= UpdateTotalPrice;

                    gheControl.SeatClicked += ShowSeatInfo;
                    gheControl.TotalPriceChanged += UpdateTotalPrice;
                    gheControl.LoadSeats(seats);
                }
                else
                {
                    MessageBox.Show("Không thể nạp ghế từ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadBookedSeats();
        }

        private void btn_Dat_Click(object sender, EventArgs e)
        {
            tab_QLDatVe.SetPage(3);
            loadPanelVeXemPhim();
            cb_IsNonMember.Checked = true;
            btn_ThemKhachHang.Visible = false;
            currentPaymentType = PaymentType.TicketsOnly;
        }

        private void LoadBookedSeats()
        {
            if (cbo_SuatChieu.SelectedIndex == -1 || cbo_PhongChieu.SelectedIndex == -1)
            {
                return;
            }

            // Lấy thông tin lịch chiếu từ combobox
            LichChieuDTO selectedLichChieu = (LichChieuDTO)cbo_SuatChieu.SelectedItem;
            string maPhongChieu = cbo_PhongChieu.SelectedValue?.ToString();

            // Lấy mã lịch chiếu tương ứng với phòng chiếu đã chọn
            if (selectedLichChieu.PhongChieuToMaLichChieu.TryGetValue(maPhongChieu, out string maLichChieu))
            {
                List<string> danhSachGheDaDatDB = cTVeBUL.LayDanhSachGheDaDat(maLichChieu);

                foreach (string maGhe in danhSachGheDaDatDB)
                {
                    Button btnGhe = FindButtonForSeat(maGhe);
                    if (btnGhe != null)
                    {
                        btnGhe.BackColor = Color.Green; // Màu xanh cho ghế đã đặt
                        btnGhe.Enabled = false;         // Khóa nút để không thể chọn lại
                    }
                }
            }
            else
            {
                // Xử lý trường hợp không tìm thấy mã lịch chiếu tương ứng
                MessageBox.Show("Không tìm thấy mã lịch chiếu tương ứng với phòng chiếu đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private Button FindButtonForSeat(string maGhe)
        {
            // Tìm button theo tên mã ghế (không cần thêm tiền tố "btn")
            return this.Controls.Find(maGhe, true).FirstOrDefault() as Button;
        }

        #endregion ChonGhe

        #region ThanhToan

        public void loadPanelVeXemPhim()
        {
            lb_TenPhimChon.Text = lbTenPhim.Text;
            lb_NgayChieuVe.Text = dt_NgayChieu.Value.ToString("dd/MM/yyyy");
            lb_PhongChieuVe.Text = cbo_PhongChieu.Text;

            int ghePerLine = 3;
            List<string> formattedGheList = new List<string>();
            for (int i = 0; i < danhSachTenGheDaChon.Count; i += ghePerLine)
            {
                formattedGheList.Add(string.Join(", ", danhSachTenGheDaChon.Skip(i).Take(ghePerLine)));
            }
            lb_DSGheDaChon.Text = string.Join("\n", formattedGheList);

            lb_TongTienVePhim.Text = lb_TongTienGhe.Text;
            lb_GioChieuVe.Text = cbo_SuatChieu.Text;

            dgv_ThanhToanDV.Rows.Clear();
            foreach (DataGridViewRow row in dgv_ThongTinDatMon.Rows)
            {
                dgv_ThanhToanDV.Rows.Add(row.Cells["TenDoAn"].Value, row.Cells["SoLuong"].Value, row.Cells["DonGia"].Value, row.Cells["ThanhTien"].Value);
            }

            lb_ThanhToanDV.Text = lb_TongTien.Text;

            decimal tongTienVe = 0;
            decimal tongTienDV = 0;

            if (string.IsNullOrEmpty(lb_TongTienVePhim.Text))
            {
                tongTienVe = 0;
            }
            else
            {
                tongTienVe = decimal.Parse(lb_TongTienVePhim.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"));
            }

            if (string.IsNullOrEmpty(lb_ThanhToanDV.Text))
            {
                tongTienDV = 0;
            }
            else
            {
                tongTienDV = decimal.Parse(lb_ThanhToanDV.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"));
            }

            lb_TongCong.Text = (tongTienVe + tongTienDV).ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
        }


        //private void btn_InVe_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string templatePath = Path.Combine(Application.StartupPath, "Template", "Ticket.dotx");

        //        if (!File.Exists(templatePath))
        //        {
        //            MessageBox.Show("Không tìm thấy template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        foreach (string seat in danhSachTenGheDaChon)
        //        {
        //            string filePath = Path.Combine(Application.StartupPath, "Template", $"Ticket_{seat}.docx");
        //            WordExport wordExport = new WordExport(templatePath, false);

        //            Dictionary<string, string> values = new Dictionary<string, string>
        //            {
        //                { "MaHD", txt_MaHD.Text },
        //                { "TenPhim", lb_TenPhimChon.Text },
        //                { "NgayChieu", lb_NgayChieuVe.Text },
        //                { "PhongChieu", lb_PhongChieuVe.Text },
        //                { "Ghe", seat },
        //                { "GioChieu", lb_GioChieuVe.Text },
        //                { "TongTien", lb_TongCong.Text }
        //            };

        //            wordExport.WriteFields(values);
        //            wordExport._doc.SaveAs2(filePath);
        //            wordExport.Close();
        //        }

        //        MessageBox.Show("In vé thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Có lỗi xãy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btn_InVe_Click(object sender, EventArgs e)
        {
            try
            {
                string templatePath = Path.Combine(Application.StartupPath, "Template", "Ticket.dotx");

                if (!File.Exists(templatePath))
                {
                    MessageBox.Show("Không tìm thấy template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (string maGhe in danhSachGheDaDat)
                {
                    // Lấy thông tin ghế từ cơ sở dữ liệu
                    GheDTO ghe = gheBUL.LayGheTheoMa(maGhe);

                    if (ghe == null)
                    {
                        MessageBox.Show($"Không tìm thấy thông tin ghế cho mã ghế: {maGhe}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    string tenGhe = ghe.hang + (ghe.cot).ToString(); // Chuyển số cột thành chuỗi để nối
                    string filePath = Path.Combine(Application.StartupPath, "Template", $"Ticket_{tenGhe}.docx");
                    WordExport wordExport = new WordExport(templatePath, false);

                    Dictionary<string, string> values = new Dictionary<string, string>
                    {
                        { "MaHD", txt_MaHD.Text },
                        { "TenPhim", lb_TenPhimChon.Text },
                        { "NgayChieu", lb_NgayChieuVe.Text },
                        { "PhongChieu", lb_PhongChieuVe.Text },
                        { "Ghe", tenGhe },
                        { "GioChieu", lb_GioChieuVe.Text },
                        { "GiaVe", ghe.Gia.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")) } // In giá của từng ghế
                    };

                    wordExport.WriteFields(values);
                    wordExport._doc.SaveAs2(filePath);
                    wordExport.Close();
                }

                MessageBox.Show("In vé thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xãy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void timKhachHangTheoSDT(string sdt)
        {
            KhachHangDTO khachHang = khachHangBUL.layKhachHangTheoSDT(sdt);
            if (khachHang != null)
            {
                btn_ThemKhachHang.Visible = false;
                txt_TenKH.Text = khachHang.TenKhachHang;
                maKH = khachHang.MaKhachHang;
            }
            else
            {
                DialogResult result = MessageBox.Show("Khách hàng không tồn tại. Bạn có muốn thêm khách hàng mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btn_ThemKhachHang.Visible = true;
                    btn_ThemKhachHang_Click(null, null); // Gọi hàm thêm khách hàng mới
                }
                else
                {
                    txt_SoDienThoai.Text = "";
                    txt_SoDienThoai.Focus();
                }
            }
        }

        private void txt_SoDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timKhachHangTheoSDT(txt_SoDienThoai.Text);
            }
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            string soDienThoai = txt_SoDienThoai.Text;
            frm_ThemKhachHang frm_ThemKhachHang = new frm_ThemKhachHang(soDienThoai);
            frm_ThemKhachHang.KhachHangAdded += Frm_ThemKhachHang_KhachHangAdded;
            frm_ThemKhachHang.Show();
        }

        private void Frm_ThemKhachHang_KhachHangAdded(object sender, KhachHangDTO khachHang)
        {
            if (khachHang != null)
            {
                //lb_TenKH.Visible = true;
                //lb_KM.Visible = true;
                //txt_TenKH.Visible = true;
                //cbo_ChonKhuyenMai.Visible = true;
                txt_TenKH.Text = khachHang.TenKhachHang;
                maKH = khachHang.MaKhachHang;
            }
        }

        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            txt_MaHD.Text = hoaDonBUL.taoMaHoaDon();
        }

        public void loadComboboxKhuyenMai()
        {
            //Dựa vào số lượng ghế trong danh sách ghế đã chọn để chọn khuyến mãi
            int soLuongGhe = danhSachGheDaDat.Count;

            //Nếu số lượng ghế > 3 thì mới load khuyến mãi
            if (soLuongGhe > 5)
            {
                cbo_ChonKhuyenMai.DataSource = khuyenMaiBUL.layDSKhuyenMai();
                cbo_ChonKhuyenMai.DisplayMember = "TenKM";
                cbo_ChonKhuyenMai.ValueMember = "MaKM";
            }
            else
            {
                cbo_ChonKhuyenMai.DataSource = null;
            }

        }
        private void cb_IsNonMember_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cb_IsNonMember.Checked)
            {
                lb_SDT.Visible = false;

                txt_SoDienThoai.Visible = false;
                lb_TenKH.Visible = false;
                lb_KM.Visible = false;
                txt_TenKH.Visible = false;
                cbo_ChonKhuyenMai.Visible = false;
            }
            else
            {
                lb_SDT.Visible = true;
                txt_SoDienThoai.Visible = true;
                //btn_ThemKhachHang.Visible = true;
                lb_SDT.Visible = true;
                lb_TenKH.Visible = true;
                lb_KM.Visible = true;
                txt_TenKH.Visible = true;

                cbo_ChonKhuyenMai.Visible = true;
                loadComboboxKhuyenMai();
            }
        }
        private void cbo_SuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có mục nào được chọn
            if (cbo_SuatChieu.SelectedIndex == -1)
            {
                lb_GioChieu.Text = string.Empty;
                cbo_PhongChieu.DataSource = null;
                return;
            }

            // Lấy thông tin lịch chiếu từ combobox
            LichChieuDTO selectedLichChieu = (LichChieuDTO)cbo_SuatChieu.SelectedItem;
            lb_GioChieu.Text = selectedLichChieu.DisplayText;

            // Tách các mã phòng chiếu và mã lịch chiếu
            List<string> phongChieuList = selectedLichChieu.PhongChieu.Split(',').Select(p => p.Trim()).ToList();

            // Tạo danh sách phòng chiếu DTO
            List<PhongChieuDTO> phongChieuDTOList = phongChieuList.Select(phongChieu => new PhongChieuDTO
            {
                MaPhongChieu = phongChieu,
                TenPhongChieu = phongChieu, // Assuming the room name is the same as the room code
                SoLuongGhe = 0 // Assuming no seat count is needed here
            }).ToList();

            // Hiển thị combobox phòng chiếu
            cbo_PhongChieu.DataSource = phongChieuDTOList;
            cbo_PhongChieu.DisplayMember = "TenPhongChieu";
            cbo_PhongChieu.ValueMember = "MaPhongChieu";
        }
        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            // Tạo hóa đơn
            string maHD = txt_MaHD.Text;
            LichChieuDTO selectedLichChieu = (LichChieuDTO)cbo_SuatChieu.SelectedItem;
            string maPhongChieu = cbo_PhongChieu.SelectedValue?.ToString();
            string maLichChieu = selectedLichChieu?.PhongChieuToMaLichChieu[maPhongChieu];
            string maKM = cbo_ChonKhuyenMai.SelectedValue?.ToString();
            decimal tongTien = decimal.Parse(lb_TongCong.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"));
            string maNV = maNhanVien;
            DateTime ngayBan = dtp_NgayLap.Value;
            string maKhachHang = cb_IsNonMember.Checked ? "KH000" : maKH;

            HoaDonDTO hoaDon = new HoaDonDTO
            {
                MaHD = maHD,
                MaNV = maNV,
                MaKH = maKhachHang,
                NgayBan = ngayBan,
                TongTien = tongTien,
                MaKM = maKM,
            };

            bool result = hoaDonBUL.themHoaDon(hoaDon);
            if (result)
            {
                MessageBox.Show("Tạo hóa đơn thành công!");

                if (currentPaymentType == PaymentType.TicketsOnly || currentPaymentType == PaymentType.Both)
                {
                    // Thêm chi tiết vé
                    if (danhSachGheDaDat.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn ghế.");
                        return;
                    }

                    bool allSeatsBookedSuccessfully = true;

                    foreach (string maGhe in danhSachGheDaDat)
                    {
                        CTVeDTO ctVeDTO = new CTVeDTO
                        {
                            MaHD = maHD,
                            MaGhe = maGhe,
                            MaLichChieu = maLichChieu
                        };

                        bool kq = cTVeBUL.themCTVe(ctVeDTO);

                        if (!kq)
                        {
                            allSeatsBookedSuccessfully = false;
                            break;
                        }
                    }

                    if (allSeatsBookedSuccessfully)
                    {
                        MessageBox.Show("Đặt ghế thành công!");
                        LoadBookedSeats();
                        //danhSachGheDaDat.Clear();
                        //danhSachTenGheDaChon.Clear();
                        lb_Ghe.Text = "";
                        uc_Ghe1.ResetTotalPrice();
                    }
                    else
                    {
                        MessageBox.Show("Đặt ghế thất bại.");
                    }
                }

                if (currentPaymentType == PaymentType.FoodOnly || currentPaymentType == PaymentType.Both)
                {
                    int isSuccessful = 0;

                    foreach (CTDoAnDTO monAn in danhSachMonAnDaChon)
                    {
                        int currentQuantity = dichVuBUL.laySoLuongMon(monAn.MaDoAn);
                        if (monAn.SoLuong > currentQuantity)
                        {
                            MessageBox.Show("Số lượng món không đủ. Vui lòng chọn số lượng ít hơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            isSuccessful++;
                            continue;
                        }

                        CTDoAnDTO ctDoAnDTO = new CTDoAnDTO
                        {
                            MaHD = maHD,
                            MaDoAn = monAn.MaDoAn,
                            SoLuong = monAn.SoLuong,
                            ThanhTien = monAn.ThanhTien
                        };

                        bool kq = cTDoAnBUL.themCTDoAn(ctDoAnDTO);
                        if (kq)
                        {
                            int newQuantity = currentQuantity - monAn.SoLuong;
                            bool updateResult = dichVuBUL.capNhatSoLuongMon(monAn.MaDoAn, newQuantity);
                            if (!updateResult)
                            {
                                isSuccessful++;
                            }
                        }
                        else
                        {
                            isSuccessful++;
                        }
                    }

                    if (isSuccessful == 0)
                    {
                        MessageBox.Show("Đặt món thành công!");
                    }
                    else
                    {
                        //MessageBox.Show("Đã xảy ra lỗi khi đặt món!");
                    }

                    danhSachMonAnDaChon.Clear();
                    dgv_ThongTinDatMon.Rows.Clear();
                    UpdateTotalPrice();
                    LoadServices();
                }

                btn_InVe.Enabled = true;
                InHoaDonMonAn.Enabled = true;
            }


            else
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
            }
        }

        private void cbo_ChonKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ChonKhuyenMai.SelectedIndex == -1)
            {
                phanTramKM = 0;
            }
            else
            {
                phanTramKM = khuyenMaiBUL.layPhanTramKMTheoMaKM(cbo_ChonKhuyenMai.SelectedValue.ToString());
            }
            UpdateTotalAmountWithDiscount();
        }

        private void UpdateTotalAmountWithDiscount()
        {
            decimal tongTienVe = 0;
            decimal tongTienDV = 0;

            if (string.IsNullOrEmpty(lb_TongTienVePhim.Text))
            {
                tongTienVe = 0;
            }
            else
            {
                tongTienVe = decimal.Parse(lb_TongTienVePhim.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"));
            }

            //Nếu lb_ThanhToanDV = "" thì gán giá trị 0
            if (string.IsNullOrEmpty(lb_ThanhToanDV.Text))
            {
                tongTienDV = 0;
            }
            else
            {
                tongTienDV = decimal.Parse(lb_ThanhToanDV.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"));
            }

            decimal tongCong = tongTienVe + tongTienDV;
            decimal discountAmount = tongCong * (phanTramKM ?? 0);
            decimal finalAmount = tongCong - discountAmount;

            lb_TongCong.Text = finalAmount.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
        }

        private void btn_TiepTucMuaDV_Click(object sender, EventArgs e)
        {
            tab_QLDatVe.SetPage(2);
            loadPanelVeXemPhim();
            cb_IsNonMember.Checked = true;
            btn_ThemKhachHang.Visible = false;
            currentPaymentType = PaymentType.Both;
        }


        #endregion ThanhToan
        private Dictionary<uint, string> GetLabelMappingFromGrid()
        {
            Dictionary<uint, string> labelMapping = new Dictionary<uint, string>();

            // Lấy dữ liệu từ DataGridView và tạo mapping từ số (ID) sang tên phim
            foreach (DataGridViewRow row in dgv_tranning.Rows)
            {
                if (row.IsNewRow) continue;

                string tenLoaiPhim = row.Cells["TenLoaiPhim"].Value?.ToString();
                string tenPhim = row.Cells["TenPhim"].Value?.ToString();

                // Tạo một ID phim giả định, có thể là số dòng hoặc một chỉ số nào đó
                uint phimId = (uint)row.Index + 1; // Ví dụ sử dụng index dòng làm ID phim

                // Lưu vào dictionary ánh xạ ID -> TenPhim
                if (!string.IsNullOrEmpty(tenLoaiPhim) && !string.IsNullOrEmpty(tenPhim))
                {
                    labelMapping[phimId] = tenPhim;
                }
            }

            return labelMapping;
        }

        private async void btn_Predict_Click(object sender, EventArgs e)
        {
            try
            {
                if (!float.TryParse(txtTuoi.Text, out float tuoi) || string.IsNullOrWhiteSpace(txtLoaiPhim.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                // Dữ liệu huấn luyện từ lưới
                List<InputModel> trainingData = GetTrainingDataFromGrid();
                if (!trainingData.Any())
                {
                    MessageBox.Show("Không có dữ liệu để huấn luyện.");
                    return;
                }

                string modelPath = @"..\MLModels\MovieRecommendationModel.zip";

                // Huấn luyện mô hình
                await duDoanBUL.TrainModelAsync(trainingData, modelPath);
                MessageBox.Show("Huấn luyện mô hình thành công!");

                // Dự đoán phim
                InputModel input = new InputModel
                {
                    Tuoi = tuoi,
                    TenLoaiPhim = txtLoaiPhim.Text
                };

                // Lấy labelMapping từ dữ liệu huấn luyện
                Dictionary<uint, string> labelMapping = GetLabelMappingFromGrid();

                // Gọi phương thức PredictMovie với labelMapping
                string prediction = duDoanBUL.PredictMovie(input, modelPath, labelMapping);

                // Hiển thị kết quả lên lb_phim
                lb_phim.Text = $"Phim dự đoán: {prediction}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private List<InputModel> GetTrainingDataFromGrid()
        {
            List<InputModel> trainingData = new List<InputModel>();
            Dictionary<uint, string> labelMapping = new Dictionary<uint, string>();

            // Lấy dữ liệu từ DataGridView và tạo mapping từ số (ID) sang tên phim
            foreach (DataGridViewRow row in dgv_tranning.Rows)
            {
                if (row.IsNewRow) continue;

                string tenLoaiPhim = row.Cells["TenLoaiPhim"].Value?.ToString();
                float tuoi = row.Cells["Tuoi"].Value != null ? Convert.ToSingle(row.Cells["Tuoi"].Value) : 0;
                string tenPhim = row.Cells["TenPhim"].Value?.ToString();

                // Kiểm tra và thêm vào danh sách
                if (!string.IsNullOrEmpty(tenLoaiPhim) && !string.IsNullOrEmpty(tenPhim))
                {
                    // Tạo một ID phim giả định, có thể là số dòng hoặc một chỉ số nào đó
                    uint phimId = (uint)row.Index + 1; // Ví dụ sử dụng index dòng làm ID phim

                    // Lưu vào dictionary ánh xạ ID -> TenPhim
                    labelMapping[phimId] = tenPhim;

                    // Thêm dữ liệu vào danh sách training data
                    trainingData.Add(new InputModel(tenLoaiPhim, tuoi, tenPhim));
                }
            }

            return trainingData;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<InputModel> movieData = duDoanBUL.LoadData(new DuDoanDAL().GetMovieData());

                if (movieData != null && movieData.Any())
                {
                    dgv_tranning.DataSource = movieData;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu phim để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btn_TuVan_Click_Click(object sender, EventArgs e)
        {
            tab_QLDatVe.SetPage(4);
        }
        private void tab_TuVan_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InHoaDonMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                string templatePath = Path.Combine(Application.StartupPath, "Template", "HoaDonTemplate.dotx");

                if (!File.Exists(templatePath))
                {
                    MessageBox.Show("Không tìm thấy template hóa đơn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string filePath = Path.Combine(Application.StartupPath, "Template", $"HoaDon_{txt_MaHD.Text}.docx");
                WordExport wordExport = new WordExport(templatePath, false);

                // Tạo dictionary chứa dữ liệu cho hóa đơn
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    { "MaHD", txt_MaHD.Text },
                    { "NgayLap", dtp_NgayLap.Value.ToString("dd/MM/yyyy") },
                    { "TenNV", txt_TenNV.Text },
                    { "TongTien", lb_ThanhToanDV.Text },
                    { "KhuyenMai", cbo_ChonKhuyenMai.SelectedIndex != -1 ? cbo_ChonKhuyenMai.Text : "Không có" },
                    { "ThanhToan", lb_TongCong.Text }
                };

                // Tạo bảng danh sách món ăn
                string danhSachMonAn = "";
                foreach (DataGridViewRow row in dgv_ThanhToanDV.Rows)
                {
                    danhSachMonAn += $"{row.Cells[0].Value}  |  SL: {row.Cells[1].Value}  |  Đơn giá: {row.Cells[2].Value}  |  Thành tiền: {row.Cells[3].Value}\n";
                }
                values.Add("DanhSachMonAn", danhSachMonAn);

                wordExport.WriteFields(values);
                wordExport._doc.SaveAs2(filePath);
                wordExport.Close();

                MessageBox.Show("In hóa đơn thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_QLBanVe_Load(object sender, EventArgs e)
        {
            cbo_loaiPhim.SelectedIndex = 0;
        }

        private void btn_ThanhToanCK_Click(object sender, EventArgs e)
        {
            string tongTien = lb_TongCong.Text;


            tongTien = tongTien.Replace("₫", "").Replace(".", "").Trim();

            QRPay qRPay = QRPay.InitVietQR(
            bankBin: BankApp.BanksObject[BankKey.MBBANK].bin,
            bankNumber: "99133336868",
            amount: tongTien,
            purpose: "Thanh toán cho hóa đơn " + txt_MaHD.Text);

            //Tạo mã QR
            string content = qRPay.Build();
            Image imageQR = QRCodeHelper.TaoVietQRCodeImage(content);

            frm_QRCode frm_QRCode = new frm_QRCode(imageQR, tongTien);
            frm_QRCode.ShowDialog();
        }
    }
}
