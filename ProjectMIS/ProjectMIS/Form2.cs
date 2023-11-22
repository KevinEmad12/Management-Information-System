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
    public partial class Window2 : Form
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void Window2_Load(object sender, EventArgs e)
        {

        }

        private void LOGINbutton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KEVIN-EMAD;Initial Catalog=Project MIS;Integrated Security=True");

            string C_Username, C_Password;
            C_Username = textBox1.Text;
            C_Password = textBox2.Text;

            try
            {
                string query = "SELECT * FROM Customer where C_Username='" + textBox1.Text + "' AND C_password='" + textBox2.Text + "'";
                SqlDataAdapter ada = new SqlDataAdapter(query, con);

                DataTable dTable = new DataTable();
                ada.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    C_Username = textBox1.Text;
                    C_Password = textBox2.Text;

                    Window4 fm = new Window4();
                    fm.Show();

                    
                }
                else
                {
                    MessageBox.Show("Invalid Login Detials","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void Clearbutton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exitbutton2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Window1 fm = new Window1();
                fm.Show();
            }
            else
            {
                this.Show();
            }
        }
    }
}
