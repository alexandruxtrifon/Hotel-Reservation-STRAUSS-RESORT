using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervare_Hotel
{
    public partial class Form4 : Form
    {
        DataTable dt;
        void GetTipCamera()
        {
            dt = new DataTable();
            Utility.adapter = new OleDbDataAdapter("SELECT * FROM TipCamera", Utility.con);
            Utility.con.Open();
            Utility.adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Utility.con.Close();

        }
        public Form4()
        {
            InitializeComponent();
            GetTipCamera();
        }


        private void butoninsereaza_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TipCamera (Nume_TipCamera,Pret_TipCamera,Capacitate_TipCamera) VALUES" +
    "(@nume,@pret,@capacitate)";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            Utility.cmd.Parameters.AddWithValue("@nume", textnumetipcamera.Text);
            Utility.cmd.Parameters.AddWithValue("@pret", textprettipcamera.Text);
            Utility.cmd.Parameters.AddWithValue("@capacitate", textcapacitatetipcamera.Text);
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            MessageBox.Show("Tipul camerei a fost introdus cu succes.");
            GetTipCamera();
        }

        private void butonactualizeaza_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Client SET Nume_TipCamera=@nume,Pret_TipCamera=@pret,Capacitate_TipCamera=@capacitate" +
    "WHERE Cod_TipCamera=@id";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            Utility.cmd.Parameters.AddWithValue("@nume", textnumetipcamera.Text);
            Utility.cmd.Parameters.AddWithValue("@pret", textprettipcamera.Text);
            Utility.cmd.Parameters.AddWithValue("@email", textcapacitatetipcamera.Text);
            Utility.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textcodtipcamera.Text));
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            MessageBox.Show("Tipul camerei a fost actualizat cu succes.");
            GetTipCamera();
        }

        private void butonsterge_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Client WHERE Cod_TipCamera=@id";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            Utility.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textcodtipcamera.Text));
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            MessageBox.Show("Tipul camerei a fost sters cu succes.");
            GetTipCamera();
        }
    }
}
