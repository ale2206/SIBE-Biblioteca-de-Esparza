using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;//permite retornar el nombre del servidor


namespace AccesoDatos
{
    public class Conexion
    {
        #region Atributos
        private string DB;
        private SqlCommand comand;// realiza las sentencias
        private SqlConnection conexion;//Gusarda la cadena de conexion
        private Boolean estadoConexion;

        #endregion

        #region Propiedades

        #endregion

        #region constructor

        public Conexion()
        {
            this.DB = "BibliotecaEsparza";
            this.estadoConexion = false;
        }

        #endregion
        #region metodos
        public void estadoConectionOpenOrClose(Boolean estado)
        {
            if (estado)
            {
                conexion.Open();
            }
            else
            {
                conexion.Close();
            }
        }
        public SqlDataReader mConsultarSelect(String sentencia)
        {
            if (estadoConexion)
            {
                try
                {
                    if (estadoDeConexion())
                    {
                        estadoConectionOpenOrClose(false);
                        comand = new SqlCommand(sentencia, conexion);
                        comand.CommandType = System.Data.CommandType.Text;
                        estadoConectionOpenOrClose(true);
                        return comand.ExecuteReader();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        private string mNombreMaquina()
        {
            Console.WriteLine(Dns.GetHostName());
            return Dns.GetHostName();//retorna el nombre del servidor
        }

        public Boolean mConectar()
        {
            try
            {
                Console.WriteLine("--------------- mConectar-----------------------");
                this.conexion = new SqlConnection();
                this.conexion.ConnectionString = "user='Sa'; password='root'; server='" + mNombreMaquina() + "'; database='" + DB + "'";
                //this.conexion.ConnectionString = "user='Sa'; password='root'; server='192.168.0.32'; database='" + DB + "'";

                this.conexion.Open();
                //conexion.
                this.estadoConexion = true;
                Console.WriteLine(estadoConexion);
                

                return estadoConexion;
            }
            catch
            {
                Console.WriteLine("No conecta");
                return false;
            }
        }
        public Boolean estadoDeConexion()
        {
            return estadoConexion;
        }

        public Boolean insertarModificarEliminarDataBase(String sentencia)
        {
            if(estadoConexion)
            {
                try
                {
                    if (estadoDeConexion())
                    {
                        estadoConectionOpenOrClose(false);
                        comand = new SqlCommand(sentencia, conexion);
                        comand.CommandType = System.Data.CommandType.Text;
                        estadoConectionOpenOrClose(true);
                        comand.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            return false;
        }


        #endregion
    }
}   