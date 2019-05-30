using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class ReporteAsitencia : Form
    {
        private DateTime fchaI, fchaF;
        private BindingSource x = null;
        private Validar v = new Validar();

        public ReporteAsitencia()
        {
            InitializeComponent();
        }

        private void panelEmpleadoVertical2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReporteAsitencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteAsistencia.c_reporte_asistencia_docente' Puede moverla o quitarla según sea necesario.
            //this.c_reporte_asistencia_docenteTableAdapter.Fill(this.ReporteAsistencia.c_reporte_asistencia_docente);
            // TODO: esta línea de código carga datos en la tabla 'ReporteAsistencia.c_reporte_asistencia_docente' Puede moverla o quitarla según sea necesario.
            //this.c_reporte_asistencia_docenteTableAdapter.Fill(this.ReporteAsistencia.c_reporte_asistencia_docente);
            // TODO: esta línea de código carga datos en la tabla 'ReporteAsistencia.c_reporte_asistencia_docente' Puede moverla o quitarla según sea necesario.
            //this.c_reporte_asistencia_docenteTableAdapter.Fill(this.ReporteAsistencia.c_reporte_asistencia_docente);
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonRAsistenciaGenerar_Click(object sender, EventArgs e)
        {
            string clave = "";

            clave = RAsistenciaNPersonal.Text.ToUpper();

            //x = new BindingSource();

            fchaI = new DateTime(RAsistenciaFechaInicio.Value.Year, RAsistenciaFechaInicio.Value.Month, RAsistenciaFechaInicio.Value.Day, 0, 0, 0);
            fchaF = new DateTime(RAsistenciaFechaFin.Value.Year, RAsistenciaFechaFin.Value.Month, RAsistenciaFechaFin.Value.Day, 23, 59, 59);
            

            if (clave.Equals(""))
            {
                clave = "%";
            }

            this.c_reporte_asistencia_docenteTableAdapter.Fill(this.ReporteAsistencia.c_reporte_asistencia_docente, clave, fchaI, fchaF);

            //this.c_reporte_asistencia_docenteTableAdapter.Fill((ReporteAsistencia.c_reporte_asistencia_docenteDataTable) v.origen_registr("select * from c_reporte_asistencia_docente"), clave, fchaI, fchaF);
            this.reportViewer1.RefreshReport();
        }
    }
}
