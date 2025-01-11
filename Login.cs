using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabRental
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Role.Items.Add("Admin");
            Role.Items.Add("Customer");
            Role.Items.Add("Driver");
            Role.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = Role.SelectedItem.ToString();

            if (role == "Admin")
            {
                if (username == "admin" && password == "admin")
                {
                    MessageBox.Show("Hi there! You're now logged in as a admin.");
                    AdminDashbord obj = new AdminDashbord();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }

            else if (role == "Customer")
            {
                User user = new User { Username = username, Password = password };
                if (VerifyLoginUser.VerifyUserCredentials(username, password))
                {
                    MessageBox.Show("Hi there! You're now logged in as a customer.");
                    UserInterface obj = new UserInterface();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else if (role == "Driver")
            {
                Driver1 driver = new Driver1 { Username = username, Password = password };
                if (VerifyLoginDriver.VerifyDriverCredentials(username, password))
                {
                    MessageBox.Show("Hi there! You're now logged in as a driver.");
                    driverInterface obj = new driverInterface();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

            }
            else
            {
                MessageBox.Show("login failed!");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            Role.SelectedIndex = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserSignUp obj = new UserSignUp();
            obj.Show();
            this.Hide();
        }
    }
    

}
