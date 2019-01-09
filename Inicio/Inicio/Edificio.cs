using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Inicio
{
    public partial class Edificio : Form
    {
        private int no_aulas=0;
        private string clave = "";
        private CDAula edificioAula = new CDAula();
        CDEdificio objEdificio = new CDEdificio();


        CDCargo objCargo = new CDCargo();
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";

        public Edificio()
        {
            InitializeComponent();
        }

        private void buttonEdificioRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objEdificio.insertaEdificio(
                    textEdificioNombre.Text,
                    textEdificioClave.Text,
                   textEdificioDescripcion.Text,
                   Convert.ToInt32(numericEdificio.Value)
                   );

                MessageBox.Show("Insertado Correctamente");
                MostrarEdificio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede insertar los datos por: " + ex);
            }

            no_aulas = Convert.ToInt32(numericEdificio.Value);
            clave = textEdificioClave.Text;
            edificioAula.insertaAulas(clave, no_aulas);
            Aula formAula = new Aula();
            formAula.clave_edificio = clave;
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
            MostrarEdificio();
        }

        private void MostrarEdificio()
        {
            CDEdificio objEdificio = new CDEdificio();
            dataGridEdificio.DataSource = objEdificio.MostrarEdificio();
        }

        private void textEdificioBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
