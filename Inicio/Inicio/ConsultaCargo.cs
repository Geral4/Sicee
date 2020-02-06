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
    public partial class ConsultaCargo : Form
    {
        CDCargo objCCargo = new CDCargo();
        

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
          "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "", sql = "";

        public ConsultaCargo()
        {
            InitializeComponent();
            dataGridCCargo.AllowUserToAddRows = true;
            dataGridCCargo.AllowUserToDeleteRows = true;
            
        }

        private void panelCCargoVertical_Paint(object sender, PaintEventArgs e)
        {

        }
        public void MostrarCargo()
        {
            CDCargo objCar = new CDCargo();
            dataGridCCargo.DataSource = objCar.MostrarCargo();
        }

        


        private void ConsultaCargo_Load(object sender, EventArgs e)
        {
            //   MostrarCargo();
            try
            {
                //Departamento.Items.Add("Administrativo");
                //Departamento.Items.Add("Académico");
                dataGridCCargo.DataSource = bindingSource1;
                GetData("select * from Cargo");
            }
            catch (DataException ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }

        }

        private void buttonCCargoEditar_Click(object sender, EventArgs e)
        {
            if (dataGridCCargo.SelectedRows.Count > 0)
            {
                EditarCargo formEditarCargo = new EditarCargo();
                formEditarCargo.textECargoClave.Text = dataGridCCargo.CurrentRow.Cells[0].Value.ToString();
                formEditarCargo.textECargoNombre.Text = dataGridCCargo.CurrentRow.Cells[1].Value.ToString();
                formEditarCargo.textECargoDescripcion.Text = dataGridCCargo.CurrentRow.Cells[2].Value.ToString();
                formEditarCargo.comboECargoDepartamento.Text = dataGridCCargo.CurrentRow.Cells[3].Value.ToString();
  
                formEditarCargo.ShowDialog();
                MostrarCargo();

            }
            else
                MessageBox.Show("Debe seleccionar una fila");
          
            //EditarCargo formCargo = new EditarCargo();
            //formCargo.Show();

            //try
            //{
            //    if (dataGridCCargo.RowCount == 2)
            //    {
            //        this.Validate();
            //        bindingSource1.EndEdit();
            //        dataAdapter.Update((DataTable)bindingSource1.DataSource);
            //        GetData(dataAdapter.SelectCommand.CommandText);
            //        MessageBox.Show("Editado Correctamente");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Solo puedes editar un registro a la vez.    Busca el registro a editar" , "Atención");
            //    }
            //}
            //catch (SqlException s)
            //{
            //    MessageBox.Show("" + s, "Verifica");
            //}




        }

        private void textCCargoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCCargoBuscar.Text;
            dataGridCCargo.DataSource = bindingSource1;
            GetData("select * from Cargo where Clave like '" 
                + filtrado + "%' or Nombre like '" + filtrado + "%';");

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

        private void dataGridCCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCCargoEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCCargo.Rows.Remove(dataGridCCargo.CurrentRow);
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
