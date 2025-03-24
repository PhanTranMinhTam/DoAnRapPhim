using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_Ghe : UserControl
    {
        private ToolTip toolTip1;
        const int SEATS_PER_ROW = 10;
        private decimal totalPrice = 0;

        public event Action<string> SeatClicked;
        public event Action<decimal> TotalPriceChanged;
        private Dictionary<string, bool> seatStates; // Lưu trữ trạng thái của ghế

        public uc_Ghe()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            seatStates = new Dictionary<string, bool>();
        }

        public void LoadSeats(List<GheDTO> seats)
        {
            panelPhongChieu.Controls.Clear();
            seatStates.Clear();

            int currentRow = 1;
            int seatIndex = 1;

            FlowLayoutPanel rowPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = true,
                Margin = new Padding(0)
            };

            if (seats.Count == 0)
            {
                Console.WriteLine("Không có ghế để hiển thị.");
                return;
            }

            int top = 0;
            foreach (GheDTO seat in seats.OrderBy(s => s.hang).ThenBy(s => s.cot))
            {
                Button seatButton = new Button();
                seatButton.Name = seat.maGhe;
                char rowLetter = (char)('A' + currentRow - 1);
                seatButton.Text = String.Format("{0}{1}", rowLetter, seatIndex);
                seatButton.Size = new Size(75, 75);
                seatButton.Margin = new Padding(5);

                seatButton.Tag = seat;
                //seatButton.Tag = seat.maGhe;
                SetSeatButtonColor(seatButton, seat.trangThai, seat.loaiGhe);
                toolTip1.SetToolTip(seatButton, seat.loaiGhe);

                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Trống", null, (s, e) => UpdateSeatStatus(seatButton, seat, 0));
                contextMenu.Items.Add("Hư", null, (s, e) => UpdateSeatStatus(seatButton, seat, -1));
                contextMenu.Items.Add("VIP", null, (s, e) => UpdateSeatType(seatButton, seat, "VIP"));
                contextMenu.Items.Add("Thường", null, (s, e) => UpdateSeatType(seatButton, seat, "Thường"));

                seatButton.ContextMenuStrip = contextMenu;
                seatButton.Click += OnSeatButtonClick;
                rowPanel.Controls.Add(seatButton);
                seatIndex++;

                if (seatIndex > SEATS_PER_ROW)
                {
                    panelPhongChieu.Controls.Add(rowPanel);
                    top += 95;
                    rowPanel = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        AutoSize = true,
                        WrapContents = true,
                        Margin = new Padding(3),
                        Top = top
                    };

                    currentRow++;
                    seatIndex = 1;
                }
            }

            if (rowPanel.Controls.Count > 0)
            {
                panelPhongChieu.Controls.Add(rowPanel);
            }
        }

        private void OnSeatButtonClick(object sender, EventArgs e)
        {
            if (sender is Button seatButton && seatButton.Tag is GheDTO seat)
            {
                // Tạo chuỗi seatInfo
                string seatInfo = $"Mã ghế {seat.maGhe} - Ghế: {seat.hang}{seat.cot} - Loại: {seat.loaiGhe} - Giá: {seat.Gia.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";

                // Kiểm tra xem ghế đã được chọn hay chưa
                if (seatStates.ContainsKey(seat.maGhe) && seatStates[seat.maGhe])
                {
                    // Nếu ghế đã được chọn, bỏ chọn ghế
                    seatStates[seat.maGhe] = false;
                    if (seat.loaiGhe == "VIP")
                    {
                        seatButton.BackColor = Color.Yellow;
                        SeatClicked?.Invoke(seatInfo);
                        seat.trangThai = 0;
                        totalPrice -= seat.Gia;
                    }
                    else
                    {
                        seatButton.BackColor = Color.Gray;
                        SeatClicked?.Invoke(seatInfo);
                        seat.trangThai = 0;
                        totalPrice -= seat.Gia;
                    }
                }
                else
                {
                    // Nếu ghế chưa được chọn, chọn ghế
                    seatStates[seat.maGhe] = true;
                    seatButton.BackColor = Color.Blue; // Đổi sang màu xanh lá
                    SeatClicked?.Invoke(seatInfo);
                    seat.trangThai = 1;
                    totalPrice += seat.Gia;
                }

                // Gọi phương thức ShowSeatInfo để hiển thị thông tin ghế
                //ShowSeatInfo(seatInfo);

                // Tính toán lại tổng giá
                CalculateTotalPrice();

            }

        }

        private void CalculateTotalPrice()
        {
            TotalPriceChanged?.Invoke(totalPrice); // Gửi tổng tiền qua sự kiện
        }

        public void ResetTotalPrice()
        {
            totalPrice = 0;
            TotalPriceChanged?.Invoke(totalPrice); // Gửi tổng tiền qua sự kiện
        }

        private void UpdateSeatStatus(Button seatButton, GheDTO seat, int newStatus)
        {
            seat.trangThai = newStatus;
            SetSeatButtonColor(seatButton, seat.trangThai, seat.loaiGhe);
            seatStates[seat.maGhe] = (newStatus == 1);
            //gheBUL.CapNhatTrangThaiGhe(seat);
        }

        private void UpdateSeatType(Button seatButton, GheDTO seat, string newType)
        {
            //seat.loaiGhe = newType;
            //SetSeatButtonColor(seatButton, seat.trangThai, seat.loaiGhe);
            //toolTip1.SetToolTip(seatButton, string.Format("{0} - Trạng thái: {1}",
            //    seat.loaiGhe, seat.trangThai == 1 ? "Đã đặt" : seat.trangThai == 0 ? "Trống" : "Hư"));
            seat.loaiGhe = newType;

            // Cập nhật loại ghế trong cơ sở dữ liệu thông qua BLL

            // Thay đổi màu sắc nút ghế
            SetSeatButtonColor(seatButton, seat.trangThai, seat.loaiGhe);

            // Cập nhật tooltip để hiển thị thông tin mới
            toolTip1.SetToolTip(seatButton, string.Format("{0} - Trạng thái: {1}",
                seat.loaiGhe, seat.trangThai == 1 ? "Đã đặt" : seat.trangThai == 0 ? "Trống" : "Hư"));
        }

        private void SetSeatButtonColor(Button seatButton, int trangThai, string loaiGhe)
        {
            if (loaiGhe == "VIP" && trangThai == 0)
            {
                seatButton.BackColor = Color.Yellow;
            }
            else
            {
                switch (trangThai)
                {
                    case -1:
                        seatButton.BackColor = Color.Red;
                        break;
                    case 0:
                        seatButton.BackColor = loaiGhe == "VIP" ? Color.Yellow : Color.Gray;
                        break;
                    case 1:
                        seatButton.BackColor = Color.Blue;
                        break;
                }
            }
        }
    }
}


