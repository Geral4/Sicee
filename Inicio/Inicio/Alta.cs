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

namespace Inicio
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }
       

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            Usuario formUsuario = new Usuario();
            formUsuario.ShowDialog();
        }

        private void buttonAlumno_Click(object sender, EventArgs e)
        {
            Alumno formAlumno = new Alumno();
            formAlumno.ShowDialog();
        }

        private void buttonEmpleado_Click(object sender, EventArgs e)
        {
            Empleado formEmpleado = new Empleado();
            formEmpleado.ShowDialog();
        }

        private void buttonAsignatura_Click(object sender, EventArgs e)
        {
            Asignatura formAsignatura = new Asignatura();
            formAsignatura.ShowDialog();
        }

        private void buttonCargo_Click(object sender, EventArgs e)
        {
            Cargo formCargo = new Cargo();
            formCargo.ShowDialog();
        }            
       

        private void buttonCarrera_Click(object sender, EventArgs e)
        {
            Carrera formCarrera = new Carrera();
            formCarrera.ShowDialog();
        }

        private void buttonEdificio_Click(object sender, EventArgs e)
        {
            Edificio formEdificio = new Edificio();
            formEdificio.ShowDialog();
        }

        private void buttonInmueble_Click(object sender, EventArgs e)
        {
            Inmueble formInmueble = new Inmueble();
            formInmueble.ShowDialog();
        }
    }
}
