using ClosedXML.Excel;
using QuanLyBanHang.Data;
using QuanLyBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanHang.Forms
{
    public partial class frmSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã sản phẩm (dùng cho Sửa và Xóa)
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Images");
        //string imagesFolder = Path.Combine(Application.StartupPath,"Images");


        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }
        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHang";
        }
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HoangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh
            }).ToList();
            BindingSource bindingSource = new BindingSource();

            dataGridView.Columns["HinhAnh"].ValueType = typeof(Image);
            ((DataGridViewImageColumn)dataGridView.Columns["HinhAnh"])
                .ImageLayout = DataGridViewImageCellLayout.Zoom;


            dataGridView.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["DonGia"].DefaultCellStyle.Format = "N0";

            dataGridView.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["SoLuong"].DefaultCellStyle.Format = "N0";


            bindingSource.DataSource = sp;
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
            dataGridView.DataSource = bindingSource;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null && e.Value is string)
            {
                string path = Path.Combine(imagesFolder, e.Value.ToString());

                if (File.Exists(path))
                {
                    Image image = Image.FromFile(path);
                    image = new Bitmap(image, 24, 24);
                    e.Value = image;
                    e.FormattingApplied = true;
                }
            }
            /**if (dataGridView.Columns[e.ColumnIndex].Name != "HinhAnh")
                return;

            string fileName = dataGridView.Rows[e.RowIndex].Cells["HinhAnh"].Value?.ToString();

            if (string.IsNullOrEmpty(fileName))
                return;

            string path = Path.Combine(imagesFolder, fileName);
            if (!File.Exists(path))
                return;

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var img = Image.FromStream(fs))
            {
                e.Value = new Bitmap(img, 24, 24);
            }

            e.FormattingApplied = true;**/

        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();
                    // Tương tự với các form đã thực hiện
                    context.SaveChanges();
                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        // Tương tự với các form đã thực hiện
                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName.GenerateSlug() + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                sp.HinhAnh = fileName.GenerateSlug() + ext;
                context.SanPham.Update(sp);
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnXoayAnh_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
                return;

            var item = dataGridView.CurrentRow.DataBoundItem as DanhSachSanPham;
            if (item == null || string.IsNullOrEmpty(item.HinhAnh))
                return;

            string path = Path.Combine(imagesFolder, item.HinhAnh);
            if (!File.Exists(path))
                return;

            using (Bitmap bmp = new Bitmap(path))
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                bmp.Save(path);
            }

            picHinhAnh.ImageLocation = path;
            dataGridView.Refresh();
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
                return;

            var item = dataGridView.CurrentRow.DataBoundItem as DanhSachSanPham;
            if (item == null || string.IsNullOrEmpty(item.HinhAnh))
                return;

            string path = Path.Combine(imagesFolder, item.HinhAnh);
            if (File.Exists(path))
                File.Delete(path);

            int id = item.ID;
            var sp = context.SanPham.Find(id);
            if (sp != null)
            {
                sp.HinhAnh = null;
                context.SaveChanges();
            }

            picHinhAnh.Image = null;
            frmSanPham_Load(sender, e);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                SanPham sp = new SanPham();
                                sp.TenSanPham = r["TenSanPham"].ToString();
                                context.SanPham.Add(sp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmSanPham_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[6] {
                    new DataColumn("TenLoai", typeof(string)),
                    new DataColumn("TenHangSanXuat", typeof(string)),
                    new DataColumn("TenSanPham", typeof(string)),
                    new DataColumn("SoLuong", typeof(int)),
                    new DataColumn("DonGia", typeof(int)),
                    new DataColumn("HinhAnh", typeof(string))
                    });
                    var sp = context.SanPham.ToList();
                    if (sp != null)
                    {
                        foreach (var p in sp)
                            table.Rows.Add(p.ID, p.TenSanPham);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "TenSanPham");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
