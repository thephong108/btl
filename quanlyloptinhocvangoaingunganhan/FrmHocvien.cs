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
    public partial class FrmHocvien : Form
    {
        public FrmHocvien()
        {
            InitializeComponent();
        }

        private void FrmHocvien_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoaddatatoGridview();
            filldatatocombo();
            filldatatocombo1();
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

            for (int i = 1; i <= 31; i++)
            {
                cboNgay1.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                cboThang1.Items.Add(i.ToString());
            }
            for (int i = 1980; i <= 2030; i++)
            {
                cboNam1.Items.Add(i.ToString());
            }
            cboNgay1.SelectedIndex = -1;
            cboThang1.SelectedIndex = -1;
            cboNam1.SelectedIndex = -1;

            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHV.Enabled = true;
            //xoa du lieu trong text box
            txtMaHV.Text = "";
            txtTenHV.Text = "";
            cboMalop.SelectedIndex = -1;
            txtDiem.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            cboNgay.SelectedIndex = -1;
            cboThang.SelectedIndex = -1;
            cboNam.SelectedIndex = -1;
            cboNgay1.SelectedIndex = -1;
            cboThang1.SelectedIndex = -1;
            cboNam1.SelectedIndex = -1;
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
            if (cboMalop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Bạn chưa chọn năm sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNgay1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn ngày nộp học phí", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboThang1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tháng nộp học phí", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNam1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn năm nộp học phí", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlCheckkey = "Select * from tblHocvien where MaHocVien = '" + txtMaHV.Text.Trim() + "'";
            DAO.OpenConnection();
        
            if (DAO.checkKeyexit(sqlCheckkey))
            {
                MessageBox.Show("Mã học viên đã tồn tại");
                DAO.CloseConnection();
                txtMaHV.Focus();
                return;
            }
            else
            {
                string Ngaysinh;
                Ngaysinh = String.Format("{1}/{0}/{2}", cboNgay.Text, cboThang.Text, cboNam.Text);
                string NgayNopHocPhi;
                NgayNopHocPhi = String.Format("{1}/{0}/{2}", cboNgay1.Text, cboThang1.Text, cboNam1.Text);

                string sql = "insert into tblHocvien values('" + txtMaHV.Text.Trim() + "',N'" + txtTenHV.Text.Trim()
                    + "','" + cboMalop.SelectedValue.ToString()

                    + "','" + Ngaysinh + "',N'" + cboGioitinh.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + cboManghe.SelectedValue.ToString()

                    + "','"+ txtSDT.Text.Trim() + "','" + NgayNopHocPhi + "','" + txtDiem.Text.Trim()+"')";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                LoaddatatoGridview();
                filldatatocombo();
                filldatatocombo1();
                DAO.CloseConnection();

            }
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblHocvien ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblHocvien = new DataTable();

                myAdapter.Fill(tblHocvien);
                gridviewHV.DataSource = tblHocvien;
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
            string sql = "select * from tblLophoc";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMalop.DataSource = table;
            cboMalop.ValueMember = "MaLop";
            cboMalop.DisplayMember = "MaLop";


        }
        public void filldatatocombo1()
        {
            string sql = "select * from tblNghenghiep";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboManghe.DataSource = table;
            cboManghe.ValueMember = "MaNghe";
            cboManghe.DisplayMember = "MaNghe";


        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0') || (e.KeyChar > '9')) && (Convert.ToInt16(e.KeyChar) != 8))
            {
                e.Handled = true;
            }
        }

        private void gridviewHV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtMaHV.Enabled = false;
            txtTenHV.Text = gridviewHV.CurrentRow.Cells["TenHV"].Value.ToString();
            txtDiem.Text = gridviewHV.CurrentRow.Cells["Diem"].Value.ToString();
            txtMaHV.Text = gridviewHV.CurrentRow.Cells["MaHV"].Value.ToString();
            txtDiachi.Text = gridviewHV.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = gridviewHV.CurrentRow.Cells["SDT"].Value.ToString();
            cboMalop.Text = gridviewHV.CurrentRow.Cells["MaLop"].Value.ToString();
            cboManghe.Text = gridviewHV.CurrentRow.Cells["MaNghe"].Value.ToString();
            string[] date = gridviewHV.CurrentRow.Cells["Ngaysinh"].Value.ToString().Split('/');
            string[] year = date[2].Split(' ');
            cboNgay.Text = date[1];
            cboThang.Text = date[0];
            cboNam.Text = year[0];
            string[] date1 = gridviewHV.CurrentRow.Cells["NgayNopHocPhi"].Value.ToString().Split('/');
            string[] year1 = date1[2].Split(' ');
            cboNgay1.Text = date1[1];
            cboThang1.Text = date1[0];
            cboNam1.Text = year1[0];
            cboGioitinh.Text = gridviewHV.CurrentRow.Cells["Gioitinh"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string Ngaysinh;
            Ngaysinh = String.Format("{1}/{0}/{2}", cboNgay.Text, cboThang.Text, cboNam.Text);
                   string NgayNopHocPhi;
            NgayNopHocPhi = String.Format("{1}/{0}/{2}", cboNgay1.Text, cboThang1.Text, cboNam1.Text);

            string sql = "UPDATE tblHocvien SET TenHocVien = N'" + txtTenHV.Text.Trim() + "', MaLop='" + cboMalop.Text.Trim() + "',NgaySinh='" + Ngaysinh + "', MaNghe='" + cboManghe.Text.Trim() +

           "', Gioitinh=N'" + cboGioitinh.Text.Trim() + "',Diachi=N'" + txtDiachi.Text.Trim() +  "',NgayNopHocPhi=N'" + NgayNopHocPhi +
           "',DienThoai=N'" + txtSDT.Text.Trim() +
           "',Diem=N'" + txtDiem.Text.Trim() +
           "'WHERE MaHocVien='" + txtMaHV.Text.Trim() + "'";
                
            DAO.OpenConnection();
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblHocvien where MaHocVien = '" + txtMaHV.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }
    }
}
