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
    public class LogicaNegocioControlUsuarios
    {
        #region Atributos
        private String sentencia;
        #endregion
        #region Constructor
        public LogicaNegocioControlUsuarios()
        {
            this.sentencia = "";
        }
        #endregion
        #region Metodos
        public ControlHorasAsistente movimiento(String identificacion, String fecha, Conexion conexion)
        {
            this.sentencia = "select identificacion, fecha, entrada, salida from controlHora where identificacion='"+identificacion+"' and fecha= '"+fecha+"'";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            ControlHorasAsistente control = new ControlHorasAsistente();
            //String aux = null;
            try
            {
                if (data.Read())
                {
                    control.identificacion = data.GetString(0).Trim();
                    control.fecha = data.GetDateTime(1)+"";
                    control.entrada = data.GetValue(2)+"";
                    control.salida = data.GetValue(3)+"";
                }
                //aux = null;
            }
            catch
            {
                //aux = null;
            }
            conexion.estadoConectionOpenOrClose(false);
            return control;
        }
        public Boolean ingresarControl(ControlHorasAsistente control, Conexion conexion)
        {
            this.sentencia = "INSERT INTO controlHora(identificacion, fecha, entrada, salida) values ('"+control.identificacion+"','"+control.fecha+"','"+control.entrada+ "','" + control.salida + "')";
            Boolean aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
        public Boolean modificarControl(ControlHorasAsistente control, Conexion conexion)
        {
            this.sentencia = "UPDATE controlHora set salida='"+control.salida+"' where identificacion='"+control.identificacion+"' and fecha='"+control.fecha+"'";
            Boolean aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
        public List<ControlHorasAsistente> listaMovimientos(String fechaDesde, String fechaHasta, Conexion conexion)
        {
            this.sentencia = "select identificacion, fecha, entrada, salida from controlHora where fecha >='"+fechaDesde+"' and fecha<='"+fechaHasta+"' " +
                "order by CONVERT(date, fecha) desc ";
            Console.WriteLine("-----------------" + sentencia + "--------------");
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            List<ControlHorasAsistente> lista = new List<ControlHorasAsistente>();
            ControlHorasAsistente control;
            try
            {
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        control = new ControlHorasAsistente();
                        control.identificacion = data.GetString(0).Trim();
                        control.fecha = data.GetValue(1)+"";
                        control.entrada = data.GetValue(2)+"";
                        control.salida = data.GetValue(3) + "";
                        if (control.salida.Equals("00:00:00"))
                        {
                            control.salida = "Pendiente";
                        }
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
