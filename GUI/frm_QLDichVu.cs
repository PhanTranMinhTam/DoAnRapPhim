using BUL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLDichVu : Form
    {
        DichVuBUL dichVuBUL;
        string maDoAn;
        DataTable dtDoAn;
        public frm_QLDichVu()
        {
            InitializeComponent();
            dichVuBUL = new DichVuBUL();
            loadData();
        }

        public void loadData()
        {
            dgv_DSDichVu.AutoGenerateColumns = false;
            dtDoAn = dichVuBUL.getDichVu();
            dgv_DSDichVu.DataSource = dtDoAn;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemDichVu frm = new frm_ThemDichVu();
            frm.Show();
            //nếu form đóng thì load lại dữ liệu
            frm.FormClosed += (s, ev) =>
            {
                loadData();
            };
        }

        private void dgv_DSDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                maDoAn = dgv_DSDichVu.Rows[index].Cells["MaMon"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (maDoAn == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa món này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dichVuBUL.xoaDichVu(maDoAn))
                    {
                        MessageBox.Show("Xóa món thành công");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa món thất bại");
                    }
                }

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (maDoAn == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa");
            }
            else
            {
                frm_SuaDichVu frm = new frm_SuaDichVu(maDoAn);
                frm.Show();
                //nếu form đóng thì load lại dữ liệu
                frm.FormClosed += (s, ev) =>
                {
                    loadData();
                };
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string filter = string.Format("TenDoAn like '%{0}%' OR MaDoAn like '%{0}%'", txt_TimKiem.Text);
            (dgv_DSDichVu.DataSource as DataTable).DefaultView.RowFilter = filter;


        }
    }
}
