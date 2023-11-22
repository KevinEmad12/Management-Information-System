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
    public partial class Window3 : Form
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordlabel4_Click(object sender, EventArgs e)
        {

        }

        private void Window3_Load(object sender, EventArgs e)
        {

        }

        private void SIGNUPbutton1_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection("Data Source=KEVIN-EMAD;Initial Catalog=Project MIS;Integrated Security=True");
            string g;
            if(FradioButton1.Checked == true)
            {
                g = "Female";
            }
            else
            {
                g = "Male";
            }
           con.Open();
           SqlCommand cmd = new SqlCommand(@"INSERT INTO Customer
           (Customer_Name
           ,DOB
           ,C_Email
           ,C_Username
           ,C_Password
           ,C_PhoneNo
           ,C_Gender
           ,C_Address)
           
     VALUES
           ('"+textBox1.Text+"','"+dateTimePicker1.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+g+"','"+textBox7.Text+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered Successfully");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FradioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MradioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
