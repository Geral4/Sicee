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
    public partial class ConsultaCargo : Form
    {
        CDCargo objCCargo = new CDCargo();
        public ConsultaCargo()
        {
            InitializeComponent();
        }

        private void panelCCargoVertical_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MostrarCargo()
        {
            CDCargo objCar = new CDCargo();
            dataGridCCargo.DataSource = objCar.MostrarCargo();
        }

        private void ConsultaCargo_Load(object sender, EventArgs e)
        {
            MostrarCargo();
        }

        private void dataGridCCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCCargoEditar_Click(object sender, EventArgs e)
        {
            //EditarCargo formCargo = new EditarCargo();
            //formCargo.Show();

           
        }
    }
}
