namespace Inicio
{
    partial class ConsultaCarrera
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
            this.labelCCarreraBuscar = new System.Windows.Forms.Label();
            this.panelCCarreraVertical2 = new System.Windows.Forms.Panel();
            this.buttonCCarreraEliminar = new System.Windows.Forms.Button();
            this.buttonCCarreraEditar = new System.Windows.Forms.Button();
            this.dataGridCCarrera = new System.Windows.Forms.DataGridView();
            this.labelCCarreraLista = new System.Windows.Forms.Label();
            this.textCCarreraBuscar = new System.Windows.Forms.TextBox();
            this.panelCCarreraVertical2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCCarreraBuscar
            // 
            this.labelCCarreraBuscar.AutoSize = true;
            this.labelCCarreraBuscar.BackColor = System.Drawing.Color.Transparent;
            this.labelCCarreraBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCarreraBuscar.ForeColor = System.Drawing.Color.White;
            this.labelCCarreraBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCCarreraBuscar.Location = new System.Drawing.Point(408, 54);
            this.labelCCarreraBuscar.Name = "labelCCarreraBuscar";
            this.labelCCarreraBuscar.Size = new System.Drawing.Size(64, 19);
            this.labelCCarreraBuscar.TabIndex = 40;
            this.labelCCarreraBuscar.Text = "Buscar ";
            // 
            // panelCCarreraVertical2
            // 
            this.panelCCarreraVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCCarreraVertical2.Controls.Add(this.textCCarreraBuscar);
            this.panelCCarreraVertical2.Controls.Add(this.labelCCarreraBuscar);
            this.panelCCarreraVertical2.Controls.Add(this.buttonCCarreraEliminar);
            this.panelCCarreraVertical2.Controls.Add(this.buttonCCarreraEditar);
            this.panelCCarreraVertical2.Controls.Add(this.dataGridCCarrera);
            this.panelCCarreraVertical2.Controls.Add(this.labelCCarreraLista);
            this.panelCCarreraVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCCarreraVertical2.Location = new System.Drawing.Point(-219, 0);
            this.panelCCarreraVertical2.Name = "panelCCarreraVertical2";
            this.panelCCarreraVertical2.Size = new System.Drawing.Size(645, 308);
            this.panelCCarreraVertical2.TabIndex = 54;
            // 
            // buttonCCarreraEliminar
            // 
            this.buttonCCarreraEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCCarreraEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCCarreraEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCarreraEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCarreraEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCCarreraEliminar.Location = new System.Drawing.Point(504, 268);
            this.buttonCCarreraEliminar.Name = "buttonCCarreraEliminar";
            this.buttonCCarreraEliminar.Size = new System.Drawing.Size(85, 24);
            this.buttonCCarreraEliminar.TabIndex = 22;
            this.buttonCCarreraEliminar.Text = "Eliminar";
            this.buttonCCarreraEliminar.UseVisualStyleBackColor = false;
            this.buttonCCarreraEliminar.Click += new System.EventHandler(this.buttonCCarreraEliminar_Click);
            // 
            // buttonCCarreraEditar
            // 
            this.buttonCCarreraEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCCarreraEditar.FlatAppearance.BorderSize = 0;
            this.buttonCCarreraEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCarreraEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCarreraEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCCarreraEditar.Location = new System.Drawing.Point(401, 269);
            this.buttonCCarreraEditar.Name = "buttonCCarreraEditar";
            this.buttonCCarreraEditar.Size = new System.Drawing.Size(75, 24);
            this.buttonCCarreraEditar.TabIndex = 21;
            this.buttonCCarreraEditar.Text = "Editar";
            this.buttonCCarreraEditar.UseVisualStyleBackColor = false;
            this.buttonCCarreraEditar.Click += new System.EventHandler(this.buttonCCarreraEditar_Click);
            // 
            // dataGridCCarrera
            // 
            this.dataGridCCarrera.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCCarrera.Location = new System.Drawing.Point(245, 93);
            this.dataGridCCarrera.Name = "dataGridCCarrera";
            this.dataGridCCarrera.Size = new System.Drawing.Size(378, 170);
            this.dataGridCCarrera.TabIndex = 1;
            // 
            // labelCCarreraLista
            // 
            this.labelCCarreraLista.AutoSize = true;
            this.labelCCarreraLista.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCCarreraLista.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCCarreraLista.Location = new System.Drawing.Point(241, 9);
            this.labelCCarreraLista.Name = "labelCCarreraLista";
            this.labelCCarreraLista.Size = new System.Drawing.Size(177, 24);
            this.labelCCarreraLista.TabIndex = 0;
            this.labelCCarreraLista.Text = "Lista de Carreras";
            // 
            // textCCarreraBuscar
            // 
            this.textCCarreraBuscar.Location = new System.Drawing.Point(478, 56);
            this.textCCarreraBuscar.Name = "textCCarreraBuscar";
            this.textCCarreraBuscar.Size = new System.Drawing.Size(135, 20);
            this.textCCarreraBuscar.TabIndex = 51;
            this.textCCarreraBuscar.TextChanged += new System.EventHandler(this.textCCarreraBuscar_TextChanged);
            // 
            // ConsultaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 308);
            this.Controls.Add(this.panelCCarreraVertical2);
            this.Name = "ConsultaCarrera";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaCarrera";
            this.Load += new System.EventHandler(this.ConsultaCarrera_Load);
            this.panelCCarreraVertical2.ResumeLayout(false);
            this.panelCCarreraVertical2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCCarrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelCCarreraBuscar;
        private System.Windows.Forms.Panel panelCCarreraVertical2;
        private System.Windows.Forms.Button buttonCCarreraEliminar;
        private System.Windows.Forms.Button buttonCCarreraEditar;
        private System.Windows.Forms.DataGridView dataGridCCarrera;
        private System.Windows.Forms.Label labelCCarreraLista;
        private System.Windows.Forms.TextBox textCCarreraBuscar;
    }
}