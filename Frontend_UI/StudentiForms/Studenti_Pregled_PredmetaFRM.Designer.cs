﻿namespace Frontend_UI.StudentiForms
{
    partial class Studenti_Pregled_PredmetaFRM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazivPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivPredmeta,
            this.sifraPredmeta});
            this.dataGridView1.Location = new System.Drawing.Point(28, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // nazivPredmeta
            // 
            this.nazivPredmeta.DataPropertyName = "nazivPredmeta";
            this.nazivPredmeta.HeaderText = "Predmet";
            this.nazivPredmeta.Name = "nazivPredmeta";
            // 
            // sifraPredmeta
            // 
            this.sifraPredmeta.DataPropertyName = "sifraPredmeta";
            this.sifraPredmeta.HeaderText = "Sifra";
            this.sifraPredmeta.Name = "sifraPredmeta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Studenti_Pregled_PredmetaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Studenti_Pregled_PredmetaFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vasi Predmeti";
            this.Load += new System.EventHandler(this.Studenti_Pregled_PredmetaFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraPredmeta;
        private System.Windows.Forms.Button button1;
    }
}