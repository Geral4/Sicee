namespace Inicio
{
    partial class ConsultaEmpleado
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
            this.panelCEmpleadoVertical2 = new System.Windows.Forms.Panel();
            this.textCEmpleadoBuscar = new System.Windows.Forms.TextBox();
            this.labelReporteLBuscar = new System.Windows.Forms.Label();
            this.buttonCEmpleadoBuscar = new System.Windows.Forms.Button();
            this.buttonCEmpleadoEliminar = new System.Windows.Forms.Button();
            this.buttonCEmpleadoEditar = new System.Windows.Forms.Button();
            this.dataGridCEmpleado = new System.Windows.Forms.DataGridView();
            this.labelCEmpleadoLista = new System.Windows.Forms.Label();
            this.columCargo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelCEmpleadoVertical2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCEmpleadoVertical2
            // 
            this.panelCEmpleadoVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCEmpleadoVertical2.Controls.Add(this.textCEmpleadoBuscar);
            this.panelCEmpleadoVertical2.Controls.Add(this.labelReporteLBuscar);
            this.panelCEmpleadoVertical2.Controls.Add(this.buttonCEmpleadoBuscar);
            this.panelCEmpleadoVertical2.Controls.Add(this.buttonCEmpleadoEliminar);
            this.panelCEmpleadoVertical2.Controls.Add(this.buttonCEmpleadoEditar);
            this.panelCEmpleadoVertical2.Controls.Add(this.dataGridCEmpleado);
            this.panelCEmpleadoVertical2.Controls.Add(this.labelCEmpleadoLista);
            this.panelCEmpleadoVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCEmpleadoVertical2.Location = new System.Drawing.Point(-8, 0);
            this.panelCEmpleadoVertical2.Name = "panelCEmpleadoVertical2";
            this.panelCEmpleadoVertical2.Size = new System.Drawing.Size(601, 395);
            this.panelCEmpleadoVertical2.TabIndex = 6;
            // 
            // textCEmpleadoBuscar
            // 
            this.textCEmpleadoBuscar.Location = new System.Drawing.Point(299, 46);
            this.textCEmpleadoBuscar.Name = "textCEmpleadoBuscar";
            this.textCEmpleadoBuscar.Size = new System.Drawing.Size(177, 20);
            this.textCEmpleadoBuscar.TabIndex = 41;
            this.textCEmpleadoBuscar.TextChanged += new System.EventHandler(this.textCEmpleadoBuscar_TextChanged);
            // 
            // labelReporteLBuscar
            // 
            this.labelReporteLBuscar.AutoSize = true;
            this.labelReporteLBuscar.BackColor = System.Drawing.Color.Transparent;
            this.labelReporteLBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReporteLBuscar.ForeColor = System.Drawing.Color.White;
            this.labelReporteLBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelReporteLBuscar.Location = new System.Drawing.Point(195, 46);
            this.labelReporteLBuscar.Name = "labelReporteLBuscar";
            this.labelReporteLBuscar.Size = new System.Drawing.Size(98, 19);
            this.labelReporteLBuscar.TabIndex = 40;
            this.labelReporteLBuscar.Text = "Buscar por :";
            // 
            // buttonCEmpleadoBuscar
            // 
            this.buttonCEmpleadoBuscar.BackColor = System.Drawing.Color.Olive;
            this.buttonCEmpleadoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCEmpleadoBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCEmpleadoBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonCEmpleadoBuscar.Location = new System.Drawing.Point(494, 40);
            this.buttonCEmpleadoBuscar.Name = "buttonCEmpleadoBuscar";
            this.buttonCEmpleadoBuscar.Size = new System.Drawing.Size(82, 26);
            this.buttonCEmpleadoBuscar.TabIndex = 42;
            this.buttonCEmpleadoBuscar.Text = "Buscar";
            this.buttonCEmpleadoBuscar.UseVisualStyleBackColor = false;
            // 
            // buttonCEmpleadoEliminar
            // 
            this.buttonCEmpleadoEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCEmpleadoEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCEmpleadoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCEmpleadoEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCEmpleadoEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCEmpleadoEliminar.Location = new System.Drawing.Point(302, 349);
            this.buttonCEmpleadoEliminar.Name = "buttonCEmpleadoEliminar";
            this.buttonCEmpleadoEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCEmpleadoEliminar.TabIndex = 22;
            this.buttonCEmpleadoEliminar.Text = "Eliminar";
            this.buttonCEmpleadoEliminar.UseVisualStyleBackColor = false;
            this.buttonCEmpleadoEliminar.Click += new System.EventHandler(this.buttonCEmpleadoEliminar_Click);
            // 
            // buttonCEmpleadoEditar
            // 
            this.buttonCEmpleadoEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCEmpleadoEditar.FlatAppearance.BorderSize = 0;
            this.buttonCEmpleadoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCEmpleadoEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCEmpleadoEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCEmpleadoEditar.Location = new System.Drawing.Point(199, 350);
            this.buttonCEmpleadoEditar.Name = "buttonCEmpleadoEditar";
            this.buttonCEmpleadoEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCEmpleadoEditar.TabIndex = 21;
            this.buttonCEmpleadoEditar.Text = "Editar";
            this.buttonCEmpleadoEditar.UseVisualStyleBackColor = false;
            this.buttonCEmpleadoEditar.Click += new System.EventHandler(this.buttonCEmpleadoEditar_Click);
            // 
            // dataGridCEmpleado
            // 
            this.dataGridCEmpleado.AllowUserToAddRows = false;
            this.dataGridCEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columCargo});
            this.dataGridCEmpleado.Location = new System.Drawing.Point(18, 88);
            this.dataGridCEmpleado.Name = "dataGridCEmpleado";
            this.dataGridCEmpleado.Size = new System.Drawing.Size(579, 255);
            this.dataGridCEmpleado.TabIndex = 1;
            // 
            // labelCEmpleadoLista
            // 
            this.labelCEmpleadoLista.AutoSize = true;
            this.labelCEmpleadoLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEmpleadoLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCEmpleadoLista.Location = new System.Drawing.Point(15, 12);
            this.labelCEmpleadoLista.Name = "labelCEmpleadoLista";
            this.labelCEmpleadoLista.Size = new System.Drawing.Size(210, 24);
            this.labelCEmpleadoLista.TabIndex = 0;
            this.labelCEmpleadoLista.Text = "Lista de empleados";
            // 
            // columCargo
            // 
            this.columCargo.DataPropertyName = "Cargo_id";
            this.columCargo.HeaderText = "Cargo";
            this.columCargo.Name = "columCargo";
            // 
            // ConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 395);
            this.Controls.Add(this.panelCEmpleadoVertical2);
            this.Name = "ConsultaEmpleado";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEmpleado";
            this.Load += new System.EventHandler(this.ConsultaEmpleado_Load);
            this.panelCEmpleadoVertical2.ResumeLayout(false);
            this.panelCEmpleadoVertical2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCEmpleadoVertical2;
        private System.Windows.Forms.Button buttonCEmpleadoEliminar;
        private System.Windows.Forms.Button buttonCEmpleadoEditar;
        private System.Windows.Forms.DataGridView dataGridCEmpleado;
        private System.Windows.Forms.Label labelCEmpleadoLista;
        private System.Windows.Forms.Label labelReporteLBuscar;
        private System.Windows.Forms.TextBox textCEmpleadoBuscar;
        private System.Windows.Forms.Button buttonCEmpleadoBuscar;
        private System.Windows.Forms.DataGridViewComboBoxColumn columCargo;
    }
}