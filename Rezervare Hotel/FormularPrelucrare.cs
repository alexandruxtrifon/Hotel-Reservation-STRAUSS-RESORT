using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervare_Hotel
{
    public partial class FormularPrelucrare : Form
    {
        public FormularPrelucrare()
        {
            InitializeComponent();
            //this.Load += FormularPrelucrare_Load;
        }
        private string firstName;
        private string lastName;
        private void FormularPrelucrare_Load(object sender, EventArgs e)
        {
            PopulateListBoxWithClientNames();



            // TODO: This line of code loads data into the 'dataSet1.Client' table. You can move, or remove it, as needed.
           // this.clientTableAdapter.Fill(this.dataSet1.Client,);
            //   this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1, int.Parse(textBox1.Text));
            this.reportViewer1.RefreshReport();
            //popularelista();
        }

        private void PopulateListBoxWithClientNames()
        {
            string query = @"SELECT C.Nume_Client & ' ' & C.Prenume_Client AS FullName
                     FROM Client AS C
                     INNER JOIN Rezervare AS R ON C.Cod_Client = R.Cod_Client";

            Utility.cmd.CommandText = query;

            try
            {
                Utility.con.Open();
                using (OleDbDataReader reader = Utility.cmd.ExecuteReader())
                {
                    listBox1.Items.Clear(); // Clear the existing items in the ListBox

                    while (reader.Read())
                    {
                        string fullName = reader.GetString(0);

                        // Add the concatenated name to the ListBox
                        listBox1.Items.Add(fullName);
                    }
                }
            }
            catch (OleDbException ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error executing query: " + ex.Message);
            }
            finally
            {
                Utility.con.Close();
            }
        }

        void popularelista() // eroare sintaxa from clause
        {
            string query = "SELECT CONCAT(c.[Nume_Client], ' ', c.[Prenume_Client]) AS NumePrenume " +
                           "FROM Rezervare r" +
                           "JOIN Client c ON r.[Cod_Client] = c.[Cod_Client]";
            Utility.con.Open();
            Utility.cmd = new OleDbCommand(query, Utility.con);
            DataTable dt = new DataTable();
            Utility.adapter = new OleDbDataAdapter(Utility.cmd);
            Utility.adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string numePrenume = row["NumePrenume"].ToString();
                // listBox1.Items.Add(numePrenume);
            }
            Utility.con.Close();
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the selected item from listBox1
            string selectedItem = listBox1.SelectedItem.ToString();

            // Split the selected item based on ' '
            string[] nameParts = selectedItem.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            // Fill the clientTableAdapter with the selected names
            this.clientTableAdapter.Fill(this.dataSet1.Client, firstName, lastName);
            // this.clientTableAdapter.Fill(this.dataSet1.Client, firstName, lastName);

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
