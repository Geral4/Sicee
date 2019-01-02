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

namespace Inicio
{
    public partial class Asignatura : Form
    {
        CDAsignatura objAsignatura = new CDAsignatura();
        public Asignatura()
        {
            InitializeComponent();
            comboAsignaturaModalidad.Items.Add("Escolarizado");
            comboAsignaturaModalidad.Items.Add("No escolarizado");
            comboAsignaturaModalidad.Items.Add("Mixto");

        }

        private void labelAsignaturaRegistro_Click(object sender, EventArgs e)
        {

        }

        private void panelAsignaturaVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Asignatura_Load(object sender, EventArgs e)
        {
            ListarCarrera();
            MostrarAsignatura();
     
        }
        private void ListarCarrera()
        {
            CDAsignatura objAsignatura1 = new CDAsignatura();
            comboAsignaturaCarrera.DataSource= objAsignatura1.ListarCarrera();
            comboAsignaturaCarrera.DisplayMember = "Nombre";
            comboAsignaturaCarrera.ValueMember = "Clave";

        }

        private void textAsignaturaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void buttonAsignaturaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objAsignatura.insertarAsignatura(
                    textAsignaturaNombre.Text,
                    textAsignaturaClave.Text,
                    Convert.ToInt32(comboAsignaturaCarrera.SelectedValue),
                    Convert.ToInt32( numericAsignatura.Value),
                    comboAsignaturaModalidad.Text
                    );
                MessageBox.Show("Insertado Correctamente");
                MostrarAsignatura();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede insertar los datos por: " + ex);
            }
        }

        private void MostrarAsignatura()
        {
            CDAsignatura objAsignatura2 = new CDAsignatura();
            dataGridViewAsignatura.DataSource = objAsignatura2.MostrarAsignatura();
        }
    }
}
