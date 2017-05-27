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
        }

        

        private void buttonNadjiBM_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PronalazakBirackogMjesta));
        }

        private void buttonNovosti_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Informacije));
        }

        private void buttonTwitter_Click(object sender, RoutedEventArgs e)
        {
            //ucitaj twitter
        }

        private void buttonStranke_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Informacije));
        }

        private void buttonHistorija_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Informacije));
        }

        private void image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //nije jos u funkciji za slijepe
        }

        private void image1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //ovo treba fino al ne znam kako
            Frame.Navigate(typeof(AdminLogin));
        }

        private void buttonStatistika_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Informacije));
        }
    }
}
