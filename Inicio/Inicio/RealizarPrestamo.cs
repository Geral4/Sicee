using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Inicio
{
    public partial class RealizarPrestamo : Form
    {
        CDPrestamo objPrestamo = new CDPrestamo();
        CDUsuario objEmpleado = new CDUsuario();
        Validar funciones = new Validar();
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
        "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable("Alumno");
        private string filtrado = "", sql = "";


        public RealizarPrestamo()
        {
            InitializeComponent();
        }

        private void radioRealizarPAlumno_Click(object sender, EventArgs e)
        {
            if (radioRealizarPAlumno.Checked)
            {
                ListarAlumno();
            }
            else
            {
                ListarNPersonal();
            }
        }
        private void radioRealizarPEmpleado_Click(object sender, EventArgs e)
        {
            if (radioRealizarPEmpleado.Checked)
            {
                ListarNPersonal();
            }
            else
            {
                ListarAlumno();
            }
        }


        private void RealizarPrestamo_Load(object sender, EventArgs e)
        {

            sql = "select NSerie, (Nserie + ' - '+ Nombre) as Inmueble from Inmueble";
            funciones.llenarComboDGSQL(sql, NSerie, "Nserie", "Inmueble");
            dataGridRP.AllowUserToDeleteRows = false;
            dataGridRP.AllowUserToAddRows = false;
            textRealizarPFolio.Text = objPrestamo.obtenerFolio() + "";
        }

        private void ListarAlumno()
        {
                comboRealizarPNumero.DataSource = objPrestamo.ListarAlumno();
                comboRealizarPNumero.DisplayMember = "Nombre";
                comboRealizarPNumero.ValueMember = "NControl";       
        }

        private void buttonRealizarPContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioRealizarPAlumno.Checked)
                {
                    objPrestamo.insertarPrestamo(
                    objPrestamo.obtenerFolio(),
                    1,
                    0,
                    comboRealizarPNumero.SelectedValue.ToString(),
                    "",
                    dateRealizarPFechaE.Value,
                    Convert.ToInt32( numericRealizarPNPrestamos.Value)                   
                    );
                }
                
                else
                {
                    objPrestamo.insertarPrestamo(
                    objPrestamo.obtenerFolio(),
                    0,
                    1,
                    "",
                    comboRealizarPNumero.SelectedValue.ToString(),
                    dateRealizarPFechaE.Value,
                    Convert.ToInt32(numericRealizarPNPrestamos.Value)
                    );
                }
                MessageBox.Show("Insertado Correctamente");
                sql = "select id_PI, Folio_id, numero, NSerie_id, Observaciones from PrestamoInmueble where " +
                    "Folio_id = "+ textRealizarPFolio.Text +"";
                dataGridRP.DataSource= funciones.llenarDataGrid(sql);
                // Actualizar el origne de datos del data grid con la consulta 
                //select numero, Nserie_id + '-' + Nombre Nombre_Inmueble, Observaciones from PrestamoInmueble where Folio_id = "+  Convert.ToInst32(txt.Text) +"
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede insertar los datos por: " + ex);
            }


        }

        private void comboRealizarPNumero_SelectedValueChanged(object sender, EventArgs e)
        {
            textRealizarPNombre.Text = comboRealizarPNumero.SelectedValue.ToString();
        }

        private void buttonRealizarPGuardar_Click(object sender, EventArgs e)
        {
            funciones.EditarDataGrid(dataGridRP);
            textRealizarPFolio.Text = objPrestamo.obtenerFolio() + "";
        }

        private void ListarNPersonal()
        {
            comboRealizarPNumero.DataSource = objEmpleado.ListarNPersonal();
            comboRealizarPNumero.DisplayMember = "Nombre";
            comboRealizarPNumero.ValueMember = "NPersonal";
        }



}
}
