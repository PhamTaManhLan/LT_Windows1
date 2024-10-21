using lab01.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class frmQLSV : Form
    {
        StudentContextDB context = new StudentContextDB();
        public frmQLSV()
        {
            InitializeComponent();
            List<Student> listStudent = context.Students.ToList();
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbKhoa.DataSource = listFalcultys;
            this.cmbKhoa.DisplayMember = "FacultyName";
            this.cmbKhoa.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Gender;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
                dgvStudent.Rows[index].Cells[4].Value = item.Faculty.FacultyName;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }

            if (!Regex.IsMatch(txtMaSV.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ.");
                return false;
            }

            if (!float.TryParse(txtDiemTB.Text, out float diemTB) || diemTB < 0 || diemTB > 10)
            {
                MessageBox.Show("Điểm trung bình sinh viên không hợp lệ.");
                return false;
            }

            if (!Regex.IsMatch(txtHoTen.Text, @"^[a-zA-Z\s]{3,100}$"))
            {
                MessageBox.Show("Tên sinh viên không hợp lệ.");
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            rbNu.Checked = true;
        }

        private void UpdateStudentCount()
        {
            int maleCount = 0, femaleCount = 0;
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells["colGioiTinh"].Value != null && row.Cells["colGioiTinh"].Value.ToString() == "Male")
                    maleCount++;
                else if (row.Cells["colGioiTinh"].Value != null && row.Cells["colGioiTinh"].Value.ToString() == "Female")
                    femaleCount++;
            }
            txtTongSVNam.Text = maleCount.ToString();
            txtTongSVNu.Text = femaleCount.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculties.ToList(); //lấy các khoa
                List<Student> listStudent = context.Students.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rbNu.Checked = true;
            txtTongSVNam.Text = "0";
            txtTongSVNu.Text = "0";
            UpdateStudentCount(); // Cập nhật số lượng sinh viên
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudent.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["colMaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["colHoTen"].Value.ToString();
                if (row.Cells["colGioiTinh"].Value.ToString() == "Male")
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;
                txtDiemTB.Text = row.Cells["colDiemTB"].Value.ToString();
                cmbKhoa.Text = row.Cells["colKhoa"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                // Thêm sinh viên mới
                dgvStudent.Rows.Add(txtMaSV.Text, txtHoTen.Text, rbNam.Checked ? "Male" : "Female", txtDiemTB.Text, cmbKhoa.Text);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
                ResetForm();
                UpdateStudentCount(); // Cập nhật số lượng sinh viên
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells["colMaSV"].Value.ToString() == txtMaSV.Text)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dgvStudent.Rows.Remove(row);
                        MessageBox.Show("Xóa sinh viên thành công!");
                        UpdateStudentCount(); // Cập nhật số lượng sinh viên
                        ResetForm();
                    }
                    return;
                }
            }
            MessageBox.Show("Mã sinh viên không tồn tại trong hệ thống.");
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    if (row.Cells["colMaSV"].Value.ToString() == txtMaSV.Text)
                    {
                        // Cập nhật thông tin sinh viên
                        row.Cells["colHoTen"].Value = txtHoTen.Text;
                        row.Cells["colGioiTinh"].Value = rbNam.Checked ? "Male" : "Female";
                        row.Cells["colDiemTB"].Value = txtDiemTB.Text;
                        row.Cells["colKhoa"].Value = cmbKhoa.Text;
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        UpdateStudentCount(); // Cập nhật số lượng sinh viên
                        return;
                    }
                }
                MessageBox.Show("Mã sinh viên không tồn tại trong hệ thống.");
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa frm = new frmQuanLyKhoa();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
