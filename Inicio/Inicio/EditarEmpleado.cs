using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaDatos;

namespace Inicio
{
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado()
        {
            InitializeComponent();
            comboEEmpleadoSexo.Items.Add("Femenino");
            comboEEmpleadoSexo.Items.Add("Masculino");

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        CDEmpleado objEEmpleado = new CDEmpleado();

   


        private void buttonCargoCancelar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelCEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void ListarCargo()
        {
            CDEmpleado objEmpleado1 = new CDEmpleado();
            comboEEmpleadoCargo.DataSource = objEmpleado1.ListarCargo();
            comboEEmpleadoCargo.DisplayMember = "Nombre";
            comboEEmpleadoCargo.ValueMember = "Clave";
        }

        private void buttonEEmpleadoGuardar_Click(object sender, EventArgs e)
        {
            objEEmpleado.editarEmpleado(
                textEEmpleadoNPersonal.Text,
                textEEmpleadoNombre.Text,
                textEEmpleadoApellidosP.Text,
                textEEmpleadoApellidoM.Text,
                textEEmpleadoTelefono.Text,
                comboEEmpleadoSexo.Text,
                textEEmpleadoDireccion.Text,
                comboEEmpleadoCargo.Text,
                textEEmpleadoEmail.Text);
            
            MessageBox.Show("Se edito Correctamente");
            this.Close();
        }

        private void buttonEEmpleadoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboEEmpleadoCargo_MouseCaptureChanged(object sender, EventArgs e)
        {
            ListarCargo();
        }
    }
}
