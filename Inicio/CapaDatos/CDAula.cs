using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDAula
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
       // private SqlDataReader LeerFilas;

        public void insertaAulas(string clave, int capacidad)
        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarAula";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@maxRegistros", capacidad);
            Coman.Parameters.AddWithValue("@claveEdif", clave);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();
        }
    }
}
