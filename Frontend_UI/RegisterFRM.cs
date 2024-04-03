using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend_Baza;
using Backend_Baza.Data;
//using Frontend_UI.StudentiForms;

namespace Frontend_UI
{
    public partial class RegisterFRM : Form
    {
        Korisnici korisnik = new Korisnici();                                   // globalni objekat korisnika za registraciju
        Backend_Baza.Profesori prof = new Backend_Baza.Profesori();
        Studenti student = new Studenti();

        public RegisterFRM()
        {
            InitializeComponent();
        }

        private void RegisterNewUser()                                          // unosi se novi korisnik samo u Korisnici tabelu
        {
            korisnik.ime = txtFirstName.Text;
            korisnik.prezime = txtLastName.Text;
            korisnik.email = txtEmail.Text;
            korisnik.username = txtUsername.Text;
            korisnik.pssw = txtPassword.Text;
            korisnik.datumRodjenja = dtpBirth.Value;
            korisnik.isProfesor = chkProfessor.Checked;
            korisnik.gradID = cmbxGrad.SelectedIndex;

            Account.CreateNewUser(korisnik);
        }

        private void RegisterNewProfessor()
        {
            prof.imeProfesora=korisnik.ime;
            prof.prezimeProfesora = korisnik.prezime;
            prof.datumRodjenjaProfesora = korisnik.datumRodjenja;
            prof.gradID = Convert.ToInt32(korisnik.gradID);
            prof.emailProfesora=korisnik.email;
            // zvanje cu rucno unositi na bazi
        }
        
        private void RegisterNewStudent()
        {
            student.imeStudenta = korisnik.ime;
            student.prezimeStudenta = korisnik.prezime;
            student.datumRodjenjaStudenta = korisnik.datumRodjenja;
            student.gradID = Convert.ToInt32(korisnik.gradID);
            student.emailStudenta = korisnik.email;
            student.indexStudenta = txtIndex.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeFRM welcome = new WelcomeFRM();
            welcome.Show();
            this.Close();
        }

        private void RegisterFRM_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';                                     // maskiramo lozinku
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }

            cmbxGrad.DataSource=KorisniciDA.getGradoveCMBX();
            cmbxGrad.DisplayMember = "gradDrzava";
            cmbxGrad.ValueMember = "gradID";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                RegisterNewUser();                                              // unosimo novog korisnika
                
                if(korisnik.isProfesor == chkProfessor.Checked)                   // ako je korisnik registrovan kao profesor unosimo te podatke u Profesori tabelu
                    RegisterNewProfessor();
                else if (korisnik.isProfesor != chkProfessor.Checked)           // ako je korisnik registrovan kao student unosimo te podatke u Studenti tabelu
                    RegisterNewStudent();

                LoginFRM login = new LoginFRM();
                login.Show();
                this.Close();
            }
        }
        //-----------------VALIDACIJA-----------------//
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Morate unijeti svoje ime!");
            }
            else
                errorProvider1.SetError(txtFirstName, "");
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Morate unijeti svoje prezime!");
            }
            else
                errorProvider1.SetError(txtLastName, "");
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Morate unijeti svoje korisnicko ime!");
            }
            else
                errorProvider1.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Morate napraviti svoju lozinku!");
            }
            else
                errorProvider1.SetError(txtPassword, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Morate napraviti svoju e-mail adresu!");
            }
            else
                errorProvider1.SetError(txtEmail, "");
        }
        //------------SAKRIJ INDEX AKO JE PROFESOR------------//
        private void chkProfessor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProfessor.Checked == true)
            {
                lblIndex.Hide();
                txtIndex.Hide();
                txtIndex.Text = "";
            }
            else if (chkProfessor.Checked == false)
            {
                lblIndex.Show();
                txtIndex.Show();
            }
        }
    }
}
