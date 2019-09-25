using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using SistemaHotelPAV.Entities;

namespace SistemaHotelPAV.Formularios
{
    public partial class frmUsuarios : Form
    {

        Usuarios objUsu = new Usuarios();
        Datos objDatos = new Datos();
        private bool flagNuevo;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.dgvUsuarios.DataSource = objUsu.recuperarUsuarios(); //El recuperar usuarios ya tiene incluido el join por ende carga el nombre del barrio automaticamente

            dgvUsuarios.Columns[0].HeaderText = "ID Usuario";
            dgvUsuarios.Columns[1].HeaderText = "Usuario";
            dgvUsuarios.Columns[2].HeaderText = "Password";
            dgvUsuarios.Columns[3].HeaderText = "Apellido";
            dgvUsuarios.Columns[4].HeaderText = "Nombre";
            dgvUsuarios.Columns[5].HeaderText = "Nro DNI";
            dgvUsuarios.Columns[6].HeaderText = "Fecha Nacimiento";
            dgvUsuarios.Columns[7].HeaderText = "Calle";
            dgvUsuarios.Columns[8].HeaderText = "Nro Calle";
            dgvUsuarios.Columns[9].HeaderText = "Barrio";


            DataTable tabla = new DataTable();
            tabla = objDatos.consultarTabla("Barrios"); //Aca cargo los barrios al combo cuando empieza todo
            LlenarCombo(cmbBarrio, tabla, "nombre", "id_barrio");
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
            tabla = objUsu.recuperarUsuarioID(id);
            txtId_Usu.Text = tabla.Rows[0]["id_usu"].ToString();
            txtUsuario.Text = tabla.Rows[0]["usuario"].ToString();
            txtPassword.Text = tabla.Rows[0]["password"].ToString();
            txtApellido.Text = tabla.Rows[0]["apellido"].ToString();
            txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
            txtNroDni.Text = tabla.Rows[0]["nroDni"].ToString();
            txtFechaNac.Text = tabla.Rows[0]["fechaNac"].ToString();
            txtCalle.Text = tabla.Rows[0]["calle"].ToString();
            txtNroCalle.Text = tabla.Rows[0]["nroCalle"].ToString();
            cmbBarrio.SelectedValue = tabla.Rows[0]["id_barrio"];
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.actualizarCampos(Convert.ToInt32(dgvUsuarios.SelectedCells[0].Value));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void habilitar(bool x) 
        {
            txtId_Usu.Enabled = x;
            txtUsuario.Enabled = x;
            txtPassword.Enabled = x;
            txtApellido.Enabled = x;
            txtNombre.Enabled = x;
            txtNroDni.Enabled = x;
            txtFechaNac.Enabled = x;
            txtCalle.Enabled = x;
            txtNroCalle.Enabled = x;
            cmbBarrio.Enabled = x;
            btnBorrar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnSalir.Enabled = !x;
            btnCancelar.Enabled = x;
            btnGuardar.Enabled = x;
        }

        private void limpiar()
        {
            txtId_Usu.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtNroDni.Text = "";
            txtFechaNac.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            cmbBarrio.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            flagNuevo = true;
            habilitar(true);
            limpiar();
            txtId_Usu.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            flagNuevo = false;
            habilitar(false);
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habilitar(true);
            txtId_Usu.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Esta seguro que desea borrar este registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)) == System.Windows.Forms.DialogResult.Yes)
            {

                objUsu.eliminarUsuario();
                this.dgvUsuarios.DataSource = objUsu.recuperarUsuarios(); //Actualizo tabla despues de eliminar el registro

                MessageBox.Show("El registro fue borrado", "ELIMINACION EXITOSA");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objUsu.Id_usu = Convert.ToInt32(txtId_Usu.Text);
            objUsu.Usuario = txtUsuario.Text;
            objUsu.Password = txtPassword.Text;
            objUsu.Apellido = txtApellido.Text;
            objUsu.Nombre = txtNombre.Text;
            objUsu.NroDni = txtNroDni.Text;
            objUsu.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
            objUsu.Calle = txtCalle.Text;
            objUsu.NroCalle = Convert.ToInt32(txtCalle.Text);
            objUsu.Id_barrio = Convert.ToInt32(cmbBarrio.SelectedValue);

            if (objUsu.validarDatosUsuarios())
            {
                if (this.flagNuevo == true)
                {
                    objUsu.guardarUsuario();
                    this.flagNuevo = false; //Flag para saber si grabamos una actualizacion o insercion
                }
                else
                {
                    objUsu.editarUsuario();
                }
            }

            MessageBox.Show("El usuario se guardo con exito!", "Guardado exitoso");
            this.dgvUsuarios.DataSource = objUsu.recuperarUsuarios(); //Recargo la grilla despues de guardar
            this.limpiar();
            this.habilitar(false);
        }
    }
}
