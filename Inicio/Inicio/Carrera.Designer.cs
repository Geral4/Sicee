namespace Inicio
{
    partial class Carrera
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
            this.panelCarreraVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textCarreraBuscar = new System.Windows.Forms.TextBox();
            this.labelCarreraBuscar = new System.Windows.Forms.Label();
            this.dataGridViewCarrera = new System.Windows.Forms.DataGridView();
            this.labelCarreraLista = new System.Windows.Forms.Label();
            this.panelCarreraVertical2 = new System.Windows.Forms.Panel();
            this.buttonCarreraCancelar = new System.Windows.Forms.Button();
            this.buttonCarreraGuardar = new System.Windows.Forms.Button();
            this.labelCarreraDescripcion = new System.Windows.Forms.Label();
            this.textCarreraNombre = new System.Windows.Forms.TextBox();
            this.labelCarreraNombre = new System.Windows.Forms.Label();
            this.textCarreraDescripcion = new System.Windows.Forms.TextBox();
            this.textCarreraClave = new System.Windows.Forms.TextBox();
            this.labelCarreraClave = new System.Windows.Forms.Label();
            this.labelCarreraRegistro = new System.Windows.Forms.Label();
            this.panelCarreraVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrera)).BeginInit();
            this.panelCarreraVertical2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCarreraVertical
            // 
            this.panelCarreraVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCarreraVertical.Controls.Add(this.label1);
            this.panelCarreraVertical.Controls.Add(this.textCarreraBuscar);
            this.panelCarreraVertical.Controls.Add(this.labelCarreraBuscar);
            this.panelCarreraVertical.Controls.Add(this.dataGridViewCarrera);
            this.panelCarreraVertical.Controls.Add(this.labelCarreraLista);
            this.panelCarreraVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCarreraVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCarreraVertical.Name = "panelCarreraVertical";
            this.panelCarreraVertical.Size = new System.Drawing.Size(468, 252);
            this.panelCarreraVertical.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(6, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "*Solo para consultas";
            // 
            // textCarreraBuscar
            // 
            this.textCarreraBuscar.Location = new System.Drawing.Point(155, 43);
            this.textCarreraBuscar.Name = "textCarreraBuscar";
            this.textCarreraBuscar.Size = new System.Drawing.Size(163, 20);
            this.textCarreraBuscar.TabIndex = 23;
            this.textCarreraBuscar.TextChanged += new System.EventHandler(this.textCarreraBuscar_TextChanged);
            // 
            // labelCarreraBuscar
            // 
            this.labelCarreraBuscar.AutoSize = true;
            this.labelCarreraBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarreraBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelCarreraBuscar.Location = new System.Drawing.Point(95, 42);
            this.labelCarreraBuscar.Name = "labelCarreraBuscar";
            this.labelCarreraBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelCarreraBuscar.TabIndex = 21;
            this.labelCarreraBuscar.Text = "Buscar";
            // 
            // dataGridViewCarrera
            // 
            this.dataGridViewCarrera.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrera.Location = new System.Drawing.Point(9, 69);
            this.dataGridViewCarrera.Name = "dataGridViewCarrera";
            this.dataGridViewCarrera.Size = new System.Drawing.Size(347, 157);
            this.dataGridViewCarrera.TabIndex = 1;
            // 
            // labelCarreraLista
            // 
            this.labelCarreraLista.AutoSize = true;
            this.labelCarreraLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarreraLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCarreraLista.Location = new System.Drawing.Point(4, 19);
            this.labelCarreraLista.Name = "labelCarreraLista";
            this.labelCarreraLista.Size = new System.Drawing.Size(136, 21);
            this.labelCarreraLista.TabIndex = 0;
            this.labelCarreraLista.Text = "Lista de carreras";
            // 
            // panelCarreraVertical2
            // 
            this.panelCarreraVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelCarreraVertical2.Controls.Add(this.buttonCarreraCancelar);
            this.panelCarreraVertical2.Controls.Add(this.buttonCarreraGuardar);
            this.panelCarreraVertical2.Controls.Add(this.labelCarreraDescripcion);
            this.panelCarreraVertical2.Controls.Add(this.textCarreraNombre);
            this.panelCarreraVertical2.Controls.Add(this.labelCarreraNombre);
            this.panelCarreraVertical2.Controls.Add(this.textCarreraDescripcion);
            this.panelCarreraVertical2.Controls.Add(this.textCarreraClave);
            this.panelCarreraVertical2.Controls.Add(this.labelCarreraClave);
            this.panelCarreraVertical2.Controls.Add(this.labelCarreraRegistro);
            this.panelCarreraVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCarreraVertical2.Location = new System.Drawing.Point(365, 0);
            this.panelCarreraVertical2.Name = "panelCarreraVertical2";
            this.panelCarreraVertical2.Size = new System.Drawing.Size(326, 252);
            this.panelCarreraVertical2.TabIndex = 3;
            // 
            // buttonCarreraCancelar
            // 
            this.buttonCarreraCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCarreraCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCarreraCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarreraCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCarreraCancelar.Location = new System.Drawing.Point(192, 200);
            this.buttonCarreraCancelar.Name = "buttonCarreraCancelar";
            this.buttonCarreraCancelar.Size = new System.Drawing.Size(78, 24);
            this.buttonCarreraCancelar.TabIndex = 20;
            this.buttonCarreraCancelar.Text = "Cancelar";
            this.buttonCarreraCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonCarreraGuardar
            // 
            this.buttonCarreraGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCarreraGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCarreraGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarreraGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonCarreraGuardar.Location = new System.Drawing.Point(68, 200);
            this.buttonCarreraGuardar.Name = "buttonCarreraGuardar";
            this.buttonCarreraGuardar.Size = new System.Drawing.Size(75, 24);
            this.buttonCarreraGuardar.TabIndex = 19;
            this.buttonCarreraGuardar.Text = "Guardar";
            this.buttonCarreraGuardar.UseVisualStyleBackColor = false;
            this.buttonCarreraGuardar.Click += new System.EventHandler(this.buttonCarreraGuardar_Click);
            // 
            // labelCarreraDescripcion
            // 
            this.labelCarreraDescripcion.AutoSize = true;
            this.labelCarreraDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarreraDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelCarreraDescripcion.Location = new System.Drawing.Point(9, 118);
            this.labelCarreraDescripcion.Name = "labelCarreraDescripcion";
            this.labelCarreraDescripcion.Size = new System.Drawing.Size(96, 20);
            this.labelCarreraDescripcion.TabIndex = 7;
            this.labelCarreraDescripcion.Text = "Descripción";
            // 
            // textCarreraNombre
            // 
            this.textCarreraNombre.Location = new System.Drawing.Point(81, 90);
            this.textCarreraNombre.Name = "textCarreraNombre";
            this.textCarreraNombre.Size = new System.Drawing.Size(233, 20);
            this.textCarreraNombre.TabIndex = 6;
            this.textCarreraNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCarreraNombre_KeyPress);
            // 
            // labelCarreraNombre
            // 
            this.labelCarreraNombre.AutoSize = true;
            this.labelCarreraNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarreraNombre.ForeColor = System.Drawing.Color.White;
            this.labelCarreraNombre.Location = new System.Drawing.Point(9, 88);
            this.labelCarreraNombre.Name = "labelCarreraNombre";
            this.labelCarreraNombre.Size = new System.Drawing.Size(68, 20);
            this.labelCarreraNombre.TabIndex = 5;
            this.labelCarreraNombre.Text = "Nombre";
            // 
            // textCarreraDescripcion
            // 
            this.textCarreraDescripcion.Location = new System.Drawing.Point(111, 119);
            this.textCarreraDescripcion.Multiline = true;
            this.textCarreraDescripcion.Name = "textCarreraDescripcion";
            this.textCarreraDescripcion.Size = new System.Drawing.Size(203, 64);
            this.textCarreraDescripcion.TabIndex = 4;
            // 
            // textCarreraClave
            // 
            this.textCarreraClave.Location = new System.Drawing.Point(81, 64);
            this.textCarreraClave.Name = "textCarreraClave";
            this.textCarreraClave.Size = new System.Drawing.Size(233, 20);
            this.textCarreraClave.TabIndex = 2;
            // 
            // labelCarreraClave
            // 
            this.labelCarreraClave.AutoSize = true;
            this.labelCarreraClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarreraClave.ForeColor = System.Drawing.Color.White;
            this.labelCarreraClave.Location = new System.Drawing.Point(8, 64);
            this.labelCarreraClave.Name = "labelCarreraClave";
            this.labelCarreraClave.Size = new System.Drawing.Size(54, 20);
            this.labelCarreraClave.TabIndex = 1;
            this.labelCarreraClave.Text = "Clave";
            // 
            // labelCarreraRegistro
            // 
            this.labelCarreraRegistro.AutoSize = true;
            this.labelCarreraRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarreraRegistro.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCarreraRegistro.Location = new System.Drawing.Point(3, 19);
            this.labelCarreraRegistro.Name = "labelCarreraRegistro";
            this.labelCarreraRegistro.Size = new System.Drawing.Size(139, 21);
            this.labelCarreraRegistro.TabIndex = 0;
            this.labelCarreraRegistro.Text = "Registrar carrera";
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 252);
            this.Controls.Add(this.panelCarreraVertical2);
            this.Controls.Add(this.panelCarreraVertical);
            this.Name = "Carrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrera";
            this.Load += new System.EventHandler(this.Carrera_Load);
            this.panelCarreraVertical.ResumeLayout(false);
            this.panelCarreraVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrera)).EndInit();
            this.panelCarreraVertical2.ResumeLayout(false);
            this.panelCarreraVertical2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCarreraVertical;
        private System.Windows.Forms.TextBox textCarreraBuscar;
        private System.Windows.Forms.Label labelCarreraBuscar;
        private System.Windows.Forms.DataGridView dataGridViewCarrera;
        private System.Windows.Forms.Label labelCarreraLista;
        private System.Windows.Forms.Panel panelCarreraVertical2;
        private System.Windows.Forms.Button buttonCarreraCancelar;
        private System.Windows.Forms.Button buttonCarreraGuardar;
        private System.Windows.Forms.Label labelCarreraDescripcion;
        private System.Windows.Forms.TextBox textCarreraNombre;
        private System.Windows.Forms.Label labelCarreraNombre;
        private System.Windows.Forms.TextBox textCarreraDescripcion;
        private System.Windows.Forms.TextBox textCarreraClave;
        private System.Windows.Forms.Label labelCarreraClave;
        private System.Windows.Forms.Label labelCarreraRegistro;
        private System.Windows.Forms.Label label1;
    }
}