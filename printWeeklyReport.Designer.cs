namespace Invoice
{
    partial class printWeeklyReport
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
            this.weeklyExpenseDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Invoice.DataSet1();
            this.reportAction1 = new Microsoft.AnalysisServices.ReportAction();
            this.weeklyReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.weeklyExpenseDataTableTableAdapter = new Invoice.DataSet1TableAdapters.weeklyExpenseDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyExpenseDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyExpenseDataTableBindingSource
            // 
            this.weeklyExpenseDataTableBindingSource.DataMember = "weeklyExpenseDataTable";
            this.weeklyExpenseDataTableBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportAction1
            // 
            this.reportAction1.Application = null;
            this.reportAction1.Description = null;
            this.reportAction1.Name = null;
            this.reportAction1.OwningCollection = null;
            this.reportAction1.Path = null;
            this.reportAction1.ReportServer = null;
            // 
            // weeklyReportViewer
            // 
            this.weeklyReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weeklyReportViewer.LocalReport.ReportEmbeddedResource = "Invoice.weeklyReport.rdlc";
            this.weeklyReportViewer.Location = new System.Drawing.Point(0, 0);
            this.weeklyReportViewer.Name = "weeklyReportViewer";
            this.weeklyReportViewer.ServerReport.BearerToken = null;
            this.weeklyReportViewer.Size = new System.Drawing.Size(813, 463);
            this.weeklyReportViewer.TabIndex = 0;
            // 
            // weeklyExpenseDataTableTableAdapter
            // 
            this.weeklyExpenseDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // printWeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 463);
            this.Controls.Add(this.weeklyReportViewer);
            this.Name = "printWeeklyReport";
            this.Text = "printWeeklyReport";
            this.Load += new System.EventHandler(this.printWeeklyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyExpenseDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.AnalysisServices.ReportAction reportAction1;
        private Microsoft.Reporting.WinForms.ReportViewer weeklyReportViewer;
        private System.Windows.Forms.BindingSource weeklyExpenseDataTableBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.weeklyExpenseDataTableTableAdapter weeklyExpenseDataTableTableAdapter;
    }
}