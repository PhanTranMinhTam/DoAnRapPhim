using BUL;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLNhanVienChucVu : Form
    {
        NguoiDungBUL nguoiDungBUL;
        ChucVuBUL chucVuBUL;
        NhanVienChucVuBUL nhanVien_ChucVuBUL;
        int flag = 0;
        string tenDangNhap, tenChucVu;
        public frm_QLNhanVienChucVu()
        {
            InitializeComponent();
            nguoiDungBUL = new NguoiDungBUL();
            chucVuBUL = new ChucVuBUL();
            nhanVien_ChucVuBUL = new NhanVienChucVuBUL();
            loadData();
            loadCombobox();
            enbaleButton(true);
        }

        public void clearData()
        {
            cbo_TenChucVu.SelectedIndex = -1;
            cbo_TenDangNhap.SelectedIndex = -1;
        }

        public void enbaleButton(bool t)
        {
            btn_Them.Enabled = t;
            btn_Sua.Enabled = t;
            btn_Xoa.Enabled = t;
            btn_Luu.Enabled = !t;
            btn_Xoa.Enabled = t;
        }

        public void loadData()
        {
            dgv_DSNV_CV.DataSource = nhanVien_ChucVuBUL.LayDanhSachNhanVienChucVu();
        }

        public void loadCombobox()
        {
            cbo_TenChucVu.DataSource = chucVuBUL.LayDanhSachChucVu();
            cbo_TenChucVu.DisplayMember = "TenChucVu";
            cbo_TenChucVu.ValueMember = "MaChucVu";
            cbo_TenChucVu.SelectedIndex = -1;

            cbo_TenDangNhap.DataSource = nguoiDungBUL.layDanhSachNguoiDung();
            cbo_TenDangNhap.DisplayMember = "TenDangNhap";
            cbo_TenDangNhap.ValueMember = "TenDangNhap";
            cbo_TenDangNhap.SelectedIndex = -1;
        }

        private void btn_Luu_Click(object sender, System.EventArgs e)
        {
            if (cbo_TenChucVu.SelectedIndex == -1 || cbo_TenDangNhap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVienChucVuDTO nhanVienChucVu = new NhanVienChucVuDTO();
            nhanVienChucVu.TenDangNhap = cbo_TenDangNhap.SelectedValue.ToString();
            nhanVienChucVu.MaChucVu = cbo_TenChucVu.SelectedValue.ToString();
            if (flag == 1)
            {
                if (nhanVien_ChucVuBUL.themNhanVienChucVu(nhanVienChucVu))
                {
                    MessageBox.Show("Thêm thành công");
                    loadData();
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
                if (nhanVien_ChucVuBUL.suaNhanVienChucVu(nhanVienChucVu))
                {
                    MessageBox.Show("Sửa thành công");
                    loadData();
                    clearData();
                    enbaleButton(true);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btn_Huy_Click(object sender, System.EventArgs e)
        {
            flag = 0;
            clearData();
            enbaleButton(true);
        }

        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            flag = 1;
            enbaleButton(false);
            clearData();
            dgv_DSNV_CV.Enabled = false;

        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            flag = 2;
            clearData();
            enbaleButton(false);
            dgv_DSNV_CV.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, System.EventArgs e)
        {
            if (tenDangNhap != null && tenChucVu != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (nhanVien_ChucVuBUL.xoaNhanVienChucVu(tenDangNhap, tenChucVu))
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
                MessageBox.Show("Vui lòng chọn dữ liệu để xóa");
            }
        }

        private void dgv_DSNV_CV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                cbo_TenDangNhap.SelectedValue = dgv_DSNV_CV.Rows[i].Cells[0].Value.ToString();
                tenDangNhap = dgv_DSNV_CV.Rows[i].Cells[0].Value.ToString();
                cbo_TenChucVu.SelectedValue = dgv_DSNV_CV.Rows[i].Cells[1].Value.ToString();
                tenChucVu = dgv_DSNV_CV.Rows[i].Cells[1].Value.ToString();
            }
        }
    }
}
