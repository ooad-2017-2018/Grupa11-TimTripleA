using System;
using Windows.System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAARent.Klase
{
    class Iznajmljivanje
    {
        static int ID = 0;
        DateTime datum;
        DateTime rok;
        double cijena;
        double placeno;
        string nacinPlacanja;
        bool vraceno;
        double dodatnaNaplata;
        string nacinPlacanjaStete;

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public DateTime Rok
        {
            get
            {
                return rok;
            }

            set
            {
                rok = value;
            }
        }

        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }

        public double Placeno
        {
            get
            {
                return placeno;
            }

            set
            {
                placeno = value;
            }
        }

        public string NacinPlacanja
        {
            get
            {
                return nacinPlacanja;
            }

            set
            {
                nacinPlacanja = value;
            }
        }

        public bool Vraceno
        {
            get
            {
                return vraceno;
            }

            set
            {
                vraceno = value;
            }
        }

        public double DodatnaNaplata
        {
            get
            {
                return dodatnaNaplata;
            }

            set
            {
                dodatnaNaplata = value;
            }
        }

        public string NacinPlacanjaStete
        {
            get
            {
                return nacinPlacanjaStete;
            }

            set
            {
                nacinPlacanjaStete = value;
            }
        }

        public Iznajmljivanje(DateTime datum, DateTime rok, double cijena, double placeno, string nacinPlacanja, bool vraceno, double dodatnaNaplata, string nacinPlacanjaStete)
        {
            this.Datum = datum;
            this.Rok = rok;
            this.Cijena = cijena;
            this.Placeno = placeno;
            this.NacinPlacanja = nacinPlacanja;
            this.Vraceno = vraceno;
            this.DodatnaNaplata = dodatnaNaplata;
            this.NacinPlacanjaStete = nacinPlacanjaStete;
        }
    }
}
