using Backend_Baza;
using Frontend_UI.StudentiForms;
using Frontend_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend_UI.Ucenici
{
    public partial class Studenti_WelcomeFRM : Form
    {
        public Studenti_WelcomeFRM(double pros, string username)
        {
            InitializeComponent();

            lblProsjek.Text = pros.ToString();
            lblUsername.Text = username;
        }

        private void Studenti_WelcomeFRM_Load(object sender, EventArgs e)
        {

        }
        private void pregledProfilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenti_Pregled_ProfilaFRM pregledFRM = new Studenti_Pregled_ProfilaFRM();
            pregledFRM.Show();
        }

        private void izmijeniPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenti_Izmijeni_ProfilFRM izmijeniFRM = new Studenti_Izmijeni_ProfilFRM();
            izmijeniFRM.Show();
        }

        private void prikaziMojeOcjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenti_Prikazi_OcjeneFRM prikaziOcjnFRM = new Studenti_Prikazi_OcjeneFRM();
            prikaziOcjnFRM.Show();
        }

        private void pregledPredmetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenti_Pregled_PredmetaFRM pregledPredFRM = new Studenti_Pregled_PredmetaFRM();
            pregledPredFRM.Show();
        }

        private void izracunajProsjekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenti_Prosjek_KalkulatorFRM prosjekCalcFRM = new Studenti_Prosjek_KalkulatorFRM();
            prosjekCalcFRM.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFRM login = new LoginFRM();
            login.Show();
        }
    }
}
