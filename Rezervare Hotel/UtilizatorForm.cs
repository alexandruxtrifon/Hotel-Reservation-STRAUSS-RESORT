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

    public partial class UtilizatorForm : Form
    {
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alex\source\repos\Rezervare Hotel\Rezervare Hotel\Baza de date licenta.accdb");
        //OleDbCommand cmd;
        //OleDbDataAdapter adapter;
        DataTable dt;
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

        public UtilizatorForm()
        {
            InitializeComponent();
            //GetCustomers();
        }

        private void butoninsereaza_Click(object sender, EventArgs e)
        {


        }

        private void butonactualizeaza_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //  textcodclient.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //  textnumer.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //  textprenumer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //  textemailr.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //  texttelefonr.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            // textadresar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void butonsterge_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Client1' table. You can move, or remove it, as needed.
            this.client1TableAdapter.Fill(this.dataSet1.Client1);
            //GetCustomers();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void butonR2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Client WHERE Cod_Client=@id";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            //   Utility.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textcodclient.Text));
            Utility.con.Open();
            Utility.cmd.ExecuteNonQuery();
            Utility.con.Close();
            GetCustomers();
        }

        private void butonR1_Click(object sender, EventArgs e)
        {
            if (textnumer.Text == "" || textprenumer.Text == "" || textemailr.Text == "" || texttelefonr.Text == "" || textadresar.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile!", "Mai incearca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "INSERT INTO Client (Nume_Client, Prenume_Client, Email_Client, Telefon_Client, Adresa_Client) VALUES" +
                    "(@nume,@prenume,@email,@telefon,@adresa)";
                    Utility.cmd = new OleDbCommand(query, Utility.con);
                    Utility.cmd.Parameters.AddWithValue("@nume", textnumer.Text);
                    Utility.cmd.Parameters.AddWithValue("@prenume", textprenumer.Text);
                    Utility.cmd.Parameters.AddWithValue("@email", textemailr.Text);
                    Utility.cmd.Parameters.AddWithValue("@telefon", texttelefonr.Text);
                    Utility.cmd.Parameters.AddWithValue("@adresa", textadresar.Text);
                    Utility.con.Open();
                    Utility.cmd.ExecuteNonQuery();
                    Utility.con.Close();
                    MessageBox.Show("Clientul a fost introdus cu succes.");
                    GetCustomers();
                }
                catch (Exception)
                {
                    MessageBox.Show("Acest client se afla deja in baza de date", "Mai incearca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butonmodifica_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE Client SET Nume_Client=@nume,Prenume_Client=@prenume,Email_Client=@email,Telefon_Client=@telefon,Adresa_Client=@adresa"; //+
            //                                                                                                                                                // "WHERE Cod_Client=@id";
            //Utility.cmd = new OleDbCommand(query, Utility.con);
            //Utility.cmd.Parameters.AddWithValue("@nume", textnumer.Text);
            //Utility.cmd.Parameters.AddWithValue("@prenume", textprenumer.Text);
            //Utility.cmd.Parameters.AddWithValue("@email", textemailr.Text);
            //Utility.cmd.Parameters.AddWithValue("@telefon", texttelefonr.Text);
            //Utility.cmd.Parameters.AddWithValue("@adresa", textadresar.Text);
            //// Utility.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textcodclient.Text));
            //Utility.con.Open();
            //Utility.cmd.ExecuteNonQuery();
            //Utility.con.Close();
            //MessageBox.Show("Clientul a fost actualizat cu succes.");
            //GetCustomers();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                selectedRow.Cells["Nume"].Value = textnumer.Text;
                selectedRow.Cells["Prenume"].Value = textprenumer.Text;
                selectedRow.Cells["Email"].Value = textemailr.Text;
                selectedRow.Cells["Telefon"].Value = texttelefonr.Text;
                selectedRow.Cells["Adresa"].Value = textadresar.Text;

                dataGridView1.ClearSelection();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textnumer.Text = selectedRow.Cells["Nume"].Value.ToString();
                textprenumer.Text = selectedRow.Cells["Prenume"].Value.ToString();
                textemailr.Text = selectedRow.Cells["Email"].Value.ToString();
                texttelefonr.Text = selectedRow.Cells["Telefon"].Value.ToString();
                textadresar.Text = selectedRow.Cells["Adresa"].Value.ToString();
            }
        }

        private void texttelefonr_Validating(object sender, CancelEventArgs e)
        {
            TextBoxR textBox = (TextBoxR)sender;
            string telefon = textBox.Text.Trim();

            if (!telefon.StartsWith("07"))
            {
                errorProvider.SetError(textBox, "Numarul de telefon trebuie sa înceapa cu '07'.");

                textBox.Invalidate();
            }

            else if (telefon.Length > 10)
            {
                errorProvider.SetError(textBox, "Numarul de telefon nu poate avea mai mult de 10 cifre.");
                textBox.Invalidate();
            }
            else
            {
                errorProvider.SetError(textBox, "");

            }
        }

        private void texttelefonr_Enter(object sender, EventArgs e)
        {
            TextBoxR textBox = (TextBoxR)sender;
            if (!string.IsNullOrEmpty(errorProvider.GetError(textBox)))
            {
                errorProvider.SetError(textBox, errorProvider.GetError(textBox));
            }
        }

        private void cautaclientr_Load(object sender, EventArgs e)
        {
        }

        private void cautaclientr__TextChanged(object sender, EventArgs e)
        {
            string cauta = cautaclientr.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string concatenatedName = $"{row.Cells["Nume"].Value} {row.Cells["Prenume"].Value}".ToLower();

                if (concatenatedName.Contains(cauta))
                {
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }
    }
}
