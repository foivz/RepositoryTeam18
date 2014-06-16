using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace App2
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class GlavnaForma : App2.Common.LayoutAwarePage
    {
        public GlavnaForma()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pregled_skladiste Skladiste = new Pregled_skladiste();
            this.Content = Skladiste;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainPage Nazad = new MainPage();
            this.Content = Nazad;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Pregled_aktivne Aktivne = new Pregled_aktivne();
            this.Content = Aktivne;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Pregled_arhiva Arhiva = new Pregled_arhiva();
            this.Content = Arhiva;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Naruciti_dobavljac Dobavljac = new Naruciti_dobavljac();
            this.Content = Dobavljac;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Statistike Statistika = new Statistike();
            this.Content = Statistika;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Azuriraj Zaposlenici = new Azuriraj();
            this.Content = Zaposlenici;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Lista_zelje Zelje = new Lista_zelje();
            this.Content = Zelje;
        }
    }
}
