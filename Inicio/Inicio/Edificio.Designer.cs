namespace Inicio
{
    partial class Edificio
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
            this.panelEdificioVertical2 = new System.Windows.Forms.Panel();
            this.buttonCarreraCancelar = new System.Windows.Forms.Button();
            this.buttonEdificioSiguiente = new System.Windows.Forms.Button();
            this.numericEdificio = new System.Windows.Forms.NumericUpDown();
            this.labelEdificioNAulas = new System.Windows.Forms.Label();
            this.labelEdificioDescripcion = new System.Windows.Forms.Label();
            this.textEdificioNombre = new System.Windows.Forms.TextBox();
            this.labelEdificioNombre = new System.Windows.Forms.Label();
            this.textEdificioDescripcion = new System.Windows.Forms.TextBox();
            this.textEdificioClave = new System.Windows.Forms.TextBox();
            this.labelEdificioClave = new System.Windows.Forms.Label();
            this.labelEdificioRegistro = new System.Windows.Forms.Label();
            this.labelEdificioLista = new System.Windows.Forms.Label();
            this.dataGridEdificio = new System.Windows.Forms.DataGridView();
            this.labelEdificioBuscar = new System.Windows.Forms.Label();
            this.textEdificioBuscar = new System.Windows.Forms.TextBox();
            this.panelEdificioVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEdificioVertical2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEdificio)).BeginInit();
            this.panelEdificioVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEdificioVertical2
            // 
            this.panelEdificioVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelEdificioVertical2.Controls.Add(this.buttonCarreraCancelar);
            this.panelEdificioVertical2.Controls.Add(this.buttonEdificioSiguiente);
            this.panelEdificioVertical2.Controls.Add(this.numericEdificio);
            this.panelEdificioVertical2.Controls.Add(this.labelEdificioNAulas);
            this.panelEdificioVertical2.Controls.Add(this.labelEdificioDescripcion);
            this.panelEdificioVertical2.Controls.Add(this.textEdificioNombre);
            this.panelEdificioVertical2.Controls.Add(this.labelEdificioNombre);
            this.panelEdificioVertical2.Controls.Add(this.textEdificioDescripcion);
            this.panelEdificioVertical2.Controls.Add(this.textEdificioClave);
            this.panelEdificioVertical2.Controls.Add(this.labelEdificioClave);
            this.panelEdificioVertical2.Controls.Add(this.labelEdificioRegistro);
            this.panelEdificioVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdificioVertical2.Location = new System.Drawing.Point(455, 0);
            this.panelEdificioVertical2.Name = "panelEdificioVertical2";
            this.panelEdificioVertical2.Size = new System.Drawing.Size(323, 289);
            this.panelEdificioVertical2.TabIndex = 4;
            // 
            // buttonCarreraCancelar
            // 
            this.buttonCarreraCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCarreraCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCarreraCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarreraCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCarreraCancelar.Location = new System.Drawing.Point(202, 227);
            this.buttonCarreraCancelar.Name = "buttonCarreraCancelar";
            this.buttonCarreraCancelar.Size = new System.Drawing.Size(94, 35);
            this.buttonCarreraCancelar.TabIndex = 26;
            this.buttonCarreraCancelar.Text = "Cancelar";
            this.buttonCarreraCancelar.UseVisualStyleBackColor = false;
            this.buttonCarreraCancelar.Click += new System.EventHandler(this.buttonCarreraCancelar_Click);
            // 
            // buttonEdificioSiguiente
            // 
            this.buttonEdificioSiguiente.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEdificioSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdificioSiguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdificioSiguiente.ForeColor = System.Drawing.Color.White;
            this.buttonEdificioSiguiente.Location = new System.Drawing.Point(41, 227);
            this.buttonEdificioSiguiente.Name = "buttonEdificioSiguiente";
            this.buttonEdificioSiguiente.Size = new System.Drawing.Size(103, 35);
            this.buttonEdificioSiguiente.TabIndex = 25;
            this.buttonEdificioSiguiente.Text = "Siguiente";
            this.buttonEdificioSiguiente.UseVisualStyleBackColor = false;
            this.buttonEdificioSiguiente.Click += new System.EventHandler(this.buttonEdificioRegistrar_Click);
            // 
            // numericEdificio
            // 
            this.numericEdificio.Location = new System.Drawing.Point(111, 185);
            this.numericEdificio.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericEdificio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEdificio.Name = "numericEdificio";
            this.numericEdificio.Size = new System.Drawing.Size(203, 20);
            this.numericEdificio.TabIndex = 24;
            this.numericEdificio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelEdificioNAulas
            // 
            this.labelEdificioNAulas.AutoSize = true;
            this.labelEdificioNAulas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdificioNAulas.ForeColor = System.Drawing.Color.White;
            this.labelEdificioNAulas.Location = new System.Drawing.Point(12, 183);
            this.labelEdificioNAulas.Name = "labelEdificioNAulas";
            this.labelEdificioNAulas.Size = new System.Drawing.Size(75, 20);
            this.labelEdificioNAulas.TabIndex = 23;
            this.labelEdificioNAulas.Text = "Nº Aulas*";
            // 
            // labelEdificioDescripcion
            // 
            this.labelEdificioDescripcion.AutoSize = true;
            this.labelEdificioDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdificioDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelEdificioDescripcion.Location = new System.Drawing.Point(9, 115);
            this.labelEdificioDescripcion.Name = "labelEdificioDescripcion";
            this.labelEdificioDescripcion.Size = new System.Drawing.Size(96, 20);
            this.labelEdificioDescripcion.TabIndex = 7;
            this.labelEdificioDescripcion.Text = "Descripción";
            // 
            // textEdificioNombre
            // 
            this.textEdificioNombre.Location = new System.Drawing.Point(81, 59);
            this.textEdificioNombre.Name = "textEdificioNombre";
            this.textEdificioNombre.Size = new System.Drawing.Size(233, 20);
            this.textEdificioNombre.TabIndex = 6;
            this.textEdificioNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdificioNombre_KeyPress);
            // 
            // labelEdificioNombre
            // 
            this.labelEdificioNombre.AutoSize = true;
            this.labelEdificioNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdificioNombre.ForeColor = System.Drawing.Color.White;
            this.labelEdificioNombre.Location = new System.Drawing.Point(9, 57);
            this.labelEdificioNombre.Name = "labelEdificioNombre";
            this.labelEdificioNombre.Size = new System.Drawing.Size(74, 20);
            this.labelEdificioNombre.TabIndex = 5;
            this.labelEdificioNombre.Text = "Nombre*";
            // 
            // textEdificioDescripcion
            // 
            this.textEdificioDescripcion.Location = new System.Drawing.Point(111, 116);
            this.textEdificioDescripcion.Multiline = true;
            this.textEdificioDescripcion.Name = "textEdificioDescripcion";
            this.textEdificioDescripcion.Size = new System.Drawing.Size(203, 52);
            this.textEdificioDescripcion.TabIndex = 4;
            // 
            // textEdificioClave
            // 
            this.textEdificioClave.Location = new System.Drawing.Point(111, 88);
            this.textEdificioClave.Name = "textEdificioClave";
            this.textEdificioClave.Size = new System.Drawing.Size(203, 20);
            this.textEdificioClave.TabIndex = 2;
            // 
            // labelEdificioClave
            // 
            this.labelEdificioClave.AutoSize = true;
            this.labelEdificioClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdificioClave.ForeColor = System.Drawing.Color.White;
            this.labelEdificioClave.Location = new System.Drawing.Point(8, 88);
            this.labelEdificioClave.Name = "labelEdificioClave";
            this.labelEdificioClave.Size = new System.Drawing.Size(60, 20);
            this.labelEdificioClave.TabIndex = 1;
            this.labelEdificioClave.Text = "Clave*";
            // 
            // labelEdificioRegistro
            // 
            this.labelEdificioRegistro.AutoSize = true;
            this.labelEdificioRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdificioRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelEdificioRegistro.Location = new System.Drawing.Point(3, 19);
            this.labelEdificioRegistro.Name = "labelEdificioRegistro";
            this.labelEdificioRegistro.Size = new System.Drawing.Size(141, 21);
            this.labelEdificioRegistro.TabIndex = 0;
            this.labelEdificioRegistro.Text = "Registrar  edificio";
            // 
            // labelEdificioLista
            // 
            this.labelEdificioLista.AutoSize = true;
            this.labelEdificioLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdificioLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelEdificioLista.Location = new System.Drawing.Point(4, 19);
            this.labelEdificioLista.Name = "labelEdificioLista";
            this.labelEdificioLista.Size = new System.Drawing.Size(134, 21);
            this.labelEdificioLista.TabIndex = 0;
            this.labelEdificioLista.Text = "Lista de edificios";
            // 
            // dataGridEdificio
            // 
            this.dataGridEdificio.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEdificio.Location = new System.Drawing.Point(5, 69);
            this.dataGridEdificio.Name = "dataGridEdificio";
            this.dataGridEdificio.Size = new System.Drawing.Size(444, 182);
            this.dataGridEdificio.TabIndex = 1;
            this.dataGridEdificio.DoubleClick += new System.EventHandler(this.dataGridEdificio_DoubleClick);
            // 
            // labelEdificioBuscar
            // 
            this.labelEdificioBuscar.AutoSize = true;
            this.labelEdificioBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdificioBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelEdificioBuscar.Location = new System.Drawing.Point(231, 35);
            this.labelEdificioBuscar.Name = "labelEdificioBuscar";
            this.labelEdificioBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelEdificioBuscar.TabIndex = 21;
            this.labelEdificioBuscar.Text = "Buscar";
            // 
            // textEdificioBuscar
            // 
            this.textEdificioBuscar.Location = new System.Drawing.Point(296, 36);
            this.textEdificioBuscar.Name = "textEdificioBuscar";
            this.textEdificioBuscar.Size = new System.Drawing.Size(135, 20);
            this.textEdificioBuscar.TabIndex = 23;
            this.textEdificioBuscar.TextChanged += new System.EventHandler(this.textEdificioBuscar_TextChanged);
            // 
            // panelEdificioVertical
            // 
            this.panelEdificioVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelEdificioVertical.Controls.Add(this.label1);
            this.panelEdificioVertical.Controls.Add(this.textEdificioBuscar);
            this.panelEdificioVertical.Controls.Add(this.labelEdificioBuscar);
            this.panelEdificioVertical.Controls.Add(this.dataGridEdificio);
            this.panelEdificioVertical.Controls.Add(this.labelEdificioLista);
            this.panelEdificioVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEdificioVertical.Location = new System.Drawing.Point(0, 0);
            this.panelEdificioVertical.Name = "panelEdificioVertical";
            this.panelEdificioVertical.Size = new System.Drawing.Size(468, 289);
            this.panelEdificioVertical.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(4, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "*Solo para consultas";
            // 
            // Edificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 289);
            this.Controls.Add(this.panelEdificioVertical2);
            this.Controls.Add(this.panelEdificioVertical);
            this.Name = "Edificio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edificio";
            this.Load += new System.EventHandler(this.Edificio_Load);
            this.panelEdificioVertical2.ResumeLayout(false);
            this.panelEdificioVertical2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEdificio)).EndInit();
            this.panelEdificioVertical.ResumeLayout(false);
            this.panelEdificioVertical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelEdificioVertical2;
        private System.Windows.Forms.Label labelEdificioDescripcion;
        private System.Windows.Forms.TextBox textEdificioNombre;
        private System.Windows.Forms.Label labelEdificioNombre;
        private System.Windows.Forms.TextBox textEdificioClave;
        private System.Windows.Forms.Label labelEdificioClave;
        private System.Windows.Forms.Label labelEdificioRegistro;
        private System.Windows.Forms.NumericUpDown numericEdificio;
        private System.Windows.Forms.Label labelEdificioNAulas;
        private System.Windows.Forms.Button buttonEdificioSiguiente;
        private System.Windows.Forms.Label labelEdificioLista;
        private System.Windows.Forms.DataGridView dataGridEdificio;
        private System.Windows.Forms.Label labelEdificioBuscar;
        private System.Windows.Forms.TextBox textEdificioBuscar;
        private System.Windows.Forms.Panel panelEdificioVertical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEdificioDescripcion;
        private System.Windows.Forms.Button buttonCarreraCancelar;
    }
}