using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioReporteISerie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxReporteIMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelReporteIVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timerBitacora_Tick(object sender, EventArgs e)
        {
            labelHBitacora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFBitacora.Text = DateTime.Now.ToString("dd MMMM yyy");
        }
    }
}
