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
    
    public partial class Usuario : Form
        {

        CDUsuario objUsuario = new CDUsuario();
        public Usuario()
        {
            InitializeComponent();
            comboUsuarioAcceso.Items.Add("Administrador");
            comboUsuarioAcceso.Items.Add("Asesor");
            comboUsuarioAcceso.Items.Add("Visitante");
        }              

        private void Usuario_Load(object sender, EventArgs e)
        {
           ListarNPersonal();
            MostrarUsuario();
        }

        private void ListarNPersonal()
        {
            CDUsuario objUsuario1 = new CDUsuario();
            comboUsuarioNPersonal.DataSource = objUsuario1.ListarNPersonal();
            comboUsuarioNPersonal.DisplayMember = "NPersonal";
            comboUsuarioNPersonal.ValueMember = "Nombre";
            textUsuarioNombre.Text = "";
        }

        private void buttonUsuarioGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objUsuario.insertarUsuario(
                   comboUsuarioNPersonal.Text,
                   comboUsuarioNPersonal.SelectedValue.ToString(),
                   textUsuarioUsuario.Text,
                   textUsuarioContraseña.Text,
                   textUsuarioRepetir.Text,
                   comboUsuarioAcceso.Text);
                MessageBox.Show("Usuario agregado");
                MostrarUsuario();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede insertar correctamente: " + ex);
            }
        }

        private void MostrarUsuario()
        {
            CDUsuario objUsuario1 = new CDUsuario();
            dataGridUsuario.DataSource = objUsuario1.MostrarUsuario();
        }

        private void comboUsuarioNPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            textUsuarioNombre.Text = "";
            
            textUsuarioNombre.Text = "Nombre:    " + comboUsuarioNPersonal.SelectedValue.ToString();

        }

    }
}
