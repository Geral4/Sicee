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
        private Validar v = new Validar();


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
                Refrescar();
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
                if (dataGridCEdificio.RowCount >= 2)
                {
                    this.Validate();
                    v.EditarDataGrid(dataGridCEdificio);
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Solo puedes editar un registro a la vez. Busca el registro a editar", "Atención");
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show("" + s, "Verifica");
            }
        }


        private void buttonCEdificioEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                v.EliminarDataGrid(dataGridCEdificio);
                Refrescar();
                //MessageBox.Show("Eliminado Correctamente");
            }
            catch (SqlException s)
            {
                MessageBox.Show("" + s, "Verifica");
            }
        }

        private void dataGridCEdificio_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string valor = (string)dataGridCEdificio.Rows[dataGridCEdificio.CurrentRow.Index].Cells[1].Value;


                //if (MessageBox.Show("¿Desea continuar?", "PREGUNTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                Aula1 aula1 = new Aula1();
                aula1.clave_edificio = valor;
                aula1.buttonAgregar.Visible = true;
                aula1.buttonEliminar.Visible = true;
                aula1.buttonGuardar.Visible = true;
                aula1.dataGridAula1.AllowUserToAddRows = false;
                aula1.ShowDialog();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            } 
            
        }

        private void ConsultaEdificio_Activated(object sender, EventArgs e)
        {
            Refrescar();
            Console.WriteLine("Prueba");
        }

        private void textCEdificioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCEdificioBuscar.Text;
            Refrescar();

        }

        private void Refrescar()
        {
            dataGridCEdificio.DataSource = v.llenarDataGrid("select * from Edificio where Nombre like '" + filtrado + "%' or Clave like '"
                + filtrado + "%' or nAulas like '" + filtrado + "%';");
        }
    }
}
