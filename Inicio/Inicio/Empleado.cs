using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Data.SqlClient;

namespace Inicio
{
    public partial class Empleado : Form
    {
       CDEmpleado objEmpleado = new CDEmpleado();
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";
        public Empleado()
        {
            InitializeComponent();
            comboEmpleadoSexo.Items.Add("Femenino");
            comboEmpleadoSexo.Items.Add("Masculino");
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            ListarCargo();
            MostrarEmpleado();
        }

        private void textEmpleadoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e); }

        private void textEmpleadoApellidosP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textEmpleadoApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textEmpleadoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void ListarCargo()
        {
            CDEmpleado objEmpleado1 = new CDEmpleado();
            comboEmpleadoCargo.DataSource = objEmpleado1.ListarCargo();
            comboEmpleadoCargo.DisplayMember = "Nombre";
            comboEmpleadoCargo.DisplayMember = "Clave";
        }

        private void buttonEmpleadoGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objEmpleado.insertarEmpleado(
                    textEmpleadoNPersonal.Text,
                    textEmpleadoNombre.Text,
                    textEmpleadoApellidosP.Text,
                    textEmpleadoApellidoM.Text,
                    textEmpleadoTelefono.Text,
                    comboEmpleadoSexo.Text,
                    textEmpleadoDireccion.Text,
                    comboEmpleadoCargo.Text,
                    textEmpleadoEmail.Text
                    );
                MessageBox.Show("Insertado Correctamente");
                MostrarEmpleado();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se puede insertar los datos por: " + ex);
            }
        }

        private void MostrarEmpleado()
        {
            CDEmpleado objEmpleado2 = new CDEmpleado();
            dataGridEmpleado.DataSource = objEmpleado2.MostrarEmpleado();
        }

        private void textEmpleadoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textEmpleadoBuscar.Text;
            dataGridEmpleado.DataSource = bindingSource1;            
            GetData("select * from Empleado where NPersonal like '" + filtrado + "%' or Nombre like " +
                "'" + filtrado +   "%' or ApellidoP like '" +filtrado +  "%' or ApellidoM like '" + filtrado +  "%';");

        }
        private void GetData(string sql)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                // dataGridCEmpleado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción: " + ex);
            }

        }

        private void dataGridEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
