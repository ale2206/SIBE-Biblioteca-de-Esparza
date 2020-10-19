using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using AccesoDatos;
using Entidades;
using System.Text.RegularExpressions;

namespace Vistas
{
    public partial class FRMEstudiante : Form
    {
        private LogicaNegocioEstudiante logica;
        private Conexion conexion;
        private Estudiante estudiante;
        private FRMMenuPrincipal frmMenuPrincipal;
        public FRMEstudiante(Conexion conexion, FRMMenuPrincipal frmMenu)
        {
            InitializeComponent();
            this.frmMenuPrincipal = frmMenu;
            this.logica = new LogicaNegocioEstudiante();
            this.conexion = conexion;
            estadoInicial();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if(frmMenuPrincipal.getEstadoFRMControlUsuarios())
            {
                frmMenuPrincipal.setEstadoFRMControlUsuarios(false);
            }
        }

        
        public void tipoUsuario(String tipo)
        {
            if(tipo.Equals("Estudiante"))
            {
                radioButtonEstudiante.Checked = true;
            }
            if(tipo.Equals("Funcionario"))
            {
                radioButtonFuncionario.Checked = true;
            }
        }
        public String tipoUsuario()
        {
            if (radioButtonEstudiante.Checked)
            {
                return radioButtonEstudiante.Text;
            }
            if (radioButtonFuncionario.Checked)
            {
                return radioButtonFuncionario.Text;
            }
            return "";
        }

        public Estudiante getEstudiante()
        {
            estudiante = new Estudiante();
            estudiante.identificacion = textBoxIdentificacion.Text;
            estudiante.nombreCompleto = textBoxNombre.Text;
            estudiante.telefono = Convert.ToInt32(textBoxNumeroTelefono.Text);
            estudiante.correo = textBoxCorreo.Text;
            estudiante.carrera = textBoxCarrera.Text;
            estudiante.padecimientos = textBoxPadecimientos.Text;
            estudiante.tipo = tipoUsuario();
            return estudiante;

        }

        public void estadoInicial()
        {
            textBoxIdentificacion.Text = "";
            textBoxIdentificacion.Enabled = true;
            textBoxNombre.Text = "";
            textBoxNombre.Enabled = false;
            textBoxNumeroTelefono.Text = "";
            textBoxNumeroTelefono.Enabled = false;
            textBoxCorreo.Text = "";
            textBoxCorreo.Enabled = false;
            textBoxCarrera.Text = "";
            textBoxCarrera.Enabled = false;
            textBoxPadecimientos.Text = "";
            textBoxPadecimientos.Enabled = false;
            radioButtonEstudiante.Checked = false;
            radioButtonEstudiante.Enabled = false;
            radioButtonFuncionario.Checked = false;
            radioButtonFuncionario.Enabled = false;
            buttonConsultar.Enabled = true;
            buttonAgregar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonMenu.Enabled = true;
        }

        public void estadoAgregarModificarEliminar(Boolean estado)
        {
            if(estado)
            {
                textBoxIdentificacion.Enabled = false;
                textBoxNombre.Enabled = true;
                textBoxNumeroTelefono.Enabled = true;
                textBoxCorreo.Enabled = true;
                textBoxCarrera.Enabled = true;
                textBoxPadecimientos.Enabled = true;
                radioButtonEstudiante.Enabled = true;
                radioButtonFuncionario.Enabled = true;
                buttonConsultar.Enabled = false;
                buttonAgregar.Enabled = true;
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
                buttonMenu.Enabled = true;
            }
            else
            {
                textBoxIdentificacion.Enabled = false;
                textBoxNombre.Enabled = true;
                textBoxNumeroTelefono.Enabled = true;
                textBoxCorreo.Enabled = true;
                textBoxCarrera.Enabled = true;
                textBoxPadecimientos.Enabled = true;
                radioButtonEstudiante.Enabled = true;
                radioButtonFuncionario.Enabled = true;
                buttonConsultar.Enabled = false;
                buttonAgregar.Enabled = false;
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
                buttonMenu.Enabled = true;
            }
        }


        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if(!textBoxIdentificacion.Text.Trim().Equals(""))
            {
                estudiante = logica.consultarUsuario(textBoxIdentificacion.Text.Trim(), conexion);
                if (estudiante != null)
                {
                    textBoxNombre.Text = estudiante.nombreCompleto;
                    textBoxNumeroTelefono.Text = estudiante.telefono + "";
                    textBoxCorreo.Text = estudiante.correo;
                    textBoxCarrera.Text = estudiante.carrera;
                    textBoxPadecimientos.Text = estudiante.padecimientos;
                    tipoUsuario(estudiante.tipo);
                    estadoAgregarModificarEliminar(false);
                }
                else
                {
                    estadoAgregarModificarEliminar(true);
                }
            }
            else
            {
                MessageBox.Show("Error de digitacion, el campo identificacion esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            String validacion = validarTodo();
            if(validacion.Equals("Debe llenar los campos: "))
            {
                DialogResult result = MessageBox.Show("Seguro que desea agregar los datos.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (logica.ingresarUsuario(getEstudiante(), conexion))
                    {
                        MessageBox.Show("Se logro agregar el usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, No se logro agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    estadoInicial();
                }
            }
            else
            {
                MessageBox.Show("Error, "+validacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            String validacion = validarTodo();
            if (validacion.Equals("Debe llenar los campos: "))
            {
                DialogResult result = MessageBox.Show("Seguro que desea modificar los datos.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (logica.modificarUsuario(getEstudiante(), conexion))
                    {
                        MessageBox.Show("Se logro modificar el usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, No se logro modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    estadoInicial();
                }
            }
            else
            {
                MessageBox.Show("Error, " + validacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar los datos.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (logica.eliminarUsuario(textBoxIdentificacion.Text, conexion))
                {
                    MessageBox.Show("Se logro eliminar el usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error, No se logro eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                estadoInicial();
            }
        }
        private String validarTodo()
        {
            string mensage = "Debe llenar los campos: ";
            try
            {

                if (string.IsNullOrEmpty(this.textBoxIdentificacion.Text))
                {
                    mensage += "\nIdentificacion.";

                }
                if (string.IsNullOrEmpty(this.textBoxNombre.Text))
                {
                    mensage += "\nNombre.";
                }
                try
                {
                    if (string.IsNullOrEmpty(this.textBoxNumeroTelefono.Text))
                    {
                        mensage += "\nTelefono. ";
                    }
                    Convert.ToInt32(textBoxNumeroTelefono.Text);
                }
                catch
                {
                    mensage += "El campo telefono solo acepta valores númericos.";
                }
                if (!validarEmail(textBoxCorreo.Text))
                {
                    mensage += "\nEl campo correo. O puede no cumpla con el formato de correo.";
                }
                if (string.IsNullOrEmpty(this.textBoxCarrera.Text))
                {
                    mensage += "\nCarrera.";
                }
                if (string.IsNullOrEmpty(this.textBoxPadecimientos.Text))
                {
                    mensage += "\nPadecimientos.";
                }
                if (tipoUsuario().Equals(""))
                {
                    mensage += "\nSeleccione un tipo de usuario.";
                }
                return mensage;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private Boolean validarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
