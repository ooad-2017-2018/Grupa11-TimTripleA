using Windows.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Controls;

namespace AAARent.Klase
{
    class Klijent
    {
        static int ID=1;
        string id;
        string ime;
        string prezime;
        string brojTelefona;
        string eMail;
        string drzava;
        Image slika;
        DateTime datumRodjenja;
        DateTime datumRegistracije;
        string username;
        string pw;

        public Klijent(string id, string ime, string prezime, string brojTelefona, string eMail,string drzava, Image slika, DateTime datumRodjenja, DateTime datumRegistracije, string username,string pw)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.brojTelefona = brojTelefona;
            this.eMail = eMail;
            this.drzava = drzava;
            this.slika = slika;
            this.datumRodjenja = datumRodjenja;
            this.datumRegistracije = datumRegistracije;
            this.username = username;
            this.pw = pw;
        }

        public string Drzava
        {
            get
            {
                return drzava;
            }
            set
            {
                drzava = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string BrojTelefona
        {
            get
            {
                return brojTelefona;
            }

            set
            {
                brojTelefona = value;
            }
        }

        public string EMail
        {
            get
            {
                return eMail;
            }

            set
            {
                eMail = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public DateTime DatumRegistracije
        {
            get
            {
                return datumRegistracije;
            }

            set
            {
                datumRegistracije = value;
            }
        }

        public System.String Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public System.String Pw
        {
            get
            {
                return pw;
            }

            set
            {
                pw = value;
            }
        }

        
    }
}
