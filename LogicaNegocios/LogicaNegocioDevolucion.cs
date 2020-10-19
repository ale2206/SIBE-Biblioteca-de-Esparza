using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data.SqlClient;

namespace LogicaNegocios
{
    public class LogicaNegocioDevolucion
    {
        #region Atributos
        private String sentencia;
        private DetallePrestamo detalle;
        #endregion

        #region Constructor
        public LogicaNegocioDevolucion()
        {
            this.sentencia = "";
            this.detalle = null;
        }
        #endregion
        #region Metodos
        public int ultimoIdDevolucion(Conexion conexion)
        {
            this.sentencia = "begin tran select COUNT(*)+1 from devolucion (tablock)";
            //conexion.estadoConectionOpenOrClose(false);
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                return data.GetInt32(0);
            }
            conexion.estadoConectionOpenOrClose(false);
            return -1;
        }
        public int idPrestamosPendientes(Conexion conexion, String identificacion)
        {
            int aux = 0;
            this.sentencia = "select idPrestamo from prestamo where idPrestamo not in(select idPrestamo from devolucion where identificacion='" + identificacion + "') and identificacion= '" + identificacion + "'";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            try
            {
                if (data.Read())
                {
                    aux = data.GetInt32(0);
                }
                else
                {
                    aux = -1;
                }
            }
            catch
            {
                aux = -1;
            }
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
        public List<DetallePrestamo> consultarDetallesPrestamo(Conexion conexion, int idPrestamo)
        {
            this.sentencia = "SELECT idPrestamo, codigo, cantidad FROM detallePrestamo where idPrestamo = " + idPrestamo + "";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            List<DetallePrestamo> lista = new List<DetallePrestamo>();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    detalle = new DetallePrestamo();
                    detalle.idPrestamo = data.GetInt32(0);
                    detalle.codigo = data.GetInt32(1);
                    detalle.cantidad = data.GetInt32(2);
                    lista.Add(detalle);
                }
                conexion.estadoConectionOpenOrClose(false);
            }
            return lista;
        }
        public Boolean ingresarDevolucion(Conexion conexion, Devolucion devolucion)
        {
            Boolean aux1 = false;
            Boolean aux2 = false;
            Boolean aux3 = true;
            Boolean aux4 = true;
            int idDevolucion = ultimoIdDevolucion(conexion);
            int count = 0;
            int idPrestamo = idPrestamosPendientes(conexion, devolucion.identificacion);
            transaccion(conexion);
            this.sentencia = "insert into devolucion(idDevolucion, identificacion, fechaHora, nombreUsuario, idPrestamo) values(" + idDevolucion + ",'" + devolucion.identificacion + "','" + devolucion.fechaHora + "','" + devolucion.nombreUsuario + "',"+idPrestamo+" )";
            aux1 = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            do
            {
                DetalleDevolucion detalle = devolucion.listaDetalleDevoluciones[count];
                if (detalle.cantidadDañada != 0)
                {
                    this.sentencia = "insert into detalleDevolucion(idDevolucion, codigo, cantidad) values(" + idDevolucion + "," + detalle.codigo + "," + detalle.cantidad + " )";
                    aux2 = conexion.insertarModificarEliminarDataBase(sentencia);
                    conexion.estadoConectionOpenOrClose(false);
                    this.sentencia = "update inventario set cantidadMalEstado = cantidadMalEstado+"+detalle.cantidadDañada+" where codigo = "+detalle.codigo+"";
                    aux4 = conexion.insertarModificarEliminarDataBase(sentencia);
                    conexion.estadoConectionOpenOrClose(false);
                    this.sentencia = "update inventario set cantidadBuenEstado = cantidadBuenEstado-"+detalle.cantidadDañada+" where codigo = "+detalle.codigo+"";
                    aux4 = conexion.insertarModificarEliminarDataBase(sentencia);
                    conexion.estadoConectionOpenOrClose(false);
                }
                else
                {
                    this.sentencia = "insert into detalleDevolucion(idDevolucion, codigo, cantidad) values(" + idDevolucion + "," + detalle.codigo + "," + detalle.cantidad + " )";
                    aux2 = conexion.insertarModificarEliminarDataBase(sentencia);
                    conexion.estadoConectionOpenOrClose(false);
                }
                count++;
            } while (aux2 && aux3 && aux4 &&count < devolucion.listaDetalleDevoluciones.Count);
            if (aux1 && aux2 && aux3 && aux4)
            {
                this.sentencia = "commit";
                conexion.insertarModificarEliminarDataBase(sentencia);
                conexion.estadoConectionOpenOrClose(false);
                return true;
            }
            else
            {
                this.sentencia = "rollback";
                conexion.insertarModificarEliminarDataBase(sentencia);
                conexion.estadoConectionOpenOrClose(false);
                return false;
            }
        }
        public void transaccion(Conexion conexion)
        {
            this.sentencia = "begin tran";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            conexion.estadoConectionOpenOrClose(false);
        }
        #endregion
    }
}
