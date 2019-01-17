namespace Inicio
{
    partial class Usuario
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
            this.panelUsuarioVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.labelUsuarioBuscar = new System.Windows.Forms.Label();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.labelUsuarioLista = new System.Windows.Forms.Label();
            this.panelUsuarioVertical2 = new System.Windows.Forms.Panel();
            this.textUsuarioNombre = new System.Windows.Forms.TextBox();
            this.comboUsuarioNPersonal = new System.Windows.Forms.ComboBox();
            this.textUsuarioRepetir = new System.Windows.Forms.TextBox();
            this.labelUsuarioRepetir = new System.Windows.Forms.Label();
            this.buttonUsuarioCancelar = new System.Windows.Forms.Button();
            this.buttonUsuarioGuardar = new System.Windows.Forms.Button();
            this.comboUsuarioAcceso = new System.Windows.Forms.ComboBox();
            this.textUsuarioContraseña = new System.Windows.Forms.TextBox();
            this.textUsuarioUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuarioAcceso = new System.Windows.Forms.Label();
            this.labelUsuarioContraseña = new System.Windows.Forms.Label();
            this.labelUsuarioUsuario = new System.Windows.Forms.Label();
            this.labelUsuarioNPersonal = new System.Windows.Forms.Label();
            this.labelUsuarioRegistro = new System.Windows.Forms.Label();
            this.panelUsuarioVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.panelUsuarioVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsuarioVertical
            // 
            this.panelUsuarioVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelUsuarioVertical.Controls.Add(this.label1);
            this.panelUsuarioVertical.Controls.Add(this.textUsuarioBuscar);
            this.panelUsuarioVertical.Controls.Add(this.labelUsuarioBuscar);
            this.panelUsuarioVertical.Controls.Add(this.dataGridUsuario);
            this.panelUsuarioVertical.Controls.Add(this.labelUsuarioLista);
            this.panelUsuarioVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUsuarioVertical.Location = new System.Drawing.Point(0, 0);
            this.panelUsuarioVertical.Name = "panelUsuarioVertical";
            this.panelUsuarioVertical.Size = new System.Drawing.Size(565, 273);
            this.panelUsuarioVertical.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(8, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "*Solo para consultas";
            // 
            // textUsuarioBuscar
            // 
            this.textUsuarioBuscar.Location = new System.Drawing.Point(310, 36);
            this.textUsuarioBuscar.Name = "textUsuarioBuscar";
            this.textUsuarioBuscar.Size = new System.Drawing.Size(170, 20);
            this.textUsuarioBuscar.TabIndex = 23;
            this.textUsuarioBuscar.TextChanged += new System.EventHandler(this.textUsuarioBuscar_TextChanged);
            // 
            // labelUsuarioBuscar
            // 
            this.labelUsuarioBuscar.AutoSize = true;
            this.labelUsuarioBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelUsuarioBuscar.Location = new System.Drawing.Point(247, 36);
            this.labelUsuarioBuscar.Name = "labelUsuarioBuscar";
            this.labelUsuarioBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelUsuarioBuscar.TabIndex = 21;
            this.labelUsuarioBuscar.Text = "Buscar";
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Location = new System.Drawing.Point(6, 69);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.Size = new System.Drawing.Size(544, 169);
            this.dataGridUsuario.TabIndex = 1;
            // 
            // labelUsuarioLista
            // 
            this.labelUsuarioLista.AutoSize = true;
            this.labelUsuarioLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelUsuarioLista.Location = new System.Drawing.Point(12, 11);
            this.labelUsuarioLista.Name = "labelUsuarioLista";
            this.labelUsuarioLista.Size = new System.Drawing.Size(134, 21);
            this.labelUsuarioLista.TabIndex = 0;
            this.labelUsuarioLista.Text = "Lista de usuarios";
            // 
            // panelUsuarioVertical2
            // 
            this.panelUsuarioVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelUsuarioVertical2.Controls.Add(this.textUsuarioNombre);
            this.panelUsuarioVertical2.Controls.Add(this.comboUsuarioNPersonal);
            this.panelUsuarioVertical2.Controls.Add(this.textUsuarioRepetir);
            this.panelUsuarioVertical2.Controls.Add(this.labelUsuarioRepetir);
            this.panelUsuarioVertical2.Controls.Add(this.buttonUsuarioCancelar);
            this.panelUsuarioVertical2.Controls.Add(this.buttonUsuarioGuardar);
            this.panelUsuarioVertical2.Controls.Add(this.comboUsuarioAcceso);
            this.panelUsuarioVertical2.Controls.Add(this.textUsuarioContraseña);
            this.panelUsuarioVertical2.Controls.Add(this.textUsuarioUsuario);
            this.panelUsuarioVertical2.Controls.Add(this.labelUsuarioAcceso);
            this.panelUsuarioVertical2.Controls.Add(this.labelUsuarioContraseña);
            this.panelUsuarioVertical2.Controls.Add(this.labelUsuarioUsuario);
            this.panelUsuarioVertical2.Controls.Add(this.labelUsuarioNPersonal);
            this.panelUsuarioVertical2.Controls.Add(this.labelUsuarioRegistro);
            this.panelUsuarioVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUsuarioVertical2.Location = new System.Drawing.Point(564, 0);
            this.panelUsuarioVertical2.Name = "panelUsuarioVertical2";
            this.panelUsuarioVertical2.Size = new System.Drawing.Size(321, 273);
            this.panelUsuarioVertical2.TabIndex = 1;
            // 
            // textUsuarioNombre
            // 
            this.textUsuarioNombre.Enabled = false;
            this.textUsuarioNombre.Location = new System.Drawing.Point(25, 93);
            this.textUsuarioNombre.Name = "textUsuarioNombre";
            this.textUsuarioNombre.ReadOnly = true;
            this.textUsuarioNombre.Size = new System.Drawing.Size(275, 20);
            this.textUsuarioNombre.TabIndex = 27;
            // 
            // comboUsuarioNPersonal
            // 
            this.comboUsuarioNPersonal.FormattingEnabled = true;
            this.comboUsuarioNPersonal.Location = new System.Drawing.Point(100, 63);
            this.comboUsuarioNPersonal.Name = "comboUsuarioNPersonal";
            this.comboUsuarioNPersonal.Size = new System.Drawing.Size(214, 21);
            this.comboUsuarioNPersonal.TabIndex = 25;
            this.comboUsuarioNPersonal.SelectedIndexChanged += new System.EventHandler(this.comboUsuarioNPersonal_SelectedIndexChanged);
            // 
            // textUsuarioRepetir
            // 
            this.textUsuarioRepetir.Location = new System.Drawing.Point(155, 180);
            this.textUsuarioRepetir.Name = "textUsuarioRepetir";
            this.textUsuarioRepetir.Size = new System.Drawing.Size(159, 20);
            this.textUsuarioRepetir.TabIndex = 24;
            // 
            // labelUsuarioRepetir
            // 
            this.labelUsuarioRepetir.AutoSize = true;
            this.labelUsuarioRepetir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioRepetir.ForeColor = System.Drawing.Color.White;
            this.labelUsuarioRepetir.Location = new System.Drawing.Point(9, 178);
            this.labelUsuarioRepetir.Name = "labelUsuarioRepetir";
            this.labelUsuarioRepetir.Size = new System.Drawing.Size(153, 20);
            this.labelUsuarioRepetir.TabIndex = 23;
            this.labelUsuarioRepetir.Text = "Repetir contraseña ";
            // 
            // buttonUsuarioCancelar
            // 
            this.buttonUsuarioCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonUsuarioCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuarioCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarioCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonUsuarioCancelar.Location = new System.Drawing.Point(198, 241);
            this.buttonUsuarioCancelar.Name = "buttonUsuarioCancelar";
            this.buttonUsuarioCancelar.Size = new System.Drawing.Size(78, 24);
            this.buttonUsuarioCancelar.TabIndex = 20;
            this.buttonUsuarioCancelar.Text = "Cancelar";
            this.buttonUsuarioCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonUsuarioGuardar
            // 
            this.buttonUsuarioGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonUsuarioGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuarioGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarioGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonUsuarioGuardar.Location = new System.Drawing.Point(71, 241);
            this.buttonUsuarioGuardar.Name = "buttonUsuarioGuardar";
            this.buttonUsuarioGuardar.Size = new System.Drawing.Size(75, 24);
            this.buttonUsuarioGuardar.TabIndex = 19;
            this.buttonUsuarioGuardar.Text = "Guardar";
            this.buttonUsuarioGuardar.UseVisualStyleBackColor = false;
            this.buttonUsuarioGuardar.Click += new System.EventHandler(this.buttonUsuarioGuardar_Click);
            // 
            // comboUsuarioAcceso
            // 
            this.comboUsuarioAcceso.FormattingEnabled = true;
            this.comboUsuarioAcceso.Location = new System.Drawing.Point(81, 208);
            this.comboUsuarioAcceso.Name = "comboUsuarioAcceso";
            this.comboUsuarioAcceso.Size = new System.Drawing.Size(233, 21);
            this.comboUsuarioAcceso.TabIndex = 18;
            // 
            // textUsuarioContraseña
            // 
            this.textUsuarioContraseña.Location = new System.Drawing.Point(111, 151);
            this.textUsuarioContraseña.Name = "textUsuarioContraseña";
            this.textUsuarioContraseña.Size = new System.Drawing.Size(203, 20);
            this.textUsuarioContraseña.TabIndex = 17;
            // 
            // textUsuarioUsuario
            // 
            this.textUsuarioUsuario.Location = new System.Drawing.Point(100, 122);
            this.textUsuarioUsuario.Name = "textUsuarioUsuario";
            this.textUsuarioUsuario.Size = new System.Drawing.Size(214, 20);
            this.textUsuarioUsuario.TabIndex = 16;
            // 
            // labelUsuarioAcceso
            // 
            this.labelUsuarioAcceso.AutoSize = true;
            this.labelUsuarioAcceso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioAcceso.ForeColor = System.Drawing.Color.White;
            this.labelUsuarioAcceso.Location = new System.Drawing.Point(9, 207);
            this.labelUsuarioAcceso.Name = "labelUsuarioAcceso";
            this.labelUsuarioAcceso.Size = new System.Drawing.Size(66, 20);
            this.labelUsuarioAcceso.TabIndex = 12;
            this.labelUsuarioAcceso.Text = "Acceso";
            // 
            // labelUsuarioContraseña
            // 
            this.labelUsuarioContraseña.AutoSize = true;
            this.labelUsuarioContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioContraseña.ForeColor = System.Drawing.Color.White;
            this.labelUsuarioContraseña.Location = new System.Drawing.Point(9, 150);
            this.labelUsuarioContraseña.Name = "labelUsuarioContraseña";
            this.labelUsuarioContraseña.Size = new System.Drawing.Size(95, 20);
            this.labelUsuarioContraseña.TabIndex = 11;
            this.labelUsuarioContraseña.Text = "Contraseña";
            // 
            // labelUsuarioUsuario
            // 
            this.labelUsuarioUsuario.AutoSize = true;
            this.labelUsuarioUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuarioUsuario.Location = new System.Drawing.Point(9, 122);
            this.labelUsuarioUsuario.Name = "labelUsuarioUsuario";
            this.labelUsuarioUsuario.Size = new System.Drawing.Size(48, 20);
            this.labelUsuarioUsuario.TabIndex = 10;
            this.labelUsuarioUsuario.Text = "Login";
            // 
            // labelUsuarioNPersonal
            // 
            this.labelUsuarioNPersonal.AutoSize = true;
            this.labelUsuarioNPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioNPersonal.ForeColor = System.Drawing.Color.White;
            this.labelUsuarioNPersonal.Location = new System.Drawing.Point(8, 63);
            this.labelUsuarioNPersonal.Name = "labelUsuarioNPersonal";
            this.labelUsuarioNPersonal.Size = new System.Drawing.Size(92, 20);
            this.labelUsuarioNPersonal.TabIndex = 1;
            this.labelUsuarioNPersonal.Text = "Nº Personal";
            // 
            // labelUsuarioRegistro
            // 
            this.labelUsuarioRegistro.AutoSize = true;
            this.labelUsuarioRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelUsuarioRegistro.Location = new System.Drawing.Point(3, 19);
            this.labelUsuarioRegistro.Name = "labelUsuarioRegistro";
            this.labelUsuarioRegistro.Size = new System.Drawing.Size(138, 21);
            this.labelUsuarioRegistro.TabIndex = 0;
            this.labelUsuarioRegistro.Text = "Registrar Usuario";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 273);
            this.Controls.Add(this.panelUsuarioVertical2);
            this.Controls.Add(this.panelUsuarioVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Usuario";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.panelUsuarioVertical.ResumeLayout(false);
            this.panelUsuarioVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.panelUsuarioVertical2.ResumeLayout(false);
            this.panelUsuarioVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsuarioVertical;
        private System.Windows.Forms.Panel panelUsuarioVertical2;
        private System.Windows.Forms.Label labelUsuarioLista;
        private System.Windows.Forms.Label labelUsuarioRegistro;
        private System.Windows.Forms.Label labelUsuarioNPersonal;
        private System.Windows.Forms.ComboBox comboUsuarioAcceso;
        private System.Windows.Forms.TextBox textUsuarioContraseña;
        private System.Windows.Forms.TextBox textUsuarioUsuario;
        private System.Windows.Forms.Label labelUsuarioAcceso;
        private System.Windows.Forms.Label labelUsuarioContraseña;
        private System.Windows.Forms.Label labelUsuarioUsuario;
        private System.Windows.Forms.Button buttonUsuarioGuardar;
        private System.Windows.Forms.Button buttonUsuarioCancelar;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.TextBox textUsuarioBuscar;
        private System.Windows.Forms.Label labelUsuarioBuscar;
        private System.Windows.Forms.TextBox textUsuarioRepetir;
        private System.Windows.Forms.Label labelUsuarioRepetir;
        private System.Windows.Forms.ComboBox comboUsuarioNPersonal;
        private System.Windows.Forms.TextBox textUsuarioNombre;
        private System.Windows.Forms.Label label1;
    }
}