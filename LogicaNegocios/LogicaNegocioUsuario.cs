using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using AccesoDatos;

// Puto el que lo lea
//ljhgkhjgikluhgljkglhjkgkluijgljkgfdf
// ivan guapo
//el chichi
//ME CAGO EN LA PUTA
namespace LogicaNegocios
{
    public class LogicaNegocioUsuario
    {
        #region Atributos
        String sentencia ="";
        Usuario usuario;
        #endregion

        #region Constructor
        public LogicaNegocioUsuario()
        {

        }
        #endregion

        #region Metodos
        public Usuario login(String nombreUsuario, Conexion conexion)
        {
            this.sentencia = "SELECT identificacion,nombreUsuario,contraseña, estado, tipo FROM usuario WHERE nombreUsuario='" + nombreUsuario + "'";
            usuario = new Usuario();
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                usuario.identificacion = data.GetString(0);
                usuario.nombreUsuario = data.GetString(1);
                usuario.contraseña = data.GetString(2);
                usuario.estado = data.GetBoolean(3);
                usuario.tipo = data.GetString(4);
                conexion.estadoConectionOpenOrClose(false);
            }
            else
            {
                usuario = null;
            }
            return usuario;
        }

       public Boolean ingresarUsuario(Usuario usuario, Conexion conexion)
        {
            Boolean aux;
            this.sentencia = "insert into usuario(identificacion, nombreCompleto, nombreUsuario,contraseña,telefono,correo,tipo,estado) values('"+usuario.identificacion+"','"+usuario.nombreCompleto+"','"+usuario.nombreUsuario+"','"+usuario.contraseña+"',"+usuario.telefono+",'"+usuario.correo+"','"+usuario.tipo+"','"+usuario.estado+"')";
            aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }

        public Boolean modificarUsuario(Usuario usuario, Conexion conexion)
        {
            Boolean aux;
            this.sentencia = "update usuario set nombreCompleto='" + usuario.nombreCompleto + "',nombreUsuario='" + usuario.nombreUsuario + "',contraseña='" + usuario.contraseña + "',telefono=" + usuario.telefono + ",correo='" + usuario.correo + "',tipo='" + usuario.tipo + "',estado='" + usuario.estado + "' where identificacion='"+usuario.identificacion+"'";
            aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }

        public Usuario consultarUsuario(String identificacion, Conexion conexion)
        {
            usuario = new Usuario();
            this.sentencia = "SELECT identificacion, nombreCompleto, nombreUsuario, contraseña, telefono, correo, tipo, estado FROM usuario WHERE identificacion='" + identificacion + "'";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            
            if(data.Read())
            {
                usuario.identificacion = data.GetString(0);
                usuario.nombreCompleto = data.GetString(1);
                usuario.nombreUsuario = data.GetString(2);
                usuario.contraseña = data.GetString(3);
                usuario.telefono = data.GetInt32(4);
                usuario.correo = data.GetString(5);
                usuario.tipo = data.GetString(6);
                usuario.estado = data.GetBoolean(7);
                conexion.estadoConectionOpenOrClose(false);
                return usuario;
            }
            else
            {
                return null;
            }
        }
        public List<Usuario> consultarUsuarios(Conexion conexion, String nombre, String tipo)
        {
            if(tipo.Equals("Todos") && nombre.Equals(""))
            {
                this.sentencia = "SELECT identificacion, nombreCompleto, nombreUsuario, contraseña, telefono, correo, tipo, estado FROM usuario";
            }
            if(!tipo.Equals("Todos") && nombre.Equals(""))
            {
                this.sentencia = "SELECT identificacion, nombreCompleto, nombreUsuario, contraseña, telefono, correo, tipo, estado FROM usuario where tipo='"+tipo+"'";
            }
            if (tipo.Equals("Todos") && !nombre.Equals(""))
            {
                this.sentencia = "SELECT identificacion, nombreCompleto, nombreUsuario, contraseña, telefono, correo, tipo, estado FROM usuario where nombreCompleto like'%" + nombre + "%'";
            }
            if (!tipo.Equals("Todos") && !nombre.Equals(""))
            {
                this.sentencia = "SELECT identificacion, nombreCompleto, nombreUsuario, contraseña, telefono, correo, tipo, estado FROM usuario where nombreCompleto like'%" + nombre + "%' and tipo like'%"+tipo+"%'";
            }

            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            List<Usuario> lista = new List<Usuario>();
            if(data.HasRows)
            {
                while (data.Read())
                {
                    usuario = new Usuario();
                    usuario.identificacion = data.GetString(0);
                    usuario.nombreCompleto = data.GetString(1);
                    usuario.nombreUsuario = data.GetString(2);
                    usuario.contraseña = data.GetString(3);
                    usuario.telefono = data.GetInt32(4);
                    usuario.correo = data.GetString(5);
                    usuario.tipo = data.GetString(6);
                    usuario.estado = data.GetBoolean(7);
                    lista.Add(usuario);
                }
                conexion.estadoConectionOpenOrClose(false);
            }
            return lista;
        }
        #endregion
    }
}
