using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    class Validar
    {
        public SqlDataAdapter dataAdapter;
        public string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        public DataTable table;

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
        //Ejemplo: llenarComboSQL("select clave_nombre from cat_aulas order by nombre", comboAulas, "clave", "nombre");
        public void llenarComboSQL(string sentencia, ComboBox combo, string valueMemb, string displayMemb)
        {

            try
            {
                dataAdapter = new SqlDataAdapter(sentencia, CadenaConexion);
                dataAdapter.Fill(table);
                combo.DataSource = table;
                combo.DisplayMember = displayMemb;
                combo.ValueMember = valueMemb;


            }catch(Exception ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }            
          
        }

    }
}
