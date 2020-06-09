

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyloptinhocvangoaingunganhan
{
    public partial class frmNghenghiep : Form
    {
        public frmNghenghiep()
        {
            InitializeComponent();
        }

   

        private void dataGridViewNgheNghiep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblNghenghiep ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblNghenghiep = new DataTable();
                myAdapter.Fill(tblNghenghiep);
                dataGridViewNgheNghiep.DataSource = tblNghenghiep;
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

  

     


        private void btnluu_Click_1(object sender, EventArgs e)
        {
            if (txtMaNghe.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã Nghề ");
                txtMaNghe.Focus();
                return;

            }
            if (txtTenNghe.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên nghề");
                txtTenNghe.Focus();

                return;
            }

            string sqlCheckKey = "Select * from tblNghenghiep where MaNghe ='" + txtMaNghe.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckKey))
            {
                MessageBox.Show(" Mã nghề đã tồn tại");
                DAO.CloseConnection();
                txtMaNghe.Focus();
                return;
            }
            else
            {
                string sql = " insert into tblNghenghiep values('" + txtMaNghe.Text.Trim() + "', N'" + txtTenNghe.Text.Trim() + "')";


                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoaddatatoGridview();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblNghenghiep where MaNghe = '" + txtMaNghe.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string sql = "update tblNghenghiep set TenNghe = N'" + txtTenNghe.Text.Trim() + "' where MaNghe = '" + txtMaNghe.Text + "' ";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtMaNghe.Enabled = true;
            txtTenNghe.Enabled = true;

            txtMaNghe.Text = "";
            txtTenNghe.Text = "";

        }

        private void frmNghenghiep_Load(object sender, EventArgs e)
        {
            LoaddatatoGridview();
        }

        private void dataGridViewNgheNghiep_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNghe.Text = dataGridViewNgheNghiep.CurrentRow.Cells["MaNghe"].Value.ToString();
            txtTenNghe.Text = dataGridViewNgheNghiep.CurrentRow.Cells["TenNghe"].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
