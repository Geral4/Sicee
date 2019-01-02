namespace Inicio
{
    partial class ConsultaCargo
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
            this.panelCCargoVertical = new System.Windows.Forms.Panel();
            this.buttonCCargoBuscar = new System.Windows.Forms.Button();
            this.textCCargoBuscar = new System.Windows.Forms.TextBox();
            this.labelCCargoBuscar = new System.Windows.Forms.Label();
            this.buttonCCargoEliminar = new System.Windows.Forms.Button();
            this.buttonCCargoEditar = new System.Windows.Forms.Button();
            this.dataGridCCargo = new System.Windows.Forms.DataGridView();
            this.labelCCargoLista = new System.Windows.Forms.Label();
            this.panelEmpleadoVertical2 = new System.Windows.Forms.Panel();
            this.textCCargoDescripcion = new System.Windows.Forms.TextBox();
            this.buttonCargoCancelar = new System.Windows.Forms.Button();
            this.buttonCargoGuardar = new System.Windows.Forms.Button();
            this.comboCCargoDepartamento = new System.Windows.Forms.ComboBox();
            this.labelCargoDepartamento = new System.Windows.Forms.Label();
            this.textCCargoClave = new System.Windows.Forms.TextBox();
            this.labelCargoClave = new System.Windows.Forms.Label();
            this.labelCargoDescripcion = new System.Windows.Forms.Label();
            this.textCCargoNombre = new System.Windows.Forms.TextBox();
            this.labelCargoNombre = new System.Windows.Forms.Label();
            this.panelCCargoVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCCargo)).BeginInit();
            this.panelEmpleadoVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCCargoVertical
            // 
            this.panelCCargoVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelCCargoVertical.Controls.Add(this.buttonCCargoBuscar);
            this.panelCCargoVertical.Controls.Add(this.textCCargoBuscar);
            this.panelCCargoVertical.Controls.Add(this.labelCCargoBuscar);
            this.panelCCargoVertical.Controls.Add(this.buttonCCargoEliminar);
            this.panelCCargoVertical.Controls.Add(this.buttonCCargoEditar);
            this.panelCCargoVertical.Controls.Add(this.dataGridCCargo);
            this.panelCCargoVertical.Controls.Add(this.labelCCargoLista);
            this.panelCCargoVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCCargoVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCCargoVertical.Name = "panelCCargoVertical";
            this.panelCCargoVertical.Size = new System.Drawing.Size(413, 251);
            this.panelCCargoVertical.TabIndex = 6;
            this.panelCCargoVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCCargoVertical_Paint);
            // 
            // buttonCCargoBuscar
            // 
            this.buttonCCargoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonCCargoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCargoBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCargoBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonCCargoBuscar.Location = new System.Drawing.Point(307, 47);
            this.buttonCCargoBuscar.Name = "buttonCCargoBuscar";
            this.buttonCCargoBuscar.Size = new System.Drawing.Size(82, 26);
            this.buttonCCargoBuscar.TabIndex = 24;
            this.buttonCCargoBuscar.Text = "Buscar";
            this.buttonCCargoBuscar.UseVisualStyleBackColor = false;
            // 
            // textCCargoBuscar
            // 
            this.textCCargoBuscar.Location = new System.Drawing.Point(165, 51);
            this.textCCargoBuscar.Name = "textCCargoBuscar";
            this.textCCargoBuscar.Size = new System.Drawing.Size(137, 20);
            this.textCCargoBuscar.TabIndex = 23;
            // 
            // labelCCargoBuscar
            // 
            this.labelCCargoBuscar.AutoSize = true;
            this.labelCCargoBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCargoBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.labelCCargoBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCCargoBuscar.Location = new System.Drawing.Point(109, 52);
            this.labelCCargoBuscar.Name = "labelCCargoBuscar";
            this.labelCCargoBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelCCargoBuscar.TabIndex = 21;
            this.labelCCargoBuscar.Text = "Buscar";
            // 
            // buttonCCargoEliminar
            // 
            this.buttonCCargoEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCCargoEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCCargoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCargoEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCargoEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCCargoEliminar.Location = new System.Drawing.Point(260, 215);
            this.buttonCCargoEliminar.Name = "buttonCCargoEliminar";
            this.buttonCCargoEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCCargoEliminar.TabIndex = 22;
            this.buttonCCargoEliminar.Text = "Eliminar";
            this.buttonCCargoEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonCCargoEditar
            // 
            this.buttonCCargoEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCCargoEditar.FlatAppearance.BorderSize = 0;
            this.buttonCCargoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCargoEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCargoEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCCargoEditar.Location = new System.Drawing.Point(160, 215);
            this.buttonCCargoEditar.Name = "buttonCCargoEditar";
            this.buttonCCargoEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCCargoEditar.TabIndex = 21;
            this.buttonCCargoEditar.Text = "Editar";
            this.buttonCCargoEditar.UseVisualStyleBackColor = false;
            // 
            // dataGridCCargo
            // 
            this.dataGridCCargo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCCargo.Location = new System.Drawing.Point(10, 87);
            this.dataGridCCargo.Name = "dataGridCCargo";
            this.dataGridCCargo.Size = new System.Drawing.Size(391, 111);
            this.dataGridCCargo.TabIndex = 1;
            this.dataGridCCargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCCargo_CellContentClick);
            // 
            // labelCCargoLista
            // 
            this.labelCCargoLista.AutoSize = true;
            this.labelCCargoLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCargoLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCCargoLista.Location = new System.Drawing.Point(12, 11);
            this.labelCCargoLista.Name = "labelCCargoLista";
            this.labelCCargoLista.Size = new System.Drawing.Size(162, 24);
            this.labelCCargoLista.TabIndex = 0;
            this.labelCCargoLista.Text = "Lista de cargos";
            // 
            // panelEmpleadoVertical2
            // 
            this.panelEmpleadoVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelEmpleadoVertical2.Controls.Add(this.textCCargoDescripcion);
            this.panelEmpleadoVertical2.Controls.Add(this.buttonCargoCancelar);
            this.panelEmpleadoVertical2.Controls.Add(this.buttonCargoGuardar);
            this.panelEmpleadoVertical2.Controls.Add(this.comboCCargoDepartamento);
            this.panelEmpleadoVertical2.Controls.Add(this.labelCargoDepartamento);
            this.panelEmpleadoVertical2.Controls.Add(this.textCCargoClave);
            this.panelEmpleadoVertical2.Controls.Add(this.labelCargoClave);
            this.panelEmpleadoVertical2.Controls.Add(this.labelCargoDescripcion);
            this.panelEmpleadoVertical2.Controls.Add(this.textCCargoNombre);
            this.panelEmpleadoVertical2.Controls.Add(this.labelCargoNombre);
            this.panelEmpleadoVertical2.Location = new System.Drawing.Point(407, 0);
            this.panelEmpleadoVertical2.Name = "panelEmpleadoVertical2";
            this.panelEmpleadoVertical2.Size = new System.Drawing.Size(326, 251);
            this.panelEmpleadoVertical2.TabIndex = 7;
            // 
            // textCCargoDescripcion
            // 
            this.textCCargoDescripcion.Location = new System.Drawing.Point(121, 102);
            this.textCCargoDescripcion.Multiline = true;
            this.textCCargoDescripcion.Name = "textCCargoDescripcion";
            this.textCCargoDescripcion.Size = new System.Drawing.Size(194, 64);
            this.textCCargoDescripcion.TabIndex = 33;
            // 
            // buttonCargoCancelar
            // 
            this.buttonCargoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCargoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargoCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargoCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCargoCancelar.Location = new System.Drawing.Point(206, 215);
            this.buttonCargoCancelar.Name = "buttonCargoCancelar";
            this.buttonCargoCancelar.Size = new System.Drawing.Size(78, 24);
            this.buttonCargoCancelar.TabIndex = 32;
            this.buttonCargoCancelar.Text = "Cancelar";
            this.buttonCargoCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonCargoGuardar
            // 
            this.buttonCargoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCargoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargoGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargoGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonCargoGuardar.Location = new System.Drawing.Point(81, 215);
            this.buttonCargoGuardar.Name = "buttonCargoGuardar";
            this.buttonCargoGuardar.Size = new System.Drawing.Size(75, 24);
            this.buttonCargoGuardar.TabIndex = 31;
            this.buttonCargoGuardar.Text = "Guardar";
            this.buttonCargoGuardar.UseVisualStyleBackColor = false;
            // 
            // comboCCargoDepartamento
            // 
            this.comboCCargoDepartamento.FormattingEnabled = true;
            this.comboCCargoDepartamento.Location = new System.Drawing.Point(121, 173);
            this.comboCCargoDepartamento.Name = "comboCCargoDepartamento";
            this.comboCCargoDepartamento.Size = new System.Drawing.Size(194, 21);
            this.comboCCargoDepartamento.TabIndex = 30;
            // 
            // labelCargoDepartamento
            // 
            this.labelCargoDepartamento.AutoSize = true;
            this.labelCargoDepartamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoDepartamento.ForeColor = System.Drawing.Color.White;
            this.labelCargoDepartamento.Location = new System.Drawing.Point(9, 174);
            this.labelCargoDepartamento.Name = "labelCargoDepartamento";
            this.labelCargoDepartamento.Size = new System.Drawing.Size(117, 20);
            this.labelCargoDepartamento.TabIndex = 29;
            this.labelCargoDepartamento.Text = "Departamento";
            // 
            // textCCargoClave
            // 
            this.textCCargoClave.Location = new System.Drawing.Point(82, 47);
            this.textCCargoClave.Name = "textCCargoClave";
            this.textCCargoClave.Size = new System.Drawing.Size(233, 20);
            this.textCCargoClave.TabIndex = 28;
            // 
            // labelCargoClave
            // 
            this.labelCargoClave.AutoSize = true;
            this.labelCargoClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoClave.ForeColor = System.Drawing.Color.White;
            this.labelCargoClave.Location = new System.Drawing.Point(10, 48);
            this.labelCargoClave.Name = "labelCargoClave";
            this.labelCargoClave.Size = new System.Drawing.Size(54, 20);
            this.labelCargoClave.TabIndex = 27;
            this.labelCargoClave.Text = "Clave";
            // 
            // labelCargoDescripcion
            // 
            this.labelCargoDescripcion.AutoSize = true;
            this.labelCargoDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelCargoDescripcion.Location = new System.Drawing.Point(10, 100);
            this.labelCargoDescripcion.Name = "labelCargoDescripcion";
            this.labelCargoDescripcion.Size = new System.Drawing.Size(96, 20);
            this.labelCargoDescripcion.TabIndex = 25;
            this.labelCargoDescripcion.Text = "Descripción";
            // 
            // textCCargoNombre
            // 
            this.textCCargoNombre.Location = new System.Drawing.Point(82, 74);
            this.textCCargoNombre.Name = "textCCargoNombre";
            this.textCCargoNombre.Size = new System.Drawing.Size(233, 20);
            this.textCCargoNombre.TabIndex = 24;
            // 
            // labelCargoNombre
            // 
            this.labelCargoNombre.AutoSize = true;
            this.labelCargoNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoNombre.ForeColor = System.Drawing.Color.White;
            this.labelCargoNombre.Location = new System.Drawing.Point(9, 75);
            this.labelCargoNombre.Name = "labelCargoNombre";
            this.labelCargoNombre.Size = new System.Drawing.Size(68, 20);
            this.labelCargoNombre.TabIndex = 23;
            this.labelCargoNombre.Text = "Nombre";
            // 
            // ConsultaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 251);
            this.Controls.Add(this.panelEmpleadoVertical2);
            this.Controls.Add(this.panelCCargoVertical);
            this.Name = "ConsultaCargo";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaCargo";
            this.Load += new System.EventHandler(this.ConsultaCargo_Load);
            this.panelCCargoVertical.ResumeLayout(false);
            this.panelCCargoVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCCargo)).EndInit();
            this.panelEmpleadoVertical2.ResumeLayout(false);
            this.panelEmpleadoVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCCargoVertical;
        private System.Windows.Forms.Button buttonCCargoBuscar;
        private System.Windows.Forms.TextBox textCCargoBuscar;
        private System.Windows.Forms.Label labelCCargoBuscar;
        private System.Windows.Forms.Button buttonCCargoEliminar;
        private System.Windows.Forms.Button buttonCCargoEditar;
        private System.Windows.Forms.DataGridView dataGridCCargo;
        private System.Windows.Forms.Label labelCCargoLista;
        private System.Windows.Forms.Panel panelEmpleadoVertical2;
        private System.Windows.Forms.ComboBox comboCCargoDepartamento;
        private System.Windows.Forms.Label labelCargoDepartamento;
        private System.Windows.Forms.TextBox textCCargoClave;
        private System.Windows.Forms.Label labelCargoClave;
        private System.Windows.Forms.Label labelCargoDescripcion;
        private System.Windows.Forms.TextBox textCCargoNombre;
        private System.Windows.Forms.Label labelCargoNombre;
        private System.Windows.Forms.Button buttonCargoCancelar;
        private System.Windows.Forms.Button buttonCargoGuardar;
        private System.Windows.Forms.TextBox textCCargoDescripcion;
    }
}