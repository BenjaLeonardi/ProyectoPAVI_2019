using SistemaHotelPAV.GUI;
using System;
using System.Windows.Forms;
using SistemaHotelPAV.Entities;
using SistemaHotelPAV.DataAccessLayer;
using System.Data;
using SistemaHotelPAV.Clases;
using SistemaHotelPAV.GUI.Reportes;

namespace SistemaHotelPAV.Formularios {
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Sistema Grandario esta siendo desarrollado, algunas de sus funciones todavia no estan terminadas!","Atencion!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void formularioProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos FormArt = new frmArticulos();
            FormArt.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {/*
            if ((MessageBox.Show("Desea cerrar sesion?", "Cerrando Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) == DialogResult.Yes) //Ver porque se repite dos veces con este metodo
            {
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }*/
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios FormUsu = new frmUsuarios();
            FormUsu.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmFactura FormFactura = new frmFactura();
            FormFactura.ShowDialog();
        }
            
        private void btnArticulos_Click(object sender, EventArgs e) {
            frmArticulos FormArt = new frmArticulos();
            FormArt.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e) {
            frmUsuarios FormUsuarios = new frmUsuarios();
            FormUsuarios.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e) {
            frmFactura FormFactura = new frmFactura();
            FormFactura.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            stsLabelUser.Text = "Usuario: " + Sesion.UserNombreCompleto;
        }

        private void clientesPorEstadiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCxE FormCxE = new frmReporteCxE();
            FormCxE.ShowDialog();
        }

        private void usuariosPorBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteUxB FormUxB = new frmReporteUxB();
            FormUxB.ShowDialog();
        }

        private void articulosPorFacturaToolStripMenuItem_Click(object sender, EventArgs e) {
            frmReporteArticuloFactura formReporteArticuloFactura = new frmReporteArticuloFactura();
            formReporteArticuloFactura.ShowDialog();
        }

        private void vehiculosPorClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            frmReporteVehiculoCliente FormReporteVehiculoCliente = new frmReporteVehiculoCliente();
            FormReporteVehiculoCliente.ShowDialog();
        }
    }
}
