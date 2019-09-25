using System;
using System.Data;
using System.Windows.Forms;
using SistemaHotelPAV.Entities;
using SistemaHotelPAV.DataAccessLayer;

namespace SistemaHotelPAV.Formularios {
    public partial class frmDetalleArticulo : Form {

        private ArticuloDA articuloDA;
        public frmDetalleArticulo() {
            InitializeComponent();

            articuloDA = new ArticuloDA();
        }

        internal void InitDetalle(int idArticulo) {
            DataRow fila = articuloDA.recuperarArticuloCompletoPorID(idArticulo);

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
