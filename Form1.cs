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

namespace David_Satterfield_Unit9_IT481
{
    public partial class Form1 : Form
    {


        private void Form1_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = @"Data Source=DESKTOP-AGRJKOJ\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
                    connection.Open();

                    CheckconnectionLabel.Text = "Connection Succesful";

                    connection.Close();
                }
                catch (Exception ex)

                {
                    MessageBox.Show("Error, " + ex);
                }
            }

        }

        private void ViewDatabase_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-AGRJKOJ\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from Customers";









            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);


            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void CountRecords_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-AGRJKOJ\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select count(*)  from Customers";

            int count = (int)command.ExecuteScalar();
            lblCount.Text = count.ToString();

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-AGRJKOJ\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from Employees";

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);


            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}