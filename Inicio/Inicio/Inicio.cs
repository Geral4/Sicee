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


namespace Inicio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);        

        private void AbrirFormHija(object formhija)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }             
        

        private void panelInicioTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelInicioVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
       
        private void timerHF_Tick(object sender, EventArgs e)
        {
            labelInicioH.Text = DateTime.Now.ToString("HH:mm:ss");
            labelInicioF.Text = DateTime.Now.ToString("dd MMMM yyy");
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Alta());
        }
        private void pictureLogo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Principal());
        }
        private void buttonHorario_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Horario());
        }
        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Consultas());
        }
        private void buttonPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Prestamos());        }                

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Reporte());
        }

        private void buttonBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Bitacora());
        }

        private void pictureCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureRestaurar.Visible = false;
            pictureMaximizar.Visible = true;
        }

        private void pictureMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureMaximizar.Visible = false;
            pictureRestaurar.Visible = true;
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelH_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        internal class SiceeDataSet
        {
            public SiceeDataSet()
            {
            }
        }

        internal class SiceeDataSetTableAdapters
        {
            internal class EmpleadoTableAdapter
            {
                public EmpleadoTableAdapter()
                {
                }
            }
        }
    }
}
