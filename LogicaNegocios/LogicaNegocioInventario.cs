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
    public class LogicaNegocioInventario
    {
        #region Atributos
        String sentencia = "";
        Inventario inventario;
        #endregion

        #region Constructor
        public LogicaNegocioInventario()
        {

        }
        #endregion

        #region Metodos
        public Inventario consultarInventario(String codigo, Conexion conexion)
        {
            inventario = new Inventario();
            this.sentencia = "SELECT codigo, nombre, tipo, cantidadExistencia, cantidadBuenEstado, cantidadMalEstado FROM inventario WHERE codigo=" + codigo + "";
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                //inventario.codigo = data.GetInt32(0);
                inventario.nombre = data.GetString(1);
                inventario.tipo = data.GetString(2);
                inventario.cantidadExistencia = data.GetInt32(3);
                inventario.cantidadBuenEstado = data.GetInt32(4);
                inventario.cantidadMalEstado = data.GetInt32(5);
                inventario.peso = -1;
                inventario.unidadMasa = null;
                inventario.material = null;
                conexion.estadoConectionOpenOrClose(false);
                if (inventario.tipo.Equals("Discos") || inventario.tipo.Equals("Mancuernas"))
                {
                    MancuernasDiscos aux = mancuernasDiscos(codigo,conexion);
                    if (aux != null)
                    {
                        inventario.peso = aux.peso;
                        inventario.unidadMasa = aux.unidadMasa;
                        inventario.material = aux.material;
                    }
                    else
                    {
                        return null;
                    }
                }
                return inventario;
            }
            else
            {
                return null;
            }
        }

        public MancuernasDiscos mancuernasDiscos(String codigo, Conexion conexion)
        {
            MancuernasDiscos aux = new MancuernasDiscos();
            this.sentencia = "SELECT codigo, peso, unidadMasa, material FROM mancuernasDiscos WHERE codigo=" + codigo;
            SqlDataReader data = conexion.mConsultarSelect(sentencia);
            if (data.Read())
            {
                aux.peso = data.GetInt32(1);
                aux.unidadMasa = data.GetString(2);
                aux.material = data.GetString(3);
            }
            else
            {
                aux = null;
                Console.Error.WriteLine("Error en la consulta de tipo de mancuernasDiscos");
            }
            conexion.estadoConectionOpenOrClose(false);
            return aux;
        }
        public Boolean ingresarInventario(Inventario inventario, Conexion conexion)
        {
            Boolean aux1;
            Boolean aux2;
            this.sentencia = "insert into inventario(codigo, nombre, tipo, cantidadExistencia, cantidadBuenEstado,cantidadMalEstado) values(" + inventario.codigo + ",'" + inventario.nombre + "','" + inventario.tipo + "'," + inventario.cantidadExistencia + "," + inventario.cantidadBuenEstado + "," + inventario.cantidadMalEstado+" )";
            aux1 = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            if(inventario.tipo.Equals("Discos") || inventario.tipo.Equals("Mancuernas"))
            {
                this.sentencia = "insert into mancuernasDiscos(codigo, peso, unidadMasa, material) values(" + inventario.codigo + "," + inventario.peso + ",'" + inventario.unidadMasa + "','" + inventario.material + "' )";
                aux2 = conexion.insertarModificarEliminarDataBase(sentencia);
                conexion.estadoConectionOpenOrClose(false);
                if (aux1 == true && aux2 == true)
                {
                    return true;
                }
                else
                {
                    this.sentencia = "DELETE inventario WHERE codigo= " + inventario.codigo + "";
                    conexion.insertarModificarEliminarDataBase(sentencia);
                    conexion.estadoConectionOpenOrClose(false);
                    this.sentencia = "DELETE mancuernasDiscos WHERE codigo= " + inventario.codigo + "";
                    conexion.insertarModificarEliminarDataBase(sentencia);
                    conexion.estadoConectionOpenOrClose(false);
                    return false;
                }
            }
            return aux1;
            
        }

        public Boolean modificarInventario(Inventario inventario, Conexion conexion)
        {
            Boolean aux1;
            Boolean aux2;
            this.sentencia = "update inventario set nombre='" + inventario.nombre + "', tipo='" + inventario.tipo + "', cantidadExistencia=" + inventario.cantidadExistencia + ",cantidadBuenEstado=" + inventario.cantidadBuenEstado + ",cantidadMalEstado=" + inventario.cantidadMalEstado + " where codigo="+inventario.codigo+"";
            aux1 = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            this.sentencia = "update mancuernasDiscos set peso=" + inventario.peso + ", unidadMasa='" + inventario.unidadMasa + "', material='" + inventario.material + "' where codigo="+inventario.codigo+"";
            aux2 = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            if (aux1 && aux2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean eliminarInventario(String codigo, Conexion conexion)
        {
            Boolean aux;
            this.sentencia = "delete inventario where codigo = " + codigo + "";
            aux = conexion.insertarModificarEliminarDataBase(sentencia);
            conexion.estadoConectionOpenOrClose(false);
            if(inventario.tipo.Equals("Discos") || inventario.tipo.Equals("Mancuernas"))
            {
                this.sentencia = "delete mancuernasDiscos where codigo = " + codigo + "";
                aux = conexion.insertarModificarEliminarDataBase(sentencia);
                conexion.estadoConectionOpenOrClose(false);
            }
            return aux;
        }

        public List<Inventario> consultarListaInventario(Conexion conexion, String nombre, String tipo, String estado)
        {
            List<Inventario> lista = null;
            if (estado!=null && tipo != null)
            {
                String auxSentencia = "";
                String auxWhere = "";
                if (estado.Equals("cantidadBuenEstado"))
                {
                    auxSentencia = "cantidadExistencia-cantidadMalEstado";
                    auxWhere = "0 < (cantidadExistencia-cantidadMalEstado)";
                }
                if (estado.Equals("cantidadMalEstado"))
                {
                    auxSentencia = "cantidadExistencia-cantidadBuenEstado";
                    auxWhere = "0 < (cantidadExistencia-cantidadBuenEstado)";
                }

                if (nombre.Equals("") && tipo.Equals("Todos") && estado.Equals("Todos"))
                {
                    this.sentencia = "SELECT codigo, nombre, tipo, cantidadExistencia, cantidadBuenEstado, cantidadMalEstado FROM inventario";
                }
                if (!nombre.Equals("") && tipo.Equals("Todos") && estado.Equals("Todos"))
                {
                    this.sentencia = "SELECT codigo, nombre, tipo, cantidadExistencia, cantidadBuenEstado, cantidadMalEstado FROM inventario WHERE nombre like'%" + nombre + "%'";
                }
                if (nombre.Equals("") && !tipo.Equals("Todos") && estado.Equals("Todos"))
                {
                    this.sentencia = "SELECT codigo, nombre, tipo, cantidadExistencia, cantidadBuenEstado, cantidadMalEstado FROM inventario WHERE tipo= '" + tipo + "'";
                }
                if (nombre.Equals("") && tipo.Equals("Todos") && !estado.Equals("Todos"))
                {
                    this.sentencia = "SELECT codigo, nombre, tipo, " + auxSentencia + " FROM inventario where " + auxWhere + "";
                }
                if (!nombre.Equals("") && !tipo.Equals("Todos") && estado.Equals("Todos"))
                {
                    this.sentencia = "SELECT codigo, nombre, tipo, cantidadExistencia, cantidadBuenEstado, cantidadMalEstado FROM inventario WHERE nombre like'%" + nombre + "%' AND tipo= '" + tipo + "'";
                }
                if (nombre.Equals("") && !tipo.Equals("Todos") && !estado.Equals("Todos"))
                {
                    this.sentencia = "SELECT codigo, nombre, tipo, " + auxSentencia + " FROM inventario WHERE tipo= '" + tipo + "' and " + auxWhere + "";
                }
                if (!nombre.Equals("") && tipo.Equals("Todos") && !estado.Equals("Todos"))
                {
                    this.sentencia = "SELECT codigo, nombre, tipo, " + auxSentencia + " FROM inventario WHERE nombre like'%" + nombre + "%' and " + auxWhere + "";
                }
                if (!nombre.Equals("") && !tipo.Equals("Todos") && !estado.Equals("Todos"))
                {
                    this.sentencia = "SELECT codigo, nombre, tipo, " + auxSentencia + " FROM inventario WHERE nombre like'%" + nombre + "%' AND tipo= '" + tipo + "' and " + auxWhere + "";
                }
                SqlDataReader data = conexion.mConsultarSelect(sentencia);
                lista = new List<Inventario>();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if (estado.Equals("cantidadBuenEstado"))
                        {
                            inventario = new Inventario();
                            inventario.codigo = data.GetInt32(0);
                            inventario.nombre = data.GetString(1);
                            inventario.tipo = data.GetString(2);
                            inventario.cantidadBuenEstado = data.GetInt32(3);
                            lista.Add(inventario);
                        }
                        if (estado.Equals("cantidadMalEstado"))
                        {
                            inventario = new Inventario();
                            inventario.codigo = data.GetInt32(0);
                            inventario.nombre = data.GetString(1);
                            inventario.tipo = data.GetString(2);
                            inventario.cantidadMalEstado = data.GetInt32(3);
                            lista.Add(inventario);
                        }
                        else if(!estado.Equals("cantidadBuenEstado") && !estado.Equals("cantidadMalEstado"))
                        {
                            inventario = new Inventario();
                            inventario.codigo = data.GetInt32(0);
                            inventario.nombre = data.GetString(1);
                            inventario.tipo = data.GetString(2);
                            inventario.cantidadExistencia = data.GetInt32(3);
                            inventario.cantidadBuenEstado = data.GetInt32(4);
                            inventario.cantidadMalEstado = data.GetInt32(5);
                            lista.Add(inventario);
                        }
                    }
                    conexion.estadoConectionOpenOrClose(false);
                }
            }
            return lista;
        }

        #endregion
    }
}
