using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenstvo
{
    public partial class Agenstvo : Form
    {
        public Agenstvo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Vxod vxod = new Vxod();     
            vxod.Show();
            this.Hide();
        }

        private void Agenstvo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
