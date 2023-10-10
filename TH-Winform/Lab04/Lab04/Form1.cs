using Lab04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        //khai báo dbcontext
        static StudentContextDB context = new StudentContextDB();
        List<Faculty> listFacultys = context.Faculties.ToList();
        List<Student> listStudent = context.Students.ToList();
        public Form1()
        {
            InitializeComponent();
            FillFacultyCombobox(listFacultys);
            BindGrid(listStudent);
        }

        private void FillFacultyCombobox(List<Faculty> listFacultys)
        {
            this.cbbKhoa.DataSource = listFacultys;
            this.cbbKhoa.DisplayMember = "FacultyName";
            this.cbbKhoa.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvShow.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvShow.Rows.Add();
                dgvShow.Rows[index].Cells[0].Value = item.StudentID;
                dgvShow.Rows[index].Cells[1].Value = item.FullName;
                dgvShow.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvShow.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        // hàm kiểm xem người dùng nhập đủ thông tin chưa
        public bool checkNull()
        {
            if (txtMssv.Text == "" || txtName.Text == "" || txtDtb.Text == "") { return true; }
            return false;
        }

        public bool CheckScore()
        {
            float score = float.Parse(txtDtb.Text);
            if (score < 0 || score > 10) { return false; }
            return true;
        }

        public bool CheckStudentID()
        {
            if (txtMssv.Text.Length != 9) { return false; }
            return true;
        }
        public bool CheckEnough()
        {
            if (!checkNull() && CheckScore() && CheckStudentID()) {  return true; }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // kiểm tra đã nhập đủ tt?
                if (CheckEnough())
                {
                    Student addStudent = new Student();
                    addStudent.StudentID = txtMssv.Text;
                    addStudent.FullName = txtName.Text;
                    addStudent.FacultyID = cbbKhoa.SelectedIndex + 1;
                    addStudent.AverageScore = Math.Round(float.Parse(txtDtb.Text), 2);
                    context.Students.Add(addStudent);
                    listStudent.Add(addStudent);
                    context.SaveChanges();
                    BindGrid(listStudent);
                    MessageBox.Show("Thêm thành công sinh viên " + addStudent.FullName + "!");
                }
                else
                {
                    MessageBox.Show("Chưa nhập đúng thông tin!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // truy van
                var updateStudent = context.Students.FirstOrDefault(s => s.StudentID.Equals(txtMssv.Text));
                if (updateStudent != null)
                {
                    updateStudent.FullName = txtName.Text;
                    updateStudent.FacultyID = cbbKhoa.SelectedIndex + 1;
                    updateStudent.AverageScore = Math.Round(float.Parse(txtDtb.Text), 2);
                    context.SaveChanges();
                    BindGrid(listStudent);
                    MessageBox.Show("Cập nhật Thông tin thành công!", "Thỏng báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMssv.Text = dgvShow.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgvShow.Rows[index].Cells[1].Value.ToString();
            cbbKhoa.Text = dgvShow.Rows[index].Cells[2].Value.ToString();
            txtDtb.Text = dgvShow.Rows[index].Cells[3].Value.ToString();
        }

        private void txtMssv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtDtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteStudent = context.Students.FirstOrDefault(s => s.StudentID.Equals(txtMssv.Text));
                if (deleteStudent != null)
                {
                    context.Students.Remove(deleteStudent);
                    context.SaveChanges();
                    var students = context.Students.ToList();
                    BindGrid(students);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không có sv cần xóa", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
