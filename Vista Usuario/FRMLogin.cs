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

namespace Vistas
{
    public partial class FRMLogin : Form
    {
        #region Atributos
        private Conexion conexion;
        private Usuario usuario;
        private LogicaNegocioUsuario logica;
        private FRMMenuPrincipal menu;
        #endregion
        #region Constructor
        public FRMLogin(Conexion conexion, FRMMenuPrincipal menu)
        {
            InitializeComponent();
            this.conexion = conexion;
            logica = new LogicaNegocioUsuario();
            this.menu = menu;
            this.txtUsuario.KeyPress += new KeyPressEventHandler(keyPress);
            this.txtContra.KeyPress += new KeyPressEventHandler(keyPress1);
        }
        #endregion
        #region Metodos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            validar();
        }
        public String encriptar(String contraseña)
        {
            String con;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(contraseña);
            byte[] hash = md5.ComputeHash(inputBytes);
            con = BitConverter.ToString(hash).Replace("-", "");
            return con;
        }
        public void validar()
        {
            if(!this.txtUsuario.Text.Trim().Equals("") && !this.txtContra.Text.Trim().Equals(""))
            {
                this.usuario = new Usuario();
                usuario = logica.login(this.txtUsuario.Text.Trim(), conexion);
                if (usuario != null)
                {
                    if (this.usuario.contraseña.Equals(encriptar(this.txtContra.Text.Trim())))
                    {
                        if (usuario.estado)
                        {
                            menu.setUsuario(usuario);
                            this.Dispose();
                            menu.accesos(usuario.tipo);
                        }
                        else
                        {
                            MessageBox.Show("El usuario se encuentra inactivo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, Usuario o contraseña  incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, Usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, Los campos usuario y contraseña no pueden estar vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void keyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(Keys.Enter))
            {
                txtContra.Focus();
            }
        }
        public void keyPress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                validar();
            }
        }
        #endregion
    }
}
