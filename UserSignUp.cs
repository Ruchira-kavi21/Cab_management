using FormClass;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CabRental
{
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == "")
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
                        string query = "INSERT INTO Customers1 (Name, Password) VALUES (@txtName, @txtPassword)";
                        MySqlCommand cmd = new MySqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@txtName", txtName.Text);
                        cmd.Parameters.AddWithValue("@txtPassword", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Successfully Added");
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
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
        }
    }

}
