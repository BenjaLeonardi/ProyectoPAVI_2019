using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelPAV.DataAccessLayer;

namespace SistemaHotelPAV.GUI.Estadisticas
{
    public partial class frmEstadisticasXUsuario : Form
    {
        public frmEstadisticasXUsuario()
        {
            InitializeComponent();
        }

        Datos objDatos = new Datos();

        private void frmEstadisticasXUsuario_Load(object sender, EventArgs e)
        {
            objDatos.LlenarCombo(cboUsuario, "Usuarios", "usuario", "id_usu");
            
            //Podriamos llenar la grid desde aca pero no se si tenemos todos los listados como funcionaria de forma prolija
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string consulta = "";

            var usuario = cboUsuario.SelectedValue.ToString();

            DateTime transformadorFechaDesde = DateTime.Parse(dtpFechaDesde.Value.ToShortDateString());
            DateTime transformadorFechaHasta = DateTime.Parse(dtpFechaHasta.Value.ToShortDateString());
            string desdeStr = transformadorFechaDesde.ToString("yyyy-MM-dd");
            string hastaStr = transformadorFechaHasta.ToString("yyyy-MM-dd");

            if (rdbEstadias.Checked)
            {
                consulta = "SELECT Usuarios.usuario, Estadias.nro_estadia, Estadias.fecha_inicio, Estadias.fecha_fun, Estadias.cant_huespedes, Estadias.nro_habitacion " + "FROM Usuarios CROSS JOIN Estadias WHERE (Usuarios.id_usu=" + usuario + ") AND (Estadias.fecha_inicio BETWEEN '" + desdeStr + "' AND '" + hastaStr + "')";
                tabla = objDatos.consultar(consulta);
                this.dgvEstadistica.DataSource = tabla;
                dgvEstadistica.Refresh();
            }
            else if (rdbFacturas.Checked)
            {
                consulta = "SELECT Usuarios.usuario, Facturas.id_factura, Facturas.tipo_factura, Facturas.fecha_factura, Facturas.total FROM Usuarios CROSS JOIN Facturas " + "WHERE Usuarios.id_usu=" + usuario + ") AND (Estadias.fecha_inicio BETWEEN '" + desdeStr + "' AND '" + hastaStr + "')";
                tabla = objDatos.consultar(consulta);
                this.dgvEstadistica.DataSource = tabla;
                dgvEstadistica.Refresh();
            }
            
        }
    }
}
