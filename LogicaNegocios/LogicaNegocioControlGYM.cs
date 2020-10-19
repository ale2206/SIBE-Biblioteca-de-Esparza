using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;
using Entidades;

namespace LogicaNegocios
{
    public class LogicaNegocioControlGYM
    {
        #region Atributos
        private String sentencia;
        #endregion
        #region Constructor
        public LogicaNegocioControlGYM()
        {
            this.sentencia = "";
        }
        #endregion
        #region Metodos
        public Boolean ingresarControlGYM(ControlHorasGYM control, Conexion conexion)
        {
            this.sentencia = "INSERT INTO controlGYM(identificacion, fechaHora) values ('" + control.identificacion + "','" + control.fechaHora + "')";
            Boolean aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
        public List<ControlHorasGYM> listaMovimientos(String fecha, Conexion conexion)
        {
            this.sentencia = "select identificacion from controlGYM where fechaHora >='" + fecha + "' and fechaHora<='" + fecha + "'";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            List<ControlHorasGYM> lista = new List<ControlHorasGYM>();
            ControlHorasGYM control;
            try
            {
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        control = new ControlHorasGYM();
                        control.identificacion = data.GetString(0).Trim();
                        lista.Add(control);
                    }
                }
            }
            catch
            {
                conexion.estadoConectionOpenOrClose(false);
                return null;
            }
            conexion.estadoConectionOpenOrClose(false);
            return lista;
        }
        
        #endregion
    }
}
