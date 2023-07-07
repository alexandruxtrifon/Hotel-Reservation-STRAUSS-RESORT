using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Rezervare_Hotel.Utility;



namespace Rezervare_Hotel
{
    public partial class Form1 : Form
    {
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alex\source\repos\Rezervare Hotel\Rezervare Hotel\Baza de date licenta.accdb");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = $"Bine ai venit, {Utility.contnume}";
            menuStrip1.BackColor = Color.White; // din nou exista un bug cu selectarea culorii
            menuStrip1.Renderer = new CustomMenuStripRenderer();
            menuStrip2.BackColor = Color.White;
            menuStrip2.Renderer = new CustomMenuStripRenderer();

            PopulateChart2();
            CustomizeChartAppearance();
            isadmin();
        }

        private void PopulateChart2()
        {
            chart2.Series.Clear();
            Series series = new Series("Gradul de Incarcare");
            series.ChartType = SeriesChartType.Line;

            // Retrieve the occupancy rate data for the past seven days
            for (int i = 6; i >= 0; i--)
            {
                DateTime currentDate = DateTime.Today.AddDays(-i);
                double occupancyRate = CalculateOccupancyRate(currentDate);

                // Add data point to the series
                series.Points.AddXY(currentDate.ToShortDateString(), occupancyRate);
            }

            // Add the series to the chart
            chart2.Series.Add(series);

            // Set chart labels and titles
            chart2.ChartAreas[0].AxisX.Title = "Data";
            chart2.ChartAreas[0].AxisY.Title = "Procent";
            chart2.ChartAreas[0].AxisY.LabelStyle.Angle = 0;
            chart2.Titles.Clear();
            chart2.Titles.Add("Gradul de incarcare");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            FormCamera f = new FormCamera();
            f.Show();
        }

        private void butonclienti_Click(object sender, EventArgs e)
        {
            ClientiForm f = new ClientiForm();
            f.Show();
        }

        private void butoncheckin_Click(object sender, EventArgs e)
        {

        }

        private void butonrezervari_Click(object sender, EventArgs e)
        {
            RezervareForm f = new RezervareForm();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //Form6 f = new Form6();
           // f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            RezervareForm f = new RezervareForm();
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormRaportUtilizatori f = new FormRaportUtilizatori();
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            //f.Hide();
            //this.Hide();
            f.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FormCamera f = new FormCamera();
            f.Show();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientiForm f = new ClientiForm();
            f.Show();
        }

        private void rezervariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezervareForm f = new RezervareForm();
            f.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactura f = new FormFactura();
            f.Show();
        }

        private void raportUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaportUtilizatori f = new FormRaportUtilizatori();
            f.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void formuarPrelucrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularPrelucrare f = new FormularPrelucrare();
            f.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void raportTipuriCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void situatiaCamerelorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void camereOcupateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaportCamereOcupate f = new FormRaportCamereOcupate();
            f.Show();
        }

        private void administrareConturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show();
        }

        private double CalculateOccupancyRate(DateTime date)
        {
            string query = "SELECT COUNT(*) FROM Rezervare WHERE Data_Cazare <= @date AND Data_Plecare > @date";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            Utility.cmd.Parameters.AddWithValue("@date", date);
            Utility.con.Open();
            int countReservations = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();
            double occupancyRate = (countReservations / (double)TotalRooms()) * 100.0;
            return occupancyRate;
        }

        private int TotalRooms()
        {
            string query = "SELECT COUNT(*) FROM Camera";
            Utility.cmd = new OleDbCommand(query, Utility.con);

            Utility.con.Open();
            int totalRooms = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            return totalRooms;
        }

        private void CustomizeChartAppearance()
        {
            chart2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
            chart2.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
            chart2.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10f, FontStyle.Bold);
            chart2.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10f, FontStyle.Bold);
            chart2.Series[0].BorderWidth = 5;
            chart2.Refresh();
        }

        private void fisaclientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportFisaClient f = new RaportFisaClient();
            f.Show();
        }

        private void gradulDeIncarcareToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void incasareCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportIncasariCamera f = new RaportIncasariCamera();
            f.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            RaportTop10Luni f = new RaportTop10Luni();
            f.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void isadmin()
        {
            if (label3.Text == $"Bine ai venit, STRAUSS RESORT")
                toolStripMenuItem7.Visible = true;
            else
                return;
        }

        private void raportPerformantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportPerformanta f = new RaportPerformanta();
            f.Show();
        }

        private void raportCamereToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void venituriCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportVenituri f = new RaportVenituri();
            f.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Application.OpenForms["LoginForm"] != null)
            {
                Application.OpenForms["LoginForm"].Close();
            }
        }

        private void top5ReceptioneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportTop5Receptioneri f = new RaportTop5Receptioneri();
            f.Show();
        }

        private void camereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportCamera f = new RaportCamera();
            f.Show();
        }

        private void categoriiCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipCameraForm f = new TipCameraForm();
            f.Show();
        }

        private void raportUtilizatoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRaportUtilizatori f = new FormRaportUtilizatori();
            f.Show();
        }
    }
}