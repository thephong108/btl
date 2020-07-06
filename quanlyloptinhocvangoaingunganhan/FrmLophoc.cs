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
using System.IO;

namespace quanlyloptinhocvangoaingunganhan
{
    public partial class FrmLophoc : Form
    {
        public FrmLophoc()
        {
            InitializeComponent();
        }
   
        private void FrmLophoc_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            for (int i = 1; i <= 31; i++)
            {
                cboNgay.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i.ToString());
            }
            for (int i = 2019; i <= 2040; i++)
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
            for (int i = 2019; i <= 2040; i++)
            {
                cboNam1.Items.Add(i.ToString());
            }
            cboNgay1.SelectedIndex = -1;
            cboThang1.SelectedIndex = -1;
            cboNam1.SelectedIndex = -1;

               
            LoaddatatoGridview();
            filldatatocombo();
            filldatatocombo1();
            filldatatocombo2();
            filldatatocombo3();
            filldatatocombo4();
            DAO.CloseConnection();
        
            
           
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblLophoc ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblLophoc = new DataTable();

                myAdapter.Fill(tblLophoc);
                gridviewLop.DataSource = tblLophoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
            gridviewLop.AllowUserToAddRows = false;
        }
        public void filldatatocombo()
        {
            string sql = "select * from tblMonhoc";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMamon.DataSource = table;
            cboMamon.ValueMember = "MaMon";
            cboMamon.DisplayMember = "MaMon";


        }
        public void filldatatocombo1()
        {
            string sql = "select * from tblGiaovien";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMaGV.DataSource = table;
            cboMaGV.ValueMember = "MaGV";
            cboMaGV.DisplayMember = "MaGV";


        }
        public void filldatatocombo2()
        {
            string sql = "select * from tblCahoc";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMaca.DataSource = table;
            cboMaca.ValueMember = "MaCa";
            cboMaca.DisplayMember = "MaCa";


        }
        public void filldatatocombo3()
        {
            string sql = "select * from tblThoigian";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMathoigian.DataSource = table;
            cboMathoigian.ValueMember = "MaThoiGian";
            cboMathoigian.DisplayMember = "MaThoiGian";


        }
        public void filldatatocombo4()
        {
            string sql = "select * from tblPhonghoc";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMaphong.DataSource = table;
            cboMaphong.ValueMember = "MaPhong";
            cboMaphong.DisplayMember = "MaPhong";


        }

        private void gridviewLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMalop.Enabled = false;
            txtTenlop.Text = gridviewLop.CurrentRow.Cells["TenLop"].Value.ToString();
            cboMamon.Text = gridviewLop.CurrentRow.Cells["Mamon"].Value.ToString();
            cboMaGV.Text = gridviewLop.CurrentRow.Cells["MaGV"].Value.ToString();
            txtMalop.Text = gridviewLop.CurrentRow.Cells["Malop"].Value.ToString();
            cboMaca.Text = gridviewLop.CurrentRow.Cells["Maca"].Value.ToString();
            cboMathoigian.Text = gridviewLop.CurrentRow.Cells["Mathoigian"].Value.ToString();
            cboMaphong.Text = gridviewLop.CurrentRow.Cells["Maphong"].Value.ToString();
            string[] date = gridviewLop.CurrentRow.Cells["NgayBD"].Value.ToString().Split('/');
            string[] year = date[2].Split(' ');
            cboNgay.Text = date[1];
            cboThang.Text = date[0];
            cboNam.Text = year[0];
            string[] date1 = gridviewLop.CurrentRow.Cells["NgayKT"].Value.ToString().Split('/');
            string[] year1 = date1[2].Split(' ');
            cboNgay1.Text = date1[1];
            cboThang1.Text = date1[0];
            cboNam1.Text = year1[0];
            txtSiso.Text = DAO.GetFieldValues("select count(MaHocVien) from tblHocvien  where Malop ='"+ txtMalop.Text+"'") ;
            txtSiso.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMalop.Text = "";
            txtTenlop.Text = "";
            cboMamon.Text = "";
            txtSiso.Text = "0";
            cboMaphong.Text = "";
            cboNgay.Text = "";
            cboThang.Text = "";
            cboNam.Text = "";
            cboMaGV.Text = "";
            cboMaca.Text = "";
            cboMathoigian.Text = "";
            cboNgay1.Text = "";
            cboThang1.Text = "";
            cboNam1.Text = "";
            txtMalop.Enabled = true;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtMalop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMalop.Focus();
                return;
            }
            if (txtTenlop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenlop.Focus();
                return;
            }
            if (cboMamon.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã môn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMaGV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã gv", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (cboMaca.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã ca", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNgay.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn ngày BĐ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboThang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tháng BĐ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNam.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn Năm BĐ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNgay1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn ngày KT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboThang1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tháng KT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNam1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn Năm KT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMathoigian.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã thời gian", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMaphong.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlCheckkey = "Select * from tblLophoc where MaLop = '" + txtMalop.Text.Trim() + "'";
            string sqlCheckkey1 = "Select * from tblLophoc where Maphong = '" + cboMaphong.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckkey))
            {
                MessageBox.Show("Mã lớp học đã tồn tại");
                DAO.CloseConnection();
                txtMalop.Focus();
                return;
            }
            else
            {
                string NgayBD;
                NgayBD = String.Format("{1}/{0}/{2}", cboNgay.Text, cboThang.Text, cboNam.Text);
                string NgayKT;
                NgayKT = String.Format("{1}/{0}/{2}", cboNgay1.Text, cboThang1.Text, cboNam1.Text);
                string siso;
                siso = string.Format(txtSiso.Text = DAO.GetFieldValues("select count(MaHocVien) from tblHocvien  where Malop ='" + txtMalop.Text + "'"));



                string sql = "insert into tblLophoc values('" + txtMalop.Text.Trim() + "',N'" + txtTenlop.Text.Trim() + "',N'" + cboMamon.Text.Trim() + "',N'" + cboMaGV.Text.Trim()
                    + "','" + NgayBD + "','" + NgayKT
                      + "',N'" + cboMaca.Text.Trim() + "',N'" + cboMathoigian.Text.Trim() + "','" + cboMaphong.Text.Trim()
                    + "','" + siso + "')";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                
     
                cmd.ExecuteNonQuery();
                LoaddatatoGridview();
                filldatatocombo();
                filldatatocombo1();
                filldatatocombo2();
                filldatatocombo3();
       
                DAO.CloseConnection();

            }
           

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string NgayBD;
            NgayBD = String.Format("{1}/{0}/{2}", cboNgay.Text, cboThang.Text, cboNam.Text);
            string NgayKT;
            NgayKT = String.Format("{1}/{0}/{2}", cboNgay1.Text, cboThang1.Text, cboNam1.Text);

            string sql = "UPDATE tblLophoc SET TenLop = N'" + txtTenlop.Text.Trim() + "', Mamon='" + cboMamon.Text.Trim()
                + "',NgayBD='" + NgayBD + "', MaGV='" + cboMaGV.Text.Trim() + "', Siso='" + txtSiso.Text.Trim() +

           "', Maca=N'" + cboMaca.Text.Trim() + "',Mathoigian='" + cboMathoigian.Text.Trim() + "',NgayKT='" + NgayKT +
           "',Maphong=N'" + cboMaphong.Text.Trim() +
           
           "'WHERE Malop='" + txtMalop.Text.Trim() + "'";

            DAO.OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void FrmLophoc_Activated(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql = "DELETE from tblLophoc where MaLop = '" + txtMalop.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void cboNgay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

