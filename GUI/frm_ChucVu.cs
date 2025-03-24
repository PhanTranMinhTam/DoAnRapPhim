using BUL;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ChucVu : Form
    {

        ChucVuBUL chucVuBUL;
        string maCV;
        int flag = 0;
        public frm_ChucVu()
        {
            InitializeComponent();
            chucVuBUL = new ChucVuBUL();
            enbaleButton(true);
            clearData();
            loadData();
        }

        public void loadData()
        {
            dgv_DSChucVu.DataSource = chucVuBUL.LayDanhSachChucVu();
        }

        public void clearData()
        {
            txt_MaChucVu.Text = "";
            txt_TenChucVu.Text = "";
        }

        public void enbaleButton(bool t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Luu.Enabled = !t;
            btn_Xoa.Enabled = t;
        }

        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            flag = 1;
            enbaleButton(false);
            dgv_DSChucVu.Enabled = false;
            txt_MaChucVu.Text = chucVuBUL.taoMaChucVu();
        }

        private void btn_Luu_Click(object sender, System.EventArgs e)
        {
            ChucVuDTO chucVu = new ChucVuDTO();
            chucVu.MaChucVu = txt_MaChucVu.Text;
            chucVu.TenChucVu = txt_TenChucVu.Text;

            if (flag == 1)
            {
                if (chucVuBUL.themChucVu(chucVu))
                {
                    MessageBox.Show("Thêm thành công");
                    loadData();
                    clearData();
                    enbaleButton(true);
                    dgv_DSChucVu.Enabled = true;
                    flag = 0;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else if (flag == 2)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (chucVuBUL.suaChucVu(chucVu))
                    {
                        MessageBox.Show("Sửa thành công");
                        loadData();
                        clearData();
                        enbaleButton(true);
                        dgv_DSChucVu.Enabled = true;
                        flag = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            if (maCV != null)
            {
                flag = 2;
                enbaleButton(false);
                dgv_DSChucVu.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Xoa_Click(object sender, System.EventArgs e)
        {
            if (maCV != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (chucVuBUL.xoaChucVu(maCV))
                    {
                        MessageBox.Show("Xóa thành công");
                        loadData();
                        clearData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_DSChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txt_MaChucVu.Text = dgv_DSChucVu.Rows[row].Cells[0].Value.ToString();
                maCV = dgv_DSChucVu.Rows[row].Cells[0].Value.ToString();
                txt_TenChucVu.Text = dgv_DSChucVu.Rows[row].Cells[1].Value.ToString();
            }
        }

        private void btn_Huy_Click(object sender, System.EventArgs e)
        {
            flag = 0;
            clearData();
            enbaleButton(true);
        }
    }
}
