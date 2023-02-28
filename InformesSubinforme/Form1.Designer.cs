namespace InformesSubinforme
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMaestroDetalle = new InformesSubinforme.DataSetMaestroDetalle();
            this.cochesVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cochesVendidosTableAdapter = new InformesSubinforme.DataSetMaestroDetalleTableAdapters.CochesVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestroDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cochesVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cochesVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InformesSubinforme.ReportEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1043, 389);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetMaestroDetalle
            // 
            this.dataSetMaestroDetalle.DataSetName = "DataSetMaestroDetalle";
            this.dataSetMaestroDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cochesVendidosBindingSource
            // 
            this.cochesVendidosBindingSource.DataMember = "CochesVendidos";
            this.cochesVendidosBindingSource.DataSource = this.dataSetMaestroDetalle;
            // 
            // cochesVendidosTableAdapter
            // 
            this.cochesVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestroDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cochesVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetMaestroDetalle dataSetMaestroDetalle;
        private System.Windows.Forms.BindingSource cochesVendidosBindingSource;
        private DataSetMaestroDetalleTableAdapters.CochesVendidosTableAdapter cochesVendidosTableAdapter;
    }
}

