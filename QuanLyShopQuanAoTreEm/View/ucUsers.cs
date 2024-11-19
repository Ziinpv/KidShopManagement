using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAoTreEm.PAL
{
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSDT.Clear();
            txtSoCCCD.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayVaoLam.Value = DateTime.Now;
            chkNam.Checked = true;
            cmbQuyenSuDung.SelectedIndex = -1;
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked)
            {
                chkNu.Checked = false; // Bỏ chọn Nữ nếu Nam được chọn
            }
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked)
            {
                chkNam.Checked = false; // Bỏ chọn Nam nếu Nữ được chọn
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control
            string hoTen = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string cccd = txtSoCCCD.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            DateTime ngayVaoLam = dtpNgayVaoLam.Value;
            string gioiTinh = "";

            // Kiểm tra giới tính được chọn
            if (chkNam.Checked && !chkNu.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (!chkNam.Checked && chkNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 giới tính!");
                return;
            }

            // Kiểm tra quyền sử dụng
            string quyenSuDung = cmbQuyenSuDung.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(quyenSuDung))
            {
                MessageBox.Show("Vui lòng chọn quyền sử dụng!");
                return;
            }

            // Thêm dữ liệu vào DataGridView
            dgvUser.Rows.Add(hoTen, sdt, cccd, ngaySinh.ToString("dd/MM/yyyy"), ngayVaoLam.ToString("dd/MM/yyyy"), gioiTinh, quyenSuDung);

        }
    }
}
