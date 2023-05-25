using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public class Conexion
    {
        //SE DECLARAN LAS VARIABLE PRIVADAS
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;

        //nos permitira establecer el metodo de autenticación en SQL
        private bool seguridad;
        //crear objeto de tipo Conexión
        //compartir y realizar la conexion a la base de datos
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "registro";
            this.Servidor = "DESKTOP-GAKLA3J";
            this.Usuario = "sa";
            this.Clave = "a123";
            this.seguridad = true;
        }

        //metodo para devolver el string de conexión
        public SqlConnection crearConexion() 
        {
            //variable de tipo sqlconnection
            SqlConnection cadena = new SqlConnection();
            try
            {
                //SE CREA CADENA DE CONEXION
                cadena.ConnectionString = "Server =" + this.Servidor + "; Database=" + this.Base + ";";
                //validar el tipo de seguridad para conectarnos a SQL
                if (this.seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex; //muestra mensaje con el error de la conexion por consola
            }
            return cadena;
                        
        }
        //crear un metodo para generar una istancia la constructor dentro de la clase
        //para activar la asignacion de las variables al cosntructor

        public static Conexion crearInstancia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
