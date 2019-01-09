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
    public partial class Carrera : Form
    {   
        CDCarrera objCarrera = new CDCarrera();

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";

        public Carrera()
        {
            InitializeComponent();
        }

        private void textCarreraNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);

        }

        private void Carrera_Load(object sender, EventArgs e)
        {
            MostrarCarrera();
        }

        private void buttonCarreraGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objCarrera.insertarCarrera(
                    textCarreraClave.Text,
                    textCarreraNombre.Text,
                    textCarreraDescripcion.Text
                    );
                MessageBox.Show("Insertado Correctamente");
                MostrarCarrera();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede insertar los datos por: " + ex);
            }
        }


        private void MostrarCarrera()
        {
            CDCarrera objCarrera1 = new CDCarrera();
            dataGridViewCarrera.DataSource = objCarrera1.MostrarCarrera();
        }

        private void textCarreraBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCarreraBuscar.Text;
            dataGridViewCarrera.DataSource = bindingSource1;
            GetData("select * from Carrera where Clave like '" + filtrado + "%' or Nombre like '" + filtrado + "%';");

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
