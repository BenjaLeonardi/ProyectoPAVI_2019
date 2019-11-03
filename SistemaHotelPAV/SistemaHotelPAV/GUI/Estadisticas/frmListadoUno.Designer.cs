namespace SistemaHotelPAV.GUI.Estadisticas
{
    partial class frmListadoUno
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsListadoUno = new SistemaHotelPAV.dsListadoUno();
            this.dtListadoUnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadoUnoTableAdapter = new SistemaHotelPAV.dsListadoUnoTableAdapters.ListadoUnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoUnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsListadoUnorpt";
            reportDataSource1.Value = this.dtListadoUnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaHotelPAV.GUI.Estadisticas.rptListadoUno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(812, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsListadoUno
            // 
            this.dsListadoUno.DataSetName = "dsListadoUno";
            this.dsListadoUno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtListadoUnoBindingSource
            // 
            this.dtListadoUnoBindingSource.DataMember = "dtListadoUno";
            this.dtListadoUnoBindingSource.DataSource = this.dsListadoUno;
            // 
            // listadoUnoTableAdapter
            // 
            this.listadoUnoTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 430);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoUno";
            this.Text = "Estadisticas de Estadias por Usuario";
            this.Load += new System.EventHandler(this.frmListadoUno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoUnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtListadoUnoBindingSource;
        private dsListadoUno dsListadoUno;
        private dsListadoUnoTableAdapters.ListadoUnoTableAdapter listadoUnoTableAdapter;
    }
}