namespace Inicio
{
    partial class ReporteBitacora
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
            this.panelRBitacoraVertical = new System.Windows.Forms.Panel();
            this.buttonRBitacoraGenerar = new System.Windows.Forms.Button();
            this.dataGridRBitacora = new System.Windows.Forms.DataGridView();
            this.labelRBitacoraLista = new System.Windows.Forms.Label();
            this.panelRBitacoraVertical2 = new System.Windows.Forms.Panel();
            this.labelRBitacoraAula = new System.Windows.Forms.Label();
            this.textRBitacoraAula = new System.Windows.Forms.TextBox();
            this.dateRBitacora = new System.Windows.Forms.DateTimePicker();
            this.radioRBitacoraAula = new System.Windows.Forms.RadioButton();
            this.radioRBitacoraFecha = new System.Windows.Forms.RadioButton();
            this.radioRBitacoraFechasVarias = new System.Windows.Forms.RadioButton();
            this.labelRBitacoraBuscar = new System.Windows.Forms.Label();
            this.buttonRBitacoraBuscar = new System.Windows.Forms.Button();
            this.panelRBitacoraVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRBitacora)).BeginInit();
            this.panelRBitacoraVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRBitacoraVertical
            // 
            this.panelRBitacoraVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelRBitacoraVertical.Controls.Add(this.buttonRBitacoraGenerar);
            this.panelRBitacoraVertical.Controls.Add(this.dataGridRBitacora);
            this.panelRBitacoraVertical.Controls.Add(this.labelRBitacoraLista);
            this.panelRBitacoraVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRBitacoraVertical.Location = new System.Drawing.Point(0, 0);
            this.panelRBitacoraVertical.Name = "panelRBitacoraVertical";
            this.panelRBitacoraVertical.Size = new System.Drawing.Size(575, 306);
            this.panelRBitacoraVertical.TabIndex = 7;
            // 
            // buttonRBitacoraGenerar
            // 
            this.buttonRBitacoraGenerar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonRBitacoraGenerar.FlatAppearance.BorderSize = 0;
            this.buttonRBitacoraGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRBitacoraGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRBitacoraGenerar.ForeColor = System.Drawing.Color.White;
            this.buttonRBitacoraGenerar.Location = new System.Drawing.Point(193, 271);
            this.buttonRBitacoraGenerar.Name = "buttonRBitacoraGenerar";
            this.buttonRBitacoraGenerar.Size = new System.Drawing.Size(147, 24);
            this.buttonRBitacoraGenerar.TabIndex = 21;
            this.buttonRBitacoraGenerar.Text = "Generar Reporte";
            this.buttonRBitacoraGenerar.UseVisualStyleBackColor = false;
            // 
            // dataGridRBitacora
            // 
            this.dataGridRBitacora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.dataGridRBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRBitacora.Location = new System.Drawing.Point(8, 57);
            this.dataGridRBitacora.Name = "dataGridRBitacora";
            this.dataGridRBitacora.Size = new System.Drawing.Size(558, 206);
            this.dataGridRBitacora.TabIndex = 1;
            // 
            // labelRBitacoraLista
            // 
            this.labelRBitacoraLista.AutoSize = true;
            this.labelRBitacoraLista.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRBitacoraLista.ForeColor = System.Drawing.Color.Olive;
            this.labelRBitacoraLista.Location = new System.Drawing.Point(165, 9);
            this.labelRBitacoraLista.Name = "labelRBitacoraLista";
            this.labelRBitacoraLista.Size = new System.Drawing.Size(221, 30);
            this.labelRBitacoraLista.TabIndex = 0;
            this.labelRBitacoraLista.Text = "Lista de bitacoras";
            // 
            // panelRBitacoraVertical2
            // 
            this.panelRBitacoraVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelRBitacoraVertical2.Controls.Add(this.labelRBitacoraAula);
            this.panelRBitacoraVertical2.Controls.Add(this.textRBitacoraAula);
            this.panelRBitacoraVertical2.Controls.Add(this.dateRBitacora);
            this.panelRBitacoraVertical2.Controls.Add(this.radioRBitacoraAula);
            this.panelRBitacoraVertical2.Controls.Add(this.radioRBitacoraFecha);
            this.panelRBitacoraVertical2.Controls.Add(this.radioRBitacoraFechasVarias);
            this.panelRBitacoraVertical2.Controls.Add(this.labelRBitacoraBuscar);
            this.panelRBitacoraVertical2.Controls.Add(this.buttonRBitacoraBuscar);
            this.panelRBitacoraVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRBitacoraVertical2.Location = new System.Drawing.Point(574, 0);
            this.panelRBitacoraVertical2.Name = "panelRBitacoraVertical2";
            this.panelRBitacoraVertical2.Size = new System.Drawing.Size(228, 306);
            this.panelRBitacoraVertical2.TabIndex = 8;
            // 
            // labelRBitacoraAula
            // 
            this.labelRBitacoraAula.AutoSize = true;
            this.labelRBitacoraAula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRBitacoraAula.ForeColor = System.Drawing.Color.White;
            this.labelRBitacoraAula.Location = new System.Drawing.Point(20, 208);
            this.labelRBitacoraAula.Name = "labelRBitacoraAula";
            this.labelRBitacoraAula.Size = new System.Drawing.Size(47, 21);
            this.labelRBitacoraAula.TabIndex = 34;
            this.labelRBitacoraAula.Text = "Aula";
            // 
            // textRBitacoraAula
            // 
            this.textRBitacoraAula.Location = new System.Drawing.Point(64, 209);
            this.textRBitacoraAula.Name = "textRBitacoraAula";
            this.textRBitacoraAula.Size = new System.Drawing.Size(152, 20);
            this.textRBitacoraAula.TabIndex = 35;
            // 
            // dateRBitacora
            // 
            this.dateRBitacora.Location = new System.Drawing.Point(14, 170);
            this.dateRBitacora.Name = "dateRBitacora";
            this.dateRBitacora.Size = new System.Drawing.Size(202, 20);
            this.dateRBitacora.TabIndex = 33;
            // 
            // radioRBitacoraAula
            // 
            this.radioRBitacoraAula.AutoSize = true;
            this.radioRBitacoraAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRBitacoraAula.ForeColor = System.Drawing.Color.Olive;
            this.radioRBitacoraAula.Location = new System.Drawing.Point(24, 144);
            this.radioRBitacoraAula.Name = "radioRBitacoraAula";
            this.radioRBitacoraAula.Size = new System.Drawing.Size(57, 20);
            this.radioRBitacoraAula.TabIndex = 32;
            this.radioRBitacoraAula.TabStop = true;
            this.radioRBitacoraAula.Text = "Aula";
            this.radioRBitacoraAula.UseVisualStyleBackColor = false;
            // 
            // radioRBitacoraFecha
            // 
            this.radioRBitacoraFecha.AutoSize = true;
            this.radioRBitacoraFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRBitacoraFecha.ForeColor = System.Drawing.Color.Olive;
            this.radioRBitacoraFecha.Location = new System.Drawing.Point(24, 118);
            this.radioRBitacoraFecha.Name = "radioRBitacoraFecha";
            this.radioRBitacoraFecha.Size = new System.Drawing.Size(129, 20);
            this.radioRBitacoraFecha.TabIndex = 31;
            this.radioRBitacoraFecha.TabStop = true;
            this.radioRBitacoraFecha.Text = "Fecha definida";
            this.radioRBitacoraFecha.UseVisualStyleBackColor = false;
            // 
            // radioRBitacoraFechasVarias
            // 
            this.radioRBitacoraFechasVarias.AutoSize = true;
            this.radioRBitacoraFechasVarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRBitacoraFechasVarias.ForeColor = System.Drawing.Color.Olive;
            this.radioRBitacoraFechasVarias.Location = new System.Drawing.Point(24, 88);
            this.radioRBitacoraFechasVarias.Name = "radioRBitacoraFechasVarias";
            this.radioRBitacoraFechasVarias.Size = new System.Drawing.Size(146, 20);
            this.radioRBitacoraFechasVarias.TabIndex = 30;
            this.radioRBitacoraFechasVarias.TabStop = true;
            this.radioRBitacoraFechasVarias.Text = "Todas las fechas";
            this.radioRBitacoraFechasVarias.UseVisualStyleBackColor = false;
            // 
            // labelRBitacoraBuscar
            // 
            this.labelRBitacoraBuscar.AutoSize = true;
            this.labelRBitacoraBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.labelRBitacoraBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRBitacoraBuscar.ForeColor = System.Drawing.Color.White;
            this.labelRBitacoraBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelRBitacoraBuscar.Location = new System.Drawing.Point(20, 57);
            this.labelRBitacoraBuscar.Name = "labelRBitacoraBuscar";
            this.labelRBitacoraBuscar.Size = new System.Drawing.Size(94, 19);
            this.labelRBitacoraBuscar.TabIndex = 29;
            this.labelRBitacoraBuscar.Text = "Buscar por:";
            // 
            // buttonRBitacoraBuscar
            // 
            this.buttonRBitacoraBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonRBitacoraBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRBitacoraBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRBitacoraBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonRBitacoraBuscar.Location = new System.Drawing.Point(83, 271);
            this.buttonRBitacoraBuscar.Name = "buttonRBitacoraBuscar";
            this.buttonRBitacoraBuscar.Size = new System.Drawing.Size(82, 26);
            this.buttonRBitacoraBuscar.TabIndex = 24;
            this.buttonRBitacoraBuscar.Text = "Buscar";
            this.buttonRBitacoraBuscar.UseVisualStyleBackColor = false;
            // 
            // ReporteBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 306);
            this.Controls.Add(this.panelRBitacoraVertical2);
            this.Controls.Add(this.panelRBitacoraVertical);
            this.Name = "ReporteBitacora";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteBitacora";
            this.panelRBitacoraVertical.ResumeLayout(false);
            this.panelRBitacoraVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRBitacora)).EndInit();
            this.panelRBitacoraVertical2.ResumeLayout(false);
            this.panelRBitacoraVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRBitacoraVertical;
        private System.Windows.Forms.Button buttonRBitacoraGenerar;
        private System.Windows.Forms.DataGridView dataGridRBitacora;
        private System.Windows.Forms.Label labelRBitacoraLista;
        private System.Windows.Forms.Panel panelRBitacoraVertical2;
        private System.Windows.Forms.Button buttonRBitacoraBuscar;
        private System.Windows.Forms.RadioButton radioRBitacoraAula;
        private System.Windows.Forms.RadioButton radioRBitacoraFecha;
        private System.Windows.Forms.RadioButton radioRBitacoraFechasVarias;
        private System.Windows.Forms.Label labelRBitacoraBuscar;
        private System.Windows.Forms.DateTimePicker dateRBitacora;
        private System.Windows.Forms.Label labelRBitacoraAula;
        private System.Windows.Forms.TextBox textRBitacoraAula;
    }
}