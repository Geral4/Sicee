using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        CNUsuario objUsuario4 = new CNUsuario();
        private string Id_Usuario =null;

        public ConsultaUsuario()
        {
            InitializeComponent();
            comboCUsuarioAcceso.Items.Add("Administrador");
            comboCUsuarioAcceso.Items.Add("Asesor");
            comboCUsuarioAcceso.Items.Add("Visitante");
        }

        private void textUsuarioNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
            ListarNPersonal();
        }
        private void MostrarUsuario()
        {
            CDUsuario objUsuario3 = new CDUsuario();
            dataGridCUsuario.DataSource = objUsuario3.MostrarUsuario();
        }

        private void ListarNPersonal()
        {
            CDUsuario objUsuario1 = new CDUsuario();
            comboCUsuarioNPersonal.DataSource = objUsuario1.ListarNPersonal();
            comboCUsuarioNPersonal.DisplayMember = "NPersonal";
            comboCUsuarioNPersonal.ValueMember = "NPersonal";
        }

        private void buttonCUsuarioEditar_Click(object sender, EventArgs e)
        {
            if (dataGridCUsuario.SelectedRows.Count > 0)
            {
                comboCUsuarioNPersonal.Text = dataGridCUsuario.CurrentRow.Cells["NºPersonal"].Value.ToString();
                textCUsuarioUsuario.Text = dataGridCUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                textCUsuarioContraseña.Text = dataGridCUsuario.CurrentRow.Cells["Contrasena"].Value.ToString();
                textCUsuarioRepetir.Text = dataGridCUsuario.CurrentRow.Cells["Repetir_Contraseña"].Value.ToString();
                comboCUsuarioAcceso.Text = dataGridCUsuario.CurrentRow.Cells["Acceso"].Value.ToString();
                //Id_Usuario = dataGridCUsuario.CurrentRow.Cells["Id_Usuario"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void buttonCUsuarioGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objUsuario4.editarUsuario2(comboCUsuarioNPersonal.Text, textCUsuarioUsuario.Text, textCUsuarioContraseña.Text, textCUsuarioRepetir.Text, comboCUsuarioAcceso.Text);
                //editarUsuario(
                //Convert.ToInt32(comboCUsuarioNPersonal.SelectedValue),
                //textCUsuarioUsuario.Text,
                //textCUsuarioUsuario.Text,
                //textCUsuarioRepetir.Text,
                //Convert.ToInt32(comboCUsuarioAcceso.SelectedValue),
                //Convert.ToInt32(Id_Usuario)
                //);
                MessageBox.Show("Se edito Correctamente");
                MostrarUsuario();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede editar: " + ex);
            }

        }
    }
}
