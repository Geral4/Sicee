using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCarrera
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;

        public void insertarCarrera(string clave, string nombre, string descripcion)
        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarCarrera";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@clave", clave);
            Coman.Parameters.AddWithValue("@nombre",nombre);
            Coman.Parameters.AddWithValue("@descripcion",descripcion);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();
        }

        public DataTable MostrarCarrera()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "MostrarCarrera";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

    }
   
}
