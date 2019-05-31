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
    public partial class ConsultaPrestamo : Form
    {
        private Validar val = new Validar();
        public ConsultaPrestamo()
        {
            InitializeComponent();
        }

        private void panelCPrestamoVertical2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ConsultaPrestamo_Load(object sender, EventArgs e)
        {
            string sentencia = "select Folio, prestado_a, prestado_a_nombre, fecha_prestamo, fecha_entrega, NSerie_id, Nombre, " +
                " Observaciones, devuelto from c_prestamos order by folio";
            dataGridCPrestamo.DataSource = val.llenarDataGrid(sentencia);
        }

        private void buttonCPrestamoBuscar_Click(object sender, EventArgs e)
        {
            string folio = "";
            folio = textCPrestamoFolio.Text;

            if (folio.Equals(""))
                folio = "%";

            string sentencia = "select Folio, prestado_a, prestado_a_nombre, fecha_prestamo, fecha_entrega, NSerie_id, Nombre, " +
                " Observaciones, devuelto from c_prestamos where Folio like '" + folio +"' order by folio";
            dataGridCPrestamo.DataSource = val.llenarDataGrid(sentencia);
        }
    }
}
