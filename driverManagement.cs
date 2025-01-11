using FormClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabRental
{
    public partial class driverManagement : Form
    {
        public driverManagement()
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
            if (Did.Text == "" || Dname.Text == "" || Dnum.Text == "" || Davailabal.Text == "")
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
                        string query = "INSERT INTO Drivers1 (driverId, Name, contactNumber, IsAvailable) VALUES (@Did, @Dname, @Dnum, @Davailabal)";
                        MySqlCommand cmd = new MySqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Did", Did.Text);
                        cmd.Parameters.AddWithValue("@Dname", Dname.Text);
                        cmd.Parameters.AddWithValue("@Dnum", Dnum.Text);
                        cmd.Parameters.AddWithValue("@Davailabal", Davailabal.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Successfully Added");
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
            Did.Clear();
            Dname.Clear();
            Dnum.Clear();
            Davailabal.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Did.Text == "")
            {
                MessageBox.Show("Please enter the Driver ID to delete.");
            }
            else
            {
                try
                {
                    string connectionString = $"server=localhost;user=root;password={DatabaseConfig.Password};database=cardb2";

                    using (MySqlConnection Con = new MySqlConnection(connectionString))
                    {
                        Con.Open();
                        string query = "DELETE FROM Drivers1 WHERE driverId = @Did";
                        MySqlCommand cmd = new MySqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Did", Did.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Driver successfully deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Driver ID not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = $"server=localhost;user=root;password={DatabaseConfig.Password};database=cardb2";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Drivers1";
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
