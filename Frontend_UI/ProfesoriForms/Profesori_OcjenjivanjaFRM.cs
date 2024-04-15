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

namespace Frontend_UI.ProfesoriForms
{
    public partial class Profesori_OcjenjivanjaFRM : Form
    {
        int profID;

        public Profesori_OcjenjivanjaFRM(int professorID)
        {
            InitializeComponent();
            this.profID=professorID;
        }

        private void Profesori_OcjenjivanjaFRM_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProfesoriDA.getOcjeneProf(profID);
        }
    }
}
