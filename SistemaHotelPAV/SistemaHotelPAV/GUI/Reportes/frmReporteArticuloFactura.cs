using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelPAV.GUI.Reportes {
    public partial class frmReporteArticuloFactura : Form {
        public frmReporteArticuloFactura() {
            InitializeComponent();
        }

        private void frmReporteArticuloFactura_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'facturasDetallesFacturaArticulos.dtFacturasArticulos' Puede moverla o quitarla según sea necesario.
            this.dtFacturasArticulosTableAdapter.Fill(this.facturasDetallesFacturaArticulos.dtFacturasArticulos);

            this.reportViewer1.RefreshReport();
        }
    }
}
