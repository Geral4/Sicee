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
using DPFP;

namespace Inicio
{
    public partial class ConsultaEmpleado : Form
    {
        CDEmpleado objEmpleado2 = new CDEmpleado();

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
           "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable("Cargos");
        private string filtrado = "", sql = "";
        private DPFP.Template Template;
        private consultasSQL con = new consultasSQL();

        //PruebaSet dataSet = new PruebaSet();
        // CNEmpleado objEmple2=new CNEmpleado();
        public ConsultaEmpleado()
        {
            InitializeComponent();
            dataGridCEmpleado.AllowUserToAddRows = true;
            dataGridCEmpleado.AllowUserToDeleteRows = true;
            con.conectarRemoto("Sicee", "geralmiguel", "tecnologico01", "192.168.0.24");
            //dataGridCEmpleado.Dock = DockStyle.Fill;

        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;

                //btnAgregar.Enabled = (Template != null);

                if (Template != null)
                {

                    Registra_Huella();

                }
                else
                {
                    MessageBox.Show("Huella no válida, inténtelo de nuevo");
                }
            }));
        }

        private void ConsultaEmpleado_Load(object sender, EventArgs e)
        {

            try
            {
                Cargo.DataSource = ObtenerCargo();
                Cargo.DisplayMember = "Nombre";
                Cargo.ValueMember = "Clave";
                dataGridCEmpleado.DataSource = bindingSource1;
                GetData("select NPersonal, Nombre, ApellidoP, ApellidoM, Telefono, Sexo, Direccion, Cargo_id, Email from Empleado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Excepción producida");
            }

            //conexion.CerrarConexion();
            //GetData(dataAdapter.SelectCommand.CommandText);
            //MostrarEmpleado();
        }

        private void buttonCEmpleadoEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCEmpleado.RowCount == 2)
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

        private DataTable ObtenerCargo()
        {
            try
            {
                sql = "select Clave, Nombre from Cargo order by Nombre";
                dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
                dataAdapter.Fill(table);
            }
            catch (SqlException sq)
            {
                MessageBox.Show("" + sq, "Excepción producida");
            }
            return table;
        }

        private void textCEmpleadoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCEmpleadoBuscar.Text;
            dataGridCEmpleado.DataSource = bindingSource1;
            GetData("select NPersonal, Nombre, ApellidoP, ApellidoM, Telefono, Sexo, Direccion, Cargo_id, Email from Empleado where NPersonal like '" + filtrado + "%' or Nombre like '" +
                 filtrado + "%' or ApellidoP like '" + filtrado + "%' or ApellidoM like '" + filtrado + "%';");

        }

        private void dataGridCEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CapturarHuella capturaH = new CapturarHuella();
            capturaH.OnTemplate += this.OnTemplate;
            capturaH.TopMost = true;
            capturaH.ShowDialog();
        }

        private void buttonCEmpleadoEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCEmpleado.Rows.Remove(dataGridCEmpleado.CurrentRow);
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


        private void Button_editarHuella(Object sender, System.EventArgs e)
        {
            
        }

        private void ConsultaEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.cerrar();
        }

        private void Registra_Huella()
        {
            byte[] huella_correcta = Template.Bytes;
            string huella_lista = BitConverter.ToString(huella_correcta);


            con.GuardaHuella(huella_correcta, dataGridCEmpleado.Rows[dataGridCEmpleado.CurrentRow.Index].Cells[1].Value.ToString());

            Template = null;

            MessageBox.Show("Proceso terminado, cierre la ventana activa para continuar con otro registro", "Registro de Huella Digital");

        }

    }
}