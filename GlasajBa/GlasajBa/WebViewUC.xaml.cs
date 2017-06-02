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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace GlasajBa
{
    public sealed partial class WebViewAndButton : UserControl
    {
        public WebViewAndButton()
        {
            this.InitializeComponent();

            String sURL = "https://twitter.com/glasaj_ba";
            try
            {
                Uri webURL = new Uri(sURL);
                ctlBrowser.Navigate(webURL);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
