using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ChiTietPhim : Form
    {
        private PhimBUL phimBUL;
        private PhimDTO phim;
        public frm_ChiTietPhim(PhimDTO phim)
        {
            InitializeComponent();
            this.phim = phim;
            phimBUL = new PhimBUL();

            txt_LoaiPhim.Text = phim.TenLoaiPhim;
            txt_TenPhim.Text = phim.TenPhim;
            txt_DaoDien.Text = phim.DaoDien;
            txt_QuocGia.Text = phim.QuocGia;
            txt_ThoiLuong.Text = phim.ThoiLuong.ToString() + " phút";
            txt_NoiDung.Text = phim.NoiDung;
            txt_NoiDung.Multiline = true;
            txt_NoiDung.ScrollBars = ScrollBars.Vertical;
            txt_NoiDung.WordWrap = true;
            pic_HinhPhim.ImageLocation = phim.HinhAnh;
            dtp_NgayChieu.Value = phim.NgayChieu;
            dtp_NgayKT.Value = phim.NgayKT;
        }

        private void frm_ChiTietPhim_Load(object sender, EventArgs e)
        {

        }
    }
}
