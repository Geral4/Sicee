namespace Inicio
{
    partial class ConsultaPrestamo
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
            this.panelCPrestamoVertical = new System.Windows.Forms.Panel();
            this.dateCPrestamoFecha = new System.Windows.Forms.DateTimePicker();
            this.labelCPrestamoBuscar = new System.Windows.Forms.Label();
            this.textCPrestamoFolio = new System.Windows.Forms.TextBox();
            this.radioCPrestamoFolio = new System.Windows.Forms.RadioButton();
            this.radioCPrestamoFecha = new System.Windows.Forms.RadioButton();
            this.buttonCPrestamoBuscar = new System.Windows.Forms.Button();
            this.labelCPrestamoLista = new System.Windows.Forms.Label();
            this.dataGridCPrestamo = new System.Windows.Forms.DataGridView();
            this.buttonCPrestamoEditar = new System.Windows.Forms.Button();
            this.buttonCPrestamoEliminar = new System.Windows.Forms.Button();
            this.buttonCPrestamoGuardar = new System.Windows.Forms.Button();
            this.panelCPrestamoVertical2 = new System.Windows.Forms.Panel();
            this.panelCPrestamoVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCPrestamo)).BeginInit();
            this.panelCPrestamoVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCPrestamoVertical
            // 
            this.panelCPrestamoVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelCPrestamoVertical.Controls.Add(this.dateCPrestamoFecha);
            this.panelCPrestamoVertical.Controls.Add(this.labelCPrestamoBuscar);
            this.panelCPrestamoVertical.Controls.Add(this.textCPrestamoFolio);
            this.panelCPrestamoVertical.Controls.Add(this.radioCPrestamoFolio);
            this.panelCPrestamoVertical.Controls.Add(this.radioCPrestamoFecha);
            this.panelCPrestamoVertical.Controls.Add(this.buttonCPrestamoBuscar);
            this.panelCPrestamoVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCPrestamoVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCPrestamoVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCPrestamoVertical.Name = "panelCPrestamoVertical";
            this.panelCPrestamoVertical.Size = new System.Drawing.Size(291, 361);
            this.panelCPrestamoVertical.TabIndex = 54;
            // 
            // dateCPrestamoFecha
            // 
            this.dateCPrestamoFecha.Location = new System.Drawing.Point(16, 193);
            this.dateCPrestamoFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateCPrestamoFecha.Name = "dateCPrestamoFecha";
            this.dateCPrestamoFecha.Size = new System.Drawing.Size(247, 22);
            this.dateCPrestamoFecha.TabIndex = 52;
            // 
            // labelCPrestamoBuscar
            // 
            this.labelCPrestamoBuscar.AutoSize = true;
            this.labelCPrestamoBuscar.BackColor = System.Drawing.Color.Transparent;
            this.labelCPrestamoBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPrestamoBuscar.ForeColor = System.Drawing.Color.White;
            this.labelCPrestamoBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCPrestamoBuscar.Location = new System.Drawing.Point(19, 32);
            this.labelCPrestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPrestamoBuscar.Name = "labelCPrestamoBuscar";
            this.labelCPrestamoBuscar.Size = new System.Drawing.Size(125, 23);
            this.labelCPrestamoBuscar.TabIndex = 40;
            this.labelCPrestamoBuscar.Text = "Buscar por :";
            // 
            // textCPrestamoFolio
            // 
            this.textCPrestamoFolio.Location = new System.Drawing.Point(28, 118);
            this.textCPrestamoFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCPrestamoFolio.Name = "textCPrestamoFolio";
            this.textCPrestamoFolio.Size = new System.Drawing.Size(235, 22);
            this.textCPrestamoFolio.TabIndex = 41;
            // 
            // radioCPrestamoFolio
            // 
            this.radioCPrestamoFolio.AutoSize = true;
            this.radioCPrestamoFolio.BackColor = System.Drawing.Color.Transparent;
            this.radioCPrestamoFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCPrestamoFolio.ForeColor = System.Drawing.Color.Olive;
            this.radioCPrestamoFolio.Location = new System.Drawing.Point(24, 86);
            this.radioCPrestamoFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCPrestamoFolio.Name = "radioCPrestamoFolio";
            this.radioCPrestamoFolio.Size = new System.Drawing.Size(71, 24);
            this.radioCPrestamoFolio.TabIndex = 44;
            this.radioCPrestamoFolio.TabStop = true;
            this.radioCPrestamoFolio.Text = "Folio";
            this.radioCPrestamoFolio.UseVisualStyleBackColor = false;
            // 
            // radioCPrestamoFecha
            // 
            this.radioCPrestamoFecha.AutoSize = true;
            this.radioCPrestamoFecha.BackColor = System.Drawing.Color.Transparent;
            this.radioCPrestamoFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCPrestamoFecha.ForeColor = System.Drawing.Color.Olive;
            this.radioCPrestamoFecha.Location = new System.Drawing.Point(16, 161);
            this.radioCPrestamoFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCPrestamoFecha.Name = "radioCPrestamoFecha";
            this.radioCPrestamoFecha.Size = new System.Drawing.Size(211, 27);
            this.radioCPrestamoFecha.TabIndex = 43;
            this.radioCPrestamoFecha.TabStop = true;
            this.radioCPrestamoFecha.Text = "Fecha de prestamo";
            this.radioCPrestamoFecha.UseVisualStyleBackColor = false;
            // 
            // buttonCPrestamoBuscar
            // 
            this.buttonCPrestamoBuscar.BackColor = System.Drawing.Color.Olive;
            this.buttonCPrestamoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCPrestamoBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCPrestamoBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonCPrestamoBuscar.Location = new System.Drawing.Point(108, 284);
            this.buttonCPrestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCPrestamoBuscar.Name = "buttonCPrestamoBuscar";
            this.buttonCPrestamoBuscar.Size = new System.Drawing.Size(109, 32);
            this.buttonCPrestamoBuscar.TabIndex = 42;
            this.buttonCPrestamoBuscar.Text = "Buscar";
            this.buttonCPrestamoBuscar.UseVisualStyleBackColor = false;
            this.buttonCPrestamoBuscar.Click += new System.EventHandler(this.buttonCPrestamoBuscar_Click);
            // 
            // labelCPrestamoLista
            // 
            this.labelCPrestamoLista.AutoSize = true;
            this.labelCPrestamoLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPrestamoLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCPrestamoLista.Location = new System.Drawing.Point(21, 44);
            this.labelCPrestamoLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPrestamoLista.Name = "labelCPrestamoLista";
            this.labelCPrestamoLista.Size = new System.Drawing.Size(258, 33);
            this.labelCPrestamoLista.TabIndex = 0;
            this.labelCPrestamoLista.Text = "Lista de prestamos";
            // 
            // dataGridCPrestamo
            // 
            this.dataGridCPrestamo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCPrestamo.Location = new System.Drawing.Point(9, 107);
            this.dataGridCPrestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridCPrestamo.Name = "dataGridCPrestamo";
            this.dataGridCPrestamo.Size = new System.Drawing.Size(839, 209);
            this.dataGridCPrestamo.TabIndex = 1;
            // 
            // buttonCPrestamoEditar
            // 
            this.buttonCPrestamoEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCPrestamoEditar.FlatAppearance.BorderSize = 0;
            this.buttonCPrestamoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCPrestamoEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCPrestamoEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCPrestamoEditar.Location = new System.Drawing.Point(303, 325);
            this.buttonCPrestamoEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCPrestamoEditar.Name = "buttonCPrestamoEditar";
            this.buttonCPrestamoEditar.Size = new System.Drawing.Size(100, 30);
            this.buttonCPrestamoEditar.TabIndex = 21;
            this.buttonCPrestamoEditar.Text = "Editar";
            this.buttonCPrestamoEditar.UseVisualStyleBackColor = false;
            // 
            // buttonCPrestamoEliminar
            // 
            this.buttonCPrestamoEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCPrestamoEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCPrestamoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCPrestamoEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCPrestamoEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCPrestamoEliminar.Location = new System.Drawing.Point(440, 324);
            this.buttonCPrestamoEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCPrestamoEliminar.Name = "buttonCPrestamoEliminar";
            this.buttonCPrestamoEliminar.Size = new System.Drawing.Size(113, 30);
            this.buttonCPrestamoEliminar.TabIndex = 22;
            this.buttonCPrestamoEliminar.Text = "Eliminar";
            this.buttonCPrestamoEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonCPrestamoGuardar
            // 
            this.buttonCPrestamoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonCPrestamoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCPrestamoGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCPrestamoGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonCPrestamoGuardar.Location = new System.Drawing.Point(607, 321);
            this.buttonCPrestamoGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCPrestamoGuardar.Name = "buttonCPrestamoGuardar";
            this.buttonCPrestamoGuardar.Size = new System.Drawing.Size(109, 32);
            this.buttonCPrestamoGuardar.TabIndex = 24;
            this.buttonCPrestamoGuardar.Text = "Guardar";
            this.buttonCPrestamoGuardar.UseVisualStyleBackColor = false;
            // 
            // panelCPrestamoVertical2
            // 
            this.panelCPrestamoVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCPrestamoVertical2.Controls.Add(this.buttonCPrestamoGuardar);
            this.panelCPrestamoVertical2.Controls.Add(this.buttonCPrestamoEliminar);
            this.panelCPrestamoVertical2.Controls.Add(this.buttonCPrestamoEditar);
            this.panelCPrestamoVertical2.Controls.Add(this.dataGridCPrestamo);
            this.panelCPrestamoVertical2.Controls.Add(this.labelCPrestamoLista);
            this.panelCPrestamoVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCPrestamoVertical2.Location = new System.Drawing.Point(291, 0);
            this.panelCPrestamoVertical2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCPrestamoVertical2.Name = "panelCPrestamoVertical2";
            this.panelCPrestamoVertical2.Size = new System.Drawing.Size(860, 361);
            this.panelCPrestamoVertical2.TabIndex = 55;
            this.panelCPrestamoVertical2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCPrestamoVertical2_Paint);
            // 
            // ConsultaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 361);
            this.Controls.Add(this.panelCPrestamoVertical2);
            this.Controls.Add(this.panelCPrestamoVertical);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultaPrestamo";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaPrestamo";
            this.Load += new System.EventHandler(this.ConsultaPrestamo_Load);
            this.panelCPrestamoVertical.ResumeLayout(false);
            this.panelCPrestamoVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCPrestamo)).EndInit();
            this.panelCPrestamoVertical2.ResumeLayout(false);
            this.panelCPrestamoVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCPrestamoVertical;
        private System.Windows.Forms.Label labelCPrestamoBuscar;
        private System.Windows.Forms.TextBox textCPrestamoFolio;
        private System.Windows.Forms.RadioButton radioCPrestamoFolio;
        private System.Windows.Forms.RadioButton radioCPrestamoFecha;
        private System.Windows.Forms.Button buttonCPrestamoBuscar;
        private System.Windows.Forms.DateTimePicker dateCPrestamoFecha;
        private System.Windows.Forms.Label labelCPrestamoLista;
        private System.Windows.Forms.DataGridView dataGridCPrestamo;
        private System.Windows.Forms.Button buttonCPrestamoEditar;
        private System.Windows.Forms.Button buttonCPrestamoEliminar;
        private System.Windows.Forms.Button buttonCPrestamoGuardar;
        private System.Windows.Forms.Panel panelCPrestamoVertical2;
    }
}