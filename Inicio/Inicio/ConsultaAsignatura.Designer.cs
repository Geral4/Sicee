namespace Inicio
{
    partial class ConsultaAsignatura
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
            this.panelCAsignaturaVertical2 = new System.Windows.Forms.Panel();
            this.textCAsignaturaBuscar = new System.Windows.Forms.TextBox();
            this.labelCAsignaturaBuscar = new System.Windows.Forms.Label();
            this.buttonCAsignaturaEliminar = new System.Windows.Forms.Button();
            this.buttonCAsignaturaEditar = new System.Windows.Forms.Button();
            this.dataGridCAsignatura = new System.Windows.Forms.DataGridView();
            this.labelCAsignaturaLista = new System.Windows.Forms.Label();
            this.Carrera = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelCAsignaturaVertical2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCAsignatura)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCAsignaturaVertical2
            // 
            this.panelCAsignaturaVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCAsignaturaVertical2.Controls.Add(this.textCAsignaturaBuscar);
            this.panelCAsignaturaVertical2.Controls.Add(this.labelCAsignaturaBuscar);
            this.panelCAsignaturaVertical2.Controls.Add(this.buttonCAsignaturaEliminar);
            this.panelCAsignaturaVertical2.Controls.Add(this.buttonCAsignaturaEditar);
            this.panelCAsignaturaVertical2.Controls.Add(this.dataGridCAsignatura);
            this.panelCAsignaturaVertical2.Controls.Add(this.labelCAsignaturaLista);
            this.panelCAsignaturaVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCAsignaturaVertical2.Location = new System.Drawing.Point(-4, 0);
            this.panelCAsignaturaVertical2.Name = "panelCAsignaturaVertical2";
            this.panelCAsignaturaVertical2.Size = new System.Drawing.Size(598, 312);
            this.panelCAsignaturaVertical2.TabIndex = 56;
            // 
            // textCAsignaturaBuscar
            // 
            this.textCAsignaturaBuscar.Location = new System.Drawing.Point(312, 58);
            this.textCAsignaturaBuscar.Name = "textCAsignaturaBuscar";
            this.textCAsignaturaBuscar.Size = new System.Drawing.Size(177, 20);
            this.textCAsignaturaBuscar.TabIndex = 41;
            this.textCAsignaturaBuscar.TextChanged += new System.EventHandler(this.textCAsignaturaBuscar_TextChanged);
            // 
            // labelCAsignaturaBuscar
            // 
            this.labelCAsignaturaBuscar.AutoSize = true;
            this.labelCAsignaturaBuscar.BackColor = System.Drawing.Color.Transparent;
            this.labelCAsignaturaBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAsignaturaBuscar.ForeColor = System.Drawing.Color.White;
            this.labelCAsignaturaBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCAsignaturaBuscar.Location = new System.Drawing.Point(246, 59);
            this.labelCAsignaturaBuscar.Name = "labelCAsignaturaBuscar";
            this.labelCAsignaturaBuscar.Size = new System.Drawing.Size(60, 19);
            this.labelCAsignaturaBuscar.TabIndex = 40;
            this.labelCAsignaturaBuscar.Text = "Buscar";
            // 
            // buttonCAsignaturaEliminar
            // 
            this.buttonCAsignaturaEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCAsignaturaEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCAsignaturaEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCAsignaturaEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCAsignaturaEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCAsignaturaEliminar.Location = new System.Drawing.Point(301, 267);
            this.buttonCAsignaturaEliminar.Name = "buttonCAsignaturaEliminar";
            this.buttonCAsignaturaEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCAsignaturaEliminar.TabIndex = 22;
            this.buttonCAsignaturaEliminar.Text = "Eliminar";
            this.buttonCAsignaturaEliminar.UseVisualStyleBackColor = false;
            this.buttonCAsignaturaEliminar.Click += new System.EventHandler(this.buttonCAsignaturaEliminar_Click);
            // 
            // buttonCAsignaturaEditar
            // 
            this.buttonCAsignaturaEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCAsignaturaEditar.FlatAppearance.BorderSize = 0;
            this.buttonCAsignaturaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCAsignaturaEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCAsignaturaEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCAsignaturaEditar.Location = new System.Drawing.Point(198, 266);
            this.buttonCAsignaturaEditar.Name = "buttonCAsignaturaEditar";
            this.buttonCAsignaturaEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCAsignaturaEditar.TabIndex = 21;
            this.buttonCAsignaturaEditar.Text = "Editar";
            this.buttonCAsignaturaEditar.UseVisualStyleBackColor = false;
            this.buttonCAsignaturaEditar.Click += new System.EventHandler(this.buttonCAsignaturaEditar_Click);
            // 
            // dataGridCAsignatura
            // 
            this.dataGridCAsignatura.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCAsignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carrera});
            this.dataGridCAsignatura.Location = new System.Drawing.Point(10, 87);
            this.dataGridCAsignatura.Name = "dataGridCAsignatura";
            this.dataGridCAsignatura.Size = new System.Drawing.Size(576, 170);
            this.dataGridCAsignatura.TabIndex = 1;
            // 
            // labelCAsignaturaLista
            // 
            this.labelCAsignaturaLista.AutoSize = true;
            this.labelCAsignaturaLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAsignaturaLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCAsignaturaLista.Location = new System.Drawing.Point(14, 9);
            this.labelCAsignaturaLista.Name = "labelCAsignaturaLista";
            this.labelCAsignaturaLista.Size = new System.Drawing.Size(199, 24);
            this.labelCAsignaturaLista.TabIndex = 0;
            this.labelCAsignaturaLista.Text = "Lista de Asignatura";
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "Carrera_id";
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Carrera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Carrera.Width = 115;
            // 
            // ConsultaAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 312);
            this.Controls.Add(this.panelCAsignaturaVertical2);
            this.Name = "ConsultaAsignatura";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaAsignatura";
            this.Load += new System.EventHandler(this.ConsultaAsignatura_Load);
            this.panelCAsignaturaVertical2.ResumeLayout(false);
            this.panelCAsignaturaVertical2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCAsignatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCAsignaturaVertical2;
        private System.Windows.Forms.Button buttonCAsignaturaEliminar;
        private System.Windows.Forms.Button buttonCAsignaturaEditar;
        private System.Windows.Forms.DataGridView dataGridCAsignatura;
        private System.Windows.Forms.Label labelCAsignaturaLista;
        private System.Windows.Forms.Label labelCAsignaturaBuscar;
        private System.Windows.Forms.TextBox textCAsignaturaBuscar;
        private System.Windows.Forms.DataGridViewComboBoxColumn Carrera;
    }
}