using BUL;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLLichChieu : Form
    {
        LichChieuBUL lichChieuBUL;
        string lichChieuSelected;
        DataTable dtLichChieu;
        public frm_QLLichChieu()
        {
            InitializeComponent();
            lichChieuBUL = new LichChieuBUL();
            loadData();

        }


        public void loadData()
        {
            dgv_LichChieu.AutoGenerateColumns = false;
            dtLichChieu = lichChieuBUL.getLichChieu();
            dgv_LichChieu.DataSource = dtLichChieu;
            //Config lại cột ngày chiếu thành dd//MM/yyyy
            dgv_LichChieu.Columns["NgayChieu"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //Ẩn cột lịch chiếu
            dgv_LichChieu.Columns["MaLichChieu"].Visible = false;

        }

        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            Form form = new frm_ThemLichChieu();
            form.Show();
            //nếu form đóng thì load lại dữ liệu
            form.FormClosed += (s, ev) =>
            {
                loadData();
            };

        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            //Binding dữ liệu từ dgv vào form sửa
            if (lichChieuSelected == null)
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu cần sửa");
            }
            else
            {
                Form form = new frm_SuaLichChieu(lichChieuSelected);
                form.Show();
                //nếu form đóng thì load lại dữ liệu
                form.FormClosed += (s, ev) =>
                {
                    loadData();
                };
            }
        }

        private void dgv_LichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                lichChieuSelected = dgv_LichChieu.Rows[index].Cells["MaLichChieu"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, System.EventArgs e)
        {
            if (lichChieuSelected == null)
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu cần xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch chiếu này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (lichChieuBUL.xoaLichChieu(lichChieuSelected))
                    {
                        MessageBox.Show("Xóa lịch chiếu thành công");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa lịch chiếu thất bại");
                    }
                }
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            string filter = string.Format("TenPhim like '%{0}%' OR TenPhongChieu like '%{0}%'", bunifuTextBox1.Text);
            (dgv_LichChieu.DataSource as DataTable).DefaultView.RowFilter = filter;
        }

        private void dtp_NgayChieu_ValueChanged(object sender, System.EventArgs e)
        {
            string filter = string.Format("NgayChieu = '{0}'", dtp_NgayChieu.Value.ToString("dd/MM/yyyy"));
            (dgv_LichChieu.DataSource as DataTable).DefaultView.RowFilter = filter;
        }
    }
}
