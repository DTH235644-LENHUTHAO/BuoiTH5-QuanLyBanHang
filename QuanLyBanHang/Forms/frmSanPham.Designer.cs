namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            groupBox1 = new GroupBox();
            btnXoaAnh = new Button();
            btnThemAnh = new Button();
            btnXoayAnh = new Button();
            txtTimKiem = new TextBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            txtMoTa = new TextBox();
            txtTenSanPham = new TextBox();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            TenLoai = new DataGridViewTextBoxColumn();
            HangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaAnh);
            groupBox1.Controls.Add(btnThemAnh);
            groupBox1.Controls.Add(btnXoayAnh);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1138, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnXoaAnh
            // 
            btnXoaAnh.Location = new Point(892, 176);
            btnXoaAnh.Name = "btnXoaAnh";
            btnXoaAnh.Size = new Size(95, 39);
            btnXoaAnh.TabIndex = 26;
            btnXoaAnh.Text = "Xoá";
            btnXoaAnh.UseVisualStyleBackColor = true;
            btnXoaAnh.Click += btnXoaAnh_Click;
            // 
            // btnThemAnh
            // 
            btnThemAnh.Location = new Point(892, 128);
            btnThemAnh.Name = "btnThemAnh";
            btnThemAnh.Size = new Size(95, 39);
            btnThemAnh.TabIndex = 25;
            btnThemAnh.Text = "Thêm";
            btnThemAnh.UseVisualStyleBackColor = true;
            // 
            // btnXoayAnh
            // 
            btnXoayAnh.Location = new Point(892, 83);
            btnXoayAnh.Name = "btnXoayAnh";
            btnXoayAnh.Size = new Size(95, 39);
            btnXoayAnh.TabIndex = 24;
            btnXoayAnh.Text = "Xoay";
            btnXoayAnh.UseVisualStyleBackColor = true;
            btnXoayAnh.Click += btnXoayAnh_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(892, 221);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(226, 27);
            txtTimKiem.TabIndex = 23;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1020, 277);
            btnXuat.Margin = new Padding(3, 4, 3, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(86, 31);
            btnXuat.TabIndex = 22;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(901, 277);
            btnNhap.Margin = new Padding(3, 4, 3, 4);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(86, 31);
            btnNhap.TabIndex = 21;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(783, 277);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 31);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(664, 277);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(540, 277);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(86, 31);
            btnHuyBo.TabIndex = 15;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(414, 277);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(285, 277);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(152, 277);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 277);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(892, 42);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(95, 39);
            btnDoiAnh.TabIndex = 13;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(676, 42);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(194, 206);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 12;
            picHinhAnh.TabStop = false;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(512, 105);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(140, 27);
            numDonGia.TabIndex = 11;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(512, 42);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(140, 27);
            numSoLuong.TabIndex = 10;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 105);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 9;
            label6.Text = "Đơn giá (*)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 45);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 8;
            label5.Text = "Số lượng (*)";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(187, 221);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(465, 27);
            txtMoTa.TabIndex = 7;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(187, 158);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(465, 27);
            txtTenSanPham.TabIndex = 6;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(187, 102);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(195, 28);
            cboHangSanXuat.TabIndex = 5;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(187, 42);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(195, 28);
            cboLoaiSanPham.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 228);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 3;
            label4.Text = "Mô tả sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 165);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm (*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 102);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Hãng sản xuất (*)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 45);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 380);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1138, 292);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenLoai, HangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1132, 266);
            dataGridView.TabIndex = 0;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // HangSanXuat
            // 
            HangSanXuat.DataPropertyName = "TenHangSanXuat";
            HangSanXuat.HeaderText = "Hãng sản xuất";
            HangSanXuat.MinimumWidth = 6;
            HangSanXuat.Name = "HangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 684);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTenSanPham;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numSoLuong;
        private Label label6;
        private Label label5;
        private TextBox txtMoTa;
        private NumericUpDown numDonGia;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private Button btnXoaAnh;
        private Button btnThemAnh;
        private Button btnXoayAnh;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn HangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}