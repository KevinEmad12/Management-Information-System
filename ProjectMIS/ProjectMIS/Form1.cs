using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectMIS
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=KEVIN-EMAD;Initial Catalog=Project MIS;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            Window2 fm = new Window2();
            fm.Show();
        }

        private void SignUpbutton2_Click(object sender, EventArgs e)
        {
            Window3 fm1 = new Window3();
            fm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Window4 fm2 = new Window4();
            fm2.Show();
        }
    }
}
