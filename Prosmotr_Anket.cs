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
    public partial class Prosmotr_Anket : Form
    {
        private SqlConnection sql = new SqlConnection(@"Data Source=S-P-A-2\MSSQLSERVER01;Initial Catalog=Company; Integrated Security=True");
        private int []id_ = null;
        private int k = 0;
        public string[] v = null;
        
        public Prosmotr_Anket()
        {
            InitializeComponent();
        }
        public string Zanos(string i, int id_)
        {
            string v1 = $"Select {i} FROM ID_Анкеты where ID='{id_}'";
            return v1;
        }
        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Prosmotr_Anket_Load(object sender, EventArgs e)
        {
            resheto.Hide();
            label1.Hide();
            sql.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string v1 = null;
            v1 = $"Select ID FROM ID_Анкеты";
            SqlCommand verifikator = new SqlCommand(v1, sql);
            adapter.SelectCommand = verifikator;
            adapter.Fill(table);
            int n = table.Rows.Count;
            int[] id = new int[n];
            int f = 0;
            SqlDataReader reader = verifikator.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id[f] = Convert.ToInt32(Convert.ToDecimal(reader.GetValue(0)).ToString());
                    f++;
                }
            }
            string []g= { "Название", "Вид_обращения", "Площадь", "Количество_помещений", "Местоположение", "Этаж", "Цена", "ID_Владельца" };
            v = g;
            reader.Close();
            id_ = id;
            k++;
            Number.Text = k.ToString();
            SqlCommand id__ = new SqlCommand();
            id__ = new SqlCommand(Zanos(v[0], id[0]), sql);
            N.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[1], id[0]), sql);
            VO.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[2], id[0]), sql);
            S2.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[3], id[0]), sql);
            KO.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[4], id[0]), sql);
            LOC.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[5], id[0]), sql);
            E.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[6], id[0]), sql);
            MON.Text = ((int)id__.ExecuteScalar()).ToString();
            sql.Close();           
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form back = new Vxod();
            back.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            sql.Open();
            if (k < 2)
            {
                sql.Close();
                return;
            }
            k--;
            int id = id_[k - 1];
            Number.Text = k.ToString();
            SqlCommand id__ = new SqlCommand(Zanos(v[0], id), sql);
            N.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[1], id), sql);
            VO.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[2], id), sql);
            S2.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[3], id), sql);
            KO.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[4], id), sql);
            LOC.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[5], id), sql);
            E.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[6], id), sql);
            MON.Text = ((int)id__.ExecuteScalar()).ToString();
            sql.Close();
            Number.Text = k.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            sql.Open();
            if (k > id_.Length-1)
            {
                sql.Close();
                return;
            }
            k++;
            int id = id_[k-1];
            Number.Text = k.ToString();
            SqlCommand id__ = new SqlCommand(Zanos(v[0], id), sql);
            N.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[1], id), sql);
            VO.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[2], id), sql);
            S2.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[3], id), sql);
            KO.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[4], id), sql);
            LOC.Text = (string)id__.ExecuteScalar();
            id__ = new SqlCommand(Zanos(v[5], id), sql);
            E.Text = ((int)id__.ExecuteScalar()).ToString();
            id__ = new SqlCommand(Zanos(v[6], id), sql);
            MON.Text = ((int)id__.ExecuteScalar()).ToString();
            sql.Close();
            Number.Text = k.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand id__ = new SqlCommand(Zanos("ID_Владельца", id_[k-1]), sql);
            string id___ = ((int)id__.ExecuteScalar()).ToString();
            string v = $"INSERT INTO[ID_Запроса] (ID_Покупателя,      Вид_обращения,  Цена,           Площадь,        Количество_помещений,   Местоположение,     Этаж,        ID_Продавца,    Комментарий)" +
                       $"Values                  (N'{ID.id_pas}',  N'{VO.Text}',   N'{MON.Text}',  N'{S2.Text}',   N'{KO.Text}',           N'{LOC.Text}',      N'{E.Text}', N'{id___}',       N'{VS.Text}')";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand verifikator = new SqlCommand(v, sql);
            if (sql.State == ConnectionState.Open)
            {
                adapter.SelectCommand = verifikator;
                if (verifikator.ExecuteNonQuery().ToString() == "1")
                    MessageBox.Show($"Покупка совершена id покупателя: {ID.id_pas} id владельца: {id_[k - 1]}");
            }
            v = $"DELETE FROM ID_Анкеты where ID_Владельца = '{id___}' and ID='{id_[k - 1]}'";
            verifikator = new SqlCommand(v, sql);
            SqlDataReader reader = verifikator.ExecuteReader();
            reader.Close();
            sql.Close();
            this.Hide();
            Form zaversh = new Zaversh();
            zaversh.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            resheto.Hide();
            label1.Hide();
        }
        Point l;

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            l = new Point(e.X, e.Y);
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - l.X;
                this.Top += e.Y - l.Y;
            }

        }
    }
}
