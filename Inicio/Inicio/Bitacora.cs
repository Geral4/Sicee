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
        private DateTime filter_date, now;
        private string sql = "", sql2 = "", fecha;
        private consultasSQL exec = new consultasSQL();


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
                sql = "select id, [N°], [Nombre Empleado], Aula, [Cantidad Alumnos], Carrera, Asignatura, [Clase/Practica], [Hora Inicio]," +
                " [Hora Fin], Observaciones, Firma from c_visor_bitacora " +
                "where format(Fecha, 'yyyyMMdd') = format(getDate(), 'yyyyMMdd')";
                dataGridBHorario.DataSource = v.llenarDataGrid(sql);
            }
            catch (DataException ex)
            {
                Console.WriteLine("Excepción producida: " + ex);
            }
        }

        private void buttonBitacoraEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonBitacoraGuardar_Click(object sender, EventArgs e)
        {
            Actualiza_cambios_bitacora();
        }

        private void btnChecador_Click(object sender, EventArgs e)
        {
            F_verificar verifica = new F_verificar();
            verifica.ShowDialog();
        }

        private void filtro_fecha_ValueChanged(object sender, EventArgs e)
        {
            filter_date = new DateTime(filtro_fecha.Value.Year, filtro_fecha.Value.Month, filtro_fecha.Value.Day);
            now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            fecha = filter_date.ToString("yyyyMMdd");
            sql2 = "select id, [N°], [Nombre Empleado], Aula, [Cantidad Alumnos], Carrera, Asignatura, [Clase/Practica], [Hora Inicio]," +
            " [Hora Fin], Observaciones, Firma from c_visor_bitacora where" +
            " (Aula like '%" + filtrado + "%' or nombre_aula like '%" + filtrado + "%') and Fecha between '"+ fecha +"' and '"+ fecha +" 23:59:59'";
            dataGridBHorario.DataSource = v.llenarDataGrid(sql2);

            if (filter_date == now)
            {
                buttonBitacoraGuardar.Enabled = true;
            }
            else
            {
                buttonBitacoraGuardar.Enabled = false;
            }
        }

        private void textBitacoraBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrado = textBitacoraBuscar.Text;            

            sql2 = "select id, [N°], [Nombre Empleado], Aula, [Cantidad Alumnos], Carrera, Asignatura, [Clase/Practica], [Hora Inicio]," +
            " [Hora Fin], Observaciones, Firma from c_visor_bitacora where" +
            " (Aula like '%"+ filtrado +"%' or nombre_aula like '%"+ filtrado + "%') and Fecha between '" + fecha + "' and '" + fecha + " 23:59:59'";
            dataGridBHorario.DataSource = v.llenarDataGrid(sql2);



        }

        private void Actualiza_cambios_bitacora()
        {
            int capacidad = 0, firma = 0, id = 0;
            string clasePract = "", obs = "";
       
            try
            {
                for (int i = 0; i < dataGridBHorario.RowCount; i++)
                {
                    firma = Convert.ToInt32(dataGridBHorario[11, i].Value);
                    //if (firma == 1)
                    //{
                    capacidad = Convert.ToInt32(dataGridBHorario[4, i].Value);
                    clasePract = dataGridBHorario[7, i].Value.ToString();
                    obs = dataGridBHorario[10, i].Value.ToString();
                    id = Convert.ToInt32(dataGridBHorario[0, i].Value);

                    sql = sql + "UPDATE Horario SET firma = " + firma + ", CAlumnos = " + capacidad + ", ClasePractica = '" + clasePract + "', " +
                        " Observaciones = '" + obs + "' WHERE id = " + id + ";\n";
                    //Console.WriteLine("Ejecuta: " + sql); 
                    //}
                }

                exec.InsertActElim2(sql);
                sql = "select id, [N°], [Nombre Empleado], Aula, [Cantidad Alumnos], Carrera, Asignatura, [Clase/Practica], [Hora Inicio]," +
                    " [Hora Fin], Observaciones, Firma from c_visor_bitacora " +
                    "where format(Fecha, 'yyyyMMdd') = format(getDate(), 'yyyyMMdd')";
                dataGridBHorario.DataSource = v.llenarDataGrid(sql);

                MessageBox.Show("Actualizado correctamente", "Bitácora de asistencia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedieron guardar los cambios. Inténtelo de nuevo.\nError: " + ex.Message, "Bitácora de asistencia");
            }
        }
    }
}
