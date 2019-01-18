using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace Inicio
{
    public partial class Horario : Form
    {
        private OpenFileDialog archivoExcel = new OpenFileDialog();
        private string ruta_archivo = "", nombre_archivo = "", conexion ="";
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";
        private DataSet ds = new DataSet();


        public Horario()
        {
            InitializeComponent();
            comboHorarioDia.Items.Add("Lunes");
            comboHorarioDia.Items.Add("Martes");
            comboHorarioDia.Items.Add("Miercoles");
            comboHorarioDia.Items.Add("Jueves");
            comboHorarioDia.Items.Add("Viernes");
            comboHorarioDia.Items.Add("Sabado");
            comboHorarioDia.Items.Add("Domingo");
            buttonHorarioExaminar.Enabled = false;
            buttonHorarioGuardar.Enabled = false;
            lblArchivoC.Text = "";
            lblArchivo.Visible = false;
        }
        

        private void buttonAsignaturaGuardar_Click(object sender, EventArgs e)
        {
            try{
                SqlConnection conexion_sql = new SqlConnection(CadenaConexion);
                conexion_sql.Open();
                SqlBulkCopy importar = default(SqlBulkCopy);
                importar = new SqlBulkCopy(conexion_sql);
                importar.DestinationTableName = "Horario";
                importar.WriteToServer(ds.Tables[0]);
                conexion_sql.Close();
                MessageBox.Show("Importación exitosa :)", "Importación Excel");
                //filtrado = textHorarioBuscar.Text;
                dataGridHorario.DataSource = bindingSource1;
                GetData("select * from Horario");
                buttonHorarioGuardar.Enabled = false;
            }
            catch(SqlException SQLEx){
                MessageBox.Show("Excepción producida: \n" + SQLEx.Message, "Error fatal");

            } 
            
        }

        private void textAsignaturaCreditos_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelHorarioA_Click(object sender, EventArgs e)
        {

        }

        private void buttonHorarioExaminar_Click(object sender, EventArgs e)
        {
            ds.Clear();
            if (radioHorarioHoja.Checked)
            {
                
                archivoExcel.Filter = "Excel|*.xlsx";   
                if(archivoExcel.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //MessageBox.Show("Nombre del archivo: " + archivoExcel.FileName + "\nRuta del archivo: " + archivoExcel.SafeFileName, "Archivo Excel");
                        ruta_archivo = archivoExcel.FileName;
                        nombre_archivo = archivoExcel.SafeFileName;
                        conexion = @"Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + ruta_archivo + "; Extended Properties= Excel 12.0;";
                        Console.WriteLine("Conexión: " + conexion);
                        //FileInfo info = new FileInfo(ruta_archivo);
                        //ruta_archivo = info.Name;
                        OleDbConnection origen = new OleDbConnection(conexion);
                        //origen = new OleDbConnection(ExcelConnection(ruta_archivo));
                        origen.Open();
                        OleDbCommand consulta = default(OleDbCommand);
                        consulta = new OleDbCommand("Select * from [Hoja1$]", origen);
                        OleDbDataAdapter adaptador = new OleDbDataAdapter();
                        adaptador.SelectCommand = consulta;
                        adaptador.Fill(ds);
                        dataGridHorario.DataSource = ds.Tables[0];
                        origen.Close();
                        lblArchivo.Visible = true;
                        lblArchivoC.Text = nombre_archivo;
                        buttonHorarioGuardar.Enabled = true;
                        //SqlConnection conexion_sql = new SqlConnection(CadenaConexion);
                        //conexion_sql.Open();
                        //SqlBulkCopy importar = default(SqlBulkCopy);
                        //importar = new SqlBulkCopy(conexion_sql);
                        //importar.DestinationTableName = "tabla_prueba";
                        //importar.WriteToServer(ds.Tables[0]);
                        //conexion_sql.Close();
                        //MessageBox.Show("Importación exitosa :)", "Importación Excel");
                        ////dataGridHorario.DataSource = "";
                        //filtrado = textHorarioBuscar.Text;
                        //dataGridHorario.DataSource = bindingSource1;
                        //GetData("select * from tabla_prueba");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Excepción producida: \n" + ex);                                         
                    }
                }
            }
        }

        private void textHorarioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textHorarioBuscar.Text;
            dataGridHorario.DataSource = bindingSource1;
            GetData("select * from Horario where DocenteEmpleado_id like '" + filtrado + "%'");
        }

        private void radioHorarioHoja_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioHorarioHoja.Checked)
            {
                buttonHorarioExaminar.Enabled = true;
            }
            else
            {
                buttonHorarioExaminar.Enabled = false;
            }
        }

        private void radioHorarioManual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioHorarioManual_Click(object sender, EventArgs e)
        {
            if (radioHorarioHoja.Checked)
            {
                buttonHorarioExaminar.Enabled = true;
            }
            else
            {
                buttonHorarioExaminar.Enabled = false;
            }
        }

        private string ExcelConnection(string fileName)
        {
            return @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data Source=" + fileName + ";" +
                   @"Extended Properties=" + Convert.ToChar(34).ToString() +
                   @"Excel 8.0" + Convert.ToChar(34).ToString() + ";";
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
    }
}
