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
    public partial class ConsultaInmueble : Form
    {

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
          "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "", sql = "";

        public ConsultaInmueble()
        {
            InitializeComponent();
            dataGridCInmueble.AllowUserToAddRows = true;
            dataGridCInmueble.AllowUserToDeleteRows = true;
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

        private void ConsultaInmueble_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridCInmueble.DataSource = bindingSource1;
                GetData("select * from Inmueble");
            }
            catch (DataException ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }
        }

        private void buttonCInmuebleEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCInmueble.RowCount == 2)
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

        private void buttonCInmuebleEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCInmueble.Rows.Remove(dataGridCInmueble.CurrentRow);
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

        private void textCInmuebleBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCInmuebleBuscar.Text;
            dataGridCInmueble.DataSource = bindingSource1;
            GetData("select * from Inmueble where Marca like '" + filtrado + "%' or Nombre like '" + filtrado + "%' or Modelo like '"
                + filtrado + "%' or  NSerie like '" + filtrado + "%' or Aula like '" + filtrado + "%';");
        }
    }
}
