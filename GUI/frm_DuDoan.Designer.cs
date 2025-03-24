namespace GUI
{
    partial class frm_DuDoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_tranning = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_phim = new System.Windows.Forms.Label();
            this.btn_Predict = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiPhim = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTuoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tranning)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_tranning);
            this.groupBox1.Location = new System.Drawing.Point(12, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(765, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // dgv_tranning
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_tranning.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tranning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_tranning.ColumnHeadersHeight = 25;
            this.dgv_tranning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_tranning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tuoi,
            this.TenLoaiPhim,
            this.TenPhim});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tranning.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_tranning.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_tranning.Location = new System.Drawing.Point(6, 27);
            this.dgv_tranning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_tranning.Name = "dgv_tranning";
            this.dgv_tranning.RowHeadersVisible = false;
            this.dgv_tranning.RowHeadersWidth = 51;
            this.dgv_tranning.RowTemplate.Height = 24;
            this.dgv_tranning.Size = new System.Drawing.Size(744, 278);
            this.dgv_tranning.TabIndex = 8;
            this.dgv_tranning.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tranning.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_tranning.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_tranning.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_tranning.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_tranning.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tranning.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_tranning.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_tranning.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_tranning.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_tranning.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_tranning.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_tranning.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_tranning.ThemeStyle.ReadOnly = false;
            this.dgv_tranning.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tranning.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tranning.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_tranning.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_tranning.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_tranning.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_tranning.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Tuoi
            // 
            this.Tuoi.DataPropertyName = "Tuoi";
            this.Tuoi.HeaderText = "Tuổi";
            this.Tuoi.MinimumWidth = 8;
            this.Tuoi.Name = "Tuoi";
            // 
            // TenLoaiPhim
            // 
            this.TenLoaiPhim.DataPropertyName = "TenLoaiPhim";
            this.TenLoaiPhim.HeaderText = "Tên loại phim";
            this.TenLoaiPhim.MinimumWidth = 8;
            this.TenLoaiPhim.Name = "TenLoaiPhim";
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.MinimumWidth = 8;
            this.TenPhim.Name = "TenPhim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.guna2Button1);
            this.groupBox2.Controls.Add(this.lb_phim);
            this.groupBox2.Controls.Add(this.btn_Predict);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLoaiPhim);
            this.groupBox2.Controls.Add(this.txtTuoi);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(765, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prediction";
            // 
            // lb_phim
            // 
            this.lb_phim.AutoSize = true;
            this.lb_phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phim.Location = new System.Drawing.Point(163, 222);
            this.lb_phim.Name = "lb_phim";
            this.lb_phim.Size = new System.Drawing.Size(64, 25);
            this.lb_phim.TabIndex = 7;
            this.lb_phim.Text = "Phim";
            // 
            // btn_Predict
            // 
            this.btn_Predict.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Predict.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Predict.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Predict.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Predict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Predict.ForeColor = System.Drawing.Color.White;
            this.btn_Predict.Location = new System.Drawing.Point(548, 111);
            this.btn_Predict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Predict.Name = "btn_Predict";
            this.btn_Predict.Size = new System.Drawing.Size(202, 56);
            this.btn_Predict.TabIndex = 6;
            this.btn_Predict.Text = "Dự đoán";
            this.btn_Predict.Click += new System.EventHandler(this.btn_Predict_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sở thích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tuổi";
            // 
            // txtLoaiPhim
            // 
            this.txtLoaiPhim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiPhim.DefaultText = "";
            this.txtLoaiPhim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoaiPhim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoaiPhim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiPhim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiPhim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiPhim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoaiPhim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiPhim.Location = new System.Drawing.Point(157, 122);
            this.txtLoaiPhim.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLoaiPhim.Name = "txtLoaiPhim";
            this.txtLoaiPhim.PasswordChar = '\0';
            this.txtLoaiPhim.PlaceholderText = "";
            this.txtLoaiPhim.SelectedText = "";
            this.txtLoaiPhim.Size = new System.Drawing.Size(339, 45);
            this.txtLoaiPhim.TabIndex = 1;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTuoi.DefaultText = "";
            this.txtTuoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTuoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTuoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTuoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTuoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTuoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTuoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTuoi.Location = new System.Drawing.Point(157, 39);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.PasswordChar = '\0';
            this.txtTuoi.PlaceholderText = "";
            this.txtTuoi.SelectedText = "";
            this.txtTuoi.Size = new System.Drawing.Size(339, 45);
            this.txtTuoi.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(548, 39);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(202, 56);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "LoadDB";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frm_DuDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DuDoan";
            this.Text = "frm_DuDoan";
            this.Load += new System.EventHandler(this.frm_DuDoan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tranning)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtLoaiPhim;
        private Guna.UI2.WinForms.Guna2TextBox txtTuoi;
        private Guna.UI2.WinForms.Guna2Button btn_Predict;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_tranning;
        private System.Windows.Forms.Label lb_phim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}