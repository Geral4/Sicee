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
    public partial class Alumno : Form
    {
        CDAlumno objAlumno = new CDAlumno();

        CDCargo objCargo = new CDCargo();
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";

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
                   comboAlumnoCarrera.SelectedValue.ToString(),
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
            textAlumnoNombre.Clear();
            textAlumnoApellidoP.Clear();
            textAlumnoApellidoM.Clear();
            textAlumnoCurp.Clear();
            textAlumnoDireccion.Clear();
            textAlumnoNControl.Clear();
            textAlumnoTelefono.Clear();
            comboAlumnoCarrera.Text = string.Empty;
            comboAlumnoSemestre.Text = string.Empty;
            comboAlumnoSexo.Text = string.Empty;
        }

        private void MostrarAlumno()
        {
            CDAlumno objAlumno2 = new CDAlumno();
            dataGridAlumno.DataSource = objAlumno2.MostrarAlumno();
        }

        private void textAlumnoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textAlumnoBuscar.Text;
            dataGridAlumno.DataSource = bindingSource1;
            GetData("select * from Alumno where NControl like '" + filtrado + "%' or Nombre like '" +
                   filtrado + "%' or ApellidoP like '" + filtrado + "%' or ApellidoM like '" + filtrado + "%';");

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
        

        private void comboAlumnoCarrera_MouseClick(object sender, MouseEventArgs e)
        {
            ListarCarrera();
        }

        private void buttonAlumnoCancelar_Click(object sender, EventArgs e)
        {
            textAlumnoNombre.Clear();
            textAlumnoApellidoP.Clear();
            textAlumnoApellidoM.Clear();
            textAlumnoCurp.Clear();
            textAlumnoDireccion.Clear();
            textAlumnoNControl.Clear();
            textAlumnoTelefono.Clear();
            comboAlumnoCarrera.Text = string.Empty;
            comboAlumnoSemestre.Text = string.Empty;
            comboAlumnoSexo.Text = string.Empty;

        }
    }
}
