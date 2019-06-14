namespace Inicio
{
    partial class Aula1
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
            this.panelAula = new System.Windows.Forms.Panel();
            this.dataGridAula1 = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAula1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAula
            // 
            this.panelAula.BackColor = System.Drawing.Color.DimGray;
            this.panelAula.Controls.Add(this.dataGridAula1);
            this.panelAula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAula.Location = new System.Drawing.Point(4, 4);
            this.panelAula.Name = "panelAula";
            this.panelAula.Size = new System.Drawing.Size(454, 218);
            this.panelAula.TabIndex = 23;
            // 
            // dataGridAula1
            // 
            this.dataGridAula1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridAula1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAula1.Location = new System.Drawing.Point(8, 10);
            this.dataGridAula1.Name = "dataGridAula1";
            this.dataGridAula1.Size = new System.Drawing.Size(436, 199);
            this.dataGridAula1.TabIndex = 0;
            this.dataGridAula1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridAula1_CellBeginEdit);
            this.dataGridAula1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAula1_CellEndEdit);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.AccessibleName = "";
            this.buttonAgregar.Location = new System.Drawing.Point(65, 228);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(56, 24);
            this.buttonAgregar.TabIndex = 24;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(352, 228);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(56, 24);
            this.buttonEliminar.TabIndex = 25;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(213, 228);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(56, 24);
            this.buttonGuardar.TabIndex = 26;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Aula1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 253);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.panelAula);
            this.Name = "Aula1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aulas";
            this.Activated += new System.EventHandler(this.Aula1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Aula1_FormClosing);
            this.Load += new System.EventHandler(this.Aula1_Load);
            this.VisibleChanged += new System.EventHandler(this.Aula1_VisibleChanged);
            this.panelAula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAula1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAula;
        public System.Windows.Forms.DataGridView dataGridAula1;
        public System.Windows.Forms.Button buttonAgregar;
        public System.Windows.Forms.Button buttonEliminar;
        public System.Windows.Forms.Button buttonGuardar;
    }
}