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

namespace Inicio
{
    public partial class Inmueble : Form
    {
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
           "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable("Aulas");
        private string sql = "";

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
            //comboInmuebleColor.Items.Clear();
            //string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            //comboInmuebleColor.Items.AddRange(colores);

            //try
            //{
            //    e.DrawBackground();
            //    string texto = comboInmuebleColor.Items[e.Index].ToString();
            //    Brush borde = new SolidBrush(e.ForeColor);
            //    Color color = Color.FromName(texto);
            //    Brush pincel = new SolidBrush(color);
            //    Pen boli = new Pen(e.ForeColor);

            //    e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
            //    e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
            //    e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);

            //    e.DrawFocusRectangle();
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void comboInmuebleAula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void comboInmuebleColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ///////////////////// Origen de registro en combobox
        private DataTable ObtenerAulas()
        {
            try
            {
                sql = "select clave, nombre from cat_aulas order by nombre";
                dataAdapter = new SqlDataAdapter(sql, CadenaConexion);
                dataAdapter.Fill(table);
            }
            catch (SqlException sq)
            {
                MessageBox.Show("" + sq, "Excepción producida");
            }
            return table;
        }

        private void Inmueble_Load(object sender, EventArgs e)
        {
            try
            {
                textInmuebleAula.Enabled = false;
                comboInmuebleAula.DataSource = ObtenerAulas();
                comboInmuebleAula.DisplayMember = "nombre";
                comboInmuebleAula.ValueMember = "clave";
                textInmuebleAula.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Excepción producida");
            }

        }

        private void buttonInmuebleGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La aula elegida tiene la clave: " + comboInmuebleAula.SelectedValue);
        }

        private void comboInmuebleAula_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textInmuebleAula.Text = "";
            textInmuebleAula.Text = comboInmuebleAula.SelectedValue.ToString();
        }
    }
}
