using SistemaHotelPAV.DataAccessLayer;
using SistemaHotelPAV.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaHotelPAV.GUI {
    public partial class frmFactura : Form
    {
        Datos Datos = new Datos();
        FacturaDA Facturas = new FacturaDA();
        EstadiaDA Estadias = new EstadiaDA();
        ArticuloDA Articulos = new ArticuloDA();
        Usuarios Usuario = new Usuarios();

        DataTable tablaTiposFactura = new DataTable();

        DataTable estadiaSeleccionada = new DataTable();
        DataTable articuloSeleccionado = new DataTable();
        
        public frmFactura()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            tablaTiposFactura = Datos.consultarTabla("TiposFactura");
            LlenarCombo(cmbTipoFactura, tablaTiposFactura, "descripcion", "id_tipo");
            
            // Setteamos hoy
            pickerFechaFactura.Value = DateTime.Today;

            // Deshabilitamos agregar
            HabilitarAdicionDetalle(false);
            HabilitarSetteoCantidad(false);
            HabilitarRegistroFactura(false);
            LimpiarCampos();
        }

        private void LlenarCombo(ComboBox cbo, DataTable tabla, string display, String value)
        {
            cbo.DataSource = tabla;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnAgregarArt_Click(object sender, EventArgs e) {
            float subtotal = float.Parse(txtArticuloCantidad.Text) * float.Parse(articuloSeleccionado.Rows[0]["precioUnitario"].ToString());
            bool existente = false;
            for (int i = 0; i < dgvListaArt.RowCount; i++) {
                if (dgvListaArt.Rows[i].Cells["id_articulo"].Value.ToString() == txtIdArticulo.Text) {
                    dgvListaArt.Rows[i].Cells["cantidad"].Value = (int.Parse(dgvListaArt.Rows[i].Cells["cantidad"].Value.ToString()) + int.Parse(txtArticuloCantidad.Text)).ToString();
                    dgvListaArt.Rows[i].Cells["subtotal"].Value = (float.Parse(dgvListaArt.Rows[i].Cells["subtotal"].Value.ToString()) + subtotal).ToString();
                    existente = true;
                }
            }
            if (!existente) {
                dgvListaArt.Rows.Add(txtIdArticulo.Text,
                    txtArticuloNombre.Text,
                    articuloSeleccionado.Rows[0]["descripcion"],
                    txtArticuloCantidad.Text,
                    articuloSeleccionado.Rows[0]["precioUnitario"],
                    subtotal.ToString());
            }
            MostrarTotal();
        }

        private void btnQuitarArt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvListaArt.SelectedRows)
            {
                dgvListaArt.Rows.RemoveAt(item.Index);
            }
            MostrarTotal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir del formulario?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e) {

        }

        private void cmbTipoFactura_SelectedIndexChanged(object sender, EventArgs e) 
        {
            ComprobarRequisitosRegistro();
        }

        private void pickerFechaInicioEstadia_ValueChanged(object sender, EventArgs e) 
        {
            DisplayFoundEstadia();
        }
        private void txtNroEstadia_TextChanged(object sender, EventArgs e) 
        {
            DisplayFoundEstadia();
        }
        
        void DisplayFoundEstadia() 
        {
            DateTime fechaInicio = pickerFechaInicioEstadia.Value;
            int nroEstadia = -1;
            estadiaSeleccionada = new DataTable();

            if(int.TryParse(txtNroEstadia.Text, out nroEstadia)) {
                estadiaSeleccionada = Estadias.GetEstadiaCompleto(fechaInicio, nroEstadia);
            }
            if (estadiaSeleccionada.Rows.Count > 0) 
            {
                txtCliente.Text = estadiaSeleccionada.Rows[0]["apellidos"].ToString() + ", " + estadiaSeleccionada.Rows[0]["nombres"].ToString();
            } else {
                txtCliente.Text = "Seleccione una fecha y un numero de Estadia validos";
            }
            ComprobarRequisitosRegistro();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e) 
        {

        }
        
        private void txtID_TextChanged(object sender, EventArgs e) 
        {
            int idArticulo;
            articuloSeleccionado = new DataTable();
            if (int.TryParse(txtIdArticulo.Text, out idArticulo))
            {
                articuloSeleccionado = Articulos.recuperarArticuloID(idArticulo);
            }
            if(articuloSeleccionado.Rows.Count > 0) 
            {
                txtArticuloNombre.Text = articuloSeleccionado.Rows[0]["nombre"].ToString();
                txtArticuloPrecio.Text = "$ " + articuloSeleccionado.Rows[0]["precioUnitario"].ToString();
                HabilitarSetteoCantidad(true);
            } 
            else 
            {
                txtArticuloNombre.Text = "Ingrese un ID de Articulo valido";
                HabilitarAdicionDetalle(false);
                HabilitarSetteoCantidad(false);
            }
        }

        void HabilitarAdicionDetalle(bool toggle) 
        {
            btnArticuloAgregar.Enabled = toggle;
        }

        void HabilitarSetteoCantidad(bool toggle) 
        {
            txtArticuloCantidad.Enabled = toggle;
            txtArticuloCantidad.Text = "";
            if (toggle) {
                txtArticuloCantidad.Text = "1";
            }
        }

        void ComprobarRequisitosRegistro()
        {
            if(cmbTipoFactura.SelectedIndex != -1 &&
                estadiaSeleccionada.Rows.Count > 0 &&
                dgvListaArt.RowCount > 0)
            {
                HabilitarRegistroFactura(true);
            }
            else
            {
                HabilitarRegistroFactura(false);
            }
        }

        void HabilitarRegistroFactura(bool toggle)
        {
            btnRegistrar.Enabled = toggle;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e) 
        {
            int cantidadArticulo = 0;
            if(articuloSeleccionado.Rows.Count > 0 && int.TryParse(txtArticuloCantidad.Text, out cantidadArticulo)) 
            {
                if (cantidadArticulo > 0) 
                {
                    txtArticuloSubtotal.Text = "$ " + (cantidadArticulo * float.Parse(articuloSeleccionado.Rows[0]["precioUnitario"].ToString())).ToString();
                    HabilitarAdicionDetalle(true);
                } else {
                    txtArticuloSubtotal.Text = "";
                    HabilitarAdicionDetalle(false);
                }
            } else {
                txtArticuloSubtotal.Text = "";
                HabilitarAdicionDetalle(false);
            }
        }

        void MostrarTotal() 
        {
            float sum = 0;
            for (int i = 0; i < dgvListaArt.RowCount; i++)
            {
                sum += float.Parse(dgvListaArt.Rows[i].Cells["subtotal"].Value.ToString());
            }
            txtTotal.Text = sum.ToString();

            ComprobarRequisitosRegistro();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) 
        {
            string idFactura = (Facturas.GetLastFacturaID(cmbTipoFactura.SelectedValue.ToString()) + 1).ToString();
            string tipoFactura = cmbTipoFactura.SelectedValue.ToString();

            Datos.ResultadoTransaccion result = Datos.ResultadoTransaccion.fracaso;
            if (dgvListaArt.Rows.Count > 0) {
                Facturas.IniciarTransaccion();
                Facturas.GrabarFactura(idFactura, tipoFactura,
                    pickerFechaFactura.Value.ToString("yyyy'-'MM'-'dd"),
                    txtNroEstadia.Text,
                    pickerFechaInicioEstadia.Value.ToString("yyyy'-'MM'-'dd"),
                    txtTotal.Text.ToString()
                    );
                for (int i = 0; i < dgvListaArt.Rows.Count; i++)
                {
                    Facturas.GrabarDetalle(idFactura, tipoFactura,
                        dgvListaArt.Rows[i].Cells["id_articulo"].Value.ToString(),
                        dgvListaArt.Rows[i].Cells["cantidad"].Value.ToString(),
                        dgvListaArt.Rows[i].Cells["precioUnitario"].Value.ToString());
                }
                result = Facturas.FinalizarTransaccion();
            }
            if (result == DataAccessLayer.Datos.ResultadoTransaccion.exito)
            {
                LimpiarCampos();
            }
        }

        void LimpiarCampos()
        {
            cmbTipoFactura.SelectedIndex = -1;
            pickerFechaFactura.Value = DateTime.Now;
            txtNroEstadia.Text = "";
            txtIdArticulo.Text = "";
            txtArticuloPrecio.Text = "";
            dgvListaArt.Rows.Clear();
            MostrarTotal();
        }

        private void txtArticuloNombre_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
