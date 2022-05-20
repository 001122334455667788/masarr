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
namespace MASAR
{
    public partial class Attendant : Form
    {
        public Attendant()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Salma Mahmoud\Downloads\Airline-1.mdf;Integrated Security = True; Connect Timeout = 30");
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (salary.Text == "" || airline_id.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Person values (" + salary.Text + ",'" + airline_id.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record added successfully");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
