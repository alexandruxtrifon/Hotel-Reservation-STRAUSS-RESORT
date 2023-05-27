using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervare_Hotel
{
    public static class Utility
    {
        //path si conexiunea globala
        public static string conString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alex\source\repos\Rezervare Hotel\Rezervare Hotel\Baza de date licenta.accdb");
        //public static string conString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Baza de date licenta.accdb");

        public static OleDbConnection con = new OleDbConnection(conString);
        public static OleDbCommand cmd;
        public static OleDbDataAdapter adapter;
        //public static OleDbDataReader reader;
        public static void utility()
        {

        }
    }

    public class DataAccessLayer
    {
        private string conString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alex\source\repos\Rezervare Hotel\Rezervare Hotel\Baza de date licenta.accdb");
        //private string conString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Baza de date licenta.accdb");


        public List<Client> GetAllClients()
        {
            List<Client> clienti = new List<Client>();
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Client", con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client
                    {
                        _Codclient = (int)reader["Cod_Client"],
                        _Numeclient = (string)reader["Nume_Client"],
                        _Prenumeclient = (string)reader["Prenume_Client"],
                        _Emailclient = (string)reader["Email_Client"],
                        _Telefonclient = (string)reader["Telefon_Client"],
                        _Adresaclient = (string)reader["Adresa_Client"]
                    };
                    clienti.Add(client);
                }
            }
            return clienti;
        }
    }
}