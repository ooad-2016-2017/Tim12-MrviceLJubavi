using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;


namespace GlasajBA.Model
{
    interface INavigationService
    {
        void Navigate(Type sourcePage);
        void Navigate(Type sourcePage, object parameter);
        void GoBack();
    }
    class NavigationService : INavigationService
    {
        public void Navigate (Type sourcePage)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage);
        }
        public void Navigate (Type sourcePage, object parameter)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage, parameter);
        }
        public void GoBack ()
        {
            var frame = (Frame)Window.Current.Content;
            frame.GoBack();
            
        }
    }
}
