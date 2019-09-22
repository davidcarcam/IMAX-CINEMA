namespace EXPO60.Reportes
{
    partial class ReporteProducto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetProveedores = new EXPO60.Reportes.DataSetProveedores();
            this.ProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedoresTableAdapter = new EXPO60.Reportes.DataSetProveedoresTableAdapters.ProveedoresTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(599, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 348);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetProveedores";
            reportDataSource2.Value = this.ProveedoresBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "EXPO60.Reportes.Report4.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(599, 348);
            this.reportViewer2.TabIndex = 0;
            // 
            // DataSetProveedores
            // 
            this.DataSetProveedores.DataSetName = "DataSetProveedores";
            this.DataSetProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProveedoresBindingSource
            // 
            this.ProveedoresBindingSource.DataMember = "Proveedores";
            this.ProveedoresBindingSource.DataSource = this.DataSetProveedores;
            // 
            // ProveedoresTableAdapter
            // 
            this.ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProducto
            // 
            this.ClientSize = new System.Drawing.Size(599, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "ReporteProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteProducto_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private DataSetProducto DataSetProducto;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ProveedoresBindingSource;
        private DataSetProveedores DataSetProveedores;
        private DataSetProveedoresTableAdapters.ProveedoresTableAdapter ProveedoresTableAdapter;

        //*  private DataSetProductoTableAdapters.DataTableTableAdapter DataTableTableAdapter;*//

    }
}