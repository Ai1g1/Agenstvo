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
    public partial class New_anket : Form
    {
        private SqlConnection sql = new SqlConnection(@"Data Source=S-P-A-2\MSSQLSERVER01;Initial Catalog=Company; Integrated Security=True");
        public New_anket()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form back = new Prosmotr_anket_Vlad();
            back.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            sql.Open();
            string v="";
            string stat = null;
            if (Ar.Checked == true)
            {
                stat = Ar.Text;
            }
            else if (Pok.Checked == true)
            {
                stat = Pok.Text;
            }
            else
            {
                return;
            }
            if (N.Text.Length<1 || S2.Text.Length < 1 || NP.Text.Length < 1 || Loc.Text.Length < 1 || Etah.Text.Length < 1 || Money.Text.Length < 1)
            {
                sql.Close();
                return;
            }
            try
            {
                v = $"INSERT INTO[ID_Анкеты] (Название,Вид_обращения, Площадь," +
                $" Количество_помещений, Местоположение, Этаж, Цена, ID_Владельца)" +
                $" Values (N'{N.Text}',N'{stat}',N'{Convert.ToInt32(S2.Text)}',N'{NP.Text}" +
                $"',N'{Loc.Text}',N'{Convert.ToInt32(Etah.Text)}',N'{Convert.ToInt32(Money.Text)}',N'{ID.id_vlad}')";
            }
            catch
            {
                MessageBox.Show("Данные неверно введены");
                sql.Close();
                return;
            }
            v = $"INSERT INTO[ID_Анкеты] (Название,Вид_обращения, Площадь," +
            $" Количество_помещений, Местоположение, Этаж, Цена, ID_Владельца)" +
            $" Values (N'{N.Text}',N'{stat}',N'{Convert.ToInt32(S2.Text)}',N'{NP.Text}" +
            $"',N'{Loc.Text}',N'{Convert.ToInt32(Etah.Text)}',N'{Convert.ToInt32(Money.Text)}',N'{ID.id_vlad}')";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand verifikator = new SqlCommand(v, sql);
            if (sql.State == ConnectionState.Open)
            {
                adapter.SelectCommand = verifikator;
                if (verifikator.ExecuteNonQuery().ToString() == "1")
                    MessageBox.Show("Анкета успешно создана");
            }
            sql.Close();
        }
    }
}
