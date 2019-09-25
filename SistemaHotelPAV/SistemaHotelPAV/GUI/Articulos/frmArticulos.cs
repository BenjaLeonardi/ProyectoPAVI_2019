using System;
using System.Data;
using System.Windows.Forms;
using SistemaHotelPAV.Entities;
using SistemaHotelPAV.DataAccessLayer;

namespace SistemaHotelPAV.Formularios
{
    public partial class frmArticulos : Form
    {

        Articulo objArt = new Articulo();
        Datos objDatos = new Datos();
        private bool flagNuevo = false;
        ArticuloDA articuloDA;

        public frmArticulos()
        {
            InitializeComponent();
            articuloDA = new ArticuloDA();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void habilitar(bool x) //x siendo el booleano que entra por la funcion
        {
            txtId.Enabled = x;
            txtNombre.Enabled = x;
            txtDescripcion.Enabled = x;
            txtPrecio.Enabled = x;
            btnBorrar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnSalir.Enabled = !x;
            btnCancelar.Enabled = x;
            btnGuardar.Enabled = x;
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }


        private void frmArticulos_Load(object sender, EventArgs e)
        {
            this.grdArticulos.DataSource = articuloDA.recuperarArticulos();

            grdArticulos.Columns[0].HeaderText = "ID";
            grdArticulos.Columns[1].HeaderText = "Nombre";
            grdArticulos.Columns[2].HeaderText = "Descripcion";
            grdArticulos.Columns[3].HeaderText = "Precio Unitario";
            grdArticulos.Columns[4].HeaderText = "Tipo"; // Aca defino los nombres de las columnas de la DGV

            /*for (int x = 0; x == Convert.ToInt32(grdArticulos.ColumnCount);)
            {
                grdArticulos.Columns[x].HeaderText = "x"; // Ver como se usa esto
            }*/


            DataTable tabla = new DataTable();
            tabla = objDatos.consultarTabla("Tipos");
            LlenarCombo(cmbTipos, tabla, "nombre", "id_tipo");
        }

        private void LlenarCombo(ComboBox cbo, DataTable tabla, string display, String value)
        {
            cbo.DataSource = tabla;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = articuloDA.recuperarArticuloID(id);
            txtId.Text = tabla.Rows[0]["id_art"].ToString();
            txtNombre.Text = tabla.Rows[0]["nombre"].ToString(); 
            txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txtPrecio.Text = tabla.Rows[0]["precioUnitario"].ToString();
        }

        private void grdArticulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.actualizarCampos(Convert.ToInt32(grdArticulos.SelectedCells[0].Value)); //Selecciona el id que esta en la primera celda de la data grid view y la pasa como parametro
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            flagNuevo = true;
            habilitar(true);
            limpiar();
            txtId.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            flagNuevo = false;
            habilitar(false);
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objArt.ID_ART = Convert.ToInt32(txtId.Text); //Aca armo el usuario correctamente con todos los atributos asignados desde los txt
            objArt.NOMBRE = txtNombre.Text;
            objArt.DESCRIPCION = txtDescripcion.Text;
            objArt.PRECIOUNITARIO = Convert.ToInt32(txtPrecio.Text);

            if (articuloDA.validarDatosArticulo(objArt))
            {
                if (this.flagNuevo == true)
                {
                    articuloDA.guardarArticulo(objArt);
                    this.flagNuevo = false; //Flag para saber si grabamos una actualizacion o insercion
                }
                else
                {
                    articuloDA.modificarArticulo(objArt);
                }
            }

            MessageBox.Show("El articulo se guardo con exito!", "Guardado exitoso");
            this.grdArticulos.DataSource = articuloDA.recuperarArticulos(); //Recargo la grilla despues de guardar
            this.limpiar();
            this.habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habilitar(true);
            txtId.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Esta seguro que desea borrar este registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)) == System.Windows.Forms.DialogResult.Yes)
            {

                articuloDA.eliminarArticulo(objArt);
                this.grdArticulos.DataSource = articuloDA.recuperarArticulos(); //Actualizo tabla despues de eliminar el registro

                MessageBox.Show("El registro fue borrado", "ELIMINACION EXITOSA");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable tabla2 = new DataTable();
            string consulta = "";
            var tipo = cmbTipos.SelectedValue.ToString();
            consulta = "SELECT * FROM Articulos WHERE 1=1 AND " + "(id_tipo=" + tipo + ")";
            tabla2 = objDatos.consultar(consulta);
            this.grdArticulos.DataSource = tabla2;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DataTable tabla3 = new DataTable();
            tabla3 = articuloDA.recuperarArticulos();
            grdArticulos.DataSource = tabla3;
            cmbTipos.SelectedValue = -1;
        }

        private void grdArticulos_CellClick(object sender, DataGridViewCellEventArgs e) {
            this.btnDetalle.Enabled = true;
        }

        private void btnDetalle_Click(object sender, EventArgs e) {
            if (grdArticulos.CurrentRow != null) {
                frmDetalleArticulo frmDetalle = new frmDetalleArticulo();
                frmDetalle.InitDetalle((int)grdArticulos.CurrentRow.Cells[0].Value);
                frmDetalle.ShowDialog();
            }
        }
    }
}
