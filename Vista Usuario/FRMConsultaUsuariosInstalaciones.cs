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
using LogicaNegocios;

namespace Vistas
{
    public partial class FRMConsultaUsuariosInstalaciones : Form
    {
        #region Atributos
        private DateTime fechaMinima = new DateTime(2019, 12, 13);
        private Conexion conexion;
        private LogicaNegocioControlGYM logicaGYM;
        private LogicaNegocioEstudiante logicaEstudiante;
        #endregion
        #region Constructor
        public FRMConsultaUsuariosInstalaciones(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            limiteFechas();
            this.logicaGYM = new LogicaNegocioControlGYM();
            this.logicaEstudiante = new LogicaNegocioEstudiante();
            comboBoxTipo.Text = "Todos";
            llenarDataGridViewUsuarios();
        }
        #endregion
        private void limiteFechas()
        {
            dateTimePickerHasta.MaxDate = DateTime.Now;
            dateTimePickerHasta.MinDate = fechaMinima;
            dateTimePickerDesde.MaxDate = DateTime.Now;
            dateTimePickerDesde.MinDate = fechaMinima;
        }
        private String fechaDesde()
        {
            DateTime fecha = Convert.ToDateTime(dateTimePickerDesde.Value.ToShortDateString());
            string fechaFormatoSQL = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            return fechaFormatoSQL;
        }
        private String fechaHasta()
        {
            DateTime fecha = Convert.ToDateTime(dateTimePickerHasta.Value.ToShortDateString());
            string fechaFormatoSQL = fecha.ToString("yyyy-MM-dd 23:59:59");
            return fechaFormatoSQL;
        }
        private void llenarDataGridViewUsuarios()
        {/*
                dataGridViewUsuarios.Rows.Clear();
                List<ControlHorasGYM> lista = logicaGYM.listaMovimientosFiltrada(fechaDesde(), fechaHasta(), comboBoxTipo.Text, conexion);
                if(lista != null)
                {
                    foreach(ControlHorasGYM control in lista)
                    {
                        DateTime fecha = Convert.ToDateTime(control.fechaHora);//*
                        fecha = Convert.ToDateTime(fecha.ToLongDateString());//*
                        string fechaFormatoSQL = fecha.ToString("dddd dd-MMMM-yyyy");//* Convierten el dateTime en fecha corta

                        Estudiante estudiante = logicaEstudiante.consultarUsuario(control.identificacion, conexion);
                        dataGridViewUsuarios.Rows.Add(control.identificacion,estudiante.nombreCompleto,estudiante.tipo, fechaFormatoSQL);
                    }
                }*/
        }
        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDataGridViewUsuarios();
        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            llenarDataGridViewUsuarios();
        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            llenarDataGridViewUsuarios();
        }
    }
}
