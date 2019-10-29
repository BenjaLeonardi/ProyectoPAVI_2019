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
            objDatos.LlenarCombo(cboUsuario, "Usuarios", "usuario", "id_usu", "<<Todos>>");
            cboUsuario.SelectedIndex = 0;
            cmbPeriodo.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string consulta = "";
            string usuario = "-1";
            if (cboUsuario.SelectedValue != null) {
                usuario = cboUsuario.SelectedValue.ToString();
            }

            DateTime transformadorFechaDesde = DateTime.Parse(dtpFechaDesde.Value.ToShortDateString());
            DateTime transformadorFechaHasta = DateTime.Parse(dtpFechaHasta.Value.ToShortDateString());
            string desdeStr = transformadorFechaDesde.ToString("yyyy-MM-dd");
            string hastaStr = transformadorFechaHasta.ToString("yyyy-MM-dd");

            if (rdbEstadias.Checked) {
                consulta = "SELECT Usuarios.usuario, Estadias.nro_estadia, Estadias.fecha_inicio, Estadias.fecha_fun, Estadias.cant_huespedes, Estadias.nro_habitacion " +
                    "FROM Usuarios JOIN Estadias ON Usuarios.id_usu=Estadias.id_usu ";
                if (cmbPeriodo.SelectedIndex != 0) {
                    consulta += "WHERE (Estadias.fecha_inicio BETWEEN '" + desdeStr + "' AND '" + hastaStr + "')";
                }
            } else if (rdbFacturas.Checked) {
                consulta = "SELECT Usuarios.usuario, Facturas.id_factura, Facturas.tipo_factura, Facturas.fecha_factura, Facturas.total " +
                    "FROM Usuarios JOIN Facturas ON Usuarios.id_usu=Facturas.id_usu ";
                if (cmbPeriodo.SelectedIndex != 0) {
                    consulta += "WHERE (Facturas.fecha_factura BETWEEN '" + desdeStr + "' AND '" + hastaStr + "')";
                }
            } else if (rdbArticulos.Checked) {
                consulta = "SELECT Articulos.id_art, Articulos.nombre, Tipos.nombre AS Tipo, SUM(DetallesFactura.cantidad) AS Cantidad " +
                    "FROM Usuarios INNER JOIN Facturas ON Usuarios.id_usu=Facturas.id_usu " +
                    "INNER JOIN DetallesFactura ON Facturas.id_factura = DetallesFactura.nro_factura " +
                    "INNER JOIN Articulos INNER JOIN Tipos ON Articulos.id_tipo = Tipos.id_tipo ON DetallesFactura.id_articulo = Articulos.id_art ";
                if (cmbPeriodo.SelectedIndex != 0) {
                    consulta += "WHERE (Facturas.fecha_factura BETWEEN '" + desdeStr + "' AND '" + hastaStr + "')";
                }
            }else if (rdbFacturasMonto.Checked) {
                consulta = "SELECT Usuarios.usuario, SUM(Facturas.total) AS MontoTotal " +
                "FROM Facturas INNER JOIN Usuarios ON Facturas.id_usu = Usuarios.id_usu ";
                if (cmbPeriodo.SelectedIndex != 0) {
                    consulta += "WHERE (Facturas.fecha_factura BETWEEN '" + desdeStr + "' AND '" + hastaStr + "')";
                }
            }

            if (usuario != "-1") {
                consulta += " AND (Usuarios.id_usu=" + usuario + ") ";
            }

            if (rdbArticulos.Checked) {
                consulta += "GROUP BY Articulos.id_art, Articulos.nombre, Tipos.nombre " +
                    "ORDER BY -SUM(DetallesFactura.cantidad)";
            }else if (rdbFacturasMonto.Checked) {
                consulta += "GROUP BY Usuarios.usuario " +
                    "ORDER BY -SUM(Facturas.total)";
            }

            tabla = objDatos.consultar(consulta);
            this.dgvEstadistica.DataSource = tabla;
            dgvEstadistica.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e) {
            dtpFechaDesde.Enabled = true;
            dtpFechaHasta.Enabled = true;

            switch (cmbPeriodo.SelectedIndex) {
                case 0:
                    dtpFechaDesde.Enabled = false;
                    dtpFechaHasta.Enabled = false;
                    break;
                case 1:
                    dtpFechaDesde.Value = new DateTime(DateTime.Today.Year, 1, 1);
                    dtpFechaHasta.Value = new DateTime(DateTime.Today.Year, 12, 31);
                    break;
                case 2:
                    dtpFechaDesde.Value = new DateTime(DateTime.Today.Year-1, 1, 1);
                    dtpFechaHasta.Value = new DateTime(DateTime.Today.Year-1, 12, 31);
                    break;
                default:
                    break;
            }
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e) {
            cmbPeriodo.SelectedIndex = 3;
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e) {
            cmbPeriodo.SelectedIndex = 3;
        }
    }
}
