﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace AAARent_ASP.Models
{
    public class Klijent
    {
        static int ID = 1;
        string korisnickoIme;
        int id;
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
        string username;
        string pw;

        public Klijent()
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

        //public Klijent(string id, string ime, string prezime, string brojTelefona, string eMail, DateTime datumRodjenja, DateTime datumRegistracije)

        public Klijent( string ime, string prezime, string brojTelefona, string eMail, string drzava, Image slika, DateTime datumRodjenja, DateTime datumRegistracije, string username, string pw)

        {
            this.id = ID;
            ID++;
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

        public int Id
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
    }
}