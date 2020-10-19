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
    public partial class FRMHorasEstudiantes : Form
    {
        private LogicaNegocioControlUsuarios logica;
        private FRMMenuPrincipal frmMenu;
        private Conexion conexion;
        public FRMHorasEstudiantes(Conexion conexion, FRMMenuPrincipal frmMenu)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.frmMenu = frmMenu;
            this.logica = new LogicaNegocioControlUsuarios();
            this.textBoxNombreUsuario.Text = frmMenu.getUsuario().nombreUsuario;
            estadoInicial();
        }
        private void estadoInicial()
        {
            buttonEntrada.Enabled = false;
            buttonSalida.Enabled = false;
            ControlHorasAsistente control = new ControlHorasAsistente();
            control.identificacion = frmMenu.getUsuario().identificacion;
            DateTime fecha = DateTime.Now;
            string fechaFormatoSQL = fecha.ToString("yyyy-MM-dd");
            //control.fecha = fechaFormatoSQL;
            control = (logica.movimiento(frmMenu.getUsuario().identificacion, fechaFormatoSQL + "", conexion));
            if (control.identificacion == null)
            {
                buttonEntrada.Enabled = true;
            }
            if(control.identificacion != null && control.salida == "00:00:00")
            {
                buttonSalida.Enabled = true;
            }
            if(control.identificacion != null && control.salida != "00:00:00")
            {
                buttonEntrada.Enabled = false;
                buttonSalida.Enabled = false;
                MessageBox.Show("Error, No se puede ingresar horas mas de una vez, en caso de ser un error y este persiste consulte a un técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private ControlHorasAsistente getMovimiento(String movimiento)
        {
            ControlHorasAsistente control = new ControlHorasAsistente();
            control.identificacion = frmMenu.getUsuario().identificacion;
            DateTime fecha = DateTime.Now;
            string fechaFormatoSQL = fecha.ToString("yyyy-MM-dd");
            control.fecha = fechaFormatoSQL;
            fechaFormatoSQL = fecha.ToString("H:mm:ss");
            if (movimiento.Equals("Entrada"))
            {
                control.entrada = fechaFormatoSQL;
                control.salida = "";
            }
            else
            {

                control.salida = fechaFormatoSQL;
            }
            return control;
        }
        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            if(logica.ingresarControl(getMovimiento("Entrada"), conexion))
            {
                MessageBox.Show("Se ingreso la entrada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Error, No se logro ingresar la entrada, si el error persiste consulte a un técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            if (logica.modificarControl(getMovimiento("Salida"), conexion))
            {
                MessageBox.Show("Se ingreso la salida.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Error, No se logro ingresar la entrada, si el error persiste consulte a un técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
