using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDEdificio
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;

        public void insertaEdificio (string nombre, string clave, string descripcion, int numeroaulas)

        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarEdificio";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@nombre", nombre);
            Coman.Parameters.AddWithValue("@clave", clave);
            Coman.Parameters.AddWithValue("@descripcion", descripcion);
            Coman.Parameters.AddWithValue("@numeroaulas", numeroaulas);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();
        }

        public DataTable MostrarEdificio()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "MostrarEdificio";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }


    }
}
