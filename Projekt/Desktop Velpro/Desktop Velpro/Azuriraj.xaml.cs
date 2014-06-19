﻿using System;
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

namespace Desktop_Velpro
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Azuriraj : Desktop_Velpro.Common.LayoutAwarePage
    {
        public Azuriraj()
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

        private void GoBack(object sender, RoutedEventArgs e)
        {
            Glavna_forma Glavna = new Glavna_forma();
            this.Content = Glavna;
        }

        private void Dodaj_zap_Click(object sender, RoutedEventArgs e)
        {
            Dodaj_zaposlenika Dodaj_zaposlenik = new Dodaj_zaposlenika();
            this.Content = Dodaj_zaposlenik;
        }

        private void Brisi_zap_Click(object sender, RoutedEventArgs e)
        {
            Brisi_zaposlenika Brisi_zaposlenik = new Brisi_zaposlenika();
            this.Content = Brisi_zaposlenik;
        }

        private void Dodaj_kor_Click(object sender, RoutedEventArgs e)
        {
            Dodaj_korisnika Dodaj_korisnik = new Dodaj_korisnika();
            this.Content = Dodaj_korisnik;
        }

        private void Brisi_kor_Click(object sender, RoutedEventArgs e)
        {
            Brisi_korisnika Brisi_korisnik = new Brisi_korisnika();
            this.Content = Brisi_korisnik;
        }
    }
}