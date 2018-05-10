using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AAARent.Klase;
using
Microsoft.WindowsAzure.MobileServices;
using
Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AAARent
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistracijaKorisnika : Page
    {
        IMobileServiceTable<Klijent> userTableobj;
        public static MobileServiceClient MobileService = new MobileServiceClient("https://aaarent.azurewebsites.net");
        public RegistracijaKorisnika()
        {
            this.InitializeComponent();
            userTableobj = App.MobileService.GetTable<Klijent>();
        }

        private void btnPotvrdiTapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                Klijent noviKlijent = new Klijent();
                noviKlijent.Ime = textBoxIme.Text;
                noviKlijent.Prezime = textBoxPrezime.Text;
                noviKlijent.KorisnickoIme = textBoxKorisnickoIme.Text;
                noviKlijent.Drzava = textBoxDrzava.Text;
                noviKlijent.MaticniBroj = textBoxMaticniBroj.Text;
                noviKlijent.EMail = textBoxMail.Text;
                long t = dat.Date.Ticks;
                noviKlijent.DatumRodjenja = new DateTime(t);
                
                noviKlijent.DatumRegistracije = new DateTime(t); 
                noviKlijent.Lozinka = textBoxLozinka.Password;
                userTableobj.InsertAsync(noviKlijent);
                MessageDialog msg = new MessageDialog("Uspješno registrovan klijent");
                msg.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msg = new MessageDialog("Error: " + ex.ToString());
                msg.ShowAsync();
            }
        }

        private bool validiranjeUnosa()
        {
            if (textBoxIme.Text.ToString().Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti ime");
                msg.ShowAsync();
                return false;
            }
            if(textBoxPrezime.Text.ToString().Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti prezime");
                msg.ShowAsync();
                return false;
            }
            if(textBoxMaticniBroj.Text.Length!=13)
            {
                MessageDialog msg = new MessageDialog("Neispravan maticni broj");
                msg.ShowAsync();
                return false;
            }
            if(textBoxDrzava.Text.ToString().Length==0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti drzavu");
                msg.ShowAsync();
                return false;
            }
            if(textBoxMail.Text.ToString().Length==0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti e-mail");
                msg.ShowAsync();
                return false;
            }
            if(textBoxKorisnickoIme.Text.Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti korisnicko ime");
                msg.ShowAsync();
                return false;
            }
            if(textBoxLozinka.Password.Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti lozinku");
                msg.ShowAsync();
                return false;
            }
            if(textBoxPotvrdaLozinke.Password.Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti lozinku za potvrdu");
                msg.ShowAsync();
                return false;
            }
            if(textBoxLozinka.Password!=textBoxPotvrdaLozinke.Password)
            {
                MessageDialog msg = new MessageDialog("Potvrda lozinke se ne podudara sa lozinkom!");
                msg.ShowAsync();
                return false;
            }
            return true;

        }
        

    }
}
