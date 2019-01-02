using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDAlumno
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarCarrera()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "ListarCarrera";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void insertarAlumno (string nombre, string apellidoP, string apellidoM, string nControl,
            string curp, string sexo, int carrera, string semestre, string direccion, string telefono)
        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarAlumno";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@nombre", nombre);
            Coman.Parameters.AddWithValue("@apellidoP", apellidoP);
            Coman.Parameters.AddWithValue("@apellidoM",apellidoM);
            Coman.Parameters.AddWithValue("@nControl",nControl);
            Coman.Parameters.AddWithValue("@curp",curp);
            Coman.Parameters.AddWithValue("@sexo",sexo);
            Coman.Parameters.AddWithValue("@carrera_id",carrera);
            Coman.Parameters.AddWithValue("@semestre",semestre);
            Coman.Parameters.AddWithValue("@direccion",direccion);
            Coman.Parameters.AddWithValue("@telefono",telefono);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();

        }

        public DataTable MostrarAlumno()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "MostrarAlumno";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }


    }
}
