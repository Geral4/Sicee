namespace Inicio
{
    partial class ConsultaCarrera
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
            this.panelCCarreraVertical = new System.Windows.Forms.Panel();
            this.textCCarreraClave = new System.Windows.Forms.TextBox();
            this.labelCCarreraBuscar = new System.Windows.Forms.Label();
            this.textCCarreraNombre = new System.Windows.Forms.TextBox();
            this.radioCCarreraNombre = new System.Windows.Forms.RadioButton();
            this.radioCCarreraClave = new System.Windows.Forms.RadioButton();
            this.buttonCCarreraBuscar = new System.Windows.Forms.Button();
            this.panelCCarreraVertical2 = new System.Windows.Forms.Panel();
            this.buttonCCarreraGuardar = new System.Windows.Forms.Button();
            this.buttonCCarreraEliminar = new System.Windows.Forms.Button();
            this.buttonCCarreraEditar = new System.Windows.Forms.Button();
            this.dataGridCCarrera = new System.Windows.Forms.DataGridView();
            this.labelCCarreraLista = new System.Windows.Forms.Label();
            this.panelCCarreraVertical.SuspendLayout();
            this.panelCCarreraVertical2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCCarreraVertical
            // 
            this.panelCCarreraVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelCCarreraVertical.Controls.Add(this.textCCarreraClave);
            this.panelCCarreraVertical.Controls.Add(this.labelCCarreraBuscar);
            this.panelCCarreraVertical.Controls.Add(this.textCCarreraNombre);
            this.panelCCarreraVertical.Controls.Add(this.radioCCarreraNombre);
            this.panelCCarreraVertical.Controls.Add(this.radioCCarreraClave);
            this.panelCCarreraVertical.Controls.Add(this.buttonCCarreraBuscar);
            this.panelCCarreraVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCCarreraVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCCarreraVertical.Name = "panelCCarreraVertical";
            this.panelCCarreraVertical.Size = new System.Drawing.Size(218, 308);
            this.panelCCarreraVertical.TabIndex = 53;
            this.panelCCarreraVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReporteLVertical2_Paint);
            // 
            // textCCarreraClave
            // 
            this.textCCarreraClave.Location = new System.Drawing.Point(21, 156);
            this.textCCarreraClave.Name = "textCCarreraClave";
            this.textCCarreraClave.Size = new System.Drawing.Size(177, 20);
            this.textCCarreraClave.TabIndex = 50;
            // 
            // labelCCarreraBuscar
            // 
            this.labelCCarreraBuscar.AutoSize = true;
            this.labelCCarreraBuscar.BackColor = System.Drawing.Color.Transparent;
            this.labelCCarreraBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCarreraBuscar.ForeColor = System.Drawing.Color.White;
            this.labelCCarreraBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCCarreraBuscar.Location = new System.Drawing.Point(14, 26);
            this.labelCCarreraBuscar.Name = "labelCCarreraBuscar";
            this.labelCCarreraBuscar.Size = new System.Drawing.Size(98, 19);
            this.labelCCarreraBuscar.TabIndex = 40;
            this.labelCCarreraBuscar.Text = "Buscar por :";
            // 
            // textCCarreraNombre
            // 
            this.textCCarreraNombre.Location = new System.Drawing.Point(21, 96);
            this.textCCarreraNombre.Name = "textCCarreraNombre";
            this.textCCarreraNombre.Size = new System.Drawing.Size(177, 20);
            this.textCCarreraNombre.TabIndex = 41;
            // 
            // radioCCarreraNombre
            // 
            this.radioCCarreraNombre.AutoSize = true;
            this.radioCCarreraNombre.BackColor = System.Drawing.Color.Transparent;
            this.radioCCarreraNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCCarreraNombre.ForeColor = System.Drawing.Color.Olive;
            this.radioCCarreraNombre.Location = new System.Drawing.Point(18, 70);
            this.radioCCarreraNombre.Name = "radioCCarreraNombre";
            this.radioCCarreraNombre.Size = new System.Drawing.Size(81, 20);
            this.radioCCarreraNombre.TabIndex = 44;
            this.radioCCarreraNombre.TabStop = true;
            this.radioCCarreraNombre.Text = "Nombre";
            this.radioCCarreraNombre.UseVisualStyleBackColor = false;
            // 
            // radioCCarreraClave
            // 
            this.radioCCarreraClave.AutoSize = true;
            this.radioCCarreraClave.BackColor = System.Drawing.Color.Transparent;
            this.radioCCarreraClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCCarreraClave.ForeColor = System.Drawing.Color.Olive;
            this.radioCCarreraClave.Location = new System.Drawing.Point(21, 130);
            this.radioCCarreraClave.Name = "radioCCarreraClave";
            this.radioCCarreraClave.Size = new System.Drawing.Size(64, 20);
            this.radioCCarreraClave.TabIndex = 43;
            this.radioCCarreraClave.TabStop = true;
            this.radioCCarreraClave.Text = "Clave";
            this.radioCCarreraClave.UseVisualStyleBackColor = false;
            // 
            // buttonCCarreraBuscar
            // 
            this.buttonCCarreraBuscar.BackColor = System.Drawing.Color.Olive;
            this.buttonCCarreraBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCarreraBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCarreraBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonCCarreraBuscar.Location = new System.Drawing.Point(81, 231);
            this.buttonCCarreraBuscar.Name = "buttonCCarreraBuscar";
            this.buttonCCarreraBuscar.Size = new System.Drawing.Size(82, 26);
            this.buttonCCarreraBuscar.TabIndex = 42;
            this.buttonCCarreraBuscar.Text = "Buscar";
            this.buttonCCarreraBuscar.UseVisualStyleBackColor = false;
            // 
            // panelCCarreraVertical2
            // 
            this.panelCCarreraVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCCarreraVertical2.Controls.Add(this.buttonCCarreraGuardar);
            this.panelCCarreraVertical2.Controls.Add(this.buttonCCarreraEliminar);
            this.panelCCarreraVertical2.Controls.Add(this.buttonCCarreraEditar);
            this.panelCCarreraVertical2.Controls.Add(this.dataGridCCarrera);
            this.panelCCarreraVertical2.Controls.Add(this.labelCCarreraLista);
            this.panelCCarreraVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCCarreraVertical2.Location = new System.Drawing.Point(208, 0);
            this.panelCCarreraVertical2.Name = "panelCCarreraVertical2";
            this.panelCCarreraVertical2.Size = new System.Drawing.Size(645, 308);
            this.panelCCarreraVertical2.TabIndex = 54;
            // 
            // buttonCCarreraGuardar
            // 
            this.buttonCCarreraGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonCCarreraGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCarreraGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCarreraGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonCCarreraGuardar.Location = new System.Drawing.Point(455, 261);
            this.buttonCCarreraGuardar.Name = "buttonCCarreraGuardar";
            this.buttonCCarreraGuardar.Size = new System.Drawing.Size(82, 26);
            this.buttonCCarreraGuardar.TabIndex = 24;
            this.buttonCCarreraGuardar.Text = "Guardar";
            this.buttonCCarreraGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonCCarreraEliminar
            // 
            this.buttonCCarreraEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCCarreraEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCCarreraEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCarreraEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCarreraEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCCarreraEliminar.Location = new System.Drawing.Point(330, 263);
            this.buttonCCarreraEliminar.Name = "buttonCCarreraEliminar";
            this.buttonCCarreraEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCCarreraEliminar.TabIndex = 22;
            this.buttonCCarreraEliminar.Text = "Eliminar";
            this.buttonCCarreraEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonCCarreraEditar
            // 
            this.buttonCCarreraEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCCarreraEditar.FlatAppearance.BorderSize = 0;
            this.buttonCCarreraEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCarreraEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCarreraEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCCarreraEditar.Location = new System.Drawing.Point(227, 264);
            this.buttonCCarreraEditar.Name = "buttonCCarreraEditar";
            this.buttonCCarreraEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCCarreraEditar.TabIndex = 21;
            this.buttonCCarreraEditar.Text = "Editar";
            this.buttonCCarreraEditar.UseVisualStyleBackColor = false;
            // 
            // dataGridCCarrera
            // 
            this.dataGridCCarrera.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCCarrera.Location = new System.Drawing.Point(10, 87);
            this.dataGridCCarrera.Name = "dataGridCCarrera";
            this.dataGridCCarrera.Size = new System.Drawing.Size(629, 170);
            this.dataGridCCarrera.TabIndex = 1;
            // 
            // labelCCarreraLista
            // 
            this.labelCCarreraLista.AutoSize = true;
            this.labelCCarreraLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCarreraLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCCarreraLista.Location = new System.Drawing.Point(16, 36);
            this.labelCCarreraLista.Name = "labelCCarreraLista";
            this.labelCCarreraLista.Size = new System.Drawing.Size(177, 24);
            this.labelCCarreraLista.TabIndex = 0;
            this.labelCCarreraLista.Text = "Lista de Carreras";
            // 
            // ConsultaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 308);
            this.Controls.Add(this.panelCCarreraVertical2);
            this.Controls.Add(this.panelCCarreraVertical);
            this.Name = "ConsultaCarrera";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaCarrera";
            this.Load += new System.EventHandler(this.ConsultaCarrera_Load);
            this.panelCCarreraVertical.ResumeLayout(false);
            this.panelCCarreraVertical.PerformLayout();
            this.panelCCarreraVertical2.ResumeLayout(false);
            this.panelCCarreraVertical2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCCarrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCCarreraVertical;
        private System.Windows.Forms.TextBox textCCarreraClave;
        private System.Windows.Forms.Label labelCCarreraBuscar;
        private System.Windows.Forms.TextBox textCCarreraNombre;
        private System.Windows.Forms.RadioButton radioCCarreraNombre;
        private System.Windows.Forms.RadioButton radioCCarreraClave;
        private System.Windows.Forms.Button buttonCCarreraBuscar;
        private System.Windows.Forms.Panel panelCCarreraVertical2;
        private System.Windows.Forms.Button buttonCCarreraGuardar;
        private System.Windows.Forms.Button buttonCCarreraEliminar;
        private System.Windows.Forms.Button buttonCCarreraEditar;
        private System.Windows.Forms.DataGridView dataGridCCarrera;
        private System.Windows.Forms.Label labelCCarreraLista;
    }
}