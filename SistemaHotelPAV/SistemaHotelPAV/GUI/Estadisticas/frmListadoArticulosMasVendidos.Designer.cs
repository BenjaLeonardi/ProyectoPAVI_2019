namespace SistemaHotelPAV.GUI.Estadisticas {
    partial class frmListadoArticulosMasVendidos {
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
            this.dsListadoArticulosVendidos = new SistemaHotelPAV.dsListadoArticulosVendidos();
            this.dtArticulosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtaArticulosVendidos = new SistemaHotelPAV.dsListadoArticulosVendidosTableAdapters.dtaArticulosVendidos();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoArticulosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TablaArticulos";
            reportDataSource1.Value = this.dtArticulosVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaHotelPAV.GUI.Estadisticas.rptArticulosMasVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(477, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsListadoArticulosVendidos
            // 
            this.dsListadoArticulosVendidos.DataSetName = "dsListadoArticulosVendidos";
            this.dsListadoArticulosVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtArticulosVendidosBindingSource
            // 
            this.dtArticulosVendidosBindingSource.DataMember = "dtArticulosVendidos";
            this.dtArticulosVendidosBindingSource.DataSource = this.dsListadoArticulosVendidos;
            // 
            // dtaArticulosVendidos
            // 
            this.dtaArticulosVendidos.ClearBeforeFill = true;
            // 
            // frmListadoArticulosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoArticulosMasVendidos";
            this.Text = "frmListadoArticulosMasVendidos";
            this.Load += new System.EventHandler(this.frmListadoArticulosMasVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoArticulosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtArticulosVendidosBindingSource;
        private dsListadoArticulosVendidos dsListadoArticulosVendidos;
        private dsListadoArticulosVendidosTableAdapters.dtaArticulosVendidos dtaArticulosVendidos;
    }
}