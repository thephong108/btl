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
    public partial class FrmCahoc : Form
    {
        public FrmCahoc()
        {
            InitializeComponent();
        }

        private void FrmCahoc_Load(object sender, EventArgs e)
        {
            LoaddatatoGridview();
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblCahoc ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblCahoc = new DataTable();
                myAdapter.Fill(tblCahoc);
                dataGridViewCa.DataSource = tblCahoc;
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtMaCa.Enabled = true;
            txtTenCa.Enabled = true;

            txtMaCa.Text = "";
            txtTenCa.Text = "";
        }

        private void dataGridViewCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCa.Text = dataGridViewCa.CurrentRow.Cells["MaCa"].Value.ToString();
            txtTenCa.Text = dataGridViewCa.CurrentRow.Cells["TenCa"].Value.ToString();

            txtMaCa.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "update tblCahoc set TenCa = N'" + txtTenCa.Text.Trim() + "' where MaCa = '" + txtMaCa.Text + "' ";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaCa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã ca ");
                txtMaCa.Focus();
                return;

            }
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên ca");
                txtTenCa.Focus();

                return;
            }

            string sqlCheckKey = "Select * from tblCahoc where MaCa ='" + txtMaCa.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckKey))
            {
                MessageBox.Show(" Mã Ca đã tồn tại");
                DAO.CloseConnection();
                txtMaCa.Focus();
                return;
            }
            else
            {
                string sql = " insert into tblCahoc values('" + txtMaCa.Text.Trim() + "', N'" + txtTenCa.Text.Trim() + "')";


                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoaddatatoGridview();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblCahoc where MaThoiGian = '" + txtMaCa.Text + "'";
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
    }
}
