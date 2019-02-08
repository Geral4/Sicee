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
using CapaDatos;

namespace Inicio
{
    public partial class Bitacora : Form
    {

        private string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
        "Initial Catalog=Sicee;Data Source=localhost";
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string filtrado = "", aux = "";
        private string sql = " select ROW_NUMBER() OVER(ORDER BY fecha ASC) AS 'Nº', (emp.Nombre + ' ' + emp.ApellidoP + ' ' + emp.ApellidoM) 'Nombre Empleado', hr.CAlumnos 'Cantidad Alumnos', car.Nombre Carrera, asig.Nombre Asignatura," +
                   "hr.ClasePractica 'Clase/Practica', hr.HorarioInicio 'Hora Inicio', hr.HorarioFin 'Hora Fin', hr.Observaciones 'Observaciones' , hr.Firma 'Firma' from Horario hr inner join Empleado emp on hr.DocenteEmpleado_id = " +
                   "emp.NPersonal inner join Carrera car on hr.Carrera_id = car.Clave inner join Asignatura asig on hr.Asignatura_id = asig.Clave inner join cat_aulas aula on hr.Aula_id = aula.clave";

        public Bitacora()
        {
            InitializeComponent();
        }

       
        private void timerBitacora_Tick(object sender, EventArgs e)
        {
            labelHBitacora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFBitacora.Text = DateTime.Now.ToString("dddd dd MMMM yyy");
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridBHorario.DataSource = bindingSource1;
                GetData(sql);
            }
            catch (DataException ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }
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

        private void textBitacoraBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textBitacoraBuscar.Text;
            dataGridBHorario.DataSource = bindingSource1;
            aux = sql + " where emp.Nombre like '" + filtrado + "%' or emp.ApellidoP like '" + filtrado + "%' or car.Nombre like '" + filtrado + "%' or hr.Aula_id like '" + filtrado + "%' or  hr.Fecha like '" + filtrado + "%' or hr.Dia like '" + filtrado + "%'";
            Console.WriteLine(aux);
            GetData(aux);
        }
    }
}
