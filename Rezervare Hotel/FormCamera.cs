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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rezervare_Hotel
{
    public partial class FormCamera : Form
    {
        public FormCamera()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Camera' table. You can move, or remove it, as needed.
            this.cameraTableAdapter.Fill(this.dataSet1.Camera);
            popularecombonume();
        }

        private void combonumetipcamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butonsterge_Click(object sender, EventArgs e)
        {

        }

        private void butonR2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string codCamera = selectedRow.Cells["cod"].Value.ToString();
                string delete = $"DELETE FROM Camera WHERE Cod_Camera = {codCamera}";

                Utility.cmd = new OleDbCommand(delete, Utility.con);
                Utility.con.Open();
                Utility.cmd.ExecuteNonQuery();
                Utility.con.Close();
                this.cameraTableAdapter.Fill(this.dataSet1.Camera);

            }
        }

        private void butonmodifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string codCamera = selectedRow.Cells["Cod_Camera"].Value.ToString();
                string nr = textnrcam.Text;
                string etaj = textetajcam.Text;
                string nume = combonume.SelectedItem.ToString();

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

        private void butonR1_Click(object sender, EventArgs e)
        {
            try
            {
                string nrCamera = textnrcam.Text;
                int etajCamera = int.Parse(textetajcam.Text);
                string selectedTipCamera = combonume.SelectedItem.ToString();

                string query1 = $"SELECT Cod_TipCamera FROM TipCamera WHERE Nume_TipCamera = '{selectedTipCamera}'";
                //Utility.cmd = new OleDbCommand(query1, Utility.con);
                Utility.cmd.CommandText = query1;
                Utility.con.Open();
                int codTipCamera = (int)Utility.cmd.ExecuteScalar();
                Utility.con.Close();

                string insert = $"INSERT INTO Camera (Nr_Camera, Cod_TipCamera, Etaj_Camera) " +
                                     $"VALUES ('{nrCamera}', {codTipCamera}, '{etajCamera}')";

                Utility.cmd = new OleDbCommand(insert, Utility.con);
                Utility.con.Open();
                Utility.cmd.ExecuteNonQuery();
                Utility.con.Close();
                this.cameraTableAdapter.Fill(this.dataSet1.Camera);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void popularecombonume()
        {
            Utility.con.Open();
            Utility.cmd = new OleDbCommand();
            string query = "SELECT Nume_TipCamera FROM TipCamera";
            Utility.cmd.CommandText = query;
            Utility.cmd.Connection = Utility.con;
            OleDbDataReader reader = Utility.cmd.ExecuteReader();
            while (reader.Read())
            {
                combonume.Items.Add(reader.GetValue(0));
            }
            reader.Close();
            Utility.con.Close();
        }
    }
}
