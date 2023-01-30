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
    public partial class Prosmotr_anket_Vlad : Form
    {
        private SqlConnection sql = new SqlConnection(@"Data Source=S-P-A-2\MSSQLSERVER01;Initial Catalog=Company; Integrated Security=True");
        public Prosmotr_anket_Vlad()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form back = new Vxod();
            back.Show();
        }

        private void Prosmotr_anket_Vlad_Load(object sender, EventArgs e)
        {
            sql.Open();
            string v = $"Select * FROM ID_Анкеты where ID_Владельца = '{ID.id_vlad}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand verifikator = new SqlCommand(v, sql);
            adapter.SelectCommand = verifikator;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sql.Close();

        }

        private void Deleted_Click(object sender, EventArgs e)
        {
            sql.Open();
            string v;
            string s;
            try
            {
                v = $"DELETE FROM ID_Анкеты where ID_Владельца = '{ID.id_vlad}' and ID='{Convert.ToInt32(ID_D.Text)}'";
            }
            catch
            {
                MessageBox.Show("Не верно введено поле ID");
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand verifikator = new SqlCommand(v, sql);
            SqlDataReader reader = verifikator.ExecuteReader();
            reader.Close();
            v = $"Select * FROM ID_Анкеты where ID_Владельца = '{ID.id_vlad}'";
            verifikator = new SqlCommand(v, sql);
            adapter.SelectCommand = verifikator;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sql.Close();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form anket_new = new New_anket();
            anket_new.Show();
        }
    }
}
