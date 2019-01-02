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
    public partial class Inmueble : Form
    {
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
            comboInmuebleColor.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            comboInmuebleColor.Items.AddRange(colores);

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
    }
}
