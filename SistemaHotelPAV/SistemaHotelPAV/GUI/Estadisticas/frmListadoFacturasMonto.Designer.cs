namespace SistemaHotelPAV.GUI.Estadisticas {
    partial class frmListadoFacturasMonto {
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsMontosFacturas = new SistemaHotelPAV.dsMontosFacturas();
            this.dtMontosFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtaMontosFacturas = new SistemaHotelPAV.dsMontosFacturasTableAdapters.dtaMontosFacturas();
            ((System.ComponentModel.ISupportInitialize)(this.dsMontosFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMontosFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtMontosFacturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaHotelPAV.GUI.Reportes.rptFacturasMonto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(360, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsMontosFacturas
            // 
            this.dsMontosFacturas.DataSetName = "dsMontosFacturas";
            this.dsMontosFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtMontosFacturasBindingSource
            // 
            this.dtMontosFacturasBindingSource.DataMember = "dtMontosFacturas";
            this.dtMontosFacturasBindingSource.DataSource = this.dsMontosFacturas;
            // 
            // dtaMontosFacturas
            // 
            this.dtaMontosFacturas.ClearBeforeFill = true;
            // 
            // frmListadoFacturasMonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoFacturasMonto";
            this.Text = "frmListadoFacturasMonto";
            this.Load += new System.EventHandler(this.frmListadoFacturasMonto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMontosFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMontosFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtMontosFacturasBindingSource;
        private dsMontosFacturas dsMontosFacturas;
        private dsMontosFacturasTableAdapters.dtaMontosFacturas dtaMontosFacturas;
    }
}