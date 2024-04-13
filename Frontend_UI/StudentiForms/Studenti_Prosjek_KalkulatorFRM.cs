using Backend_Baza;
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
    public partial class Studenti_Prosjek_KalkulatorFRM : Form
    {
        //Korisnici user = new Korisnici();
        double pros = 0.0;
        
        public Studenti_Prosjek_KalkulatorFRM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Studenti_WelcomeFRM welcomefrm = new Studenti_WelcomeFRM(pros, null);
            welcomefrm.Show();
            this.Close();
        }

        private void Studenti_Prosjek_KalkulatorFRM_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                if(Convert.ToDouble(txtEcon.Text)  >=6 && Convert.ToDouble(txtEcon.Text)  <=10 &&
                   Convert.ToDouble(txtPoduz.Text) >=6 && Convert.ToDouble(txtPoduz.Text) <=10 &&
                   Convert.ToDouble(txtBos.Text)   >=6 && Convert.ToDouble(txtBos.Text)   <=10 &&
                   Convert.ToDouble(txtEng.Text)   >=6 && Convert.ToDouble(txtEng.Text)   <=10 &&
                   Convert.ToDouble(txtLog.Text)   >=6 && Convert.ToDouble(txtLog.Text)   <=10 &&
                   Convert.ToDouble(txtSah.Text)   >=6 && Convert.ToDouble(txtSah.Text)   <=10 &&
                   Convert.ToDouble(txtMat.Text)   >=6 && Convert.ToDouble(txtMat.Text)   <=10 &&
                   Convert.ToDouble(txtProg.Text)  >=6 && Convert.ToDouble(txtProg.Text)  <=10 &&
                   Convert.ToDouble(txtBaze.Text)  >=6 && Convert.ToDouble(txtBaze.Text)  <=10 &&
                   Convert.ToDouble(txtMuz.Text)   >=6 && Convert.ToDouble(txtMuz.Text)   <= 10 )
                {
                    double econ  = Convert.ToDouble(txtEcon.Text);
                    double poduz = Convert.ToDouble(txtPoduz.Text);
                    double mat   = Convert.ToDouble(txtMat.Text);
                    double bos   = Convert.ToDouble(txtBos.Text);
                    double eng   = Convert.ToDouble(txtEng.Text);
                    double log   = Convert.ToDouble(txtLog.Text);
                    double sah   = Convert.ToDouble(txtSah.Text);
                    double prog  = Convert.ToDouble(txtProg.Text);
                    double baze  = Convert.ToDouble(txtBaze.Text);
                    double muz   = Convert.ToDouble(txtMuz.Text);

                    pros = (econ + poduz + mat + bos + eng + log + sah + prog + baze + muz) / 10;

                    lblProsjek.Text = pros.ToString();
                }
                else
                    MessageBox.Show("Unesene ocjene moraju biti od 6 do 10!");
            }
        }

        private void txtEcon_Validating(object sender, CancelEventArgs e)
        {
            bool provjera = false;
            int broj = 0;
            provjera = int.TryParse(txtEcon.Text, out broj);

            if (string.IsNullOrEmpty(txtEcon.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEcon, "Polje ne smije biti prazno!");
            }
            else if (provjera == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEcon, "Morate unijeti cijeli broj!");
            }
            else
                errorProvider1.SetError(txtEcon, "");
        }
    }
}
