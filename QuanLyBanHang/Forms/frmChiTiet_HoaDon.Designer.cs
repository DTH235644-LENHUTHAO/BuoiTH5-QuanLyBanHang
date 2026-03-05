namespace QuanLyBanHang.Forms
{
    partial class frmChiTiet_HoaDon
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
            txtGhiChuHoaDon = new TextBox();
            label3 = new Label();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            cboSanPham = new ComboBox();
            label4 = new Label();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            colID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(765, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(140, 76);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(605, 27);
            txtGhiChuHoaDon.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 79);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 4;
            label3.Text = "Chi tiết hóa đơn:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(511, 32);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(234, 28);
            cboKhachHang.TabIndex = 3;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(142, 32);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(234, 28);
            cboNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 35);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng(*)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập (*)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(765, 318);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(3, 127);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(759, 188);
            dataGridView.TabIndex = 16;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(670, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 31);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(541, 71);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(123, 31);
            btnXacNhanBan.TabIndex = 13;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(225, 71);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(140, 27);
            numDonGiaBan.TabIndex = 12;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(382, 72);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(140, 27);
            numSoLuongBan.TabIndex = 11;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 37);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 8;
            label6.Text = "Số lượng bán (*)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 36);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 7;
            label5.Text = "Đơn giá bán (*)";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(16, 71);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(194, 28);
            cboSanPham.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 37);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 6;
            label4.Text = "Sản phẩm (*)";
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(216, 480);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(123, 31);
            btnLuuHoaDon.TabIndex = 17;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(345, 480);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(123, 31);
            btnInHoaDon.TabIndex = 18;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(473, 480);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 31);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // colID
            // 
            colID.DataPropertyName = "colID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            SoLuongBan.HeaderText = "Số lượng";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // frmChiTiet_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 522);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmChiTiet_HoaDon";
            Text = "Chi Tiết Hóa Đơn";
            Load += frmChiTiet_HoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtGhiChuHoaDon;
        private Label label3;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private ComboBox cboSanPham;
        private NumericUpDown numSoLuongBan;
        private NumericUpDown numDonGiaBan;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private DataGridView dataGridView;
        private Button btnLuuHoaDon;
        private Button btnInHoaDon;
        private Button btnThoat;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}