using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMIS
{
    public partial class Window4 : Form
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Sportsbutton1_Click(object sender, EventArgs e)
        {
            Window6 fm = new Window6();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Window5 fm = new Window5();
            fm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
