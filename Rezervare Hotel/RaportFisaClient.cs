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
    public partial class RaportFisaClient : Form
    {
        public RaportFisaClient()
        {
            InitializeComponent();
        }

        private void RaportFisaClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Fisa_Client' table. You can move, or remove it, as needed.
            //his.fisa_ClientTableAdapter.Fill(this.dataSet1.Fisa_Client);

            this.reportViewer1.RefreshReport();
            PopulateListBoxWithClientNames();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the selected item from listBox1
            string selectedItem = listBox1.SelectedItems[0] as string;

            // Split the selected item based on ' '
            string[] nameParts = selectedItem.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            // Fill the clientTableAdapter with the selected names
            this.fisa_ClientTableAdapter.Fill(this.dataSet1.Fisa_Client, firstName, lastName);
            // this.clientTableAdapter.Fill(this.dataSet1.Client, firstName, lastName);
            this.reportViewer1.RefreshReport();

        }

        private void PopulateListBoxWithClientNames()
        {
            string query = @"SELECT DISTINCT C.Nume_Client & ' ' & C.Prenume_Client AS FullName
                     FROM Client AS C
                     INNER JOIN Rezervare AS R ON C.Cod_Client = R.Cod_Client";
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
    }
}
