using BUL;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_PhanQuyen : Form
    {
        ChucVuBUL chucVuBUL;
        DM_ManHinhBUL danhMucManHinh;
        PhanQuyenBUL phanQuyenBUL;
        int flag = 0;
        string tenCV, tenMH;
        public frm_PhanQuyen()
        {
            InitializeComponent();
            chucVuBUL = new ChucVuBUL();
            danhMucManHinh = new DM_ManHinhBUL();
            phanQuyenBUL = new PhanQuyenBUL();
            loadDanhSachChucVu();
            loadCombobox();
            enbaleButton(true);
        }

        public void clearData()
        {
            cbo_TenChucVu.SelectedIndex = -1;
            cbo_TenManHinh.SelectedIndex = -1;
        }

        public void enbaleButton(bool t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Luu.Enabled = !t;
            btn_Xoa.Enabled = t;
        }
        public void loadDanhSachChucVu()
        {
            dgv_DSPhanQuyen.DataSource = phanQuyenBUL.getDSQuyen();
            dgv_DSPhanQuyen.CellFormatting += dgv_DSPhanQuyen_CellFormatting;
        }

        private void dgv_DSPhanQuyen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DSPhanQuyen.Columns[e.ColumnIndex].Name == "CoQuyen")
            {
                if (e.Value != null)
                {
                    int quyenValue;
                    if (int.TryParse(e.Value.ToString(), out quyenValue))
                    {
                        e.Value = quyenValue == 1 ? "Có quyền" : "Không có quyền";
                        e.FormattingApplied = true;
                    }
                }
            }
        }



        private void dgv_DSPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                cbo_TenChucVu.SelectedValue = dgv_DSPhanQuyen.Rows[i].Cells[0].Value.ToString();
                tenCV = dgv_DSPhanQuyen.Rows[i].Cells[0].Value.ToString();
                cbo_TenManHinh.SelectedValue = dgv_DSPhanQuyen.Rows[i].Cells[1].Value.ToString();
                tenMH = dgv_DSPhanQuyen.Rows[i].Cells[1].Value.ToString();
                cb_CoQuyen.Checked = dgv_DSPhanQuyen.Rows[i].Cells[2].Value.ToString() == "1" ? true : false;
            }
        }

        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            flag = 1;
            clearData();
            enbaleButton(false);
            dgv_DSPhanQuyen.Enabled = true;
        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            if (tenCV != null && tenMH != null)
            {
                flag = 2;
                enbaleButton(false);
            }
            else if (tenCV == null || tenMH == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa");
            }
        }

        private void btn_Xoa_Click(object sender, System.EventArgs e)
        {
            if (tenCV != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (phanQuyenBUL.xoaQuyen(tenCV, tenMH))
                    {
                        MessageBox.Show("Xóa thành công");
                        loadDanhSachChucVu();
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
                MessageBox.Show("Vui lòng chọn dữ liệu để xóa");
            }
        }

        private void btn_Luu_Click(object sender, System.EventArgs e)
        {
            PhanQuyenDTO phanQuyen = new PhanQuyenDTO();
            phanQuyen.MaChucVu = cbo_TenChucVu.SelectedValue.ToString();
            phanQuyen.MaManHinh = cbo_TenManHinh.SelectedValue.ToString();
            phanQuyen.CoQuyen = cb_CoQuyen.Checked ? 1 : 0;

            if (flag == 1)
            {
                if (phanQuyenBUL.themQuyen(phanQuyen))
                {
                    MessageBox.Show("Thêm thành công");
                    loadDanhSachChucVu();
                    clearData();
                    enbaleButton(true);
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
                    if (phanQuyenBUL.suaQuyen(phanQuyen))
                    {
                        MessageBox.Show("Sửa thành công");
                        loadDanhSachChucVu();
                        clearData();
                        enbaleButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, System.EventArgs e)
        {
            flag = 0;
            clearData();
            enbaleButton(true);
            dgv_DSPhanQuyen.Enabled = true;
        }

        public void loadCombobox()
        {
            cbo_TenManHinh.DataSource = danhMucManHinh.LoadManHinh();
            cbo_TenManHinh.DisplayMember = "tenManHinh";
            cbo_TenManHinh.ValueMember = "maManHinh";
            cbo_TenManHinh.SelectedIndex = -1;

            cbo_TenChucVu.DataSource = chucVuBUL.LayDanhSachChucVu();
            cbo_TenChucVu.DisplayMember = "tenChucVu";
            cbo_TenChucVu.ValueMember = "maChucVu";
            cbo_TenChucVu.SelectedIndex = -1;
        }

    }
}
