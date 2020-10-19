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
using System.Security.Cryptography;
using System.Text.RegularExpressions;


namespace Vistas
{

    public partial class FRMUsuario : Form
    {
        #region Atributos
        Usuario usuario;
        Conexion conexion;
        LogicaNegocioUsuario logica;
        private String contraseña;
        #endregion

        #region Constructor
        public FRMUsuario(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.logica = new LogicaNegocioUsuario();
        }
        #endregion

        #region Metodos
        public String encriptar(String contraseña)
        {
            String con;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(contraseña);
            byte[] hash = md5.ComputeHash(inputBytes);
            con = BitConverter.ToString(hash).Replace("-", "");
            return con;
        }
        public Usuario getUsuario()
        {
            try
            {
                usuario = new Usuario();
                usuario.identificacion = textBoxCarnet.Text.Trim();
                usuario.nombreCompleto = textBoxNombre.Text;
                usuario.nombreUsuario = textBoxNombreUsuario.Text.Trim();
                usuario.contraseña = (textBoxContraseña.Text).Trim();
                usuario.telefono = Convert.ToInt32(textBoxTelefono.Text);
                usuario.correo = textBoxCorreo.Text;
                usuario.tipo = getTipoUsuario();
                usuario.estado = getEstado();
                return usuario;
            }
            catch
            {
                return null;
            }
        }
        public string getTipoUsuario()
        {
            String tipo = "";
            if(radioButtonAdministrador.Checked)
            {
                return tipo = radioButtonAdministrador.Text;
            }
            if (radioButtonAsistente.Checked)
            {
                return tipo = radioButtonAsistente.Text;
            }
            return tipo;
        }
        public bool getEstado()
        {
            bool estado = false;
            if (radioButtonActivo.Checked)
            {
                //return estado = "a";
                estado = true;
            }
            return estado;
        }

       


        public void setTipoUsuario(String tipo)
        {
            if(tipo.Equals("Administrador"))
            {
                radioButtonAdministrador.Select();
            }
            if(tipo.Equals("Asistente"))
            {
                radioButtonAsistente.Select();
            }
        }
        public void setEstado(bool tipo)
        {
            if (tipo)
            {
                radioButtonActivo.Select();
            }
            else
            {
                radioButtonInactivo.Select();
            }
        }

        public void estadoInicial()
        {
            textBoxCarnet.Text = "";
            textBoxCarnet.Enabled = true;
            textBoxNombre.Text = "";
            textBoxNombre.Enabled = false;
            textBoxNombreUsuario.Text = "";
            textBoxNombreUsuario.Enabled = false;
            textBoxContraseña.Text = "";
            textBoxContraseña.Enabled = false;
            textBoxTelefono.Text = "";
            textBoxTelefono.Enabled = false;
            textBoxCorreo.Text = "";
            textBoxCorreo.Enabled = false;
            radioButtonActivo.Checked=false;
            radioButtonActivo.Enabled = false;
            radioButtonInactivo.Checked = false;
            radioButtonInactivo.Enabled = false;
            radioButtonAdministrador.Checked = true;
            radioButtonAdministrador.Checked = false;
            radioButtonAdministrador.Enabled = false;
            radioButtonAsistente.Checked = false;
            radioButtonAsistente.Enabled = false;
            buttonAgregar.Enabled = false;
            buttonBuscar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonBuscar.Enabled = true;
        }

        public void estadoModificarAgregar(Boolean agregarModificar)
        {
            textBoxCarnet.Enabled = false;
            textBoxNombre.Enabled = true;
            textBoxNombreUsuario.Enabled = true;
            textBoxContraseña.Enabled = true;
            textBoxTelefono.Enabled = true;
            textBoxCorreo.Enabled = true;
            radioButtonActivo.Checked = false;
            radioButtonActivo.Enabled = true;
            radioButtonInactivo.Checked = false;
            radioButtonInactivo.Enabled = true;
            radioButtonAdministrador.Checked = false;
            radioButtonAdministrador.Enabled = true;
            radioButtonAsistente.Checked = false;
            radioButtonAsistente.Enabled = true;
            if(agregarModificar)
            {
                buttonAgregar.Enabled = true;
                buttonModificar.Enabled = false;
            }
            else 
            {
                buttonAgregar.Enabled = false;
                buttonModificar.Enabled = true;
            }
            buttonBuscar.Enabled = false;
            buttonBuscar.Enabled = true;

        }

        private void FRMUsuario_Load(object sender, EventArgs e)
        {
            estadoInicial();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (validarTodo().Equals("Debe llenar los campos: "))
            {
                contraseña = usuario.contraseña;
                usuario = getUsuario();
                if (!contraseña.Equals(usuario.contraseña))
                {
                    usuario.contraseña = encriptar(usuario.contraseña);
                }
                DialogResult result = MessageBox.Show("Seguro que desea modificar el usuario.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (logica.modificarUsuario(this.usuario, conexion))
                    {
                        MessageBox.Show("Se modifico el usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, No se logro agregar, si el problema persiste pongase en contacto con un tecnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                estadoInicial();
            }
            else
            {
                MessageBox.Show(validarTodo(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
                if(validarTodo().Equals("Debe llenar los campos: "))
                {
                    this.usuario = getUsuario();
                    this.usuario.contraseña = encriptar(this.usuario.contraseña);
                    DialogResult result = MessageBox.Show("Seguro que desea agregar el usuario.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (logica.ingresarUsuario(this.usuario, conexion))
                        {
                            MessageBox.Show("Se agrego el usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error, No se logro agregar, si el problema persiste pongase en contacto con un tecnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    estadoInicial();
                }
                else
                {
                    MessageBox.Show(validarTodo(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(!textBoxCarnet.Text.Trim().Equals(""))
            {
                usuario = logica.consultarUsuario(textBoxCarnet.Text.Trim(), conexion);
                if (usuario != null)
                {
                    estadoModificarAgregar(false);
                    textBoxNombre.Text = usuario.nombreCompleto;
                    textBoxNombreUsuario.Text = usuario.nombreUsuario;
                    textBoxContraseña.Text = usuario.contraseña;
                    textBoxTelefono.Text = usuario.telefono + "";
                    textBoxCorreo.Text = usuario.correo;
                    setTipoUsuario(usuario.tipo);
                    setEstado(usuario.estado);
                    contraseña = usuario.contraseña;
                }
                else
                {
                    estadoModificarAgregar(true);
                }
            }
            else
            {
                MessageBox.Show("Error, El campo identificacion esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        }//Este metodo valida que el campo correo tenga el formato de uno
        private String validarTodo()
        {
            string mensage = "Debe llenar los campos: ";
            if (string.IsNullOrEmpty(this.textBoxCarnet.Text))
            {
                mensage += "\nidentificacion";
            }
            if (string.IsNullOrEmpty(this.textBoxNombre.Text))
            {
                mensage += "\nNombre";
            }
            if (string.IsNullOrEmpty(this.textBoxNombreUsuario.Text))
            {
                mensage += "\nNombre Usuario";
            }
            if (string.IsNullOrEmpty(this.textBoxContraseña.Text))
            {
                mensage += "\nContraseña";
            }
            if (string.IsNullOrEmpty(this.textBoxTelefono.Text))
            {
                mensage += "\nTelefóno";
            }
            try
            {
                Convert.ToInt32(this.textBoxTelefono.Text);
            }
            catch
            {
                mensage += "\nEl campo telefóno es de tipo númerico.";
            }
            if (string.IsNullOrEmpty(this.textBoxCorreo.Text))
            {
                mensage += "\nCorreo";
            }
            if (!validarEmail(textBoxCorreo.Text))
            {
                mensage += "\nEl correo debe tener formato de correo";
            }
            if(getEstado().Equals(""))
            {
                mensage += "\nSeleccione un estado para el usuario.";
            }
            if (getTipoUsuario().Equals(""))
            {
                mensage += "\nSeleccione un tipo de usuario.";
            }
            return mensage;
        }
        #endregion
    }
}
