using Backend_Baza.Data;
using Frontend_UI.Profesori;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend_UI.ProfesoriForms
{
    public partial class Profesori_PredmetiFRM : Form
    {
        public Profesori_PredmetiFRM()
        {
            InitializeComponent();
        }

        private void Profesori_PredmetiFRM_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProfesoriDA.getPredmeteProf();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Profesori_WelcomeFRM wlcmprof = new Profesori_WelcomeFRM(null);
            wlcmprof.Show();
            this.Close();
        }
    }
}
