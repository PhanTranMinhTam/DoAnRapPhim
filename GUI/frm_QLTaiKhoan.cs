using BUL;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QLTaiKhoan : Form
    {
        NguoiDungBUL nguoiDungBUL;
        NhanVienBUL nhanVienBUL;
        int flag = 0;
        string tenDangNhap;
        public frm_QLTaiKhoan()
        {
            InitializeComponent();
            nguoiDungBUL = new NguoiDungBUL();
            nhanVienBUL = new NhanVienBUL();
            enbaleButton(true);
            clearData();
            loadData();
            loadComboxNhanVien();

        }

        public void clearData()
        {
            txt_TenTaiKhoan.Text = "";
            rd_HoatDong.Checked = false;
            //rd_NgungHoatDong.Checked = false;
            cbo_NhanVien.SelectedIndex = -1;
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
            dgv_DSTaiKhoan.DataSource = nguoiDungBUL.layDanhSachNguoiDung();
            dgv_DSTaiKhoan.Columns["MatKhau"].Visible = false;
            dgv_DSTaiKhoan.CellFormatting += dgv_DSTaiKhoan_CellFormatting;
        }

        private void dgv_DSTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DSTaiKhoan.Columns[e.ColumnIndex].Name == "HoatDong")
            {
                if (e.Value != null)
                {
                    int hoatDongValue;
                    if (int.TryParse(e.Value.ToString(), out hoatDongValue))
                    {
                        e.Value = hoatDongValue == 1 ? "Đang hoạt động" : "Ngưng hoạt động";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        public void loadComboxNhanVien()
        {
            cbo_NhanVien.DataSource = nhanVienBUL.getNhanVien();
            cbo_NhanVien.DisplayMember = "TenNhanVien";
            cbo_NhanVien.ValueMember = "MaNhanVien";
            cbo_NhanVien.SelectedIndex = -1;
        }

        public bool checkData()
        {
            if (txt_TenTaiKhoan.Text == "" || cbo_NhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgv_DSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txt_TenTaiKhoan.Text = dgv_DSTaiKhoan.Rows[row].Cells["TenDN"].Value.ToString();
                tenDangNhap = dgv_DSTaiKhoan.Rows[row].Cells["TenDN"].Value.ToString();
                cbo_NhanVien.SelectedValue = dgv_DSTaiKhoan.Rows[row].Cells["MaNhanVien"].Value.ToString();
                if (dgv_DSTaiKhoan.Rows[row].Cells["HoatDong"].Value.ToString() == "1")
                {
                    rd_HoatDong.Checked = true;
                }
                else
                {
                    rd_HoatDong.Checked = false;
                }
            }
        }

        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            flag = 1;
            enbaleButton(false);
            clearData();
            dgv_DSTaiKhoan.Enabled = false;
        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            flag = 2;
            enbaleButton(false);
            dgv_DSTaiKhoan.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, System.EventArgs e)
        {
            if (tenDangNhap != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (nguoiDungBUL.xoaNguoiDung(tenDangNhap))
                    {
                        MessageBox.Show("Xóa thành công");
                        loadData();
                        clearData();
                        enbaleButton(true);
                        dgv_DSTaiKhoan.Enabled = true;
                        flag = 0;
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

        private void btn_Huy_Click(object sender, System.EventArgs e)
        {
            flag = 0;
            clearData();
            enbaleButton(true);
        }

        private void btn_Luu_Click(object sender, System.EventArgs e)
        {
            NguoiDungDTO nguoiDung = new NguoiDungDTO();
            if (checkData())
            {
                nguoiDung.TenDangNhap = txt_TenTaiKhoan.Text;
                nguoiDung.MatKhau = "1";
                nguoiDung.MaNhanVien = cbo_NhanVien.SelectedValue.ToString();
                if (rd_HoatDong.Checked == true)
                {
                    nguoiDung.HoatDong = 1;
                }
                else
                {
                    nguoiDung.HoatDong = 0;
                }
                if (flag == 1)
                {
                    if (nguoiDungBUL.themNguoiDung(nguoiDung))
                    {
                        MessageBox.Show("Thêm thành công");
                        loadData();
                        clearData();
                        enbaleButton(true);
                        dgv_DSTaiKhoan.Enabled = true;
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
                        if (nguoiDungBUL.suaNguoiDung(nguoiDung))
                        {
                            MessageBox.Show("Sửa thành công");
                            loadData();
                            clearData();
                            enbaleButton(true);
                            dgv_DSTaiKhoan.Enabled = true;
                            flag = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }

        }
    }
}
