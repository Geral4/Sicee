namespace Inicio
{
    partial class Aula1
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
            this.panelAula = new System.Windows.Forms.Panel();
            this.dataGridAula1 = new System.Windows.Forms.DataGridView();
            this.panelAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAula1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAula
            // 
            this.panelAula.BackColor = System.Drawing.Color.DimGray;
            this.panelAula.Controls.Add(this.dataGridAula1);
            this.panelAula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAula.Location = new System.Drawing.Point(4, 4);
            this.panelAula.Name = "panelAula";
            this.panelAula.Size = new System.Drawing.Size(454, 218);
            this.panelAula.TabIndex = 23;
            // 
            // dataGridAula1
            // 
            this.dataGridAula1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridAula1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAula1.Location = new System.Drawing.Point(8, 10);
            this.dataGridAula1.Name = "dataGridAula1";
            this.dataGridAula1.Size = new System.Drawing.Size(436, 199);
            this.dataGridAula1.TabIndex = 0;
            // 
            // Aula1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 228);
            this.Controls.Add(this.panelAula);
            this.Name = "Aula1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aulas";
            this.Load += new System.EventHandler(this.Aula1_Load);
            this.panelAula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAula1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAula;
        private System.Windows.Forms.DataGridView dataGridAula1;
    }
}