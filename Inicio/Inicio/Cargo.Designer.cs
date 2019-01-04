namespace Inicio
{
    partial class Cargo
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
            this.panelCargoVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textCargoBuscar = new System.Windows.Forms.TextBox();
            this.labelCargoBuscar = new System.Windows.Forms.Label();
            this.dataGridViewCargo = new System.Windows.Forms.DataGridView();
            this.labelCargoLista = new System.Windows.Forms.Label();
            this.panelCargoVertical2 = new System.Windows.Forms.Panel();
            this.comboCargoDepartamento = new System.Windows.Forms.ComboBox();
            this.labelCargoDepartamento = new System.Windows.Forms.Label();
            this.buttonCargoCancelar = new System.Windows.Forms.Button();
            this.buttonCargoGuardar = new System.Windows.Forms.Button();
            this.textCargoClave = new System.Windows.Forms.TextBox();
            this.labelCargoClave = new System.Windows.Forms.Label();
            this.textCargoDescripcion = new System.Windows.Forms.TextBox();
            this.labelCargoDescripcion = new System.Windows.Forms.Label();
            this.textCargoNombre = new System.Windows.Forms.TextBox();
            this.labelCargoNombre = new System.Windows.Forms.Label();
            this.labelCargoRegistro = new System.Windows.Forms.Label();
            this.panelCargoVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).BeginInit();
            this.panelCargoVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCargoVertical
            // 
            this.panelCargoVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCargoVertical.Controls.Add(this.label1);
            this.panelCargoVertical.Controls.Add(this.textCargoBuscar);
            this.panelCargoVertical.Controls.Add(this.labelCargoBuscar);
            this.panelCargoVertical.Controls.Add(this.dataGridViewCargo);
            this.panelCargoVertical.Controls.Add(this.labelCargoLista);
            this.panelCargoVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCargoVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCargoVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCargoVertical.Name = "panelCargoVertical";
            this.panelCargoVertical.Size = new System.Drawing.Size(612, 336);
            this.panelCargoVertical.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(16, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "*Solo para consultas";
            // 
            // textCargoBuscar
            // 
            this.textCargoBuscar.Location = new System.Drawing.Point(302, 49);
            this.textCargoBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCargoBuscar.Name = "textCargoBuscar";
            this.textCargoBuscar.Size = new System.Drawing.Size(181, 22);
            this.textCargoBuscar.TabIndex = 23;
            this.textCargoBuscar.TextChanged += new System.EventHandler(this.textCargoBuscar_TextChanged);
            this.textCargoBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCargoBuscar_KeyPress);
            // 
            // labelCargoBuscar
            // 
            this.labelCargoBuscar.AutoSize = true;
            this.labelCargoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelCargoBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCargoBuscar.Location = new System.Drawing.Point(220, 49);
            this.labelCargoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargoBuscar.Name = "labelCargoBuscar";
            this.labelCargoBuscar.Size = new System.Drawing.Size(74, 24);
            this.labelCargoBuscar.TabIndex = 21;
            this.labelCargoBuscar.Text = "Buscar";
            // 
            // dataGridViewCargo
            // 
            this.dataGridViewCargo.AllowDrop = true;
            this.dataGridViewCargo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.dataGridViewCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargo.Location = new System.Drawing.Point(16, 105);
            this.dataGridViewCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCargo.Name = "dataGridViewCargo";
            this.dataGridViewCargo.Size = new System.Drawing.Size(584, 178);
            this.dataGridViewCargo.TabIndex = 1;
            this.dataGridViewCargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCargo_CellContentClick);
            // 
            // labelCargoLista
            // 
            this.labelCargoLista.AutoSize = true;
            this.labelCargoLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCargoLista.Location = new System.Drawing.Point(13, 11);
            this.labelCargoLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargoLista.Name = "labelCargoLista";
            this.labelCargoLista.Size = new System.Drawing.Size(139, 25);
            this.labelCargoLista.TabIndex = 0;
            this.labelCargoLista.Text = "Lista de Cargo";
            // 
            // panelCargoVertical2
            // 
            this.panelCargoVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelCargoVertical2.Controls.Add(this.comboCargoDepartamento);
            this.panelCargoVertical2.Controls.Add(this.labelCargoDepartamento);
            this.panelCargoVertical2.Controls.Add(this.buttonCargoCancelar);
            this.panelCargoVertical2.Controls.Add(this.buttonCargoGuardar);
            this.panelCargoVertical2.Controls.Add(this.textCargoClave);
            this.panelCargoVertical2.Controls.Add(this.labelCargoClave);
            this.panelCargoVertical2.Controls.Add(this.textCargoDescripcion);
            this.panelCargoVertical2.Controls.Add(this.labelCargoDescripcion);
            this.panelCargoVertical2.Controls.Add(this.textCargoNombre);
            this.panelCargoVertical2.Controls.Add(this.labelCargoNombre);
            this.panelCargoVertical2.Controls.Add(this.labelCargoRegistro);
            this.panelCargoVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCargoVertical2.Location = new System.Drawing.Point(608, 0);
            this.panelCargoVertical2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCargoVertical2.Name = "panelCargoVertical2";
            this.panelCargoVertical2.Size = new System.Drawing.Size(437, 336);
            this.panelCargoVertical2.TabIndex = 4;
            this.panelCargoVertical2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCargoVertical2_Paint);
            // 
            // comboCargoDepartamento
            // 
            this.comboCargoDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCargoDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCargoDepartamento.Items.AddRange(new object[] {
            "Administracion"});
            this.comboCargoDepartamento.Location = new System.Drawing.Point(160, 239);
            this.comboCargoDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCargoDepartamento.Name = "comboCargoDepartamento";
            this.comboCargoDepartamento.Size = new System.Drawing.Size(257, 24);
            this.comboCargoDepartamento.TabIndex = 22;
            // 
            // labelCargoDepartamento
            // 
            this.labelCargoDepartamento.AutoSize = true;
            this.labelCargoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoDepartamento.ForeColor = System.Drawing.Color.White;
            this.labelCargoDepartamento.Location = new System.Drawing.Point(11, 239);
            this.labelCargoDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargoDepartamento.Name = "labelCargoDepartamento";
            this.labelCargoDepartamento.Size = new System.Drawing.Size(128, 24);
            this.labelCargoDepartamento.TabIndex = 21;
            this.labelCargoDepartamento.Text = "Departamento";
            // 
            // buttonCargoCancelar
            // 
            this.buttonCargoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCargoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargoCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCargoCancelar.Location = new System.Drawing.Point(260, 292);
            this.buttonCargoCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCargoCancelar.Name = "buttonCargoCancelar";
            this.buttonCargoCancelar.Size = new System.Drawing.Size(104, 30);
            this.buttonCargoCancelar.TabIndex = 20;
            this.buttonCargoCancelar.Text = "Cancelar";
            this.buttonCargoCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonCargoGuardar
            // 
            this.buttonCargoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCargoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargoGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargoGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonCargoGuardar.Location = new System.Drawing.Point(93, 292);
            this.buttonCargoGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCargoGuardar.Name = "buttonCargoGuardar";
            this.buttonCargoGuardar.Size = new System.Drawing.Size(100, 30);
            this.buttonCargoGuardar.TabIndex = 19;
            this.buttonCargoGuardar.Text = "Guardar";
            this.buttonCargoGuardar.UseVisualStyleBackColor = false;
            this.buttonCargoGuardar.Click += new System.EventHandler(this.buttonCargoGuardar_Click);
            // 
            // textCargoClave
            // 
            this.textCargoClave.Location = new System.Drawing.Point(108, 68);
            this.textCargoClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCargoClave.Name = "textCargoClave";
            this.textCargoClave.Size = new System.Drawing.Size(309, 22);
            this.textCargoClave.TabIndex = 8;
            // 
            // labelCargoClave
            // 
            this.labelCargoClave.AutoSize = true;
            this.labelCargoClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoClave.ForeColor = System.Drawing.Color.White;
            this.labelCargoClave.Location = new System.Drawing.Point(12, 69);
            this.labelCargoClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargoClave.Name = "labelCargoClave";
            this.labelCargoClave.Size = new System.Drawing.Size(57, 24);
            this.labelCargoClave.TabIndex = 7;
            this.labelCargoClave.Text = "Clave";
            // 
            // textCargoDescripcion
            // 
            this.textCargoDescripcion.Location = new System.Drawing.Point(160, 144);
            this.textCargoDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCargoDescripcion.Multiline = true;
            this.textCargoDescripcion.Name = "textCargoDescripcion";
            this.textCargoDescripcion.Size = new System.Drawing.Size(257, 78);
            this.textCargoDescripcion.TabIndex = 4;
            // 
            // labelCargoDescripcion
            // 
            this.labelCargoDescripcion.AutoSize = true;
            this.labelCargoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelCargoDescripcion.Location = new System.Drawing.Point(12, 143);
            this.labelCargoDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargoDescripcion.Name = "labelCargoDescripcion";
            this.labelCargoDescripcion.Size = new System.Drawing.Size(110, 24);
            this.labelCargoDescripcion.TabIndex = 3;
            this.labelCargoDescripcion.Text = "Descripción";
            // 
            // textCargoNombre
            // 
            this.textCargoNombre.Location = new System.Drawing.Point(108, 105);
            this.textCargoNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCargoNombre.Name = "textCargoNombre";
            this.textCargoNombre.Size = new System.Drawing.Size(309, 22);
            this.textCargoNombre.TabIndex = 2;
            this.textCargoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCargoNombre_KeyPress);
            // 
            // labelCargoNombre
            // 
            this.labelCargoNombre.AutoSize = true;
            this.labelCargoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoNombre.ForeColor = System.Drawing.Color.White;
            this.labelCargoNombre.Location = new System.Drawing.Point(11, 105);
            this.labelCargoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargoNombre.Name = "labelCargoNombre";
            this.labelCargoNombre.Size = new System.Drawing.Size(79, 24);
            this.labelCargoNombre.TabIndex = 1;
            this.labelCargoNombre.Text = "Nombre";
            // 
            // labelCargoRegistro
            // 
            this.labelCargoRegistro.AutoSize = true;
            this.labelCargoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCargoRegistro.Location = new System.Drawing.Point(9, 23);
            this.labelCargoRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargoRegistro.Name = "labelCargoRegistro";
            this.labelCargoRegistro.Size = new System.Drawing.Size(148, 25);
            this.labelCargoRegistro.TabIndex = 0;
            this.labelCargoRegistro.Text = "Registrar Cargo";
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 336);
            this.Controls.Add(this.panelCargoVertical2);
            this.Controls.Add(this.panelCargoVertical);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cargo";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargo";
            this.Load += new System.EventHandler(this.Cargo_Load);
            this.panelCargoVertical.ResumeLayout(false);
            this.panelCargoVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).EndInit();
            this.panelCargoVertical2.ResumeLayout(false);
            this.panelCargoVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCargoVertical;
        private System.Windows.Forms.TextBox textCargoBuscar;
        private System.Windows.Forms.Label labelCargoBuscar;
        private System.Windows.Forms.DataGridView dataGridViewCargo;
        private System.Windows.Forms.Label labelCargoLista;
        private System.Windows.Forms.Panel panelCargoVertical2;
        private System.Windows.Forms.Button buttonCargoCancelar;
        private System.Windows.Forms.Button buttonCargoGuardar;
        private System.Windows.Forms.TextBox textCargoClave;
        private System.Windows.Forms.Label labelCargoClave;
        private System.Windows.Forms.TextBox textCargoDescripcion;
        private System.Windows.Forms.Label labelCargoDescripcion;
        private System.Windows.Forms.TextBox textCargoNombre;
        private System.Windows.Forms.Label labelCargoNombre;
        private System.Windows.Forms.Label labelCargoRegistro;
        private System.Windows.Forms.Label labelCargoDepartamento;
        private System.Windows.Forms.ComboBox comboCargoDepartamento;
        private System.Windows.Forms.Label label1;
        //private Inicio.SiceeDataSet1TableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
    }
}