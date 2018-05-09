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
        string korisnickoIme;
        string id;
        string ime;
        string prezime;
        string brojTelefona;
        string eMail;
        string drzava;
        string lozinka;
        string maticniBroj;
        Image slika;
        DateTime datumRodjenja;
        DateTime datumRegistracije;

        public Klijent ()
        {

        }
        public string MaticniBroj
        {
            get
            {
                return maticniBroj;
            }
            set
            {
                maticniBroj = value;
            }
        }
        public string Lozinka
        {
            get
            {
                return lozinka;
            }
            set
            {
                lozinka = value;
            }
        }
        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }
            set
            {
                korisnickoIme = value;
            }
        }
            
        public Klijent(string id, string ime, string prezime, string brojTelefona, string eMail, DateTime datumRodjenja, DateTime datumRegistracije)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.BrojTelefona = brojTelefona;
            this.EMail = eMail;
            this.DatumRodjenja = datumRodjenja;
            this.DatumRegistracije = datumRegistracije;
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
    }
}
