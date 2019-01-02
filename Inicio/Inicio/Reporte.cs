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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }            
        
        private void buttonReporteAsistencia_Click(object sender, EventArgs e)
        {
            ReporteAsitencia formReporteAsitencia = new ReporteAsitencia();
            formReporteAsitencia.ShowDialog();
        }

        private void buttonReporteInmobiliario_Click(object sender, EventArgs e)
        {
            ReporteInmobiliario formReporteInmobiliario = new ReporteInmobiliario();
            formReporteInmobiliario.ShowDialog();
        }

        private void buttonReportePrestamos_Click(object sender, EventArgs e)
        {
            ReportePrestamos formReportePrestamos = new ReportePrestamos();
            formReportePrestamos.ShowDialog();
         
        }

        private void buttonReporteBitacora_Click(object sender, EventArgs e)
        {
            ReporteBitacora formReporteBitacora = new ReporteBitacora();
            formReporteBitacora.ShowDialog();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }

        
    }
}
