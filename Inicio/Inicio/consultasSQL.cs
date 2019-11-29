using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

class consultasSQL
{
    public string strCadConexion = "", conexionRemota="";
    public SqlConnection conexion = null;
    public SqlCommand comando= null;
    public SqlDataReader lector = null;
    public int resultado = 0;
    public OleDbConnection conA= null;
    OleDbDataReader lectorAccess = null;
    OleDbCommand comandoAccess = null;



    // Métodos para access

    public void conectarAccess(string ruta)
    {

        try
        {
            string strCadConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ruta+";";
            conA = new OleDbConnection(strCadConexion);
            conA.Open();
            Console.WriteLine("Conexion establecida en: " + strCadConexion);

        }
        catch (Exception sql)
        {
            MessageBox.Show(sql.ToString(), "Error de conexión");
        }

    }


    public OleDbDataReader ConsultarAccess(string sentencia)
    {
        try
        {
            comandoAccess = new OleDbCommand(sentencia, conA);
            lectorAccess = comandoAccess.ExecuteReader();

        }
        catch (Exception consulta)
        {
            MessageBox.Show(consulta.ToString(), "Error al iniciar la consulta");
        }

        return lectorAccess;

    }

    public void cerrarA()
    {
        try
        {
            if (conA.State != ConnectionState.Closed)
            {
                conA.Close();
                Console.WriteLine("Conexión cerrada exitosamente");
            }
        }
        catch (Exception cierra)
        {
            MessageBox.Show(cierra.ToString(), "Error al cerrar la conexión");
        }
    }


    //Métodos para SQLSERVER
    public void conectar(string database, string usuario, string contra)
    {

        try
        {
            string strCadConexion = "user id=" + usuario + ";" +
                                "password=" + contra + ";server=DESKTOP-80NR32B;" +
                                "Trusted_Connection=false;" +
                                "database=" + database + ";" +
                                "connection timeout=15";
            Console.WriteLine("SQLSERVER: Conexion establecida");
            conexion = new SqlConnection(strCadConexion);
            conexion.Open();

        }
        catch (Exception sql)
        {
            MessageBox.Show(sql.ToString(), "Error de conexión");
        }

    }    

    public void conectarRemoto(string database, string usuario, string contra, string server)
    {
        try
        {
            string strCadConexion = "user id=" + usuario + ";" +
                                "password=" + contra + ";server=" + server + ";" +
                                "Trusted_Connection=false;" +
                                "database=" + database + ";" +
                                "connection timeout=15";          
            conexion = new SqlConnection(strCadConexion);
            conexion.Open();
            Console.WriteLine("SQLSERVER: Conexion establecida");

        }
        catch (Exception sql)
        {
            MessageBox.Show(sql.ToString(), "Error de conexión");
        }
    }

    public SqlDataReader Consultar(string sentencia)
    {
        try
        {
            comando = new SqlCommand(sentencia, conexion);
            lector = comando.ExecuteReader();                     

        }
        catch (Exception consulta)
        {
            MessageBox.Show(consulta.ToString(), "Error al iniciar la consulta");
        }

        return lector;

    }

    public void InsertActElim (string sentencia)
    {
        try
        {    
            comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = string.Format(sentencia);
            resultado = comando.ExecuteNonQuery();
            
            if(resultado > 0)
            {
                //MessageBox.Show("Acción generada con con éxito", "Correcto");
            }
            else
            {
                MessageBox.Show("Error al realizar la inserción, actualización o eliminación", "Incorrecto");
            }
        }
        catch (Exception consulta)
        {
            MessageBox.Show(consulta.ToString(), "Error al realizar la inserción, actualización o eliminación");
        }
        
    }

    public int InsertActElim2(string sentencia)
    {
        try
        {
            resultado = 0;
            string strCadConexion = "Integrated Security=SSPI;Persist Security Info=False;" +
            "Initial Catalog=Sicee;Data Source=localhost";
            conexion = new SqlConnection(strCadConexion);
            conexion.Open();
            Console.WriteLine("SQLSERVER: Conexion establecida");
            comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = string.Format(sentencia);
            resultado = comando.ExecuteNonQuery();

            if (resultado > 0)
            {
                //MessageBox.Show("Los cambios de han guardado correctamente", "Devoluciones");
            }
            else
            {
                //MessageBox.Show("Error al realizar la inserción, actualización o eliminación", "Incorrecto");
            }
        }
        catch (Exception consulta)
        {
            MessageBox.Show(consulta.ToString(), "Error al realizar la inserción, actualización o eliminación");
        }
        return resultado;

    }

    public int GuardaHuella(byte[] huella, string emp)
    {
        try
        {
            comando = new SqlCommand("UPDATE cat_nomina_trabajadores set huella = @huella, huella_foto = @huella where clave_empleado = '" + emp + "'", conexion);

            comando.Parameters.AddWithValue("@huella", huella);

            SqlParameter[] param = { new SqlParameter("@huella", SqlDbType.VarBinary) };
            param[0].Value = huella;

            comando.ExecuteNonQuery();

        }
        catch (Exception consulta)
        {
            resultado = 0;
            //MessageBox.Show(consulta.ToString(), "Error al realizar la inserción, actualización o eliminación");
        }
        return resultado;
    }

    public SqlCommand cargarProcedure (string procedimiento)
    {
        try
        {
            comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = procedimiento;
        } catch(Exception exct)
        {
            MessageBox.Show(exct.ToString(), "Error al cargar el procedimiento almacenado");
        }
        return comando;

    }


    public void ejecutarProcedure(SqlCommand com)
    {
        try
        {
            resultado = com.ExecuteNonQuery();

            if (resultado > 0)
            {
                MessageBox.Show("Transacción realizada con éxito", "Correcto");
            }
            else
            {
                MessageBox.Show("No se pudo realizar la transacción correctamente", "Incorrecto");
            }
        }
        catch (Exception consulta)
        {
            MessageBox.Show(consulta.ToString(), "Error al realizar la inserción, actualización o eliminación");
        }
    }


    public void cerrar()
    {
        try
        {
            if(conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
                Console.WriteLine("Conexión cerrada exitosamente");
            }
        }catch (Exception cierra)
        {
            MessageBox.Show(cierra.ToString(), "Error al cerrar la conexión");
        } 
    }
}
