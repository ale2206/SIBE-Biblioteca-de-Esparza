using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocios;
using AccesoDatos;

namespace Vistas
{
    public partial class FRMDevolucion : Form
    {
        private FRMMenuPrincipal frmMenu;
        private Conexion conexion;
        private LogicaNegocioDevolucion logicaDevolucion;
        private LogicaNegocioEstudiante logicaEstudiante;
        private LogicaNegocioInventario logicaInventario;
        public FRMDevolucion(Conexion conexion, FRMMenuPrincipal frmMenu)
        {
            InitializeComponent();
            this.textBoxFecha.Text = DateTime.Now.ToLongDateString() + "";
            this.logicaDevolucion = new LogicaNegocioDevolucion();
            this.logicaEstudiante = new LogicaNegocioEstudiante();
            this.logicaInventario = new LogicaNegocioInventario();
            this.frmMenu = frmMenu;
            this.conexion = conexion;
            estadoInicial();
        }
        private void estadoInicial()
        {
            dataGridViewDevolucion.Rows.Clear();
            textBoxIdentificacion.Text = "";
            textBoxIdentificacion.Enabled = true;
            textBoxNombre.Text = "";
            buttonConsultar.Enabled = true;
        }
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if(!textBoxIdentificacion.Text.Equals(""))
            {
                String identificacion = textBoxIdentificacion.Text;
                int idPrestamoPendiente = logicaDevolucion.idPrestamosPendientes(conexion, identificacion);
                Estudiante estudiante = logicaEstudiante.consultarUsuario(identificacion, conexion);
                if(idPrestamoPendiente != -1 && estudiante != null)
                {
                    textBoxNombre.Text = estudiante.nombreCompleto;
                    List<DetallePrestamo> lista = logicaDevolucion.consultarDetallesPrestamo(conexion, idPrestamoPendiente);
                    if(lista.Count>0)
                    {
                        foreach(DetallePrestamo detalle in lista)
                        {
                            dataGridViewDevolucion.Rows.Add(detalle.codigo,logicaInventario.consultarInventario(detalle.codigo+"",conexion).nombre,detalle.cantidad, "Editable");
                        }
                        buttonConsultar.Enabled = false;
                        textBoxIdentificacion.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no posee prestamos pendientes ó verifique que la identificacion sea correcta si el error persiste pongase en contacto con un tecnico", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Error, debe ingresar una identificacion primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDevolucion_Click(object sender, EventArgs e)
        {
            List<DetalleDevolucion> lista = new List<DetalleDevolucion>();
            Boolean aux = false;
            foreach (DataGridViewRow row in dataGridViewDevolucion.Rows)
            {
                try
                {
                    String cantidad = Convert.ToString(row.Cells["Cantidad"].Value).Trim();
                    String cantidadDañada = row.Cells["CantidadDañada"].Value.ToString();
                    if (!cantidad.Equals("") && !cantidadDañada.Equals("Editable") && !cantidadDañada.Equals(""))
                    {
                        int aux1 = Convert.ToInt32(cantidad);
                        int aux2 = Convert.ToInt32(cantidadDañada);
                        if (aux1 >= aux2)
                        {
                            DetalleDevolucion detalle = new DetalleDevolucion();
                            detalle.idPrestamo = 0;
                            detalle.codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
                            detalle.cantidad = aux1;
                            detalle.cantidadDañada = aux2;
                            lista.Add(detalle);
                            aux = true;
                        }
                    }
                    if(!cantidad.Equals("") && (cantidadDañada.Equals("Editable") || cantidadDañada.Equals("")))
                    {
                        int aux1 = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        DetalleDevolucion detalle = new DetalleDevolucion();
                        detalle.idPrestamo = 0;
                        detalle.codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
                        detalle.cantidad = aux1;
                        detalle.cantidadDañada = 0;
                        lista.Add(detalle);
                        aux = true;

                    }
                    if(aux)
                    {
                        Devolucion devolucion = new Devolucion();
                        devolucion.idDevolucion = 0;
                        devolucion.identificacion = textBoxIdentificacion.Text;
                        DateTime fecha = DateTime.Now;
                        string fechaFormatoSQL = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                        devolucion.fechaHora = fechaFormatoSQL;
                        devolucion.nombreUsuario = frmMenu.getUsuario().nombreUsuario;
                        devolucion.listaDetalleDevoluciones = lista;
                        DialogResult result = MessageBox.Show("Seguro que desea confirmar el prestamo", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if(logicaDevolucion.ingresarDevolucion(conexion, devolucion))
                            {
                                MessageBox.Show("Se devolvio el prestamo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error, no se efectuo la devolucion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            estadoInicial();
                        }
                        else
                        {

                        }
                    }
                    else if(!aux)
                    {
                        MessageBox.Show("Error, la cantidad dañada debe ser menor que la cantidad prestada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Error, en el campo de la tabla cantidad dañada los valores a ingresarse deben ser de tipo númerico y la cantidad dañada no puede ser mayor a la cantidad prestada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
