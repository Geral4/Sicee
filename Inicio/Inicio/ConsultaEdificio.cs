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
    public partial class ConsultaEdificio : Form
    {

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";


        public ConsultaEdificio()
        {
            InitializeComponent();
        }

        private void textCEdificioBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
