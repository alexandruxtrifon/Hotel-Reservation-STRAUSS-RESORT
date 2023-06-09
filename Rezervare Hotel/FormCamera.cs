﻿using System;
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
            GetCamera();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butontipcamera_Click(object sender, EventArgs e)
        {
            TipCameraForm f4 = new TipCameraForm();
            f4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Utility.con.Open();
            Utility.cmd = new OleDbCommand();
            //Utility.reader = Utility.cmd.ExecuteReader();
            string query = ("SELECT Nume_TipCamera FROM TipCamera");
            Utility.cmd.CommandText = query;
            Utility.cmd.Connection = Utility.con;
            OleDbDataReader reader = Utility.cmd.ExecuteReader();
            while (reader.Read())
            {
                combonumetipcamera.Items.Add(reader.GetValue(0));
            }
            reader.Close();
            Utility.con.Close();
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
                string selectedTipCamera = combonumetipcamera.SelectedItem.ToString();

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
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           // textcodcamera.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textnrcamera.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textetajcamera.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void combonumetipcamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}