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
    public partial class FRMControlUsuarios : Form
    {
        private LogicaNegocioEstudiante logicaEstudiante;
        private LogicaNegocioControlGYM logicaGYM;
        private Conexion conexion;
        private FRMMenuPrincipal frmMenu;
        public FRMControlUsuarios(Conexion conexion, FRMMenuPrincipal frmMenu)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.frmMenu = frmMenu;
            this.logicaEstudiante = new LogicaNegocioEstudiante();
            this.logicaGYM = new LogicaNegocioControlGYM();
            llenardataGridViewUsuariosInstalacionesDia();
        }
        private void llenardataGridViewUsuariosInstalacionesDia()
        {
            DateTime fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string fechaFormatoSQL = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            List<ControlHorasGYM> lista = logicaGYM.listaMovimientos(fechaFormatoSQL, conexion);
            if (dataGridViewUsuariosInstalacionesDia.Rows.Count >0)
            {
                dataGridViewUsuariosInstalacionesDia.Rows.Clear();
            }
            if(lista != null)
            {
                foreach (ControlHorasGYM control in lista)
                {
                    Estudiante estudinate = logicaEstudiante.consultarUsuario(control.identificacion.Trim(), conexion);
                    dataGridViewUsuariosInstalacionesDia.Rows.Add(estudinate.identificacion, estudinate.nombreCompleto, estudinate.carrera);
                }
            }
        }
        private ControlHorasGYM getControlHoras(String identificacion)
        {
            ControlHorasGYM control = new ControlHorasGYM();
            DateTime fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string fechaFormatoSQL = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            control.identificacion = identificacion;
            control.fechaHora = fechaFormatoSQL;
            return control;
        }
        private void buttonConsultarAgregar_Click(object sender, EventArgs e)
        {
            if(!textBoxidentificacion.Text.Trim().Equals(""))
            {
                DialogResult result = MessageBox.Show("Verifique la identificación antes de continuar.", "Verificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Estudiante estudiante = logicaEstudiante.consultarUsuario(textBoxidentificacion.Text.Trim(), conexion);
                    if(estudiante != null)
                    {
                        if(logicaGYM.ingresarControlGYM(getControlHoras(estudiante.identificacion), conexion))
                        {
                            MessageBox.Show("Se agrego correctamente el ingreso del usuario de las instalaciones.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            llenardataGridViewUsuariosInstalacionesDia();
                        }
                        else
                        {
                            MessageBox.Show("Error, no se agrego el ingreso del usuario de las instalaciones, recuerde que solo se debe realizar el ingreso una vez y si el error persiste contacte a un técnico.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario con esa identificacion no existe, debe ingresarse al sistema.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmMenu.setEstadoFRMControlUsuarios(true);
                        this.Visible=false;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Error, el campo identificacion esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
