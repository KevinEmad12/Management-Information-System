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
    public partial class Window9 : Form
    {
        public Window9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KEVIN-EMAD;Initial Catalog=Project MIS;Integrated Security=True");

            string A_Username, A_Password;
            A_Username = textBox1.Text;
            A_Password = textBox2.Text;

            try
            {
                string query = "SELECT * FROM Customer where A_Username='" + textBox1.Text + "' AND A_password='" + textBox2.Text + "'";
                SqlDataAdapter ada = new SqlDataAdapter(query, con);

                DataTable dTable = new DataTable();
                ada.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    A_Username = textBox1.Text;
                    A_Password = textBox2.Text;

                    Window10 fm = new Window10();
                    fm.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Login Detials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
