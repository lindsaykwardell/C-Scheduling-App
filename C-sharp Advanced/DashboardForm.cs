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
    public partial class DashboardForm : Form
    {
        private User activeUser;

        public DashboardForm()
        {
            InitializeComponent();
            LoginForm login = new LoginForm();
            if (login.ShowDialog(this) == DialogResult.OK)
            {
                this.activeUser = login.activeUser;
                UsernameLabel.Text = this.activeUser.userName;
            }
        }
    }
}
