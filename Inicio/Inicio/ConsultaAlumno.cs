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
    public partial class ConsultaAlumno : Form
    {
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
          "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "", sql = "";

        public ConsultaAlumno()
        {
            InitializeComponent();

            dataGridCAlumno.AllowUserToAddRows = true;
            dataGridCAlumno.AllowUserToDeleteRows = true;
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

        private void textCAlumnoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCAlumnoBuscar.Text;
            dataGridCAlumno.DataSource = bindingSource1;
            GetData("select * from Alumno where Nombre like '" + filtrado + "%' or ApellidoP like '"
                + filtrado + "%' or ApellidoM like '" + filtrado + "%' or NControl like '"
                + filtrado + "%' or CURP like '" + filtrado + "%';");

        }

        

        private void buttonCAlumnoEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCAlumno.Rows.Remove(dataGridCAlumno.CurrentRow);
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

        private void buttonCAlumnoEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCAlumno.RowCount == 2)
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

        private void ConsultaAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridCAlumno.DataSource = bindingSource1;
                GetData("select * from Alumno");
            }          catch (DataException ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }

        }
    }
}
