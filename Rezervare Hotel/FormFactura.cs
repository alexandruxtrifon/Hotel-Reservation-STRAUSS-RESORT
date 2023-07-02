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
    public partial class FormFactura : Form
    {
        DataTable dt;
        OleDbDataAdapter adapter;
        public FormFactura()
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
            textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1, int.Parse(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CodFactura' table. You can move, or remove it, as needed.
            this.codFacturaTableAdapter.Fill(this.dataSet1.CodFactura);
            // TODO: This line of code loads data into the 'dataSet1.Rezervare' table. You can move, or remove it, as needed.
            this.rezervareTableAdapter.Fill(this.dataSet1.Rezervare);

            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1, int.Parse(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1, int.Parse(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1, int.Parse(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                int codfactura = int.Parse(listBox1.SelectedValue.ToString());
                this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1, codfactura);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                return;
            }
        }
    }
}
