using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    class Validar
    {
        public static void sololetras(KeyPressEventArgs V)
        {
            if(Char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if(Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }

        public static void solonumeros (KeyPressEventArgs V)
        {
            if(Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if(char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }

        }

    }
}
