using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRG282_Project_1
{
    public partial class frmLogin : Form
    {
        string filePath;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            LoginValidation loginValidation = new LoginValidation();

            if (loginValidation.Validate(username,password) == true)
            {
                MainMenu mainMenu = new MainMenu();
                MessageBox.Show("Login Successful !", "Login Validation");
                this.Hide();
                mainMenu.Show();
            }
            else if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password field cannot be empty");
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username field cannot be empty");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password field cannot be empty");
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                tbxPassword.Clear();
                tbxUsername.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            LoginValidation loginValidation = new LoginValidation();
            FileHandler fileHandler = new FileHandler();

            if (loginValidation.Validate(username) == true)
            {
                MessageBox.Show("Username already exists, please enter a new one");
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please Enter a valid username");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter a valid password");
            }
            else if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a valid username and password");
            }
            else
            {
                fileHandler.Write(username, password);
                MessageBox.Show("You are now registered");
                tbxUsername.Clear();
                tbxPassword.Clear();
            }
        }
    }
}
