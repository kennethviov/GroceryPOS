using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryPOS.Screens;

namespace GroceryPOS
{
    public partial class loginForm : Form
    {
        string username;
        string password;
        

        public loginForm()
        {
            InitializeComponent();
            setPlaceholder();
            AcceptButton = button1;
        }

        private void setPlaceholder()
        {
            usernameTextBox.Text = "Username";
            usernameTextBox.ForeColor = Color.Gray;

            passwordTextBox.Text = "Password";
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.PasswordChar = '\0'; // Show text instead of dots
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            if (username == "admin" && password == "admin")
            {
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

        private void showpasswordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // if the checkbox is checked, show the password by setting PasswordChar to '\0' (no masking).
            // if unchecked, mask the password with '*'
            passwordTextBox.PasswordChar = showpasswordcheckbox.Checked ? '\0' : '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            signinForm sf = new signinForm();
            sf.Show();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue; // Change text color when hovered
            label3.Font = new Font(label3.Font, FontStyle.Underline); // Underline text
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black; // Revert text color when not hovered
            label3.Font = new Font(label3.Font, FontStyle.Regular); // Remove under
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
    