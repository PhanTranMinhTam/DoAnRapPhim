using BUL;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLManHinh : Form
    {
        DM_ManHinhBUL manHinhBUL;
        int flag = 0;
        string maManHinh;
        public frm_QLManHinh()
        {
            InitializeComponent();
            manHinhBUL = new DM_ManHinhBUL();
            enbaleButton(true);
            clearData();
            loadData();
        }

        public void loadData()
        {
            dgv_DSManHinh.DataSource = manHinhBUL.LoadManHinh();
        }

        public void clearData()
        {
            txt_MaManHinh.Text = "";
            txt_TenManHinh.Text = "";
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
            dgv_DSManHinh.Enabled = false;
            txt_MaManHinh.Text = manHinhBUL.taoMaManHinh();
        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            if (maManHinh != null)
            {
                flag = 2;
                enbaleButton(false);
                dgv_DSManHinh.Enabled = false;
            }
            else if (maManHinh == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa");
            }
        }

        private void btn_Xoa_Click(object sender, System.EventArgs e)
        {
            if (maManHinh != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (manHinhBUL.xoaManHinh(maManHinh))
                    {
                        MessageBox.Show("Xóa thành công");
                        loadData();
                        clearData();
                        enbaleButton(true);
                        dgv_DSManHinh.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else if (maManHinh == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xóa");
            }
        }

        private void dgv_DSManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txt_MaManHinh.Text = dgv_DSManHinh.Rows[row].Cells[0].Value.ToString();
                maManHinh = dgv_DSManHinh.Rows[row].Cells[0].Value.ToString();
                txt_TenManHinh.Text = dgv_DSManHinh.Rows[row].Cells[1].Value.ToString();
            }
        }

        private void btn_Luu_Click(object sender, System.EventArgs e)
        {
            DM_ManHinhDTO manHinh = new DM_ManHinhDTO();
            manHinh.MaManHinh = txt_MaManHinh.Text;
            manHinh.TenManHinh = txt_TenManHinh.Text;

            if (flag == 1)
            {
                if (txt_TenManHinh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }

                if (manHinhBUL.themManHinh(manHinh))
                {
                    MessageBox.Show("Thêm thành công");
                    loadData();
                    clearData();
                    enbaleButton(true);
                    dgv_DSManHinh.Enabled = true;
                    flag = 0;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else if (flag == 2)
            {
                if (txt_TenManHinh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }

                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (manHinhBUL.suaManHinh(manHinh))
                    {
                        MessageBox.Show("Sửa thành công");
                        loadData();
                        clearData();
                        enbaleButton(true);
                        dgv_DSManHinh.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    return;
                }
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
