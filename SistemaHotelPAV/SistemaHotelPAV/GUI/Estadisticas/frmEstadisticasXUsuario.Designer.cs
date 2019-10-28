namespace SistemaHotelPAV.GUI.Estadisticas
{
    partial class frmEstadisticasXUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFacturas = new System.Windows.Forms.RadioButton();
            this.rdbEstadias = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEstadistica = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(15, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(18, 28);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(177, 21);
            this.cboUsuario.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFacturas);
            this.groupBox1.Controls.Add(this.rdbEstadias);
            this.groupBox1.Location = new System.Drawing.Point(18, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Filtro";
            // 
            // rdbFacturas
            // 
            this.rdbFacturas.AutoSize = true;
            this.rdbFacturas.Location = new System.Drawing.Point(43, 45);
            this.rdbFacturas.Name = "rdbFacturas";
            this.rdbFacturas.Size = new System.Drawing.Size(85, 17);
            this.rdbFacturas.TabIndex = 1;
            this.rdbFacturas.TabStop = true;
            this.rdbFacturas.Text = "Por Facturas";
            this.rdbFacturas.UseVisualStyleBackColor = true;
            // 
            // rdbEstadias
            // 
            this.rdbEstadias.AutoSize = true;
            this.rdbEstadias.Location = new System.Drawing.Point(43, 22);
            this.rdbEstadias.Name = "rdbEstadias";
            this.rdbEstadias.Size = new System.Drawing.Size(84, 17);
            this.rdbEstadias.TabIndex = 0;
            this.rdbEstadias.TabStop = true;
            this.rdbEstadias.Text = "Por Estadias";
            this.rdbEstadias.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Desde";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(240, 28);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaDesde.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(240, 80);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaHasta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(250, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEstadistica
            // 
            this.dgvEstadistica.AllowUserToAddRows = false;
            this.dgvEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadistica.Location = new System.Drawing.Point(18, 166);
            this.dgvEstadistica.Name = "dgvEstadistica";
            this.dgvEstadistica.ReadOnly = true;
            this.dgvEstadistica.Size = new System.Drawing.Size(625, 338);
            this.dgvEstadistica.TabIndex = 7;
            // 
            // frmEstadisticasXUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 516);
            this.Controls.Add(this.dgvEstadistica);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmEstadisticasXUsuario";
            this.Text = "Estadisticas por Usuario";
            this.Load += new System.EventHandler(this.frmEstadisticasXUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFacturas;
        private System.Windows.Forms.RadioButton rdbEstadias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEstadistica;
    }
}