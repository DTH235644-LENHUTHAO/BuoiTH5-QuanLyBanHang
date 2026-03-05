namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtDienThoai = new TextBox();
            label2 = new Label();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            btnHuyBo = new Button();
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            label4 = new Label();
            txtMatKhau = new TextBox();
            label5 = new Label();
            txtTenDangNhap = new TextBox();
            label6 = new Label();
            btnLuu = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(881, 107);
            btnXuat.Margin = new Padding(3, 4, 3, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(86, 31);
            btnXuat.TabIndex = 13;
            btnXuat.Text = "Xuất ...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(881, 68);
            btnNhap.Margin = new Padding(3, 4, 3, 4);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(86, 31);
            btnNhap.TabIndex = 12;
            btnNhap.Text = "Nhập ...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(881, 29);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 31);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(111, 112);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(212, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 116);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ (*):";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(111, 73);
            txtDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(212, 27);
            txtDienThoai.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 7;
            label2.Text = "Điện thoại (*):";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 24);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1000, 412);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(13, 207);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1006, 440);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hãng sản xuất";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(789, 105);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(689, 105);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(689, 28);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(111, 35);
            txtHoVaTen.Margin = new Padding(3, 4, 3, 4);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(212, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(789, 67);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(86, 31);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 19);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1006, 159);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(482, 112);
            cboQuyenHan.Margin = new Padding(3, 4, 3, 4);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(159, 28);
            cboQuyenHan.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 116);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 18;
            label4.Text = "Quyền hạn (*):";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(482, 73);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(159, 27);
            txtMatKhau.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 77);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 16;
            label5.Text = "Mật khẩu (*):";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(482, 35);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(159, 27);
            txtTenDangNhap.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 39);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 14;
            label6.Text = "Tên đăng nhập (*):";
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(789, 28);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(689, 67);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 665);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtDienThoai;
        private Label label2;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtHoVaTen;
        private Label label1;
        private Button btnHuyBo;
        private GroupBox groupBox1;
        private Button btnLuu;
        private Button btnSua;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private Label label4;
        private TextBox txtMatKhau;
        private Label label5;
        private TextBox txtTenDangNhap;
        private Label label6;
        private ComboBox cboQuyenHan;
    }
}