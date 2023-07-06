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

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string selectedItem = listBox1.SelectedItems[0] as string;
            string selectedItem = Utility.contnume as string;

            string[] nameParts = selectedItem.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            this.clientTableAdapter.Fill(this.dataSet1.Client, firstName, lastName);
            this.reportViewer1.RefreshReport();


        }

        void button1_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.dataSet1.Client, firstName, lastName);


        }
    }
}
