using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelPAV.DataAccessLayer;
using SistemaHotelPAV.Entities;
using SistemaHotelPAV.Formularios;
using SistemaHotelPAV.Clases;

namespace SistemaHotelPAV
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Datos objDatos = new Datos();
            int idUsuario = objDatos.validarUsuarioLogin(txtUsuario.Text, txtContrasena.Text);

            if (idUsuario != 0) //Podemos hacer despues que el usuario se quede guardado, ver despues
            {
                MessageBox.Show("Bienvenido al sistema del Hotel Grandario!", "Bienvenido");
                frmMenuPrincipal FormMenu = new frmMenuPrincipal();
                Sesion.userID = idUsuario;
                FormMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El login ha sido incorrecto, compruebe la contraseña y el usuario para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtUsuario.Focus();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Desea salir del programa?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
