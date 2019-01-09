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
    public partial class Asignatura : Form
    {
        CDAsignatura objAsignatura = new CDAsignatura();

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
          "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";


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
                    comboAsignaturaCarrera.SelectedValue.ToString(),
                    Convert.ToInt32(numericAsignatura.Value),
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

        private void textAsignaturaBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textAsignaturaBuscar.Text;
            dataGridViewAsignatura.DataSource = bindingSource1;
            GetData("select * from Asignatura where Nombre like '" + filtrado + "%' or Clave like '"  + filtrado + "%' or Creditos like '" + filtrado + "%';");

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
    }
}
