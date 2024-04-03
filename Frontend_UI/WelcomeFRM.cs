using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend_UI
{
    public partial class WelcomeFRM : Form
    {
        public WelcomeFRM()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFRM loginForm = new LoginFRM();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterFRM registerFRM = new RegisterFRM();
            registerFRM.Show();
        }
    }
}
