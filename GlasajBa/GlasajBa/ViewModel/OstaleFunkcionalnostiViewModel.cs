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
using System.ComponentModel;

namespace GlasajBa.ViewModel
{  
    
    namespace GlasajBa.ViewModel
    {
        
       class OstaleFunkcionalnostiViewModel
        {
            private ICommand PronalazakBM { get; set; }
            private ICommand pregledNovosti;
            private ICommand pretragaKandidata;
            private ICommand sistemZaSlijepeISlabovidne;
            private ICommand pregledStranaka;
            private ICommand idiNaTwitter1;
            private ICommand registracija;
            private ICommand pregledStatistike;
            private ICommand pregledHistorije;
            private ICommand glasaj1;

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

            public INavigationService NavigationService { get; set; }
            //INavigationService INS { get; set; }

            /*
            public ICommand PronalazakBM
            {
                get
                {
                    return pronalazakBM ?? (pronalazakBM = new CommandHandler(() => nadjiBM(), true));
                }
            }*/

            public ICommand PregledNovosti
            {
                get
                {
                    return pregledNovosti;
                }

                set
                {
                    pregledNovosti = value;
                }
            }

            public ICommand PretragaKandidata
            {
                get
                {
                    return pretragaKandidata;
                }

                set
                {
                    pretragaKandidata = value;
                }
            }

            public ICommand SistemZaSlijepeISlabovidne
            {
                get
                {
                    return sistemZaSlijepeISlabovidne;
                }

                set
                {
                    sistemZaSlijepeISlabovidne = value;
                }
            }

            public ICommand PregledStranaka
            {
                get
                {
                    return pregledStranaka;
                }

                set
                {
                    pregledStranaka = value;
                }
            }

            public ICommand IdiNaTwitter
            {
                get
                {
                    return idiNaTwitter1;
                }

                set
                {
                    idiNaTwitter1 = value;
                }
            }

            public ICommand Registracija
            {
                get
                {
                    return registracija;
                }

                set
                {
                    registracija = value;
                }
            }

            public ICommand PregledStatistike
            {
                get
                {
                    return pregledStatistike;
                }

                set
                {
                    pregledStatistike = value;
                }
            }

            public ICommand PregledHistorije
            {
                get
                {
                    return pregledHistorije;
                }

                set
                {
                    pregledHistorije = value;
                }
            }

            public ICommand Glasaj
            {
                get
                {
                    return glasaj1;
                }

                set
                {
                    glasaj1 = value;
                }
            }

            #region print
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
            #endregion

            public void nadjiBM(object o)
            {
                NavigationService.Navigate(typeof(PronalazakBirackogMjesta), new GpsViewModel(new Windows.UI.Xaml.Controls.Maps.MapControl()));
                //((Frame)Window.Current.Content).Navigate(typeof(PronalazakBirackogMjesta), null);
            }

            public void otvoriNovost(object o)
            {
                NavigationService.Navigate(typeof(Informacije), this);
            }

            public void idiNaTwitter(object o)
            {
                //ucitaj twitter
                string sURL = @"https://twitter.com/glasaj_ba";

                try
                {
                    Uri webURL = new Uri(sURL);
                    // ctlBowser.Navigate(webURL); webview

                }
                catch (Exception)
                {
                    //greska pri otvaranju
                }
                
            }

            public void otvoriStranke(object o)
            {
                NavigationService.Navigate(typeof(Informacije), this);
            }

            public void otvoriHistoriju(object o)
            {
                NavigationService.Navigate(typeof(Informacije), this);
            }

            public void slijepi(object o)
            {
                //nije jos u funkciji za slijepe
                GlasackiSistem.slijepi = true;
            }

            public void registrujSe(object o)
            {
                NavigationService.Navigate(typeof(AdminLogin));
            }

            public void otvoriStatistiku(object o)
            {
                NavigationService.Navigate(typeof(Informacije));
            }
            public void pretraziKandidata(object o)
            {
                NavigationService.Navigate(typeof(PretragaKandidata));
            }

            public void glasaj(object o)
            {
                NavigationService.Navigate(typeof(Glasanje));
            }
            public bool jeLiMoguce(object o)
            {
                return true;
            }

            public OstaleFunkcionalnostiViewModel()
            {
                //this.DataContext = this;
                Sistem = new GlasackiSistem(new List<Glasac>(), new List<Kandidat>(), new List<Kandidat>(),new List<Kandidat>(), new List<Kandidat>(), new List<Stranka>(), new List<Ulica>(), new List<Novost>(), new DateTime(2017,10,5), new DateTime(2017,10,6), false, "mrviceljubavi", "admin", false);

                NavigationService = new NavigationService();

                PretragaKandidata = new RelayCommand<object>(pretraziKandidata, jeLiMoguce);
                PronalazakBM= new RelayCommand<object>(nadjiBM, jeLiMoguce);
                PregledNovosti = new RelayCommand<object>(otvoriNovost, jeLiMoguce);
                PregledStranaka = new RelayCommand<object>(otvoriStranke, jeLiMoguce);
                PregledStatistike = new RelayCommand<object>(otvoriStatistiku, jeLiMoguce);
                Registracija = new RelayCommand<object>(registrujSe, jeLiMoguce);
                IdiNaTwitter = new RelayCommand<object>(idiNaTwitter, jeLiMoguce);
                SistemZaSlijepeISlabovidne = new RelayCommand<object>(slijepi, jeLiMoguce);
                PregledHistorije = new RelayCommand<object>(otvoriHistoriju, jeLiMoguce);
                Glasaj = new RelayCommand<object>(glasaj, jeLiMoguce);
            }
            #region INotifyPropertyChanged Methods

            public void OnPropertyChanged(string propertyName)
            {
                this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            }

            protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, args);
                }
            }


            public event PropertyChangedEventHandler PropertyChanged;

            #endregion

            /*

            string uriToLaunch = @"https://twitter.com/glasaj_ba";
            var uri = new Uri(uriToLaunch);

            async void DefaultLaunch()
            {
                // Set the option to show a warning
                var options = new Windows.System.LauncherOptions();
                options.TreatAsUntrusted = true;

                // Launch the URI with a warning prompt
                var success = await Windows.System.Launcher.LaunchUriAsync(uri, options);

                if (success)
                {
                    // URI launched
                }
                else
                {
                    // URI launch failed
                }
            }*/
        }
    }

}
