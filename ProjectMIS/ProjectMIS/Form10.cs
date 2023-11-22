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
    public partial class Window10 : Form
    {
        public Window10()
        {
            InitializeComponent();
        }

        private void Window10_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KEVIN-EMAD;Initial Catalog=Project MIS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Product
           (PID
           ,Product_Name
           ,Product_Type
           ,Product_Type_Count
           ,P_Price
           ,Status
           ,Category_ID)
     VALUES
           ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4 + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7 + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Successfully");
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KEVIN-EMAD;Initial Catalog=Project MIS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE Product
   SET PID = PID
      ,Product_Name = Product_Name
      ,Product_Type = Product_Type
      ,Product_Type_Count = Product_Type_Count
      ,P_Price = P_Price
      ,Status = Status
      ,Category_ID = Category_ID 
       WHERE PID = PID", con);
            cmd.Parameters.AddWithValue("@PID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Product_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Product_Type", textBox3.Text);
            cmd.Parameters.AddWithValue("@Product_Type_Count", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@P_Price", float.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Status", textBox6.Text);
            cmd.Parameters.AddWithValue("@Category_ID", int.Parse(textBox7.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KEVIN-EMAD;Initial Catalog=Project MIS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Product
      WHERE PID = PID ", con);
            cmd.Parameters.AddWithValue("@PID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully");
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KEVIN-EMAD;Initial Catalog=Project MIS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Product WHERE PID = PID AND Product_Name = Product_Name", con);
            cmd.Parameters.AddWithValue("@PID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Product_Name", textBox2.Text);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable dTable = new DataTable();
            ada.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
