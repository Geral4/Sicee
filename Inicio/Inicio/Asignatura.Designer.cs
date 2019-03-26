namespace Inicio
{
    partial class Asignatura
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
            this.panelAsignaturaVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textAsignaturaBuscar = new System.Windows.Forms.TextBox();
            this.labelAsignaturaBuscar = new System.Windows.Forms.Label();
            this.dataGridViewAsignatura = new System.Windows.Forms.DataGridView();
            this.labelAsignaturaLista = new System.Windows.Forms.Label();
            this.panelAsignaturaVertical2 = new System.Windows.Forms.Panel();
            this.comboAsignaturaCarrera = new System.Windows.Forms.ComboBox();
            this.numericAsignatura = new System.Windows.Forms.NumericUpDown();
            this.labelAsignaturaCreditos = new System.Windows.Forms.Label();
            this.comboAsignaturaModalidad = new System.Windows.Forms.ComboBox();
            this.buttonAsignaturaCancelar = new System.Windows.Forms.Button();
            this.buttonAsignaturaGuardar = new System.Windows.Forms.Button();
            this.labelAsignaturaCarrera = new System.Windows.Forms.Label();
            this.labelAsignaturaModalidad = new System.Windows.Forms.Label();
            this.textAsignaturaClave = new System.Windows.Forms.TextBox();
            this.labelAsignaturaClave = new System.Windows.Forms.Label();
            this.textAsignaturaNombre = new System.Windows.Forms.TextBox();
            this.labelAsignaturaNombre = new System.Windows.Forms.Label();
            this.labelAsignaturaRegistro = new System.Windows.Forms.Label();
            this.panelAsignaturaVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignatura)).BeginInit();
            this.panelAsignaturaVertical2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAsignatura)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAsignaturaVertical
            // 
            this.panelAsignaturaVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelAsignaturaVertical.Controls.Add(this.label1);
            this.panelAsignaturaVertical.Controls.Add(this.textAsignaturaBuscar);
            this.panelAsignaturaVertical.Controls.Add(this.labelAsignaturaBuscar);
            this.panelAsignaturaVertical.Controls.Add(this.dataGridViewAsignatura);
            this.panelAsignaturaVertical.Controls.Add(this.labelAsignaturaLista);
            this.panelAsignaturaVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAsignaturaVertical.Location = new System.Drawing.Point(0, 0);
            this.panelAsignaturaVertical.Name = "panelAsignaturaVertical";
            this.panelAsignaturaVertical.Size = new System.Drawing.Size(553, 338);
            this.panelAsignaturaVertical.TabIndex = 2;
            this.panelAsignaturaVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAsignaturaVertical_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(3, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "*Solo para consultas";
            // 
            // textAsignaturaBuscar
            // 
            this.textAsignaturaBuscar.Location = new System.Drawing.Point(363, 37);
            this.textAsignaturaBuscar.Name = "textAsignaturaBuscar";
            this.textAsignaturaBuscar.Size = new System.Drawing.Size(137, 20);
            this.textAsignaturaBuscar.TabIndex = 23;
            this.textAsignaturaBuscar.TextChanged += new System.EventHandler(this.textAsignaturaBuscar_TextChanged);
            // 
            // labelAsignaturaBuscar
            // 
            this.labelAsignaturaBuscar.AutoSize = true;
            this.labelAsignaturaBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignaturaBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelAsignaturaBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelAsignaturaBuscar.Location = new System.Drawing.Point(302, 38);
            this.labelAsignaturaBuscar.Name = "labelAsignaturaBuscar";
            this.labelAsignaturaBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelAsignaturaBuscar.TabIndex = 21;
            this.labelAsignaturaBuscar.Text = "Buscar";
            // 
            // dataGridViewAsignatura
            // 
            this.dataGridViewAsignatura.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignatura.Location = new System.Drawing.Point(8, 69);
            this.dataGridViewAsignatura.Name = "dataGridViewAsignatura";
            this.dataGridViewAsignatura.Size = new System.Drawing.Size(538, 227);
            this.dataGridViewAsignatura.TabIndex = 1;
            // 
            // labelAsignaturaLista
            // 
            this.labelAsignaturaLista.AutoSize = true;
            this.labelAsignaturaLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignaturaLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelAsignaturaLista.Location = new System.Drawing.Point(4, 19);
            this.labelAsignaturaLista.Name = "labelAsignaturaLista";
            this.labelAsignaturaLista.Size = new System.Drawing.Size(158, 21);
            this.labelAsignaturaLista.TabIndex = 0;
            this.labelAsignaturaLista.Text = "Lista de asignatura";
            // 
            // panelAsignaturaVertical2
            // 
            this.panelAsignaturaVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAsignaturaVertical2.Controls.Add(this.comboAsignaturaCarrera);
            this.panelAsignaturaVertical2.Controls.Add(this.numericAsignatura);
            this.panelAsignaturaVertical2.Controls.Add(this.labelAsignaturaCreditos);
            this.panelAsignaturaVertical2.Controls.Add(this.comboAsignaturaModalidad);
            this.panelAsignaturaVertical2.Controls.Add(this.buttonAsignaturaCancelar);
            this.panelAsignaturaVertical2.Controls.Add(this.buttonAsignaturaGuardar);
            this.panelAsignaturaVertical2.Controls.Add(this.labelAsignaturaCarrera);
            this.panelAsignaturaVertical2.Controls.Add(this.labelAsignaturaModalidad);
            this.panelAsignaturaVertical2.Controls.Add(this.textAsignaturaClave);
            this.panelAsignaturaVertical2.Controls.Add(this.labelAsignaturaClave);
            this.panelAsignaturaVertical2.Controls.Add(this.textAsignaturaNombre);
            this.panelAsignaturaVertical2.Controls.Add(this.labelAsignaturaNombre);
            this.panelAsignaturaVertical2.Controls.Add(this.labelAsignaturaRegistro);
            this.panelAsignaturaVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAsignaturaVertical2.Location = new System.Drawing.Point(552, 0);
            this.panelAsignaturaVertical2.Name = "panelAsignaturaVertical2";
            this.panelAsignaturaVertical2.Size = new System.Drawing.Size(328, 338);
            this.panelAsignaturaVertical2.TabIndex = 3;
            // 
            // comboAsignaturaCarrera
            // 
            this.comboAsignaturaCarrera.FormattingEnabled = true;
            this.comboAsignaturaCarrera.Location = new System.Drawing.Point(83, 115);
            this.comboAsignaturaCarrera.Name = "comboAsignaturaCarrera";
            this.comboAsignaturaCarrera.Size = new System.Drawing.Size(231, 21);
            this.comboAsignaturaCarrera.TabIndex = 32;
            this.comboAsignaturaCarrera.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboAsignaturaCarrera_MouseClick);
            // 
            // numericAsignatura
            // 
            this.numericAsignatura.Location = new System.Drawing.Point(81, 146);
            this.numericAsignatura.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericAsignatura.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericAsignatura.Name = "numericAsignatura";
            this.numericAsignatura.Size = new System.Drawing.Size(233, 20);
            this.numericAsignatura.TabIndex = 24;
            this.numericAsignatura.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelAsignaturaCreditos
            // 
            this.labelAsignaturaCreditos.AutoSize = true;
            this.labelAsignaturaCreditos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignaturaCreditos.ForeColor = System.Drawing.Color.White;
            this.labelAsignaturaCreditos.Location = new System.Drawing.Point(10, 143);
            this.labelAsignaturaCreditos.Name = "labelAsignaturaCreditos";
            this.labelAsignaturaCreditos.Size = new System.Drawing.Size(76, 20);
            this.labelAsignaturaCreditos.TabIndex = 22;
            this.labelAsignaturaCreditos.Text = "Creditos*";
            // 
            // comboAsignaturaModalidad
            // 
            this.comboAsignaturaModalidad.FormattingEnabled = true;
            this.comboAsignaturaModalidad.Location = new System.Drawing.Point(105, 174);
            this.comboAsignaturaModalidad.Name = "comboAsignaturaModalidad";
            this.comboAsignaturaModalidad.Size = new System.Drawing.Size(209, 21);
            this.comboAsignaturaModalidad.TabIndex = 21;
            // 
            // buttonAsignaturaCancelar
            // 
            this.buttonAsignaturaCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAsignaturaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsignaturaCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignaturaCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonAsignaturaCancelar.Location = new System.Drawing.Point(204, 272);
            this.buttonAsignaturaCancelar.Name = "buttonAsignaturaCancelar";
            this.buttonAsignaturaCancelar.Size = new System.Drawing.Size(78, 24);
            this.buttonAsignaturaCancelar.TabIndex = 20;
            this.buttonAsignaturaCancelar.Text = "Cancelar";
            this.buttonAsignaturaCancelar.UseVisualStyleBackColor = false;
            this.buttonAsignaturaCancelar.Click += new System.EventHandler(this.buttonAsignaturaCancelar_Click);
            // 
            // buttonAsignaturaGuardar
            // 
            this.buttonAsignaturaGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAsignaturaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsignaturaGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignaturaGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonAsignaturaGuardar.Location = new System.Drawing.Point(77, 272);
            this.buttonAsignaturaGuardar.Name = "buttonAsignaturaGuardar";
            this.buttonAsignaturaGuardar.Size = new System.Drawing.Size(75, 24);
            this.buttonAsignaturaGuardar.TabIndex = 19;
            this.buttonAsignaturaGuardar.Text = "Guardar";
            this.buttonAsignaturaGuardar.UseVisualStyleBackColor = false;
            this.buttonAsignaturaGuardar.Click += new System.EventHandler(this.buttonAsignaturaGuardar_Click);
            // 
            // labelAsignaturaCarrera
            // 
            this.labelAsignaturaCarrera.AutoSize = true;
            this.labelAsignaturaCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignaturaCarrera.ForeColor = System.Drawing.Color.White;
            this.labelAsignaturaCarrera.Location = new System.Drawing.Point(10, 113);
            this.labelAsignaturaCarrera.Name = "labelAsignaturaCarrera";
            this.labelAsignaturaCarrera.Size = new System.Drawing.Size(72, 20);
            this.labelAsignaturaCarrera.TabIndex = 12;
            this.labelAsignaturaCarrera.Text = "Carrera*";
            // 
            // labelAsignaturaModalidad
            // 
            this.labelAsignaturaModalidad.AutoSize = true;
            this.labelAsignaturaModalidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignaturaModalidad.ForeColor = System.Drawing.Color.White;
            this.labelAsignaturaModalidad.Location = new System.Drawing.Point(9, 173);
            this.labelAsignaturaModalidad.Name = "labelAsignaturaModalidad";
            this.labelAsignaturaModalidad.Size = new System.Drawing.Size(96, 20);
            this.labelAsignaturaModalidad.TabIndex = 7;
            this.labelAsignaturaModalidad.Text = "Modalidad*";
            // 
            // textAsignaturaClave
            // 
            this.textAsignaturaClave.Location = new System.Drawing.Point(81, 87);
            this.textAsignaturaClave.Name = "textAsignaturaClave";
            this.textAsignaturaClave.Size = new System.Drawing.Size(233, 20);
            this.textAsignaturaClave.TabIndex = 4;
            // 
            // labelAsignaturaClave
            // 
            this.labelAsignaturaClave.AutoSize = true;
            this.labelAsignaturaClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignaturaClave.ForeColor = System.Drawing.Color.White;
            this.labelAsignaturaClave.Location = new System.Drawing.Point(8, 86);
            this.labelAsignaturaClave.Name = "labelAsignaturaClave";
            this.labelAsignaturaClave.Size = new System.Drawing.Size(60, 20);
            this.labelAsignaturaClave.TabIndex = 3;
            this.labelAsignaturaClave.Text = "Clave*";
            // 
            // textAsignaturaNombre
            // 
            this.textAsignaturaNombre.Location = new System.Drawing.Point(81, 59);
            this.textAsignaturaNombre.Name = "textAsignaturaNombre";
            this.textAsignaturaNombre.Size = new System.Drawing.Size(233, 20);
            this.textAsignaturaNombre.TabIndex = 2;
            this.textAsignaturaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAsignaturaNombre_KeyPress);
            // 
            // labelAsignaturaNombre
            // 
            this.labelAsignaturaNombre.AutoSize = true;
            this.labelAsignaturaNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignaturaNombre.ForeColor = System.Drawing.Color.White;
            this.labelAsignaturaNombre.Location = new System.Drawing.Point(8, 59);
            this.labelAsignaturaNombre.Name = "labelAsignaturaNombre";
            this.labelAsignaturaNombre.Size = new System.Drawing.Size(74, 20);
            this.labelAsignaturaNombre.TabIndex = 1;
            this.labelAsignaturaNombre.Text = "Nombre*";
            // 
            // labelAsignaturaRegistro
            // 
            this.labelAsignaturaRegistro.AutoSize = true;
            this.labelAsignaturaRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignaturaRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelAsignaturaRegistro.Location = new System.Drawing.Point(7, 19);
            this.labelAsignaturaRegistro.Name = "labelAsignaturaRegistro";
            this.labelAsignaturaRegistro.Size = new System.Drawing.Size(169, 21);
            this.labelAsignaturaRegistro.TabIndex = 0;
            this.labelAsignaturaRegistro.Text = "Registrar Asignatura";
            this.labelAsignaturaRegistro.Click += new System.EventHandler(this.labelAsignaturaRegistro_Click);
            // 
            // Asignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 338);
            this.Controls.Add(this.panelAsignaturaVertical2);
            this.Controls.Add(this.panelAsignaturaVertical);
            this.Name = "Asignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignatura";
            this.Load += new System.EventHandler(this.Asignatura_Load);
            this.panelAsignaturaVertical.ResumeLayout(false);
            this.panelAsignaturaVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignatura)).EndInit();
            this.panelAsignaturaVertical2.ResumeLayout(false);
            this.panelAsignaturaVertical2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAsignatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAsignaturaVertical;
        private System.Windows.Forms.TextBox textAsignaturaBuscar;
        private System.Windows.Forms.Label labelAsignaturaBuscar;
        private System.Windows.Forms.DataGridView dataGridViewAsignatura;
        private System.Windows.Forms.Label labelAsignaturaLista;
        private System.Windows.Forms.Panel panelAsignaturaVertical2;
        private System.Windows.Forms.Button buttonAsignaturaCancelar;
        private System.Windows.Forms.Button buttonAsignaturaGuardar;
        private System.Windows.Forms.Label labelAsignaturaCarrera;
        private System.Windows.Forms.Label labelAsignaturaModalidad;
        private System.Windows.Forms.TextBox textAsignaturaClave;
        private System.Windows.Forms.Label labelAsignaturaClave;
        private System.Windows.Forms.TextBox textAsignaturaNombre;
        private System.Windows.Forms.Label labelAsignaturaNombre;
        private System.Windows.Forms.Label labelAsignaturaRegistro;
        private System.Windows.Forms.ComboBox comboAsignaturaModalidad;
        private System.Windows.Forms.Label labelAsignaturaCreditos;
        private System.Windows.Forms.NumericUpDown numericAsignatura;
        private System.Windows.Forms.ComboBox comboAsignaturaCarrera;
        private System.Windows.Forms.Label label1;
    }
}