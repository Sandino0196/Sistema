namespace Sistema_Empenos_Anderson
{
    partial class Informe_Recibo
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
            this.Data_Recibo = new Sistema_Empenos_Anderson.Data_Recibo();
            this.SP_Informe_Recibo_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_Informe_Recibo_DetalleTableAdapter = new Sistema_Empenos_Anderson.Data_ReciboTableAdapters.SP_Informe_Recibo_DetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Recibo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Informe_Recibo_DetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Informe_Recibo_DetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Empenos_Anderson.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // Data_Recibo
            // 
            this.Data_Recibo.DataSetName = "Data_Recibo";
            this.Data_Recibo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Informe_Recibo_DetalleBindingSource
            // 
            this.SP_Informe_Recibo_DetalleBindingSource.DataMember = "SP_Informe_Recibo_Detalle";
            this.SP_Informe_Recibo_DetalleBindingSource.DataSource = this.Data_Recibo;
            // 
            // SP_Informe_Recibo_DetalleTableAdapter
            // 
            this.SP_Informe_Recibo_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // Informe_Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Informe_Recibo";
            this.Text = "Informe_Recibo";
            this.Load += new System.EventHandler(this.Informe_Recibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Recibo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Informe_Recibo_DetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Informe_Recibo_DetalleBindingSource;
        private Data_Recibo Data_Recibo;
        private Data_ReciboTableAdapters.SP_Informe_Recibo_DetalleTableAdapter SP_Informe_Recibo_DetalleTableAdapter;
    }
}