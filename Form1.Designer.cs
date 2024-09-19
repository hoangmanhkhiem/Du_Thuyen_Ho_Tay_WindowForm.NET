namespace DuThuyenHoTay
{
    partial class FormDatTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer thanhPhan = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (thanhPhan != null))
            {
                thanhPhan.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nhomNhapThongTin = new System.Windows.Forms.GroupBox();
            this.lblTienKyHieu = new System.Windows.Forms.Label();
            this.lblGiaKyHieu = new System.Windows.Forms.Label();
            this.radioTourNuaNgay = new System.Windows.Forms.RadioButton();
            this.radioTourCaNgay = new System.Windows.Forms.RadioButton();
            this.txtGiaTour = new System.Windows.Forms.TextBox();
            this.txtHoTenKhach = new System.Windows.Forms.TextBox();
            this.comboBoxSoLuongKhach = new System.Windows.Forms.ComboBox();
            this.comboBoxChonDoUong = new System.Windows.Forms.ComboBox();
            this.txtTienThanhToan = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVaoDanhSach = new System.Windows.Forms.Button();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblSoLuongKhach = new System.Windows.Forms.Label();
            this.lblDoUong = new System.Windows.Forms.Label();
            this.lblGiaTour = new System.Windows.Forms.Label();
            this.lblHoTenKhach = new System.Windows.Forms.Label();
            this.nhomDanhSachKhachHang = new System.Windows.Forms.GroupBox();
            this.txtDanhSachKhach = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.nhomNhapThongTin.SuspendLayout();
            this.nhomDanhSachKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhomNhapThongTin
            // 
            this.nhomNhapThongTin.Controls.Add(this.lblTienKyHieu);
            this.nhomNhapThongTin.Controls.Add(this.lblGiaKyHieu);
            this.nhomNhapThongTin.Controls.Add(this.radioTourNuaNgay);
            this.nhomNhapThongTin.Controls.Add(this.radioTourCaNgay);
            this.nhomNhapThongTin.Controls.Add(this.txtGiaTour);
            this.nhomNhapThongTin.Controls.Add(this.txtHoTenKhach);
            this.nhomNhapThongTin.Controls.Add(this.comboBoxSoLuongKhach);
            this.nhomNhapThongTin.Controls.Add(this.comboBoxChonDoUong);
            this.nhomNhapThongTin.Controls.Add(this.txtTienThanhToan);
            this.nhomNhapThongTin.Controls.Add(this.btnThemMoi);
            this.nhomNhapThongTin.Controls.Add(this.btnThemVaoDanhSach);
            this.nhomNhapThongTin.Controls.Add(this.lblTien);
            this.nhomNhapThongTin.Controls.Add(this.lblSoLuongKhach);
            this.nhomNhapThongTin.Controls.Add(this.lblDoUong);
            this.nhomNhapThongTin.Controls.Add(this.lblGiaTour);
            this.nhomNhapThongTin.Controls.Add(this.lblHoTenKhach);
            this.nhomNhapThongTin.Location = new System.Drawing.Point(28, 54);
            this.nhomNhapThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.nhomNhapThongTin.Name = "nhomNhapThongTin";
            this.nhomNhapThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.nhomNhapThongTin.Size = new System.Drawing.Size(521, 487);
            this.nhomNhapThongTin.TabIndex = 0;
            this.nhomNhapThongTin.TabStop = false;
            this.nhomNhapThongTin.Text = "Nhập Thông Tin Khách Hàng Đặt Tour";
            // 
            // lblTienKyHieu
            // 
            this.lblTienKyHieu.AutoSize = true;
            this.lblTienKyHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienKyHieu.Location = new System.Drawing.Point(262, 354);
            this.lblTienKyHieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienKyHieu.Name = "lblTienKyHieu";
            this.lblTienKyHieu.Size = new System.Drawing.Size(18, 20);
            this.lblTienKyHieu.TabIndex = 6;
            this.lblTienKyHieu.Text = "$";
            // 
            // lblGiaKyHieu
            // 
            this.lblGiaKyHieu.AutoSize = true;
            this.lblGiaKyHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaKyHieu.Location = new System.Drawing.Point(328, 162);
            this.lblGiaKyHieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaKyHieu.Name = "lblGiaKyHieu";
            this.lblGiaKyHieu.Size = new System.Drawing.Size(18, 20);
            this.lblGiaKyHieu.TabIndex = 6;
            this.lblGiaKyHieu.Text = "$";
            // 
            // radioTourNuaNgay
            // 
            this.radioTourNuaNgay.AutoSize = true;
            this.radioTourNuaNgay.Location = new System.Drawing.Point(261, 98);
            this.radioTourNuaNgay.Margin = new System.Windows.Forms.Padding(4);
            this.radioTourNuaNgay.Name = "radioTourNuaNgay";
            this.radioTourNuaNgay.Size = new System.Drawing.Size(89, 20);
            this.radioTourNuaNgay.TabIndex = 5;
            this.radioTourNuaNgay.TabStop = true;
            this.radioTourNuaNgay.Tag = "100";
            this.radioTourNuaNgay.Text = "Nửa Ngày";
            this.radioTourNuaNgay.UseVisualStyleBackColor = true;
            this.radioTourNuaNgay.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioTourCaNgay
            // 
            this.radioTourCaNgay.AutoSize = true;
            this.radioTourCaNgay.Location = new System.Drawing.Point(39, 98);
            this.radioTourCaNgay.Margin = new System.Windows.Forms.Padding(4);
            this.radioTourCaNgay.Name = "radioTourCaNgay";
            this.radioTourCaNgay.Size = new System.Drawing.Size(81, 20);
            this.radioTourCaNgay.TabIndex = 5;
            this.radioTourCaNgay.TabStop = true;
            this.radioTourCaNgay.Tag = "200";
            this.radioTourCaNgay.Text = "Cả Ngày";
            this.radioTourCaNgay.UseVisualStyleBackColor = true;
            this.radioTourCaNgay.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // txtGiaTour
            // 
            this.txtGiaTour.Location = new System.Drawing.Point(135, 159);
            this.txtGiaTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTour.Name = "txtGiaTour";
            this.txtGiaTour.ReadOnly = true;
            this.txtGiaTour.Size = new System.Drawing.Size(184, 22);
            this.txtGiaTour.TabIndex = 4;
            // 
            // txtHoTenKhach
            // 
            this.txtHoTenKhach.Location = new System.Drawing.Point(135, 42);
            this.txtHoTenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenKhach.Name = "txtHoTenKhach";
            this.txtHoTenKhach.Size = new System.Drawing.Size(223, 22);
            this.txtHoTenKhach.TabIndex = 4;
            // 
            // comboBoxSoLuongKhach
            // 
            this.comboBoxSoLuongKhach.FormattingEnabled = true;
            this.comboBoxSoLuongKhach.Location = new System.Drawing.Point(197, 251);
            this.comboBoxSoLuongKhach.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSoLuongKhach.Name = "comboBoxSoLuongKhach";
            this.comboBoxSoLuongKhach.Size = new System.Drawing.Size(112, 24);
            this.comboBoxSoLuongKhach.TabIndex = 3;
            this.comboBoxSoLuongKhach.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxChonDoUong
            // 
            this.comboBoxChonDoUong.FormattingEnabled = true;
            this.comboBoxChonDoUong.Location = new System.Drawing.Point(25, 251);
            this.comboBoxChonDoUong.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChonDoUong.Name = "comboBoxChonDoUong";
            this.comboBoxChonDoUong.Size = new System.Drawing.Size(137, 24);
            this.comboBoxChonDoUong.TabIndex = 3;
            this.comboBoxChonDoUong.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // txtTienThanhToan
            // 
            this.txtTienThanhToan.Location = new System.Drawing.Point(25, 352);
            this.txtTienThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThanhToan.Name = "txtTienThanhToan";
            this.txtTienThanhToan.ReadOnly = true;
            this.txtTienThanhToan.Size = new System.Drawing.Size(229, 22);
            this.txtTienThanhToan.TabIndex = 2;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(279, 421);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(164, 36);
            this.btnThemMoi.TabIndex = 1;
            this.btnThemMoi.Text = "Reset";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVaoDanhSach
            // 
            this.btnThemVaoDanhSach.Location = new System.Drawing.Point(53, 421);
            this.btnThemVaoDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemVaoDanhSach.Name = "btnThemVaoDanhSach";
            this.btnThemVaoDanhSach.Size = new System.Drawing.Size(164, 36);
            this.btnThemVaoDanhSach.TabIndex = 1;
            this.btnThemVaoDanhSach.Text = "Thêm Vào DS";
            this.btnThemVaoDanhSach.UseVisualStyleBackColor = true;
            this.btnThemVaoDanhSach.Click += new System.EventHandler(this.btnThemTour_Click);
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(21, 320);
            this.lblTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(34, 16);
            this.lblTien.TabIndex = 0;
            this.lblTien.Text = "Tiền";
            // 
            // lblSoLuongKhach
            // 
            this.lblSoLuongKhach.AutoSize = true;
            this.lblSoLuongKhach.Location = new System.Drawing.Point(193, 217);
            this.lblSoLuongKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongKhach.Name = "lblSoLuongKhach";
            this.lblSoLuongKhach.Size = new System.Drawing.Size(85, 16);
            this.lblSoLuongKhach.TabIndex = 0;
            this.lblSoLuongKhach.Text = "Số Lượng KH";
            // 
            // lblDoUong
            // 
            this.lblDoUong.AutoSize = true;
            this.lblDoUong.Location = new System.Drawing.Point(21, 216);
            this.lblDoUong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoUong.Name = "lblDoUong";
            this.lblDoUong.Size = new System.Drawing.Size(94, 16);
            this.lblDoUong.TabIndex = 0;
            this.lblDoUong.Text = "Chọn Đồ Uống";
            // 
            // lblGiaTour
            // 
            this.lblGiaTour.AutoSize = true;
            this.lblGiaTour.Location = new System.Drawing.Point(21, 162);
            this.lblGiaTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaTour.Name = "lblGiaTour";
            this.lblGiaTour.Size = new System.Drawing.Size(96, 16);
            this.lblGiaTour.TabIndex = 0;
            this.lblGiaTour.Text = "Giá Du Thuyền";
            // 
            // lblHoTenKhach
            // 
            this.lblHoTenKhach.AutoSize = true;
            this.lblHoTenKhach.Location = new System.Drawing.Point(35, 46);
            this.lblHoTenKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTenKhach.Name = "lblHoTenKhach";
            this.lblHoTenKhach.Size = new System.Drawing.Size(73, 16);
            this.lblHoTenKhach.TabIndex = 0;
            this.lblHoTenKhach.Text = "Họ Tên KH";
            // 
            // nhomDanhSachKhachHang
            // 
            this.nhomDanhSachKhachHang.Controls.Add(this.txtDanhSachKhach);
            this.nhomDanhSachKhachHang.Location = new System.Drawing.Point(573, 71);
            this.nhomDanhSachKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.nhomDanhSachKhachHang.Name = "nhomDanhSachKhachHang";
            this.nhomDanhSachKhachHang.Padding = new System.Windows.Forms.Padding(4);
            this.nhomDanhSachKhachHang.Size = new System.Drawing.Size(477, 384);
            this.nhomDanhSachKhachHang.TabIndex = 0;
            this.nhomDanhSachKhachHang.TabStop = false;
            this.nhomDanhSachKhachHang.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // txtDanhSachKhach
            // 
            this.txtDanhSachKhach.Location = new System.Drawing.Point(8, 25);
            this.txtDanhSachKhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtDanhSachKhach.Multiline = true;
            this.txtDanhSachKhach.Name = "txtDanhSachKhach";
            this.txtDanhSachKhach.ReadOnly = true;
            this.txtDanhSachKhach.Size = new System.Drawing.Size(460, 351);
            this.txtDanhSachKhach.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(943, 498);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormDatTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.nhomDanhSachKhachHang);
            this.Controls.Add(this.nhomNhapThongTin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDatTour";
            this.Text = "Công Ty Du Thuyền Hồ Tây";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listenKeyPress);
            this.nhomNhapThongTin.ResumeLayout(false);
            this.nhomNhapThongTin.PerformLayout();
            this.nhomDanhSachKhachHang.ResumeLayout(false);
            this.nhomDanhSachKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox nhomNhapThongTin;
        private System.Windows.Forms.GroupBox nhomDanhSachKhachHang;
        private System.Windows.Forms.TextBox txtTienThanhToan;
        private System.Windows.Forms.Button btnThemVaoDanhSach;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblSoLuongKhach;
        private System.Windows.Forms.Label lblDoUong;
        private System.Windows.Forms.Label lblGiaTour;
        private System.Windows.Forms.Label lblHoTenKhach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox comboBoxSoLuongKhach;
        private System.Windows.Forms.ComboBox comboBoxChonDoUong;
        private System.Windows.Forms.RadioButton radioTourNuaNgay;
        private System.Windows.Forms.RadioButton radioTourCaNgay;
        private System.Windows.Forms.TextBox txtGiaTour;
        private System.Windows.Forms.TextBox txtHoTenKhach;
        private System.Windows.Forms.TextBox txtDanhSachKhach;
        private System.Windows.Forms.Label lblGiaKyHieu;
        private System.Windows.Forms.Label lblTienKyHieu;
        private System.Windows.Forms.Button btnThemMoi;
    }
}
