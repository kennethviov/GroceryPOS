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
    public partial class LoginForm : Form
    {
        string username;
        string password;
        

        public LoginForm()
        {
            InitializeComponent();
            SetPlaceholder();
            AcceptButton = loginBtn;
            signupPanel.Visible = false; // Initially hide the signup panel
        }

        private void SetPlaceholder()
        {
            liUsername.Text = "Username";
            liUsername.ForeColor = Color.Gray;
            suUsername.Text = "Username";
            suUsername.ForeColor = Color.Gray;

            liPassword.Text = "Password";
            liPassword.ForeColor = Color.Gray;
            liPassword.PasswordChar = '\0'; // Show text instead of dots
            suPassword.Text = "Password";
            suPassword.ForeColor = Color.Gray;
            suPassword.PasswordChar = '\0'; // Show text instead of dots
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            username = liUsername.Text;
            password = liPassword.Text;

            if (username == "admin" && password == "admin")
            {
                //TODO: Change logic to redirect to Admin
                MessageBox.Show("Login successfully", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                MainFrame mf = new MainFrame();
                mf.Show();
                this.Hide();
                mf.FormClosed += (s, args) => this.Close();

            }
            else
            {
                MessageBox.Show("Username and Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            username = suUsername.Text;
            password = suPassword.Text;

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

            // TODO: Add logic to save the new user and redirect back to LogIn panel
            // Here, you should insert the user into your database or list
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool UserExists(string username)
        {
            // This should ideally check a database or a list of users
            List<string> existingUsers = new List<string> { "admin", "testUser" }; // Example data
            return existingUsers.Contains(username);
        }

        private void Showpasswordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // if the checkbox is checked, show the password by setting PasswordChar to '\0' (no masking).
            // if unchecked, mask the password with '*'
            liPassword.PasswordChar = showpasswordcheckbox.Checked ? '\0' : '*';
        }

        private void SuOrLi_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Name == "signupHyperLink")
            {
                // Switch to Sign Up
                loginPanel.Visible = false;
                signupPanel.Visible = true;
            }
            else
            {
                // Switch to Log In
                loginPanel.Visible = true;
                signupPanel.Visible = false;
            }
        }
    } 
}
    