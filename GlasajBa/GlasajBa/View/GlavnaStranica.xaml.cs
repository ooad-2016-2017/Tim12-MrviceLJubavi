using GlasajBa.Model;
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
using GlasajBa.ViewModel;
using Windows.UI.Core;
using GlasajBa.ViewModel.GlasajBa.ViewModel;
using GlasajBa.Helper;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GlasajBa.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GlavnaStranica : Page
    {

        public GlavnaStranica()
        {
            this.InitializeComponent();
            //var inicijalizacija = new DataSource();
            DataContext = new OstaleFunkcionalnostiViewModel();
            NavigationCacheMode = NavigationCacheMode.Required;


           // var glasac = DataSource.DajSveGlasace()[0];
            //Glasac g = new Glasac();
            //g = glasac;
         

            //this.DataContext = this;
            //pokušaj instanciranja view modela:
            //vm = new OstaleFunkcionalnostiViewModel();
            //DataContext = new OstaleFunkcionalnostiViewModel();

            // var currentView = SystemNavigationManager.GetForCurrentView();
            //currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            //SystemNavigationManager.GetForCurrentView().BackRequested += ;
        }



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }
        /* protected override void OnNavigatedTo(NavigationEventArgs e) {
             DataContext = new OstaleFunkcionalnostiViewModel();
         }*/
        /*
        private void ThisPage_BackRequested(object sender, BackRequestedEventArgs e) {
            if (Frame.CanGoBack) { Frame.GoBack(); e.Handled = true; } 
        }
        */
    }
}
