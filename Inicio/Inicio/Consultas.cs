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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void buttonConsultaAlumno_Click(object sender, EventArgs e)
        {
            ConsultaAlumno formConsultaAlumno = new ConsultaAlumno();
            formConsultaAlumno.ShowDialog();
        }


        private void buttonConsultaEmpleado_Click(object sender, EventArgs e)
        {
            ConsultaEmpleado formConsultaEmpleado = new ConsultaEmpleado();
            formConsultaEmpleado.ShowDialog();
        }

        private void buttonConsultaUsuario_Click(object sender, EventArgs e)
        {
            ConsultaUsuario formConsultaUsuario = new ConsultaUsuario();
            formConsultaUsuario.ShowDialog();
        }

        private void buttonConsultaCargo_Click(object sender, EventArgs e)
        {
            ConsultaCargo formConsultaCargo = new ConsultaCargo();
            formConsultaCargo.ShowDialog();
        }
        

        private void buttonConsultaInmueble_Click(object sender, EventArgs e)
        {
            ConsultaInmueble formConsultaInmueble = new ConsultaInmueble ();
            formConsultaInmueble.ShowDialog();            
        }

        private void buttonConsultaCarrera_Click(object sender, EventArgs e)
        {
            ConsultaCarrera formConsultaCarrera = new ConsultaCarrera();
            formConsultaCarrera.ShowDialog();
        }

        private void buttonConsultaAsignatura_Click(object sender, EventArgs e)
        {
            ConsultaAsignatura formConsultaAsignatura = new ConsultaAsignatura();
            formConsultaAsignatura.ShowDialog();
        }

        
        private void buttonConsultaPrestamo_Click(object sender, EventArgs e)
        {
            ConsultaPrestamo formConsultaPrestamo = new ConsultaPrestamo();
            formConsultaPrestamo.ShowDialog();
        }

        private void buttonConsultaEdificio_Click(object sender, EventArgs e)
        {
            ConsultaEdificio formConsultaEdificio = new ConsultaEdificio();
            formConsultaEdificio.ShowDialog();
        }
        
        private void buttonConsultaHorario_Click(object sender, EventArgs e)
        {
            ConsultaLaboral formConsultaLaboral = new ConsultaLaboral();
            formConsultaLaboral.ShowDialog();
        }

        private void buttonConsultaCambio_Click(object sender, EventArgs e)
        {
            ModificacionCambio formModificacionCambio = new ModificacionCambio();
            formModificacionCambio.ShowDialog();
        }
    }
}
