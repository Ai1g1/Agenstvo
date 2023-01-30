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
using System.Linq;

namespace Agenstvo
{
    public partial class Vxod : Form
    {
        private SqlConnection sql = null;
        public Vxod()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form reg = new Register();
            this.Hide();
            reg.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(@"Data Source=S-P-A-2\MSSQLSERVER01;Initial Catalog=Company; Integrated Security=True");
            sql.Open();
            string log = EP.Text; 
            string pas = ID.hash(Pas.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string v = null;
            string i = null;
            string stat = null;
            Form admin = new Admin();
            if (Vlad.Checked == true)
            {
                v = $"Select ID, Статус, Эл_Почта, Пароль FROM ID_Пользователя where Статус= '{Vlad.Text}' and Эл_Почта='{log}' and Пароль = '{pas}'";
                stat = Vlad.Text;
                i= $"Select ID FROM ID_Пользователя where Статус= '{Vlad.Text}' and Эл_Почта='{log}' and Пароль = '{pas}'";
            }
            else if (Pok.Checked == true)
            {
                v = $"select ID, Статус, Эл_Почта, Пароль FROM ID_Пользователя where Статус= '{Pok.Text}' and Эл_Почта='{log}' and Пароль = '{pas}'";
                stat = Pok.Text;
                i = $"Select ID FROM ID_Пользователя where Статус= '{Pok.Text}' and Эл_Почта='{log}' and Пароль = '{pas}'";
            }
            else if (adm.Checked == true)
            {
                if (log == "admin" && Pas.Text == "admin")
                {
                    this.Hide();
                    admin.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль для администратора");
                    return;
                }
            }
            else
            {
                return;
            }    
            SqlCommand verifikator = new SqlCommand(v, sql);
            adapter.SelectCommand = verifikator;
            adapter.Fill(table);
            SqlCommand id_ = new SqlCommand(i, sql);
            int id;
            Form vlad = new Prosmotr_anket_Vlad();
            Form pol = new Prosmotr_Anket();
            if (table.Rows.Count == 1)
            {
                this.Hide();
                id = (int)id_.ExecuteScalar();
                if (stat== Vlad.Text)
                {
                    vlad.Show();
                    ID.id_vlad = id;
                    MessageBox.Show($"Авторизация прошла успешна ваш статус: {Vlad.Text} и ваш id: {id}");
                }
                else
                {
                    pol.Show();
                    ID.id_pas = id;
                    MessageBox.Show($"Авторизация прошла успешна ваш статус: {Pok.Text} и ваш id: {id}");
                }
            }
            else
            {
                MessageBox.Show("Зайдите под другим статусом");
            }
            sql.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
