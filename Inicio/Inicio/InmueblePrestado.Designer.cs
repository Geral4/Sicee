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
            this.panelInmueblePrestado.Size = new System.Drawing.Size(584, 232);
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
            this.dataGridInmueblePrestado.Size = new System.Drawing.Size(561, 204);
            this.dataGridInmueblePrestado.TabIndex = 7;
            // 
            // InmueblePrestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 273);
            this.Controls.Add(this.panelInmueblePrestado);
            this.Name = "InmueblePrestado";
            this.Text = "InmueblePrestado";
            this.Load += new System.EventHandler(this.InmueblePrestado_Load);
            this.panelInmueblePrestado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInmueblePrestado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInmueblePrestado;
        private System.Windows.Forms.DataGridView dataGridInmueblePrestado;
    }
}