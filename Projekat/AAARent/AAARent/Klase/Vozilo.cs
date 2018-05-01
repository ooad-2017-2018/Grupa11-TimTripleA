using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Controls;

namespace AAARent.Klase
{
    class Vozilo
    {
        string registracija;
        string tip;
        string model;
        string proizvodjac;
        int godiste;
        string boja;
        string tipGoriva;
        int konjskihSnaga;
        double kubikaza;
        double masa;
        double cijena;
        bool naStanju;
        Image slika;
        double lokacijaX;
        double lokacijaY;

        public Vozilo(string registracija, string tip, string model, string proizvodjac, int godiste, string boja, string tipGoriva, int konjskihSnaga, double kubikaza, double masa, double cijena, bool naStanju, double lokacijaX, double lokacijaY)
        {
            this.registracija = registracija;
            this.tip = tip;
            this.model = model;
            this.proizvodjac = proizvodjac;
            this.godiste = godiste;
            this.boja = boja;
            this.tipGoriva = tipGoriva;
            this.konjskihSnaga = konjskihSnaga;
            this.kubikaza = kubikaza;
            this.masa = masa;
            this.cijena = cijena;
            this.naStanju = naStanju;
            this.lokacijaX = lokacijaX;
            this.lokacijaY = lokacijaY;
        }

        public string Registracija
        {
            get
            {
                return registracija;
            }

            set
            {
                registracija = value;
            }
        }

        public string Tip
        {
            get
            {
                return tip;
            }

            set
            {
                tip = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Proizvodjac
        {
            get
            {
                return proizvodjac;
            }

            set
            {
                proizvodjac = value;
            }
        }

        public int Godiste
        {
            get
            {
                return godiste;
            }

            set
            {
                godiste = value;
            }
        }

        public string Boja
        {
            get
            {
                return boja;
            }

            set
            {
                boja = value;
            }
        }

        public string TipGoriva
        {
            get
            {
                return tipGoriva;
            }

            set
            {
                tipGoriva = value;
            }
        }

        public int KonjskihSnaga
        {
            get
            {
                return konjskihSnaga;
            }

            set
            {
                konjskihSnaga = value;
            }
        }

        public double Kubikaza
        {
            get
            {
                return kubikaza;
            }

            set
            {
                kubikaza = value;
            }
        }

        public double Masa
        {
            get
            {
                return masa;
            }

            set
            {
                masa = value;
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

        public bool NaStanju
        {
            get
            {
                return naStanju;
            }

            set
            {
                naStanju = value;
            }
        }

        public double LokacijaX
        {
            get
            {
                return lokacijaX;
            }

            set
            {
                lokacijaX = value;
            }
        }

        public double LokacijaY
        {
            get
            {
                return lokacijaY;
            }

            set
            {
                lokacijaY = value;
            }
        }
    }
}
