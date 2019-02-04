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
    public partial class ConsultaUsuario : Form
    {
        CDUsuario objUsuario3 = new CDUsuario();
      //  CNUsuario objUsuario4 = new CNUsuario();

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
          "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "", sql = "";
        private DataTable table = new DataTable("Empleado");

        public ConsultaUsuario()
        {
            InitializeComponent();
            //comboCUsuarioAcceso.Items.Add("Administrador");
            //comboCUsuarioAcceso.Items.Add("Asesor");
            //comboCUsuarioAcceso.Items.Add("Visitante");

            dataGridCUsuario.AllowUserToAddRows = true;
            dataGridCUsuario.AllowUserToDeleteRows = true;
        }

        private void textUsuarioNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            //MostrarUsuario();
          ListarNPersonal();
            dataGridCUsuario.DataSource = bindingSource1;
            try
            {
                NPersonal.DataSource = ObtenerEmpleado();
                NPersonal.DisplayMember = "NPersonal";
                NPersonal.ValueMember = "NPersonal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Excepción producida");
            }
            GetData("select usu.NPersonal_id, (emp.ApellidoP + ' ' + emp.ApellidoM + ' ' + emp.Nombre) " +
                "Nombre_Completo, usu.Usuario, usu.Contrasena, usu.Acceso  from Usuario usu left outer join " +
                "Empleado emp on usu.NPersonal_id = emp.NPersonal");
        }
        private void MostrarUsuario()
        {
            CDUsuario objUsuario3 = new CDUsuario();
           // dataGridCUsuario.DataSource = objUsuario3.MostrarUsuario();
        }

        private DataTable ObtenerEmpleado()
        {
            try
            {
                sql = "select NPersonal, (ApellidoP + ' ' + ApellidoM + ' ' + Nombre) as nombre_comp from Empleado order by ApellidoP ";
                dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
                dataAdapter.Fill(table);
            }
            catch (SqlException sq)
            {
                MessageBox.Show("" + sq, "Excepción producida");
            }
            return table;
        }

        private void ListarNPersonal()
        {
          //  CDUsuario objUsuario1 = new CDUsuario();
           
        }

        private void buttonCUsuarioEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCUsuario.RowCount == 2)
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

        private void buttonCUsuarioEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCUsuario.Rows.Remove(dataGridCUsuario.CurrentRow);
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

        private void textCUsuarioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCUsuarioBuscar.Text;
            dataGridCUsuario.DataSource = bindingSource1;

            string consulta = "select usu.NPersonal_id, (emp.ApellidoP + ' ' + emp.ApellidoM + ' ' + emp.Nombre) " +
                            "'Nombre Empleado', usu.Usuario, usu.Contrasena, usu.Acceso  from Empleado emp left outer join " +
                            "Usuario usu on emp.NPersonal = usu.NPersonal_id where usu.NPersonal_id like '" + filtrado + "%' " +
                            "or emp.ApellidoP like '" + filtrado + "%' or emp.ApellidoM like '" + filtrado + "%'  or emp.Nombre like '" +
                            filtrado + "%'or usu.Usuario like '" + filtrado + "%';";
            Console.WriteLine(consulta);
            GetData(consulta);
            //GetData("select * from Usuario where NPersonal_id like '" + filtrado + "%' or Nombre like '" + filtrado + "%' or Usuario like '" + filtrado + "%';");

        }

        //private void buttonCUsuarioGuardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        objUsuario4.editarUsuario2(comboCUsuarioNPersonal.Text, textCUsuarioUsuario.Text, textCUsuarioContraseña.Text, textCUsuarioRepetir.Text, comboCUsuarioAcceso.Text);
        //        //editarUsuario(
        //        //Convert.ToInt32(comboCUsuarioNPersonal.SelectedValue),
        //        //textCUsuarioUsuario.Text,
        //        //textCUsuarioUsuario.Text,
        //        //textCUsuarioRepetir.Text,
        //        //Convert.ToInt32(comboCUsuarioAcceso.SelectedValue),
        //        //Convert.ToInt32(Id_Usuario)
        //        //);
        //        MessageBox.Show("Se edito Correctamente");
        //        MostrarUsuario();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("No se puede editar: " + ex);
        //    }

        // }
    }
}
