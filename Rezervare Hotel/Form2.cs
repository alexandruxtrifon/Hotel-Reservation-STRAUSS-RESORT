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
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();
            GetCamera();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butontipcamera_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Utility.con.Open();
            Utility.cmd = new OleDbCommand();
            //Utility.reader = Utility.cmd.ExecuteReader();
            string query = ("SELECT Nume_TipCamera FROM TipCamera");
            Utility.cmd.CommandText = query;
            Utility.cmd = new OleDbCommand(query, Utility.con);
            //Utility.cmd.ExecuteReader();
            OleDbDataReader reader = Utility.cmd.ExecuteReader();
            while (reader.Read())
            {
                combonumetipcamera.Items.Add(reader.GetValue(0));
            }
            Utility.con.Close();
        }

        private void butoninsereaza_Click(object sender, EventArgs e)
        {
            try
            {
                //default value pentru could camera
                //int codcamera = 0;


                // aici vom selecta codul camera luand numele din Combobox
                string query1 = $"SELECT CodCamera FROM Tip_Camera WHERE NumeCamera = '{combonumetipcamera}'";
                Utility.con.Open();

                OleDbDataReader reader = Utility.cmd.ExecuteReader();
               
                int codcamera = (int)Utility.cmd.ExecuteScalar();


                //{codcamera} va lua valoarea Query1
                string query2 = $"INSERT INTO Camera(Nr_Camera, Cod_TipCamera, Etaj_Camera) VALUES ('{textnrcamera}',{codcamera},'{textetajcamera}')"; 



                //string query = "INSERT INTO Camera (Nr_Camera,Etaj_Camera) VALUES" +
                //"(@nr,@etaj)";
                //Utility.cmd = new OleDbCommand(query, Utility.con);
                //Utility.cmd.Parameters.AddWithValue("@nr", textnrcamera.Text);
                ////Utility.cmd.Parameters.AddWithValue("@codtip", textprenume.Text);
                //Utility.cmd.Parameters.AddWithValue("@etaj", textetajcamera.Text);
                //Utility.con.Open();
                //Utility.cmd.ExecuteNonQuery();
                //Utility.con.Close();
                //MessageBox.Show("Camera a fost introdusa cu succes.");
                //GetCamera();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utility.con.Close();
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textcodcamera.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textnrcamera.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //textcodtipcamera.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textetajcamera.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }


        //private void combonumetipcamera_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // obtin codul Cod_TipCamera din Camera(table)
        //        //int codcamera = 0;
        //        //string query2 = $"SELECT Cod_TipCamera FROM Camera WHERE Nume_TipCamera = '{combonumetipcamera}';";
        //        //Utility.con.Open();
        //        //OleDbDataReader reader2 = Utility.cmd.ExecuteReader();
        //        //while(reader2.Read())
        //        //{
        //        //    codcamera = reader2.GetInt32(0);
        //        //}
        //        //Utility.con.Close();

        //        //string query = $"SELECT TipCamera.Cod_TipCamera" + $" FROM TipCamera" +
        //        //    $" INNER JOIN Camera ON Tipcamera.CodTip_Camera = {codcamera}";
        //        //Utility.cmd = new OleDbCommand(query, Utility.con);
        //        //Utility.con.Open();
        //        //Utility.cmd.ExecuteNonQuery();
        //        //OleDbDataReader reader = Utility.cmd.ExecuteReader();
        //        //while(reader.Read())
        //        //{
        //        //    textcodtipcamera.AppendText(reader.GetString(0));
        //        //}
        //        //Utility.con.Close();
        //    }
        //    catch(Exception ex) 
        //    {
        //        MessageBox.Show(ex.Message);
        //        Utility.con.Close();
        //    }

        //}
    }
}
