namespace SistemaHotelPAV.GUI.Reportes {
    partial class frmReporteArticuloFactura {
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturasDetallesFacturaArticulos = new SistemaHotelPAV.FacturasDetallesFacturaArticulos();
            this.dtFacturasArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtFacturasArticulosTableAdapter = new SistemaHotelPAV.FacturasDetallesFacturaArticulosTableAdapters.dtFacturasArticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetallesFacturaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturasArticulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "dsFacturasDetallesFacturaArticulos";
            reportDataSource2.Value = this.dtFacturasArticulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaHotelPAV.GUI.Reportes.rptFacturaArticulo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(969, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturasDetallesFacturaArticulos
            // 
            this.facturasDetallesFacturaArticulos.DataSetName = "FacturasDetallesFacturaArticulos";
            this.facturasDetallesFacturaArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtFacturasArticulosBindingSource
            // 
            this.dtFacturasArticulosBindingSource.DataMember = "dtFacturasArticulos";
            this.dtFacturasArticulosBindingSource.DataSource = this.facturasDetallesFacturaArticulos;
            // 
            // dtFacturasArticulosTableAdapter
            // 
            this.dtFacturasArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteArticuloFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteArticuloFactura";
            this.Text = "frmReporteArticuloFactura";
            this.Load += new System.EventHandler(this.frmReporteArticuloFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasDetallesFacturaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturasArticulosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FacturasDetallesFacturaArticulos facturasDetallesFacturaArticulos;
        private System.Windows.Forms.BindingSource dtFacturasArticulosBindingSource;
        private FacturasDetallesFacturaArticulosTableAdapters.dtFacturasArticulosTableAdapter dtFacturasArticulosTableAdapter;
    }
}