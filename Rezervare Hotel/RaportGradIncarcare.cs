using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervare_Hotel
{
    public partial class RaportGradIncarcare : Form
    {
        public RaportGradIncarcare()
        {
            InitializeComponent();
        }

        private void RaportGradIncarcare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ContorCam' table. You can move, or remove it, as needed.
            this.contorCamTableAdapter.Fill(this.dataSet1.ContorCam);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the date range for the past 7 days
          //  DateTime endDate = DateTime.Today;
           // DateTime startDate = endDate.AddDays(-6); // Subtract 6 days from the end date

            // Set the report file path
            //reportViewer1.LocalReport.ReportPath = "C:\\Users\\Alex\\source\\repos\\Rezervare Hotel\\Rezervare Hotel\\RaportGradIncarcare.rdlc";

            // Set the parameter value for the past 7 days
            //ReportParameter dateParameter = new ReportParameter("@data", startDate.ToString("dd-MM-yyyy"));

           // reportViewer1.LocalReport.SetParameters(dateParameter);
           // this.contorRezervariTableAdapter.Fill(this.dataSet1, );
            // Refresh the report viewer to display the updated report
            //reportViewer1.RefreshReport();




            List<DateTime> pastSevenDays = GetPastSevenDays();

            // Clear the existing report data
            this.reportViewer1.Clear();
            DataTable mergedTable = this.dataSet1.ContorRezervari.Clone();


            // Iterate through the past seven days
            foreach (DateTime pastDate in pastSevenDays)
            {
                // Set the date parameter for the report
                ReportParameter dateParameter = new ReportParameter("DateParameter", pastDate.ToString("dd-MM-yyyy"));
                //this.reportViewer1.LocalReport.SetParameters(dateParameter);
                DataTable dateTable = new DataTable();
                this.contorRezervariTableAdapter.Fill(this.dataSet1.ContorRezervari, pastDate);
                // Refresh the report viewer to load the new data
                mergedTable.Merge(dateTable);
            }
            this.dataSet1.ContorRezervari.Merge(mergedTable);
            this.reportViewer1.RefreshReport();

        }
        private List<DateTime> GetPastSevenDays()
        {
            List<DateTime> pastSevenDays = new List<DateTime>();
            DateTime currentDate = DateTime.Today;

            for (int i = 0; i < 7; i++)
            {
                DateTime pastDate = currentDate.AddDays(-i);
                pastSevenDays.Add(pastDate);
            }

            return pastSevenDays;
        }
    }
}
