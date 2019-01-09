namespace Inicio
{
    partial class Alumno
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
            this.panelAlumnoVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textAlumnoBuscar = new System.Windows.Forms.TextBox();
            this.labelAlumnoBuscar = new System.Windows.Forms.Label();
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            this.labelAlumnoLista = new System.Windows.Forms.Label();
            this.panelAlumnoVertical2 = new System.Windows.Forms.Panel();
            this.textAlumnoApellidoM = new System.Windows.Forms.TextBox();
            this.comboAlumnoCarrera = new System.Windows.Forms.ComboBox();
            this.comboAlumnoSexo = new System.Windows.Forms.ComboBox();
            this.comboAlumnoSemestre = new System.Windows.Forms.ComboBox();
            this.labelAlumnoApellidoM = new System.Windows.Forms.Label();
            this.textAlumnoApellidoP = new System.Windows.Forms.TextBox();
            this.labelAlumnoApellidoP = new System.Windows.Forms.Label();
            this.labelAlumnoSemestre = new System.Windows.Forms.Label();
            this.buttonAlumnoCancelar = new System.Windows.Forms.Button();
            this.buttonAlumnoGuardar = new System.Windows.Forms.Button();
            this.textAlumnoDireccion = new System.Windows.Forms.TextBox();
            this.textAlumnoNControl = new System.Windows.Forms.TextBox();
            this.labelAlumnonNControl = new System.Windows.Forms.Label();
            this.textAlumnoCurp = new System.Windows.Forms.TextBox();
            this.labelAlumnoDireccion = new System.Windows.Forms.Label();
            this.labelAlumnoCurp = new System.Windows.Forms.Label();
            this.labelAlumnoCarrera = new System.Windows.Forms.Label();
            this.labelAlumnoSexo = new System.Windows.Forms.Label();
            this.textAlumnoTelefono = new System.Windows.Forms.TextBox();
            this.labelAlumnoTelefono = new System.Windows.Forms.Label();
            this.textAlumnoNombre = new System.Windows.Forms.TextBox();
            this.labelAlumnoNombre = new System.Windows.Forms.Label();
            this.labelAlumnoRegistro = new System.Windows.Forms.Label();
            this.panelAlumnoVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.panelAlumnoVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlumnoVertical
            // 
            this.panelAlumnoVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelAlumnoVertical.Controls.Add(this.label1);
            this.panelAlumnoVertical.Controls.Add(this.textAlumnoBuscar);
            this.panelAlumnoVertical.Controls.Add(this.labelAlumnoBuscar);
            this.panelAlumnoVertical.Controls.Add(this.dataGridAlumno);
            this.panelAlumnoVertical.Controls.Add(this.labelAlumnoLista);
            this.panelAlumnoVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAlumnoVertical.Location = new System.Drawing.Point(0, 0);
            this.panelAlumnoVertical.Name = "panelAlumnoVertical";
            this.panelAlumnoVertical.Size = new System.Drawing.Size(575, 370);
            this.panelAlumnoVertical.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(6, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "*Solo para consultas";
            // 
            // textAlumnoBuscar
            // 
            this.textAlumnoBuscar.Location = new System.Drawing.Point(273, 41);
            this.textAlumnoBuscar.Name = "textAlumnoBuscar";
            this.textAlumnoBuscar.Size = new System.Drawing.Size(137, 20);
            this.textAlumnoBuscar.TabIndex = 23;
            this.textAlumnoBuscar.TextChanged += new System.EventHandler(this.textAlumnoBuscar_TextChanged);
            // 
            // labelAlumnoBuscar
            // 
            this.labelAlumnoBuscar.AutoSize = true;
            this.labelAlumnoBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelAlumnoBuscar.Location = new System.Drawing.Point(211, 40);
            this.labelAlumnoBuscar.Name = "labelAlumnoBuscar";
            this.labelAlumnoBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelAlumnoBuscar.TabIndex = 21;
            this.labelAlumnoBuscar.Text = "Buscar";
            // 
            // dataGridAlumno
            // 
            this.dataGridAlumno.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumno.Location = new System.Drawing.Point(6, 69);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.Size = new System.Drawing.Size(558, 263);
            this.dataGridAlumno.TabIndex = 1;
            // 
            // labelAlumnoLista
            // 
            this.labelAlumnoLista.AutoSize = true;
            this.labelAlumnoLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelAlumnoLista.Location = new System.Drawing.Point(4, 19);
            this.labelAlumnoLista.Name = "labelAlumnoLista";
            this.labelAlumnoLista.Size = new System.Drawing.Size(138, 21);
            this.labelAlumnoLista.TabIndex = 0;
            this.labelAlumnoLista.Text = "Lista de alumnos";
            // 
            // panelAlumnoVertical2
            // 
            this.panelAlumnoVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAlumnoVertical2.Controls.Add(this.textAlumnoApellidoM);
            this.panelAlumnoVertical2.Controls.Add(this.comboAlumnoCarrera);
            this.panelAlumnoVertical2.Controls.Add(this.comboAlumnoSexo);
            this.panelAlumnoVertical2.Controls.Add(this.comboAlumnoSemestre);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoApellidoM);
            this.panelAlumnoVertical2.Controls.Add(this.textAlumnoApellidoP);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoApellidoP);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoSemestre);
            this.panelAlumnoVertical2.Controls.Add(this.buttonAlumnoCancelar);
            this.panelAlumnoVertical2.Controls.Add(this.buttonAlumnoGuardar);
            this.panelAlumnoVertical2.Controls.Add(this.textAlumnoDireccion);
            this.panelAlumnoVertical2.Controls.Add(this.textAlumnoNControl);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnonNControl);
            this.panelAlumnoVertical2.Controls.Add(this.textAlumnoCurp);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoDireccion);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoCurp);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoCarrera);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoSexo);
            this.panelAlumnoVertical2.Controls.Add(this.textAlumnoTelefono);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoTelefono);
            this.panelAlumnoVertical2.Controls.Add(this.textAlumnoNombre);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoNombre);
            this.panelAlumnoVertical2.Controls.Add(this.labelAlumnoRegistro);
            this.panelAlumnoVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAlumnoVertical2.Location = new System.Drawing.Point(570, 0);
            this.panelAlumnoVertical2.Name = "panelAlumnoVertical2";
            this.panelAlumnoVertical2.Size = new System.Drawing.Size(330, 370);
            this.panelAlumnoVertical2.TabIndex = 2;
            // 
            // textAlumnoApellidoM
            // 
            this.textAlumnoApellidoM.Location = new System.Drawing.Point(145, 115);
            this.textAlumnoApellidoM.Name = "textAlumnoApellidoM";
            this.textAlumnoApellidoM.Size = new System.Drawing.Size(169, 20);
            this.textAlumnoApellidoM.TabIndex = 32;
            // 
            // comboAlumnoCarrera
            // 
            this.comboAlumnoCarrera.FormattingEnabled = true;
            this.comboAlumnoCarrera.Location = new System.Drawing.Point(83, 219);
            this.comboAlumnoCarrera.Name = "comboAlumnoCarrera";
            this.comboAlumnoCarrera.Size = new System.Drawing.Size(231, 21);
            this.comboAlumnoCarrera.TabIndex = 31;
            // 
            // comboAlumnoSexo
            // 
            this.comboAlumnoSexo.FormattingEnabled = true;
            this.comboAlumnoSexo.Location = new System.Drawing.Point(82, 195);
            this.comboAlumnoSexo.Name = "comboAlumnoSexo";
            this.comboAlumnoSexo.Size = new System.Drawing.Size(231, 21);
            this.comboAlumnoSexo.TabIndex = 30;
            // 
            // comboAlumnoSemestre
            // 
            this.comboAlumnoSemestre.FormattingEnabled = true;
            this.comboAlumnoSemestre.Location = new System.Drawing.Point(81, 247);
            this.comboAlumnoSemestre.Name = "comboAlumnoSemestre";
            this.comboAlumnoSemestre.Size = new System.Drawing.Size(233, 21);
            this.comboAlumnoSemestre.TabIndex = 27;
            // 
            // labelAlumnoApellidoM
            // 
            this.labelAlumnoApellidoM.AutoSize = true;
            this.labelAlumnoApellidoM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoApellidoM.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoApellidoM.Location = new System.Drawing.Point(9, 113);
            this.labelAlumnoApellidoM.Name = "labelAlumnoApellidoM";
            this.labelAlumnoApellidoM.Size = new System.Drawing.Size(137, 20);
            this.labelAlumnoApellidoM.TabIndex = 25;
            this.labelAlumnoApellidoM.Text = "Apellido Materno";
            // 
            // textAlumnoApellidoP
            // 
            this.textAlumnoApellidoP.Location = new System.Drawing.Point(145, 88);
            this.textAlumnoApellidoP.Name = "textAlumnoApellidoP";
            this.textAlumnoApellidoP.Size = new System.Drawing.Size(169, 20);
            this.textAlumnoApellidoP.TabIndex = 24;
            this.textAlumnoApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlumnoApellidoP_KeyPress);
            // 
            // labelAlumnoApellidoP
            // 
            this.labelAlumnoApellidoP.AutoSize = true;
            this.labelAlumnoApellidoP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoApellidoP.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoApellidoP.Location = new System.Drawing.Point(8, 87);
            this.labelAlumnoApellidoP.Name = "labelAlumnoApellidoP";
            this.labelAlumnoApellidoP.Size = new System.Drawing.Size(131, 20);
            this.labelAlumnoApellidoP.TabIndex = 23;
            this.labelAlumnoApellidoP.Text = "Apellido Paterno";
            // 
            // labelAlumnoSemestre
            // 
            this.labelAlumnoSemestre.AutoSize = true;
            this.labelAlumnoSemestre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoSemestre.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoSemestre.Location = new System.Drawing.Point(10, 247);
            this.labelAlumnoSemestre.Name = "labelAlumnoSemestre";
            this.labelAlumnoSemestre.Size = new System.Drawing.Size(75, 20);
            this.labelAlumnoSemestre.TabIndex = 21;
            this.labelAlumnoSemestre.Text = "Semestre";
            // 
            // buttonAlumnoCancelar
            // 
            this.buttonAlumnoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAlumnoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlumnoCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlumnoCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonAlumnoCancelar.Location = new System.Drawing.Point(198, 336);
            this.buttonAlumnoCancelar.Name = "buttonAlumnoCancelar";
            this.buttonAlumnoCancelar.Size = new System.Drawing.Size(78, 24);
            this.buttonAlumnoCancelar.TabIndex = 20;
            this.buttonAlumnoCancelar.Text = "Cancelar";
            this.buttonAlumnoCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonAlumnoGuardar
            // 
            this.buttonAlumnoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAlumnoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlumnoGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlumnoGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonAlumnoGuardar.Location = new System.Drawing.Point(71, 336);
            this.buttonAlumnoGuardar.Name = "buttonAlumnoGuardar";
            this.buttonAlumnoGuardar.Size = new System.Drawing.Size(75, 24);
            this.buttonAlumnoGuardar.TabIndex = 19;
            this.buttonAlumnoGuardar.Text = "Guardar";
            this.buttonAlumnoGuardar.UseVisualStyleBackColor = false;
            this.buttonAlumnoGuardar.Click += new System.EventHandler(this.buttonAlumnoGuardar_Click);
            // 
            // textAlumnoDireccion
            // 
            this.textAlumnoDireccion.Location = new System.Drawing.Point(93, 278);
            this.textAlumnoDireccion.Name = "textAlumnoDireccion";
            this.textAlumnoDireccion.Size = new System.Drawing.Size(221, 20);
            this.textAlumnoDireccion.TabIndex = 16;
            // 
            // textAlumnoNControl
            // 
            this.textAlumnoNControl.Location = new System.Drawing.Point(121, 143);
            this.textAlumnoNControl.Name = "textAlumnoNControl";
            this.textAlumnoNControl.Size = new System.Drawing.Size(193, 20);
            this.textAlumnoNControl.TabIndex = 6;
            // 
            // labelAlumnonNControl
            // 
            this.labelAlumnonNControl.AutoSize = true;
            this.labelAlumnonNControl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnonNControl.ForeColor = System.Drawing.Color.White;
            this.labelAlumnonNControl.Location = new System.Drawing.Point(9, 143);
            this.labelAlumnonNControl.Name = "labelAlumnonNControl";
            this.labelAlumnonNControl.Size = new System.Drawing.Size(106, 20);
            this.labelAlumnonNControl.TabIndex = 5;
            this.labelAlumnonNControl.Text = "Nº de control";
            // 
            // textAlumnoCurp
            // 
            this.textAlumnoCurp.Location = new System.Drawing.Point(81, 171);
            this.textAlumnoCurp.Name = "textAlumnoCurp";
            this.textAlumnoCurp.Size = new System.Drawing.Size(233, 20);
            this.textAlumnoCurp.TabIndex = 17;
            // 
            // labelAlumnoDireccion
            // 
            this.labelAlumnoDireccion.AutoSize = true;
            this.labelAlumnoDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoDireccion.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoDireccion.Location = new System.Drawing.Point(8, 278);
            this.labelAlumnoDireccion.Name = "labelAlumnoDireccion";
            this.labelAlumnoDireccion.Size = new System.Drawing.Size(80, 20);
            this.labelAlumnoDireccion.TabIndex = 10;
            this.labelAlumnoDireccion.Text = "Dirección";
            // 
            // labelAlumnoCurp
            // 
            this.labelAlumnoCurp.AutoSize = true;
            this.labelAlumnoCurp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoCurp.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoCurp.Location = new System.Drawing.Point(10, 168);
            this.labelAlumnoCurp.Name = "labelAlumnoCurp";
            this.labelAlumnoCurp.Size = new System.Drawing.Size(45, 20);
            this.labelAlumnoCurp.TabIndex = 12;
            this.labelAlumnoCurp.Text = "Curp";
            // 
            // labelAlumnoCarrera
            // 
            this.labelAlumnoCarrera.AutoSize = true;
            this.labelAlumnoCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoCarrera.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoCarrera.Location = new System.Drawing.Point(10, 220);
            this.labelAlumnoCarrera.Name = "labelAlumnoCarrera";
            this.labelAlumnoCarrera.Size = new System.Drawing.Size(66, 20);
            this.labelAlumnoCarrera.TabIndex = 11;
            this.labelAlumnoCarrera.Text = "Carrera";
            // 
            // labelAlumnoSexo
            // 
            this.labelAlumnoSexo.AutoSize = true;
            this.labelAlumnoSexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoSexo.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoSexo.Location = new System.Drawing.Point(9, 195);
            this.labelAlumnoSexo.Name = "labelAlumnoSexo";
            this.labelAlumnoSexo.Size = new System.Drawing.Size(43, 20);
            this.labelAlumnoSexo.TabIndex = 9;
            this.labelAlumnoSexo.Text = "Sexo";
            // 
            // textAlumnoTelefono
            // 
            this.textAlumnoTelefono.Location = new System.Drawing.Point(82, 306);
            this.textAlumnoTelefono.Name = "textAlumnoTelefono";
            this.textAlumnoTelefono.Size = new System.Drawing.Size(233, 20);
            this.textAlumnoTelefono.TabIndex = 8;
            this.textAlumnoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlumnoTelefono_KeyPress);
            // 
            // labelAlumnoTelefono
            // 
            this.labelAlumnoTelefono.AutoSize = true;
            this.labelAlumnoTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoTelefono.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoTelefono.Location = new System.Drawing.Point(10, 305);
            this.labelAlumnoTelefono.Name = "labelAlumnoTelefono";
            this.labelAlumnoTelefono.Size = new System.Drawing.Size(71, 20);
            this.labelAlumnoTelefono.TabIndex = 7;
            this.labelAlumnoTelefono.Text = "Teléfono";
            // 
            // textAlumnoNombre
            // 
            this.textAlumnoNombre.Location = new System.Drawing.Point(81, 59);
            this.textAlumnoNombre.Name = "textAlumnoNombre";
            this.textAlumnoNombre.Size = new System.Drawing.Size(233, 20);
            this.textAlumnoNombre.TabIndex = 2;
            this.textAlumnoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlumnoNombre_KeyPress);
            // 
            // labelAlumnoNombre
            // 
            this.labelAlumnoNombre.AutoSize = true;
            this.labelAlumnoNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoNombre.ForeColor = System.Drawing.Color.White;
            this.labelAlumnoNombre.Location = new System.Drawing.Point(8, 59);
            this.labelAlumnoNombre.Name = "labelAlumnoNombre";
            this.labelAlumnoNombre.Size = new System.Drawing.Size(68, 20);
            this.labelAlumnoNombre.TabIndex = 1;
            this.labelAlumnoNombre.Text = "Nombre";
            // 
            // labelAlumnoRegistro
            // 
            this.labelAlumnoRegistro.AutoSize = true;
            this.labelAlumnoRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelAlumnoRegistro.Location = new System.Drawing.Point(3, 19);
            this.labelAlumnoRegistro.Name = "labelAlumnoRegistro";
            this.labelAlumnoRegistro.Size = new System.Drawing.Size(143, 21);
            this.labelAlumnoRegistro.TabIndex = 0;
            this.labelAlumnoRegistro.Text = "Registrar Alumno";
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 370);
            this.Controls.Add(this.panelAlumnoVertical2);
            this.Controls.Add(this.panelAlumnoVertical);
            this.Name = "Alumno";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.panelAlumnoVertical.ResumeLayout(false);
            this.panelAlumnoVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.panelAlumnoVertical2.ResumeLayout(false);
            this.panelAlumnoVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlumnoVertical;
        private System.Windows.Forms.TextBox textAlumnoBuscar;
        private System.Windows.Forms.Label labelAlumnoBuscar;
        private System.Windows.Forms.DataGridView dataGridAlumno;
        private System.Windows.Forms.Label labelAlumnoLista;
        private System.Windows.Forms.Panel panelAlumnoVertical2;
        private System.Windows.Forms.Button buttonAlumnoCancelar;
        private System.Windows.Forms.Button buttonAlumnoGuardar;
        private System.Windows.Forms.TextBox textAlumnoCurp;
        private System.Windows.Forms.TextBox textAlumnoDireccion;
        private System.Windows.Forms.Label labelAlumnoCurp;
        private System.Windows.Forms.Label labelAlumnoCarrera;
        private System.Windows.Forms.Label labelAlumnoDireccion;
        private System.Windows.Forms.Label labelAlumnoSexo;
        private System.Windows.Forms.TextBox textAlumnoTelefono;
        private System.Windows.Forms.Label labelAlumnoTelefono;
        private System.Windows.Forms.TextBox textAlumnoNControl;
        private System.Windows.Forms.Label labelAlumnonNControl;
        private System.Windows.Forms.TextBox textAlumnoNombre;
        private System.Windows.Forms.Label labelAlumnoNombre;
        private System.Windows.Forms.Label labelAlumnoRegistro;
        private System.Windows.Forms.Label labelAlumnoSemestre;
        private System.Windows.Forms.ComboBox comboAlumnoSemestre;
        private System.Windows.Forms.Label labelAlumnoApellidoM;
        private System.Windows.Forms.TextBox textAlumnoApellidoP;
        private System.Windows.Forms.Label labelAlumnoApellidoP;
        private System.Windows.Forms.ComboBox comboAlumnoSexo;
        private System.Windows.Forms.ComboBox comboAlumnoCarrera;
        private System.Windows.Forms.TextBox textAlumnoApellidoM;
        private System.Windows.Forms.Label label1;
    }
}