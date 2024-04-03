using Frontend_UI.Ucenici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend_UI.StudentiForms
{
    public partial class Studenti_Pregled_ProfilaFRM : Form
    {
        public Studenti_Pregled_ProfilaFRM()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Studenti_WelcomeFRM studWelcome = new Studenti_WelcomeFRM();
            studWelcome.Show();
            this.Close();
        }
    }
}
