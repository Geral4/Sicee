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
    public class CDInmueble
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;


        public DataTable ListarAula()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "ListarAula";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void insertarInmueble(string nombre, string marca, string modelo, string color, string nserie, string aula, string claveaula, string descripcion)
        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarInmueble";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@nombre", nombre);
            Coman.Parameters.AddWithValue("@marca", marca);
            Coman.Parameters.AddWithValue("@modelo", modelo);
            Coman.Parameters.AddWithValue("@color", color);
            Coman.Parameters.AddWithValue("@nserie", nserie);
            Coman.Parameters.AddWithValue("@aula",aula);
            Coman.Parameters.AddWithValue("@claveaula",claveaula);
            Coman.Parameters.AddWithValue("@descripcion",descripcion);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();

        }

        public DataTable MostrarInmueble()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "MostrarInmueble";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        
    }
}
