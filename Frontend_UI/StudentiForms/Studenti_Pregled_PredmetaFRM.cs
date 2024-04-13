using Backend_Baza.Data;
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
    public partial class Studenti_Pregled_PredmetaFRM : Form
    {
        public Studenti_Pregled_PredmetaFRM()
        {
            InitializeComponent();
        }

        private void Studenti_Pregled_PredmetaFRM_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentiDA.getPredmete();
        }
    }
}
