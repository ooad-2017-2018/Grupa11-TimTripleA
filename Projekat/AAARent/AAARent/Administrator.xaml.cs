using Windows.System;
using System.Collections.Generic;
using System;
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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;

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
            azurirajListu();
        }

        private async void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (validacijaUnos())
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
                    noviRadnik.Lozinka = textBoxPassword.Password;
                    noviRadnik.LjekarskiPregled = Convert.ToBoolean(checkBox.IsChecked);
                    noviRadnik.Administrator = Convert.ToBoolean(checkBox2.IsChecked);
                    noviRadnik.Plata = (float)Convert.ToDecimal(textBoxPlata.Text);
                    await userTableobj.InsertAsync(noviRadnik);
                    MessageDialog msg = new MessageDialog("Unijeti novi radnik");
                    await msg.ShowAsync();
                    azurirajListu();
                }
                catch (Exception ex)
                {
                    MessageDialog msg = new MessageDialog("Error: " + ex.ToString());
                     await msg.ShowAsync();
                }
            }
        }

        private void textBlockIme_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private bool validacijaUnos()
        {
            if (textBoxIme.Text.ToString().Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti ime");
                msg.ShowAsync();
                return false;
            }
            if (textBoxPrezime.Text.Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti prezime");
                msg.ShowAsync();
                return false;
            }
            if (textBoxJMBG.Text.Length != 13)
            {
                MessageDialog msg = new MessageDialog("Maticni broj mora sadrzavati tacno 13 karaktera");
                msg.ShowAsync();
                return false;
            }
            if (datePickerrodjen.Date.Ticks > System.DateTime.Now.Ticks)
            {
                MessageDialog msg = new MessageDialog("Pogresan datum rodjenja");
                msg.ShowAsync();
                return false;
            }
            if (datePickerzaposlen.Date.Ticks > System.DateTime.Now.Ticks)
            {
                MessageDialog msg = new MessageDialog("Pogresan datum zaposlenja");
                msg.ShowAsync();
                return false;
            }
            if (textBoxMjesto.Text.Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti mjesto rodjenja");
                msg.ShowAsync();
                return false;
            }
            if (textBoxUsername.Text.Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti korisnicko ime");
                msg.ShowAsync();
                return false;
            }
            if (textBoxPassword.Password.Length == 0)
            {
                MessageDialog msg = new MessageDialog("Morate unijeti lozinku");
                msg.ShowAsync();
                return false;
            }
            if (textBoxPlata.Text.Length == 0 || Convert.ToDecimal(textBoxPlata.Text) <= 0)
            {
                MessageDialog msg = new MessageDialog("Plata mora biti pozitivna");
                msg.ShowAsync();
                return false;
            }
            return true;
        }

        private async void button2_Tapped(object sender, TappedRoutedEventArgs e)
        {

            IMobileServiceTable<Radnik> radnici = App.MobileService.GetTable<Radnik>();
            var rad = from x in radnici
                      where x.MaticniBroj == textBoxJMBG2.Text && x.KorisnickoIme == textBoxUsername2.Text
                      select x;
            var spisak = await rad.ToListAsync();
            if (spisak.Count == 0)
            {
                MessageDialog msg = new MessageDialog("Ne postoji dati radnik");
                await msg.ShowAsync();
            }
            else
            {
                var el = spisak[0];
                await userTableobj.DeleteAsync(el);
                MessageDialog msg = new MessageDialog("Obrisali ste radnika");
                await msg.ShowAsync();
                azurirajListu();
            }

        }
        private async void azurirajListu()
        {
            IMobileServiceTable<Radnik> radnici = App.MobileService.GetTable<Radnik>();
            var rad = from x in radnici
                      select x;
            var spisak = await rad.ToListAsync();
            listView.Items.Clear();
            foreach (Radnik r in spisak)
            {
                listView.Items.Add(r.Ime + " " + r.Prezime + "(" + r.MaticniBroj + ", " + r.KorisnickoIme + ")");
            }

        }

        

        
    }
}
