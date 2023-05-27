namespace Rezervare_Hotel
{
    partial class Form6
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
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.TipCameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipCameraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipCameraTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.TipCameraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipCameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipCameraBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tipCameraBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rezervare_Hotel.RaportTipCamera.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(682, 1055);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TipCameraBindingSource
            // 
            this.TipCameraBindingSource.DataMember = "TipCamera";
            this.TipCameraBindingSource.DataSource = this.dataSet1;
            // 
            // tipCameraBindingSource1
            // 
            this.tipCameraBindingSource1.DataMember = "TipCamera";
            this.tipCameraBindingSource1.DataSource = this.dataSet1;
            // 
            // tipCameraTableAdapter
            // 
            this.tipCameraTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 1055);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipCameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipCameraBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource TipCameraBindingSource;
        private System.Windows.Forms.BindingSource tipCameraBindingSource1;
        private DataSet1TableAdapters.TipCameraTableAdapter tipCameraTableAdapter;
    }
}