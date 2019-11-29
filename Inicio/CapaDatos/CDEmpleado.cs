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
    public class CDEmpleado
    {
        private CDConexion Conexion = new CDConexion();
        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;
   

        public DataTable ListarCargo()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "ListarCargo";
            Coman.CommandType = CommandType.StoredProcedure;                        
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void insertarEmpleado(string nPersonal, string nombre, string apellidoP,
        string apellidoM, string telefono, string sexo, string direccion, string cargo_id, string email, byte[] huellas= null, int manual = 0)
        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarEmpleado";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@nPersonal", nPersonal);
            Coman.Parameters.AddWithValue("@nombre", nombre);
            Coman.Parameters.AddWithValue("@apellidoP", apellidoP);
            Coman.Parameters.AddWithValue("@apellidoM", apellidoM);
            Coman.Parameters.AddWithValue("@telefono", telefono);
            Coman.Parameters.AddWithValue("@sexo", sexo);
            Coman.Parameters.AddWithValue("@direccion", direccion);
            Coman.Parameters.AddWithValue("@cargoid", cargo_id);
            Coman.Parameters.AddWithValue("@email", email);
            SqlParameter[] param = { new SqlParameter("@huella", SqlDbType.VarBinary) };
            param[0].Value = huellas;
            Coman.Parameters.AddWithValue("@huellas", huellas);
            Coman.Parameters.AddWithValue("@manual", manual);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();
        }

        public DataTable MostrarEmpleado()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "MostrarEmpleado";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
           return Tabla;
        }
    }
}
