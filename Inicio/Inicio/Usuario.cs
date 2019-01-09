﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Data.SqlClient;

namespace Inicio
{
    
    public partial class Usuario : Form
        {

        CDUsuario objUsuario = new CDUsuario();


        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";

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

        private void textUsuarioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textUsuarioBuscar.Text;
            dataGridUsuario.DataSource = bindingSource1;
            GetData("select * from Usuario where NPersonal_id like '" + filtrado + "%' or Nombre like '" + filtrado + "%' or Usuario like '" +filtrado + "%';");

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

    }
}
