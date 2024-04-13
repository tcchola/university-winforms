namespace Frontend_UI.Ucenici
{
    partial class Studenti_WelcomeFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studenti_WelcomeFRM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentiMenu = new System.Windows.Forms.MenuStrip();
            this.mojProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledProfilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmijeniPodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziMojeOcjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPredmetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izracunajProsjekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.studentiMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // studentiMenu
            // 
            this.studentiMenu.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojProfilToolStripMenuItem,
            this.ocjeneToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.izracunajProsjekToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.studentiMenu.Location = new System.Drawing.Point(0, 0);
            this.studentiMenu.Name = "studentiMenu";
            this.studentiMenu.Size = new System.Drawing.Size(693, 27);
            this.studentiMenu.TabIndex = 11;
            // 
            // mojProfilToolStripMenuItem
            // 
            this.mojProfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledProfilaToolStripMenuItem,
            this.izmijeniPodatkeToolStripMenuItem});
            this.mojProfilToolStripMenuItem.Name = "mojProfilToolStripMenuItem";
            this.mojProfilToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.mojProfilToolStripMenuItem.Text = "Moj Profil";
            // 
            // pregledProfilaToolStripMenuItem
            // 
            this.pregledProfilaToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F);
            this.pregledProfilaToolStripMenuItem.Name = "pregledProfilaToolStripMenuItem";
            this.pregledProfilaToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.pregledProfilaToolStripMenuItem.Text = "Pregled profila";
            this.pregledProfilaToolStripMenuItem.Click += new System.EventHandler(this.pregledProfilaToolStripMenuItem_Click);
            // 
            // izmijeniPodatkeToolStripMenuItem
            // 
            this.izmijeniPodatkeToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F);
            this.izmijeniPodatkeToolStripMenuItem.Name = "izmijeniPodatkeToolStripMenuItem";
            this.izmijeniPodatkeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.izmijeniPodatkeToolStripMenuItem.Text = "Izmijeni podatke";
            this.izmijeniPodatkeToolStripMenuItem.Click += new System.EventHandler(this.izmijeniPodatkeToolStripMenuItem_Click);
            // 
            // ocjeneToolStripMenuItem
            // 
            this.ocjeneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziMojeOcjeneToolStripMenuItem});
            this.ocjeneToolStripMenuItem.Name = "ocjeneToolStripMenuItem";
            this.ocjeneToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.ocjeneToolStripMenuItem.Text = "Ocjene";
            // 
            // prikaziMojeOcjeneToolStripMenuItem
            // 
            this.prikaziMojeOcjeneToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prikaziMojeOcjeneToolStripMenuItem.Name = "prikaziMojeOcjeneToolStripMenuItem";
            this.prikaziMojeOcjeneToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.prikaziMojeOcjeneToolStripMenuItem.Text = "Prikazi moje ocjene";
            this.prikaziMojeOcjeneToolStripMenuItem.Click += new System.EventHandler(this.prikaziMojeOcjeneToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledPredmetaToolStripMenuItem});
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            // 
            // pregledPredmetaToolStripMenuItem
            // 
            this.pregledPredmetaToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F);
            this.pregledPredmetaToolStripMenuItem.Name = "pregledPredmetaToolStripMenuItem";
            this.pregledPredmetaToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.pregledPredmetaToolStripMenuItem.Text = "Pregled predmeta";
            this.pregledPredmetaToolStripMenuItem.Click += new System.EventHandler(this.pregledPredmetaToolStripMenuItem_Click);
            // 
            // izracunajProsjekToolStripMenuItem
            // 
            this.izracunajProsjekToolStripMenuItem.Name = "izracunajProsjekToolStripMenuItem";
            this.izracunajProsjekToolStripMenuItem.Size = new System.Drawing.Size(147, 23);
            this.izracunajProsjekToolStripMenuItem.Text = "Izracunaj Prosjek";
            this.izracunajProsjekToolStripMenuItem.Click += new System.EventHandler(this.izracunajProsjekToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dobro Došli";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Roboto Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(200, 79);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 25);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Thin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vaš prosjek";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProsjek.Location = new System.Drawing.Point(39, 185);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(42, 25);
            this.lblProsjek.TabIndex = 17;
            this.lblProsjek.Text = "0.0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Studenti_WelcomeFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentiMenu);
            this.MainMenuStrip = this.studentiMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Studenti_WelcomeFRM";
            this.Text = "Welcome Students";
            this.Load += new System.EventHandler(this.Studenti_WelcomeFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.studentiMenu.ResumeLayout(false);
            this.studentiMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip studentiMenu;
        private System.Windows.Forms.ToolStripMenuItem ocjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziMojeOcjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPredmetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izracunajProsjekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledProfilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmijeniPodatkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}