using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CDAsignatura
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarCarrera()
        {
            DataTable Tabla2 = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "ListarCarrera";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla2.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla2;
        }

        public void insertarAsignatura (string nombre, string clave, string carrera,int creditos,string modalidad)
        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarAsignatura";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@nombre", nombre);
            Coman.Parameters.AddWithValue("@clave",clave );
            Coman.Parameters.AddWithValue("@carrera_id", carrera);
            Coman.Parameters.AddWithValue("@creditos",creditos);
            Coman.Parameters.AddWithValue("@modalidad",modalidad);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();

        }


        public DataTable MostrarAsignatura()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "MostrarAsignatura";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

    }
}
