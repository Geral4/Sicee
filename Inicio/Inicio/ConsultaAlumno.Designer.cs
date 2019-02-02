namespace Inicio
{
    partial class ConsultaAlumno
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
            this.labelCAlumnoLista = new System.Windows.Forms.Label();
            this.dataGridCAlumno = new System.Windows.Forms.DataGridView();
            this.buttonCAlumnoEditar = new System.Windows.Forms.Button();
            this.buttonCAlumnoEliminar = new System.Windows.Forms.Button();
            this.labelCAlumnoBuscar = new System.Windows.Forms.Label();
            this.textCAlumnoBuscar = new System.Windows.Forms.TextBox();
            this.panelCAlumnoVertical = new System.Windows.Forms.Panel();
            this.Carrera = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCAlumno)).BeginInit();
            this.panelCAlumnoVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCAlumnoLista
            // 
            this.labelCAlumnoLista.AutoSize = true;
            this.labelCAlumnoLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAlumnoLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCAlumnoLista.Location = new System.Drawing.Point(12, 11);
            this.labelCAlumnoLista.Name = "labelCAlumnoLista";
            this.labelCAlumnoLista.Size = new System.Drawing.Size(180, 24);
            this.labelCAlumnoLista.TabIndex = 0;
            this.labelCAlumnoLista.Text = "Lista de alumnos";
            // 
            // dataGridCAlumno
            // 
            this.dataGridCAlumno.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carrera});
            this.dataGridCAlumno.Location = new System.Drawing.Point(10, 87);
            this.dataGridCAlumno.Name = "dataGridCAlumno";
            this.dataGridCAlumno.Size = new System.Drawing.Size(562, 170);
            this.dataGridCAlumno.TabIndex = 1;
            // 
            // buttonCAlumnoEditar
            // 
            this.buttonCAlumnoEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCAlumnoEditar.FlatAppearance.BorderSize = 0;
            this.buttonCAlumnoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCAlumnoEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCAlumnoEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCAlumnoEditar.Location = new System.Drawing.Point(227, 264);
            this.buttonCAlumnoEditar.Name = "buttonCAlumnoEditar";
            this.buttonCAlumnoEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCAlumnoEditar.TabIndex = 21;
            this.buttonCAlumnoEditar.Text = "Editar";
            this.buttonCAlumnoEditar.UseVisualStyleBackColor = false;
            this.buttonCAlumnoEditar.Click += new System.EventHandler(this.buttonCAlumnoEditar_Click_1);
            // 
            // buttonCAlumnoEliminar
            // 
            this.buttonCAlumnoEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCAlumnoEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCAlumnoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCAlumnoEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCAlumnoEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCAlumnoEliminar.Location = new System.Drawing.Point(330, 263);
            this.buttonCAlumnoEliminar.Name = "buttonCAlumnoEliminar";
            this.buttonCAlumnoEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCAlumnoEliminar.TabIndex = 22;
            this.buttonCAlumnoEliminar.Text = "Eliminar";
            this.buttonCAlumnoEliminar.UseVisualStyleBackColor = false;
            this.buttonCAlumnoEliminar.Click += new System.EventHandler(this.buttonCAlumnoEliminar_Click);
            // 
            // labelCAlumnoBuscar
            // 
            this.labelCAlumnoBuscar.AutoSize = true;
            this.labelCAlumnoBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAlumnoBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelCAlumnoBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCAlumnoBuscar.Location = new System.Drawing.Point(195, 58);
            this.labelCAlumnoBuscar.Name = "labelCAlumnoBuscar";
            this.labelCAlumnoBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelCAlumnoBuscar.TabIndex = 21;
            this.labelCAlumnoBuscar.Text = "Buscar";
            // 
            // textCAlumnoBuscar
            // 
            this.textCAlumnoBuscar.Location = new System.Drawing.Point(251, 57);
            this.textCAlumnoBuscar.Name = "textCAlumnoBuscar";
            this.textCAlumnoBuscar.Size = new System.Drawing.Size(137, 20);
            this.textCAlumnoBuscar.TabIndex = 23;
            this.textCAlumnoBuscar.TextChanged += new System.EventHandler(this.textCAlumnoBuscar_TextChanged);
            // 
            // panelCAlumnoVertical
            // 
            this.panelCAlumnoVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCAlumnoVertical.Controls.Add(this.textCAlumnoBuscar);
            this.panelCAlumnoVertical.Controls.Add(this.labelCAlumnoBuscar);
            this.panelCAlumnoVertical.Controls.Add(this.buttonCAlumnoEliminar);
            this.panelCAlumnoVertical.Controls.Add(this.buttonCAlumnoEditar);
            this.panelCAlumnoVertical.Controls.Add(this.dataGridCAlumno);
            this.panelCAlumnoVertical.Controls.Add(this.labelCAlumnoLista);
            this.panelCAlumnoVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCAlumnoVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCAlumnoVertical.Name = "panelCAlumnoVertical";
            this.panelCAlumnoVertical.Size = new System.Drawing.Size(585, 297);
            this.panelCAlumnoVertical.TabIndex = 5;
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "Carrera_id";
            this.Carrera.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MaxDropDownItems = 20;
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 115;
            // 
            // ConsultaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 297);
            this.Controls.Add(this.panelCAlumnoVertical);
            this.Name = "ConsultaAlumno";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaAlumno";
            this.Load += new System.EventHandler(this.ConsultaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCAlumno)).EndInit();
            this.panelCAlumnoVertical.ResumeLayout(false);
            this.panelCAlumnoVertical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCAlumnoLista;
        private System.Windows.Forms.DataGridView dataGridCAlumno;
        private System.Windows.Forms.Button buttonCAlumnoEditar;
        private System.Windows.Forms.Button buttonCAlumnoEliminar;
        private System.Windows.Forms.Label labelCAlumnoBuscar;
        private System.Windows.Forms.TextBox textCAlumnoBuscar;
        private System.Windows.Forms.Panel panelCAlumnoVertical;
        private System.Windows.Forms.DataGridViewComboBoxColumn Carrera;
    }
}