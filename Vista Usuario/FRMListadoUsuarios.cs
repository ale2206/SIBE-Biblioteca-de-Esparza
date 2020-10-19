using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using LogicaNegocios;
using Entidades;
namespace Vistas
{
    public partial class FRMListadoUsuarios : Form
    {
        #region Atributos
        private Conexion conexion;
        LogicaNegocioUsuario logica;
        #endregion

        #region Contructor
        public FRMListadoUsuarios(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.logica = new LogicaNegocioUsuario();
            llenarDataGridView("", "Todos");
            comboBoxTipoUsuario.SelectedIndex=0;
        }
        #endregion

        #region Metodos
        public void llenarDataGridView(String nombre, String tipo)
        {
            limpiarDataGridView();
             List<Usuario> lista = this.logica.consultarUsuarios(conexion,nombre , tipo);
            foreach (Usuario usuario in lista)
            {
                dataGridViewListaUsuarios.Rows.Add(usuario.identificacion, usuario.nombreCompleto, usuario.nombreUsuario, usuario.telefono, usuario.correo, usuario.tipo);
            }
        }

        private void comboBoxTipoUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            //llenarDataGridView("",comboBoxTipoUsuario.Text);
            llenarDataGridView(textBoxNombre.Text.Trim(), comboBoxTipoUsuario.Text);
        }
        public void limpiarDataGridView()
        {
                dataGridViewListaUsuarios.Rows.Clear();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //llenarDataGridView(textBoxNombre.Text, comboBoxTipoUsuario.Text);
        }
        #endregion

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            llenarDataGridView(textBoxNombre.Text.Trim(), comboBoxTipoUsuario.Text);
        }
    }
}
