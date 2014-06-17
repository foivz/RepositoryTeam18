using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Velpro
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        //na back key bacaj van aplikacije 
        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult mRes = MessageBox.Show("Would you like to exit?", "Exit", MessageBoxButton.OKCancel);
            if (mRes == MessageBoxResult.OK)
            {
                Application.Current.Terminate();
            }
            if (mRes == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        //kontrole za placeholder naziva na listi želja
        private void Naziv_GotFocus(object sender, RoutedEventArgs e)
        {
            NazivPlaceholder.Visibility = Visibility.Collapsed;    
        }
    

        private void Naziv_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                var textbox = sender as TextBox;
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    NazivPlaceholder.Visibility = Visibility.Visible;
                    }
                }
            }

        //kontrole za placeholder opisa na listi želja
        private void Opis_GotFocus(object sender, RoutedEventArgs e)
        {
            OpisPlaceholder.Visibility = Visibility.Collapsed;
        }


        private void Opis_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                var textbox = sender as TextBox;
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    OpisPlaceholder.Visibility = Visibility.Visible;
                }
            }
        }


        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void Panorama_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

       

       

        

        

    }
}