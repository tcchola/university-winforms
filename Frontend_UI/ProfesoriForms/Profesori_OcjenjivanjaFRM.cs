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
    public partial class Profesori_OcjenjivanjaFRM : Form
    {
        public Profesori_OcjenjivanjaFRM()
        {
            InitializeComponent();
        }

        private void Profesori_OcjenjivanjaFRM_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProfesoriDA.getOcjeneProf();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Profesori_WelcomeFRM wlcmprof = new Profesori_WelcomeFRM(null);
            wlcmprof.Show();
            this.Close();
        }
    }
}
