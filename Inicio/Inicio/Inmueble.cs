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
using System.Data.SqlClient;

namespace Inicio
{
    public partial class Inmueble : Form
    {
        CDInmueble objInmueble = new CDInmueble();

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";


        //private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
        //  "Initial Catalog=Sicee;Data Source=localhost";
        //private BindingSource bindingSource1 = new BindingSource();
        //private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        // private DataTable table = new DataTable("Aulas");
        //private string sql = "";

        public Inmueble()
        {
            InitializeComponent();
        }

        private void textInmuebleNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textInmuebleMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }


        private void comboInmuebleColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            try
            {
                e.DrawBackground();
                string texto = comboInmuebleColor.Items[e.Index].ToString();
                Brush borde = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush pincel = new SolidBrush(color);
                Pen boli = new Pen(e.ForeColor);

                e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);

                e.DrawFocusRectangle();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        ///////////////////// Origen de registro en combobox
        //private DataTable ObtenerAulas()
        //{
        //    try
        //    {
        //        sql = "select clave, nombre from cat_aulas order by nombre";
        //        dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
        //        dataAdapter.Fill(table);
        //    }
        //    catch (SqlException sq)
        //    {
        //        MessageBox.Show("" + sq, "Excepción producida");
        //    }
        //    return table;
        //}

        private void Inmueble_Load(object sender, EventArgs e)
        {
            
            MostrarInmueble();



            //Es lo que hizo Miguel para listar las aulas en inmueble

            //try
            //{
            //    textInmuebleAula.Enabled = false;
            //    comboInmuebleAula.DataSource = ObtenerAulas();
            //    comboInmuebleAula.DisplayMember = "nombre";
            //    comboInmuebleAula.ValueMember = "clave";
            //    textInmuebleAula.Text = "";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex, "Excepción producida");
            //}

        }

        private void buttonInmuebleGuardar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("La aula elegida tiene la clave: " + comboInmuebleAula.SelectedValue);
            if (textInmuebleNombre.Text == "" ||  textInmuebleMarca.Text == "" || textInmuebleModelo.Text == "" ||
                textInmuebleNSerie.Text=="" || comboInmuebleAula.Text=="" )
            {
                MessageBox.Show("Llenar los campos obligatorios");

            }
            else
            {

                try
            {
                objInmueble.insertarInmueble(
                    textInmuebleNombre.Text,
                    textInmuebleMarca.Text,
                    textInmuebleModelo.Text,
                    comboInmuebleColor.Text,
                    textInmuebleNSerie.Text,
                    comboInmuebleAula.Text,
                    comboInmuebleAula.SelectedValue.ToString(),
                    textInmuebleDescripcion.Text
                    );
                MessageBox.Show("Insertado Correctamente");
                MostrarInmueble();
            }

            catch 
            {
                    MessageBox.Show("No se puede repetir la misma Clave ");
                }
            textInmuebleNombre.Clear();
            textInmuebleMarca.Clear();
            textInmuebleModelo.Clear();
            textInmuebleNSerie.Clear();
            textInmuebleDescripcion.Clear();
            textInmuebleAula.Clear();
            comboInmuebleAula.Text = string.Empty;
            comboInmuebleColor.Text = string.Empty;
            }
        }

        private void ListarAula()
        {
            textInmuebleAula.Enabled = false;
            CDInmueble objInmueble = new CDInmueble();
            comboInmuebleAula.DataSource = objInmueble.ListarAula();
            comboInmuebleAula.DisplayMember = "Nombre";
            comboInmuebleAula.ValueMember = "Clave";
            textInmuebleAula.Text = "";
        }

        private void MostrarInmueble()
        {
            CDInmueble objInmueble2 = new CDInmueble();
            dataGridInmueble.DataSource = objInmueble2.MostrarInmueble();

        }

        private void comboInmuebleAula_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textInmuebleAula.Text = "";
            textInmuebleAula.Text = "Clave de aula:    " + comboInmuebleAula.SelectedValue.ToString();

        }     


        private void comboInmuebleColor_Enter(object sender, EventArgs e)
        {
            comboInmuebleColor.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            comboInmuebleColor.Items.AddRange(colores);
        }

        private void textInmuebleAula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInmuebleBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textInmuebleBuscar.Text;
            dataGridInmueble.DataSource = bindingSource1;
            GetData("select * from Inmueble where Marca like '" + filtrado + "%' or Nombre like '" + filtrado + "%' or Modelo like '" +filtrado + "%' or  NSerie like '" +filtrado+ "%' or Aula like '"+ filtrado + "%';");

        }


        private void GetData(string sql)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                // dataGridCEmpleado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción: " + ex);
            }

        }

        private void comboInmuebleAula_MouseClick(object sender, MouseEventArgs e)
        {

            ListarAula();
        }

        private void buttonInmuebleCancelar_Click(object sender, EventArgs e)
        {
            textInmuebleNombre.Clear();
            textInmuebleMarca.Clear();
            textInmuebleModelo.Clear();
            textInmuebleNSerie.Clear();
            textInmuebleDescripcion.Clear();
            textInmuebleAula.Clear();
            comboInmuebleAula.Text = string.Empty;
            comboInmuebleColor.Text = string.Empty;
        }
    }
}
