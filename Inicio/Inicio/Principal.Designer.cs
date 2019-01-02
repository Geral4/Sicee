namespace Inicio
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHora.Location = new System.Drawing.Point(351, 21);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(299, 108);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "label1";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelFecha.Location = new System.Drawing.Point(395, 129);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(152, 55);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelPrincipal.Controls.Add(this.dataGridViewPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 323);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1056, 280);
            this.panelPrincipal.TabIndex = 3;
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(16, 19);
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(1024, 249);
            this.dataGridViewPrincipal.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Principal";
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
    }
}