using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Entidades;
using AccesoDatos;
using LogicaNegocios;

namespace Vistas
{
    public partial class FRMPrestamo : Form
    {
        private List<Inventario> listaInventario;
        private LogicaNegocioInventario logicaInventario;
        private LogicaNegocioEstudiante logicaEstudiante;
        private LogicaNegocioPrestamo logicaPrestamo;
        private Conexion conexion;
        private Estudiante estudiante;
        private FRMMenuPrincipal menu;
        public FRMPrestamo(Conexion conexion, FRMMenuPrincipal menu)
        {
            InitializeComponent();
            this.textBoxFecha.Text = DateTime.Now.ToLongDateString()+"";
            this.logicaInventario = new LogicaNegocioInventario();
            this.logicaEstudiante = new LogicaNegocioEstudiante();
            this.logicaPrestamo = new LogicaNegocioPrestamo();
            this.menu = menu;
            this.conexion = conexion;
            this.llenarComboBox();
            this.dataGridViewPrestamo.AllowUserToAddRows = false;
            estadoInicial();
        }
        public void estadoInicial()
        {
            textBoxIdentificacion.Text = "";
            textBoxIdentificacion.Enabled = true;
            textBoxNombre.Text = "";
            textBoxFecha.Enabled = false;
            textBoxNombre.Enabled = false;
            comboBoxActivos.Text = "";
            comboBoxActivos.Enabled = false;
            numericUpDownCantidad.Value = 0;
            numericUpDownCantidad.Enabled = false;
            numericUpDownCantidad.ReadOnly = true;
            buttonAgregar.Enabled = false;
            buttonConsultar.Enabled = true;
            buttonEliminar.Enabled = false;
            dataGridViewPrestamo.Rows.Clear();

        }
        public void estadoAgregar()
        {
            textBoxIdentificacion.Enabled = false;
            comboBoxActivos.Text = "";
            comboBoxActivos.Enabled = true;
            numericUpDownCantidad.Value = 0;
            numericUpDownCantidad.Enabled = true;
            numericUpDownCantidad.ReadOnly = true;
            buttonAgregar.Enabled = true;
            buttonConsultar.Enabled = false;
            buttonEliminar.Enabled = true;
        }
        private void llenarComboBox()
        {
            listaInventario = logicaInventario.consultarListaInventario(conexion, "", "Todos", "cantidadBuenEstado");
            if(listaInventario!=null)
            {
                foreach(Inventario i in listaInventario)
                {
                    comboBoxActivos.Items.Add(i.nombre);
                }
            }
        }
        private void comboBoxActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventario inventario = listaInventario.ElementAt(comboBoxActivos.SelectedIndex);
            int cantidadDisponible = (logicaPrestamo.cantidadInventario(conexion, inventario.codigo) - logicaPrestamo.cantidadPrestados(conexion, inventario.codigo) + logicaPrestamo.cantidadDevueltos(conexion, inventario.codigo));
            numericUpDownCantidad.Maximum = cantidadDisponible;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            Inventario inventario = listaInventario.ElementAt(comboBoxActivos.SelectedIndex);
            int cantidadDisponible = (logicaPrestamo.cantidadInventario(conexion, inventario.codigo) - logicaPrestamo.cantidadPrestados(conexion, inventario.codigo) + logicaPrestamo.cantidadDevueltos(conexion, inventario.codigo));
            if (!comboBoxActivos.Text.Equals("") && numericUpDownCantidad.Value > 0)
            {
                foreach (DataGridViewRow row in dataGridViewPrestamo.Rows)
                {
                    int aux = Convert.ToInt32(Convert.ToInt32(row.Cells["Cantidad"].Value) + numericUpDownCantidad.Value);
                    if ( Convert.ToInt32(row.Cells["Codigo"].Value) == inventario.codigo)
                    {
                        if(aux <= cantidadDisponible)
                        {
                            row.Cells["Cantidad"].Value = aux;
                        }
                        else
                        {
                            MessageBox.Show("Error, la cantidad supera la cantidad permitida por disponibilidad de inventario: " + cantidadDisponible, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        existe = true;
                    }
                }
                if(!existe)
                {
                    dataGridViewPrestamo.Rows.Add(inventario.codigo, inventario.nombre, numericUpDownCantidad.Value);
                }
            }
            else
            {
                MessageBox.Show("Error de digitacion, seleccione el nombre del articulo y su cantidad correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<DetallePrestamo> getDetallesPrestamo()
        {
            List<DetallePrestamo> lista = new List<DetallePrestamo>();
            DetallePrestamo detalle;
            if(dataGridViewPrestamo.ColumnCount > 0)
            {
                foreach (DataGridViewRow row in dataGridViewPrestamo.Rows)
                {
                    detalle = new DetallePrestamo();
                    detalle.idPrestamo = 0;
                    detalle.codigo= Convert.ToInt32(row.Cells["codigo"].Value);
                    detalle.cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    lista.Add(detalle);
                }
            }
            else
            {
                lista = null;
            }
            return lista;
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewPrestamo.Rows.Count>0)
            {
                dataGridViewPrestamo.Rows.RemoveAt(dataGridViewPrestamo.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("Error, La tabla no posee elementos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            String aux = textBoxIdentificacion.Text;
            if (!aux.Equals(""))
            {
                estudiante = logicaEstudiante.consultarUsuario(aux, conexion);
                if(estudiante != null)
                {
                    textBoxNombre.Text = estudiante.nombreCompleto;
                    estadoAgregar();
                }
                else
                {
                    MessageBox.Show("Error de digitacion, ingrese una identificacion valida; si el error persiste pongase en contacto con un tecnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estadoInicial();
                }
            }
            else
            {
                MessageBox.Show("Error de digitacion, ingrese la identificacion del estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrestamo_Click(object sender, EventArgs e)
        {
            List<DetallePrestamo> lista = getDetallesPrestamo();
            Prestamo prestamo = new Prestamo();
            if(lista.Count > 0)
            {
                if(!textBoxNombre.Text.Equals(""))
                {
                    prestamo.identificacion = textBoxIdentificacion.Text;
                    DateTime fecha = DateTime.Now;
                    string fechaFormatoSQL = fecha.ToString("yyyy-MM-dd hh:mm:ss");
                    prestamo.fechaHora = fechaFormatoSQL;
                    prestamo.nombreUsuario = menu.getUsuario().nombreUsuario;
                    prestamo.listaDetalles = lista;
                    if (logicaPrestamo.prestamosPendientes(conexion,prestamo.identificacion) == 0)
                    {
                        
                        DialogResult result = MessageBox.Show("Seguro que desea confirmar el prestamo", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (logicaPrestamo.ingresarPrestamo(conexion, prestamo))
                            {
                                MessageBox.Show("Se agrego correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error, No se logro agregar, No existen el total de los articulos disponibles para el prestamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            estadoInicial();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, El estudiante posee un prestamo pendiente de devolver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, Debe consultar el usuario primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, Debe ingresar elementos para el prestamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
