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
        public Edificio()
        {
            InitializeComponent();
        }

        private void buttonEdificioRegistrar_Click(object sender, EventArgs e)
        {
            Aula formAula = new Aula();
            formAula.Show();
        }

        private void textEdificioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
    }
}
