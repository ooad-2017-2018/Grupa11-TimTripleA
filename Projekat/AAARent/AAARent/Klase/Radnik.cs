using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAARent.Klase
{
    class Radnik
    {

        string maticniBroj;
        string ime;
        string prezime;
        string mjestoRodjenja;
        DateTime datumRodjenja;

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

        public Radnik(string maticniBroj, string ime, string prezime, string mjestoRodjenja, DateTime datumRodjenja)
        {
            this.MaticniBroj = maticniBroj;
            this.Ime = ime;
            this.Prezime = prezime;
            this.MjestoRodjenja = mjestoRodjenja;
            this.DatumRodjenja = datumRodjenja;
        }
    }
}
