﻿#pragma checksum "C:\Users\McTino\Documents\Visual Studio 2012\Projects\Velpro\Velpro\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "43EB1830FA312585D287006096F3894A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Velpro {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock Naziv;
        
        internal System.Windows.Controls.TextBlock NazivPlaceholder;
        
        internal System.Windows.Controls.TextBox naziv;
        
        internal System.Windows.Controls.TextBlock Opis;
        
        internal System.Windows.Controls.TextBlock OpisPlaceholder;
        
        internal System.Windows.Controls.TextBox opis;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Velpro;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Naziv = ((System.Windows.Controls.TextBlock)(this.FindName("Naziv")));
            this.NazivPlaceholder = ((System.Windows.Controls.TextBlock)(this.FindName("NazivPlaceholder")));
            this.naziv = ((System.Windows.Controls.TextBox)(this.FindName("naziv")));
            this.Opis = ((System.Windows.Controls.TextBlock)(this.FindName("Opis")));
            this.OpisPlaceholder = ((System.Windows.Controls.TextBlock)(this.FindName("OpisPlaceholder")));
            this.opis = ((System.Windows.Controls.TextBox)(this.FindName("opis")));
        }
    }
}

