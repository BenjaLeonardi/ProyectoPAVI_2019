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
    public partial class frmReporteVehiculoCliente : Form {
        public frmReporteVehiculoCliente() {
            InitializeComponent();
        }

        private void frmReporteVehiculoCliente_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.dtClienteVehiculo' Puede moverla o quitarla según sea necesario.
            this.dtClienteVehiculoTableAdapter.Fill(this.dataSet1.dtClienteVehiculo);

            this.reportViewer1.RefreshReport();
        }
    }
}
