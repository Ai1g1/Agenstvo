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
    public partial class Register : Form
    {
        private SqlConnection sql = null;
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Vxod vxod = new Vxod();
            vxod.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Vxod vxod = new Vxod();
            Register register = new Register();
            //SqlCommand command = new SqlCommand("INSERT INTO[ID_Анкеты] (Название,Вид_обращения, Площадь, Количество_помещений, Местоположение, Этаж, Цена) Values");
            string Stat;
            if (Vlad.Checked == true)
            {
                Stat = Vlad.Text;
            }
            else if (Pok.Checked == true)
            {
                Stat = Pok.Text;
            }
            else
            {
                return;
            }
            string pas = ID.hash(Pas.Text);
            
            sql = new SqlConnection(@"Data Source=S-P-A-2\MSSQLSERVER01;Initial Catalog=Company; Integrated Security=True");
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [ID_Пользователя] (Фамилия, Имя, Отчество, Эл_Почта, Номер_телефона, Пароль, Статус) VALUES (N'{SN.Text}', N'{N.Text}', N'{LN.Text}', N'{EP.Text}', N'{Convert.ToInt64(Num.Text)}', N'{pas}', N'{Stat}')",
                sql);
            SqlCommand command1 = new SqlCommand($"Select Эл_Почта, Пароль FROM ID_Пользователя where Эл_Почта='{EP.Text}' and Пароль = '{pas}'",sql);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            sql.Open();
            
            if (sql.State == ConnectionState.Open)
            {
                adapter.SelectCommand = command1;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Пользователь существует");
                    return;
                }
                vxod.Show();
                this.Hide();
                MessageBox.Show(command.ExecuteNonQuery().ToString());
            }
            sql.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string pas = ID.hash(Pas.Text);
            Pas.Text = pas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
