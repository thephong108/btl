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
    public partial class FrmTrinhdo : Form
    {
        public FrmTrinhdo()
        {
            InitializeComponent();
        }

        private void FrmTrinhdo_Load(object sender, EventArgs e)
        {
            LoaddatatoGridview();
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblTrinhdo ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblTrinhdo = new DataTable();
                myAdapter.Fill(tblTrinhdo);
                dataGridViewTrinhDo.DataSource = tblTrinhdo;
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

        private void dataGridViewTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTrinhDo.Text = dataGridViewTrinhDo.CurrentRow.Cells["MaTrinhDo"].Value.ToString();
            txtTenTrinhDo.Text = dataGridViewTrinhDo.CurrentRow.Cells["TenTrinhDo"].Value.ToString();

            txtMaTrinhDo.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtMaTrinhDo.Enabled = true;
            txtTenTrinhDo.Enabled = true;

            txtMaTrinhDo.Text = "";
            txtTenTrinhDo.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "update tblTrinhdo set TenTrinhDo = N'" + txtTenTrinhDo.Text.Trim() + "' where MaTrinhDo = '" + txtMaTrinhDo.Text + "' ";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            LoaddatatoGridview();
            DAO.CloseConnection();
          
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (txtMaTrinhDo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã trình độ ");
                txtMaTrinhDo.Focus();
                return;

            }
            if (txtTenTrinhDo.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên trình độ");
                txtTenTrinhDo.Focus();

                return;
            }

            string sqlCheckKey = "Select * from tblTrinhdo where MaTrinhDo ='" + txtMaTrinhDo.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckKey))
            {
                MessageBox.Show(" Mã trình độ đã tồn tại");
                DAO.CloseConnection();
                txtMaTrinhDo.Focus();
                return;
            }
            else
            {
                string sql = " insert into tblTrinhdo values('" + txtMaTrinhDo.Text.Trim() + "', N'" + txtTenTrinhDo.Text.Trim() + "')";


                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                LoaddatatoGridview();
                DAO.CloseConnection();
           

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblTrinhdo where MaTrinhDo = '" + txtMaTrinhDo.Text + "'";
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
