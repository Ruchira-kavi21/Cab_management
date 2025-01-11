using FormClass;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabRental
{
    public partial class addCars : Form
    {
        public addCars()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashbord obj = new AdminDashbord();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Cid.Text == "" || Cmodel.Text == "" || Cplate.Text == "" || Cavailabl.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    string connectionString = $"server=localhost;user=root;password={DatabaseConfig.Password};database=cardb2";

                    using (MySqlConnection Con = new MySqlConnection(connectionString))
                    {
                        Con.Open();
                        string query = "INSERT INTO Cars (carId, Model, plateNumber, IsAvailable) VALUES (@Cid, @Cmodel, @Cplate, @Cavailabl)";
                        MySqlCommand cmd = new MySqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Cid", Cid.Text);
                        cmd.Parameters.AddWithValue("@Cmodel", Cmodel.Text);
                        cmd.Parameters.AddWithValue("@Cplate", Cplate.Text);
                        cmd.Parameters.AddWithValue("@Cavailabl", Cavailabl.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car Successfully Added");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cid.Clear();
            Cmodel.Clear();
            Cplate.Clear();
            Cavailabl.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Cid.Text == "")
            {
                MessageBox.Show("Please enter the Car ID to delete.");
            }
            else
            {
                try
                {
                    string connectionString = $"server=localhost;user=root;password={DatabaseConfig.Password};database=cardb2";

                    using (MySqlConnection Con = new MySqlConnection(connectionString))
                    {
                        Con.Open();
                        string query = "DELETE FROM Cars WHERE CarId = @Cid";
                        MySqlCommand cmd = new MySqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Cid", Cid.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car successfully deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Car ID not found.");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = $"server=localhost;user=root;password={DatabaseConfig.Password};database=cardb2";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Cars";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
