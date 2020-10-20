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
    public partial class FRMInventario : Form
    {
        private Inventario inventario;
        private LogicaNegocioInventario logica;
        private Conexion conexion;
        private int modificar;
        public FRMInventario(Conexion conexion)
        {
            InitializeComponent();
            estadoInicial();
            this.conexion = conexion;
            this.modificar = 0;
            this.logica = new LogicaNegocioInventario();
        }
        public void estadoInicial()
        {
            textBoxCodigo.Text = "";
            textBoxCodigo.Enabled = true;
            textBoxNombre.Text = "";
            textBoxNombre.Enabled=false;
            textBoxMaterial.Text = "";
            textBoxMaterial.Enabled = false;
            radioButtonAccesorios.Checked = false;
            radioButtonAccesorios.Enabled = false;
            radioButtonDiscos.Checked = false;
            radioButtonDiscos.Enabled = false;
            radioButtonImplementoDeportivo.Checked = false;
            radioButtonImplementoDeportivo.Enabled = false;
            radioButtonMancuernas.Checked = false;
            radioButtonMancuernas.Enabled = false;
            numericUpDownCantidadBuenEstado.Value = 0;
            numericUpDownCantidadBuenEstado.Enabled = false;
            numericUpDownCantidadMalEstado.Value = 0;
            numericUpDownCantidadMalEstado.Enabled = false;
            numericUpDownCantidadExistencia.Value = 0;
            numericUpDownCantidadExistencia.Enabled = false;
            comboBoxUnidadMasa.Text = "";
            comboBoxUnidadMasa.Enabled = false;
            numericUpDownPeso.Value = 0;
            numericUpDownPeso.Enabled = false;
            buttonConsultar.Enabled = true;
            buttonAgregar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
        }
        public void estadoAgregar(int estado)
        {
            if(estado == 1)
            {
                textBoxCodigo.Enabled = false;
                radioButtonAccesorios.Enabled = true;
                radioButtonDiscos.Enabled = true;
                radioButtonImplementoDeportivo.Enabled = true;
                radioButtonMancuernas.Enabled = true;
                buttonConsultar.Enabled = false;
                buttonAgregar.Enabled = false;
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
                //modificar = 2;
            }
            else
            {
                textBoxNombre.Enabled = true;
                numericUpDownCantidadBuenEstado.Enabled = true;
                numericUpDownCantidadMalEstado.Enabled = true;
                numericUpDownCantidadExistencia.Enabled = true;

                buttonAgregar.Enabled = true;
                if(radioButtonMancuernas.Checked || radioButtonDiscos.Checked)
                {
                    numericUpDownPeso.Enabled = true;
                    comboBoxUnidadMasa.Enabled = true;
                    textBoxMaterial.Enabled = true;
                }
            }
        }
        public void estadoModificarEliminar()
        {
                textBoxCodigo.Enabled = false;
                radioButtonAccesorios.Enabled = true;
                radioButtonDiscos.Enabled = true;
                radioButtonImplementoDeportivo.Enabled = true;
                radioButtonMancuernas.Enabled = true;
                buttonConsultar.Enabled = false;
                buttonAgregar.Enabled = false;
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
                textBoxNombre.Enabled = true;
                numericUpDownCantidadBuenEstado.Enabled = true;
                numericUpDownCantidadMalEstado.Enabled = true;
                numericUpDownCantidadExistencia.Enabled = true;
                numericUpDownPeso.Enabled = false;
                comboBoxUnidadMasa.Enabled = false;
                textBoxMaterial.Enabled = false;
                if (radioButtonMancuernas.Checked || radioButtonDiscos.Checked)
                {
                    numericUpDownPeso.Enabled = true;
                    comboBoxUnidadMasa.Enabled = true;
                    textBoxMaterial.Enabled = true;
                }
                modificar = 2;
        }
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if(!textBoxCodigo.Text.Trim().Equals(""))
            {
                escucharRadioButton();
                try
                {
                    inventario = logica.consultarInventario(textBoxCodigo.Text, conexion);
                    if (inventario != null)
                    {
                        textBoxNombre.Text = inventario.nombre;
                        setTipo(inventario.tipo);
                        numericUpDownCantidadExistencia.Value = inventario.cantidadExistencia;
                        numericUpDownCantidadBuenEstado.Value = inventario.cantidadBuenEstado;
                        numericUpDownCantidadMalEstado.Value = inventario.cantidadMalEstado;
                        numericUpDownPeso.Value = 0;

                        if (inventario.tipo.Equals("Mancuernas") || inventario.tipo.Equals("Discos"))
                        {
                            numericUpDownPeso.Value = inventario.peso;
                            comboBoxUnidadMasa.Text = inventario.unidadMasa;
                            textBoxMaterial.Text = inventario.material;
                        }
                        modificar = 2;
                        estadoModificarEliminar();
                    }
                    else
                    {
                        modificar = 1;
                        estadoAgregar(1);
                    }
                }
                catch
                {
                    MessageBox.Show("Error de digitacion, el valor del codigo debe ser numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error de digitacion, el campo codigo esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void setTipo(String tipo)
        {
            if(tipo.Equals("Mancuernas"))
            {
                radioButtonMancuernas.Checked = true;
            }
            if (tipo.Equals("Discos")) 
            {
                radioButtonDiscos.Checked = true;
            }
            if(tipo.Equals("Accesorios"))
            {
                radioButtonAccesorios.Checked = true;
            }
            if(tipo.Equals("Implento deportivo"))
            {
                radioButtonImplementoDeportivo.Checked = true;
            }
        }
        public string getTipo()
        {
            String tipo = "";
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
            return tipo;
        }

        public Inventario getInventario()
        {
            inventario = new Inventario();
            inventario.codigo = Convert.ToInt32(textBoxCodigo.Text);
            inventario.nombre = textBoxNombre.Text;
            inventario.tipo = getTipo();
            inventario.cantidadExistencia = Convert.ToInt32(numericUpDownCantidadExistencia.Value+"");
            inventario.cantidadBuenEstado = Convert.ToInt32(numericUpDownCantidadBuenEstado.Value + "");
            inventario.cantidadMalEstado = Convert.ToInt32(numericUpDownCantidadMalEstado.Value + "");
            if(inventario.tipo.Equals("Discos") || inventario.tipo.Equals("Mancuernas"))
            {
                inventario.peso = Convert.ToInt32(numericUpDownPeso.Value+"");
                inventario.unidadMasa = comboBoxUnidadMasa.Text;
                inventario.material = textBoxMaterial.Text;
            }
            return inventario;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            String validacion = validarTodo();
            if (validacion.Equals("Debe llenar los campos: "))
            {
                DialogResult result = MessageBox.Show("Seguro que desea agregar los datos.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (logica.ingresarInventario(getInventario(), conexion))
                    {
                        MessageBox.Show("Se agrego", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, No se agrego y si el error persiste contacte un técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
 
                }
                this.modificar = 0;
                this.estadoInicial();
            }
            else
            {
                 MessageBox.Show(validacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(modificar == 1)
            {
                estadoAgregar(2);
            }
            if(modificar == 2)
            {
                estadoModificarEliminar();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if(validarTodo().Equals("Debe llenar los campos: "))
            {
                DialogResult result = MessageBox.Show("Seguro que desea modificar los datos.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (logica.modificarInventario(getInventario(), conexion))
                    {
                        MessageBox.Show("Se modificaron los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, No se modifico y si el error persiste contacte un técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                modificar = 0;
                estadoInicial();
            }
            else
            {
                MessageBox.Show(validarTodo(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Seguro que desea eliminar los datos.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (logica.eliminarInventario(getInventario().codigo + "", conexion))
                    {
                        MessageBox.Show("Se eliminaron los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, No se eliminaron y si el error persiste contacte un técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                modificar = 0;
                estadoInicial();
        }
        //jhgkjgkggkjhgkjgk

        private void FRMInventario_Load(object sender, EventArgs e)
        {
            radioButtonImplementoDeportivo.Checked = true;
            radioButtonAccesorios.Checked = false;
            radioButtonDiscos.Checked = false;
            radioButtonImplementoDeportivo.Checked = false;
            radioButtonMancuernas.Checked = false;
        }
        private void escucharRadioButton()
        {
            this.radioButtonAccesorios.CheckedChanged += new EventHandler(radioButton_CheckedChanged);// Con esta linea la ventana escucha los eventos de los radio button
            this.radioButtonDiscos.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioButtonImplementoDeportivo.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioButtonMancuernas.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }
        private String validarTodo()
        {
            string mensage = "Debe llenar los campos: ";

                if (string.IsNullOrEmpty(this.textBoxCodigo.Text))
                {
                    mensage += "\nCodigo.";

                }
                if (string.IsNullOrEmpty(this.textBoxNombre.Text))
                {
                    mensage += "\nNombre.";
                }
                if (Convert.ToInt32(this.numericUpDownCantidadExistencia.Text) == 0)
                {
                    mensage += "\nCantidad Existencia. ";
                }
                if(Convert.ToInt32(this.numericUpDownCantidadExistencia.Text) != Convert.ToInt32(this.numericUpDownCantidadBuenEstado.Text) + Convert.ToInt32(this.numericUpDownCantidadMalEstado.Text))
                {
                    mensage += "\nLa existencia no coincide con la suma de la cantidad en buen y mal estado.";
                }
                if (getTipo().Equals("Discos") || getTipo().Equals("Mancuernas"))
                {
                    if (string.IsNullOrEmpty(this.comboBoxUnidadMasa.Text))
                    {
                        mensage += "\nUnidad de masa.";
                    }
                    if (string.IsNullOrEmpty(this.textBoxMaterial.Text))
                    {
                        mensage += "\nMaterial.";
                    }
                    if (string.IsNullOrEmpty(this.numericUpDownPeso.Text))
                    {
                        mensage += "\nPeso.";
                    }
                }
                if (getTipo().Equals(""))
                {
                    mensage += "\nSeleccione un tipo.";
                }
                return mensage;
        }
    }
}
