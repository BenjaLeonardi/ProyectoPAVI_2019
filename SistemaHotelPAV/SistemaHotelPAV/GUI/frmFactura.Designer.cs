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
            this.btnArticuloAgregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblArticuloCantidad = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArticuloPrecio = new System.Windows.Forms.TextBox();
            this.txtArticuloSubtotal = new System.Windows.Forms.TextBox();
            this.txtArticuloCantidad = new System.Windows.Forms.TextBox();
            this.txtArticuloNombre = new System.Windows.Forms.TextBox();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
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
            this.label3.Location = new System.Drawing.Point(423, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha";
            // 
            // pickerFechaFactura
            // 
            this.pickerFechaFactura.Location = new System.Drawing.Point(426, 26);
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
            this.txtNroEstadia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtCliente.Text = "Seleccione una fecha y un numero de Estadia";
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
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
            this.dgvListaArt.Location = new System.Drawing.Point(14, 115);
            this.dgvListaArt.Name = "dgvListaArt";
            this.dgvListaArt.ReadOnly = true;
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
            this.id_articulo.ReadOnly = true;
            this.id_articulo.Width = 50;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.Frozen = true;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // precioUnitario
            // 
            this.precioUnitario.Frozen = true;
            this.precioUnitario.HeaderText = "Precio";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(470, 552);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(551, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(499, 399);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total";
            // 
            // gbxDetalleFac
            // 
            this.gbxDetalleFac.Controls.Add(this.btnQuitarArt);
            this.gbxDetalleFac.Controls.Add(this.label7);
            this.gbxDetalleFac.Controls.Add(this.btnArticuloAgregar);
            this.gbxDetalleFac.Controls.Add(this.txtTotal);
            this.gbxDetalleFac.Controls.Add(this.label11);
            this.gbxDetalleFac.Controls.Add(this.label12);
            this.gbxDetalleFac.Controls.Add(this.lblArticuloCantidad);
            this.gbxDetalleFac.Controls.Add(this.label9);
            this.gbxDetalleFac.Controls.Add(this.label8);
            this.gbxDetalleFac.Controls.Add(this.txtArticuloPrecio);
            this.gbxDetalleFac.Controls.Add(this.txtArticuloSubtotal);
            this.gbxDetalleFac.Controls.Add(this.txtArticuloCantidad);
            this.gbxDetalleFac.Controls.Add(this.txtArticuloNombre);
            this.gbxDetalleFac.Controls.Add(this.txtIdArticulo);
            this.gbxDetalleFac.Controls.Add(this.dgvListaArt);
            this.gbxDetalleFac.Location = new System.Drawing.Point(15, 115);
            this.gbxDetalleFac.Name = "gbxDetalleFac";
            this.gbxDetalleFac.Size = new System.Drawing.Size(611, 431);
            this.gbxDetalleFac.TabIndex = 10;
            this.gbxDetalleFac.TabStop = false;
            // 
            // btnQuitarArt
            // 
            this.btnQuitarArt.Location = new System.Drawing.Point(223, 397);
            this.btnQuitarArt.Name = "btnQuitarArt";
            this.btnQuitarArt.Size = new System.Drawing.Size(167, 23);
            this.btnQuitarArt.TabIndex = 12;
            this.btnQuitarArt.Text = "Quitar Articulo Seleccionado";
            this.btnQuitarArt.UseVisualStyleBackColor = true;
            this.btnQuitarArt.Click += new System.EventHandler(this.btnQuitarArt_Click);
            // 
            // btnArticuloAgregar
            // 
            this.btnArticuloAgregar.Location = new System.Drawing.Point(499, 82);
            this.btnArticuloAgregar.Name = "btnArticuloAgregar";
            this.btnArticuloAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnArticuloAgregar.TabIndex = 12;
            this.btnArticuloAgregar.Text = "Agregar";
            this.btnArticuloAgregar.UseVisualStyleBackColor = true;
            this.btnArticuloAgregar.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Precio Unidad";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(390, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Subtotal";
            // 
            // lblArticuloCantidad
            // 
            this.lblArticuloCantidad.AutoSize = true;
            this.lblArticuloCantidad.Location = new System.Drawing.Point(11, 69);
            this.lblArticuloCantidad.Name = "lblArticuloCantidad";
            this.lblArticuloCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblArticuloCantidad.TabIndex = 9;
            this.lblArticuloCantidad.Text = "Cantidad";
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
            // txtArticuloPrecio
            // 
            this.txtArticuloPrecio.Location = new System.Drawing.Point(499, 39);
            this.txtArticuloPrecio.Name = "txtArticuloPrecio";
            this.txtArticuloPrecio.ReadOnly = true;
            this.txtArticuloPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtArticuloPrecio.TabIndex = 6;
            this.txtArticuloPrecio.Text = "0";
            this.txtArticuloPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArticuloSubtotal
            // 
            this.txtArticuloSubtotal.Location = new System.Drawing.Point(393, 85);
            this.txtArticuloSubtotal.Name = "txtArticuloSubtotal";
            this.txtArticuloSubtotal.ReadOnly = true;
            this.txtArticuloSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtArticuloSubtotal.TabIndex = 6;
            this.txtArticuloSubtotal.Text = "0";
            this.txtArticuloSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArticuloCantidad
            // 
            this.txtArticuloCantidad.Location = new System.Drawing.Point(14, 85);
            this.txtArticuloCantidad.Name = "txtArticuloCantidad";
            this.txtArticuloCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtArticuloCantidad.TabIndex = 6;
            this.txtArticuloCantidad.Text = "1";
            this.txtArticuloCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtArticuloCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtArticuloNombre
            // 
            this.txtArticuloNombre.Location = new System.Drawing.Point(120, 39);
            this.txtArticuloNombre.Name = "txtArticuloNombre";
            this.txtArticuloNombre.ReadOnly = true;
            this.txtArticuloNombre.Size = new System.Drawing.Size(373, 20);
            this.txtArticuloNombre.TabIndex = 6;
            this.txtArticuloNombre.Text = "Ingrese un ID de Articulo";
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(14, 39);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtIdArticulo.TabIndex = 6;
            this.txtIdArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdArticulo.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 583);
            this.Controls.Add(this.gbxDetalleFac);
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
        private System.Windows.Forms.Button btnArticuloAgregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblArticuloCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArticuloPrecio;
        private System.Windows.Forms.TextBox txtArticuloCantidad;
        private System.Windows.Forms.TextBox txtArticuloNombre;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtArticuloSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}