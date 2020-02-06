using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDConexion
    {
        //static private string CadenaConexion = "user id=geralmiguel;password=tecnologico01;server=192.168.0.24, 2008;Trusted_Connection=false;database=Sicee;connection timeout=15";
        static private string CadenaConexion = "Server=localhost; DataBase=Sicee;Integrated Security=true";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
