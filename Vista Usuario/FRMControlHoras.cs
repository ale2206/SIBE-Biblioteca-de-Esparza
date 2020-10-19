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
    public partial class FRMControlHoras : Form
    {
        #region Atributos
        private DateTime fechaMinima = new DateTime(2019, 12, 13);
        private Conexion conexion;
        private LogicaNegocioControlUsuarios logicaControl;
        private LogicaNegocioUsuario logicaUsuario;
        #endregion
        public FRMControlHoras(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.logicaControl = new LogicaNegocioControlUsuarios();
            this.logicaUsuario = new LogicaNegocioUsuario();
            limiteFechas();
            llenarDataGridViewControlHoras();
        }
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            llenarDataGridViewControlHoras();
        }
        private void llenarDataGridViewControlHoras()
        {
            if (dataGridViewControlHoras.RowCount > 0)
            {
                dataGridViewControlHoras.Rows.Clear();
            }
            List<ControlHorasAsistente> lista = logicaControl.listaMovimientos(fechaDesde(), fechaHasta(),conexion);
            if(lista != null)
            {
                if((lista.Count()%2) == 0)
                {
                    for (int i = 0; i<lista.Count(); i++)
                    {
                        Usuario usuario = logicaUsuario.consultarUsuario(lista[i].identificacion, conexion);
                        dataGridViewControlHoras.Rows.Add(lista[i].identificacion, usuario.nombreCompleto,lista[i].entrada,lista[i].salida, lista[i].fecha);
                    }
                }
            }
        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            llenarDataGridViewControlHoras();
        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            llenarDataGridViewControlHoras();
        }
    }
}
