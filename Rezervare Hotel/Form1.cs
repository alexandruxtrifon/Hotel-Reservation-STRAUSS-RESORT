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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alex\source\repos\Rezervare Hotel\Rezervare Hotel\Baza de date licenta.accdb");
       
        public Form1()
        {
            InitializeComponent();

        }
       
     
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Client(Nume_Client,Prenume_Client,Email_Client,Telefon_Client,Adresa_Client)" +
                "Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);
            //cmd.CommandText = "";
            //cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Adaugat", "Bravo buey");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
        }

        private void butonclienti_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}