using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Form
{
    public partial class Form_Login : Form
    {
        // A simple in-memory dictionary to act as a small database for storing usernames and passwords
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>
        {
            { "admin", "password123" },
            { "user1", "pass1" },
            { "user2", "pass2" }
        };
        public Form_Login()
        {
            InitializeComponent();
        }

        private void txt_Login_Click(object sender, EventArgs e)
        {
            // Retrieve the username and password from the input fields
            string username = txt_Username.Text;
            string password = txt_Password.Text;

            // Validate the credentials against the in-memory user database
            if (userDatabase.ContainsKey(username) && userDatabase[username] == password)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the main application window (frmEmployee)
                Form_Info mainForm = new Form_Info();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear the password field for security reasons
                txt_Password.Clear();
                txt_Password.Focus();
            }
        }

        // Function to add a new user and password to the database
        private void AddNewUser(string username, string password)
        {
            if (userDatabase.ContainsKey(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userDatabase.Add(username, password);
                MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
