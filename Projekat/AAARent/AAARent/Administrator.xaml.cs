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
    public sealed partial class Administrator : Page
    {
        IMobileServiceTable<Radnik> userTableobj;
        public static MobileServiceClient MobileService = new MobileServiceClient("https://aaarent.azurewebsites.net");

        public Administrator()
        {
            this.InitializeComponent();
            userTableobj = App.MobileService.GetTable<Radnik>();

        }

        private void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                Radnik noviRadnik = new Radnik();
                noviRadnik.Ime = textBoxIme.Text;
                noviRadnik.Prezime = textBoxPrezime.Text;
                noviRadnik.MaticniBroj = textBoxJMBG.Text;
                noviRadnik.MjestoRodjenja = textBoxMjesto.Text;
                long t = datePickerrodjen.Date.Ticks;
                noviRadnik.DatumRodjenja = new DateTime(t);
                t = datePickerzaposlen.Date.Ticks;
                noviRadnik.DatumZaposlenja = new DateTime(t);
                noviRadnik.KorisnickoIme = textBoxUsername.Text;
                noviRadnik.Lozinka = textBoxPassword.Text;
                noviRadnik.LjekarskiPregled = Convert.ToBoolean(checkBox.IsChecked);
                noviRadnik.Administrator = Convert.ToBoolean(checkBox2.IsChecked);
                noviRadnik.Plata = (float)Convert.ToDecimal(textBoxPlata.Text);
                userTableobj.InsertAsync(noviRadnik);
                MessageDialog msg = new MessageDialog("Unijeti novi radnik");
                msg.ShowAsync();
            }
            catch(Exception ex)
            {
                MessageDialog msg = new MessageDialog("Error: " + ex.ToString());
                msg.ShowAsync();
            }
        }

        private void textBlockIme_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
