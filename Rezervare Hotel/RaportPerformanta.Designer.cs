namespace Rezervare_Hotel
{
    partial class RaportPerformanta
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
            this.performantaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PerformantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performantaTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.PerformantaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.performantaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformantaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // performantaBindingSource1
            // 
            this.performantaBindingSource1.DataMember = "Performanta";
            this.performantaBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PerformantaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rezervare_Hotel.RaportPerformanta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 761);
            this.reportViewer1.TabIndex = 6;
            // 
            // PerformantaBindingSource
            // 
            this.PerformantaBindingSource.DataMember = "Performanta";
            this.PerformantaBindingSource.DataSource = this.dataSet1;
            // 
            // performantaTableAdapter
            // 
            this.performantaTableAdapter.ClearBeforeFill = true;
            // 
            // RaportPerformanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportPerformanta";
            this.Text = "RaportPerformanta";
            this.Load += new System.EventHandler(this.RaportPerformanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performantaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformantaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource performantaBindingSource1;
        private System.Windows.Forms.BindingSource PerformantaBindingSource;
        private DataSet1TableAdapters.PerformantaTableAdapter performantaTableAdapter;
    }
}