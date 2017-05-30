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
    
    namespace GlasajBa.ViewModel
    {
        
        class OstaleFunkcionalnostiViewModel : PrintDocument
        {
            ICommand PronalazakBirackogMjesta { get; set; }
            ICommand PregledNovosti { get; set; }
            ICommand PretragaKandidata { get; set; }
            ICommand SistemZaSlijepeISlabovidne { get; set; }
            ICommand PregledStranaka { get; set; }
            ICommand IdiNaTwitter { get; set; }
            ICommand Registracija { get; set; }
            ICommand PregledStatistike { get; set; }
            ICommand PregledHistorije { get; set; }
            ICommand Glasaj { get; set; }

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

            NavigationService NavigationService { get; set; }
            INavigationService INS { get; set; }

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

            /*
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

            private void nadjiBM(Object o)
            {
                NavigationService.Navigate(typeof(PronalazakBirackogMjesta), null);
            }

            private void otvoriNovost(Object o)
            {
                INS.Navigate(typeof(Informacije));
            }

            private void idiNaTwitter(Object o)
            {
                //ucitaj twitter
            }

            private void otvoriStranke(Object o)
            {
                NavigationService.Navigate(typeof(Informacije), null);
            }

            private void otvoriHistoriju(Object o)
            {
                NavigationService.Navigate(typeof(Informacije), null);
            }

            private void slijepi(Object o)
            {
                //nije jos u funkciji za slijepe
                GlasackiSistem.slijepi = true;
            }

            public void registrujSe(Object o)
            {
                NavigationService.Navigate(typeof(AdminLogin), null);
            }

            private void otvoriStatistiku(Object o)
            {
                NavigationService.Navigate(typeof(Informacije), null);
            }
            private void pretraziKandidata(Object o)
            {
                NavigationService.Navigate(typeof(PretragaKandidata), null);
            }
            public bool traziKandidata(Object o)
            {
                return true;
            }
            private void glasaj(Object o)
            {
                NavigationService.Navigate(typeof(Glasanje), null);
            }
            public bool jeLiMoguce(Object o)
            {
                return true;
            }

            public OstaleFunkcionalnostiViewModel()
            {
                NavigationService = new NavigationService();

                Sistem = new GlasackiSistem(new List<Glasac>(), new List<Kandidat>(), new List<Kandidat>(),new List<Kandidat>(), new List<Kandidat>(), new List<Stranka>(), new List<Ulica>(), new List<Novost>(), new DateTime(2017,10,5), new DateTime(2017,10,6), false, "mrviceljubavi", "admin", false);

                PretragaKandidata = new RelayCommand<object>(pretraziKandidata, traziKandidata);
                PronalazakBirackogMjesta = new RelayCommand<object>(nadjiBM, jeLiMoguce);
                PregledNovosti = new RelayCommand<object>(otvoriNovost, jeLiMoguce);
                PregledStranaka = new RelayCommand<object>(otvoriStranke, jeLiMoguce);
                PregledStatistike = new RelayCommand<object>(otvoriStatistiku, jeLiMoguce);
                Registracija = new RelayCommand<object>(registrujSe, jeLiMoguce);
                IdiNaTwitter = new RelayCommand<object>(idiNaTwitter, jeLiMoguce);
                SistemZaSlijepeISlabovidne = new RelayCommand<object>(slijepi, jeLiMoguce);
                PregledHistorije = new RelayCommand<object>(otvoriHistoriju, jeLiMoguce);
                Glasaj = new RelayCommand<object>(glasaj, jeLiMoguce);
            }
        }
    }

}
