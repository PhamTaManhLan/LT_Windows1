namespace lab01
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripbtnQuanLyKhoa = new System.Windows.Forms.ToolStripButton();
            this.lblQuanLyKhoa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripbtnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.lblTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblQLSV = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTongSVNam = new System.Windows.Forms.TextBox();
            this.lblTongSVNam = new System.Windows.Forms.Label();
            this.lblTongSVNu = new System.Windows.Forms.Label();
            this.txtTongSVNu = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpThongTinSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSV,
            this.colHoTen,
            this.colGioiTinh,
            this.colDiemTB,
            this.colKhoa});
            this.dgvStudent.Location = new System.Drawing.Point(263, 96);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(465, 297);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtnQuanLyKhoa,
            this.lblQuanLyKhoa,
            this.toolStripbtnTimKiem,
            this.lblTimKiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(754, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripbtnQuanLyKhoa
            // 
            this.toolStripbtnQuanLyKhoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnQuanLyKhoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnQuanLyKhoa.Image")));
            this.toolStripbtnQuanLyKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnQuanLyKhoa.Name = "toolStripbtnQuanLyKhoa";
            this.toolStripbtnQuanLyKhoa.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnQuanLyKhoa.Text = "toolStripButton1";
            this.toolStripbtnQuanLyKhoa.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblQuanLyKhoa
            // 
            this.lblQuanLyKhoa.Name = "lblQuanLyKhoa";
            this.lblQuanLyKhoa.Size = new System.Drawing.Size(77, 22);
            this.lblQuanLyKhoa.Text = "Quản lý khoa";
            // 
            // toolStripbtnTimKiem
            // 
            this.toolStripbtnTimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnTimKiem.Image")));
            this.toolStripbtnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnTimKiem.Name = "toolStripbtnTimKiem";
            this.toolStripbtnTimKiem.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnTimKiem.Text = "toolStripButton2";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(56, 22);
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // colMaSV
            // 
            this.colMaSV.HeaderText = "Mã SV";
            this.colMaSV.Name = "colMaSV";
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colDiemTB
            // 
            this.colDiemTB.HeaderText = "Điểm TB";
            this.colDiemTB.Name = "colDiemTB";
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Tên khoa";
            this.colKhoa.Name = "colKhoa";
            // 
            // grpThongTinSinhVien
            // 
            this.grpThongTinSinhVien.Controls.Add(this.cmbKhoa);
            this.grpThongTinSinhVien.Controls.Add(this.rbNu);
            this.grpThongTinSinhVien.Controls.Add(this.rbNam);
            this.grpThongTinSinhVien.Controls.Add(this.txtDiemTB);
            this.grpThongTinSinhVien.Controls.Add(this.lblDiemTB);
            this.grpThongTinSinhVien.Controls.Add(this.lblKhoa);
            this.grpThongTinSinhVien.Controls.Add(this.lblGioiTinh);
            this.grpThongTinSinhVien.Controls.Add(this.txtHoTen);
            this.grpThongTinSinhVien.Controls.Add(this.lblHoTen);
            this.grpThongTinSinhVien.Controls.Add(this.txtMaSV);
            this.grpThongTinSinhVien.Controls.Add(this.lblMaSV);
            this.grpThongTinSinhVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpThongTinSinhVien.Location = new System.Drawing.Point(23, 96);
            this.grpThongTinSinhVien.Name = "grpThongTinSinhVien";
            this.grpThongTinSinhVien.Size = new System.Drawing.Size(220, 252);
            this.grpThongTinSinhVien.TabIndex = 3;
            this.grpThongTinSinhVien.TabStop = false;
            this.grpThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaSV.Location = new System.Drawing.Point(21, 35);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(39, 13);
            this.lblMaSV.TabIndex = 4;
            this.lblMaSV.Text = "Mã SV";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(79, 32);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(135, 20);
            this.txtMaSV.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(79, 74);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(135, 20);
            this.txtHoTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHoTen.Location = new System.Drawing.Point(21, 77);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 13);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGioiTinh.Location = new System.Drawing.Point(21, 123);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKhoa.Location = new System.Drawing.Point(21, 167);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 10;
            this.lblKhoa.Text = "Khoa";
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(79, 211);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(135, 20);
            this.txtDiemTB.TabIndex = 13;
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiemTB.Location = new System.Drawing.Point(21, 214);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(48, 13);
            this.lblDiemTB.TabIndex = 12;
            this.lblDiemTB.Text = "Điểm TB";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbNam.Location = new System.Drawing.Point(79, 123);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(48, 17);
            this.rbNam.TabIndex = 14;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Male";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbNu.Location = new System.Drawing.Point(149, 123);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(59, 17);
            this.rbNu.TabIndex = 15;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Female";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(79, 164);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(135, 21);
            this.cmbKhoa.TabIndex = 16;
            // 
            // lblQLSV
            // 
            this.lblQLSV.AutoSize = true;
            this.lblQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLSV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQLSV.Location = new System.Drawing.Point(156, 49);
            this.lblQLSV.Name = "lblQLSV";
            this.lblQLSV.Size = new System.Drawing.Size(435, 31);
            this.lblQLSV.TabIndex = 4;
            this.lblQLSV.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 354);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 29);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(101, 354);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(182, 354);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTongSVNam
            // 
            this.txtTongSVNam.Enabled = false;
            this.txtTongSVNam.Location = new System.Drawing.Point(349, 407);
            this.txtTongSVNam.Name = "txtTongSVNam";
            this.txtTongSVNam.Size = new System.Drawing.Size(82, 20);
            this.txtTongSVNam.TabIndex = 8;
            // 
            // lblTongSVNam
            // 
            this.lblTongSVNam.AutoSize = true;
            this.lblTongSVNam.Location = new System.Drawing.Point(269, 410);
            this.lblTongSVNam.Name = "lblTongSVNam";
            this.lblTongSVNam.Size = new System.Drawing.Size(74, 13);
            this.lblTongSVNam.TabIndex = 9;
            this.lblTongSVNam.Text = "Tổng SV Nam";
            // 
            // lblTongSVNu
            // 
            this.lblTongSVNu.AutoSize = true;
            this.lblTongSVNu.Location = new System.Drawing.Point(447, 410);
            this.lblTongSVNu.Name = "lblTongSVNu";
            this.lblTongSVNu.Size = new System.Drawing.Size(66, 13);
            this.lblTongSVNu.TabIndex = 11;
            this.lblTongSVNu.Text = "Tổng SV Nữ";
            // 
            // txtTongSVNu
            // 
            this.txtTongSVNu.Enabled = false;
            this.txtTongSVNu.Location = new System.Drawing.Point(519, 407);
            this.txtTongSVNu.Name = "txtTongSVNu";
            this.txtTongSVNu.Size = new System.Drawing.Size(80, 20);
            this.txtTongSVNu.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(667, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 29);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTongSVNu);
            this.Controls.Add(this.txtTongSVNu);
            this.Controls.Add(this.lblTongSVNam);
            this.Controls.Add(this.txtTongSVNam);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblQLSV);
            this.Controls.Add(this.grpThongTinSinhVien);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpThongTinSinhVien.ResumeLayout(false);
            this.grpThongTinSinhVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripbtnQuanLyKhoa;
        private System.Windows.Forms.ToolStripLabel lblQuanLyKhoa;
        private System.Windows.Forms.ToolStripButton toolStripbtnTimKiem;
        private System.Windows.Forms.ToolStripLabel lblTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.GroupBox grpThongTinSinhVien;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblQLSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTongSVNam;
        private System.Windows.Forms.Label lblTongSVNam;
        private System.Windows.Forms.Label lblTongSVNu;
        private System.Windows.Forms.TextBox txtTongSVNu;
        private System.Windows.Forms.Button btnThoat;
    }
}

