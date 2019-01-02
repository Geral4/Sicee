using CapaDatos;
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
    public partial class Edificio : Form
    {
        private int no_aulas=0;
        private string clave = "";
        private CDEdificio edificioAula = new CDEdificio();
        public Edificio()
        {
            InitializeComponent();
        }

        private void buttonEdificioRegistrar_Click(object sender, EventArgs e)
        {
            no_aulas = Convert.ToInt32(numericEdificio.Value);
            clave = textEdificioClave.Text;
            edificioAula.insertaAulas(clave, no_aulas);
            Aula formAula = new Aula();
            formAula.Show();
        }

        private void textEdificioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
            

        private void numericEdificio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Edificio_Load(object sender, EventArgs e)
        {

        }
    }
}
