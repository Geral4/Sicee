using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using CapaDatos;


namespace Inicio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        private void ptbminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }    
        

        private void textLoginUsuario_Enter(object sender, EventArgs e)
        {
            if (textLoginUsuario.Text == "USUARIO") 
            {
                textLoginUsuario.Text = "";
                textLoginUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textLoginUsuario_Leave(object sender, EventArgs e)
        {
            if (textLoginUsuario.Text == "")
            {
                textLoginUsuario.Text = "USUARIO";
                textLoginUsuario.ForeColor = Color.DimGray;
            }
        }
        
        private void textLoginContraseña_Enter(object sender, EventArgs e)
        {
            if (textLoginContraseña.Text == "CONTRASEÑA")
            {
                textLoginContraseña.Text = "";
                textLoginContraseña.ForeColor = Color.LightGray;
                textLoginContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textLoginContraseña_Leave(object sender, EventArgs e)
        {
            if (textLoginContraseña.Text == "")
            {
                textLoginContraseña.Text = "CONTRASEÑA";
                textLoginContraseña.ForeColor = Color.DimGray;
                textLoginContraseña.UseSystemPasswordChar = false;
            }
        }

        private void panelLoginVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonLoginAcceder_Click(object sender, EventArgs e)
        {
            CNUsuario objEmpleado = new CNUsuario();
            SqlDataReader Loguear;
            objEmpleado.Usuario = textLoginUsuario.Text;
            objEmpleado.Contrasena = textLoginContraseña.Text;
            Loguear = objEmpleado.IniciarSesion();
            if (Loguear.Read() == true)
            {
                this.Hide();
                Inicio ObjFP = new Inicio();
                ObjFP.Show();
            }
            else
            {
                MessageBox.Show("Invalido");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
