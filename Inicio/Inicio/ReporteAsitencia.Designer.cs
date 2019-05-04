namespace Inicio
{
    partial class ReporteAsitencia
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
            this.panelRAsistenciaVertical2 = new System.Windows.Forms.Panel();
            this.buttonRAsistenciaGenerar = new System.Windows.Forms.Button();
            this.panelRAsistenciaVertical = new System.Windows.Forms.Panel();
            this.RAsistenciaFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaInicio = new System.Windows.Forms.Label();
            this.RAsistenciaNombre = new System.Windows.Forms.TextBox();
            this.labelRAsistenciaNPersonal = new System.Windows.Forms.Label();
            this.RAsistenciaNPersonal = new System.Windows.Forms.TextBox();
            this.RAsistenciaFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelRAsistenciaBuscar = new System.Windows.Forms.Label();
            this.panelRAsistenciaVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRAsistenciaVertical2
            // 
            this.panelRAsistenciaVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelRAsistenciaVertical2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRAsistenciaVertical2.Location = new System.Drawing.Point(216, 0);
            this.panelRAsistenciaVertical2.Name = "panelRAsistenciaVertical2";
            this.panelRAsistenciaVertical2.Size = new System.Drawing.Size(590, 406);
            this.panelRAsistenciaVertical2.TabIndex = 2;
            // 
            // buttonRAsistenciaGenerar
            // 
            this.buttonRAsistenciaGenerar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonRAsistenciaGenerar.FlatAppearance.BorderSize = 0;
            this.buttonRAsistenciaGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRAsistenciaGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRAsistenciaGenerar.ForeColor = System.Drawing.Color.White;
            this.buttonRAsistenciaGenerar.Location = new System.Drawing.Point(41, 321);
            this.buttonRAsistenciaGenerar.Name = "buttonRAsistenciaGenerar";
            this.buttonRAsistenciaGenerar.Size = new System.Drawing.Size(147, 24);
            this.buttonRAsistenciaGenerar.TabIndex = 21;
            this.buttonRAsistenciaGenerar.Text = "Generar Reporte";
            this.buttonRAsistenciaGenerar.UseVisualStyleBackColor = false;
            // 
            // panelRAsistenciaVertical
            // 
            this.panelRAsistenciaVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelRAsistenciaVertical.Controls.Add(this.buttonRAsistenciaGenerar);
            this.panelRAsistenciaVertical.Controls.Add(this.RAsistenciaFechaFin);
            this.panelRAsistenciaVertical.Controls.Add(this.label1);
            this.panelRAsistenciaVertical.Controls.Add(this.FechaInicio);
            this.panelRAsistenciaVertical.Controls.Add(this.RAsistenciaNombre);
            this.panelRAsistenciaVertical.Controls.Add(this.labelRAsistenciaNPersonal);
            this.panelRAsistenciaVertical.Controls.Add(this.RAsistenciaNPersonal);
            this.panelRAsistenciaVertical.Controls.Add(this.RAsistenciaFechaInicio);
            this.panelRAsistenciaVertical.Controls.Add(this.labelRAsistenciaBuscar);
            this.panelRAsistenciaVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRAsistenciaVertical.Location = new System.Drawing.Point(0, 0);
            this.panelRAsistenciaVertical.Name = "panelRAsistenciaVertical";
            this.panelRAsistenciaVertical.Size = new System.Drawing.Size(218, 406);
            this.panelRAsistenciaVertical.TabIndex = 3;
            this.panelRAsistenciaVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmpleadoVertical2_Paint);
            // 
            // RAsistenciaFechaFin
            // 
            this.RAsistenciaFechaFin.Location = new System.Drawing.Point(9, 233);
            this.RAsistenciaFechaFin.Name = "RAsistenciaFechaFin";
            this.RAsistenciaFechaFin.Size = new System.Drawing.Size(202, 20);
            this.RAsistenciaFechaFin.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hasta";
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSize = true;
            this.FechaInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicio.ForeColor = System.Drawing.Color.White;
            this.FechaInicio.Location = new System.Drawing.Point(85, 146);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(48, 17);
            this.FechaInicio.TabIndex = 32;
            this.FechaInicio.Text = "Desde";
            // 
            // RAsistenciaNombre
            // 
            this.RAsistenciaNombre.Location = new System.Drawing.Point(11, 97);
            this.RAsistenciaNombre.Name = "RAsistenciaNombre";
            this.RAsistenciaNombre.Size = new System.Drawing.Size(199, 20);
            this.RAsistenciaNombre.TabIndex = 31;
            // 
            // labelRAsistenciaNPersonal
            // 
            this.labelRAsistenciaNPersonal.AutoSize = true;
            this.labelRAsistenciaNPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAsistenciaNPersonal.ForeColor = System.Drawing.Color.White;
            this.labelRAsistenciaNPersonal.Location = new System.Drawing.Point(2, 63);
            this.labelRAsistenciaNPersonal.Name = "labelRAsistenciaNPersonal";
            this.labelRAsistenciaNPersonal.Size = new System.Drawing.Size(85, 17);
            this.labelRAsistenciaNPersonal.TabIndex = 22;
            this.labelRAsistenciaNPersonal.Text = "Nº Personal:";
            // 
            // RAsistenciaNPersonal
            // 
            this.RAsistenciaNPersonal.Location = new System.Drawing.Point(85, 62);
            this.RAsistenciaNPersonal.Name = "RAsistenciaNPersonal";
            this.RAsistenciaNPersonal.Size = new System.Drawing.Size(127, 20);
            this.RAsistenciaNPersonal.TabIndex = 30;
            // 
            // RAsistenciaFechaInicio
            // 
            this.RAsistenciaFechaInicio.Location = new System.Drawing.Point(9, 166);
            this.RAsistenciaFechaInicio.Name = "RAsistenciaFechaInicio";
            this.RAsistenciaFechaInicio.Size = new System.Drawing.Size(202, 20);
            this.RAsistenciaFechaInicio.TabIndex = 22;
            // 
            // labelRAsistenciaBuscar
            // 
            this.labelRAsistenciaBuscar.AutoSize = true;
            this.labelRAsistenciaBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.labelRAsistenciaBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAsistenciaBuscar.ForeColor = System.Drawing.Color.White;
            this.labelRAsistenciaBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelRAsistenciaBuscar.Location = new System.Drawing.Point(51, 20);
            this.labelRAsistenciaBuscar.Name = "labelRAsistenciaBuscar";
            this.labelRAsistenciaBuscar.Size = new System.Drawing.Size(68, 19);
            this.labelRAsistenciaBuscar.TabIndex = 25;
            this.labelRAsistenciaBuscar.Text = "Buscar :";
            // 
            // ReporteAsitencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 406);
            this.Controls.Add(this.panelRAsistenciaVertical);
            this.Controls.Add(this.panelRAsistenciaVertical2);
            this.Name = "ReporteAsitencia";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteAsitencia";
            this.panelRAsistenciaVertical.ResumeLayout(false);
            this.panelRAsistenciaVertical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRAsistenciaVertical2;
        private System.Windows.Forms.Button buttonRAsistenciaGenerar;
        private System.Windows.Forms.Panel panelRAsistenciaVertical;
        private System.Windows.Forms.Label labelRAsistenciaBuscar;
        private System.Windows.Forms.DateTimePicker RAsistenciaFechaInicio;
        private System.Windows.Forms.Label labelRAsistenciaNPersonal;
        private System.Windows.Forms.TextBox RAsistenciaNPersonal;
        private System.Windows.Forms.DateTimePicker RAsistenciaFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FechaInicio;
        private System.Windows.Forms.TextBox RAsistenciaNombre;
    }
}