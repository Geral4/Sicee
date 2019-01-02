namespace Inicio
{
    partial class Aula
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
            this.buttonAulaGuardar = new System.Windows.Forms.Button();
            this.panelAula = new System.Windows.Forms.Panel();
            this.labelAulaDescripcion = new System.Windows.Forms.Label();
            this.tableAula = new System.Windows.Forms.TableLayoutPanel();
            this.labelAulaCapacidad = new System.Windows.Forms.Label();
            this.labelAulaNombre = new System.Windows.Forms.Label();
            this.labelAulaClave = new System.Windows.Forms.Label();
            this.panelAula.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAulaGuardar
            // 
            this.buttonAulaGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAulaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAulaGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAulaGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonAulaGuardar.Location = new System.Drawing.Point(164, 243);
            this.buttonAulaGuardar.Name = "buttonAulaGuardar";
            this.buttonAulaGuardar.Size = new System.Drawing.Size(92, 28);
            this.buttonAulaGuardar.TabIndex = 19;
            this.buttonAulaGuardar.Text = "Guardar";
            this.buttonAulaGuardar.UseVisualStyleBackColor = false;
            // 
            // panelAula
            // 
            this.panelAula.BackColor = System.Drawing.Color.DimGray;
            this.panelAula.Controls.Add(this.labelAulaDescripcion);
            this.panelAula.Controls.Add(this.tableAula);
            this.panelAula.Controls.Add(this.labelAulaCapacidad);
            this.panelAula.Controls.Add(this.labelAulaNombre);
            this.panelAula.Controls.Add(this.labelAulaClave);
            this.panelAula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAula.Location = new System.Drawing.Point(0, 3);
            this.panelAula.Name = "panelAula";
            this.panelAula.Size = new System.Drawing.Size(447, 232);
            this.panelAula.TabIndex = 22;
            // 
            // labelAulaDescripcion
            // 
            this.labelAulaDescripcion.AutoSize = true;
            this.labelAulaDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labelAulaDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAulaDescripcion.ForeColor = System.Drawing.Color.Black;
            this.labelAulaDescripcion.Location = new System.Drawing.Point(310, 18);
            this.labelAulaDescripcion.Name = "labelAulaDescripcion";
            this.labelAulaDescripcion.Size = new System.Drawing.Size(100, 21);
            this.labelAulaDescripcion.TabIndex = 6;
            this.labelAulaDescripcion.Text = "Descripcion";
            // 
            // tableAula
            // 
            this.tableAula.BackColor = System.Drawing.Color.White;
            this.tableAula.ColumnCount = 4;
            this.tableAula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.31461F));
            this.tableAula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.68539F));
            this.tableAula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableAula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableAula.Location = new System.Drawing.Point(24, 42);
            this.tableAula.Name = "tableAula";
            this.tableAula.RowCount = 5;
            this.tableAula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableAula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableAula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableAula.Size = new System.Drawing.Size(393, 175);
            this.tableAula.TabIndex = 5;
            // 
            // labelAulaCapacidad
            // 
            this.labelAulaCapacidad.AutoSize = true;
            this.labelAulaCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.labelAulaCapacidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAulaCapacidad.ForeColor = System.Drawing.Color.Black;
            this.labelAulaCapacidad.Location = new System.Drawing.Point(202, 18);
            this.labelAulaCapacidad.Name = "labelAulaCapacidad";
            this.labelAulaCapacidad.Size = new System.Drawing.Size(102, 21);
            this.labelAulaCapacidad.TabIndex = 4;
            this.labelAulaCapacidad.Text = "Capacidad";
            // 
            // labelAulaNombre
            // 
            this.labelAulaNombre.AutoSize = true;
            this.labelAulaNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelAulaNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAulaNombre.ForeColor = System.Drawing.Color.Black;
            this.labelAulaNombre.Location = new System.Drawing.Point(34, 18);
            this.labelAulaNombre.Name = "labelAulaNombre";
            this.labelAulaNombre.Size = new System.Drawing.Size(73, 21);
            this.labelAulaNombre.TabIndex = 3;
            this.labelAulaNombre.Text = "Nombre";
            // 
            // labelAulaClave
            // 
            this.labelAulaClave.AutoSize = true;
            this.labelAulaClave.BackColor = System.Drawing.Color.Transparent;
            this.labelAulaClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAulaClave.ForeColor = System.Drawing.Color.Black;
            this.labelAulaClave.Location = new System.Drawing.Point(123, 18);
            this.labelAulaClave.Name = "labelAulaClave";
            this.labelAulaClave.Size = new System.Drawing.Size(57, 21);
            this.labelAulaClave.TabIndex = 2;
            this.labelAulaClave.Text = "Clave";
            // 
            // Aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 283);
            this.Controls.Add(this.panelAula);
            this.Controls.Add(this.buttonAulaGuardar);
            this.Name = "Aula";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula";
            this.panelAula.ResumeLayout(false);
            this.panelAula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAulaGuardar;
        private System.Windows.Forms.Panel panelAula;
        private System.Windows.Forms.TableLayoutPanel tableAula;
        private System.Windows.Forms.Label labelAulaCapacidad;
        private System.Windows.Forms.Label labelAulaNombre;
        private System.Windows.Forms.Label labelAulaClave;
        private System.Windows.Forms.Label labelAulaDescripcion;
    }
}