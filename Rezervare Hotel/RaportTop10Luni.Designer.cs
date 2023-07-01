namespace Rezervare_Hotel
{
    partial class RaportTop10Luni
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
            this.top10LuniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Rezervare_Hotel.DataSet1();
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.top10LuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.top10LuniTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.Top10LuniTableAdapter();
            this.dataSet12 = new Rezervare_Hotel.DataSet1();
            this.top10LuniBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.top10LuniBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10LuniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10LuniBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.top10LuniBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rezervare_Hotel.RaportTop10Luni.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 845);
            this.reportViewer1.TabIndex = 1;
            // 
            // top10LuniBindingSource1
            // 
            this.top10LuniBindingSource1.DataMember = "Top10Luni";
            this.top10LuniBindingSource1.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // top10LuniBindingSource
            // 
            this.top10LuniBindingSource.DataMember = "Top10Luni";
            this.top10LuniBindingSource.DataSource = this.dataSet1;
            // 
            // top10LuniTableAdapter
            // 
            this.top10LuniTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // top10LuniBindingSource2
            // 
            this.top10LuniBindingSource2.DataMember = "Top10Luni";
            this.top10LuniBindingSource2.DataSource = this.dataSet12;
            // 
            // RaportTop10Luni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 845);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportTop10Luni";
            this.Text = "RaportTop10Luni";
            this.Load += new System.EventHandler(this.RaportTop10Luni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.top10LuniBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10LuniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10LuniBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource top10LuniBindingSource;
        private DataSet1TableAdapters.Top10LuniTableAdapter top10LuniTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource top10LuniBindingSource1;
        private DataSet1 dataSet12;
        private System.Windows.Forms.BindingSource top10LuniBindingSource2;
    }
}