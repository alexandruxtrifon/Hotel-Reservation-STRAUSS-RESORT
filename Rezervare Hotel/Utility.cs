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
        public static OleDbConnection con = new OleDbConnection(conString);
        public static OleDbCommand cmd;
        public static OleDbDataAdapter adapter;
        //public static OleDbDataReader reader;

        public static void utility() 
        {

        }
    }
}
