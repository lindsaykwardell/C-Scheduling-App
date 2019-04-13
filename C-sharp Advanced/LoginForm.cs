using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Advanced
{
    public partial class LoginForm : Form
    {
        public User activeUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private databaseEntities dbConnect = new databaseEntities();

        private void loginButton_Click(object sender, EventArgs e)
        {
            string Username = userNameTextBox.Text;
            string Password = passwordTextBox.Text;

            var query = dbConnect.Users.Where(u => u.userName == Username);

            if (!query.Any())
            {
                MessageBox.Show("No user found!");
            }

            else
            {
                var passwordMatches = query.Where(u => u.password == Password);
                if (!passwordMatches.Any())
                {
                    MessageBox.Show("Username and password do not match.");
                }
                else
                {
                    User user = passwordMatches.First();
                    MessageBox.Show("Welcome, " + user.userName + "!");
                    this.activeUser = user;
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            string Username = userNameTextBox.Text;
            string Password = passwordTextBox.Text;

            User newUser = new User();
            newUser.userName = Username;
            newUser.password = Password;
            newUser.active = 1;
            newUser.createDate = new DateTime();
            newUser.createdBy = Username;

            if (dbConnect.Users.Where(u => u.userName == newUser.userName).Any())
            {
                MessageBox.Show("A user with that name already exists.");
            }
            else
            {
                User saved = dbConnect.Users.Add(newUser);
                dbConnect.SaveChanges();

                MessageBox.Show("Registered! Welcome, " + saved.userName + "!");
                this.activeUser = saved;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
