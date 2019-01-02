using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;

namespace Inicio
{
    public partial class ConsultaEmpleado : Form
    {
        CDEmpleado objEmpleado2 = new CDEmpleado();
        CDConexion conexion = new CDConexion();
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        //PruebaSet dataSet = new PruebaSet();
        // CNEmpleado objEmple2=new CNEmpleado();
        public ConsultaEmpleado()
        {
            InitializeComponent();
            dataGridCEmpleado.AllowUserToAddRows = true;
            dataGridCEmpleado.AllowUserToDeleteRows = true;
            //dataGridCEmpleado.Dock = DockStyle.Fill;

        }

        private void ConsultaEmpleado_Load(object sender, EventArgs e)
        {

            dataGridCEmpleado.DataSource = bindingSource1;
            GetData("select * from Empleado");
            //conexion.CerrarConexion();
            //GetData(dataAdapter.SelectCommand.CommandText);
            //MostrarEmpleado();
        }

        private void buttonCEmpleadoEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bindingSource1.EndEdit();
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
                GetData(dataAdapter.SelectCommand.CommandText);
            }
            catch (SqlException s)
            {
                MessageBox.Show("" + s, "Verifica");
            }
        }

        private void MostrarEmpleado()
        {
            CDEmpleado objEmple2 = new CDEmpleado();
            //dataGridCEmpleado.DataSource = objEmple2.MostrarEmpleado();
            //dataGridCEmpleado.DataSource = dataSet.Empleado;


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

        private void dataGridCEmpleado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridCEmpleado_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridCEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridCEmpleado_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridCEmpleado_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}