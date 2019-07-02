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
using System.Data.SqlTypes;
using CapaDatos;


namespace Inicio
{
    public partial class Horario : Form

    {

        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();

        private OpenFileDialog archivoExcel = new OpenFileDialog();
        private string ruta_archivo = "", nombre_archivo = "", conexion ="", aux="";
        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "";
        private DataSet ds = new DataSet();
        private string sql = "select (emp.Nombre + ' ' + emp.ApellidoP + ' '+ emp.ApellidoM) 'Nombre Empleado', car.Nombre Carrera, asig.Nombre Asignatura, " +
                    "hr.HorarioInicio 'Hora Inicio', hr.HorarioFin 'Hora Fin', aula.clave Aula, hr.Dia from Horario hr inner join Empleado emp on hr.DocenteEmpleado_id = " +
                    "emp.NPersonal inner join Carrera car on hr.Carrera_id = car.Clave inner join Asignatura asig on hr.Asignatura_id = asig.Clave inner join" +
                    " cat_aulas aula on hr.Aula_id = aula.clave";

       
        


        public Horario()
        {
            InitializeComponent();
            comboHorarioDia.Items.Add("Lunes");
            comboHorarioDia.Items.Add("Martes");
            comboHorarioDia.Items.Add("Miercoles");
            comboHorarioDia.Items.Add("Jueves");
            comboHorarioDia.Items.Add("Viernes");
            comboHorarioDia.Items.Add("Sabado");
            buttonHorarioExaminar.Enabled = false;
            buttonHorarioGuardar.Enabled = false;
            lblArchivoC.Text = "";
            lblArchivo.Visible = false;

            comboHorarioHoraI.Items.Add("07:00");
            comboHorarioHoraI.Items.Add("08:00");
            comboHorarioHoraI.Items.Add("09:00");
            comboHorarioHoraI.Items.Add("10:00");
            comboHorarioHoraI.Items.Add("11:00");
            comboHorarioHoraI.Items.Add("12:00");
            comboHorarioHoraI.Items.Add("13:00");
            comboHorarioHoraI.Items.Add("14:00");
            comboHorarioHoraI.Items.Add("15:00");
            comboHorarioHoraI.Items.Add("16:00");
            comboHorarioHoraI.Items.Add("17:00");
            comboHorarioHoraI.Items.Add("18:00");
            comboHorarioHoraI.Items.Add("19:00");
            comboHorarioHoraI.Items.Add("20:00");
            comboHorarioHoraI.Items.Add("21:00");

            comboHorarioHoraF.Items.Add("08:00");
            comboHorarioHoraF.Items.Add("09:00");
            comboHorarioHoraF.Items.Add("10:00");
            comboHorarioHoraF.Items.Add("11:00");
            comboHorarioHoraF.Items.Add("12:00");
            comboHorarioHoraF.Items.Add("13:00");
            comboHorarioHoraF.Items.Add("14:00");
            comboHorarioHoraF.Items.Add("15:00");
            comboHorarioHoraF.Items.Add("16:00");
            comboHorarioHoraF.Items.Add("17:00");
            comboHorarioHoraF.Items.Add("18:00");
            comboHorarioHoraF.Items.Add("19:00");
            comboHorarioHoraF.Items.Add("20:00");
            comboHorarioHoraF.Items.Add("21:00");
            comboHorarioHoraF.Items.Add("22:00");

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
                GetData(sql);
                buttonHorarioGuardar.Enabled = false;

                actualizarHorario();

            }
            catch(SqlException SQLEx){
                MessageBox.Show("Excepción producida: \n" + SQLEx.Message, "Error fatal");

            } 
            
        }              

        public void actualizarHorario()
        {
            try
            {
                Coman.Connection = Conexion.AbrirConexion();
                Coman.CommandText = "Bitacora";
                Coman.CommandType = CommandType.StoredProcedure;
                Coman.Parameters.AddWithValue("@fecha_inicial_clases", FechaBitacora.Value);
                Coman.Parameters.AddWithValue("@fecha_final_clases", FechaFinBitacora.Value);
                Coman.ExecuteNonQuery();
                    Coman.Parameters.Clear();
            }
            catch (SqlException sql)
            {
                Console.WriteLine("Excepción producida: " + sql);
            }

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
            aux = sql + " where emp.Nombre like '" + filtrado + "%' or emp.ApellidoP like '" + filtrado + "%' or car.Nombre like '" + filtrado + "%' or hr.Aula_id like '" + filtrado + "%'" +
                " or hr.Dia like '" + filtrado + "%'";
            Console.WriteLine(aux);
            GetData(aux);
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

        private void dataGridHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BitacoraFechaSemestre_Click(object sender, EventArgs e)
        {

        }

        private void Horario_Load(object sender, EventArgs e)
        {
           // Bitacora();
        }


        //private void Bitacora()
        //{
        //    CDBitacora objbitacora1 = new CDBitacora();
        //    dataGridHorario.DataSource = objbitacora1.Bitacora();
        //}





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
