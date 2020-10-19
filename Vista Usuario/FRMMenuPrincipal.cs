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
using Entidades;


//
namespace Vistas
{
    public partial class FRMMenuPrincipal : Form
    {
        #region Atributos
        private FRMLogin login;
        private Conexion conexion;
        private Usuario usuarioRegistrado;
        private FRMUsuario frmUsuario;
        private FRMListadoUsuarios frmListaUsuarios;
        private FRMEstudiante frmEstudiante;
        private FRMListadoEstudiantes frmListadoEstudiantes;
        private FRMInventario frmInventario;
        private FRMPrestamo frmPrestamo;
        private FRMHorasEstudiantes frmHorasEstudiante;
        private FRMConsultaInventario frmConsultaInventario;
        private FRMControlUsuarios frmControlUsuarios;
        private FRMDevolucion frmDevolucion;
        private FRMConsultaUsuariosInstalaciones frmConsultaUsuariosInstalaciones;
        /*private FRMControlHoras frmControlHoras;*/
        private Boolean estadoFRMControlUsuarios;
        #endregion

        #region Constructor
        public FRMMenuPrincipal()
        {
            InitializeComponent();
            this.Visible = true;
            this.conexion = new Conexion();
            conectarServidor();
            this.login = new FRMLogin(conexion,this);
            this.login.Visible=true;
            estadoInicial();
            this.labelNombreUsuario.BringToFront();// Trea el label al frente del panel gradiente
            this.frmConsultaUsuariosInstalaciones = new FRMConsultaUsuariosInstalaciones(conexion);
            this.frmConsultaUsuariosInstalaciones.Visible = false;
            this.estadoFRMControlUsuarios = false;
        }
        #endregion

        #region Metodos
        public void conectarServidor()
        {
            if (!this.conexion.mConectar())
            {
                MessageBox.Show("Error, No se logro establecer la conexión con el servidor, se terminara la ejecución de la aplicación.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            labelNombreUsuario.SetBounds(this.Width-100,40,100,100);
        }
        public void estadoInicial()
        {
            iniciarSesionToolStripMenuItem.Enabled = true;
            cerrarSesionToolStripMenuItem.Enabled = false;
            ayudaToolStripMenuItem.Enabled = true;
            cerrarAplicacionToolStripMenuItem.Enabled = true;
            mantenimientoUsuariosToolStripMenuItem.Enabled = false;
            listaUsuariosToolStripMenuItem.Enabled = false;
            prestamoToolStripMenuItem.Enabled = false;
            devolucionesToolStripMenuItem.Enabled = false;
            inventarioToolStripMenuItem.Enabled = false;
            mantenimientoEstudiantesToolStripMenuItem.Enabled = false;
            listaEstudiantesToolStripMenuItem.Enabled = false;
            inicioToolStripMenuItem.Visible = true;
            usuariosSistemaToolStripMenuItem.Visible = false;
            serviciosToolStripMenuItem.Visible = false;
            usuariosInstalacionessToolStripMenuItem.Visible = false;
            controlGimnacioToolStripMenuItem.Visible = false;
            marcarEntradaOSalidaToolStripMenuItem.Enabled = false;
            controlHorasToolStripMenuItem.Enabled = false;
            controlUsoInstalacionesToolStripMenuItem.Enabled = false;
            listaInventarioToolStripMenuItem.Enabled = false;
            controlHorasToolStripMenuItem.Visible = false;
            controlUsoInstalacionesToolStripMenuItem.Visible = false;
            controlDeHorarioToolStripMenuItem.Enabled = false;
            controlDeHorarioToolStripMenuItem.Visible = false;
        }
        public void accesos(String tipoUsuario)
        {
            if(tipoUsuario.Equals("Administrador"))
            {
                iniciarSesionToolStripMenuItem.Enabled = false;
                cerrarSesionToolStripMenuItem.Enabled = true;
                ayudaToolStripMenuItem.Enabled = true;
                cerrarAplicacionToolStripMenuItem.Enabled = true;
                mantenimientoUsuariosToolStripMenuItem.Enabled = true;
                listaUsuariosToolStripMenuItem.Enabled = true;
                prestamoToolStripMenuItem.Enabled = true;
                devolucionesToolStripMenuItem.Enabled = true;
                inventarioToolStripMenuItem.Enabled = true;
                mantenimientoEstudiantesToolStripMenuItem.Enabled = true;
                listaEstudiantesToolStripMenuItem.Enabled = true;
                inicioToolStripMenuItem.Visible = true;
                usuariosSistemaToolStripMenuItem.Visible = true;
                serviciosToolStripMenuItem.Visible = true;
                usuariosInstalacionessToolStripMenuItem.Visible = true;
                controlGimnacioToolStripMenuItem.Visible = true;
                marcarEntradaOSalidaToolStripMenuItem.Enabled = true;
                controlHorasToolStripMenuItem.Enabled = true;
                controlUsoInstalacionesToolStripMenuItem.Enabled = true;
                listaInventarioToolStripMenuItem.Enabled = true;
                controlHorasToolStripMenuItem.Visible = true;
                controlUsoInstalacionesToolStripMenuItem.Visible = true;
                controlDeHorarioToolStripMenuItem.Enabled = true;
                controlDeHorarioToolStripMenuItem.Visible = true;

            }
            if(tipoUsuario.Equals("Horas Asistente"))
                {
                iniciarSesionToolStripMenuItem.Enabled = false;
                cerrarSesionToolStripMenuItem.Enabled = true;
                ayudaToolStripMenuItem.Enabled = true;
                cerrarAplicacionToolStripMenuItem.Enabled = true;
                mantenimientoUsuariosToolStripMenuItem.Enabled = true;
                listaUsuariosToolStripMenuItem.Enabled = true;
                prestamoToolStripMenuItem.Enabled = true;
                devolucionesToolStripMenuItem.Enabled = true;
                inventarioToolStripMenuItem.Enabled = true;
                mantenimientoEstudiantesToolStripMenuItem.Enabled = true;
                listaEstudiantesToolStripMenuItem.Enabled = true;
                inicioToolStripMenuItem.Visible = true;
                usuariosSistemaToolStripMenuItem.Visible = true;
                serviciosToolStripMenuItem.Visible = true;
                usuariosInstalacionessToolStripMenuItem.Visible = true;
                controlGimnacioToolStripMenuItem.Visible = true;
                marcarEntradaOSalidaToolStripMenuItem.Enabled = true;
                controlHorasToolStripMenuItem.Enabled = false;
                controlUsoInstalacionesToolStripMenuItem.Enabled = true;
                listaInventarioToolStripMenuItem.Enabled = true;
                controlHorasToolStripMenuItem.Visible = false;
                controlUsoInstalacionesToolStripMenuItem.Visible = false;
                controlDeHorarioToolStripMenuItem.Enabled = false;
                controlDeHorarioToolStripMenuItem.Visible = false;
            }
            if (tipoUsuario.Equals("Horas Estudiante"))
            {
                iniciarSesionToolStripMenuItem.Enabled = false;
                cerrarSesionToolStripMenuItem.Enabled = true;
                ayudaToolStripMenuItem.Enabled = true;
                cerrarAplicacionToolStripMenuItem.Enabled = true;
                mantenimientoUsuariosToolStripMenuItem.Enabled = false;
                listaUsuariosToolStripMenuItem.Enabled = false;
                prestamoToolStripMenuItem.Enabled = true;
                devolucionesToolStripMenuItem.Enabled = true;
                inventarioToolStripMenuItem.Enabled = false;
                mantenimientoEstudiantesToolStripMenuItem.Enabled = true;
                listaEstudiantesToolStripMenuItem.Enabled = true;
                inicioToolStripMenuItem.Visible = true;
                usuariosSistemaToolStripMenuItem.Visible = false;
                serviciosToolStripMenuItem.Visible = true;
                usuariosInstalacionessToolStripMenuItem.Visible = true;
                controlGimnacioToolStripMenuItem.Visible = true;
                marcarEntradaOSalidaToolStripMenuItem.Enabled = true;
                controlHorasToolStripMenuItem.Enabled = false;
                controlUsoInstalacionesToolStripMenuItem.Enabled = false;
                listaInventarioToolStripMenuItem.Enabled = true;
                controlHorasToolStripMenuItem.Visible = false;
                controlUsoInstalacionesToolStripMenuItem.Visible = false;
                controlDeHorarioToolStripMenuItem.Enabled = false;
                controlDeHorarioToolStripMenuItem.Visible = false;
            }
        }
        private void cerrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login != null)
            {
                login.Dispose();
            }
            login = new FRMLogin(conexion, this);
            login.Visible = true;
        }
        public void setEstadoFRMControlUsuarios(Boolean estado)
        {
            estadoFRMControlUsuarios = estado;
            if(estado)
            {
                frmEstudiante = new FRMEstudiante(conexion,this);
                frmEstudiante.Visible = true;
            }
            else
            {
                frmEstudiante = new FRMEstudiante(conexion, this);
                frmEstudiante.Visible = false;
                frmControlUsuarios.Visible = true;
            }
        }
        public Boolean getEstadoFRMControlUsuarios()
        {
            return estadoFRMControlUsuarios;
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelNombreUsuario.Text = "";
            setUsuario(null);
            estadoInicial();
            MessageBox.Show("Se cerro la sesion del usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mantenimientoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUsuario != null)
            {
                frmUsuario.Dispose();
            }
            frmUsuario = new FRMUsuario(conexion);
            frmUsuario.Visible = true;
        }

        private void listaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListaUsuarios != null)
            {
                frmListaUsuarios.Dispose();
            }
            this.frmListaUsuarios = new FRMListadoUsuarios(conexion);
            this.frmListaUsuarios.Visible = true;
        }

        private void mantenimientoEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEstudiante != null)
            {
                frmEstudiante.Dispose();
            }
            this.frmEstudiante = new FRMEstudiante(conexion,this);
            this.frmEstudiante.Visible = true;
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListadoEstudiantes != null)
            {
                frmListadoEstudiantes.Dispose();
            }
            this.frmListadoEstudiantes = new FRMListadoEstudiantes(conexion);
            this.frmListadoEstudiantes.Visible = true;
        }
        

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInventario != null)
            {
                frmInventario.Dispose();
            }
            frmInventario = new FRMInventario(conexion);
            frmInventario.Visible = true;
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(frmPrestamo != null)
            {
                frmPrestamo.Dispose();
            }
            this.frmPrestamo = new FRMPrestamo(conexion, this);
            this.frmPrestamo.Visible = true;
        }

        private void marcarEntradaOSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHorasEstudiante != null)
            {
                frmHorasEstudiante.Dispose();
            }
            frmHorasEstudiante = new FRMHorasEstudiantes(conexion,this);
            frmHorasEstudiante.Visible = true;
        }
        #endregion

        private void listaInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultaInventario != null)
            {
                frmConsultaInventario.Dispose();
            }
            frmConsultaInventario = new FRMConsultaInventario(conexion);
            frmConsultaInventario.Visible = true;
        } // ivan escribio y es puto

        //mc chichi

        private void controlHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmControlUsuarios != null)
            {
                frmControlUsuarios.Dispose();
            }
            frmControlUsuarios = new FRMControlUsuarios(conexion,this);
            frmControlUsuarios.Visible = true;
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDevolucion != null)
            {
                frmDevolucion.Dispose();
            }
            frmDevolucion = new FRMDevolucion(conexion, this);
            frmDevolucion.Visible = true;
        }

        private void controlUsoInstalacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultaUsuariosInstalaciones != null)
            {
                frmConsultaUsuariosInstalaciones.Dispose();
            }
            frmConsultaUsuariosInstalaciones = new FRMConsultaUsuariosInstalaciones(conexion);
            frmConsultaUsuariosInstalaciones.Visible = true;
        }

        private void controlDeHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            if (frmControlHoras != null)
            {
                frmControlHoras.Dispose();
            }
            frmControlHoras = new FRMControlHoras(conexion);
            frmControlHoras.Visible = true;*/
        }
        public void setUsuario(Usuario usuario)
        {
            this.usuarioRegistrado = usuario;
            if(usuario == null)
            {
                labelNombreUsuario.Text = "";
            }
            else
            {
                labelNombreUsuario.Text = usuario.nombreUsuario;
            }
        }
        public Usuario getUsuario()
        {
            return this.usuarioRegistrado;
        }
    }
}
