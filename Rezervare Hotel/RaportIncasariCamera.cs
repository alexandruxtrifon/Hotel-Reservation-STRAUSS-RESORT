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
    public partial class RaportIncasariCamera : Form
    {
        public RaportIncasariCamera()
        {
            InitializeComponent();
        }

        private void RaportIncasariCamera_Load(object sender, EventArgs e)
        {
            PopulateListBoxWithRooms();
            this.reportViewer1.RefreshReport();
        }

        private void PopulateListBoxWithRooms()
        {
            string query = @"SELECT C.Nr_Camera
                     FROM Camera AS C";
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

                        //listBox1.Items.Add(fullName);
                        if (!listBox1.Items.Contains(fullName))
                        {
                            listBox1.Items.Add(fullName);
                        }
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

            string nr = listBox1.SelectedItems[0] as string;

            this.incasariCameraTableAdapter.Fill(this.dataSet1.IncasariCamera, nr);
            this.reportViewer1.RefreshReport();

        }
    }
}
