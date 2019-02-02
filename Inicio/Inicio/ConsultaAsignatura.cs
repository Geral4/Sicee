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
    public partial class ConsultaAsignatura : Form
    {
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
           "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "", sql = "";
        private DataTable table = new DataTable("Carreras");

        public ConsultaAsignatura()
        {
            InitializeComponent();
            dataGridCAsignatura.AllowUserToAddRows = true;
            dataGridCAsignatura.AllowUserToDeleteRows = true;
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

        private void textCAsignaturaBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCAsignaturaBuscar.Text;
            dataGridCAsignatura.DataSource = bindingSource1;
            GetData("select * from Asignatura where Nombre like '" + filtrado + "%' or Clave like '"
                + filtrado + "%' or Carrera_id like '" + filtrado + "%' or Creditos like '"
                + filtrado + "%' or Modalidad like '" + filtrado + "%';");

        }

        private void buttonCAsignaturaEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCAsignatura.RowCount == 2)
                {
                    this.Validate();
                    bindingSource1.EndEdit();
                    dataAdapter.Update((DataTable)bindingSource1.DataSource);
                    GetData(dataAdapter.SelectCommand.CommandText);
                    MessageBox.Show("Editado Correctamente");
                }
                else
                {
                    MessageBox.Show("Solo puedes editar un registro a la vez", "Atención");
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show("" + s, "Verifica");
            }
        }

        private void buttonCAsignaturaEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCAsignatura.Rows.Remove(dataGridCAsignatura.CurrentRow);
                //this.Validate();
                bindingSource1.EndEdit();
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
                GetData(dataAdapter.SelectCommand.CommandText);
                MessageBox.Show("Eliminado Correctamente");

            }
            catch (SqlException s)
            {
                MessageBox.Show("" + s, "Verifica");
            }
        }

        private void ConsultaAsignatura_Load(object sender, EventArgs e)
        {           
             dataGridCAsignatura.DataSource = bindingSource1;
                       
            try
            {
                Carrera.DataSource = ObtenerCarrera();
                Carrera.DisplayMember = "Nombre";
                Carrera.ValueMember = "Clave";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Excepción producida");
            }
            GetData("select * from Asignatura");
        }


        private DataTable ObtenerCarrera()
        {
            try
            {
                sql = "select Clave, Nombre from Carrera order by Nombre";
                dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
                dataAdapter.Fill(table);
            }
            catch (SqlException sq)
            {
                MessageBox.Show("" + sq, "Excepción producida");
            }
            return table;
        }
    }
}
