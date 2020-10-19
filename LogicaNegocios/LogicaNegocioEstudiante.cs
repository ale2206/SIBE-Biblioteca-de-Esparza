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
    public class LogicaNegocioEstudiante
    {
        #region Atributos
        private String sentencia;
        private Estudiante estudiante;
        #endregion

        #region Constructor
        public LogicaNegocioEstudiante()
        {
            this.sentencia = "";
        }
        #endregion

        #region Metodos
        public Estudiante consultarUsuario(String identificacion, Conexion conexion)
        {
            estudiante = new Estudiante();
            this.sentencia = "SELECT identificacion, nombreCompleto, carrera, padecimientos, telefono, correo, tipo FROM estudiante WHERE identificacion='" + identificacion + "'";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                estudiante.identificacion = data.GetString(0);
                estudiante.nombreCompleto = data.GetString(1);
                estudiante.carrera = data.GetString(2);
                estudiante.padecimientos = data.GetString(3);
                estudiante.telefono = data.GetInt32(4);
                estudiante.correo = data.GetString(5);
                estudiante.tipo = data.GetString(6);
                conexion.estadoConectionOpenOrClose(false);
                return estudiante;
            }
            else
            {
                return null;
            }
        }

        public Boolean ingresarUsuario(Estudiante estudiante, Conexion conexion)
        {
            Boolean aux;
            this.sentencia = "insert into estudiante(identificacion, nombreCompleto, carrera, padecimientos, telefono,correo,tipo) values('" + estudiante.identificacion + "','" + estudiante.nombreCompleto + "','" + estudiante.carrera + "','" + estudiante.padecimientos + "'," + estudiante.telefono + ",'" + estudiante.correo + "','" + estudiante.tipo + "')";
            aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }

        public Boolean modificarUsuario(Estudiante estudiante, Conexion conexion)
        {
            Boolean aux;
            this.sentencia = "update estudiante set nombreCompleto='" + estudiante.nombreCompleto + "', carrera='" + estudiante.carrera + "', padecimientos='" + estudiante.padecimientos + "',telefono=" + estudiante.telefono + ",correo='" + estudiante.correo + "',tipo='" + estudiante.tipo + "' where identificacion='" + estudiante.identificacion + "'";
            aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
        public Boolean eliminarUsuario(String identificacion, Conexion conexion)
        {
            Boolean aux;
            this.sentencia = "delete estudiante where identificacion = '" + estudiante.identificacion + "'";
            aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }

        public List<Estudiante> consultarUsuarios(Conexion conexion, String nombre, String tipo)
        {
            if (tipo.Equals("Todos") && nombre.Equals(""))
            {
                this.sentencia = "SELECT identificacion, nombreCompleto, carrera, padecimientos, telefono, correo, tipo FROM estudiante";
            }
            if (!tipo.Equals("Todos") && nombre.Equals(""))
            {
                this.sentencia = "SELECT identificacion, nombreCompleto, carrera, padecimientos, telefono, correo, tipo FROM estudiante where tipo='" + tipo + "'";
            }
            if (tipo.Equals("Todos") && !nombre.Equals(""))
            {
                this.sentencia = "SELECT identificacion, nombreCompleto, carrera, padecimientos, telefono, correo, tipo FROM estudiante where nombreCompleto like'%" + nombre + "%'";
            }
            if (!tipo.Equals("Todos") && !nombre.Equals(""))
            {
                this.sentencia = "SELECT identificacion, nombreCompleto, carrera, padecimientos, telefono, correo, tipo FROM estudiante where nombreCompleto like'%" + nombre + "%' and tipo like'%" + tipo + "%'";
            }

            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            List<Estudiante> lista = new List<Estudiante>();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    estudiante = new Estudiante();
                    estudiante.identificacion = data.GetString(0);
                    estudiante.nombreCompleto = data.GetString(1);
                    estudiante.carrera = data.GetString(2);
                    estudiante.padecimientos = data.GetString(3);
                    estudiante.telefono = data.GetInt32(4);
                    estudiante.correo = data.GetString(5);
                    estudiante.tipo = data.GetString(6);
                    lista.Add(estudiante);
                }
                conexion.estadoConectionOpenOrClose(false);
            }
            return lista;
        }

        #endregion
    }
}
