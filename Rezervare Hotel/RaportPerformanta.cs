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
    public partial class RaportPerformanta : Form
    {
        public RaportPerformanta()
        {
            InitializeComponent();
        }


        private void RaportPerformanta_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Refresh();
            PopulateListBoxWithUserNames();
        }

        private void PopulateListBoxWithUserNames()
        {
            string query = @"SELECT U.Nume & ' ' & U.Prenume AS Nume
                     FROM Utilizator AS U";
            Utility.cmd = new OleDbCommand();
            Utility.cmd.Connection = Utility.con;

            Utility.cmd.CommandText = query;


            try
            {
                Utility.con.Open();
                using (OleDbDataReader reader = Utility.cmd.ExecuteReader())
                {
                    listBox1.Items.Clear();

                    while (reader.Read())
                    {
                        string fullName = reader.GetString(0);

                        listBox1.Items.Add(fullName);
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Utility.con.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItems[0] as string;


            string[] nameParts = selectedItem.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            this.performantaTableAdapter.Fill(this.dataSet1.Performanta, firstName, lastName);
            this.reportViewer1.RefreshReport();

        }
    }
}
