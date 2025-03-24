namespace GUI
{
    partial class frm_PhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_CoQuyen = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbo_TenManHinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_TenChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CoQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_DSPhanQuyen = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhanQuyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(511, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 34);
            this.label1.TabIndex = 201;
            this.label1.Text = "QUẢN LÝ PHÂN QUYỀN";
            // 
            // cb_CoQuyen
            // 
            this.cb_CoQuyen.AutoSize = true;
            this.cb_CoQuyen.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CoQuyen.CheckedState.BorderRadius = 0;
            this.cb_CoQuyen.CheckedState.BorderThickness = 0;
            this.cb_CoQuyen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CoQuyen.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CoQuyen.Location = new System.Drawing.Point(49, 171);
            this.cb_CoQuyen.Name = "cb_CoQuyen";
            this.cb_CoQuyen.Size = new System.Drawing.Size(107, 26);
            this.cb_CoQuyen.TabIndex = 16;
            this.cb_CoQuyen.Text = "Có quyền";
            this.cb_CoQuyen.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_CoQuyen.UncheckedState.BorderRadius = 0;
            this.cb_CoQuyen.UncheckedState.BorderThickness = 0;
            this.cb_CoQuyen.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbo_TenManHinh
            // 
            this.cbo_TenManHinh.BackColor = System.Drawing.Color.Transparent;
            this.cbo_TenManHinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_TenManHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenManHinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_TenManHinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_TenManHinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_TenManHinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_TenManHinh.ItemHeight = 30;
            this.cbo_TenManHinh.Location = new System.Drawing.Point(215, 103);
            this.cbo_TenManHinh.Name = "cbo_TenManHinh";
            this.cbo_TenManHinh.Size = new System.Drawing.Size(315, 36);
            this.cbo_TenManHinh.TabIndex = 15;
            // 
            // cbo_TenChucVu
            // 
            this.cbo_TenChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbo_TenChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_TenChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_TenChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_TenChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_TenChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_TenChucVu.ItemHeight = 30;
            this.cbo_TenChucVu.Location = new System.Drawing.Point(215, 30);
            this.cbo_TenChucVu.Name = "cbo_TenChucVu";
            this.cbo_TenChucVu.Size = new System.Drawing.Size(315, 36);
            this.cbo_TenChucVu.TabIndex = 14;
            // 
            // CoQuyen
            // 
            this.CoQuyen.DataPropertyName = "CoQuyen";
            this.CoQuyen.HeaderText = "Có quyền";
            this.CoQuyen.MinimumWidth = 6;
            this.CoQuyen.Name = "CoQuyen";
            this.CoQuyen.ReadOnly = true;
            // 
            // MaManHinh
            // 
            this.MaManHinh.DataPropertyName = "MaManHinh";
            this.MaManHinh.HeaderText = "Mã màn hình";
            this.MaManHinh.MinimumWidth = 6;
            this.MaManHinh.Name = "MaManHinh";
            this.MaManHinh.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.cb_CoQuyen);
            this.groupBox2.Controls.Add(this.cbo_TenManHinh);
            this.groupBox2.Controls.Add(this.cbo_TenChucVu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(355, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 230);
            this.groupBox2.TabIndex = 208;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên màn hình";
            // 
            // dgv_DSPhanQuyen
            // 
            this.dgv_DSPhanQuyen.AllowUserToAddRows = false;
            this.dgv_DSPhanQuyen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_DSPhanQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSPhanQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSPhanQuyen.ColumnHeadersHeight = 20;
            this.dgv_DSPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaManHinh,
            this.MaChucVu,
            this.CoQuyen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSPhanQuyen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DSPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSPhanQuyen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DSPhanQuyen.Location = new System.Drawing.Point(3, 22);
            this.dgv_DSPhanQuyen.Name = "dgv_DSPhanQuyen";
            this.dgv_DSPhanQuyen.ReadOnly = true;
            this.dgv_DSPhanQuyen.RowHeadersVisible = false;
            this.dgv_DSPhanQuyen.RowHeadersWidth = 51;
            this.dgv_DSPhanQuyen.RowTemplate.Height = 24;
            this.dgv_DSPhanQuyen.Size = new System.Drawing.Size(1096, 168);
            this.dgv_DSPhanQuyen.TabIndex = 0;
            this.dgv_DSPhanQuyen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DSPhanQuyen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DSPhanQuyen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DSPhanQuyen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DSPhanQuyen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DSPhanQuyen.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DSPhanQuyen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DSPhanQuyen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DSPhanQuyen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DSPhanQuyen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_DSPhanQuyen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DSPhanQuyen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DSPhanQuyen.ThemeStyle.HeaderStyle.Height = 20;
            this.dgv_DSPhanQuyen.ThemeStyle.ReadOnly = true;
            this.dgv_DSPhanQuyen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DSPhanQuyen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DSPhanQuyen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_DSPhanQuyen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DSPhanQuyen.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_DSPhanQuyen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DSPhanQuyen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DSPhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSPhanQuyen_CellClick);
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã chức vụ";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_DSPhanQuyen);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 193);
            this.groupBox1.TabIndex = 202;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phân quyền";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BorderRadius = 10;
            this.btn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(817, 331);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(159, 43);
            this.btn_Huy.TabIndex = 214;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Luu.BorderRadius = 10;
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(258, 331);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(159, 43);
            this.btn_Luu.TabIndex = 213;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BorderRadius = 10;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(631, 331);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(159, 43);
            this.btn_Xoa.TabIndex = 212;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BorderRadius = 10;
            this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(439, 331);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(159, 43);
            this.btn_Sua.TabIndex = 211;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BorderRadius = 10;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(80, 331);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(159, 43);
            this.btn_Them.TabIndex = 210;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 595);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PhanQuyen";
            this.Text = "frm_PhanQuyen";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhanQuyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox cb_CoQuyen;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_TenManHinh;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_TenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaManHinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DSPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Huy;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
    }
}