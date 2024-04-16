using System;
using Backend_Baza;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frontend_UI.ProfesoriForms;

namespace Frontend_UI.Profesori
{
    public partial class Profesori_WelcomeFRM : Form
    {
        Backend_Baza.Profesori prof = new Backend_Baza.Profesori();

        public Profesori_WelcomeFRM(string username)
        {
            InitializeComponent();

            lblUsername.Text = username;
        }

        private void Profesori_WelcomeFRM_Load(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFRM login = new LoginFRM(0, 0);
            login.Show();
        }

        private void pregledPredmetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesori_PredmetiFRM profPredmeti = new Profesori_PredmetiFRM();
            profPredmeti.Show();
            this.Hide();
        }

        private void prikaziMojeOcjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesori_OcjenjivanjaFRM ocjn = new Profesori_OcjenjivanjaFRM();
            ocjn.Show();
            this.Hide();
        }
    }
}
