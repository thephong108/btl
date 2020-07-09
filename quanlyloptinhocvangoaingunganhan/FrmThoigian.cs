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
using System.Data.Sql;

namespace quanlyloptinhocvangoaingunganhan
{
    public partial class FrmThoigian : Form
    {
        public FrmThoigian()
        {
            InitializeComponent();
        }

        private void FrmThoigian_Load(object sender, EventArgs e)
        {
            LoaddatatoGridview();
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblThoigian ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblThoigian = new DataTable();
                myAdapter.Fill(tblThoigian);
                dataGridViewThoiGian.DataSource = tblThoigian;
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

        private void dataGridViewThoiGian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThoiGian.Text = dataGridViewThoiGian.CurrentRow.Cells["MaThoiGian"].Value.ToString();
            txtTenThoiGian.Text = dataGridViewThoiGian.CurrentRow.Cells["TenThoiGian"].Value.ToString();

            txtMaThoiGian.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaThoiGian.Enabled = true;
            txtTenThoiGian.Enabled = true;

            txtMaThoiGian.Text = "";
            txtTenThoiGian.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaThoiGian.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã thời gian ");
                txtMaThoiGian.Focus();
                return;

            }
            if (txtTenThoiGian.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên thời gian");
                txtTenThoiGian.Focus();

                return;
            }

            string sqlCheckKey = "Select * from tblThoigian where MaThoiGian ='" + txtMaThoiGian.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckKey))
            {
                MessageBox.Show(" Mã thời gian đã tồn tại");
                DAO.CloseConnection();
                txtMaThoiGian.Focus();
                return;
            }
            else
            {
                string sql = " insert into tblThoigian values('" + txtMaThoiGian.Text.Trim() + "', N'" + txtTenThoiGian.Text.Trim() + "')";


                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                LoaddatatoGridview();
                DAO.CloseConnection();
            

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblThoigian set TenThoiGian = N'" + txtTenThoiGian.Text.Trim() + "' where MaThoiGian = '" + txtMaThoiGian.Text + "' ";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            LoaddatatoGridview();
            DAO.CloseConnection();
          
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblThoigian where MaThoiGian = '" + txtMaThoiGian.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            LoaddatatoGridview();
            DAO.CloseConnection();
          
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
