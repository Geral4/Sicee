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
    public partial class Horario : Form
    {
        public Horario()
        {
            InitializeComponent();
            comboHorarioDia.Items.Add("Lunes");
            comboHorarioDia.Items.Add("Martes");
            comboHorarioDia.Items.Add("Miercoles");
            comboHorarioDia.Items.Add("Jueves");
            comboHorarioDia.Items.Add("Viernes");
            comboHorarioDia.Items.Add("Sabado");
            comboHorarioDia.Items.Add("Domingo");
        }
        

        private void buttonAsignaturaGuardar_Click(object sender, EventArgs e)
        {

        }

        private void textAsignaturaCreditos_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelHorarioA_Click(object sender, EventArgs e)
        {

        }
    }
}
