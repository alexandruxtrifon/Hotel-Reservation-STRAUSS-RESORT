namespace Rezervare_Hotel
{
    partial class RaportCamera
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tipCameraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TipCameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipCameraTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.TipCameraTableAdapter();
            this.nrCamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nr_CamTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.Nr_CamTableAdapter();
            this.Nr_CamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipCameraBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.numeUtilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeUtilizatorTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.NumeUtilizatorTableAdapter();
            this.nrCamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tipCameraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipCameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrCamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nr_CamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipCameraBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeUtilizatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrCamBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipCameraBindingSource1
            // 
            this.tipCameraBindingSource1.DataMember = "TipCamera";
            this.tipCameraBindingSource1.DataSource = this.dataSet1;
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
            reportDataSource1.Value = this.TipCameraBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Nr_CamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rezervare_Hotel.RaportCamera.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 761);
            this.reportViewer1.TabIndex = 0;
            // 
            // TipCameraBindingSource
            // 
            this.TipCameraBindingSource.DataMember = "TipCamera";
            this.TipCameraBindingSource.DataSource = this.dataSet1;
            // 
            // tipCameraTableAdapter
            // 
            this.tipCameraTableAdapter.ClearBeforeFill = true;
            // 
            // nrCamBindingSource
            // 
            this.nrCamBindingSource.DataMember = "Nr Cam";
            this.nrCamBindingSource.DataSource = this.dataSet1;
            // 
            // nr_CamTableAdapter
            // 
            this.nr_CamTableAdapter.ClearBeforeFill = true;
            // 
            // Nr_CamBindingSource
            // 
            this.Nr_CamBindingSource.DataMember = "Nr Cam";
            this.Nr_CamBindingSource.DataSource = this.dataSet1;
            // 
            // tipCameraBindingSource2
            // 
            this.tipCameraBindingSource2.DataMember = "TipCamera";
            this.tipCameraBindingSource2.DataSource = this.dataSet1;
            // 
            // numeUtilizatorBindingSource
            // 
            this.numeUtilizatorBindingSource.DataMember = "NumeUtilizator";
            this.numeUtilizatorBindingSource.DataSource = this.dataSet1;
            // 
            // numeUtilizatorTableAdapter
            // 
            this.numeUtilizatorTableAdapter.ClearBeforeFill = true;
            // 
            // nrCamBindingSource1
            // 
            this.nrCamBindingSource1.DataMember = "Nr Cam";
            this.nrCamBindingSource1.DataSource = this.dataSet1;
            // 
            // RaportCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RaportCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport Camera";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipCameraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipCameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrCamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nr_CamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipCameraBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeUtilizatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrCamBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource TipCameraBindingSource;
        private System.Windows.Forms.BindingSource tipCameraBindingSource1;
        private DataSet1TableAdapters.TipCameraTableAdapter tipCameraTableAdapter;
        private System.Windows.Forms.BindingSource nrCamBindingSource;
        private DataSet1TableAdapters.Nr_CamTableAdapter nr_CamTableAdapter;
        private System.Windows.Forms.BindingSource Nr_CamBindingSource;
        private System.Windows.Forms.BindingSource tipCameraBindingSource2;
        private System.Windows.Forms.BindingSource numeUtilizatorBindingSource;
        private DataSet1TableAdapters.NumeUtilizatorTableAdapter numeUtilizatorTableAdapter;
        private System.Windows.Forms.BindingSource nrCamBindingSource1;
    }
}