using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public class DatosSQL
    {
        //METODO PARA LISTAR LOS ELEMENTOS DE LA TABLA -registro-
        public DataTable Listar()
        {
            //nos permite leer una secuencia de filas en una tabla
            //dentro de SQL server
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            //conectarse a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Personas";
                con = Conexion.crearInstancia().crearConexion(); //devuelve el string de conexion
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                lista = comando.ExecuteReader();
                Tabla.Load(lista);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); //cerramos la conexion
                }
            }
        }
        //METODO PARA REALIZAR BUSQUEDAS DENTRO DE LOS REGISTROS
        public DataTable Buscar(string valor)
        {
            //nos permite leer una secuencia de filas en una tabla
            //dentro de SQL server
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            //conectarse a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {              
                string sql = "Select * from Personas where perNombres like '%' +'" + valor + "'+ '%' or perApellidos like '%' +'"+valor+ "'+ '%' or perCUI like +'"+valor+ "'+ '%'";
                con = Conexion.crearInstancia().crearConexion(); //devuelve el string de conexion
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                lista = comando.ExecuteReader();
                Tabla.Load(lista);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); //cerramos la conexion
                }
            }
        }
        //METODO PARA INSERTAR LOS REGISTROS
        public string Insertar(user obj)
        {
            string respuesta = "";
            //conectarse a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Insert into Personas (perNombres,perApellidos,perGenero,perCUI,perFecha,perPais,perDepartamento,perMunicipio) values(" +
                    "'"+obj.perNombres+"'," +
                    "'"+obj.perApellidos+"'," +
                    "'"+obj.perGenero+"'," +
                    "'"+obj.perCUI+"'," +
                    "'"+obj.perFecha+"'," +
                    "'"+obj.perPais+"'," +
                    "'"+obj.perDepartamento+"'," +
                    "'"+obj.perMunicipio+"')";
                con = Conexion.crearInstancia().crearConexion(); //devuelve el string de conexion
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Registro no Ingresado"; //if de una fila
                /*if(comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }//if clasico
                else     
                {
                    respuesta = "No se pudo ingresar el registro";
                }*/
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); //cerramos la conexion
                }
            }
            return respuesta;
        }
    }
}
