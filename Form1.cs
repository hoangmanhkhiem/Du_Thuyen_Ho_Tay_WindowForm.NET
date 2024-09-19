using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DuThuyenHoTay
{
    public partial class FormDatTour : Form
    {
        private List<Tour> DanhSachTour;

        public FormDatTour()
        {
            InitializeComponent();
            this.DanhSachTour = new List<Tour>();

            List<int> listSoLuong = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            comboBoxSoLuongKhach.DataSource = listSoLuong;

            List<DoUong> listDoUong = new List<DoUong>
            {
                new DoUong { TenDoUong = "Coca Cola", Gia = 0.5 },
                new DoUong { TenDoUong = "Pepsi", Gia = 0.8 },
                new DoUong { TenDoUong = "Seven Up", Gia = 1.0 },
            };
            comboBoxChonDoUong.DataSource = listDoUong;
            comboBoxChonDoUong.DisplayMember = "TenDoUong";

            txtDanhSachKhach.ScrollBars = ScrollBars.Both;

            this.KeyPreview = true;

            radioTourCaNgay.Checked = true;
        }
        private void listenKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            if (e.Alt && e.KeyCode == Keys.M)
            {
                txtHoTenKhach.Text = "";
                txtHoTenKhach.Focus();

                comboBoxChonDoUong.SelectedIndex = 0;
                comboBoxSoLuongKhach.SelectedIndex = 0;

                radioTourCaNgay.Checked = true;

                this.tinhTien();
            }
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            this.themTour();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                txtGiaTour.Text = radioButton.Tag.ToString();
                this.tinhTien();
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tinhTien();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtHoTenKhach.Text = "";
            txtHoTenKhach.Focus();

            comboBoxChonDoUong.SelectedIndex = 0;
            comboBoxSoLuongKhach.SelectedIndex = 0;

            radioTourCaNgay.Checked = true;

            this.tinhTien();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void themTour()
        {
            Tour tour = new Tour();
            tour.TenKhachHang = txtHoTenKhach.Text;
            tour.ThoiGian = radioTourCaNgay.Checked ? "Cả ngày" : "Nửa ngày";
            tour.GiaThuyen = double.Parse(txtGiaTour.Text);
            tour.GiaDoUong = ((DoUong)comboBoxChonDoUong.SelectedItem).Gia;
            tour.TongTien = double.Parse(txtTienThanhToan.Text);
            tour.TenDoUong = ((DoUong)comboBoxChonDoUong.SelectedItem).TenDoUong;

            if (tour.TenKhachHang == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenKhach.Focus();
                return;
            }

            this.DanhSachTour.Add(tour);
            string data = "";
            foreach (Tour _tour in DanhSachTour)
            {
                data += _tour.TenKhachHang + " | ";
                data += _tour.ThoiGian + " | ";
                data += _tour.GiaThuyen + " | ";
                data += "Đồ uống :" + _tour.TenDoUong+ " "+ _tour.GiaDoUong + "$ | ";
                data += "Tổng " + _tour.TongTien + "$";
                data += Environment.NewLine;
            }

            txtDanhSachKhach.Text = data;
        }

        private void tinhTien()
        {
            int soLuong = (int)comboBoxSoLuongKhach.SelectedItem;
            DoUong doUong = (DoUong)comboBoxChonDoUong.SelectedItem;
            int giaDuThuyen = int.Parse(txtGiaTour.Text);
            double tien = giaDuThuyen + doUong.Gia * soLuong;
            txtTienThanhToan.Text = tien.ToString();
        }
    }
}
