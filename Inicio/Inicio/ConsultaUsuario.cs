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
        private string Id_Usuario =null;

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
          "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable("Cargos");
        private string filtrado = "", sql = "";

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
                "Nombre_Completo, usu.Usuario, usu.Contrasena, usu.Acceso  from Empleado emp left outer join " +
                "Usuario usu on emp.NPersonal = usu.NPersonal_id");
        }
        private void MostrarUsuario()
        {
            CDUsuario objUsuario3 = new CDUsuario();
            dataGridCUsuario.DataSource = objUsuario3.MostrarUsuario();
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
            CDUsuario objUsuario1 = new CDUsuario();
           
        }

        private void buttonCUsuarioEditar_Click(object sender, EventArgs e)
        {
            
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

        private void textCUsuarioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textCUsuarioBuscar.Text;
            dataGridCUsuario.DataSource = bindingSource1;
            GetData("select usu.NPersonal_id, (emp.ApellidoP + ' ' + emp.ApellidoM + ' ' + emp.Nombre) " +
                "Nombre_Completo, usu.Usuario, usu.Contrasena, usu.Acceso  from Empleado emp left outer join " +
                "Usuario usu on emp.NPersonal = usu.NPersonal_id where usu.NPersonal_id like '" + filtrado + "%' " +
                "or Nombre_Completo like '" + filtrado + "%' or usu.Usuario like '" + filtrado + "%';");
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
