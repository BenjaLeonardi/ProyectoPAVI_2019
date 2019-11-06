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
            this.dtArticulosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListadoArticulosVendidos = new SistemaHotelPAV.dsListadoArticulosVendidos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtaArticulosVendidos = new SistemaHotelPAV.dsListadoArticulosVendidosTableAdapters.dtaArticulosVendidos();
            this.dataSet1 = new SistemaHotelPAV.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsArticulosVendidosFacultad = new SistemaHotelPAV.dsArticulosVendidosFacultad();
            this.dtFacultadVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtaFacultadVendidos = new SistemaHotelPAV.dsArticulosVendidosFacultadTableAdapters.dtaFacultadVendidos();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoArticulosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArticulosVendidosFacultad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacultadVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtArticulosVendidosBindingSource
            // 
            this.dtArticulosVendidosBindingSource.DataMember = "dtArticulosVendidos";
            this.dtArticulosVendidosBindingSource.DataSource = this.dsListadoArticulosVendidos;
            // 
            // dsListadoArticulosVendidos
            // 
            this.dsListadoArticulosVendidos.DataSetName = "dsListadoArticulosVendidos";
            this.dsListadoArticulosVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dtArtVendidos";
            reportDataSource1.Value = this.dtFacultadVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaHotelPAV.GUI.Estadisticas.rptFacultadVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtaArticulosVendidos
            // 
            this.dtaArticulosVendidos.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dsArticulosVendidosFacultad
            // 
            this.dsArticulosVendidosFacultad.DataSetName = "dsArticulosVendidosFacultad";
            this.dsArticulosVendidosFacultad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtFacultadVendidosBindingSource
            // 
            this.dtFacultadVendidosBindingSource.DataMember = "dtFacultadVendidos";
            this.dtFacultadVendidosBindingSource.DataSource = this.dsArticulosVendidosFacultad;
            // 
            // dtaFacultadVendidos
            // 
            this.dtaFacultadVendidos.ClearBeforeFill = true;
            // 
            // frmListadoArticulosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoArticulosMasVendidos";
            this.Text = "frmListadoArticulosMasVendidos";
            this.Load += new System.EventHandler(this.frmListadoArticulosMasVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoArticulosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArticulosVendidosFacultad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacultadVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtArticulosVendidosBindingSource;
        private dsListadoArticulosVendidos dsListadoArticulosVendidos;
        private dsListadoArticulosVendidosTableAdapters.dtaArticulosVendidos dtaArticulosVendidos;
        private System.Windows.Forms.BindingSource dtFacultadVendidosBindingSource;
        private dsArticulosVendidosFacultad dsArticulosVendidosFacultad;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private dsArticulosVendidosFacultadTableAdapters.dtaFacultadVendidos dtaFacultadVendidos;
    }
}