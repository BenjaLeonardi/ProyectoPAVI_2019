namespace SistemaHotelPAV.GUI.Reportes
{
    partial class frmReporteUxB
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
            this.dtUsuarioBarrioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuarioBarrio = new SistemaHotelPAV.dsUsuarioBarrio();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtUsuarioBarrioTableAdapter = new SistemaHotelPAV.dsUsuarioBarrioTableAdapters.dtUsuarioBarrioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarioBarrioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarioBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // dtUsuarioBarrioBindingSource
            // 
            this.dtUsuarioBarrioBindingSource.DataMember = "dtUsuarioBarrio";
            this.dtUsuarioBarrioBindingSource.DataSource = this.dsUsuarioBarrio;
            // 
            // dsUsuarioBarrio
            // 
            this.dsUsuarioBarrio.DataSetName = "dsUsuarioBarrio";
            this.dsUsuarioBarrio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsUsuarioBarrio";
            reportDataSource1.Value = this.dtUsuarioBarrioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaHotelPAV.GUI.Reportes.rptUsuarioBarrio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(609, 586);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtUsuarioBarrioTableAdapter
            // 
            this.dtUsuarioBarrioTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteUxB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 610);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteUxB";
            this.Text = "Reporte de Usuarios por Barrios";
            this.Load += new System.EventHandler(this.frmReporteUxB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarioBarrioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarioBarrio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsUsuarioBarrio dsUsuarioBarrio;
        private System.Windows.Forms.BindingSource dtUsuarioBarrioBindingSource;
        private dsUsuarioBarrioTableAdapters.dtUsuarioBarrioTableAdapter dtUsuarioBarrioTableAdapter;
    }
}