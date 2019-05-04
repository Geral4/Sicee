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
    public partial class Aula : Form
    {
        Edificio edificio1 = new Edificio();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public string clave_edificio = "";
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
           "Initial Catalog=Sicee;Data Source=localhost";
        public Aula()
        {
            InitializeComponent();
        }

        private void Aula_Load(object sender, EventArgs e)
        {
            dataGridAula.DataSource = bindingSource1;
            GetData("select * from cat_aulas where clave like '"+clave_edificio+"%' order by clave");
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

        private void buttonAulaGuardar_Click(object sender, EventArgs e)
        {
            Edificio edificio1 = new Edificio();
            try
            {
                this.Validate();
                bindingSource1.EndEdit();
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
                GetData(dataAdapter.SelectCommand.CommandText);
                MessageBox.Show("Guardado Correctamente");

            }
            catch (SqlException s)
            {
                MessageBox.Show("" + s, "Verifica");
            }
            this.Close();
        }
    }
}
