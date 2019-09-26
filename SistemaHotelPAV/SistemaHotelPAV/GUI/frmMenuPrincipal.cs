using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelPAV.Formularios;

namespace SistemaHotelPAV.Formularios
{
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
    }
}
