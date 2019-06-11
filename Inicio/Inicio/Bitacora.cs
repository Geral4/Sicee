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
        private string filtrado = "";
        private Validar v = new Validar();

        private string sql = "", sql2= "";
                   

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
                sql =  "select[N°], [Nombre Empleado], Aula, [Cantidad Alumnos], Carrera, Asignatura, [Clase/Practica], [Hora Inicio]," +
                " [Hora Fin], Observaciones, Firma from c_visor_bitacora " +
                "where format(Fecha, 'yyyyMMdd') = format(getDate(), 'yyyyMMdd')";
                dataGridBHorario.DataSource = v.llenarDataGrid(sql);
            }
            catch (DataException ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }
        }

        
        
        private void textBitacoraBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textBitacoraBuscar.Text;            

            sql2 = "select [N°], [Nombre Empleado], Aula, [Cantidad Alumnos], Carrera, Asignatura, [Clase/Practica], [Hora Inicio]," +
            " [Hora Fin], Observaciones, Firma from c_visor_bitacora where " +
            " (Aula like '%"+ filtrado +"%' or nombre_aula like '%"+ filtrado +"%')";

            if (filtrado.Equals(""))
                dataGridBHorario.DataSource = v.llenarDataGrid(sql);
            else
                dataGridBHorario.DataSource = v.llenarDataGrid(sql2);



        }
    }
}
