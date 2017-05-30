using GlasajBa.Helper;
using GlasajBa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GlasajBa.ViewModel;
using Windows.UI.Xaml;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Printing;
using Windows.UI.Xaml.Navigation;
using Windows.Graphics.Printing;
using GlasajBa.View;
using Windows.UI.Xaml.Input;

namespace GlasajBa.ViewModel
{
    

using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Printing;
using Windows.UI.Xaml.Controls;
using Windows.Graphics.Printing;

namespace GlasajBa.ViewModel
{


    class OstaleFunkcionalnostiViewModel : PrintDocument, Baza
    {
        ICommand PronalazakBirackogMjesta { get; set; }
        ICommand PregledNovosti { get; set; }
        ICommand PretragaKandidata { get; set; }
        ICommand SistemZaSlijepeISlabovidne { get; set; }
        GlasackiSistem sistem;

        public GlasackiSistem Sistem
        {
            get
            {
                return sistem;
            }

            set
            {
                sistem = value;
            }
        }

        Novost novost;
        Ulica ulica;
        Kandidat kandidat;

        List<Ulica> listaUlica = new List<Ulica>();
        List<Novost> listaNovosti = new List<Novost>();
        List<Kandidat> listaKandidata = new List<Kandidat>();

        List<Kandidat> listaPronadjenihKandidata = new List<Kandidat>();

        NavigationService NavigationService { get; set; }


        /* async private void OnPrintButtonClick(object sender, RoutedEventArgs e)

        async private void OnPrintButtonClick(object sender, RoutedEventArgs e)

         {
             if (Windows.Graphics.Printing.PrintManager.IsSupported())
             {
                 try
                 {
                     await Windows.Graphics.Printing.PrintManager.ShowPrintUIAsync();
                 }
                 catch
                 {
                     // Nije moguce printati
                     ContentDialog noPrintingDialog = new ContentDialog()
                     {
                         Title = "Greška u printanju",
                         Content = "\nŽao nam je, nije moguće printati u ovome trenutku.",
                         PrimaryButtonText = "OK"
                     };
                     await noPrintingDialog.ShowAsync();
                 }
             }
             else
             {
                 // Printanje nije podržžano na ovom uređaju
                 ContentDialog noPrintingDialog = new ContentDialog()
                 {
                     Title = "Printanje nije podržano",
                     Content = "\nŽao nam je, printanje nije podržano na ovome uređaju.",
                     PrimaryButtonText = "OK"
                 };
                 await noPrintingDialog.ShowAsync();
             }
         }


         public virtual void RegisterForPrinting()
         {
             PrintDocument = new PrintDocument();
             printDocumentSource = printDocument.DocumentSource;
             printDocument.Paginate += CreatePrintPreviewPages;
             printDocument.GetPreviewPage += GetPrintPreviewPage;
             printDocument.AddPages += AddPrintPages;

             PrintManager printMan = PrintManager.GetForCurrentView();
             printMan.PrintTaskRequested += PrintTaskRequested;
         }

         protected override void OnNavigatedTo(NavigationEventArgs e)
         {
             // Initalize common helper class and register for printing
             printHelper = new PrintHelper(this);
             printHelper.RegisterForPrinting();

             // Initialize print content for this scenario
             printHelper.PreparePrintContent(new PageToPrint());

             // Tell the user how to print
             MainPage.Current.NotifyUser("Print contract registered with customization, use the Print button to print.", NotifyType.StatusMessage);
         }

         protected override void OnNavigatedFrom(NavigationEventArgs e)
         {
             if (printHelper != null)
             {
                 printHelper.UnregisterForPrinting();
             }
         }

         protected virtual void PrintTaskRequested(PrintManager sender, PrintTaskRequestedEventArgs e)
         {
             PrintTask printTask = null;
             printTask = e.Request.CreatePrintTask("C# Printing SDK Sample", sourceRequested =>
             {
                 // Print Task event handler is invoked when the print job is completed.
                 printTask.Completed += async (s, args) =>
                 {
                     // Obavjestavanje korisnika da printanje nije uspjelo
                     if (args.Completion == PrintTaskCompletion.Failed)
                     {
                         await scenarioPage.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                         {
                             MainPage.Current.NotifyUser("Printanje nije uspjelo.", NotifyType.ErrorMessage);
                         });
                     }
                 };
                 sourceRequested.SetSource(printDocumentSource);
             });
         }
         protected virtual void GetPrintPreviewPage(object sender, GetPreviewPageEventArgs e)
         {
             PrintDocument printDoc = (PrintDocument)sender;
             printDoc.SetPreviewPage(e.PageNumber, printPreviewPages[e.PageNumber - 1]);
         }

         */

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


         public virtual void RegisterForPrinting()
         {
             PrintDocument = new PrintDocument();
             printDocumentSource = printDocument.DocumentSource;
             printDocument.Paginate += CreatePrintPreviewPages;
             printDocument.GetPreviewPage += GetPrintPreviewPage;
             printDocument.AddPages += AddPrintPages;

             PrintManager printMan = PrintManager.GetForCurrentView();
             printMan.PrintTaskRequested += PrintTaskRequested;
         }

         protected override void OnNavigatedTo(NavigationEventArgs e)
         {
             // Initalize common helper class and register for printing
             printHelper = new PrintHelper(this);
             printHelper.RegisterForPrinting();

             // Initialize print content for this scenario
             printHelper.PreparePrintContent(new PageToPrint());

             // Tell the user how to print
             MainPage.Current.NotifyUser("Print contract registered with customization, use the Print button to print.", NotifyType.StatusMessage);
         }

         protected override void OnNavigatedFrom(NavigationEventArgs e)
         {
             if (printHelper != null)
             {
                 printHelper.UnregisterForPrinting();
             }
         }

         protected virtual void PrintTaskRequested(PrintManager sender, PrintTaskRequestedEventArgs e)
         {
             PrintTask printTask = null;
             printTask = e.Request.CreatePrintTask("C# Printing SDK Sample", sourceRequested =>
             {
                 // Print Task event handler is invoked when the print job is completed.
                 printTask.Completed += async (s, args) =>
                 {
                     // Obavjestavanje korisnika da printanje nije uspjelo
                     if (args.Completion == PrintTaskCompletion.Failed)
                     {
                         await scenarioPage.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                         {
                             MainPage.Current.NotifyUser("Printanje nije uspjelo.", NotifyType.ErrorMessage);
                         });
                     }
                 };
                 sourceRequested.SetSource(printDocumentSource);
             });
         }
         protected virtual void GetPrintPreviewPage(object sender, GetPreviewPageEventArgs e)
         {
             PrintDocument printDoc = (PrintDocument)sender;
             printDoc.SetPreviewPage(e.PageNumber, printPreviewPages[e.PageNumber - 1]);
         }

         

        private void buttonNadjiBM_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(PronalazakBirackogMjesta));
            NavigationService.Navigate(typeof(GlasajBa.View.PronalazakBirackogMjesta), null);
        }

        private void buttonNovosti_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(Informacije));
            NavigationService.Navigate(typeof(GlasajBa.View.Informacije), null);
        }

        private void buttonTwitter_Click(object sender, RoutedEventArgs e)
        {
            //ucitaj twitter
        }

        private void buttonStranke_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(Informacije));
            NavigationService.Navigate(typeof(GlasajBa.View.Informacije), null);

        }

        private void buttonHistorija_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(Informacije));

            //Frame.Navigate(typeof(Informacije));
            NavigationService.Navigate(typeof(GlasajBa.View.Informacije), null);

        }

        private void image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //nije jos u funkciji za slijepe
        }

        private void image1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //ovo treba fino al ne znam kako

            Frame.Navigate(typeof(AdminLogin));

            //Frame.Navigate(typeof(AdminLogin));
            NavigationService.Navigate(typeof(GlasajBa.View.AdminLogin), null);

        }

        private void buttonStatistika_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(Informacije));

            //Frame.Navigate(typeof(Informacije));
            NavigationService.Navigate(typeof(GlasajBa.View.Informacije), null);

        }


        public OstaleFunkcionalnostiViewModel()
        {

            NavigationService = new NavigationService();

            //PretragaKandidata = new RelayCommand<object>(pretragaKandidata, jeLiMogucaPretraga);
            PronalazakBirackogMjesta = new RelayCommand<object>(pronadiBirackoMjesto, jeLiMogucaPretraga);
            //PregledNovosti = new RelayCommand<object>(nadjiNovosti, boolDodaj);
            //SistemZaSlijepeISlabovidne = new RelayCommand<object>();
        }

        public bool jeLiMogucaPretraga(object parametar)
        {
            return true;
        }

        public void pronadiBirackoMjesto(object parametar)
        {
            foreach (Ulica u in Sistem.Ulice)
            {
                if (u.Naziv == ulica.Naziv) ulica.BirackoMjesto = u.BirackoMjesto;
            }

        }
        public bool boolDodaj(Object o)
        {
            return true;
        }


        public List<T> citajIzBaze<T>()
        {
            List<T> lista = new List<T>();
            //citaj
            return lista;
        }

        public void unesiUBazu<T>(List<T> lista)
        {
            //throw new NotImplementedException();
        }

        public void urediBazu<T>(List<T> lista)
        {
            //throw new NotImplementedException();
        }
    }

}
