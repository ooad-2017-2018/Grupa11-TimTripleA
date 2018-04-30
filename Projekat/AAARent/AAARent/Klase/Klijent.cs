using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AAARent.Klase
{
    class Klijent
    {
        static int ID=1;
        int id;
        string ime;
        string prezime;
        string brojTelefona;
        string eMail;
        DateTime datumRodjenja;
        DateTime datumRegistracije;


        public Klijent(int id, string ime, string prezime, string brojTelefona, string eMail, DateTime datumRodjenja, DateTime datumRegistracije)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.BrojTelefona = brojTelefona;
            this.EMail = eMail;
            this.DatumRodjenja = datumRodjenja;
            this.DatumRegistracije = datumRegistracije;
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
