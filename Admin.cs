using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenstvo
{
    public partial class Admin : Form
    {
        private SqlConnection sql = new SqlConnection(@"Data Source=S-P-A-2\MSSQLSERVER01;Initial Catalog=Company; Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        SqlCommand verifikator;
        
        public Admin()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form back = new Vxod();
            back.Show();
        }
        private void No___Click(object sender, EventArgs e)
        {
            table1.Clear();
            table2.Clear();
            table3.Clear();
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            sql.Open();
            string S2_ = "";
            string Money_ = "";
            string v1;
            int n = 0;
            int i=0;
            string eror="";
            string v;
            try
            {
                if (PA.Checked)
                {
                    v = $"Select * From ID_Пользователя";
                    verifikator = new SqlCommand(v, sql);
                    adapter.SelectCommand = verifikator;
                    adapter.Fill(table1);
                    if (table1.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = table1;
                        dataGridView1.Show();
                    }
                }
                else if (PP.Checked)
                {
                    v = $"Select * From ID_Анкеты";
                    verifikator = new SqlCommand(v, sql);
                    adapter.SelectCommand = verifikator;
                    adapter.Fill(table2);
                    if (table2.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = table2;
                        dataGridView2.Show();
                    }
                }
                else if (DD.Checked)
                {
                    v = $"Select * From ID_Запроса";
                    verifikator = new SqlCommand(v, sql);
                    adapter.SelectCommand = verifikator;
                    adapter.Fill(table3);
                    if (table3.Rows.Count > 0)
                    {
                        dataGridView3.DataSource = table3;
                        dataGridView3.Show();
                    }
                }
                else
                {
                    sql.Close();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Неверно введенны поля в полях Анкеты");
                sql.Close();
                return;
            }

            sql.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
        }

        private void DD_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
