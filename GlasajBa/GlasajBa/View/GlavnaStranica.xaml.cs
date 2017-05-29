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
            //pokušaj instanciranja view modela:
            NavigationCacheMode = NavigationCacheMode.Required;
            DataContext = new OstaleFunkcionalnostiViewModel();
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            //SystemNavigationManager.GetForCurrentView().BackRequested += ;
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            DataContext = new OstaleFunkcionalnostiViewModel();
        }
        /*
        private void ThisPage_BackRequested(object sender, BackRequestedEventArgs e) {
            if (Frame.CanGoBack) { Frame.GoBack(); e.Handled = true; } 
        }
        */
    }
}
