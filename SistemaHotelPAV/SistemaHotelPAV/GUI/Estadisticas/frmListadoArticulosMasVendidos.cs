using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelPAV.GUI.Estadisticas {
    public partial class frmListadoArticulosMasVendidos : Form {
        public frmListadoArticulosMasVendidos() {
            InitializeComponent();
        }

        string fechaDesde;
        string fechaHasta;

        public void InitializeReport(string desde, string hasta) {
            fechaDesde = desde;
            fechaHasta = hasta;
        }

        private void frmListadoArticulosMasVendidos_Load(object sender, EventArgs e) {
            this.dtaFacultadVendidos.Fill(this.dsArticulosVendidosFacultad.dtFacultadVendidos, fechaDesde, fechaHasta);
            this.reportViewer1.RefreshReport();
        }
    }
}
