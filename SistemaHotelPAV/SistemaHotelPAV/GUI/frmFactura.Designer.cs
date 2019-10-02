namespace SistemaHotelPAV.GUI {
    partial class frmFactura {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoFactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickerFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroEstadia = new System.Windows.Forms.TextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.pickerFechaInicioEstadia = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvListaArt = new System.Windows.Forms.DataGridView();
            this.id_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxDetalleFac = new System.Windows.Forms.GroupBox();
            this.btnQuitarArt = new System.Windows.Forms.Button();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombreArt = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArt)).BeginInit();
            this.gbxDetalleFac.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Factura";
            // 
            // cmbTipoFactura
            // 
            this.cmbTipoFactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoFactura.FormattingEnabled = true;
            this.cmbTipoFactura.Location = new System.Drawing.Point(15, 25);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoFactura.TabIndex = 2;
            this.cmbTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFactura_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha";
            // 
            // pickerFechaFactura
            // 
            this.pickerFechaFactura.Location = new System.Drawing.Point(254, 26);
            this.pickerFechaFactura.Name = "pickerFechaFactura";
            this.pickerFechaFactura.Size = new System.Drawing.Size(200, 20);
            this.pickerFechaFactura.TabIndex = 3;
            this.pickerFechaFactura.Value = new System.DateTime(2019, 10, 1, 18, 55, 12, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de Estadia";
            // 
            // txtNroEstadia
            // 
            this.txtNroEstadia.Location = new System.Drawing.Point(251, 76);
            this.txtNroEstadia.Name = "txtNroEstadia";
            this.txtNroEstadia.Size = new System.Drawing.Size(100, 20);
            this.txtNroEstadia.TabIndex = 0;
            this.txtNroEstadia.Text = "0";
            this.txtNroEstadia.TextChanged += new System.EventHandler(this.txtNroEstadia_TextChanged);
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(145, 26);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.ReadOnly = true;
            this.txtNroFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNroFactura.TabIndex = 0;
            this.txtNroFactura.Text = "0";
            // 
            // pickerFechaInicioEstadia
            // 
            this.pickerFechaInicioEstadia.Location = new System.Drawing.Point(15, 76);
            this.pickerFechaInicioEstadia.Name = "pickerFechaInicioEstadia";
            this.pickerFechaInicioEstadia.Size = new System.Drawing.Size(230, 20);
            this.pickerFechaInicioEstadia.TabIndex = 3;
            this.pickerFechaInicioEstadia.Value = new System.DateTime(2019, 10, 1, 18, 55, 12, 0);
            this.pickerFechaInicioEstadia.ValueChanged += new System.EventHandler(this.pickerFechaInicioEstadia_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Inicio Estadia";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(357, 76);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(269, 20);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.Text = "(Se completa solo, mostrando que encontro la estadia)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cliente";
            // 
            // dgvListaArt
            // 
            this.dgvListaArt.AllowUserToAddRows = false;
            this.dgvListaArt.AllowUserToDeleteRows = false;
            this.dgvListaArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_articulo,
            this.nombre,
            this.descripcion,
            this.cantidad,
            this.precioUnitario,
            this.subtotal});
            this.dgvListaArt.Location = new System.Drawing.Point(14, 163);
            this.dgvListaArt.Name = "dgvListaArt";
            this.dgvListaArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArt.Size = new System.Drawing.Size(585, 275);
            this.dgvListaArt.TabIndex = 5;
            this.dgvListaArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_articulo
            // 
            this.id_articulo.Frozen = true;
            this.id_articulo.HeaderText = "ID";
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.Width = 50;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.Frozen = true;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precioUnitario
            // 
            this.precioUnitario.Frozen = true;
            this.precioUnitario.HeaderText = "Precio";
            this.precioUnitario.Name = "precioUnitario";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(470, 625);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(551, 625);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(526, 589);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 574);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total";
            // 
            // gbxDetalleFac
            // 
            this.gbxDetalleFac.Controls.Add(this.btnQuitarArt);
            this.gbxDetalleFac.Controls.Add(this.btnAgregarArt);
            this.gbxDetalleFac.Controls.Add(this.label11);
            this.gbxDetalleFac.Controls.Add(this.label10);
            this.gbxDetalleFac.Controls.Add(this.label9);
            this.gbxDetalleFac.Controls.Add(this.label8);
            this.gbxDetalleFac.Controls.Add(this.txtPrecio);
            this.gbxDetalleFac.Controls.Add(this.txtCantidad);
            this.gbxDetalleFac.Controls.Add(this.txtNombreArt);
            this.gbxDetalleFac.Controls.Add(this.txtID);
            this.gbxDetalleFac.Controls.Add(this.dgvListaArt);
            this.gbxDetalleFac.Location = new System.Drawing.Point(15, 115);
            this.gbxDetalleFac.Name = "gbxDetalleFac";
            this.gbxDetalleFac.Size = new System.Drawing.Size(611, 450);
            this.gbxDetalleFac.TabIndex = 10;
            this.gbxDetalleFac.TabStop = false;
            // 
            // btnQuitarArt
            // 
            this.btnQuitarArt.Location = new System.Drawing.Point(524, 134);
            this.btnQuitarArt.Name = "btnQuitarArt";
            this.btnQuitarArt.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarArt.TabIndex = 12;
            this.btnQuitarArt.Text = "Quitar";
            this.btnQuitarArt.UseVisualStyleBackColor = true;
            this.btnQuitarArt.Click += new System.EventHandler(this.btnQuitarArt_Click);
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Location = new System.Drawing.Point(441, 134);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarArt.TabIndex = 12;
            this.btnAgregarArt.Text = "Agregar";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Precio";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre Articulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID Articulo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(120, 85);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(14, 85);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(120, 39);
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.ReadOnly = true;
            this.txtNombreArt.Size = new System.Drawing.Size(242, 20);
            this.txtNombreArt.TabIndex = 6;
            this.txtNombreArt.Text = "(Se completa solo, mostrando que encontro el ID)";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(14, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 660);
            this.Controls.Add(this.gbxDetalleFac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pickerFechaInicioEstadia);
            this.Controls.Add(this.pickerFechaFactura);
            this.Controls.Add(this.cmbTipoFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtNroEstadia);
            this.Controls.Add(this.txtNroFactura);
            this.Name = "frmFactura";
            this.Text = "Factura de compra en bar";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArt)).EndInit();
            this.gbxDetalleFac.ResumeLayout(false);
            this.gbxDetalleFac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pickerFechaFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroEstadia;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.DateTimePicker pickerFechaInicioEstadia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvListaArt;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxDetalleFac;
        private System.Windows.Forms.Button btnQuitarArt;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}