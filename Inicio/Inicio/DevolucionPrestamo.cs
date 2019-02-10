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
    public partial class DevolucionPrestamo : Form
    {
        Validar funciones = new Validar();
        private BindingSource bindingSource1 = new BindingSource();
        private string sql = "";


        public DevolucionPrestamo()
        {
            InitializeComponent();
        }

        private void DevolucionPrestamo_Load(object sender, EventArgs e)
        {
            sql = "select Folio, iif(es_alumno = 1, NControl, NPersonal) identi," +
                " iif(es_usuario = 1, (emp.Nombre + ' ' + emp.ApellidoP + ' ' + emp.ApellidoM), " +
                "(al.Nombre + ' ' + al.ApellidoP + ' ' + al.ApellidoM)) Nombre_Completo, FechaP, FechaE  from Prestamo p" +
                " left outer join Alumno al on p.NControl_id = al.NControl left outer join Empleado emp on p.NPersonal_id = emp.NPersonal";        
            dataGridDevolucionP.DataSource = funciones.llenarDataGrid(sql);
        }

        private void dataGridDevolucionP_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int valor = (int)dataGridDevolucionP.CurrentCell.Value;
                if (valor > 0)
                {
                    InmueblePrestado inmuebles = new InmueblePrestado();
                    inmuebles.folio = valor;
                    inmuebles.ShowDialog();
                }
            }
            catch (SystemException caca)
            {
                Console.WriteLine("Hola" + caca);
            }
            
        }

        private void dataGridDevolucionP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
