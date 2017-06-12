using GlasajBa.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace GlasajBa.UserControls
{
    public sealed partial class ImageAndButton : UserControl
    {
        public ImageAndButton()
        {
            this.InitializeComponent();
        }

        public static byte[] uploadSlika = null;
        public static Image image = null;
        private async void dugmeUC_Click(object sender, RoutedEventArgs e)
        {
            //byte[] uploadSlika = null;
            FileOpenPicker picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    // Set the image source to the selected bitmap 
                    //uploadSlika = (await Windows.Storage.FileIO.ReadBufferAsync(file)).ToArray();
                    //AdministratorViewModel.NoviKandidat.Slika = uploadSlika;
                    //BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.DecodePixelWidth = 600; //match the target Image.Width, not shown
                    await bitmapImage.SetSourceAsync(fileStream);
                    slikaUC.Source = bitmapImage;
                    image = slikaUC;
                    
                }
                //uploadSlika =await spasi(bitmapImage);
            }

        }

        private async Task<byte[]> spasi(BitmapImage image)
        {
            RandomAccessStreamReference streamRef = RandomAccessStreamReference.CreateFromUri(image.UriSource);
            IRandomAccessStreamWithContentType streamWithContent = await streamRef.OpenReadAsync();
            byte[] buffer = new byte[streamWithContent.Size];
            await streamWithContent.ReadAsync(buffer.AsBuffer(), (uint)streamWithContent.Size, InputStreamOptions.None);
            return buffer;
        }

        private void slikaUC_Loaded(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}
