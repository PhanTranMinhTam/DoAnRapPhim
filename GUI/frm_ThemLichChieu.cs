using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThemLichChieu : Form
    {
        PhongChieuBUL phongChieuBUL;
        PhimBUL phimBUL;
        LichChieuBUL lichChieuBUL;
        public frm_ThemLichChieu()
        {
            InitializeComponent();
            phongChieuBUL = new PhongChieuBUL();
            phimBUL = new PhimBUL();
            lichChieuBUL = new LichChieuBUL();
            loadComboboxPhim();
            loadComboboxPhongChieu();
        }

        public void loadComboboxPhim()
        {
            cbo_Phim.DataSource = phimBUL.getPhim();
            cbo_Phim.DisplayMember = "TenPhim";
            cbo_Phim.ValueMember = "MaPhim";
            cbo_Phim.SelectedIndex = -1;
        }

        public void loadComboboxPhongChieu()
        {
            cbo_PhongChieu.DataSource = phongChieuBUL.getPhongChieu();
            cbo_PhongChieu.DisplayMember = "TenPhongChieu";
            cbo_PhongChieu.ValueMember = "MaPhongChieu";
            cbo_PhongChieu.SelectedIndex = -1;
        }

        public string taoMaLichChieu()
        {
            string maLichChieuLonNhat = lichChieuBUL.layMaLichChieu();
            string maLichChieu;
            if (maLichChieuLonNhat == "")
            {
                maLichChieu = "LC001";
            }
            else
            {
                int so = int.Parse(maLichChieuLonNhat.Substring(2)) + 1;
                if (so < 10)
                {
                    maLichChieu = "LC00" + so;
                }
                else if (so < 100)
                {
                    maLichChieu = "LC0" + so;
                }
                else
                {
                    maLichChieu = "LC" + so;
                }
            }
            return maLichChieu;

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (cbo_Phim.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim");
                count++;
            }
            if (cbo_PhongChieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu");
                count++;
            }
            if (dtp_NgayChieu.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày chiếu không hợp lệ");
                count++;
            }
            if (dtp_GioBatDau.Value >= dtp_GioKetThuc.Value)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc");
                count++;
            }

            if (count == 0)
            {
                LichChieuDTO lichChieu = new LichChieuDTO
                {
                    MaLichChieu = taoMaLichChieu(),
                    MaPhim = cbo_Phim.SelectedValue.ToString(),
                    MaPhongChieu = cbo_PhongChieu.SelectedValue.ToString(),
                    NgayChieu = dtp_NgayChieu.Value,
                    GioBatDau = dtp_GioBatDau.Value.TimeOfDay,
                    GioKetThuc = dtp_GioKetThuc.Value.TimeOfDay
                };

                string errorMessage;
                bool kq = lichChieuBUL.themLichChieu(lichChieu, out errorMessage);
                if (kq)
                {
                    MessageBox.Show("Thêm lịch chiếu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Thêm lịch chiếu thất bại: {errorMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        }



        private void btn_Huy_Click(object sender, System.EventArgs e)
        {
            cbo_Phim.SelectedIndex = -1;
            cbo_PhongChieu.SelectedIndex = -1;
            dtp_NgayChieu.Value = System.DateTime.Now;
            dtp_GioBatDau.Value = System.DateTime.Now;
            dtp_GioKetThuc.Value = System.DateTime.Now;
        }
    }
}
