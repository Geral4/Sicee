using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CNUsuario
    {
        private CDUsuario objDato = new CDUsuario();
        private String _Usuario;
        private String _Contrasena;

        public String Usuario
        {
            set { _Usuario = value; }
            get { return _Usuario; }
        }
        public String Contrasena
        {
            set { _Contrasena = value; }
            get { return _Contrasena; }
        }

        public CNUsuario() { }

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.iniciarSesion(Usuario, Contrasena);
            return Loguear;
        }

        //public void editarUsuario2(string nPersonal_id, string usuario,
        //    string contrasena, string repetirContra, string acceso) //            string Id_Usuario)
        //{
        //    objDato.editarUsuario(Convert.ToInt32(nPersonal_id), usuario, contrasena, repetirContra, acceso); //             Convert.ToInt32(Id_Usuario));

        //}

    }
}