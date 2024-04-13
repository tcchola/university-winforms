namespace Frontend_UI.Profesori
{
    partial class Profesori_WelcomeFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesori_WelcomeFRM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentiMenu = new System.Windows.Forms.MenuStrip();
            this.mojProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledProfilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmijeniPodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziMojeOcjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPredmetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.studentiMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // studentiMenu
            // 
            this.studentiMenu.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojProfilToolStripMenuItem,
            this.ocjeneToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.studentiMenu.Location = new System.Drawing.Point(0, 0);
            this.studentiMenu.Name = "studentiMenu";
            this.studentiMenu.Size = new System.Drawing.Size(800, 27);
            this.studentiMenu.TabIndex = 12;
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
            // 
            // izmijeniPodatkeToolStripMenuItem
            // 
            this.izmijeniPodatkeToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F);
            this.izmijeniPodatkeToolStripMenuItem.Name = "izmijeniPodatkeToolStripMenuItem";
            this.izmijeniPodatkeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.izmijeniPodatkeToolStripMenuItem.Text = "Izmijeni podatke";
            // 
            // ocjeneToolStripMenuItem
            // 
            this.ocjeneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziMojeOcjeneToolStripMenuItem});
            this.ocjeneToolStripMenuItem.Name = "ocjeneToolStripMenuItem";
            this.ocjeneToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.ocjeneToolStripMenuItem.Text = "Ocjenjivanja";
            // 
            // prikaziMojeOcjeneToolStripMenuItem
            // 
            this.prikaziMojeOcjeneToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prikaziMojeOcjeneToolStripMenuItem.Name = "prikaziMojeOcjeneToolStripMenuItem";
            this.prikaziMojeOcjeneToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.prikaziMojeOcjeneToolStripMenuItem.Text = "Prikaži moja ocjenjivanja";
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
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Profesori_WelcomeFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.studentiMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Profesori_WelcomeFRM";
            this.Text = "Professors Home";
            this.Load += new System.EventHandler(this.Profesori_WelcomeFRM_Load);
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
        private System.Windows.Forms.ToolStripMenuItem mojProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledProfilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmijeniPodatkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziMojeOcjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPredmetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}