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
    public partial class FRMListadoEstudiantes : Form
    {
        private Conexion conexion;
        private LogicaNegocioEstudiante logica;
        public FRMListadoEstudiantes(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.logica = new LogicaNegocioEstudiante();
            llenarDataGridView("", "Todos");
            comboBoxTipoUsuario.SelectedIndex=0;
        }
        public void limpiarDataGridView()
        {
            dataGridViewEstudiantes.Rows.Clear();
        }
        public void llenarDataGridView(String identificacion, String tipo)
        {
            limpiarDataGridView();
            List<Estudiante> lista = this.logica.consultarUsuarios(conexion, identificacion, tipo);
            foreach (Estudiante estudiante in lista)
            {
                dataGridViewEstudiantes.Rows.Add(estudiante.identificacion, estudiante.nombreCompleto, estudiante.carrera, estudiante.padecimientos, estudiante.telefono, estudiante.correo, estudiante.tipo);
            }
        }

        private void textBoxIdentificacion_TextChanged(object sender, EventArgs e)
        {
            llenarDataGridView(textBoxNombre.Text.Trim(), comboBoxTipoUsuario.Text);
        }

        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDataGridView(textBoxNombre.Text.Trim(), comboBoxTipoUsuario.Text);
        }
    }
}
