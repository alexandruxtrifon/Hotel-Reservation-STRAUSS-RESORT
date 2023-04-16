using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rezervare_Hotel
{
    public class Client
    {
        public int _Codclient { get; set; }
        public string _Numeclient { get; set; }
        public string _Prenumeclient { get; set; }
        public string _Emailclient { get; set; }
        public string _Telefonclient { get; set; }
        public string _Adresaclient { get; set; }

        //public Client(string Codclient, string Numeclient, string Prenumeclient,
        //    string Emailclient, string Telefonclient, string Adresaclient)
        //{
        //    _Codclient = Codclient;
        //    _Numeclient = Numeclient;
        //    _Emailclient = Emailclient;
        //    _Telefonclient = Telefonclient;
        //    _Adresaclient = Adresaclient;
        //}
    }



        
        public class Rezervare
    {
        public int _Codrezervare { get; set; }
        public DateTime _Datacazare { get; set; }
        public DateTime _Dataplecare { get; set; }
        public string _Codclient { get; set; }
        public string _Codcamera { get; set; }

        //public Rezervare(string Codrezervare, DateTime Datacheckin, DateTime Datacheckout, string Codclient, string Codcamera)
        //{
        //    _Codrezervare = Codrezervare;
        //    _Datacazare = Datacheckin;
        //    _Dataplecare = Datacheckout;
        //    _Codclient = Codclient;
        //    _Codcamera = Codcamera;
        //}
    }

    public class Camera
    {
        public string _Codcamera { get; set; }
        public string _Nrcamera { get; set; }
        public string _Codtipcamera { get; set; }
        public string _Etajcamera { get; set; }

        //public Camera(string codcamera, string nrcamera, string etajcamera, string codtipcamera)
        //{
        //    _Codcamera = codcamera;
        //    _Nrcamera = nrcamera;
        //    _Codtipcamera = codtipcamera;
        //    _Etajcamera = etajcamera;
            
        //}
    }

    public class TipCamera
    {
        public string _Codtipcamera { get; set; }
        public string _Numetipcamera { get; set; }
        public string _Prettipcamera { get; set; }
        public string _Capacitatetipcamera { get; set; }

        //public TipCamera(string codtipcamera, string numetipcamera, string prettipcamera, string capacitatetipcamera)
        //{
        //    _Codtipcamera = codtipcamera;
        //    _Numetipcamera = numetipcamera;
        //    _Prettipcamera = prettipcamera;
        //    _Capacitatetipcamera = capacitatetipcamera;
        //}
    }

    public class Factura
    {
        public int _Codfactura { get; set; }
        public DateTime _Datafactura { get; set; }
        public string _Sumafactura { get; set; }
        public string _Codrezervare { get; set; }
        public string _Codplata { get; set; }

        //public Factura(string codfactura, DateTime datafactura, string sumafactura, string codrezervare, string codplata)
        //{
        //    _Codfactura = codfactura;
        //    _Datafactura = datafactura;
        //    _Sumafactura = sumafactura;
        //    _Codrezervare = codrezervare;
        //    _Codplata = codplata;
        //}
    }

    public class Plata
    {
        public string _Codplata { get; set; }
        public string _Metodadeplata { get; set; }

        //public Plata(string codplata, string metodadeplata)
        //{
        //    _Codplata = codplata;
        //    _Metodadeplata = metodadeplata;
        //}
    }
}
