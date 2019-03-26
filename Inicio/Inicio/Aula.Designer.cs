namespace Inicio
{
    partial class Aula
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
            this.buttonAulaGuardar = new System.Windows.Forms.Button();
            this.panelAula = new System.Windows.Forms.Panel();
            this.dataGridAula = new System.Windows.Forms.DataGridView();
            this.panelAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAula)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAulaGuardar
            // 
            this.buttonAulaGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAulaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAulaGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAulaGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonAulaGuardar.Location = new System.Drawing.Point(213, 243);
            this.buttonAulaGuardar.Name = "buttonAulaGuardar";
            this.buttonAulaGuardar.Size = new System.Drawing.Size(92, 28);
            this.buttonAulaGuardar.TabIndex = 19;
            this.buttonAulaGuardar.Text = "Guardar";
            this.buttonAulaGuardar.UseVisualStyleBackColor = false;
            this.buttonAulaGuardar.Click += new System.EventHandler(this.buttonAulaGuardar_Click);
            // 
            // panelAula
            // 
            this.panelAula.BackColor = System.Drawing.Color.DimGray;
            this.panelAula.Controls.Add(this.dataGridAula);
            this.panelAula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAula.Location = new System.Drawing.Point(0, 3);
            this.panelAula.Name = "panelAula";
            this.panelAula.Size = new System.Drawing.Size(493, 232);
            this.panelAula.TabIndex = 22;
            // 
            // dataGridAula
            // 
            this.dataGridAula.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridAula.AllowUserToAddRows = false;
            this.dataGridAula.AllowUserToDeleteRows = false;
            this.dataGridAula.AllowUserToOrderColumns = true;
            this.dataGridAula.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAula.Location = new System.Drawing.Point(12, 12);
            this.dataGridAula.Name = "dataGridAula";
            this.dataGridAula.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAula.Size = new System.Drawing.Size(468, 204);
            this.dataGridAula.TabIndex = 7;
            // 
            // Aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 283);
            this.Controls.Add(this.panelAula);
            this.Controls.Add(this.buttonAulaGuardar);
            this.Name = "Aula";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula";
            this.Load += new System.EventHandler(this.Aula_Load);
            this.panelAula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAulaGuardar;
        private System.Windows.Forms.Panel panelAula;
        private System.Windows.Forms.DataGridView dataGridAula;
    }
}