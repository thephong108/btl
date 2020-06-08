using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace quanlyloptinhocvangoaingunganhan
{
    public partial class FrmGiaovien : Form
    {
        public FrmGiaovien()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Ảnh jpg|*.jpg|Ảnh bitmap|*.bmp|All files|*.*";
            dlgOpen.InitialDirectory = "D:\\Pictures";
            dlgOpen.FilterIndex = 1;
            dlgOpen.Title = "Chọn ảnh";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = dlgOpen.FileName;
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

        private void txtAnh_TextChanged(object sender, EventArgs e)
        {
            if (txtAnh.Text != "")
                picAnh.Image = Image.FromFile(txtAnh.Text);
        }

        private void FrmGiaovien_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoaddatatoGridview();
            filldatatocombo();
            filldatatocombo1();
            filldatatocombo2();
            filldatatocombo3();
            DAO.CloseConnection();
            for (int i = 1; i <= 31; i++)
            {
                cboNgay.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i.ToString());
            }
            for (int i = 1980; i <= 2030; i++)
            {
                cboNam.Items.Add(i.ToString());
            }
            cboNgay.SelectedIndex = -1;
            cboThang.SelectedIndex = -1;
            cboNam.SelectedIndex = -1;

         

            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblGiaovien ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblGiaovien = new DataTable();

                myAdapter.Fill(tblGiaovien);
                gridviewGV.DataSource = tblGiaovien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
        }
        public void filldatatocombo()
        {
            string sql = "select * from tblChucDanh";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMachucdanh.DataSource = table;
            cboMachucdanh.ValueMember = "MaChucDanh";
            cboMachucdanh.DisplayMember = "MaChucDanh";


        }
        public void filldatatocombo1()
        {
            string sql = "select * from tblChuyenMon";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMachuyenmon.DataSource = table;
            cboMachuyenmon.ValueMember = "MaChuyenMon";
            cboMachuyenmon.DisplayMember = "MaChuyenMon";


        }
        public void filldatatocombo2()
        {
            string sql = "select * from tblCoquan";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMaCQ.DataSource = table;
            cboMaCQ.ValueMember = "MaCQ";
            cboMaCQ.DisplayMember = "MaCQ";


        }
        public void filldatatocombo3()
        {
            string sql = "select * from tblTrinhdo";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMatrinhdo.DataSource = table;
            cboMatrinhdo.ValueMember = "MaTrinhDo";
            cboMatrinhdo.DisplayMember = "MaTrinhDo";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGV.Enabled = true;
            //xoa du lieu trong text box
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            cboMachucdanh.SelectedIndex = -1;
            txtAnh.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            cboNgay.SelectedIndex = -1;
            cboThang.SelectedIndex = -1;
            cboNam.SelectedIndex = -1;
            cboMachuyenmon.SelectedIndex = -1;
            cboMaCQ.SelectedIndex = -1;
            cboMatrinhdo.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtMaHV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHV.Focus();
                return;
            }
            if (txtTenHV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHV.Focus();
                return;
            }
            if (cboGioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (cboMachucdanh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã chức danh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNgay.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboThang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tháng sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNam.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn Năm sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMachuyenmon.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã chuyên môn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMaCQ.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã cơ quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMatrinhdo.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn Mã trình độ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlCheckkey = "Select * from tblHocvien where MaHocVien = '" + txtMaGV.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckkey))
            {
                MessageBox.Show("Mã giáo viên đã tồn tại");
                DAO.CloseConnection();
                txtMaGV.Focus();
                return;
            }
            else
            {
                string Ngaysinh;
                Ngaysinh = String.Format("{0}/{1}/{2}", cboThang.Text, cboNgay.Text, cboNam.Text);
           

                string sql = "insert into tblHocvien values('" + txtMaHV.Text.Trim() + "',N'" + txtTenHV.Text.Trim()
                    + "','" + cboMalop.SelectedValue.ToString()

                    + "','" + Ngaysinh + "',N'" + cboGioitinh.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + cboManghe.SelectedValue.ToString()

                    + "','" + txtSDT.Text.Trim() + "','" + NgayNopHocPhi + "','" + txtDiem.Text.Trim() + "')";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                LoaddatatoGridview();
                filldatatocombo();
                filldatatocombo1();
                DAO.CloseConnection();

            }
        }
    }
}
