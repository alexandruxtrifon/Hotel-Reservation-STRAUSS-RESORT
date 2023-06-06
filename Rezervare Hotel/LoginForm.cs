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

                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizator sau Parola introdusa gresit");
                reader.Close();
                Utility.con.Close();
            }


        }
        //catch (Exception ex)
        //  {
        //         MessageBox.Show("A aparut o eroare: " + ex.Message);
        //    }
        //    finally
        //   {
        //        Utility.con.Close();
        //   }        
    }
}
