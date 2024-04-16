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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(47, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 283);
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-1, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Pregledajte kakve ste ocjene davali:";
            // 
            // Profesori_OcjenjivanjaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Profesori_OcjenjivanjaFRM";
            this.Text = "Profesori_OcjenjivanjaFRM";
            this.Load += new System.EventHandler(this.Profesori_OcjenjivanjaFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}