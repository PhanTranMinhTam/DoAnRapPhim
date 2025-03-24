namespace GUI
{
    partial class frm_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Top5 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_SoVe = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.maKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_LoaiPhim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ThongKe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_Nam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_Thang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_Phim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_Xuat = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_TongDoanhThu = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Top5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(417, 11);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(86, 28);
            this.bunifuLabel4.TabIndex = 135;
            this.bunifuLabel4.Text = "Loại phim";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_Top5);
            this.groupBox2.Location = new System.Drawing.Point(5, 382);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(625, 204);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top 5 phim có doanh thu cao nhất";
            // 
            // dgv_Top5
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_Top5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Top5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Top5.ColumnHeadersHeight = 22;
            this.dgv_Top5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Top5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenPhim,
            this.DoanhThu});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Top5.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Top5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Top5.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Top5.Location = new System.Drawing.Point(3, 17);
            this.dgv_Top5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Top5.Name = "dgv_Top5";
            this.dgv_Top5.RowHeadersVisible = false;
            this.dgv_Top5.RowHeadersWidth = 62;
            this.dgv_Top5.RowTemplate.Height = 28;
            this.dgv_Top5.Size = new System.Drawing.Size(619, 185);
            this.dgv_Top5.TabIndex = 119;
            this.dgv_Top5.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Top5.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Top5.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Top5.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Top5.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Top5.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Top5.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Top5.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Top5.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Top5.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Top5.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Top5.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Top5.ThemeStyle.HeaderStyle.Height = 22;
            this.dgv_Top5.ThemeStyle.ReadOnly = false;
            this.dgv_Top5.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Top5.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Top5.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Top5.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Top5.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Top5.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Top5.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tenPhim
            // 
            this.tenPhim.DataPropertyName = "tenPhim";
            this.tenPhim.HeaderText = "Tên phim";
            this.tenPhim.MinimumWidth = 8;
            this.tenPhim.Name = "tenPhim";
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.HeaderText = "Doanh thu";
            this.DoanhThu.MinimumWidth = 8;
            this.DoanhThu.Name = "DoanhThu";
            // 
            // lbl_SoVe
            // 
            this.lbl_SoVe.AllowParentOverrides = false;
            this.lbl_SoVe.AutoEllipsis = false;
            this.lbl_SoVe.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_SoVe.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_SoVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoVe.Location = new System.Drawing.Point(5, 586);
            this.lbl_SoVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_SoVe.Name = "lbl_SoVe";
            this.lbl_SoVe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_SoVe.Size = new System.Drawing.Size(108, 28);
            this.lbl_SoVe.TabIndex = 133;
            this.lbl_SoVe.Text = "Số vé bán ra";
            this.lbl_SoVe.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_SoVe.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chartDoanhThu);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(639, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(753, 494);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biểu đồ doanh thu theo tháng";
            // 
            // chartDoanhThu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend2);
            this.chartDoanhThu.Location = new System.Drawing.Point(5, 22);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(742, 458);
            this.chartDoanhThu.TabIndex = 116;
            this.chartDoanhThu.Text = "chart1";
            // 
            // maKhuyenMai
            // 
            this.maKhuyenMai.DataPropertyName = "maKhuyenMai";
            this.maKhuyenMai.HeaderText = "Mã Khuyến Mãi";
            this.maKhuyenMai.MinimumWidth = 8;
            this.maKhuyenMai.Name = "maKhuyenMai";
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 8;
            this.tongTien.Name = "tongTien";
            // 
            // cbo_LoaiPhim
            // 
            this.cbo_LoaiPhim.BackColor = System.Drawing.Color.Transparent;
            this.cbo_LoaiPhim.BorderColor = System.Drawing.Color.MistyRose;
            this.cbo_LoaiPhim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_LoaiPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiPhim.FillColor = System.Drawing.Color.MistyRose;
            this.cbo_LoaiPhim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_LoaiPhim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_LoaiPhim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiPhim.ForeColor = System.Drawing.Color.Red;
            this.cbo_LoaiPhim.ItemHeight = 30;
            this.cbo_LoaiPhim.Location = new System.Drawing.Point(524, 11);
            this.cbo_LoaiPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_LoaiPhim.Name = "cbo_LoaiPhim";
            this.cbo_LoaiPhim.Size = new System.Drawing.Size(176, 36);
            this.cbo_LoaiPhim.TabIndex = 136;
            this.cbo_LoaiPhim.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiPhim_SelectedIndexChanged);
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.MinimumWidth = 8;
            this.NgayBan.Name = "NgayBan";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.MinimumWidth = 8;
            this.tenNhanVien.Name = "tenNhanVien";
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "maHD";
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.MinimumWidth = 8;
            this.maHD.Name = "maHD";
            // 
            // dgv_ThongKe
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_ThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_ThongKe.ColumnHeadersHeight = 22;
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.tenNhanVien,
            this.tenKhachHang,
            this.NgayBan,
            this.tongTien,
            this.maKhuyenMai});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThongKe.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_ThongKe.Location = new System.Drawing.Point(3, 18);
            this.dgv_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.RowHeadersVisible = false;
            this.dgv_ThongKe.RowHeadersWidth = 62;
            this.dgv_ThongKe.RowTemplate.Height = 28;
            this.dgv_ThongKe.Size = new System.Drawing.Size(617, 213);
            this.dgv_ThongKe.TabIndex = 131;
            this.dgv_ThongKe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ThongKe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_ThongKe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_ThongKe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_ThongKe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_ThongKe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ThongKe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_ThongKe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_ThongKe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ThongKe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ThongKe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_ThongKe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ThongKe.ThemeStyle.HeaderStyle.Height = 22;
            this.dgv_ThongKe.ThemeStyle.ReadOnly = false;
            this.dgv_ThongKe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ThongKe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ThongKe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ThongKe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_ThongKe.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_ThongKe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ThongKe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "Tên khách hàng";
            this.tenKhachHang.MinimumWidth = 8;
            this.tenKhachHang.Name = "tenKhachHang";
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Nam.BorderColor = System.Drawing.Color.MistyRose;
            this.cbo_Nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Nam.FillColor = System.Drawing.Color.MistyRose;
            this.cbo_Nam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Nam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Nam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Nam.ForeColor = System.Drawing.Color.Red;
            this.cbo_Nam.ItemHeight = 30;
            this.cbo_Nam.Location = new System.Drawing.Point(479, 60);
            this.cbo_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(129, 36);
            this.cbo_Nam.TabIndex = 130;
            this.cbo_Nam.SelectedIndexChanged += new System.EventHandler(this.cbo_Nam_SelectedIndexChanged);
            // 
            // cbo_Thang
            // 
            this.cbo_Thang.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Thang.BorderColor = System.Drawing.Color.MistyRose;
            this.cbo_Thang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Thang.FillColor = System.Drawing.Color.MistyRose;
            this.cbo_Thang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Thang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Thang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Thang.ForeColor = System.Drawing.Color.Red;
            this.cbo_Thang.ItemHeight = 30;
            this.cbo_Thang.Location = new System.Drawing.Point(93, 60);
            this.cbo_Thang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(131, 36);
            this.cbo_Thang.TabIndex = 129;
            this.cbo_Thang.SelectedIndexChanged += new System.EventHandler(this.cbo_Thang_SelectedIndexChanged);
            // 
            // cbo_Phim
            // 
            this.cbo_Phim.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Phim.BorderColor = System.Drawing.Color.MistyRose;
            this.cbo_Phim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Phim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Phim.FillColor = System.Drawing.Color.MistyRose;
            this.cbo_Phim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Phim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Phim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Phim.ForeColor = System.Drawing.Color.Red;
            this.cbo_Phim.ItemHeight = 30;
            this.cbo_Phim.Location = new System.Drawing.Point(90, 11);
            this.cbo_Phim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Phim.Name = "cbo_Phim";
            this.cbo_Phim.Size = new System.Drawing.Size(295, 36);
            this.cbo_Phim.TabIndex = 128;
            this.cbo_Phim.SelectedIndexChanged += new System.EventHandler(this.cbo_Phim_SelectedIndexChanged);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(420, 60);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(42, 28);
            this.bunifuLabel2.TabIndex = 127;
            this.bunifuLabel2.Text = "Năm";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BorderRadius = 10;
            this.btn_Xuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat.ForeColor = System.Drawing.Color.White;
            this.btn_Xuat.Location = new System.Drawing.Point(743, 2);
            this.btn_Xuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(203, 39);
            this.btn_Xuat.TabIndex = 125;
            this.btn_Xuat.Text = "Xuất thống kê";
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(20, 11);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(44, 28);
            this.bunifuLabel3.TabIndex = 124;
            this.bunifuLabel3.Text = "Phim";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(20, 60);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(54, 28);
            this.bunifuLabel1.TabIndex = 123;
            this.bunifuLabel1.Text = "Tháng";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_TongDoanhThu
            // 
            this.lbl_TongDoanhThu.AllowParentOverrides = false;
            this.lbl_TongDoanhThu.AutoEllipsis = false;
            this.lbl_TongDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_TongDoanhThu.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_TongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongDoanhThu.Location = new System.Drawing.Point(5, 637);
            this.lbl_TongDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_TongDoanhThu.Name = "lbl_TongDoanhThu";
            this.lbl_TongDoanhThu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TongDoanhThu.Size = new System.Drawing.Size(144, 28);
            this.lbl_TongDoanhThu.TabIndex = 126;
            this.lbl_TongDoanhThu.Text = "Tổng doanh thu:";
            this.lbl_TongDoanhThu.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TongDoanhThu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgv_ThongKe);
            this.groupBox3.Location = new System.Drawing.Point(10, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 234);
            this.groupBox3.TabIndex = 137;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn";
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 633);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_SoVe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbo_LoaiPhim);
            this.Controls.Add(this.cbo_Nam);
            this.Controls.Add(this.cbo_Thang);
            this.Controls.Add(this.cbo_Phim);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.lbl_TongDoanhThu);
            this.Name = "frm_ThongKe";
            this.Text = "frm_ThongKe";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Top5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Top5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private Bunifu.UI.WinForms.BunifuLabel lbl_SoVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_LoaiPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_ThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Nam;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Thang;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Phim;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Guna.UI2.WinForms.Guna2Button btn_Xuat;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TongDoanhThu;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}