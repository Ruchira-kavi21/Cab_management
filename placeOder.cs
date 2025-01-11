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
    public partial class placeOder : Form
    {
        public placeOder()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInterface obj = new UserInterface();
            obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Oderid.Text == "" || CusID.Text == "" || DrId.Text == "" || CrId.Text == "" || CLocation.Text == "" || D.Text == "")
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
                        string query = "INSERT INTO Orders3 (OrderId, CustomerId, DriverId, CarId, CurrentLocation, Destination) VALUES (@Oderid, @CusID, @DrId, @CrId, @CLocation, @D)";
                        MySqlCommand cmd = new MySqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Oderid", Oderid.Text);
                        cmd.Parameters.AddWithValue("@CusID", CusID.Text);
                        cmd.Parameters.AddWithValue("@DrId", DrId.Text);
                        cmd.Parameters.AddWithValue("@CrId", CrId.Text);
                        cmd.Parameters.AddWithValue("@CLocation", CLocation.Text);
                        cmd.Parameters.AddWithValue("@D", D.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Oder Successfully Added");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Oderid.Clear();
            CusID.Clear();
            DrId.Clear();
            CrId.Clear();
            CLocation.Clear();
            D.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = $"server=localhost;user=root;password={DatabaseConfig.Password};database=cardb2";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Orders3";
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
    }
}
