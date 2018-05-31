using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AAARent_ASP.Models
{
    public class Radnik
    {
        static int ID = 0;
        int id;
        string maticniBroj;
        string ime;
        string prezime;
        string mjestoRodjenja;
        DateTime datumRodjenja;
        DateTime datumZaposlenja;
        string korisnickoIme;
        string lozinka;
        bool ljekarskiPregled;
        bool administrator;
        float plata;

        public Radnik()
        {

        }

        public Radnik(string maticniBroj, string ime, string prezime, string mjestoRodjenja, DateTime datumRodjenja, DateTime datumZaposlenja, string korisnickoIme, string lozinka, bool ljekarskiPregled, bool administrator, float plata)
        {
            this.id = ID;
            ID++;
            this.maticniBroj = maticniBroj;
            this.ime = ime;
            this.prezime = prezime;
            this.mjestoRodjenja = mjestoRodjenja;
            this.datumRodjenja = datumRodjenja;
            this.datumZaposlenja = datumZaposlenja;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.ljekarskiPregled = ljekarskiPregled;
            this.administrator = administrator;
            this.plata = plata;
        }

        public float Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
            }
        }

     

        public bool LjekarskiPregled
        {
            get
            {
                return ljekarskiPregled;
            }

            set
            {
                ljekarskiPregled = value;
            }
        }

        public bool Administrator
        {
            get
            {
                return administrator;
            }

            set
            {
                administrator = value;
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

        public string MjestoRodjenja
        {
            get
            {
                return mjestoRodjenja;
            }

            set
            {
                mjestoRodjenja = value;
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

        public DateTime DatumZaposlenja
        {
            get
            {
                return datumZaposlenja;
            }

            set
            {
                datumZaposlenja = value;
            }
        }

      
    }
}