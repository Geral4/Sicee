namespace Inicio
{
    partial class Inmueble
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
            this.panelInmuebleVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textInmuebleBuscar = new System.Windows.Forms.TextBox();
            this.labelInmuebleBuscar = new System.Windows.Forms.Label();
            this.dataGridInmueble = new System.Windows.Forms.DataGridView();
            this.labeInmuebleLista = new System.Windows.Forms.Label();
            this.panelInmuebleVertical2 = new System.Windows.Forms.Panel();
            this.textInmuebleAula = new System.Windows.Forms.TextBox();
            this.comboInmuebleAula = new System.Windows.Forms.ComboBox();
            this.labelInmuebleAula = new System.Windows.Forms.Label();
            this.comboInmuebleColor = new System.Windows.Forms.ComboBox();
            this.labelInmuebleColor = new System.Windows.Forms.Label();
            this.buttonInmuebleCancelar = new System.Windows.Forms.Button();
            this.buttonInmuebleGuardar = new System.Windows.Forms.Button();
            this.labelInmuebleDescripcion = new System.Windows.Forms.Label();
            this.textInmuebleNSerie = new System.Windows.Forms.TextBox();
            this.labelInmuebleNSerie = new System.Windows.Forms.Label();
            this.textInmuebleModelo = new System.Windows.Forms.TextBox();
            this.labelInmuebleModelo = new System.Windows.Forms.Label();
            this.textInmuebleMarca = new System.Windows.Forms.TextBox();
            this.labelProductoMarca = new System.Windows.Forms.Label();
            this.textInmuebleNombre = new System.Windows.Forms.TextBox();
            this.labelInmuebleNombre = new System.Windows.Forms.Label();
            this.labeInmuebleRegistro = new System.Windows.Forms.Label();
            this.textInmuebleDescripcion = new System.Windows.Forms.TextBox();
            this.panelInmuebleVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInmueble)).BeginInit();
            this.panelInmuebleVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInmuebleVertical
            // 
            this.panelInmuebleVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelInmuebleVertical.Controls.Add(this.label1);
            this.panelInmuebleVertical.Controls.Add(this.textInmuebleBuscar);
            this.panelInmuebleVertical.Controls.Add(this.labelInmuebleBuscar);
            this.panelInmuebleVertical.Controls.Add(this.dataGridInmueble);
            this.panelInmuebleVertical.Controls.Add(this.labeInmuebleLista);
            this.panelInmuebleVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInmuebleVertical.Location = new System.Drawing.Point(0, 0);
            this.panelInmuebleVertical.Name = "panelInmuebleVertical";
            this.panelInmuebleVertical.Size = new System.Drawing.Size(575, 378);
            this.panelInmuebleVertical.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(3, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "*Solo para consultas";
            // 
            // textInmuebleBuscar
            // 
            this.textInmuebleBuscar.Location = new System.Drawing.Point(274, 41);
            this.textInmuebleBuscar.Name = "textInmuebleBuscar";
            this.textInmuebleBuscar.Size = new System.Drawing.Size(137, 20);
            this.textInmuebleBuscar.TabIndex = 23;
            this.textInmuebleBuscar.TextChanged += new System.EventHandler(this.textInmuebleBuscar_TextChanged);
            // 
            // labelInmuebleBuscar
            // 
            this.labelInmuebleBuscar.AutoSize = true;
            this.labelInmuebleBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInmuebleBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelInmuebleBuscar.Location = new System.Drawing.Point(218, 40);
            this.labelInmuebleBuscar.Name = "labelInmuebleBuscar";
            this.labelInmuebleBuscar.Size = new System.Drawing.Size(61, 18);
            this.labelInmuebleBuscar.TabIndex = 21;
            this.labelInmuebleBuscar.Text = "Buscar";
            // 
            // dataGridInmueble
            // 
            this.dataGridInmueble.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.dataGridInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInmueble.Location = new System.Drawing.Point(6, 69);
            this.dataGridInmueble.Name = "dataGridInmueble";
            this.dataGridInmueble.Size = new System.Drawing.Size(558, 279);
            this.dataGridInmueble.TabIndex = 1;
            // 
            // labeInmuebleLista
            // 
            this.labeInmuebleLista.AutoSize = true;
            this.labeInmuebleLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeInmuebleLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labeInmuebleLista.Location = new System.Drawing.Point(4, 19);
            this.labeInmuebleLista.Name = "labeInmuebleLista";
            this.labeInmuebleLista.Size = new System.Drawing.Size(133, 20);
            this.labeInmuebleLista.TabIndex = 0;
            this.labeInmuebleLista.Text = "Lista de inmueble";
            // 
            // panelInmuebleVertical2
            // 
            this.panelInmuebleVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelInmuebleVertical2.Controls.Add(this.textInmuebleDescripcion);
            this.panelInmuebleVertical2.Controls.Add(this.textInmuebleAula);
            this.panelInmuebleVertical2.Controls.Add(this.comboInmuebleAula);
            this.panelInmuebleVertical2.Controls.Add(this.labelInmuebleAula);
            this.panelInmuebleVertical2.Controls.Add(this.comboInmuebleColor);
            this.panelInmuebleVertical2.Controls.Add(this.labelInmuebleColor);
            this.panelInmuebleVertical2.Controls.Add(this.buttonInmuebleCancelar);
            this.panelInmuebleVertical2.Controls.Add(this.buttonInmuebleGuardar);
            this.panelInmuebleVertical2.Controls.Add(this.labelInmuebleDescripcion);
            this.panelInmuebleVertical2.Controls.Add(this.textInmuebleNSerie);
            this.panelInmuebleVertical2.Controls.Add(this.labelInmuebleNSerie);
            this.panelInmuebleVertical2.Controls.Add(this.textInmuebleModelo);
            this.panelInmuebleVertical2.Controls.Add(this.labelInmuebleModelo);
            this.panelInmuebleVertical2.Controls.Add(this.textInmuebleMarca);
            this.panelInmuebleVertical2.Controls.Add(this.labelProductoMarca);
            this.panelInmuebleVertical2.Controls.Add(this.textInmuebleNombre);
            this.panelInmuebleVertical2.Controls.Add(this.labelInmuebleNombre);
            this.panelInmuebleVertical2.Controls.Add(this.labeInmuebleRegistro);
            this.panelInmuebleVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInmuebleVertical2.Location = new System.Drawing.Point(570, 0);
            this.panelInmuebleVertical2.Name = "panelInmuebleVertical2";
            this.panelInmuebleVertical2.Size = new System.Drawing.Size(329, 378);
            this.panelInmuebleVertical2.TabIndex = 5;
            // 
            // textInmuebleAula
            // 
            this.textInmuebleAula.Location = new System.Drawing.Point(84, 230);
            this.textInmuebleAula.Name = "textInmuebleAula";
            this.textInmuebleAula.Size = new System.Drawing.Size(230, 20);
            this.textInmuebleAula.TabIndex = 26;
            this.textInmuebleAula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textInmuebleAula.TextChanged += new System.EventHandler(this.textInmuebleAula_TextChanged);
            // 
            // comboInmuebleAula
            // 
            this.comboInmuebleAula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboInmuebleAula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboInmuebleAula.Location = new System.Drawing.Point(84, 200);
            this.comboInmuebleAula.Name = "comboInmuebleAula";
            this.comboInmuebleAula.Size = new System.Drawing.Size(230, 21);
            this.comboInmuebleAula.TabIndex = 25;
            this.comboInmuebleAula.SelectedIndexChanged += new System.EventHandler(this.comboInmuebleAula_SelectedIndexChanged_1);
            // 
            // labelInmuebleAula
            // 
            this.labelInmuebleAula.AutoSize = true;
            this.labelInmuebleAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInmuebleAula.ForeColor = System.Drawing.Color.White;
            this.labelInmuebleAula.Location = new System.Drawing.Point(9, 198);
            this.labelInmuebleAula.Name = "labelInmuebleAula";
            this.labelInmuebleAula.Size = new System.Drawing.Size(36, 18);
            this.labelInmuebleAula.TabIndex = 24;
            this.labelInmuebleAula.Text = "Aula";
            // 
            // comboInmuebleColor
            // 
            this.comboInmuebleColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboInmuebleColor.FormattingEnabled = true;
            this.comboInmuebleColor.Location = new System.Drawing.Point(81, 143);
            this.comboInmuebleColor.Name = "comboInmuebleColor";
            this.comboInmuebleColor.Size = new System.Drawing.Size(233, 21);
            this.comboInmuebleColor.TabIndex = 23;
            this.comboInmuebleColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboInmuebleColor_DrawItem);
            this.comboInmuebleColor.Enter += new System.EventHandler(this.comboInmuebleColor_Enter);
            // 
            // labelInmuebleColor
            // 
            this.labelInmuebleColor.AutoSize = true;
            this.labelInmuebleColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInmuebleColor.ForeColor = System.Drawing.Color.White;
            this.labelInmuebleColor.Location = new System.Drawing.Point(9, 143);
            this.labelInmuebleColor.Name = "labelInmuebleColor";
            this.labelInmuebleColor.Size = new System.Drawing.Size(45, 18);
            this.labelInmuebleColor.TabIndex = 22;
            this.labelInmuebleColor.Text = "Color";
            // 
            // buttonInmuebleCancelar
            // 
            this.buttonInmuebleCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonInmuebleCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInmuebleCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInmuebleCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonInmuebleCancelar.Location = new System.Drawing.Point(220, 343);
            this.buttonInmuebleCancelar.Name = "buttonInmuebleCancelar";
            this.buttonInmuebleCancelar.Size = new System.Drawing.Size(78, 24);
            this.buttonInmuebleCancelar.TabIndex = 21;
            this.buttonInmuebleCancelar.Text = "Cancelar";
            this.buttonInmuebleCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonInmuebleGuardar
            // 
            this.buttonInmuebleGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonInmuebleGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInmuebleGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInmuebleGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonInmuebleGuardar.Location = new System.Drawing.Point(56, 342);
            this.buttonInmuebleGuardar.Name = "buttonInmuebleGuardar";
            this.buttonInmuebleGuardar.Size = new System.Drawing.Size(75, 24);
            this.buttonInmuebleGuardar.TabIndex = 20;
            this.buttonInmuebleGuardar.Text = "Guardar";
            this.buttonInmuebleGuardar.UseVisualStyleBackColor = false;
            this.buttonInmuebleGuardar.Click += new System.EventHandler(this.buttonInmuebleGuardar_Click);
            // 
            // labelInmuebleDescripcion
            // 
            this.labelInmuebleDescripcion.AutoSize = true;
            this.labelInmuebleDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInmuebleDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelInmuebleDescripcion.Location = new System.Drawing.Point(8, 259);
            this.labelInmuebleDescripcion.Name = "labelInmuebleDescripcion";
            this.labelInmuebleDescripcion.Size = new System.Drawing.Size(87, 18);
            this.labelInmuebleDescripcion.TabIndex = 9;
            this.labelInmuebleDescripcion.Text = "Descripción";
            // 
            // textInmuebleNSerie
            // 
            this.textInmuebleNSerie.Location = new System.Drawing.Point(81, 172);
            this.textInmuebleNSerie.Name = "textInmuebleNSerie";
            this.textInmuebleNSerie.Size = new System.Drawing.Size(233, 20);
            this.textInmuebleNSerie.TabIndex = 8;
            // 
            // labelInmuebleNSerie
            // 
            this.labelInmuebleNSerie.AutoSize = true;
            this.labelInmuebleNSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInmuebleNSerie.ForeColor = System.Drawing.Color.White;
            this.labelInmuebleNSerie.Location = new System.Drawing.Point(9, 171);
            this.labelInmuebleNSerie.Name = "labelInmuebleNSerie";
            this.labelInmuebleNSerie.Size = new System.Drawing.Size(62, 18);
            this.labelInmuebleNSerie.TabIndex = 7;
            this.labelInmuebleNSerie.Text = "Nº Serie";
            // 
            // textInmuebleModelo
            // 
            this.textInmuebleModelo.Location = new System.Drawing.Point(81, 116);
            this.textInmuebleModelo.Name = "textInmuebleModelo";
            this.textInmuebleModelo.Size = new System.Drawing.Size(233, 20);
            this.textInmuebleModelo.TabIndex = 6;
            // 
            // labelInmuebleModelo
            // 
            this.labelInmuebleModelo.AutoSize = true;
            this.labelInmuebleModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInmuebleModelo.ForeColor = System.Drawing.Color.White;
            this.labelInmuebleModelo.Location = new System.Drawing.Point(8, 115);
            this.labelInmuebleModelo.Name = "labelInmuebleModelo";
            this.labelInmuebleModelo.Size = new System.Drawing.Size(58, 18);
            this.labelInmuebleModelo.TabIndex = 5;
            this.labelInmuebleModelo.Text = "Modelo";
            // 
            // textInmuebleMarca
            // 
            this.textInmuebleMarca.Location = new System.Drawing.Point(81, 87);
            this.textInmuebleMarca.Name = "textInmuebleMarca";
            this.textInmuebleMarca.Size = new System.Drawing.Size(233, 20);
            this.textInmuebleMarca.TabIndex = 4;
            this.textInmuebleMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textInmuebleMarca_KeyPress);
            // 
            // labelProductoMarca
            // 
            this.labelProductoMarca.AutoSize = true;
            this.labelProductoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductoMarca.ForeColor = System.Drawing.Color.White;
            this.labelProductoMarca.Location = new System.Drawing.Point(8, 86);
            this.labelProductoMarca.Name = "labelProductoMarca";
            this.labelProductoMarca.Size = new System.Drawing.Size(50, 18);
            this.labelProductoMarca.TabIndex = 3;
            this.labelProductoMarca.Text = "Marca";
            // 
            // textInmuebleNombre
            // 
            this.textInmuebleNombre.Location = new System.Drawing.Point(81, 59);
            this.textInmuebleNombre.Name = "textInmuebleNombre";
            this.textInmuebleNombre.Size = new System.Drawing.Size(233, 20);
            this.textInmuebleNombre.TabIndex = 2;
            this.textInmuebleNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textInmuebleNombre_KeyPress);
            // 
            // labelInmuebleNombre
            // 
            this.labelInmuebleNombre.AutoSize = true;
            this.labelInmuebleNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInmuebleNombre.ForeColor = System.Drawing.Color.White;
            this.labelInmuebleNombre.Location = new System.Drawing.Point(8, 59);
            this.labelInmuebleNombre.Name = "labelInmuebleNombre";
            this.labelInmuebleNombre.Size = new System.Drawing.Size(62, 18);
            this.labelInmuebleNombre.TabIndex = 1;
            this.labelInmuebleNombre.Text = "Nombre";
            // 
            // labeInmuebleRegistro
            // 
            this.labeInmuebleRegistro.AutoSize = true;
            this.labeInmuebleRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeInmuebleRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labeInmuebleRegistro.Location = new System.Drawing.Point(3, 19);
            this.labeInmuebleRegistro.Name = "labeInmuebleRegistro";
            this.labeInmuebleRegistro.Size = new System.Drawing.Size(105, 20);
            this.labeInmuebleRegistro.TabIndex = 0;
            this.labeInmuebleRegistro.Text = "Alta inmueble";
            // 
            // textInmuebleDescripcion
            // 
            this.textInmuebleDescripcion.Location = new System.Drawing.Point(101, 259);
            this.textInmuebleDescripcion.Multiline = true;
            this.textInmuebleDescripcion.Name = "textInmuebleDescripcion";
            this.textInmuebleDescripcion.Size = new System.Drawing.Size(213, 52);
            this.textInmuebleDescripcion.TabIndex = 27;
            // 
            // Inmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 378);
            this.Controls.Add(this.panelInmuebleVertical2);
            this.Controls.Add(this.panelInmuebleVertical);
            this.Name = "Inmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmueble";
            this.Load += new System.EventHandler(this.Inmueble_Load);
            this.panelInmuebleVertical.ResumeLayout(false);
            this.panelInmuebleVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInmueble)).EndInit();
            this.panelInmuebleVertical2.ResumeLayout(false);
            this.panelInmuebleVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInmuebleVertical;
        private System.Windows.Forms.TextBox textInmuebleBuscar;
        private System.Windows.Forms.Label labelInmuebleBuscar;
        private System.Windows.Forms.DataGridView dataGridInmueble;
        private System.Windows.Forms.Label labeInmuebleLista;
        private System.Windows.Forms.Panel panelInmuebleVertical2;
        private System.Windows.Forms.Label labelInmuebleAula;
        private System.Windows.Forms.ComboBox comboInmuebleColor;
        private System.Windows.Forms.Label labelInmuebleColor;
        private System.Windows.Forms.Button buttonInmuebleCancelar;
        private System.Windows.Forms.Button buttonInmuebleGuardar;
        private System.Windows.Forms.Label labelInmuebleDescripcion;
        private System.Windows.Forms.TextBox textInmuebleNSerie;
        private System.Windows.Forms.Label labelInmuebleNSerie;
        private System.Windows.Forms.TextBox textInmuebleModelo;
        private System.Windows.Forms.Label labelInmuebleModelo;
        private System.Windows.Forms.TextBox textInmuebleMarca;
        private System.Windows.Forms.Label labelProductoMarca;
        private System.Windows.Forms.TextBox textInmuebleNombre;
        private System.Windows.Forms.Label labelInmuebleNombre;
        private System.Windows.Forms.Label labeInmuebleRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboInmuebleAula;
        private System.Windows.Forms.TextBox textInmuebleAula;
        private System.Windows.Forms.TextBox textInmuebleDescripcion;
    }
}