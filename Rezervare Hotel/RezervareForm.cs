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
            //

            string selectednume = combonumeclient.SelectedItem.ToString();
            string nume = selectednume.Split(' ')[0];
            string query1 = $"SELECT Cod_Client FROM Client WHERE Nume_Client = '{nume}'";
            Utility.cmd = new OleDbCommand(query1, Utility.con);
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
            //Utility.con.Close();
            int codcamera = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();

            //
            if (checkoverlap(codcamera, checkindate.Value, checkoutdate.Value))
            {
                MessageBox.Show("Camera selectata este deja rezervata");
                return;
            }
            //

            string query3 = $"INSERT INTO Rezervare(Data_Cazare, Data_Plecare, Cod_Client, Cod_Camera)" +
                $" VALUES ('{checkindate.Value}', '{checkoutdate.Value}', '{codclient}', '{codcamera}')";
            Utility.cmd.CommandText = query3;
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            MessageBox.Show("Rezervarea a fost efectuata cu succes!");

            getrezervari();
        }

        private void RezervareForm_Load(object sender, EventArgs e)
        {
            popularenrcamera();
            popularerezervari();
            popularetipcamera();
            populareclienti();
            getrezervari();
        }
        private bool checkoverlap(int codcamera, DateTime datacazare, DateTime dataplecare)
        {
            //verific daca camera selectata este disponibila pe perioada selectata
            string query = $"SELECT COUNT(*) FROM Rezervare WHERE Cod_Camera = {codcamera} AND " +
                   $"((Data_Cazare <= #{datacazare.ToShortDateString()}# AND Data_Plecare >= #{datacazare.ToShortDateString()}#) " +
                   $"OR (Data_Cazare <= #{dataplecare.ToShortDateString()}# AND Data_Plecare >= #{dataplecare.ToShortDateString()}#) " +
                   $"OR (Data_Cazare >= #{datacazare.ToShortDateString()}# AND Data_Plecare <= #{dataplecare.ToShortDateString()}#))";
            Utility.cmd.CommandText = query;
            Utility.con.Open();
            int count = (int)Utility.cmd.ExecuteScalar();
            Utility.con.Close();
            return count > 0;
        }
        private void overlap()
        {
            Utility.con.Open();
            bool overlaps = false;
            DateTime checkin = checkindate.Value;
            DateTime checkout = checkoutdate.Value;
            string query = "SELECT Data_Cazare, Data_Plecare FROM Rezervare WHERE Camera.Nr_Camera = @nrcamera";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, Utility.con);
            adapter.SelectCommand.Parameters.AddWithValue("@nrcamera", combonrcamera.SelectedValue);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                DateTime existingcheckin = Convert.ToDateTime(dr["Data_Cazare"]);
                DateTime existingcheckout = Convert.ToDateTime(dr["Data_Plecare"]);

                if (checkin < existingcheckout && checkout > existingcheckin)
                {
                    overlaps = true;
                    break;
                }
            }
            if (overlaps)
            {
                MessageBox.Show("Camera selectata este deja rezervata in acea perioada");
            }

        }
        void getrezervari()
        {
            DataTable dt = new DataTable();
            Utility.adapter = new OleDbDataAdapter("SELECT * FROM Rezervare", Utility.con);
            Utility.adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Utility.con.Close();
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
            textcodrezervare.Text = string.Empty;
            textcodclient.Text = string.Empty;
            textcodcamera.Text = string.Empty;
            combonumeclient.Text = string.Empty;
            combonrcamera.Text = string.Empty;
            combotipcamera.Text = string.Empty;
            checkindate.Value = DateTimePicker.MinimumDateTime;
            checkoutdate.Value = DateTimePicker.MaximumDateTime;
        }

        private void combotipcamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            //curat comboboxul cu nr camere
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
        }

        private void combonumeclient_SelectedIndexChanged(object sender, EventArgs e)
        {


            string numecomplet = combonumeclient.SelectedItem.ToString();
            string nume = numecomplet.Split(' ')[0];
            //MessageBox.Show(nume); //testing daca merge




            //textcodclient.Text = codclient.ToString();

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Form f = new Form1();
            f.Show();
        }
    }
}
