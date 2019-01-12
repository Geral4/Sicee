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
            this.textCCargoBuscar = new System.Windows.Forms.TextBox();
            this.labelCCargoBuscar = new System.Windows.Forms.Label();
            this.buttonCCargoEliminar = new System.Windows.Forms.Button();
            this.buttonCCargoEditar = new System.Windows.Forms.Button();
            this.dataGridCCargo = new System.Windows.Forms.DataGridView();
            this.labelCCargoLista = new System.Windows.Forms.Label();
            this.Departamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelCCargoVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCCargoVertical
            // 
            this.panelCCargoVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelCCargoVertical.Controls.Add(this.textCCargoBuscar);
            this.panelCCargoVertical.Controls.Add(this.labelCCargoBuscar);
            this.panelCCargoVertical.Controls.Add(this.buttonCCargoEliminar);
            this.panelCCargoVertical.Controls.Add(this.buttonCCargoEditar);
            this.panelCCargoVertical.Controls.Add(this.dataGridCCargo);
            this.panelCCargoVertical.Controls.Add(this.labelCCargoLista);
            this.panelCCargoVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCCargoVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCCargoVertical.Name = "panelCCargoVertical";
            this.panelCCargoVertical.Size = new System.Drawing.Size(485, 311);
            this.panelCCargoVertical.TabIndex = 6;
            this.panelCCargoVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCCargoVertical_Paint);
            // 
            // textCCargoBuscar
            // 
            this.textCCargoBuscar.Location = new System.Drawing.Point(227, 50);
            this.textCCargoBuscar.Name = "textCCargoBuscar";
            this.textCCargoBuscar.Size = new System.Drawing.Size(137, 20);
            this.textCCargoBuscar.TabIndex = 23;
            this.textCCargoBuscar.TextChanged += new System.EventHandler(this.textCCargoBuscar_TextChanged);
            // 
            // labelCCargoBuscar
            // 
            this.labelCCargoBuscar.AutoSize = true;
            this.labelCCargoBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCargoBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.labelCCargoBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCCargoBuscar.Location = new System.Drawing.Point(157, 49);
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
            this.buttonCCargoEliminar.Location = new System.Drawing.Point(260, 275);
            this.buttonCCargoEliminar.Name = "buttonCCargoEliminar";
            this.buttonCCargoEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCCargoEliminar.TabIndex = 22;
            this.buttonCCargoEliminar.Text = "Eliminar";
            this.buttonCCargoEliminar.UseVisualStyleBackColor = false;
            this.buttonCCargoEliminar.Click += new System.EventHandler(this.buttonCCargoEliminar_Click);
            // 
            // buttonCCargoEditar
            // 
            this.buttonCCargoEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCCargoEditar.FlatAppearance.BorderSize = 0;
            this.buttonCCargoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCargoEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCargoEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCCargoEditar.Location = new System.Drawing.Point(160, 275);
            this.buttonCCargoEditar.Name = "buttonCCargoEditar";
            this.buttonCCargoEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCCargoEditar.TabIndex = 21;
            this.buttonCCargoEditar.Text = "Editar";
            this.buttonCCargoEditar.UseVisualStyleBackColor = false;
            this.buttonCCargoEditar.Click += new System.EventHandler(this.buttonCCargoEditar_Click);
            // 
            // dataGridCCargo
            // 
            this.dataGridCCargo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departamento});
            this.dataGridCCargo.Location = new System.Drawing.Point(7, 87);
            this.dataGridCCargo.Name = "dataGridCCargo";
            this.dataGridCCargo.Size = new System.Drawing.Size(444, 182);
            this.dataGridCCargo.TabIndex = 1;
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
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Departamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ConsultaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 311);
            this.Controls.Add(this.panelCCargoVertical);
            this.Name = "ConsultaCargo";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaCargo";
            this.Load += new System.EventHandler(this.ConsultaCargo_Load);
            this.panelCCargoVertical.ResumeLayout(false);
            this.panelCCargoVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCCargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCCargoVertical;
        private System.Windows.Forms.TextBox textCCargoBuscar;
        private System.Windows.Forms.Label labelCCargoBuscar;
        private System.Windows.Forms.Button buttonCCargoEliminar;
        private System.Windows.Forms.Button buttonCCargoEditar;
        private System.Windows.Forms.DataGridView dataGridCCargo;
        private System.Windows.Forms.Label labelCCargoLista;
        private System.Windows.Forms.DataGridViewComboBoxColumn Departamento;
    }
}