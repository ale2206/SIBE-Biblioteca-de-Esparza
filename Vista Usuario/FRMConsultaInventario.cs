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
using AccesoDatos;
using LogicaNegocios;
namespace Vistas
{
    public partial class FRMConsultaInventario : Form
    {
        private LogicaNegocioInventario logica;
        private Conexion conexion;
        private String [] columnasDataGridView = new String[] { "Codigo", "Nombre", "Tipo", "Existencia", "Buen Estado", "Mal Estado" };
        public FRMConsultaInventario(Conexion conexion)
        {
            InitializeComponent();
            this.logica = new LogicaNegocioInventario();
            this.conexion = conexion;
            this.radioButtonAccesorios.CheckedChanged += new EventHandler(radioButton_CheckedChanged);// Con esta linea la ventana escucha los eventos de los radio button
            this.radioButtonDiscos.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioButtonImplementoDeportivo.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioButtonMancuernas.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioButtonTodos.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            estadoInicial();
        }

        private void estadoInicial()
        {
            comboBoxEstado.Text = "Todos";
            radioButtonTodos.Checked = true;
            textBoxNombre.Text = "";
            //llenarDataGridView();
        }
        private string getTipo()
        {
            String tipo = null;
            if (radioButtonMancuernas.Checked)
            {
                tipo = radioButtonMancuernas.Text;
            }
            if (radioButtonDiscos.Checked)
            {
                tipo = radioButtonDiscos.Text;
            }
            if (radioButtonAccesorios.Checked)
            {
                tipo = radioButtonAccesorios.Text;
            }
            if (radioButtonImplementoDeportivo.Checked)
            {
                tipo = radioButtonImplementoDeportivo.Text;
            }
            if(radioButtonTodos.Checked)
            {
                tipo = radioButtonTodos.Text;
            }
            return tipo;
        }
        private String getEstado()
        {
            if(comboBoxEstado.Text.Equals("Buen Estado"))
            {
                return "cantidadBuenEstado";
            }
            if (comboBoxEstado.Text.Equals("Mal Estado"))
            {
                return "cantidadMalEstado";
            }
            else if(!comboBoxEstado.Text.Equals("Mal Estado") && !comboBoxEstado.Text.Equals("Buen Estado"))
            {
                return "Todos";
            }
            return null;
        }
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void comboBoxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }
        private void llenarDataGridView()
        {
            limpiarDataGridView();
            List<Inventario> lista = this.logica.consultarListaInventario(this.conexion, textBoxNombre.Text, getTipo(), getEstado());
            if(lista != null)
            {
                if (comboBoxEstado.Text.Equals("Buen Estado"))
                {
                    int count = 0;
                    dataGridViewInventario.Columns.Clear();
                    for (int i = 0; i < columnasDataGridView.Length; i++)
                    {
                        if (!columnasDataGridView[i].Equals("Existencia") && !columnasDataGridView[i].Equals("Mal Estado"))
                        {
                            dataGridViewInventario.Columns.Add(columnasDataGridView[i], columnasDataGridView[i]);
                            dataGridViewInventario.Columns[count].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            count++;
                        }

                    }
                    foreach (Inventario inventario in lista)
                    {
                        dataGridViewInventario.Rows.Add(inventario.codigo, inventario.nombre, inventario.tipo, inventario.cantidadBuenEstado);
                    }
                }
                if (comboBoxEstado.Text.Equals("Mal Estado"))
                {
                    int count = 0;
                    dataGridViewInventario.Columns.Clear();
                    for (int i = 0; i < columnasDataGridView.Length; i++)
                    {
                        if (!columnasDataGridView[i].Equals("Existencia") && !columnasDataGridView[i].Equals("Buen Estado"))
                        {
                            dataGridViewInventario.Columns.Add(columnasDataGridView[i], columnasDataGridView[i]);
                            dataGridViewInventario.Columns[count].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            count++;
                        }

                    }
                    foreach (Inventario inventario in lista)
                    {
                        dataGridViewInventario.Rows.Add(inventario.codigo, inventario.nombre, inventario.tipo, inventario.cantidadMalEstado);
                    }
                }
                else if (comboBoxEstado.Text.Equals("Todos"))
                {
                    dataGridViewInventario.Columns.Clear();
                    for (int i = 0; i < columnasDataGridView.Length; i++)
                    {
                        dataGridViewInventario.Columns.Add(columnasDataGridView[i], columnasDataGridView[i]);
                        dataGridViewInventario.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    }
                    foreach (Inventario inventario in lista)
                    {
                        dataGridViewInventario.Rows.Add(inventario.codigo, inventario.nombre, inventario.tipo, inventario.cantidadExistencia, inventario.cantidadBuenEstado, inventario.cantidadMalEstado);
                    }
                }
            }

        }
        private void limpiarDataGridView()
        {
            dataGridViewInventario.Rows.Clear();
        }
    }
}
