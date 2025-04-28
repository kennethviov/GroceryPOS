using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryPOS
{
    public partial class SignupForm : Form
    {
        String username;
        String password;

        bool UserExist = true; // This should be a method, not a boolean variable

        public SignupForm()
        {
            InitializeComponent();
            setPlaceholder();
            

        }

        private void setPlaceholder()
        {
            usernameTextBox.Text = "Username";
            usernameTextBox.ForeColor = Color.Gray;

            passwordTextBox.Text = "Password";
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.PasswordChar = '\0'; // Show text instead of dots
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue; // change text color when hovered
            label3.Font = new Font(label3.Font, FontStyle.Underline); // Underline text
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black; // revert text color when not hovered
            label3.Font = new Font(label3.Font, FontStyle.Regular); // remove underline
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            if (UserExists(username))
            {
                MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Here, you should insert the user into your database or list
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Simulated method for checking if a user exists (without a database)
        private bool UserExists(string username)
        {
            // This should ideally check a database or a list of users
            List<string> existingUsers = new List<string> { "admin", "testUser" }; // Example data
            return existingUsers.Contains(username);
        }

        private void showpasswordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showpasswordcheckbox.Checked ? '\0' : '*';
        }

        // username placeholder
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.Black;
               
            }
        }
            
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                usernameTextBox.Text = "Username";
                usernameTextBox.ForeColor = Color.Gray;
               
            }

        }

        // password placeholder
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.Gray;
                passwordTextBox.PasswordChar = '\0';
            }
        }
    }
}
