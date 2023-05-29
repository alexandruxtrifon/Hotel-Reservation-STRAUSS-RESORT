using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static Rezervare_Hotel.Utility;
using MaterialSkin;
//using MaterialSkin.Controls;
//using MaterialSkin.Animations;
//using MaterialSkin.Properties;


namespace Rezervare_Hotel
{
    public partial class Form1 : Form
    {
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alex\source\repos\Rezervare Hotel\Rezervare Hotel\Baza de date licenta.accdb");
       
        public Form1()
        {
            InitializeComponent();

            //testing
            chart1.Titles.Add("Ponderea Camerelor Rezervate Dupa Tip");
            chart1.Series.Add("s1");
            chart1.Series["s1"].Points.AddXY("Single", "12");
            chart1.Series["s1"].Points.AddXY("Double", "27");
            chart1.Series["s1"].Points.AddXY("Triple", "31");
            chart1.Series["s1"].Points.AddXY("Quad", "30");
            chart1.Series["s1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadgauge();
            //piechart_load();
            // chart1.Series["Tipuri de Camere"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void butonclienti_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
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
            Form2 f = new Form2();
            f.Show();
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
            Form3 f = new Form3();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormRaportUtilizatori f = new FormRaportUtilizatori();
            f.Show();
        }

        private void solidGauge1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
        }

        public void loadgauge()
        {
            Utility.cmd = new OleDbCommand();
            Utility.cmd.Connection = Utility.con;
            string query = "SELECT COUNT (*) FROM Rezervare";
            Utility.cmd.CommandText = query;
            Utility.con.Open();
            countrezervari = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();
            //double countrezervari = (double)Utility.cmd.ExecuteScalar();
            string query1 = $"SELECT COUNT (*) FROM Camera";
            Utility.cmd.CommandText = query1;
            Utility.con.Open();
            double countcamere = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();
            double situatie = countrezervari / countcamere;
            solidGauge1.Value = situatie;
            solidGauge1.To = countrezervari;
        }
        double countrezervari;

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void piechart_load()//(object sender, EventArgs e)
        {
            Utility.cmd = new OleDbCommand();
            Utility.cmd.Connection = Utility.con;

            string query = "SELECT COUNT(*) FROM Rezervare " +
                "INNER JOIN TipCamera  ON Rezervare.Cod_TipCamera = TipCamera.Cod_TipCamera " +
                "WHERE TipCamera.Nume_TipCamera = 'Single'";
            Utility.cmd.CommandText = query;
            Utility.con.Open();
            int countsingle = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            string query1 = "SELECT COUNT(*) FROM Rezervare R " +
                "INNER JOIN TipCamera TC ON R.Cod_TipCamera = TC.Cod_TipCamera " +
                "WHERE TC.Nume_TipCamera = 'Double'";
            Utility.cmd.CommandText = query1;
            Utility.con.Open();
            int countdouble = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            string query2 = "SELECT COUNT(*) FROM Rezervare R " +
                "INNER JOIN TipCamera TC ON R.Cod_TipCamera = TC.Cod_TipCamera " +
                "WHERE TC.Nume_TipCamera = 'Triple'";
            Utility.cmd.CommandText = query2;
            Utility.con.Open();
            int counttriple = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            string query3 = "SELECT COUNT(*) FROM Rezervare R " +
                "INNER JOIN TipCamera TC ON R.Cod_TipCamera = TC.Cod_TipCamera " +
                "WHERE TC.Nume_TipCamera = 'Quad'";
            Utility.cmd.CommandText = query3;
            Utility.con.Open();
            int countquad = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            //double ponderesingle = countrezervari;

            // Retrieve the counts of each room type from the database
            string querycounttipcamera = "SELECT COUNT(*) AS CountTipCamera FROM Rezervare AS R INNER JOIN Camera AS C ON R.FK_CameraId = C.Id INNER JOIN TipCamera AS TC ON C.FK_TipCameraId = TC.Id GROUP BY TC.Nume_TipCamera";
            DataTable tablecontortipcamera = new DataTable();
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, Utility.con))
            {
                adapter.Fill(tablecontortipcamera);
            }

            // converteste tabela contorizata intr-o matrice 
            int[] countertipcamera = tablecontortipcamera.Rows.OfType<DataRow>().Select(row => row.Field<int>("CountTipCamera")).ToArray();

            // Retrieve the room types from the database
            string querytipcamera = "SELECT Nume_TipCamera FROM TipCamera";
            DataTable tabletipcamera = new DataTable();
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(querytipcamera, Utility.con))
            {
                adapter.Fill(tabletipcamera);
            }

            // Convert the room types table to an array of strings
            string[] tipuricamera = tabletipcamera.Rows.OfType<DataRow>().Select(row => row.Field<string>("Nume_TipCamera")).ToArray();

            chart1.Series.Clear();
            chart1.Series.Add("Tipuri de Camere");

            // Set the chart type to a pie chart
            //chart1.Series["RoomTypes"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Add the room types and their counts to the chart series
            for (int i = 0; i < tipuricamera.Length; i++)
            {
                chart1.Series["Tipuri de Camere"].Points.AddXY(tipuricamera[i], countertipcamera[i]);
            }

            // Set the chart title
            chart1.Titles.Clear();
            chart1.Titles.Add("Pondere Tipuri Camere");

            // Refresh the chart to update the display
            chart1.Refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }
    }
}