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

            if (cmbPeriodo.SelectedIndex == 0) {
                desdeStr = DateTime.MinValue.ToString("yyyy-MM-dd");
                hastaStr = DateTime.Now.ToString("yyyy-MM-dd");
            }

            if (rdbEstadias.Checked)
            {
                frmListadoUno FormListadoUno = new frmListadoUno();
                FormListadoUno.InitDetalle(desdeStr, hastaStr, Convert.ToInt32(usuario));
                FormListadoUno.ShowDialog();
            }
            else if (rdbFacturas.Checked)
            {
                frmListadoDos FormListadoDos = new frmListadoDos();
                FormListadoDos.InitDetalle(desdeStr, hastaStr, Convert.ToInt32(usuario));
                FormListadoDos.ShowDialog();
            }else if (rdbArticulos.Checked) {
                frmListadoArticulosMasVendidos listadoArticulosVendidos = new frmListadoArticulosMasVendidos();
                listadoArticulosVendidos.InitializeReport(desdeStr, hastaStr);
                listadoArticulosVendidos.ShowDialog();
            }else if (rdbFacturasMonto.Checked) {
                frmListadoFacturasMonto listadoFacturasMonto = new frmListadoFacturasMonto();
                listadoFacturasMonto.InitializeReport(desdeStr, hastaStr);
                listadoFacturasMonto.ShowDialog();
            }
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            SelectedReport();

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

        private void rdbArticulos_CheckedChanged(object sender, EventArgs e) {
            SelectedReport();
        }

        void SelectedReport() {
            bool usuarios = !(rdbArticulos.Checked || rdbFacturasMonto.Checked);
            cboUsuario.Enabled = usuarios;
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void rdbEstadias_CheckedChanged(object sender, EventArgs e) {
            SelectedReport();

        }

        private void rdbFacturas_CheckedChanged(object sender, EventArgs e) {
            SelectedReport();

        }
    }
}
