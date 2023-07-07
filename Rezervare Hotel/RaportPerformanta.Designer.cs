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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PerformantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.performantaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.performantaTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.PerformantaTableAdapter();
            this.utilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatorTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.UtilizatorTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performantaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PerformantaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rezervare_Hotel.RaportPerformanta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(206, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(778, 761);
            this.reportViewer1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 761);
            this.panel1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 264);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PerformantaBindingSource
            // 
            this.PerformantaBindingSource.DataMember = "Performanta";
            this.PerformantaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // performantaBindingSource1
            // 
            this.performantaBindingSource1.DataMember = "Performanta";
            this.performantaBindingSource1.DataSource = this.dataSet1;
            // 
            // performantaTableAdapter
            // 
            this.performantaTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatorBindingSource
            // 
            this.utilizatorBindingSource.DataMember = "Utilizator";
            this.utilizatorBindingSource.DataSource = this.dataSet1;
            // 
            // utilizatorTableAdapter
            // 
            this.utilizatorTableAdapter.ClearBeforeFill = true;
            // 
            // RaportPerformanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportPerformanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaportPerformanta";
            this.Load += new System.EventHandler(this.RaportPerformanta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerformantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performantaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource performantaBindingSource1;
        private System.Windows.Forms.BindingSource PerformantaBindingSource;
        private DataSet1TableAdapters.PerformantaTableAdapter performantaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource utilizatorBindingSource;
        private DataSet1TableAdapters.UtilizatorTableAdapter utilizatorTableAdapter;
    }
}