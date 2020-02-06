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
    public partial class EditarCargo : Form
    {
        CDCargo objECargo = new CDCargo();


        public EditarCargo()
        {
            InitializeComponent();
            comboECargoDepartamento.Items.Add("Administrativo");
            comboECargoDepartamento.Items.Add("Academico");
            //Departamento.Items.Add("Académico");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        private void buttonCargoCancelar_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void EditarCargo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelEmpleadoVertical2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelEmpleadoVertical2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCargoGuardar_Click(object sender, EventArgs e)
        {
            objECargo.editarCargo(
            textECargoClave.Text,
            textECargoNombre.Text,
            textECargoDescripcion.Text,
            comboECargoDepartamento.Text);

            MessageBox.Show("Se edito Correctamente");
            this.Close();
            
                        
        }



        private void textECargoDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
