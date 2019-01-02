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
    public partial class Alumno : Form
    {
        CDAlumno objAlumno = new CDAlumno();
        public Alumno()
        {
            InitializeComponent();

            comboAlumnoSemestre.Items.Add("1º");
            comboAlumnoSemestre.Items.Add("2º");
            comboAlumnoSemestre.Items.Add("3º");
            comboAlumnoSemestre.Items.Add("4º");
            comboAlumnoSemestre.Items.Add("5º");
            comboAlumnoSemestre.Items.Add("6º");
            comboAlumnoSemestre.Items.Add("7º");
            comboAlumnoSemestre.Items.Add("8º");
            comboAlumnoSemestre.Items.Add("9º");
            comboAlumnoSemestre.Items.Add("10º");
            comboAlumnoSemestre.Items.Add("11º");
            comboAlumnoSemestre.Items.Add("12º");
            comboAlumnoSemestre.Items.Add("13º");

            comboAlumnoSexo.Items.Add("Femenino");
            comboAlumnoSexo.Items.Add("Masculino");

        }        

        private void textAlumnoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textAlumnoApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void texAlumnoApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textAlumnoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            ListarCarrera();
            MostrarAlumno();
        }
        private void ListarCarrera()
        {
            CDAlumno objAlumno1 = new CDAlumno();
            comboAlumnoCarrera.DataSource = objAlumno1.ListarCarrera();
            comboAlumnoCarrera.DisplayMember = "Nombre";
            comboAlumnoCarrera.ValueMember = "Clave";

        }
        

        private void buttonAlumnoGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objAlumno.insertarAlumno(
                    textAlumnoNombre.Text,
                    textAlumnoApellidoP.Text,
                   textAlumnoApellidoM.Text,
                   textAlumnoNControl.Text,
                   textAlumnoCurp.Text,
                   comboAlumnoSexo.Text,
                   Convert.ToInt32(comboAlumnoCarrera.SelectedValue),
                   comboAlumnoSemestre.Text,
                   textAlumnoDireccion.Text,
                   textAlumnoTelefono.Text
                   );
            
                MessageBox.Show("Insertado Correctamente");
                MostrarAlumno();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede insertar los datos por: " + ex);
            }
        }

        private void MostrarAlumno()
        {
            CDAlumno objAlumno2 = new CDAlumno();
            dataGridAlumno.DataSource = objAlumno2.MostrarAlumno();
        }
    }
}

