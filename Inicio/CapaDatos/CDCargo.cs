using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{


    public class CDCargo
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;
        



        public void insertarCargo(string clave, string nombre,
           string descripcion, string departamento)
        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarCargo";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@clave", clave);
            Coman.Parameters.AddWithValue("@nombre", nombre);
            Coman.Parameters.AddWithValue("@descripcion", descripcion);
            Coman.Parameters.AddWithValue("@departamento", departamento);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();
        }

        public DataTable MostrarCargo()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "MostrarCargo";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        

    }   
}
