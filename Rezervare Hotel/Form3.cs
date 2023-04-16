using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervare_Hotel
{

    public partial class Form3 : Form
    {
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alex\source\repos\Rezervare Hotel\Rezervare Hotel\Baza de date licenta.accdb");
        //OleDbCommand cmd;
        //OleDbDataAdapter adapter;
        DataTable dt;
        private DataAccessLayer dal = new DataAccessLayer();
        private BindingSource clientiBindingSource = new BindingSource();

        void GetCustomers()
        {
            dt = new DataTable();
            Utility.adapter = new OleDbDataAdapter("SELECT * FROM Client", Utility.con);
            Utility.con.Open();
            Utility.adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Utility.con.Close();

        }

        public Form3()
        {
            InitializeComponent();
            //GetCustomers();


        }

        private void butoninsereaza_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO Client (Nume_Client,Prenume_Client,Email_Client,Telefon_Client,Adresa_Client) VALUES" +
            //    "(@nume,@prenume,@email,@telefon,@adresa)";
            //Utility.cmd = new OleDbCommand(query, Utility.con);
            //Utility.cmd.Parameters.AddWithValue("@nume", textnume.Text);
            //Utility.cmd.Parameters.AddWithValue("@prenume", textprenume.Text);
            //Utility.cmd.Parameters.AddWithValue("@email", textemail.Text);
            //Utility.cmd.Parameters.AddWithValue("@telefon", texttelefon.Text);
            //Utility.cmd.Parameters.AddWithValue("@adresa", textadresa.Text);
            //Utility.con.Open();
            //Utility.cmd.ExecuteNonQuery();
            //Utility.con.Close();
            //MessageBox.Show("Clientul a fost introdus cu succes. BRAVO BUEY");
            //GetCustomers();

            Client newClient = new Client();
            clientiBindingSource.Add(newClient);
        }

        private void butonactualizeaza_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Client SET Nume_Client=@nume,Prenume_Client=@prenume,Email_Client=@email,Telefon_Client=@telefon,Adresa_Client=@adresa" +
                "WHERE Cod_Client=@id";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            Utility.cmd.Parameters.AddWithValue("@nume", textnume.Text);
            Utility.cmd.Parameters.AddWithValue("@prenume", textprenume.Text);
            Utility.cmd.Parameters.AddWithValue("@email", textemail.Text);
            Utility.cmd.Parameters.AddWithValue("@telefon", texttelefon.Text);
            Utility.cmd.Parameters.AddWithValue("@adresa", textadresa.Text);
            Utility.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textcodclient.Text));
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            MessageBox.Show("Clientul a fost actualizat cu succes. BRAVO BUEY");
            GetCustomers();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //textcodclient.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textnume.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //textprenume.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //textemail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //texttelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //textadresa.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void butonsterge_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Client WHERE Cod_Client=@id";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            Utility.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textcodclient.Text));
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            MessageBox.Show("Clientul a fost sters cu succes. BRAVO BUEY");
            GetCustomers();
        }

        private void cautaclient_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Nume_Client LIKE '%" + cautaclient.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Client> clienti = dal.GetAllClients();
            clientiBindingSource.DataSource = clienti;
            dataGridView1.DataSource = clientiBindingSource;
        }
    }
}
