using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class frmQuanLyKhoa : Form
    {
        public frmQuanLyKhoa()
        {
            InitializeComponent();
        }

        private bool KiemTraDuLieu()
        {
            // Kiểm tra mã khoa (10 ký tự, không chứa ký tự đặc biệt)
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                txtMaKhoa.Text.Length != 10 ||
                !txtMaKhoa.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Mã khoa không hợp lệ. Vui lòng nhập 10 ký tự không chứa ký tự đặc biệt.");
                return false;
            }

            // Kiểm tra tên khoa (3-100 ký tự, không chứa ký tự số và ký tự đặc biệt)
            if (string.IsNullOrWhiteSpace(txtTenKhoa.Text) || txtTenKhoa.Text.Length < 3 || txtTenKhoa.Text.Length > 100 ||
                txtTenKhoa.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Tên khoa không hợp lệ. Tên khoa không được chứa ký tự số.");
                return false;
            }

            // Kiểm tra tổng số giáo sư (0-15)
            if (!int.TryParse(txtTongGS.Text, out int soGS) || soGS < 0 || soGS > 15)
            {
                MessageBox.Show("Tổng số giáo sư không hợp lệ. Vui lòng nhập từ 0 đến 15.");
                return false;
            }

            return true;
        }

        private void cmbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSapXep.SelectedItem != null)
            {
                if (cmbSapXep.SelectedItem.ToString() == "Tăng dần")
                {
                    // Sắp xếp tăng dần
                    dgvQuanLiKhoa.Sort(dgvQuanLiKhoa.Columns["colTongSoGS"], ListSortDirection.Ascending);
                }
                else if (cmbSapXep.SelectedItem.ToString() == "Giảm dần")
                {
                    // Sắp xếp giảm dần
                    dgvQuanLiKhoa.Sort(dgvQuanLiKhoa.Columns["colTongSoGS"], ListSortDirection.Descending);
                }
            }
        }

        private void ResetFields()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTongGS.Clear();
            txtTongSoGS.Text = CalculateTotalProfessors().ToString(); // Cập nhật tổng số giáo sư
        }

        private void UpdateTotalProfessors()
        {
            int total = CalculateTotalProfessors();
            txtTongSoGS.Text = total.ToString(); // Cập nhật tổng số giáo sư
        }

        private int CalculateTotalProfessors()
        {
            return dgvQuanLiKhoa.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells["colTongSoGS"].Value != null)
                .Sum(row => int.TryParse(row.Cells["colTongSoGS"].Value.ToString(), out int soGS) ? soGS : 0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {
            txtTongSoGS.Text = "0";
            cmbSapXep.Items.Add("Tăng dần");
            cmbSapXep.Items.Add("Giảm dần");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                // Kiểm tra mã khoa có tồn tại chưa
                var exists = dgvQuanLiKhoa.Rows
                    .Cast<DataGridViewRow>()
                    .Any(r => r.Cells["colMaKhoa"].Value != null &&
                               r.Cells["colMaKhoa"].Value.ToString() == txtMaKhoa.Text);

                if (exists)
                {
                    MessageBox.Show("Mã khoa đã tồn tại. Vui lòng nhập mã khoa khác.");
                }
                else
                {
                    // Thêm khoa mới
                    dgvQuanLiKhoa.Rows.Add(txtMaKhoa.Text, txtTenKhoa.Text, txtTongGS.Text);
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    ResetFields();
                    UpdateTotalProfessors(); // Cập nhật tổng số giáo sư
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khoa để sửa.");
                    return;
                }

                foreach (DataGridViewRow row in dgvQuanLiKhoa.Rows)
                {
                    if (row.Cells["colMaKhoa"].Value != null &&
                        row.Cells["colMaKhoa"].Value.ToString() == txtMaKhoa.Text)
                    {
                        // Cập nhật thông tin khoa
                        row.Cells["colTenKhoa"].Value = txtTenKhoa.Text;
                        row.Cells["colTongSoGS"].Value = txtTongGS.Text; // Sửa từ colTongGS thành colTongSoGS
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        ResetFields();
                        UpdateTotalProfessors(); // Cập nhật tổng số giáo sư
                        return;
                    }
                }
                MessageBox.Show("Mã khoa không tồn tại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var maKhoa = txtMaKhoa.Text;

            if (string.IsNullOrWhiteSpace(maKhoa))
            {
                MessageBox.Show("Vui lòng nhập mã khoa để xóa.");
                return;
            }

            var rowToDelete = dgvQuanLiKhoa.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["colMaKhoa"].Value != null &&
                                     r.Cells["colMaKhoa"].Value.ToString() == maKhoa);

            if (rowToDelete == null)
            {
                MessageBox.Show("Mã khoa không tồn tại trong hệ thống.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dgvQuanLiKhoa.Rows.Remove(rowToDelete);
                MessageBox.Show("Xóa khoa thành công!");
                ResetFields();
                UpdateTotalProfessors(); // Cập nhật tổng số giáo sư
            }
        }

        private void dgvQuanLiKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQuanLiKhoa.Rows[e.RowIndex];

                // Kiểm tra xem các ô có null không trước khi gán giá trị cho các TextBox
                txtMaKhoa.Text = row.Cells["colMaKhoa"].Value?.ToString() ?? string.Empty;
                txtTenKhoa.Text = row.Cells["colTenKhoa"].Value?.ToString() ?? string.Empty;
                txtTongGS.Text = row.Cells["colTongSoGS"].Value?.ToString() ?? string.Empty; // Đảm bảo tên cột chính xác
            }
        }
    }
}
