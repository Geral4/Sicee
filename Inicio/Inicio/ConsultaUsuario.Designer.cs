namespace Inicio
{
    partial class ConsultaUsuario
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
            this.panelCUsuarioVertical = new System.Windows.Forms.Panel();
            this.textCUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.labelCUsuarioBuscar = new System.Windows.Forms.Label();
            this.buttonCUsuarioEliminar = new System.Windows.Forms.Button();
            this.buttonCUsuarioEditar = new System.Windows.Forms.Button();
            this.dataGridCUsuario = new System.Windows.Forms.DataGridView();
            this.NPersonal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.labelCUsuarioLista = new System.Windows.Forms.Label();
            this.panelCUsuarioVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCUsuarioVertical
            // 
            this.panelCUsuarioVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCUsuarioVertical.Controls.Add(this.textCUsuarioBuscar);
            this.panelCUsuarioVertical.Controls.Add(this.labelCUsuarioBuscar);
            this.panelCUsuarioVertical.Controls.Add(this.buttonCUsuarioEliminar);
            this.panelCUsuarioVertical.Controls.Add(this.buttonCUsuarioEditar);
            this.panelCUsuarioVertical.Controls.Add(this.dataGridCUsuario);
            this.panelCUsuarioVertical.Controls.Add(this.labelCUsuarioLista);
            this.panelCUsuarioVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUsuarioVertical.Location = new System.Drawing.Point(0, 0);
            this.panelCUsuarioVertical.Name = "panelCUsuarioVertical";
            this.panelCUsuarioVertical.Size = new System.Drawing.Size(553, 313);
            this.panelCUsuarioVertical.TabIndex = 6;
            // 
            // textCUsuarioBuscar
            // 
            this.textCUsuarioBuscar.Location = new System.Drawing.Point(285, 51);
            this.textCUsuarioBuscar.Name = "textCUsuarioBuscar";
            this.textCUsuarioBuscar.Size = new System.Drawing.Size(174, 20);
            this.textCUsuarioBuscar.TabIndex = 23;
            this.textCUsuarioBuscar.TextChanged += new System.EventHandler(this.textCUsuarioBuscar_TextChanged);
            // 
            // labelCUsuarioBuscar
            // 
            this.labelCUsuarioBuscar.AutoSize = true;
            this.labelCUsuarioBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCUsuarioBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelCUsuarioBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCUsuarioBuscar.Location = new System.Drawing.Point(222, 51);
            this.labelCUsuarioBuscar.Name = "labelCUsuarioBuscar";
            this.labelCUsuarioBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelCUsuarioBuscar.TabIndex = 21;
            this.labelCUsuarioBuscar.Text = "Buscar";
            // 
            // buttonCUsuarioEliminar
            // 
            this.buttonCUsuarioEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCUsuarioEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCUsuarioEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCUsuarioEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCUsuarioEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCUsuarioEliminar.Location = new System.Drawing.Point(314, 270);
            this.buttonCUsuarioEliminar.Name = "buttonCUsuarioEliminar";
            this.buttonCUsuarioEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCUsuarioEliminar.TabIndex = 22;
            this.buttonCUsuarioEliminar.Text = "Eliminar";
            this.buttonCUsuarioEliminar.UseVisualStyleBackColor = false;
            this.buttonCUsuarioEliminar.Click += new System.EventHandler(this.buttonCUsuarioEliminar_Click);
            // 
            // buttonCUsuarioEditar
            // 
            this.buttonCUsuarioEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCUsuarioEditar.FlatAppearance.BorderSize = 0;
            this.buttonCUsuarioEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCUsuarioEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCUsuarioEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCUsuarioEditar.Location = new System.Drawing.Point(210, 270);
            this.buttonCUsuarioEditar.Name = "buttonCUsuarioEditar";
            this.buttonCUsuarioEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCUsuarioEditar.TabIndex = 21;
            this.buttonCUsuarioEditar.Text = "Editar";
            this.buttonCUsuarioEditar.UseVisualStyleBackColor = false;
            this.buttonCUsuarioEditar.Click += new System.EventHandler(this.buttonCUsuarioEditar_Click);
            // 
            // dataGridCUsuario
            // 
            this.dataGridCUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NPersonal});
            this.dataGridCUsuario.Location = new System.Drawing.Point(10, 87);
            this.dataGridCUsuario.Name = "dataGridCUsuario";
            this.dataGridCUsuario.Size = new System.Drawing.Size(531, 170);
            this.dataGridCUsuario.TabIndex = 1;
            // 
            // NPersonal
            // 
            this.NPersonal.DataPropertyName = "NPersonal_id";
            this.NPersonal.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.NPersonal.HeaderText = "Nº Personal";
            this.NPersonal.Name = "NPersonal";
            this.NPersonal.Width = 80;
            // 
            // labelCUsuarioLista
            // 
            this.labelCUsuarioLista.AutoSize = true;
            this.labelCUsuarioLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCUsuarioLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCUsuarioLista.Location = new System.Drawing.Point(12, 11);
            this.labelCUsuarioLista.Name = "labelCUsuarioLista";
            this.labelCUsuarioLista.Size = new System.Drawing.Size(171, 24);
            this.labelCUsuarioLista.TabIndex = 0;
            this.labelCUsuarioLista.Text = "Lista de usuarios";
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 313);
            this.Controls.Add(this.panelCUsuarioVertical);
            this.Name = "ConsultaUsuario";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaUsuario";
            this.Load += new System.EventHandler(this.ConsultaUsuario_Load);
            this.panelCUsuarioVertical.ResumeLayout(false);
            this.panelCUsuarioVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCUsuarioVertical;
        private System.Windows.Forms.TextBox textCUsuarioBuscar;
        private System.Windows.Forms.Label labelCUsuarioBuscar;
        private System.Windows.Forms.Button buttonCUsuarioEliminar;
        private System.Windows.Forms.Button buttonCUsuarioEditar;
        private System.Windows.Forms.DataGridView dataGridCUsuario;
        private System.Windows.Forms.Label labelCUsuarioLista;
        private System.Windows.Forms.DataGridViewComboBoxColumn NPersonal;
    }
}