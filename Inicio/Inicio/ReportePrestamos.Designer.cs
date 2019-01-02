namespace Inicio
{
    partial class ReportePrestamos
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
            this.panelRPrestamosVertical = new System.Windows.Forms.Panel();
            this.buttonRPrestamosGenerar = new System.Windows.Forms.Button();
            this.dataGridRPrestamos = new System.Windows.Forms.DataGridView();
            this.labelRPrestamosLista = new System.Windows.Forms.Label();
            this.panelRPrestamosVertical2 = new System.Windows.Forms.Panel();
            this.textRPrestamosNControl = new System.Windows.Forms.TextBox();
            this.radioRPrestamosNControl = new System.Windows.Forms.RadioButton();
            this.texRPrestamosNPersonal = new System.Windows.Forms.TextBox();
            this.textRPrestamosNSerie = new System.Windows.Forms.TextBox();
            this.textRPrestamosModelo = new System.Windows.Forms.TextBox();
            this.radioRPrestamosNPersonal = new System.Windows.Forms.RadioButton();
            this.radioRPrestamosNSerie = new System.Windows.Forms.RadioButton();
            this.radioRPrestamosModelo = new System.Windows.Forms.RadioButton();
            this.labelRPrestamosBuscar = new System.Windows.Forms.Label();
            this.buttonRPrestamosBuscar = new System.Windows.Forms.Button();
            this.panelRPrestamosVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRPrestamos)).BeginInit();
            this.panelRPrestamosVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRPrestamosVertical
            // 
            this.panelRPrestamosVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelRPrestamosVertical.Controls.Add(this.buttonRPrestamosGenerar);
            this.panelRPrestamosVertical.Controls.Add(this.dataGridRPrestamos);
            this.panelRPrestamosVertical.Controls.Add(this.labelRPrestamosLista);
            this.panelRPrestamosVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRPrestamosVertical.Location = new System.Drawing.Point(0, 0);
            this.panelRPrestamosVertical.Name = "panelRPrestamosVertical";
            this.panelRPrestamosVertical.Size = new System.Drawing.Size(575, 304);
            this.panelRPrestamosVertical.TabIndex = 6;
            // 
            // buttonRPrestamosGenerar
            // 
            this.buttonRPrestamosGenerar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonRPrestamosGenerar.FlatAppearance.BorderSize = 0;
            this.buttonRPrestamosGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRPrestamosGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRPrestamosGenerar.ForeColor = System.Drawing.Color.White;
            this.buttonRPrestamosGenerar.Location = new System.Drawing.Point(193, 271);
            this.buttonRPrestamosGenerar.Name = "buttonRPrestamosGenerar";
            this.buttonRPrestamosGenerar.Size = new System.Drawing.Size(147, 24);
            this.buttonRPrestamosGenerar.TabIndex = 21;
            this.buttonRPrestamosGenerar.Text = "Generar Reporte";
            this.buttonRPrestamosGenerar.UseVisualStyleBackColor = false;
            this.buttonRPrestamosGenerar.Click += new System.EventHandler(this.buttonReporteAGenerar_Click);
            // 
            // dataGridRPrestamos
            // 
            this.dataGridRPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.dataGridRPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRPrestamos.Location = new System.Drawing.Point(8, 57);
            this.dataGridRPrestamos.Name = "dataGridRPrestamos";
            this.dataGridRPrestamos.Size = new System.Drawing.Size(558, 206);
            this.dataGridRPrestamos.TabIndex = 1;
            // 
            // labelRPrestamosLista
            // 
            this.labelRPrestamosLista.AutoSize = true;
            this.labelRPrestamosLista.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPrestamosLista.ForeColor = System.Drawing.Color.Olive;
            this.labelRPrestamosLista.Location = new System.Drawing.Point(165, 9);
            this.labelRPrestamosLista.Name = "labelRPrestamosLista";
            this.labelRPrestamosLista.Size = new System.Drawing.Size(233, 30);
            this.labelRPrestamosLista.TabIndex = 0;
            this.labelRPrestamosLista.Text = "Lista de prestamos";
            // 
            // panelRPrestamosVertical2
            // 
            this.panelRPrestamosVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelRPrestamosVertical2.Controls.Add(this.textRPrestamosNControl);
            this.panelRPrestamosVertical2.Controls.Add(this.radioRPrestamosNControl);
            this.panelRPrestamosVertical2.Controls.Add(this.texRPrestamosNPersonal);
            this.panelRPrestamosVertical2.Controls.Add(this.textRPrestamosNSerie);
            this.panelRPrestamosVertical2.Controls.Add(this.textRPrestamosModelo);
            this.panelRPrestamosVertical2.Controls.Add(this.radioRPrestamosNPersonal);
            this.panelRPrestamosVertical2.Controls.Add(this.radioRPrestamosNSerie);
            this.panelRPrestamosVertical2.Controls.Add(this.radioRPrestamosModelo);
            this.panelRPrestamosVertical2.Controls.Add(this.labelRPrestamosBuscar);
            this.panelRPrestamosVertical2.Controls.Add(this.buttonRPrestamosBuscar);
            this.panelRPrestamosVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRPrestamosVertical2.Location = new System.Drawing.Point(572, 0);
            this.panelRPrestamosVertical2.Name = "panelRPrestamosVertical2";
            this.panelRPrestamosVertical2.Size = new System.Drawing.Size(228, 304);
            this.panelRPrestamosVertical2.TabIndex = 7;
            // 
            // textRPrestamosNControl
            // 
            this.textRPrestamosNControl.Location = new System.Drawing.Point(48, 243);
            this.textRPrestamosNControl.Name = "textRPrestamosNControl";
            this.textRPrestamosNControl.Size = new System.Drawing.Size(168, 20);
            this.textRPrestamosNControl.TabIndex = 35;
            // 
            // radioRPrestamosNControl
            // 
            this.radioRPrestamosNControl.AutoSize = true;
            this.radioRPrestamosNControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRPrestamosNControl.ForeColor = System.Drawing.Color.Olive;
            this.radioRPrestamosNControl.Location = new System.Drawing.Point(29, 220);
            this.radioRPrestamosNControl.Name = "radioRPrestamosNControl";
            this.radioRPrestamosNControl.Size = new System.Drawing.Size(96, 20);
            this.radioRPrestamosNControl.TabIndex = 34;
            this.radioRPrestamosNControl.TabStop = true;
            this.radioRPrestamosNControl.Text = "Nº Control";
            this.radioRPrestamosNControl.UseVisualStyleBackColor = false;
            // 
            // texRPrestamosNPersonal
            // 
            this.texRPrestamosNPersonal.Location = new System.Drawing.Point(48, 194);
            this.texRPrestamosNPersonal.Name = "texRPrestamosNPersonal";
            this.texRPrestamosNPersonal.Size = new System.Drawing.Size(168, 20);
            this.texRPrestamosNPersonal.TabIndex = 33;
            // 
            // textRPrestamosNSerie
            // 
            this.textRPrestamosNSerie.Location = new System.Drawing.Point(48, 147);
            this.textRPrestamosNSerie.Name = "textRPrestamosNSerie";
            this.textRPrestamosNSerie.Size = new System.Drawing.Size(168, 20);
            this.textRPrestamosNSerie.TabIndex = 32;
            // 
            // textRPrestamosModelo
            // 
            this.textRPrestamosModelo.Location = new System.Drawing.Point(48, 99);
            this.textRPrestamosModelo.Name = "textRPrestamosModelo";
            this.textRPrestamosModelo.Size = new System.Drawing.Size(168, 20);
            this.textRPrestamosModelo.TabIndex = 31;
            // 
            // radioRPrestamosNPersonal
            // 
            this.radioRPrestamosNPersonal.AutoSize = true;
            this.radioRPrestamosNPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRPrestamosNPersonal.ForeColor = System.Drawing.Color.Olive;
            this.radioRPrestamosNPersonal.Location = new System.Drawing.Point(29, 171);
            this.radioRPrestamosNPersonal.Name = "radioRPrestamosNPersonal";
            this.radioRPrestamosNPersonal.Size = new System.Drawing.Size(109, 20);
            this.radioRPrestamosNPersonal.TabIndex = 29;
            this.radioRPrestamosNPersonal.TabStop = true;
            this.radioRPrestamosNPersonal.Text = "Nº Personal";
            this.radioRPrestamosNPersonal.UseVisualStyleBackColor = false;
            // 
            // radioRPrestamosNSerie
            // 
            this.radioRPrestamosNSerie.AutoSize = true;
            this.radioRPrestamosNSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRPrestamosNSerie.ForeColor = System.Drawing.Color.Olive;
            this.radioRPrestamosNSerie.Location = new System.Drawing.Point(29, 127);
            this.radioRPrestamosNSerie.Name = "radioRPrestamosNSerie";
            this.radioRPrestamosNSerie.Size = new System.Drawing.Size(84, 20);
            this.radioRPrestamosNSerie.TabIndex = 28;
            this.radioRPrestamosNSerie.TabStop = true;
            this.radioRPrestamosNSerie.Text = "Nº Serie";
            this.radioRPrestamosNSerie.UseVisualStyleBackColor = false;
            // 
            // radioRPrestamosModelo
            // 
            this.radioRPrestamosModelo.AutoSize = true;
            this.radioRPrestamosModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRPrestamosModelo.ForeColor = System.Drawing.Color.Olive;
            this.radioRPrestamosModelo.Location = new System.Drawing.Point(29, 79);
            this.radioRPrestamosModelo.Name = "radioRPrestamosModelo";
            this.radioRPrestamosModelo.Size = new System.Drawing.Size(78, 20);
            this.radioRPrestamosModelo.TabIndex = 27;
            this.radioRPrestamosModelo.TabStop = true;
            this.radioRPrestamosModelo.Text = "Modelo";
            this.radioRPrestamosModelo.UseVisualStyleBackColor = false;
            // 
            // labelRPrestamosBuscar
            // 
            this.labelRPrestamosBuscar.AutoSize = true;
            this.labelRPrestamosBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.labelRPrestamosBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPrestamosBuscar.ForeColor = System.Drawing.Color.White;
            this.labelRPrestamosBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelRPrestamosBuscar.Location = new System.Drawing.Point(25, 48);
            this.labelRPrestamosBuscar.Name = "labelRPrestamosBuscar";
            this.labelRPrestamosBuscar.Size = new System.Drawing.Size(94, 19);
            this.labelRPrestamosBuscar.TabIndex = 25;
            this.labelRPrestamosBuscar.Text = "Buscar por:";
            // 
            // buttonRPrestamosBuscar
            // 
            this.buttonRPrestamosBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonRPrestamosBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRPrestamosBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRPrestamosBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonRPrestamosBuscar.Location = new System.Drawing.Point(83, 271);
            this.buttonRPrestamosBuscar.Name = "buttonRPrestamosBuscar";
            this.buttonRPrestamosBuscar.Size = new System.Drawing.Size(82, 26);
            this.buttonRPrestamosBuscar.TabIndex = 24;
            this.buttonRPrestamosBuscar.Text = "Buscar";
            this.buttonRPrestamosBuscar.UseVisualStyleBackColor = false;
            // 
            // ReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.panelRPrestamosVertical2);
            this.Controls.Add(this.panelRPrestamosVertical);
            this.Name = "ReportePrestamos";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePrestamos";
            this.panelRPrestamosVertical.ResumeLayout(false);
            this.panelRPrestamosVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRPrestamos)).EndInit();
            this.panelRPrestamosVertical2.ResumeLayout(false);
            this.panelRPrestamosVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRPrestamosVertical;
        private System.Windows.Forms.Button buttonRPrestamosGenerar;
        private System.Windows.Forms.DataGridView dataGridRPrestamos;
        private System.Windows.Forms.Label labelRPrestamosLista;
        private System.Windows.Forms.Panel panelRPrestamosVertical2;
        private System.Windows.Forms.TextBox texRPrestamosNPersonal;
        private System.Windows.Forms.TextBox textRPrestamosNSerie;
        private System.Windows.Forms.TextBox textRPrestamosModelo;
        private System.Windows.Forms.RadioButton radioRPrestamosNPersonal;
        private System.Windows.Forms.RadioButton radioRPrestamosNSerie;
        private System.Windows.Forms.RadioButton radioRPrestamosModelo;
        private System.Windows.Forms.Label labelRPrestamosBuscar;
        private System.Windows.Forms.Button buttonRPrestamosBuscar;
        private System.Windows.Forms.TextBox textRPrestamosNControl;
        private System.Windows.Forms.RadioButton radioRPrestamosNControl;
    }
}