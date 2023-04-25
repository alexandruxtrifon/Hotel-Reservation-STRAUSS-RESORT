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
            if (combonumeclient.SelectedIndex == -1 
                || combotipcamera.SelectedIndex == -1 
                || combonrcamera.SelectedIndex == -1)
                if(checkindate.Value == DateTimePicker.MinimumDateTime 
                    || checkoutdate.Value == DateTimePicker.MinimumDateTime)
                //|| checkindate.Value = DateTimePicker.MinimumDateTime || checkoutdate.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Selecteaza toate campurile", "Mai incearca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Utility.con.Open();
                    string query = "INSERT INTO Rezervare (Cod_Rezervare,Data_Cazare,Data_Plecare,Cod_Client,Cod_Camera" +
                            " VALUES('"+textcodrezervare.Text+"',@checkindate,@checkoutdate,'"+textcodclient.Text+"','"+textcodcamera.Text+"')";
                    Utility.cmd.Parameters.AddWithValue("@checkindate",checkindate.Value);
                    Utility.cmd.Parameters.AddWithValue("@checkoutdate", checkoutdate.Value);
                    Utility.cmd = new OleDbCommand(query, Utility.con);
                    string query2 = "SELECT Max(Cod_Rezervare) FROM Rezervare";
                    OleDbCommand cmd2 = new OleDbCommand(query2, Utility.con);
                        Utility.cmd.ExecuteNonQuery();
                    OleDbDataReader reader = cmd2.ExecuteReader();
                    if(reader.Read())
                        {
                            popularerezervari();
                            MessageBox.Show("Rezervare efectuata", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Rezervare esuata", "Mai incearca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Utility.con.Close();

                }
                    catch(Exception)
                    {
                        MessageBox.Show("Codul Client este deja folosit", "Mai incearca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void RezervareForm_Load(object sender, EventArgs e)
        {
            popularenrcamera();
            popularerezervari();
            popularetipcamera();
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
        }
        public void popularerezervari()
        {
            Utility.con.Open();
            string query = "SELECT * FROM Rezervare";
            Utility.cmd = new OleDbCommand(query,Utility.con);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter (Utility.cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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


            // Convert the selected value from the room type combo box to an integer
            int codTipCamera = Convert.ToInt32(combotipcamera.SelectedValue);

            //populez combo nrcamere in functie de tipul de camera selectat
            string query = "SELECT Nr_Camera, Cod_Camera FROM Camera INNER JOIN TipCamera ON Camera.Cod_TipCamera = TipCamera.CodTipCamera";
            string query2 = "SELECT Nr_Camera, Cod_Camera FROM Camera INNER JOIN TipCamera ON Camera.Cod_TipCamera = TipCamera.CodTipCamera WHERE '" + combotipcamera.Text + "' = TipCamera.Nume_TipCamera";
            Utility.cmd = new OleDbCommand(query2, Utility.con);
            Utility.cmd.Parameters.AddWithValue(query2, Utility.con);            
            //OleDbDataAdapter adapter = new OleDbDataAdapter(query2, Utility.con);
            //adapter.SelectCommand.Parameters.AddWithValue("TipCamera.CodTipCamera", combotipcamera.SelectedValue);
            DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //Utility.cmd.Parameters.AddWithValue("@codtipcamera", combotipcamera.SelectedValue);

            foreach (DataRow dr in dt.Rows)
            {
                combonrcamera.Items.Add(dr["Nr_Camera"].ToString());
            }
        }
    }
}
