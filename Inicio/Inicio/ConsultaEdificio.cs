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
    public partial class ConsultaEdificio : Form
    {

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
         "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "", sql = "";


        public ConsultaEdificio()
        {
            InitializeComponent();
            dataGridCEdificio.AllowUserToAddRows = true;
            dataGridCEdificio.AllowUserToDeleteRows = true;
        }

        private void ConsultaEdificio_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridCEdificio.DataSource = bindingSource1;
                GetData("select * from Edificio");
            }
            catch (DataException ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }          
        }

        private void buttonCEdificioEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridCEdificio.RowCount == 2)
                {
                    this.Validate();
                    bindingSource1.EndEdit();
                    dataAdapter.Update((DataTable)bindingSource1.DataSource);
                    GetData(dataAdapter.SelectCommand.CommandText);
                    MessageBox.Show("Editado Correctamente");
                }
                else
                {
                    MessageBox.Show("Solo puedes editar un registro a la vez.    Busca el registro a editar", "Atención");
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show("" + s, "Verifica");
            }
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

        private void buttonCEdificioEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCEdificio.Rows.Remove(dataGridCEdificio.CurrentRow);
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

        private void textCEdificioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCEdificioBuscar.Text;
            dataGridCEdificio.DataSource = bindingSource1;
            GetData("select * from Edificio where Nombre like '" + filtrado + "%' or Clave like '" 
                +filtrado + "%' or nAulas like '" + filtrado + "%';");

        }
    }
}
