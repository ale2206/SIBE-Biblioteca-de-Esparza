using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;

namespace LogicaNegocios
{
    public class LogicaNegocioPrestamo
    {
        #region Atributos
        String sentencia = "";
        #endregion
        public int ultimoIdPrestamo(Conexion conexion)
        {
            this.sentencia = "begin tran select COUNT(*)+1 from prestamo (tablock)";
            //conexion.estadoConectionOpenOrClose(false);
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if(data.Read())
            {
                return data.GetInt32(0);
            }
            conexion.estadoConectionOpenOrClose(false);
            return -1;
        }
        public int cantidadInventario(Conexion conexion, int codigo)
        {
            this.sentencia = "select cantidadBuenEstado from inventario where codigo = "+codigo+"";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                return data.GetInt32(0);
            }
            conexion.estadoConectionOpenOrClose(false);
            return 0;
        }
        public int cantidadPrestados(Conexion conexion, int codigo)
        {
            int aux = 0;
            this.sentencia = "select SUM(cantidad) as cantidad from detallePrestamo where codigo = " + codigo + "";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                try
                {
                    aux = data.GetInt32(0);
                }
                catch
                {
                    aux = 0;
                }
            }
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
        public int cantidadDevueltos(Conexion conexion, int codigo)
        {
            int aux = 0;
            this.sentencia = "select SUM(cantidad) as cantidad from detalleDevolucion where codigo = " + codigo + "";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                try
                {
                    aux = data.GetInt32(0);
                }
                catch
                {
                    aux = 0;
                }
            }
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
        public Boolean ingresarPrestamo(Conexion conexion, Prestamo prestamo)
        {
            Boolean aux1 = false;
            Boolean aux2 = false;
            int idPrestamo = ultimoIdPrestamo(conexion);
            int count =0;
            this.sentencia = "insert into prestamo(idPrestamo, identificacion, fechaHora, nombreUsuario) values(" + idPrestamo + ",'" + prestamo.identificacion + "','" + prestamo.fechaHora + "','" + prestamo.nombreUsuario +"' )";
            aux1 = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            do
            {
                int codigo = prestamo.listaDetalles.ElementAt(count).codigo;
                if (cantidadInventario(conexion, codigo) - cantidadPrestados(conexion, codigo) + cantidadDevueltos(conexion, codigo) > 0)
                {
                    this.sentencia = "insert into detallePrestamo(idPrestamo, codigo, cantidad) values(" + idPrestamo + "," + prestamo.listaDetalles.ElementAt(count).codigo + "," + prestamo.listaDetalles.ElementAt(count).cantidad + " )";
                    aux2 = conexion.insertarModificarEliminarDataBase(sentencia);
                    conexion.estadoConectionOpenOrClose(false);
                }
                else
                {
                    aux2=false;
                }
                count++;
            } while (aux2 && count<prestamo.listaDetalles.Count);
            if(aux1 && aux2)
            {
                return true;
            }
            else
            {
                this.sentencia = "delete prestamo where idPrestamo = "+idPrestamo+"";
                conexion.insertarModificarEliminarDataBase(sentencia);
                conexion.estadoConectionOpenOrClose(false);
                this.sentencia = "delete detallePrestamo where idPrestamo = " + idPrestamo + "";
                conexion.insertarModificarEliminarDataBase(sentencia);
                conexion.estadoConectionOpenOrClose(false);
                return false;
            }
        }
        public int prestamosPendientes(Conexion conexion, String identificacion)
        {
            int aux = 0;
            this.sentencia = "select COUNT(idPrestamo) from prestamo where idPrestamo not in(select idPrestamo from devolucion where identificacion='"+identificacion+"') and identificacion= '"+identificacion+"'";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                try
                {
                    aux = data.GetInt32(0);
                }
                catch
                {
                    aux = 0;
                }
            }
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
    }
}
