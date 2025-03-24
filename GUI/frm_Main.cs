using BUL;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Main : Form
    {
        private BunifuButton currentSelectedButton;
        private Form activeForm = null;
        BunifuButton currentButton;
        string username;
        string maNhanVien;
        string tenNV;
        PhanQuyenBUL phanQuyenBUL;
        public frm_Main(string username, string maNhanVien, string tenNhanVien, string chucVu)
        {
            InitializeComponent();


            // Đặt kích thước của form
            this.ClientSize = new Size(1848, 856);

            // Căn giữa form khi mở
            this.StartPosition = FormStartPosition.CenterScreen;

            //Kích thước cửa sổ không thay đổi
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;

            initSubMenu();
            this.username = username;
            lb_Welcome.Text = "Xin chào: " + username;
            this.maNhanVien = maNhanVien;
            uc_TaiKhoan1.loadThongTinHoTen(tenNhanVien);
            tenNV = tenNhanVien;
            uc_TaiKhoan1.loadThongTinChucVu(chucVu);

            mnu_QLNguoiDung.IsMainMenu = true;
            mnu_QLNguoiDung.PrimaryColor = Color.FromArgb(179, 2, 37);
            mnu_QLNguoiDung.MenuItemTextColor = Color.Black;
            mnu_QLNguoiDung.MenuItemHeight = 40;
            mnu_QLNguoiDung.Closed += Menu_Closed;

            phanQuyenBUL = new PhanQuyenBUL();

            ApplyPermissions();
        }

        #region MenuForm
        public void initSubMenu()
        {
            pnel_SubMenu.Visible = false;
        }

        public void anSubMenu()
        {
            if (pnel_SubMenu.Visible == true)
            {
                pnel_SubMenu.Visible = false;
            }
        }

        public void hienSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                anSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnel_Right.Controls.Add(childForm);
            pnel_Right.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void disableButton()
        {
            if (currentButton != null)
            {
                currentButton.OnPressedState.FillColor = Color.FromArgb(220, 20, 60); // Màu mặc định
                currentButton.OnPressedState.ForeColor = Color.White;
                currentButton.OnIdleState.FillColor = Color.FromArgb(220, 20, 60); // Màu mặc định
                currentButton.OnIdleState.ForeColor = Color.White;
            }
        }

        public void activeButton(object sender)
        {
            if (sender != null)
            {
                BunifuButton clickedButton = (BunifuButton)sender;

                if (currentButton != clickedButton)
                {
                    disableButton();
                    currentButton = clickedButton;
                    Color color = Color.FromArgb(179, 2, 37); // Màu đã chọn
                    currentButton.OnPressedState.FillColor = color;
                    currentButton.OnPressedState.ForeColor = Color.White;
                    currentButton.OnIdleState.FillColor = color;
                    currentButton.OnIdleState.ForeColor = Color.White;
                }
                else
                {
                    disableButton();
                    currentButton = null; // Reset currentButton
                }
            }
        }


        #endregion

        private void SetButtonSelected(BunifuButton button)
        {
            if (currentSelectedButton != null && currentSelectedButton != button)
            {
                currentSelectedButton.BackColor = Color.Transparent;
            }

            button.BackColor = Color.FromArgb(179, 2, 37);
            currentSelectedButton = button;
        }



        private void Menu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (currentSelectedButton != null)
            {
                currentSelectedButton.BackColor = Color.Transparent;
                currentSelectedButton = null;
            }
        }


        private void ApplyPermissions()
        {
            List<string> nhomChucVu = new ChucVuBUL().layMaChucVuTheoTenDangNhap(username);
            foreach (string item in nhomChucVu)
            {
                DataTable dsQuyen = phanQuyenBUL.layDanhSachQuyen(item);
                //Lưu danh sách mã màn hình vào List

                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(mnu_QLNguoiDung.Items, mh[1].ToString(), Convert.ToBoolean(mh[2]));
                    FindButtonPhanQuyen(mh[1].ToString(), Convert.ToBoolean(mh[2]));
                }
            }
        }

        private void FindMenuPhanQuyen(ToolStripItemCollection menuItems, string pScreeName, bool pEnable)
        {
            foreach (ToolStripMenuItem menu in menuItems)
            {
                if (menu is ToolStripMenuItem && ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems, pScreeName, pEnable);
                    menu.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreeName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }

        //private void FindButtonPhanQuyen(string pScreeName, bool pEnable)
        //{
        //    // Dò trên pnl_Left (Menu) để tìm button
        //    foreach (Control control in pnel_Left.Controls)
        //    {
        //        if (control is BunifuButton button && string.Equals(pScreeName, button.Tag))
        //        {
        //            button.Enabled = pEnable;
        //            button.Visible = pEnable;
        //        }

        //        // Dò trên subMenu để tìm button
        //        foreach (Control subControl in pnel_SubMenu.Controls)
        //        {
        //            if (subControl is BunifuButton subButton && string.Equals(pScreeName, subButton.Tag))
        //            {
        //                subButton.Enabled = pEnable;
        //                subButton.Visible = pEnable;
        //            }
        //        }
        //    }

        //}


        private void FindButtonPhanQuyen(string pScreeName, bool pEnable)
        {
            // Dò trên pnl_Left (Menu) để tìm button
            foreach (Control control in pnel_Left.Controls)
            {
                if (control is BunifuButton button && string.Equals(pScreeName, button.Tag))
                {
                    button.Enabled = pEnable;
                    button.Visible = pEnable;
                }
            }

            // Duyệt tất cả các cấp trong pnel_SubMenu
            SetButtonVisibilityRecursive(pnel_SubMenu, pScreeName, pEnable);
        }

        // Hàm đệ quy để duyệt tất cả các cấp con trong pnel_SubMenu
        private void SetButtonVisibilityRecursive(Control parent, string pScreeName, bool pEnable)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is BunifuButton button && string.Equals(pScreeName, button.Tag))
                {
                    button.Enabled = pEnable;
                    button.Visible = pEnable;
                }

                // Nếu control có con, duyệt đệ quy
                if (control.HasChildren)
                {
                    SetButtonVisibilityRecursive(control, pScreeName, pEnable);
                }
            }
        }


        private bool CheckAllMenuChildVisible(ToolStripItemCollection menuItems)
        {
            foreach (ToolStripMenuItem menuItem in menuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }

            return false;
        }

        private void btn_QuanLy_Click(object sender, System.EventArgs e)
        {
            hienSubMenu(pnel_SubMenu);
            activeButton(sender);
        }

        private void btn_QuanLyNhanVien_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLNhanVien());
            activeButton(sender);
            anSubMenu();
        }

        private void btn_DangXuat_Click(object sender, System.EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Form form = new frm_DangNhap();
                form.Show();
                this.Hide();
            }
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dialog == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            Application.Exit();


        }

        private void btn_QuanLyLichChieu_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLLichChieu());
            activeButton(sender);
            //anSubMenu();
        }

        private void frm_Main_Load(object sender, System.EventArgs e)
        {
        }

        private void btn_QuanLyPhim_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLPhim());
            activeButton(sender);
            //anSubMenu();
        }

        private void btn_QuanLyLoaiPhim_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLLoaiPhim());
            activeButton(sender);
            //anSubMenu();
        }

        private void btn_QuanLyPhongChieu_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLPhongChieu());
            activeButton(sender);
            //anSubMenu();
        }

        private void btn_QuanLyVe_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLBanVe(username, maNhanVien));
            activeButton(sender);
        }

        private void btn_QuanLyDichVu_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLDichVu());
            activeButton(sender);
        }

        private void btn_QuanLyKhachHang_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLKhachHang());
            activeButton(sender);
            anSubMenu();
        }

        private void btn_QuanLyNguoiDung_Click(object sender, System.EventArgs e)
        {
            mnu_QLNguoiDung.Show(btn_QuanLyNguoiDung, btn_QuanLyNguoiDung.Width, 0);
            SetButtonSelected(btn_QuanLyNguoiDung);
            anSubMenu();
        }

        private void btn_KhuyenMai_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_QLKhuyenMai());
            activeButton(sender);
        }

        private void btn_ThongKe_Click(object sender, System.EventArgs e)
        {
            openChildForm(new frm_ThongKe(tenNV));
            activeButton(sender);
            anSubMenu();
        }

        private void btn_QLKhuyenMai_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QLKhuyenMai());
            activeButton(sender);
        }

        private void qLTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QLTaiKhoan());
        }

        private void qLChucVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_ChucVu());
        }

        private void qLNhanVienChucVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QLNhanVienChucVu());
        }

        private void qLDMucManHinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QLManHinh());
        }

        private void qLPhanQuyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_PhanQuyen());
        }
    }
}
