namespace Inicio
{
    partial class InmueblePrestado
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
            this.panelInmueblePrestado = new System.Windows.Forms.Panel();
            this.dataGridInmueblePrestado = new System.Windows.Forms.DataGridView();
            this.buttonIPGuardar = new System.Windows.Forms.Button();
            this.panelInmueblePrestado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInmueblePrestado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInmueblePrestado
            // 
            this.panelInmueblePrestado.BackColor = System.Drawing.Color.DimGray;
            this.panelInmueblePrestado.Controls.Add(this.dataGridInmueblePrestado);
            this.panelInmueblePrestado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInmueblePrestado.Location = new System.Drawing.Point(0, 1);
            this.panelInmueblePrestado.Name = "panelInmueblePrestado";
            this.panelInmueblePrestado.Size = new System.Drawing.Size(708, 232);
            this.panelInmueblePrestado.TabIndex = 24;
            // 
            // dataGridInmueblePrestado
            // 
            this.dataGridInmueblePrestado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridInmueblePrestado.AllowUserToAddRows = false;
            this.dataGridInmueblePrestado.AllowUserToDeleteRows = false;
            this.dataGridInmueblePrestado.AllowUserToOrderColumns = true;
            this.dataGridInmueblePrestado.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridInmueblePrestado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInmueblePrestado.Location = new System.Drawing.Point(10, 11);
            this.dataGridInmueblePrestado.Name = "dataGridInmueblePrestado";
            this.dataGridInmueblePrestado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridInmueblePrestado.Size = new System.Drawing.Size(682, 204);
            this.dataGridInmueblePrestado.TabIndex = 7;
            // 
            // buttonIPGuardar
            // 
            this.buttonIPGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonIPGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonIPGuardar.Location = new System.Drawing.Point(246, 239);
            this.buttonIPGuardar.Name = "buttonIPGuardar";
            this.buttonIPGuardar.Size = new System.Drawing.Size(158, 24);
            this.buttonIPGuardar.TabIndex = 20;
            this.buttonIPGuardar.Text = "Guardar cambios";
            this.buttonIPGuardar.UseVisualStyleBackColor = false;
            this.buttonIPGuardar.Click += new System.EventHandler(this.buttonIPGuardar_Click);
            // 
            // InmueblePrestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 273);
            this.Controls.Add(this.buttonIPGuardar);
            this.Controls.Add(this.panelInmueblePrestado);
            this.Name = "InmueblePrestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InmueblePrestado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InmueblePrestado_FormClosing);
            this.Load += new System.EventHandler(this.InmueblePrestado_Load);
            this.panelInmueblePrestado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInmueblePrestado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInmueblePrestado;
        private System.Windows.Forms.DataGridView dataGridInmueblePrestado;
        private System.Windows.Forms.Button buttonIPGuardar;
    }
}