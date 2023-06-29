using LiveCharts;
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
using static Rezervare_Hotel.Utility;
using System.Runtime.CompilerServices;
using System.Windows.Controls.Primitives;


namespace Rezervare_Hotel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxR1.Select();
        }

        private void butonR1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string user = textBoxR1.Text;
            string parola = textBoxR2.Text;

            string query = $"SELECT Nume, Prenume FROM Utilizator WHERE Username = '" + textBoxR1.Text + "' AND Parola = '" + textBoxR2.Text + "'";
            Utility.cmd = new OleDbCommand(query, Utility.con);
            //  Utility.cmd.Parameters.AddWithValue("@Username", user);
            //  Utility.cmd.Parameters.AddWithValue("@Parola", parola);

            Utility.con.Open();
            OleDbDataReader reader = Utility.cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                Utility.contnume = $"{reader["Nume"].ToString()} {reader["Prenume"].ToString()}";

             //   string nume = reader["Nume"].ToString();
             //   string prenume = reader["Prenume"].ToString();
                reader.Close();
                Utility.con.Close();
                Form1 f = new Form1();
                // Label label = (Label)Form1.Controls["label3"]
                // ((Label)Form1.Controls.["label3"]).Text = "Bun venit, " + nume + " " + prenume; 
                this.Hide();
                f.Show();

            }
            else
            {
                MessageBox.Show("Utilizator sau Parola introdusa gresit");
                reader.Close();
                Utility.con.Close();
            }


        }

        private void textBoxR2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butonR1.PerformClick();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butonR1.PerformClick();
                e.Handled = true;
            }
        }

        private void textBoxR1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBoxR1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
