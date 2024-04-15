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
            this.ocjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziMojeOcjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPredmetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.studentiMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 80);
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
            this.ocjeneToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.studentiMenu.Location = new System.Drawing.Point(0, 0);
            this.studentiMenu.Name = "studentiMenu";
            this.studentiMenu.Size = new System.Drawing.Size(554, 27);
            this.studentiMenu.TabIndex = 12;
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
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Roboto Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(213, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 25);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dobro Došli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "You are logged in as a professor of this university.";
            // 
            // Profesori_WelcomeFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ToolStripMenuItem ocjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziMojeOcjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPredmetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}