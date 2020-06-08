﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Data;


namespace quanlyloptinhocvangoaingunganhan
    {
        class DAO
        {
            public static SqlConnection conn;
            public static string connectionString = "Data Source=MSI;Initial Catalog=QLtinhoc;Integrated Security=True";
            public static void OpenConnection()
            {
                conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                if (conn.State == System.Data.ConnectionState.Closed)
                    try
                    {
                        conn.Open();
                        //MessageBox.Show("mo ket noi thanh cong");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

            }
            public static void CloseConnection()
            {
                conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                if (conn.State == System.Data.ConnectionState.Open)
                    try
                    {
                        conn.Close();
                        MessageBox.Show("Đóng ket noi thanh cong");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

            }
            public static bool checkKeyexit(string sql)
            {
                bool kq = false;
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                    kq = true;

                return kq;
            }
            public static void filldatatocombo(string sql, ComboBox combo, string valueField, string displayField)
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                combo.DataSource = table;
                combo.ValueMember = valueField;
                combo.DisplayMember = displayField;


            }
            public static string CreateKey(string tiento)
            {
                string key = tiento;
                string[] partsDay;
                partsDay = DateTime.Now.ToShortDateString().Split('/');
                //Ví dụ 07/08/2009
                string d = String.Format("-{0}/{1}/{2}", partsDay[0], partsDay[1], partsDay[2]);
                key = key + d;
                string[] partsTime;
                partsTime = DateTime.Now.ToLongTimeString().Split(':');
                //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
                if (partsTime[2].Substring(3, 2) == "PM")
                    partsTime[0] = ConvertTimeTo24(partsTime[0]);
                if (partsTime[2].Substring(3, 2) == "AM")
                    if (partsTime[0].Length == 1)
                        partsTime[0] = "0" + partsTime[0];
                //Xóa ký tự trắng và PM hoặc AM
                partsTime[2] = partsTime[2].Remove(2, 3);
                string t;
                t = String.Format("-{0}:{1}:{2}", partsTime[0], partsTime[1], partsTime[2]);
                key = key + t;
                return key;
            }
            public static string ConvertTimeTo24(string hour)
            {
                string h = "";
                switch (hour)
                {
                    case "1":
                        h = "13";
                        break;
                    case "2":
                        h = "14";
                        break;
                    case "3":
                        h = "15";
                        break;
                    case "4":
                        h = "16";
                        break;
                    case "5":
                        h = "17";
                        break;
                    case "6":
                        h = "18";
                        break;
                    case "7":
                        h = "19";
                        break;
                    case "8":
                        h = "20";
                        break;
                    case "9":
                        h = "21";
                        break;
                    case "10":
                        h = "22";
                        break;
                    case "11":
                        h = "23";
                        break;
                    case "12":
                        h = "0";
                        break;
                }
                return h;
            }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

    }
    }

