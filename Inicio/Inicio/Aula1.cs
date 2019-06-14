using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Inicio
{
    public partial class Aula1 : Form
    {

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public string clave_edificio = "";
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
           "Initial Catalog=Sicee;Data Source=localhost", cade ="", aux_cambio = "";
        private Validar v = new Validar();
        private consultasSQL sql = new consultasSQL();
        private int numero_aulas = 0;
        private bool guardado = false, valida_cambios = false, eliminado = false, agregado = false;
        

        public Aula1()
        {
            InitializeComponent();
        }

        private void Aula1_Load(object sender, EventArgs e)
        {
            //dataGridAula1.DataSource = bindingSource1;
            //GetData("select clave, nombre, capacidad, descripcion, id_edificio from cat_aulas where id_edificio = '" + clave_edificio + "' order by clave");
            //Refrescar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            sql.InsertActElim2("exec sp_agrega_aulas '" + clave_edificio + "'");
            Refrescar();
            agregado = true;
            guardado = false;
            eliminado = false;
        }


        private void Refrescar()
        {
            dataGridAula1.DataSource = v.llenarDataGrid("select clave, nombre, capacidad, descripcion from cat_aulas " +
                "where id_edificio = '" + clave_edificio + "' order by clave");            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (valida_guardado())
            {
                MessageBox.Show("Faltan campos por llenar. Verifique", "Sicee");
            }
            else
            {
                v.EditarDataGrid(dataGridAula1);
                Refrescar();
                guardado = true;
            }
        }

        private void Aula1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int valida_filas = 0;

            valida_filas = dataGridAula1.RowCount;

            dataGridAula1.EndEdit();

            if (guardado)
                return;

            if (eliminado)
                return;
            
            if ((agregado || valida_cambios))
            {                
                if (MessageBox.Show("¿Desea guardar los cambios antes de salir?", "Sicee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (valida_guardado())
                    {
                        MessageBox.Show("Faltan campos por llenar. Verifique", "Sicee");
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        v.EditarDataGrid(dataGridAula1);
                    }
                }
                else
                {
                    if (numero_aulas != valida_filas)
                    {
                        cade = "delete from cat_aulas where clave >= '" + clave_edificio + valida_filas + "' and id_edificio = '" + clave_edificio + "';";
                        cade = cade + "exec sp_act_capacidad_aulas '" + clave_edificio + "';";
                        sql.InsertActElim2(cade);
                    }                    
                }
            }
        }

        private void Aula1_Activated(object sender, EventArgs e)
        {
            
        }

        private void Aula1_VisibleChanged(object sender, EventArgs e)
        {
            Refrescar();
            numero_aulas = dataGridAula1.RowCount;
            valida_cambios = false;
            guardado = false;
            eliminado = false;
            agregado = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar esta aula?", "Sicee", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                v.EliminarDataGrid(dataGridAula1);
                //int valida_filas = 0;
                //valida_filas = dataGridAula1.RowCount;
                cade = "exec sp_act_capacidad_aulas '"+ clave_edificio +"'";
                sql.InsertActElim2(cade);
                eliminado = true;
            }
                
        }

        private void dataGridAula1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string valor_celda = dataGridAula1.CurrentCell.Value.ToString();
            if (valor_celda != aux_cambio)
            {
                valida_cambios = true;
            }
        }

        private void dataGridAula1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            aux_cambio = dataGridAula1.CurrentCell.Value.ToString();
        }

        private bool valida_guardado()
        {
            bool campos_vacios = false;
            int a = 0;
            string b = "";
            for (int i = 0; i < dataGridAula1.RowCount; i++)
            {
                b = dataGridAula1[1, i].Value.ToString();
                a = Convert.ToInt32(dataGridAula1[2, i].Value);

                if (dataGridAula1[1, i].Value.ToString().Equals("") || Convert.ToInt32(dataGridAula1[2, i].Value) == 0)
                {
                    campos_vacios = true;
                }
            }

            return campos_vacios;
        }

    }
}
