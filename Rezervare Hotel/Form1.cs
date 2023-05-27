using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervare_Hotel
{
    public partial class Form1 : Form
    {
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alex\source\repos\Rezervare Hotel\Rezervare Hotel\Baza de date licenta.accdb");
       
        public Form1()
        {
            InitializeComponent();

        }
       
     
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utility.con.Open();
            //OleDbCommand cmd = new OleDbCommand("Insert into Client(Nume_Client,Prenume_Client,Email_Client,Telefon_Client,Adresa_Client)" +
            //    "Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", Utility.con);
             Utility.cmd = new OleDbCommand("Insert into Client(Nume_Client,Prenume_Client,Email_Client,Telefon_Client,Adresa_Client)" +
                "Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", Utility.con);
            //cmd.CommandText = "";
            //cmd.Connection = con;
            Utility.cmd.ExecuteNonQuery();
            MessageBox.Show("Client Adaugat");
            Utility.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void butonclienti_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void butoncheckin_Click(object sender, EventArgs e)
        {

        }

        private void butonrezervari_Click(object sender, EventArgs e)
        {
            RezervareForm f = new RezervareForm();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            RezervareForm f = new RezervareForm();
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormRaportUtilizatori f = new FormRaportUtilizatori();
            f.Show();
        }
    }
}