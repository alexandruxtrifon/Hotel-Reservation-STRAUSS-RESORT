﻿using System;
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
    public partial class Form5 : Form
    {
        DataTable dt;
        OleDbDataAdapter adapter;
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void GetFactura()
        {
            dt = new DataTable();
            //Utility.adapter = new OleDbDataAdapter("SELECT * FROM Factura", Utility.con);
            string query = "SELECT F.Data, F.Pret_Unitar, F.Cantitate, F.Valoare," +
                " Client.Nume_Client, Client.Prenume_Client, Client.Adresa_Client, TipCamera.Nume_TipCamera, " +
                "Camera.Nr_Camera " +
                "FROM (((Factura AS F " +
                "INNER JOIN Rezervare AS RE ON F.Cod_Rezervare = RE.Cod_Rezervare) " +
                "INNER JOIN Client AS CL ON RE.Cod_Client = CL.Cod_Client) " +
                "INNER JOIN Camera AS C ON RE.Cod_Camera = C.Cod_Camera) " +
                "INNER JOIN TipCamera AS TC ON C.Cod_TipCamera = TC.Cod_TipCamera";
              //  "WHERE RE.Cod_Rezervare IS NOT NULL";
            adapter = new OleDbDataAdapter(query, Utility.con);
            //Utility.con.Open();
            //Utility.adapter.Fill(dt);
            adapter.Fill(dt);
            //Utility.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
