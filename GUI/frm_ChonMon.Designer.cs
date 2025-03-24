namespace GUI
{
    partial class frm_ChonMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.btn_TiepTuc = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ThongTinDatMon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.uc_ChonDichVu1 = new GUI.uc_ChonDichVu();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinDatMon)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Right
            // 
            this.panel_Right.AutoSize = true;
            this.panel_Right.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Right.Controls.Add(this.btn_TiepTuc);
            this.panel_Right.Controls.Add(this.label2);
            this.panel_Right.Controls.Add(this.btn_Xoa);
            this.panel_Right.Controls.Add(this.lb_TongTien);
            this.panel_Right.Controls.Add(this.label1);
            this.panel_Right.Controls.Add(this.dgv_ThongTinDatMon);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(857, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(521, 730);
            this.panel_Right.TabIndex = 2;
            // 
            // btn_TiepTuc
            // 
            this.btn_TiepTuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TiepTuc.BorderRadius = 10;
            this.btn_TiepTuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TiepTuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TiepTuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TiepTuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TiepTuc.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_TiepTuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TiepTuc.ForeColor = System.Drawing.Color.White;
            this.btn_TiepTuc.Location = new System.Drawing.Point(203, 650);
            this.btn_TiepTuc.Name = "btn_TiepTuc";
            this.btn_TiepTuc.Size = new System.Drawing.Size(159, 43);
            this.btn_TiepTuc.TabIndex = 13;
            this.btn_TiepTuc.Text = "Tiếp tục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thông tin chọn món:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BorderRadius = 10;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.Crimson;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(429, 50);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(70, 30);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.Color.Red;
            this.lb_TongTien.Location = new System.Drawing.Point(351, 603);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(64, 22);
            this.lb_TongTien.TabIndex = 10;
            this.lb_TongTien.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng tiền:";
            // 
            // dgv_ThongTinDatMon
            // 
            this.dgv_ThongTinDatMon.AllowUserToAddRows = false;
            this.dgv_ThongTinDatMon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_ThongTinDatMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_ThongTinDatMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ThongTinDatMon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongTinDatMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_ThongTinDatMon.ColumnHeadersHeight = 26;
            this.dgv_ThongTinDatMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ThongTinDatMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoAn,
            this.TenDoAn,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThongTinDatMon.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_ThongTinDatMon.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongTinDatMon.Location = new System.Drawing.Point(9, 95);
            this.dgv_ThongTinDatMon.Name = "dgv_ThongTinDatMon";
            this.dgv_ThongTinDatMon.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongTinDatMon.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_ThongTinDatMon.RowHeadersVisible = false;
            this.dgv_ThongTinDatMon.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_ThongTinDatMon.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ThongTinDatMon.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongTinDatMon.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ThongTinDatMon.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.dgv_ThongTinDatMon.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongTinDatMon.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgv_ThongTinDatMon.RowTemplate.Height = 70;
            this.dgv_ThongTinDatMon.Size = new System.Drawing.Size(503, 489);
            this.dgv_ThongTinDatMon.TabIndex = 8;
            this.dgv_ThongTinDatMon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ThongTinDatMon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_ThongTinDatMon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_ThongTinDatMon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_ThongTinDatMon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_ThongTinDatMon.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongTinDatMon.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongTinDatMon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongTinDatMon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ThongTinDatMon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_ThongTinDatMon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Red;
            this.dgv_ThongTinDatMon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ThongTinDatMon.ThemeStyle.HeaderStyle.Height = 26;
            this.dgv_ThongTinDatMon.ThemeStyle.ReadOnly = true;
            this.dgv_ThongTinDatMon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongTinDatMon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ThongTinDatMon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ThongTinDatMon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Red;
            this.dgv_ThongTinDatMon.ThemeStyle.RowsStyle.Height = 70;
            this.dgv_ThongTinDatMon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ThongTinDatMon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // MaDoAn
            // 
            this.MaDoAn.DataPropertyName = "MaDoAn";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDoAn.DefaultCellStyle = dataGridViewCellStyle9;
            this.MaDoAn.HeaderText = "Mã món";
            this.MaDoAn.MinimumWidth = 12;
            this.MaDoAn.Name = "MaDoAn";
            this.MaDoAn.ReadOnly = true;
            // 
            // TenDoAn
            // 
            this.TenDoAn.DataPropertyName = "TenDoAn";
            this.TenDoAn.HeaderText = "Tên món";
            this.TenDoAn.MinimumWidth = 6;
            this.TenDoAn.Name = "TenDoAn";
            this.TenDoAn.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.AutoSize = true;
            this.panel_Menu.Controls.Add(this.uc_ChonDichVu1);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(857, 730);
            this.panel_Menu.TabIndex = 3;
            // 
            // uc_ChonDichVu1
            // 
            this.uc_ChonDichVu1.Location = new System.Drawing.Point(3, 3);
            this.uc_ChonDichVu1.Name = "uc_ChonDichVu1";
            this.uc_ChonDichVu1.Size = new System.Drawing.Size(200, 380);
            this.uc_ChonDichVu1.TabIndex = 0;
            // 
            // frm_ChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1378, 730);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Right);
            this.Name = "frm_ChonMon";
            this.Text = "frm_ChonMon";
            this.panel_Right.ResumeLayout(false);
            this.panel_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinDatMon)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_ThongTinDatMon;
        private Guna.UI2.WinForms.Guna2Button btn_TiepTuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.FlowLayoutPanel panel_Menu;
        private uc_ChonDichVu uc_ChonDichVu1;
    }
}