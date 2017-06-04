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
            public ICommand PronalazakBM { get; set; }
            public ICommand PregledNovosti { get; set; }
            public ICommand PretraziKandidate { get; set; }
            public ICommand ZaSlijepeISlabovidne { get; set; }
            public ICommand PregledStranaka { get; set; }
            public ICommand PregledTwittera { get; set; }
            public ICommand RegistrujSe { get; set; }
            public ICommand PregledStatistike { get; set; }
            public ICommand PregledHistorije { get; set; }
            public ICommand Glasaj { get; set; }
            static int indikator=0;
            
            GlasackiSistem sistem;

            internal GlasackiSistem Sistem
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

            public void otvoriNovost(object parametar)
            {
                NavigationService.Navigate(typeof(Informacije), this);
            }
            
            public void idiNaTwitter(object o)
            {
                NavigationService.Navigate(typeof(PregledajTwitter), this);
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
                //treba preci na Glasanje, gdje ce se pustiti zvuk
            }

            public void registruj(object o)
            {
                NavigationService.Navigate(typeof(AdminLogin), new AdministratorViewModel(this));
            }

            public void otvoriStatistiku(object o)
            {
                NavigationService.Navigate(typeof(Informacije), this);
            }
            public void pretraziKandidata(object o)
            {
                NavigationService.Navigate(typeof(PretragaKandidata), new GlasanjeViewModel(this));
            }

            public void glasaj(object o)
            {
                NavigationService.Navigate(typeof(Glasanje), new GlasanjeViewModel(this));
            }
            public bool jeLiMoguce(object o)
            {
                return true;
            }

            private string _naziv;
            public string Naziv
            {
                get
                {
                    return _naziv;
                }
                set
                {
                    _naziv = value;
                }
            }

            public OstaleFunkcionalnostiViewModel()
            {
                Sistem = new GlasackiSistem();
                NavigationService = new NavigationService();

                PregledNovosti = new RelayCommand<object>(otvoriNovost, jeLiMoguce);
                Nazad = new RelayCommand<object>(idiNazad, jeLiMoguce);
                PregledStatistike = new RelayCommand<object>(otvoriStatistiku, jeLiMoguce);
                PregledStranaka = new RelayCommand<object>(otvoriStranke, jeLiMoguce);
                PregledHistorije = new RelayCommand<object>(otvoriHistoriju, jeLiMoguce);
                RegistrujSe = new RelayCommand<object>(registruj, jeLiMoguce);
                PretraziKandidate = new RelayCommand<object>(pretraziKandidata, jeLiMoguce);
                PronalazakBM = new RelayCommand<object>(nadjiBM, jeLiMoguce);
                ZaSlijepeISlabovidne = new RelayCommand<object>(slijepi, jeLiMoguce);
                PregledTwittera = new RelayCommand<object>(idiNaTwitter, jeLiMoguce);
                Glasaj = new RelayCommand<object>(glasaj, jeLiMoguce);
                if (indikator==0)
                {
                   // pustiZvuk();
                }
                indikator = 1;
            }
            
            public ICommand Nazad { get; set; }
            public void idiNazad(object parametar)
            {
                NavigationService.GoBack();
            }


            private async void pustiZvuk()
            {
                //baca exception, vidjeti zasto
                try
                {
                    MediaElement me = new MediaElement();
                    Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
                    Windows.Storage.StorageFile file = await folder.GetFileAsync("Uvod.mp3");
                    var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                    me.SetSource(stream, file.ContentType);
                    me.Play();
                }catch(Exception e)
                {

                }
            }


            /*
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
            */
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
