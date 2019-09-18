using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelPAV.Clases;

namespace SistemaHotelPAV.Formularios {
    public partial class frmDetalleArticulo : Form {

        private Articulos articuloService;
        public frmDetalleArticulo() {
            InitializeComponent();

            articuloService = new Articulos();
        }

        internal void InitDetalle(int idArticulo) {
            DataRow fila = articuloService.recuperarArticuloCompletoPorID(idArticulo);

            txtId.Text = fila["id_art"].ToString();
            txtNombre.Text = fila["nombre"].ToString();
            txtDescripcion.Text = fila["descripcion"].ToString();
            txtPrecio.Text = fila["precioUnitario"].ToString();
            txtTipo.Text = fila[4].ToString();
        }

        private void btnDone_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
