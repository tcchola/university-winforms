﻿using System;
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
using Frontend_UI.Profesori;
using Frontend_UI.Ucenici;

namespace Frontend_UI
{
    public partial class LoginFRM : Form
    {
        public LoginFRM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeFRM welcome = new WelcomeFRM();
            welcome.Show();
            this.Close();
        }

        private void LoginFRM_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    Korisnici korisnik = Account.Login(txtUsername.Text, txtPassword.Text);

                    if (korisnik.isProfesor == true)
                    {
                        Profesori_WelcomeFRM profesori_WelcomeFRM = new Profesori_WelcomeFRM();
                        profesori_WelcomeFRM.Show();
                        this.Close();
                    }
                    else if (korisnik.isProfesor == false)
                    {
                        Studenti_WelcomeFRM studenti_WelcomeFRM = new Studenti_WelcomeFRM();
                        studenti_WelcomeFRM.Show();
                        this.Close();
                    }
                }
                else if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Login fileds cannot be empty!");
                }
                //ugradit provjeru da li uopste postoji user koji je unesen
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Morate unijeti korisnicko ime!");
            }
            else
                errorProvider1.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Morate unijeti lozinku!");
            }
            else
                errorProvider1.SetError(txtPassword, "");
        }
    }
}