using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Collections;
using System.Windows.Media.Media3D;

namespace Rezervare_Hotel
{
    public partial class RezervareForm : Form
    {
        public RezervareForm()
        {
            InitializeComponent();
        }

        private void butoninsereaza_Click(object sender, EventArgs e)
        {
           
        }

        private void RezervareForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Rezervare' table. You can move, or remove it, as needed.
            this.rezervareTableAdapter.Fill(this.dataSet1.Rezervare);
            popularenrcamera();
           // popularerezervari();
            popularetipcamera();
            populareclienti();





        }
        private bool checkoverlap(int codcamera, DateTime datacazare, DateTime dataplecare)
        {
            //verific daca camera selectata este disponibila pe perioada selectata
            string query = $"SELECT COUNT(*) FROM Rezervare WHERE Cod_Camera = {codcamera} AND " +
                   $"((Data_Cazare <= #{datacazare.ToShortDateString()}# AND Data_Plecare >= #{datacazare.ToShortDateString()}#) " +
                   $"OR (Data_Cazare <= #{dataplecare.ToShortDateString()}# AND Data_Plecare >= #{dataplecare.ToShortDateString()}#) " +
                   $"OR (Data_Cazare >= #{datacazare.ToShortDateString()}# AND Data_Plecare <= #{dataplecare.ToShortDateString()}#))";

            //string query1 = $"SELECT COUNT(*) FROM Rezervare WHERE Cod_Camera = {codcamera} AND " +
            //        $"((Data_Cazare >= #{datacazare.ToShortDateString()}# AND Data_Plecare >= {dataplecare.ToShortDateString()}#) " +
            //        $"OR (Data_Cazare <= #{datacazare.ToShortDateString()}# AND Data_Plecare <= {dataplecare.ToShortDateString()}#) " +
            //        $" OR (Data_Cazare <= #{dataplecare.ToShortDateString()}# AND Data_Plecare >= #{dataplecare.ToShortDateString()}#) " +
            //        $"";
            string query2 = $"SELECT COUNT(*) FROM REZERVARE WHERE Cod_Camera = {codcamera} AND " +
                $"((#{datacazare.ToShortDateString()}# >= Data_Cazare AND #{datacazare.ToShortDateString()}# < Data_Plecare) " +
                $"OR (#{datacazare.ToShortDateString()}# < Data_Cazare AND #{dataplecare.ToShortDateString()}# > Data_Cazare))";

            Utility.cmd.CommandText = query;
            Utility.con.Open();
            int count = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();
            return count > 0;
        }

        private void checkdate(DateTime checkindate, DateTime checkoutdate)
        {
            if (checkindate == checkoutdate)
            {
                MessageBox.Show("Rezervarea nu poate sa fie mai scurta decat o zi");
                return;
            }
            this.rezervareTableAdapter.Fill(this.dataSet1.Rezervare);
        }

        public void popularenrcamera()
        {
            try
            {
                Utility.con.Open();
                string query = "SELECT Nr_Camera from Camera";
                Utility.cmd = new OleDbCommand(query, Utility.con);
                Utility.cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(Utility.cmd);
                da.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    combonrcamera.Items.Add(dr["Nr_Camera"].ToString());
                }
                Utility.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void popularetipcamera()
        {
            Utility.con.Open();
            string query = "SELECT DISTINCT Nume_TipCamera from TipCamera";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, Utility.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                combotipcamera.Items.Add(dr["Nume_TipCamera"].ToString());
            }
            Utility.con.Close();
        }
        public void popularerezervari()
        {
            Utility.con.Open();
            string query = "SELECT * FROM Rezervare";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Utility.cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Utility.con.Close();
        }
        public void populareclienti()
        {
            Utility.con.Open();
            string query = "SELECT Nume_Client + ' ' + Prenume_Client AS ClientName FROM Client";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, Utility.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                combonumeclient.Items.Add(dr["ClientName"].ToString());
            }
            Utility.con.Close();
        }
        public void clear()
        {
            combonumeclient.Text = string.Empty;
            combonrcamera.Text = string.Empty;
            combotipcamera.Text = string.Empty;
            checkindate.Value = DateTimePicker.MinimumDateTime;
            checkoutdate.Value = DateTimePicker.MaximumDateTime;
        }

        private void combonumeclient_SelectedIndexChanged(object sender, EventArgs e)
        {


            string numecomplet = combonumeclient.SelectedItem.ToString();
            string nume = numecomplet.Split(' ')[0];
            //MessageBox.Show(nume); //testing daca merge
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Form f = new Form1();
            f.Show();
        }

        private void combotipcamera_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void butoninsereaza_Click_1(object sender, EventArgs e)
        {

        }

        private void butonactualizeaza_Click(object sender, EventArgs e)
        {

        }

        private void butonR1_Click(object sender, EventArgs e)
        {
            //

            string selectednume = combonumeclient.SelectedItem.ToString();
            string nume = selectednume.Split(' ')[0];
            string query1 = $"SELECT Cod_Client FROM Client WHERE Nume_Client = '{nume}'";
            //Utility.cmd = new OleDbCommand(query1, Utility.con);
            Utility.cmd.CommandText = query1;
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            int codclient = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            string selectedcamera = combonrcamera.SelectedItem.ToString();
            string query2 = $"SELECT Cod_Camera FROM Camera WHERE Nr_Camera = '{selectedcamera}'";
            Utility.cmd.CommandText = query2;
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            int codcamera = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();




            //
            if (checkoverlap(codcamera, checkindate.Value, checkoutdate.Value))
            {
                MessageBox.Show("Camera selectata este deja rezervata");
                return;
            }
            //
            checkdate(checkindate.Value, checkoutdate.Value);

            string query3 = $"INSERT INTO Rezervare(Data_Cazare, Data_Plecare, Cod_Client, Cod_Camera, Cod_Utilizator)" +
                $" VALUES ('{checkindate.Value}', '{checkoutdate.Value}', " +
                $"'{codclient}', '{codcamera}', '{Utility.codutilizator}')";
            Utility.cmd.CommandText = query3;
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            MessageBox.Show("Rezervarea a fost efectuata cu succes!");


            // Retrieve fk codrezervare
            string query4 = "SELECT MAX(Cod_Rezervare) FROM Rezervare";
            Utility.cmd.CommandText = query4;
            Utility.con.Open();
            int codRezervare = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            string query5 = $"SELECT Cod_Client FROM Client WHERE Nume_Client = '{nume}'";
            Utility.cmd.CommandText = query5;
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            int codClient = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();


            string query11 = "SELECT MAX(Data_Cazare) FROM Rezervare";
            Utility.cmd.CommandText = query11;
            Utility.con.Open();
            DateTime datacazare = (DateTime)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            string query12 = "SELECT MAX(Data_Plecare) FROM Rezervare";
            Utility.cmd.CommandText = query12;
            Utility.con.Open();
            DateTime dataplecare = (DateTime)Utility.cmd.ExecuteScalar();
            Utility.con.Close();


            // calculare nr zile si total de plata
            int pretTipCamera = int.Parse(textpretcamera.Text);
            int nrzile = (int)(dataplecare - datacazare).TotalDays;
            int totalplata = nrzile * pretTipCamera;

            this.rezervareTableAdapter.Fill(this.dataSet1.Rezervare);
            this.dataGridView1.Refresh();
        }

        private void butonsterge_Click(object sender, EventArgs e)
        {

        }

        private void combotipcamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            combonrcamera.Items.Clear();

            string camptipcamera = combotipcamera.Text;

            string query = "SELECT Camera.Nr_Camera FROM Camera INNER JOIN TipCamera ON Camera.Cod_TipCamera = TipCamera.Cod_TipCamera WHERE TipCamera.Nume_TipCamera = @roomType";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, Utility.con);
            adapter.SelectCommand.Parameters.AddWithValue("@roomType", camptipcamera);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            //adaug camerele in combobox nr camere
            foreach (DataRow dr in dt.Rows)
            {
                combonrcamera.Items.Add(dr["Nr_Camera"].ToString());
            }

            //actualizare preturi
            combotipcamera.SelectedIndexChanged += combotipcamera_SelectedIndexChanged;
            //string camptipcamera = combotipcamera.Text;
            string selectedTipCamera = combotipcamera.SelectedItem.ToString();
            string query1 = $"SELECT Pret_TipCamera FROM TipCamera WHERE Nume_TipCamera = '{camptipcamera}'";
            Utility.cmd = new OleDbCommand(query1, Utility.con);
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            double pretTipCamera = (double)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            textpretcamera.Text = pretTipCamera.ToString();


        }
    }
}
