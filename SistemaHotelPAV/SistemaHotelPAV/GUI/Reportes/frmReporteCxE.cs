using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelPAV.GUI.Reportes
{
    public partial class frmReporteCxE : Form
    {
        public frmReporteCxE()
        {
            InitializeComponent();
        }

        private void frmReporteCxE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsReporteClienteEstadia.dtClienteEstadia' Puede moverla o quitarla según sea necesario.
            this.dtClienteEstadiaTA.Fill(this.dsReporteClienteEstadia.dtClienteEstadia);

            this.reportViewer1.RefreshReport();
        }
    }
}
