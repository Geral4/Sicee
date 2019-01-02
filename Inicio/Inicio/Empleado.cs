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
            comboEmpleadoCargo.ValueMember = "Clave";
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
                    Convert.ToInt32(comboEmpleadoCargo.SelectedValue),
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

    }
}
