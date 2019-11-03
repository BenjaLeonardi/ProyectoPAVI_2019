using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelPAV.GUI.Estadisticas
{
    public partial class frmListadoDos : Form
    {
        public frmListadoDos()
        {
            InitializeComponent();
        }

        private string fechaDesde;
        private string fechaHasta;
        private int idUsu;

        public void InitDetalle(string FechaDesde, string FechaHasta, int IdUsu)
        {
            fechaDesde = FechaDesde;
            fechaHasta = FechaHasta;
            idUsu = IdUsu;
        }
        private void frmListadoDos_Load(object sender, EventArgs e)
        {
            this.dtListadoDosTableAdapter.Fill(dsListadoDos.dtListadoDos, idUsu, fechaDesde, fechaHasta);
            this.reportViewer1.RefreshReport();
        }
    }
}
