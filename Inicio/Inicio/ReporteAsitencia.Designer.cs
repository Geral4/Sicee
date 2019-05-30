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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.c_reporte_asistencia_docenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteAsistencia = new ReporteAsistencia();
            this.panelRAsistenciaVertical2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.c_reporte_asistencia_docenteTableAdapter = new ReporteAsistenciaTableAdapters.c_reporte_asistencia_docenteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c_reporte_asistencia_docenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteAsistencia)).BeginInit();
            this.panelRAsistenciaVertical2.SuspendLayout();
            this.panelRAsistenciaVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_reporte_asistencia_docenteBindingSource
            // 
            this.c_reporte_asistencia_docenteBindingSource.DataMember = "c_reporte_asistencia_docente";
            this.c_reporte_asistencia_docenteBindingSource.DataSource = this.ReporteAsistencia;
            // 
            // ReporteAsistencia
            // 
            this.ReporteAsistencia.DataSetName = "ReporteAsistencia";
            this.ReporteAsistencia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelRAsistenciaVertical2
            // 
            this.panelRAsistenciaVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelRAsistenciaVertical2.Controls.Add(this.reportViewer1);
            this.panelRAsistenciaVertical2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRAsistenciaVertical2.Location = new System.Drawing.Point(0, 0);
            this.panelRAsistenciaVertical2.Margin = new System.Windows.Forms.Padding(4);
            this.panelRAsistenciaVertical2.Name = "panelRAsistenciaVertical2";
            this.panelRAsistenciaVertical2.Size = new System.Drawing.Size(1400, 650);
            this.panelRAsistenciaVertical2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RAsistenciaDoc";
            reportDataSource1.Value = this.c_reporte_asistencia_docenteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inicio.ReporteAsistencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(288, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1112, 650);
            this.reportViewer1.TabIndex = 0;
            // 
            // buttonRAsistenciaGenerar
            // 
            this.buttonRAsistenciaGenerar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonRAsistenciaGenerar.FlatAppearance.BorderSize = 0;
            this.buttonRAsistenciaGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRAsistenciaGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRAsistenciaGenerar.ForeColor = System.Drawing.Color.White;
            this.buttonRAsistenciaGenerar.Location = new System.Drawing.Point(55, 395);
            this.buttonRAsistenciaGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRAsistenciaGenerar.Name = "buttonRAsistenciaGenerar";
            this.buttonRAsistenciaGenerar.Size = new System.Drawing.Size(196, 30);
            this.buttonRAsistenciaGenerar.TabIndex = 21;
            this.buttonRAsistenciaGenerar.Text = "Generar Reporte";
            this.buttonRAsistenciaGenerar.UseVisualStyleBackColor = false;
            this.buttonRAsistenciaGenerar.Click += new System.EventHandler(this.buttonRAsistenciaGenerar_Click);
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
            this.panelRAsistenciaVertical.Margin = new System.Windows.Forms.Padding(4);
            this.panelRAsistenciaVertical.Name = "panelRAsistenciaVertical";
            this.panelRAsistenciaVertical.Size = new System.Drawing.Size(291, 650);
            this.panelRAsistenciaVertical.TabIndex = 3;
            this.panelRAsistenciaVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmpleadoVertical2_Paint);
            // 
            // RAsistenciaFechaFin
            // 
            this.RAsistenciaFechaFin.Location = new System.Drawing.Point(12, 287);
            this.RAsistenciaFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.RAsistenciaFechaFin.Name = "RAsistenciaFechaFin";
            this.RAsistenciaFechaFin.Size = new System.Drawing.Size(268, 22);
            this.RAsistenciaFechaFin.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hasta";
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSize = true;
            this.FechaInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicio.ForeColor = System.Drawing.Color.White;
            this.FechaInicio.Location = new System.Drawing.Point(113, 180);
            this.FechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(64, 21);
            this.FechaInicio.TabIndex = 32;
            this.FechaInicio.Text = "Desde";
            // 
            // RAsistenciaNombre
            // 
            this.RAsistenciaNombre.Location = new System.Drawing.Point(15, 119);
            this.RAsistenciaNombre.Margin = new System.Windows.Forms.Padding(4);
            this.RAsistenciaNombre.Name = "RAsistenciaNombre";
            this.RAsistenciaNombre.Size = new System.Drawing.Size(264, 22);
            this.RAsistenciaNombre.TabIndex = 31;
            // 
            // labelRAsistenciaNPersonal
            // 
            this.labelRAsistenciaNPersonal.AutoSize = true;
            this.labelRAsistenciaNPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAsistenciaNPersonal.ForeColor = System.Drawing.Color.White;
            this.labelRAsistenciaNPersonal.Location = new System.Drawing.Point(3, 78);
            this.labelRAsistenciaNPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRAsistenciaNPersonal.Name = "labelRAsistenciaNPersonal";
            this.labelRAsistenciaNPersonal.Size = new System.Drawing.Size(108, 21);
            this.labelRAsistenciaNPersonal.TabIndex = 22;
            this.labelRAsistenciaNPersonal.Text = "Nº Personal:";
            // 
            // RAsistenciaNPersonal
            // 
            this.RAsistenciaNPersonal.Location = new System.Drawing.Point(113, 76);
            this.RAsistenciaNPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.RAsistenciaNPersonal.Name = "RAsistenciaNPersonal";
            this.RAsistenciaNPersonal.Size = new System.Drawing.Size(168, 22);
            this.RAsistenciaNPersonal.TabIndex = 30;
            // 
            // RAsistenciaFechaInicio
            // 
            this.RAsistenciaFechaInicio.Location = new System.Drawing.Point(12, 204);
            this.RAsistenciaFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.RAsistenciaFechaInicio.Name = "RAsistenciaFechaInicio";
            this.RAsistenciaFechaInicio.Size = new System.Drawing.Size(268, 22);
            this.RAsistenciaFechaInicio.TabIndex = 22;
            // 
            // labelRAsistenciaBuscar
            // 
            this.labelRAsistenciaBuscar.AutoSize = true;
            this.labelRAsistenciaBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.labelRAsistenciaBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAsistenciaBuscar.ForeColor = System.Drawing.Color.White;
            this.labelRAsistenciaBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelRAsistenciaBuscar.Location = new System.Drawing.Point(68, 25);
            this.labelRAsistenciaBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRAsistenciaBuscar.Name = "labelRAsistenciaBuscar";
            this.labelRAsistenciaBuscar.Size = new System.Drawing.Size(87, 23);
            this.labelRAsistenciaBuscar.TabIndex = 25;
            this.labelRAsistenciaBuscar.Text = "Buscar :";
            // 
            // c_reporte_asistencia_docenteTableAdapter
            // 
            this.c_reporte_asistencia_docenteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAsitencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 650);
            this.Controls.Add(this.panelRAsistenciaVertical);
            this.Controls.Add(this.panelRAsistenciaVertical2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteAsitencia";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteAsitencia";
            this.Load += new System.EventHandler(this.ReporteAsitencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_reporte_asistencia_docenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteAsistencia)).EndInit();
            this.panelRAsistenciaVertical2.ResumeLayout(false);
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
        //private ReporteAsistencia ReporteAsistencia;
        //private ReporteAsistenciaTableAdapters.c_reporte_asistencia_docenteTableAdapter c_reporte_asistencia_docenteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource c_reporte_asistencia_docenteBindingSource;
        private ReporteAsistencia ReporteAsistencia;
        private ReporteAsistenciaTableAdapters.c_reporte_asistencia_docenteTableAdapter c_reporte_asistencia_docenteTableAdapter;
        //private Inicio.ReporteAsistencia ReporteAsistencia;
        //private ReporteAsistenciaTableAdapters.c_reporte_asistencia_docenteTableAdapter c_reporte_asistencia_docenteTableAdapter;
    }
}