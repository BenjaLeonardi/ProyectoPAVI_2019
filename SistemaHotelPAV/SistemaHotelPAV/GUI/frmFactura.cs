using SistemaHotelPAV.DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaHotelPAV.GUI {
    public partial class frmFactura : Form
    {
        Datos objDatos = new Datos();
        FacturaDA Facturas = new FacturaDA();
        EstadiaDA Estadias = new EstadiaDA();
        DataTable tablaTiposFactura = new DataTable();
        DataTable tablaClientes = new DataTable();
        DataTable tablaArticulos = new DataTable();

        public frmFactura()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            tablaTiposFactura = objDatos.consultarTabla("TiposFactura");
            LlenarCombo(cmbTipoFactura, tablaTiposFactura, "descripcion", "id_tipo");

            tablaClientes = objDatos.consultarTabla("Clientes");
            tablaArticulos = objDatos.consultarTabla("Articulos");

            // Setteamos hoy
            pickerFechaFactura.Value = DateTime.Today;
        }

        private void LlenarCombo(ComboBox cbo, DataTable tabla, string display, String value)
        {
            cbo.DataSource = tabla;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            dgvListaArt.Rows.Add(txtID.Text, txtNombreArt.Text, txtCantidad.Text, "DESCRIPCION", txtPrecio.Text, (Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text))); //Falta descripcion que entraria como dato de la consulta del id en la tabla articulos, porque no hace falta un textBox con descripcion, subtotal safa porque es un calculo pasado a String
        }

        private void btnQuitarArt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvListaArt.SelectedRows)
            {
                dgvListaArt.Rows.RemoveAt(item.Index);
            }
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

        private void cmbTipoFactura_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbTipoFactura.SelectedItem != null) {
                string tipo_seleccionado = cmbTipoFactura.SelectedValue.ToString();
                // Solo buscamos el ultimo ID si el tipo seleccionado es valido [un numero]
                if (int.TryParse(tipo_seleccionado, out int parsed)) {
                    string ultimo_id = Facturas.GetLastFacturaID(tipo_seleccionado).ToString();
                    txtNroFactura.Text = ultimo_id;
                }
            }
        }

        private void pickerFechaInicioEstadia_ValueChanged(object sender, EventArgs e) {
            DisplayFoundEstadia();
        }
        private void txtNroEstadia_TextChanged(object sender, EventArgs e) {
            DisplayFoundEstadia();
        }

        DataTable estadiaSeleccionada;

        void DisplayFoundEstadia() {
            DateTime fechaInicio = pickerFechaInicioEstadia.Value;
            int nroEstadia = -1;
            estadiaSeleccionada = new DataTable();

            if(int.TryParse(txtNroEstadia.Text, out nroEstadia)) {
                estadiaSeleccionada = Estadias.GetEstadiaCompleto(fechaInicio, nroEstadia);
            }
            if (estadiaSeleccionada.Rows.Count > 0) {
                txtCliente.Text = estadiaSeleccionada.Rows[0]["apellidos"].ToString() + ", " + estadiaSeleccionada.Rows[0]["nombres"].ToString();
            } else {
                txtCliente.Text = "No se encontraron estadias";
            }
        }
    }
}
