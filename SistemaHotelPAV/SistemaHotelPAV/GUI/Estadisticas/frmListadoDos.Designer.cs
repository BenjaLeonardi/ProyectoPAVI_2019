﻿namespace SistemaHotelPAV.GUI.Estadisticas
{
    partial class frmListadoDos
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
            this.dsListadoDos = new SistemaHotelPAV.dsListadoDos();
            this.dtListadoDosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtListadoDosTableAdapter = new SistemaHotelPAV.dsListadoDosTableAdapters.dtListadoDosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoDosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsListadoDos";
            reportDataSource1.Value = this.dtListadoDosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaHotelPAV.GUI.Estadisticas.rptListadoDos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsListadoDos
            // 
            this.dsListadoDos.DataSetName = "dsListadoDos";
            this.dsListadoDos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtListadoDosBindingSource
            // 
            this.dtListadoDosBindingSource.DataMember = "dtListadoDos";
            this.dtListadoDosBindingSource.DataSource = this.dsListadoDos;
            // 
            // dtListadoDosTableAdapter
            // 
            this.dtListadoDosTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoDos";
            this.Text = "Estadisticas de Facturas por Usuario";
            this.Load += new System.EventHandler(this.frmListadoDos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoDosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtListadoDosBindingSource;
        private dsListadoDos dsListadoDos;
        private dsListadoDosTableAdapters.dtListadoDosTableAdapter dtListadoDosTableAdapter;
    }
}