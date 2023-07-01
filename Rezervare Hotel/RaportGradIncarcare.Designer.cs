namespace Rezervare_Hotel
{
    partial class RaportGradIncarcare
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
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.contorRezervariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contorRezervariTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.ContorRezervariTableAdapter();
            this.contorCamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contorCamTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.ContorCamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contorRezervariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contorCamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.contorRezervariBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.contorCamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rezervare_Hotel.RaportGradIncarcare.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(298, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(490, 407);
            this.reportViewer1.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(59, 161);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contorRezervariBindingSource
            // 
            this.contorRezervariBindingSource.DataMember = "ContorRezervari";
            this.contorRezervariBindingSource.DataSource = this.dataSet1;
            // 
            // contorRezervariTableAdapter
            // 
            this.contorRezervariTableAdapter.ClearBeforeFill = true;
            // 
            // contorCamBindingSource
            // 
            this.contorCamBindingSource.DataMember = "ContorCam";
            this.contorCamBindingSource.DataSource = this.dataSet1;
            // 
            // contorCamTableAdapter
            // 
            this.contorCamTableAdapter.ClearBeforeFill = true;
            // 
            // RaportGradIncarcare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "RaportGradIncarcare";
            this.Text = "RaportGradIncarcare";
            this.Load += new System.EventHandler(this.RaportGradIncarcare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contorRezervariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contorCamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContorRezBindingSource;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource contorRezervariBindingSource;
        private DataSet1TableAdapters.ContorRezervariTableAdapter contorRezervariTableAdapter;
        private System.Windows.Forms.BindingSource contorCamBindingSource;
        private DataSet1TableAdapters.ContorCamTableAdapter contorCamTableAdapter;
    }
}