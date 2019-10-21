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
    public partial class frmReporteUxB : Form
    {
        public frmReporteUxB()
        {
            InitializeComponent();
        }

        private void frmReporteUxB_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
