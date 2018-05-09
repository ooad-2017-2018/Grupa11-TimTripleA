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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AAARent.Klase;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AAARent
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Prijava : Page
    {
        IMobileServiceTable<Radnik> radnici;
        public static MobileServiceClient MobileService = new MobileServiceClient("https://aaarent.azurewebsites.net");

        IMobileServiceTable<Klijent> klijenti;
      //  public static MobileServiceClient MobileService = new MobileServiceClient("https://aaarent.azurewebsites.net");

        public Prijava()
        {
            this.InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistracijaKorisnika));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
