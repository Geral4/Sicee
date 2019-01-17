namespace Inicio
{
    partial class ConsultaInmueble
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
            this.panelCInmuebleHorizontal3 = new System.Windows.Forms.Panel();
            this.panelCInmuebleVertical2 = new System.Windows.Forms.Panel();
            this.textCInmuebleBuscar = new System.Windows.Forms.TextBox();
            this.labelCInmuebleBuscar = new System.Windows.Forms.Label();
            this.buttonCInmuebleEliminar = new System.Windows.Forms.Button();
            this.buttonCInmuebleEditar = new System.Windows.Forms.Button();
            this.dataGridCInmueble = new System.Windows.Forms.DataGridView();
            this.labelCInmuebleLista = new System.Windows.Forms.Label();
            this.panelCInmuebleHorizontal = new System.Windows.Forms.Panel();
            this.panelCInmuebleVertical2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCInmueble)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCInmuebleHorizontal3
            // 
            this.panelCInmuebleHorizontal3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelCInmuebleHorizontal3.Location = new System.Drawing.Point(0, 525);
            this.panelCInmuebleHorizontal3.Name = "panelCInmuebleHorizontal3";
            this.panelCInmuebleHorizontal3.Size = new System.Drawing.Size(1035, 19);
            this.panelCInmuebleHorizontal3.TabIndex = 13;
            // 
            // panelCInmuebleVertical2
            // 
            this.panelCInmuebleVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelCInmuebleVertical2.Controls.Add(this.textCInmuebleBuscar);
            this.panelCInmuebleVertical2.Controls.Add(this.labelCInmuebleBuscar);
            this.panelCInmuebleVertical2.Controls.Add(this.buttonCInmuebleEliminar);
            this.panelCInmuebleVertical2.Controls.Add(this.buttonCInmuebleEditar);
            this.panelCInmuebleVertical2.Controls.Add(this.dataGridCInmueble);
            this.panelCInmuebleVertical2.Controls.Add(this.labelCInmuebleLista);
            this.panelCInmuebleVertical2.Location = new System.Drawing.Point(7, 30);
            this.panelCInmuebleVertical2.Name = "panelCInmuebleVertical2";
            this.panelCInmuebleVertical2.Size = new System.Drawing.Size(670, 489);
            this.panelCInmuebleVertical2.TabIndex = 12;
            // 
            // textCInmuebleBuscar
            // 
            this.textCInmuebleBuscar.Location = new System.Drawing.Point(375, 37);
            this.textCInmuebleBuscar.Name = "textCInmuebleBuscar";
            this.textCInmuebleBuscar.Size = new System.Drawing.Size(173, 20);
            this.textCInmuebleBuscar.TabIndex = 23;
            this.textCInmuebleBuscar.TextChanged += new System.EventHandler(this.textCInmuebleBuscar_TextChanged);
            // 
            // labelCInmuebleBuscar
            // 
            this.labelCInmuebleBuscar.AutoSize = true;
            this.labelCInmuebleBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCInmuebleBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.labelCInmuebleBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCInmuebleBuscar.Location = new System.Drawing.Point(321, 37);
            this.labelCInmuebleBuscar.Name = "labelCInmuebleBuscar";
            this.labelCInmuebleBuscar.Size = new System.Drawing.Size(57, 18);
            this.labelCInmuebleBuscar.TabIndex = 21;
            this.labelCInmuebleBuscar.Text = "Buscar";
            // 
            // buttonCInmuebleEliminar
            // 
            this.buttonCInmuebleEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCInmuebleEliminar.FlatAppearance.BorderSize = 0;
            this.buttonCInmuebleEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCInmuebleEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCInmuebleEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonCInmuebleEliminar.Location = new System.Drawing.Point(375, 453);
            this.buttonCInmuebleEliminar.Name = "buttonCInmuebleEliminar";
            this.buttonCInmuebleEliminar.Size = new System.Drawing.Size(94, 26);
            this.buttonCInmuebleEliminar.TabIndex = 22;
            this.buttonCInmuebleEliminar.Text = "Eliminar";
            this.buttonCInmuebleEliminar.UseVisualStyleBackColor = false;
            this.buttonCInmuebleEliminar.Click += new System.EventHandler(this.buttonCInmuebleEliminar_Click);
            // 
            // buttonCInmuebleEditar
            // 
            this.buttonCInmuebleEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCInmuebleEditar.FlatAppearance.BorderSize = 0;
            this.buttonCInmuebleEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCInmuebleEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCInmuebleEditar.ForeColor = System.Drawing.Color.White;
            this.buttonCInmuebleEditar.Location = new System.Drawing.Point(160, 453);
            this.buttonCInmuebleEditar.Name = "buttonCInmuebleEditar";
            this.buttonCInmuebleEditar.Size = new System.Drawing.Size(96, 26);
            this.buttonCInmuebleEditar.TabIndex = 21;
            this.buttonCInmuebleEditar.Text = "Editar";
            this.buttonCInmuebleEditar.UseVisualStyleBackColor = false;
            this.buttonCInmuebleEditar.Click += new System.EventHandler(this.buttonCInmuebleEditar_Click);
            // 
            // dataGridCInmueble
            // 
            this.dataGridCInmueble.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCInmueble.Location = new System.Drawing.Point(8, 69);
            this.dataGridCInmueble.Name = "dataGridCInmueble";
            this.dataGridCInmueble.Size = new System.Drawing.Size(653, 364);
            this.dataGridCInmueble.TabIndex = 1;
            // 
            // labelCInmuebleLista
            // 
            this.labelCInmuebleLista.AutoSize = true;
            this.labelCInmuebleLista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCInmuebleLista.ForeColor = System.Drawing.Color.White;
            this.labelCInmuebleLista.Location = new System.Drawing.Point(6, 19);
            this.labelCInmuebleLista.Name = "labelCInmuebleLista";
            this.labelCInmuebleLista.Size = new System.Drawing.Size(180, 23);
            this.labelCInmuebleLista.TabIndex = 0;
            this.labelCInmuebleLista.Text = "Lista de inmuebles";
            // 
            // panelCInmuebleHorizontal
            // 
            this.panelCInmuebleHorizontal.BackColor = System.Drawing.Color.Olive;
            this.panelCInmuebleHorizontal.Location = new System.Drawing.Point(0, 6);
            this.panelCInmuebleHorizontal.Name = "panelCInmuebleHorizontal";
            this.panelCInmuebleHorizontal.Size = new System.Drawing.Size(690, 19);
            this.panelCInmuebleHorizontal.TabIndex = 10;
            // 
            // ConsultaInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 549);
            this.Controls.Add(this.panelCInmuebleHorizontal3);
            this.Controls.Add(this.panelCInmuebleVertical2);
            this.Controls.Add(this.panelCInmuebleHorizontal);
            this.Name = "ConsultaInmueble";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaInmueble";
            this.Load += new System.EventHandler(this.ConsultaInmueble_Load);
            this.panelCInmuebleVertical2.ResumeLayout(false);
            this.panelCInmuebleVertical2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCInmueble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCInmuebleHorizontal3;
        private System.Windows.Forms.Panel panelCInmuebleVertical2;
        private System.Windows.Forms.TextBox textCInmuebleBuscar;
        private System.Windows.Forms.Label labelCInmuebleBuscar;
        private System.Windows.Forms.Button buttonCInmuebleEliminar;
        private System.Windows.Forms.Button buttonCInmuebleEditar;
        private System.Windows.Forms.DataGridView dataGridCInmueble;
        private System.Windows.Forms.Label labelCInmuebleLista;
        private System.Windows.Forms.Panel panelCInmuebleHorizontal;
    }
}