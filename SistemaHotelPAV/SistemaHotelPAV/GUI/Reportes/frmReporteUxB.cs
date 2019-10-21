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
            // TODO: esta línea de código carga datos en la tabla 'dsUsuarioBarrio.dtUsuarioBarrio' Puede moverla o quitarla según sea necesario.
            this.dtUsuarioBarrioTableAdapter.Fill(this.dsUsuarioBarrio.dtUsuarioBarrio);

            this.reportViewer1.RefreshReport();
        }
    }
}
