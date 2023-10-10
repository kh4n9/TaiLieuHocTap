
namespace Lab04
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbTTSV = new System.Windows.Forms.GroupBox();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.txtDtb = new System.Windows.Forms.TextBox();
            this.lblDtb = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.lblMssv = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(296, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý thông tin Sinh viên";
            // 
            // gbTTSV
            // 
            this.gbTTSV.Controls.Add(this.cbbKhoa);
            this.gbTTSV.Controls.Add(this.txtDtb);
            this.gbTTSV.Controls.Add(this.lblDtb);
            this.gbTTSV.Controls.Add(this.lblKhoa);
            this.gbTTSV.Controls.Add(this.txtName);
            this.gbTTSV.Controls.Add(this.lblHoTen);
            this.gbTTSV.Controls.Add(this.txtMssv);
            this.gbTTSV.Controls.Add(this.lblMssv);
            this.gbTTSV.Location = new System.Drawing.Point(29, 76);
            this.gbTTSV.Name = "gbTTSV";
            this.gbTTSV.Size = new System.Drawing.Size(301, 263);
            this.gbTTSV.TabIndex = 1;
            this.gbTTSV.TabStop = false;
            this.gbTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(108, 136);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(156, 21);
            this.cbbKhoa.TabIndex = 1;
            // 
            // txtDtb
            // 
            this.txtDtb.Location = new System.Drawing.Point(108, 188);
            this.txtDtb.Name = "txtDtb";
            this.txtDtb.Size = new System.Drawing.Size(103, 20);
            this.txtDtb.TabIndex = 0;
            this.txtDtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDtb_KeyPress);
            // 
            // lblDtb
            // 
            this.lblDtb.AutoSize = true;
            this.lblDtb.Location = new System.Drawing.Point(16, 191);
            this.lblDtb.Name = "lblDtb";
            this.lblDtb.Size = new System.Drawing.Size(48, 13);
            this.lblDtb.TabIndex = 0;
            this.lblDtb.Text = "Điểm TB";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(16, 139);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Khoa";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(16, 88);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(108, 34);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(103, 20);
            this.txtMssv.TabIndex = 0;
            this.txtMssv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMssv_KeyPress);
            // 
            // lblMssv
            // 
            this.lblMssv.AutoSize = true;
            this.lblMssv.Location = new System.Drawing.Point(16, 37);
            this.lblMssv.Name = "lblMssv";
            this.lblMssv.Size = new System.Drawing.Size(55, 13);
            this.lblMssv.TabIndex = 0;
            this.lblMssv.Text = "Mã Số SV";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(129, 345);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 22);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(198, 345);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 22);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(267, 345);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 22);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.name,
            this.khoa,
            this.dtb});
            this.dgvShow.Location = new System.Drawing.Point(337, 83);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(441, 283);
            this.dgvShow.TabIndex = 3;
            this.dgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellClick);
            // 
            // mssv
            // 
            this.mssv.HeaderText = "Mã Số SV";
            this.mssv.Name = "mssv";
            this.mssv.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Họ Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "Khoa";
            this.khoa.Name = "khoa";
            this.khoa.ReadOnly = true;
            // 
            // dtb
            // 
            this.dtb.HeaderText = "Điểm TB";
            this.dtb.Name = "dtb";
            this.dtb.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(715, 416);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(63, 22);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbTTSV);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTTSV.ResumeLayout(false);
            this.gbTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbTTSV;
        private System.Windows.Forms.TextBox txtDtb;
        private System.Windows.Forms.Label lblDtb;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.Label lblMssv;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
    }
}

