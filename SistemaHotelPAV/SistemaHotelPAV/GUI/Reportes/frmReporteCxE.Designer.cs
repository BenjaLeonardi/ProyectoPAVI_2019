namespace SistemaHotelPAV.GUI.Reportes
{
    partial class frmReporteCxE
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtClienteEstadiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReporteClienteEstadia = new SistemaHotelPAV.dsReporteClienteEstadia();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtClienteEstadiaTA = new SistemaHotelPAV.dsReporteClienteEstadiaTableAdapters.dtClienteEstadiaTA();
            ((System.ComponentModel.ISupportInitialize)(this.dtClienteEstadiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteClienteEstadia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtClienteEstadiaBindingSource
            // 
            this.dtClienteEstadiaBindingSource.DataMember = "dtClienteEstadia";
            this.dtClienteEstadiaBindingSource.DataSource = this.dsReporteClienteEstadia;
            // 
            // dsReporteClienteEstadia
            // 
            this.dsReporteClienteEstadia.DataSetName = "dsReporteClienteEstadia";
            this.dsReporteClienteEstadia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsReporteClienteEstadia";
            reportDataSource1.Value = this.dtClienteEstadiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaHotelPAV.GUI.Reportes.rptClienteEstadia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(997, 586);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtClienteEstadiaTA
            // 
            this.dtClienteEstadiaTA.ClearBeforeFill = true;
            // 
            // frmReporteCxE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 610);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteCxE";
            this.Text = "Reporte de Cliente por Estadias";
            this.Load += new System.EventHandler(this.frmReporteCxE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtClienteEstadiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteClienteEstadia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsReporteClienteEstadia dsReporteClienteEstadia;
        private System.Windows.Forms.BindingSource dtClienteEstadiaBindingSource;
        private dsReporteClienteEstadiaTableAdapters.dtClienteEstadiaTA dtClienteEstadiaTA;
    }
}