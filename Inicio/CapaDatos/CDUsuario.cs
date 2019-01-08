using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class CDUsuario
    {
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;

        private SqlCommand Coman = new SqlCommand();
        private SqlDataReader LeerFilas;

        

        public SqlDataReader iniciarSesion(string user, string pass)
        {
        //    //string sql = "select *from Usuario where Usuario='" + user + "'and Contrasena='" + pass + "'";
        //    //SqlCommand Comando = new SqlCommand();
        //    //Comando.Connection = Conexion.AbrirConexion();
        //    //Comando.CommandText = sql;

           SqlCommand Comando = new SqlCommand("PIniciarSesion", Conexion.AbrirConexion());
           Comando.CommandType = CommandType.StoredProcedure;
           Comando.Parameters.AddWithValue("@Usuario", user);
           Comando.Parameters.AddWithValue("@Contrasena", pass);

          leer = Comando.ExecuteReader();
           return leer;
        }

        public DataTable ListarNPersonal()
        {
            DataTable Table = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "ListarNPersonal";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Table.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Table;
        }

        public void insertarUsuario(string nPersonal_id,string nombre,string usuario,
            string contrasena,string repetirContra,string acceso)
        {
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "InsertarUsuario";
            Coman.CommandType = CommandType.StoredProcedure;
            Coman.Parameters.AddWithValue("@npersonal_id",nPersonal_id);
            Coman.Parameters.AddWithValue("@nombre", nombre);
            Coman.Parameters.AddWithValue("@usuario", usuario);
            Coman.Parameters.AddWithValue("@contrasena", contrasena);
            Coman.Parameters.AddWithValue("@repetirContra", repetirContra);
            Coman.Parameters.AddWithValue("@acceso", acceso);
            Coman.ExecuteNonQuery();
            Coman.Parameters.Clear();
        }

        //public void editarUsuario(int nPersonal_id, string usuario,
        //    string contrasena, string repetirContra, string acceso)//t Id_Usuario)
        //{
        //    Coman.Connection = Conexion.AbrirConexion();
        //    Coman.CommandText = "EditarUsuario";
        //    Coman.CommandType = CommandType.StoredProcedure;
        //    Coman.Parameters.AddWithValue("@npersonal_id", nPersonal_id);
        //    Coman.Parameters.AddWithValue("@usuario", usuario);
        //    Coman.Parameters.AddWithValue("@contrasena", contrasena);
        //    Coman.Parameters.AddWithValue("@repetirContra", repetirContra);
        //    Coman.Parameters.AddWithValue("@acceso", acceso);
        //    //            Coman.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
        //    Coman.ExecuteNonQuery();
        //    Coman.Parameters.Clear();
        //}


        public DataTable MostrarUsuario()
        {
            DataTable Tabla = new DataTable();
            Coman.Connection = Conexion.AbrirConexion();
            Coman.CommandText = "MostrarUsuario";
            Coman.CommandType = CommandType.StoredProcedure;
            LeerFilas = Coman.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
    }
}
