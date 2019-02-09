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
        public SqlDataAdapter dataAdapter, global;       
        public string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        public DataTable table;
        public BindingSource g = new BindingSource();

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
                table = new DataTable();
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


        public void llenarComboDGSQL(string sentencia, DataGridViewComboBoxColumn combo, string valueMemb, string displayMemb)
        {

            try
            {
                table = new DataTable();
                dataAdapter = new SqlDataAdapter(sentencia, CadenaConexion);
                dataAdapter.Fill(table);
                combo.DataSource = table;
                combo.DisplayMember = displayMemb;
                combo.ValueMember = valueMemb;


            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }

        }

        public BindingSource llenarDataGrid(string sql)
        {
            try
            {
                global = new SqlDataAdapter(sql, CadenaConexion);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(global);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                global.Fill(table);
                g.DataSource = table;
                // dataGridCEmpleado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción: " + ex);
            }
            return g;
        }

        public void EditarDataGrid(DataGridView dg)
        {
            try
            {
                    g.EndEdit();
                    global.Update((DataTable)g.DataSource);
                    //GetData(dataAdapter.SelectCommand.CommandText);
                    MessageBox.Show("Editado Correctamente");
                    dg.Refresh();
            }
            catch (SqlException s)
            {
                MessageBox.Show("" + s, "Verifica");
            }
        }

        private void GetData(string sql)
        {
            try
            {
                global = new SqlDataAdapter(sql, CadenaConexion);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(global);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                global.Fill(table);
                g.DataSource = table;
                // dataGridCEmpleado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción: " + ex);
            }

        }

    }
}
