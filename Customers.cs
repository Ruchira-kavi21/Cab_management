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
using FormClass;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;


namespace CabRental
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
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
                        string query = "INSERT INTO Users (UserId, UserName, UserPassword) VALUES (@Uid, @Uname, @Upass)";
                        MySqlCommand cmd = new MySqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Uid", Uid.Text);
                        cmd.Parameters.AddWithValue("@Uname", Uname.Text);
                        cmd.Parameters.AddWithValue("@Upass", Upass.Text);
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

        private void button6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
    
}
