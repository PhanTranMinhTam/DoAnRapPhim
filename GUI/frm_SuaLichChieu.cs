using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_SuaLichChieu : Form
    {
        LichChieuBUL lichChieuBUL;
        string maLichChieu;
        public frm_SuaLichChieu(string maLichChieu)
        {
            InitializeComponent();
            this.maLichChieu = maLichChieu;
            lichChieuBUL = new LichChieuBUL();
            loadDataForm();

        }

        public void loadComboBoxPhim()
        {
            PhimBUL phimBUL = new PhimBUL();
            cbo_Phim.DataSource = phimBUL.getPhim();
            cbo_Phim.DisplayMember = "TenPhim";
            cbo_Phim.ValueMember = "MaPhim";
        }

        public void loadComboBoxPhongChieu()
        {
            PhongChieuBUL phongChieuBUL = new PhongChieuBUL();
            cbo_PhongChieu.DataSource = phongChieuBUL.getPhongChieu();
            cbo_PhongChieu.DisplayMember = "TenPhongChieu";
            cbo_PhongChieu.ValueMember = "MaPhongChieu";
        }

        public void loadDataForm()
        {
            LichChieuDTO lichChieu = lichChieuBUL.layThongTinLichChieuTheoMa(maLichChieu);
            if (lichChieu == null)
            {
                MessageBox.Show("Không tìm thấy lịch chiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                loadComboBoxPhim();
                loadComboBoxPhongChieu();
                cbo_Phim.SelectedValue = lichChieu.MaPhim;
                cbo_PhongChieu.SelectedValue = lichChieu.MaPhongChieu;
                dtp_NgayChieu.Value = lichChieu.NgayChieu.Value;
                dtp_GioBatDau.Value = DateTime.Parse(lichChieu.GioBatDau.ToString());
                dtp_GioKetThuc.Value = DateTime.Parse(lichChieu.GioKetThuc.ToString());
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            LichChieuDTO lichChieu = new LichChieuDTO
            {
                MaLichChieu = maLichChieu,
                MaPhim = cbo_Phim.SelectedValue.ToString(),
                MaPhongChieu = cbo_PhongChieu.SelectedValue.ToString(),
                NgayChieu = dtp_NgayChieu.Value,
                GioBatDau = TimeSpan.Parse(dtp_GioBatDau.Value.ToString("HH:mm")),
                GioKetThuc = TimeSpan.Parse(dtp_GioKetThuc.Value.ToString("HH:mm"))
            };

            string errorMessage;

            if (lichChieuBUL.suaLichChieu(lichChieu, out errorMessage))
            {
                // Success: Show success message
                MessageBox.Show("Sửa lịch chiếu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Failure: Show error message
                MessageBox.Show($"Sửa lịch chiếu thất bại: {errorMessage}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
