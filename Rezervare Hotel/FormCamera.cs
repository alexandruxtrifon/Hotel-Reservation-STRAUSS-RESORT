using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rezervare_Hotel
{
    public partial class FormCamera : Form
    {
        DataTable dt;
        
        void GetCamera()
        {
            dt = new DataTable();
            Utility.adapter = new OleDbDataAdapter("SELECT * FROM Camera", Utility.con);
            Utility.con.Open();
            Utility.adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Utility.con.Close();

        }
        public FormCamera()
        {
            InitializeComponent();


        }

        private void butontipcamera_Click(object sender, EventArgs e)
        {
            TipCameraForm f4 = new TipCameraForm();
            f4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Camera' table. You can move, or remove it, as needed.
            this.cameraTableAdapter.Fill(this.dataSet1.Camera);
        }

        private void butoninsereaza_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Camera (Nr_Camera,Etaj_Camera) VALUES" +
                "(@nr,@etaj)";
                Utility.cmd = new OleDbCommand(query, Utility.con);
                Utility.cmd.Parameters.AddWithValue("@nr", textnrcamera.Text);
                //Utility.cmd.Parameters.AddWithValue("@codtip", textprenume.Text);
                Utility.cmd.Parameters.AddWithValue("@etaj", textetajcamera.Text);
                Utility.con.Open();
                Utility.cmd.ExecuteNonQuery();
                Utility.con.Close();
                MessageBox.Show("Camera a fost introdusa cu succes.");
                GetCamera();


                // Retrieve the selected item from the combo box
                string selectedTipCamera = combonume.SelectedItem.ToString();

                // Query the 'TipCamera' table to retrieve the corresponding 'Cod_TipCamera' value
                string query1 = $"SELECT Cod_TipCamera FROM TipCamera WHERE Nume_TipCamera = '{selectedTipCamera}'";
                Utility.cmd.CommandText = query1;
                Utility.con.Open();
                int codTipCamera = (int)Utility.cmd.ExecuteScalar();
                Utility.con.Close();

                // Insert a new record into the 'Camera' table
                string query2 = $"INSERT INTO Camera(Nr_Camera, Cod_TipCamera, Etaj_Camera) VALUES ('{textnrcamera.Text}',{codTipCamera},'{textetajcamera.Text}')";
                Utility.cmd.CommandText = query2;
                Utility.con.Open();
                Utility.cmd.ExecuteNonQuery();
                Utility.con.Close();

                MessageBox.Show("Camera a fost introdusa cu succes.");
                GetCamera();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utility.con.Close();
            }
        }

        private void combonumetipcamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butonR1_Click(object sender, EventArgs e)
        {
                string nr = textnrcam.Text;
                string etaj = textetajcam.Text;
                string nume = combonume.SelectedItem.ToString();

                string insert = $"INSERT INTO Camera (Nr_Camera, Etaj_Camera, Cod_TipCamera) " +
                                     $"SELECT '{nr}', '{etaj}', TipCamera.Cod_TipCamera " +
                                     $"FROM TipCamera WHERE Nume_TipCamera = '{nume}'";


            Utility.cmd = new OleDbCommand(insert, Utility.con);
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            this.dataGridView1.Update();
            this.dataGridView1.Refresh();
        }

        private void butonmodifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string codCamera = selectedRow.Cells["Cod_Camera"].Value.ToString();
                string nr = textnrcam.Text;
                string etaj = textetajcam.Text;
                string nume = combonume.Text;

                string update = $"UPDATE Camera " +
                                 $"SET Nr_Camera = '{nr}', Etaj_Camera = '{etaj}', " +
                                 $"Cod_TipCamera = (SELECT Cod_TipCamera FROM TipCamera WHERE Nume_TipCamera = '{nume}') " +
                                 $"WHERE Cod_Camera = {codCamera}";

                Utility.cmd = new OleDbCommand(update, Utility.con);
                Utility.con.Open();
                Utility.cmd.ExecuteNonQuery();
                Utility.con.Close();
                this.dataGridView1.Update();
                this.dataGridView1.Refresh();
            }
        }

        private void butonsterge_Click(object sender, EventArgs e)
        {

        }

        private void butonR2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the codCamera of the selected row
                string codCamera = selectedRow.Cells["Cod_Camera"].Value.ToString();

                // Delete query
                string delete = $"DELETE FROM Camera WHERE Cod_Camera = {codCamera}";

                Utility.cmd = new OleDbCommand(delete, Utility.con);
                Utility.con.Open();
                Utility.cmd.ExecuteNonQuery();
                Utility.con.Close();
                this.dataGridView1.Update();
                this.dataGridView1.Refresh();
            }
        }
    }
}
