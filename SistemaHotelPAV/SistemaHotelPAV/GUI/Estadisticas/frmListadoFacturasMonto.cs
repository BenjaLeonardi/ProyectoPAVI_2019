using System;
using System.Windows.Forms;

namespace SistemaHotelPAV.GUI.Estadisticas {
    public partial class frmListadoFacturasMonto : Form {
        public frmListadoFacturasMonto() {
            InitializeComponent();
        }

        string fechaDesde;
        string fechaHasta;

        public void InitializeReport(string desde, string hasta) {
            fechaDesde = desde;
            fechaHasta = hasta;
        }

        private void frmListadoFacturasMonto_Load(object sender, EventArgs e) {
            this.dtaMontosFacturas.Fill(this.dsMontosFacturas.dtMontosFacturas, fechaDesde, fechaHasta);
            this.reportViewer1.RefreshReport();
        }
    }
}
