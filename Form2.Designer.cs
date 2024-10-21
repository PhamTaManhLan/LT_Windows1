namespace lab01
{
    partial class frmQuanLyKhoa
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
            this.dgvQuanLiKhoa = new System.Windows.Forms.DataGridView();
            this.grpThongTinKhoa = new System.Windows.Forms.GroupBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.txtTongGS = new System.Windows.Forms.TextBox();
            this.lblTongGS = new System.Windows.Forms.Label();
            this.cmbSapXep = new System.Windows.Forms.ComboBox();
            this.lblSapXep = new System.Windows.Forms.Label();
            this.txtTongSoGS = new System.Windows.Forms.TextBox();
            this.lblTongSoGS = new System.Windows.Forms.Label();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongSoGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiKhoa)).BeginInit();
            this.grpThongTinKhoa.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanLiKhoa
            // 
            this.dgvQuanLiKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLiKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKhoa,
            this.colTenKhoa,
            this.colTongSoGS});
            this.dgvQuanLiKhoa.Location = new System.Drawing.Point(291, 92);
            this.dgvQuanLiKhoa.Name = "dgvQuanLiKhoa";
            this.dgvQuanLiKhoa.Size = new System.Drawing.Size(497, 290);
            this.dgvQuanLiKhoa.TabIndex = 0;
            this.dgvQuanLiKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLiKhoa_CellClick);
            // 
            // grpThongTinKhoa
            // 
            this.grpThongTinKhoa.Controls.Add(this.txtTongGS);
            this.grpThongTinKhoa.Controls.Add(this.lblTongGS);
            this.grpThongTinKhoa.Controls.Add(this.txtTenKhoa);
            this.grpThongTinKhoa.Controls.Add(this.lblTenKhoa);
            this.grpThongTinKhoa.Controls.Add(this.txtMaKhoa);
            this.grpThongTinKhoa.Controls.Add(this.lblMaKhoa);
            this.grpThongTinKhoa.Location = new System.Drawing.Point(40, 92);
            this.grpThongTinKhoa.Name = "grpThongTinKhoa";
            this.grpThongTinKhoa.Size = new System.Drawing.Size(232, 155);
            this.grpThongTinKhoa.TabIndex = 1;
            this.grpThongTinKhoa.TabStop = false;
            this.grpThongTinKhoa.Text = "Thông tin khoa";
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.lblSapXep);
            this.grpChucNang.Controls.Add(this.cmbSapXep);
            this.grpChucNang.Location = new System.Drawing.Point(41, 263);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(231, 66);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 351);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(121, 351);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(202, 351);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(713, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(14, 30);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(49, 13);
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(81, 27);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(131, 20);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(81, 71);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(131, 20);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(10, 74);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(53, 13);
            this.lblTenKhoa.TabIndex = 2;
            this.lblTenKhoa.Text = "Tên khoa";
            // 
            // txtTongGS
            // 
            this.txtTongGS.Location = new System.Drawing.Point(81, 115);
            this.txtTongGS.Name = "txtTongGS";
            this.txtTongGS.Size = new System.Drawing.Size(131, 20);
            this.txtTongGS.TabIndex = 5;
            // 
            // lblTongGS
            // 
            this.lblTongGS.AutoSize = true;
            this.lblTongGS.Location = new System.Drawing.Point(10, 118);
            this.lblTongGS.Name = "lblTongGS";
            this.lblTongGS.Size = new System.Drawing.Size(64, 13);
            this.lblTongGS.TabIndex = 4;
            this.lblTongGS.Text = "Tổng số GS";
            // 
            // cmbSapXep
            // 
            this.cmbSapXep.FormattingEnabled = true;
            this.cmbSapXep.Location = new System.Drawing.Point(80, 28);
            this.cmbSapXep.Name = "cmbSapXep";
            this.cmbSapXep.Size = new System.Drawing.Size(131, 21);
            this.cmbSapXep.TabIndex = 0;
            this.cmbSapXep.SelectedIndexChanged += new System.EventHandler(this.cmbSapXep_SelectedIndexChanged);
            // 
            // lblSapXep
            // 
            this.lblSapXep.AutoSize = true;
            this.lblSapXep.Location = new System.Drawing.Point(13, 31);
            this.lblSapXep.Name = "lblSapXep";
            this.lblSapXep.Size = new System.Drawing.Size(46, 13);
            this.lblSapXep.TabIndex = 6;
            this.lblSapXep.Text = "Sắp xếp";
            // 
            // txtTongSoGS
            // 
            this.txtTongSoGS.Location = new System.Drawing.Point(389, 407);
            this.txtTongSoGS.Name = "txtTongSoGS";
            this.txtTongSoGS.Size = new System.Drawing.Size(100, 20);
            this.txtTongSoGS.TabIndex = 7;
            // 
            // lblTongSoGS
            // 
            this.lblTongSoGS.AutoSize = true;
            this.lblTongSoGS.Enabled = false;
            this.lblTongSoGS.Location = new System.Drawing.Point(321, 410);
            this.lblTongSoGS.Name = "lblTongSoGS";
            this.lblTongSoGS.Size = new System.Drawing.Size(64, 13);
            this.lblTongSoGS.TabIndex = 8;
            this.lblTongSoGS.Text = "Tổng số GS";
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.Name = "colMaKhoa";
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.HeaderText = "Tên khoa";
            this.colTenKhoa.Name = "colTenKhoa";
            // 
            // colTongSoGS
            // 
            this.colTongSoGS.HeaderText = "Tổng số GS";
            this.colTongSoGS.Name = "colTongSoGS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ KHOA";
            // 
            // frmQuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTongSoGS);
            this.Controls.Add(this.txtTongSoGS);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTinKhoa);
            this.Controls.Add(this.dgvQuanLiKhoa);
            this.Name = "frmQuanLyKhoa";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmQuanLyKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiKhoa)).EndInit();
            this.grpThongTinKhoa.ResumeLayout(false);
            this.grpThongTinKhoa.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLiKhoa;
        private System.Windows.Forms.GroupBox grpThongTinKhoa;
        private System.Windows.Forms.TextBox txtTongGS;
        private System.Windows.Forms.Label lblTongGS;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.ComboBox cmbSapXep;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongSoGS;
        private System.Windows.Forms.TextBox txtTongSoGS;
        private System.Windows.Forms.Label lblTongSoGS;
        private System.Windows.Forms.Label label1;
    }
}