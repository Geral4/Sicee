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
        private string observaciones = "", res= "";
        private int entregados = 0, numero = 0;
        consultasSQL exec = new consultasSQL();


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

        private void InmueblePrestado_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                int numFilas = dataGridInmueblePrestado.RowCount;
                for (int i = 0; i < numFilas; i++)
                {
                    observaciones = dataGridInmueblePrestado[4, i].Value.ToString();
                    entregados = Convert.ToInt32(dataGridInmueblePrestado[5, i].Value);
                    numero = Convert.ToInt32(dataGridInmueblePrestado[0, i].Value);
                    sql = "UPDATE PrestamoInmueble SET Observaciones = '" + observaciones + "', " +
                        "Prestado = " + entregados + " WHERE Folio_id = " + folio + " and Numero = " + numero + ";";
                    Console.WriteLine("Actualizar observaciones: " + sql);
                    if (exec.InsertActElim2(sql) > 0)
                    {
                        res = "Los cambios de han guardado correctamente";
                    }
                    else
                    {
                        res = "Los cambios no se han podido guardar, verifique";
                    }
                    
                }
                MessageBox.Show(res, "Devoluciones");
                exec.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }
                       
        }
    }
}
