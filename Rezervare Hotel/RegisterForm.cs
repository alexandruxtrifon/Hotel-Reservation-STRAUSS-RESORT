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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            textnume.KeyPress += textnume_KeyPress;
        }

        private void butonR1_Click(object sender, EventArgs e)
        {
            string nume = textnume.Text;
            string prenume = textprenume.Text;
            string user = textutilizator.Text;
            string parola = textparola.Text;
            string adresa = textadr.Text;
            string telefon = texttel.Text;
            string email = textemail.Text;
            string iban = textiban.Text;

            string query = "INSERT INTO Utilizator (Nume, Prenume, Username, Parola, Email, Telefon, Adresa, IBAN) " +
                           $"VALUES ('{nume}', '{prenume}', '{user}', '{parola}', '{email}', '{telefon}', '{adresa}', '{iban}')";

            Utility.cmd = new OleDbCommand(query, Utility.con);

            try
            {
                Utility.con.Open();
                Utility.cmd.ExecuteNonQuery();
                MessageBox.Show("User registered successfully!");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Utility.con.Close();
            }
            clear();
        }
        private void clear()
        {
            textadr.Text = string.Empty;
            texttel.Text = string.Empty;
            textnume.Text = string.Empty;
            textprenume.Text= string.Empty;
            textutilizator.Text= string.Empty;
            textparola.Text= string.Empty;
            textiban.Text= string.Empty;
            textemail.Text= string.Empty;
        }

        private void textnume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
