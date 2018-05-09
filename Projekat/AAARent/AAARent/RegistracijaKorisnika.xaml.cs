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

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
