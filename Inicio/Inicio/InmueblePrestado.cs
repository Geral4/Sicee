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
    public partial class InmueblePrestado : Form
    {

        Validar funciones = new Validar();
        private BindingSource bindingSource1 = new BindingSource();
        private string sql = "";
        public int folio = 0;


        public InmueblePrestado()
        {
            InitializeComponent();
        }

        private void InmueblePrestado_Load(object sender, EventArgs e)
        {
            sql = "select Numero, NSerie_id 'Numero de serie', i.Nombre, i.Modelo, Observaciones, Prestado From PrestamoInmueble p " +
                "inner join Inmueble i on p.Nserie_id = i.Nserie where p.Folio_id = "+ folio +"";
            dataGridInmueblePrestado.DataSource = funciones.llenarDataGrid(sql);
        }
    }
}
