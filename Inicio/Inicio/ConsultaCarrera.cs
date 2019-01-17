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
    public partial class ConsultaCarrera : Form
    {

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
         "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "", sql = "";


        public ConsultaCarrera()
        {
            InitializeComponent();
            dataGridCCarrera.AllowUserToAddRows = true;
            dataGridCCarrera.AllowUserToDeleteRows = true;
        }

        private void ConsultaCarrera_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridCCarrera.DataSource = bindingSource1;
                GetData("select * from Carrera");
            }
            catch (DataException ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }
        }


        private void textCCarreraBuscar_TextChanged(object sender, EventArgs e)
        {

            filtrado = textCCarreraBuscar.Text;
            dataGridCCarrera.DataSource = bindingSource1;
            GetData("select * from Carrera where Clave like '" + filtrado + "%' or Nombre like '" + filtrado + "%';");

        }

        private void buttonCCarreraEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCCarrera.RowCount == 2)
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



        private void buttonCCarreraEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCCarrera.Rows.Remove(dataGridCCarrera.CurrentRow);
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
    }
}
