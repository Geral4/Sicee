using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CapaDatos
{
   public class CDPrestamo
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;


        public DataTable ListarAlumno()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "ListarAlumno";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }


        public int obtenerFolio()
        {
            int folio = 0;
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "select count(*) + 1 folio from prestamo";
            Coman.CommandType = CommandType.Text;
            LeerFilas = Coman.ExecuteReader();
            if (LeerFilas.Read())
            {
                folio = (int) LeerFilas.GetValue(0);
            }
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return folio;
        }


        public void insertarPrestamo (int Folio, int es_alumno, int es_usuario, string NControl_id, string NPersonal_id, DateTime FechaE, int nprestamo )

        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarPrestamo";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@Folio", Folio);
            Coman.Parameters.AddWithValue("@es_alumno",es_alumno);
            Coman.Parameters.AddWithValue("@es_usuario",es_usuario);
            Coman.Parameters.AddWithValue("@NControl_id",NControl_id);
            Coman.Parameters.AddWithValue("@NPersonal_id",NPersonal_id);
            Coman.Parameters.AddWithValue("@FechaE",FechaE);
            Coman.Parameters.AddWithValue("@nprestamo",nprestamo);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();


        }

    }
}
