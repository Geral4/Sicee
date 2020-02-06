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
        private string filtrado = "", sql = "";
        //private DPFP.Template Template;
        private consultasSQL con = new consultasSQL();

        //PruebaSet dataSet = new PruebaSet();
       
        public ConsultaEmpleado()
        {
            InitializeComponent();
            dataGridCEmpleado.AllowUserToAddRows = true;
            dataGridCEmpleado.AllowUserToDeleteRows = true;
            con.conectarRemoto("Sicee", "geralmiguel", "tecnologico01", "localhost");
            //dataGridCEmpleado.Dock = DockStyle.Fill;

        }

        //private void OnTemplate(DPFP.Template template)
        //{
        //    this.Invoke(new Function(delegate ()
        //    {
        //        Template = template;

        //        //btnAgregar.Enabled = (Template != null);

        //        if (Template != null)
        //        {

        //            Registra_Huella();

        //        }
        //        else
        //        {
        //            MessageBox.Show("Huella no válida, inténtelo de nuevo");
        //        }
        //    }));
        //}
        private void ConsultaEmpleado_Load_1(object sender, EventArgs e)
        {

            MostrarEmpleado();
        }

        private void buttonCEmpleadoEditar_Click(object sender, EventArgs e)
        {
            if(dataGridCEmpleado.SelectedRows.Count>0)
            {
                EditarEmpleado formEditarEmpleado = new EditarEmpleado();
                formEditarEmpleado.textEEmpleadoNPersonal.Text = dataGridCEmpleado.CurrentRow.Cells[0].Value.ToString();
                formEditarEmpleado.textEEmpleadoNombre.Text = dataGridCEmpleado.CurrentRow.Cells[1].Value.ToString();
                formEditarEmpleado.textEEmpleadoApellidosP.Text = dataGridCEmpleado.CurrentRow.Cells[2].Value.ToString();
                formEditarEmpleado.textEEmpleadoApellidoM.Text = dataGridCEmpleado.CurrentRow.Cells[3].Value.ToString();
                formEditarEmpleado.textEEmpleadoTelefono.Text = dataGridCEmpleado.CurrentRow.Cells[4].Value.ToString();
                formEditarEmpleado.comboEEmpleadoSexo.Text = dataGridCEmpleado.CurrentRow.Cells[5].Value.ToString();
                formEditarEmpleado.textEEmpleadoDireccion.Text = dataGridCEmpleado.CurrentRow.Cells[6].Value.ToString();
                formEditarEmpleado.comboEEmpleadoCargo.Text = dataGridCEmpleado.CurrentRow.Cells[7].Value.ToString();
                formEditarEmpleado.textEEmpleadoEmail.Text = dataGridCEmpleado.CurrentRow.Cells[8].Value.ToString();
                formEditarEmpleado.ShowDialog();
                MostrarEmpleado();
     
            }                      
            else
                MessageBox.Show("Debe seleccionar una fila");          

        }

        private void MostrarEmpleado()
        {
            CDEmpleado objEmplea = new CDEmpleado();
            dataGridCEmpleado.DataSource = objEmplea.MostrarEmpleado();
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

      

        private void textCEmpleadoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCEmpleadoBuscar.Text;
            dataGridCEmpleado.DataSource = bindingSource1;
            GetData("select NPersonal, Nombre, ApellidoP, ApellidoM, Telefono, Sexo, Direccion, Cargo_id, Email from Empleado where NPersonal like '" + filtrado + "%' or Nombre like '" +
                 filtrado + "%' or ApellidoP like '" + filtrado + "%' or ApellidoM like '" + filtrado + "%';");

        }

        //private void dataGridCEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    CapturarHuella capturaH = new CapturarHuella();
        //    capturaH.OnTemplate += this.OnTemplate;
        //    capturaH.TopMost = true;
        //    capturaH.ShowDialog();
        //}

        private void buttonCEmpleadoEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCEmpleado.SelectedRows.Count > 0)
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
            else
                MessageBox.Show("Debe seleccionar una fila");

        }


        private void Button_editarHuella(Object sender, System.EventArgs e)
        {
            
        }

        private void ConsultaEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.cerrar();
        }

        

        private void dataGridCEmpleado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void Registra_Huella()
        //{
        //    byte[] huella_correcta = Template.Bytes;
        //    string huella_lista = BitConverter.ToString(huella_correcta);


        //    con.GuardaHuella(huella_correcta, dataGridCEmpleado.Rows[dataGridCEmpleado.CurrentRow.Index].Cells[1].Value.ToString());

        //    Template = null;

        //    MessageBox.Show("Proceso terminado, cierre la ventana activa para continuar con otro registro", "Registro de Huella Digital");

        //}

    }
}