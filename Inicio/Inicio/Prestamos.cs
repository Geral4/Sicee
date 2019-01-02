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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }    
        

        private void buttonPrestamosRealizar_Click(object sender, EventArgs e)
        {
            RealizarPrestamo formRealizarPrestamo = new RealizarPrestamo();
            formRealizarPrestamo.ShowDialog();
        }

        private void buttonPrestamosDevolucion_Click(object sender, EventArgs e)
        {
            DevolucionPrestamo formDevolucionPrestamo = new DevolucionPrestamo();
            formDevolucionPrestamo.ShowDialog();
        }
    }
}
