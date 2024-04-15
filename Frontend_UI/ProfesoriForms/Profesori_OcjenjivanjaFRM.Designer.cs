namespace Frontend_UI.ProfesoriForms
{
    partial class Profesori_OcjenjivanjaFRM
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
            this.ocjenaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ocjenaID,
            this.nazivPredmeta,
            this.ocjena,
            this.datum,
            this.student});
            this.dataGridView1.Location = new System.Drawing.Point(84, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // ocjenaID
            // 
            this.ocjenaID.DataPropertyName = "ocjenaID";
            this.ocjenaID.HeaderText = "ocjenaID";
            this.ocjenaID.Name = "ocjenaID";
            this.ocjenaID.Visible = false;
            // 
            // nazivPredmeta
            // 
            this.nazivPredmeta.DataPropertyName = "nazivPredmeta";
            this.nazivPredmeta.HeaderText = "Predmet";
            this.nazivPredmeta.Name = "nazivPredmeta";
            // 
            // ocjena
            // 
            this.ocjena.DataPropertyName = "ocjena";
            this.ocjena.HeaderText = "Ocjena";
            this.ocjena.Name = "ocjena";
            // 
            // datum
            // 
            this.datum.DataPropertyName = "datum";
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            // 
            // student
            // 
            this.student.DataPropertyName = "student";
            this.student.HeaderText = "Student";
            this.student.Name = "student";
            // 
            // Profesori_OcjenjivanjaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Profesori_OcjenjivanjaFRM";
            this.Text = "Profesori_OcjenjivanjaFRM";
            this.Load += new System.EventHandler(this.Profesori_OcjenjivanjaFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
    }
}