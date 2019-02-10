namespace Inicio
{
    partial class DevolucionPrestamo
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
            this.panelDevolucionPHorizontal2 = new System.Windows.Forms.Panel();
            this.panelDevolucionPHorizontal3 = new System.Windows.Forms.Panel();
            this.buttonDevolucionPBuscar = new System.Windows.Forms.Button();
            this.textDevolucionPBuscar = new System.Windows.Forms.TextBox();
            this.labelDevolucionPBuscar = new System.Windows.Forms.Label();
            this.dataGridDevolucionP = new System.Windows.Forms.DataGridView();
            this.labelDevolucionPLista = new System.Windows.Forms.Label();
            this.buttonDevolucionPGuardar = new System.Windows.Forms.Button();
            this.panelDevolucionPHorizontal4 = new System.Windows.Forms.Panel();
            this.labelDevolucionPTitulo = new System.Windows.Forms.Label();
            this.panelDevolucionPHorizontal = new System.Windows.Forms.Panel();
            this.buttonDevolucionPEditar = new System.Windows.Forms.Button();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDevolucionPHorizontal3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucionP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDevolucionPHorizontal2
            // 
            this.panelDevolucionPHorizontal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelDevolucionPHorizontal2.Location = new System.Drawing.Point(785, 24);
            this.panelDevolucionPHorizontal2.Name = "panelDevolucionPHorizontal2";
            this.panelDevolucionPHorizontal2.Size = new System.Drawing.Size(297, 19);
            this.panelDevolucionPHorizontal2.TabIndex = 31;
            // 
            // panelDevolucionPHorizontal3
            // 
            this.panelDevolucionPHorizontal3.BackColor = System.Drawing.Color.White;
            this.panelDevolucionPHorizontal3.Controls.Add(this.buttonDevolucionPBuscar);
            this.panelDevolucionPHorizontal3.Controls.Add(this.textDevolucionPBuscar);
            this.panelDevolucionPHorizontal3.Controls.Add(this.labelDevolucionPBuscar);
            this.panelDevolucionPHorizontal3.Controls.Add(this.dataGridDevolucionP);
            this.panelDevolucionPHorizontal3.Controls.Add(this.labelDevolucionPLista);
            this.panelDevolucionPHorizontal3.Location = new System.Drawing.Point(12, 100);
            this.panelDevolucionPHorizontal3.Name = "panelDevolucionPHorizontal3";
            this.panelDevolucionPHorizontal3.Size = new System.Drawing.Size(1056, 423);
            this.panelDevolucionPHorizontal3.TabIndex = 33;
            // 
            // buttonDevolucionPBuscar
            // 
            this.buttonDevolucionPBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonDevolucionPBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevolucionPBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolucionPBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonDevolucionPBuscar.Location = new System.Drawing.Point(620, 15);
            this.buttonDevolucionPBuscar.Name = "buttonDevolucionPBuscar";
            this.buttonDevolucionPBuscar.Size = new System.Drawing.Size(94, 28);
            this.buttonDevolucionPBuscar.TabIndex = 24;
            this.buttonDevolucionPBuscar.Text = "Buscar";
            this.buttonDevolucionPBuscar.UseVisualStyleBackColor = false;
            // 
            // textDevolucionPBuscar
            // 
            this.textDevolucionPBuscar.Location = new System.Drawing.Point(441, 22);
            this.textDevolucionPBuscar.Name = "textDevolucionPBuscar";
            this.textDevolucionPBuscar.Size = new System.Drawing.Size(173, 20);
            this.textDevolucionPBuscar.TabIndex = 23;
            // 
            // labelDevolucionPBuscar
            // 
            this.labelDevolucionPBuscar.AutoSize = true;
            this.labelDevolucionPBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevolucionPBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelDevolucionPBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelDevolucionPBuscar.Location = new System.Drawing.Point(387, 22);
            this.labelDevolucionPBuscar.Name = "labelDevolucionPBuscar";
            this.labelDevolucionPBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelDevolucionPBuscar.TabIndex = 21;
            this.labelDevolucionPBuscar.Text = "Buscar";
            // 
            // dataGridDevolucionP
            // 
            this.dataGridDevolucionP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridDevolucionP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevolucionP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.identi,
            this.Nombre,
            this.fechaP,
            this.fechaE});
            this.dataGridDevolucionP.Location = new System.Drawing.Point(8, 69);
            this.dataGridDevolucionP.Name = "dataGridDevolucionP";
            this.dataGridDevolucionP.Size = new System.Drawing.Size(1036, 307);
            this.dataGridDevolucionP.TabIndex = 1;
            this.dataGridDevolucionP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDevolucionP_CellContentClick);
            this.dataGridDevolucionP.DoubleClick += new System.EventHandler(this.dataGridDevolucionP_DoubleClick);
            // 
            // labelDevolucionPLista
            // 
            this.labelDevolucionPLista.AutoSize = true;
            this.labelDevolucionPLista.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevolucionPLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelDevolucionPLista.Location = new System.Drawing.Point(4, 20);
            this.labelDevolucionPLista.Name = "labelDevolucionPLista";
            this.labelDevolucionPLista.Size = new System.Drawing.Size(160, 19);
            this.labelDevolucionPLista.TabIndex = 0;
            this.labelDevolucionPLista.Text = "Lista de prestamos";
            // 
            // buttonDevolucionPGuardar
            // 
            this.buttonDevolucionPGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonDevolucionPGuardar.FlatAppearance.BorderSize = 0;
            this.buttonDevolucionPGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevolucionPGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolucionPGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonDevolucionPGuardar.Location = new System.Drawing.Point(596, 529);
            this.buttonDevolucionPGuardar.Name = "buttonDevolucionPGuardar";
            this.buttonDevolucionPGuardar.Size = new System.Drawing.Size(96, 26);
            this.buttonDevolucionPGuardar.TabIndex = 21;
            this.buttonDevolucionPGuardar.Text = "Guardar";
            this.buttonDevolucionPGuardar.UseVisualStyleBackColor = false;
            // 
            // panelDevolucionPHorizontal4
            // 
            this.panelDevolucionPHorizontal4.BackColor = System.Drawing.Color.White;
            this.panelDevolucionPHorizontal4.Location = new System.Drawing.Point(0, 570);
            this.panelDevolucionPHorizontal4.Name = "panelDevolucionPHorizontal4";
            this.panelDevolucionPHorizontal4.Size = new System.Drawing.Size(1081, 30);
            this.panelDevolucionPHorizontal4.TabIndex = 25;
            // 
            // labelDevolucionPTitulo
            // 
            this.labelDevolucionPTitulo.AutoSize = true;
            this.labelDevolucionPTitulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevolucionPTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelDevolucionPTitulo.Location = new System.Drawing.Point(311, 9);
            this.labelDevolucionPTitulo.Name = "labelDevolucionPTitulo";
            this.labelDevolucionPTitulo.Size = new System.Drawing.Size(460, 44);
            this.labelDevolucionPTitulo.TabIndex = 29;
            this.labelDevolucionPTitulo.Text = "Devolucion de Prestamo";
            // 
            // panelDevolucionPHorizontal
            // 
            this.panelDevolucionPHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelDevolucionPHorizontal.Location = new System.Drawing.Point(0, 24);
            this.panelDevolucionPHorizontal.Name = "panelDevolucionPHorizontal";
            this.panelDevolucionPHorizontal.Size = new System.Drawing.Size(297, 19);
            this.panelDevolucionPHorizontal.TabIndex = 32;
            // 
            // buttonDevolucionPEditar
            // 
            this.buttonDevolucionPEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonDevolucionPEditar.FlatAppearance.BorderSize = 0;
            this.buttonDevolucionPEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevolucionPEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolucionPEditar.ForeColor = System.Drawing.Color.White;
            this.buttonDevolucionPEditar.Location = new System.Drawing.Point(365, 529);
            this.buttonDevolucionPEditar.Name = "buttonDevolucionPEditar";
            this.buttonDevolucionPEditar.Size = new System.Drawing.Size(96, 26);
            this.buttonDevolucionPEditar.TabIndex = 50;
            this.buttonDevolucionPEditar.Text = "Editar";
            this.buttonDevolucionPEditar.UseVisualStyleBackColor = false;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "Folio";
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Width = 80;
            // 
            // identi
            // 
            this.identi.DataPropertyName = "identi";
            this.identi.HeaderText = "Nº Control / Nº Personal";
            this.identi.Name = "identi";
            this.identi.ReadOnly = true;
            this.identi.Width = 180;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre_Completo";
            this.Nombre.HeaderText = "Nombre Completo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // fechaP
            // 
            this.fechaP.DataPropertyName = "FechaP";
            this.fechaP.HeaderText = "Fecha de prestamo";
            this.fechaP.Name = "fechaP";
            this.fechaP.ReadOnly = true;
            this.fechaP.Width = 150;
            // 
            // fechaE
            // 
            this.fechaE.DataPropertyName = "FechaE";
            this.fechaE.HeaderText = "Fecha de entrega";
            this.fechaE.Name = "fechaE";
            this.fechaE.ReadOnly = true;
            this.fechaE.Width = 150;
            // 
            // DevolucionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.buttonDevolucionPEditar);
            this.Controls.Add(this.panelDevolucionPHorizontal);
            this.Controls.Add(this.panelDevolucionPHorizontal4);
            this.Controls.Add(this.panelDevolucionPHorizontal3);
            this.Controls.Add(this.buttonDevolucionPGuardar);
            this.Controls.Add(this.labelDevolucionPTitulo);
            this.Controls.Add(this.panelDevolucionPHorizontal2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DevolucionPrestamo";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevolucionPrestamo";
            this.Load += new System.EventHandler(this.DevolucionPrestamo_Load);
            this.panelDevolucionPHorizontal3.ResumeLayout(false);
            this.panelDevolucionPHorizontal3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucionP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDevolucionPHorizontal2;
        private System.Windows.Forms.Panel panelDevolucionPHorizontal3;
        private System.Windows.Forms.Button buttonDevolucionPBuscar;
        private System.Windows.Forms.TextBox textDevolucionPBuscar;
        private System.Windows.Forms.Label labelDevolucionPBuscar;
        private System.Windows.Forms.Button buttonDevolucionPGuardar;
        private System.Windows.Forms.DataGridView dataGridDevolucionP;
        private System.Windows.Forms.Label labelDevolucionPLista;
        private System.Windows.Forms.Panel panelDevolucionPHorizontal4;
        private System.Windows.Forms.Label labelDevolucionPTitulo;
        private System.Windows.Forms.Panel panelDevolucionPHorizontal;
        private System.Windows.Forms.Button buttonDevolucionPEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn identi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaE;
    }
}