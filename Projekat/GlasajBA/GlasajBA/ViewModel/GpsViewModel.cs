using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Xaml.Controls.Maps;

namespace GlasajBA.ViewModel
{
    class GpsViewModel : INotifyPropertyChanged
    {
        private Geopoint lokacija;
        public Geopoint Lokacija
        {
            get
            {
                return lokacija;
            }
            set
            {
                lokacija = value;
                OnNotifyPropertyChanged("Lokacija");
            }
        }
        private string location;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
                OnNotifyPropertyChanged("Location");
            }
        }
        private string adresa;
        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                adresa = value;
                OnNotifyPropertyChanged("Adresa");
            }
        }
        MapControl mapa;
        public GpsViewModel (MapControl m)
        {
            mapa = m;
            dajLokaciju();
        }
        public async void dajLokaciju()
        {
            Geoposition pos = null;
            var accessStatus = await Geolocator.RequestAccessAsync();
            if (accessStatus==GeolocationAccessStatus.Allowed)
            {
                Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = 10 };
                pos = await geolocator.GetGeopositionAsync();
             
            }
            Lokacija = pos.Coordinate.Point;
            Location = "Geolokacija Lat: " + Lokacija.Position.Latitude + " Lng: " + Lokacija.Position.Longitude;
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(pos.Coordinate.Point);
            if (result.Status==MapLocationFinderStatus.Success)
            {
                Adresa = "Adresa je " + result.Locations[0].Address.Street;
            }
            double centerLatitude = mapa.Center.Position.Latitude;
            double centerLongitude = mapa.Center.Position.Longitude;
            MapPolyline mapPolyLine = new MapPolyline();
            mapPolyLine.Path = new Geopath(new List<BasicGeoposition>()
            {
                new BasicGeoposition()
                {
                    Latitude=centerLatitude-0.0005, Longitude=centerLongitude-0.001
                },
                new BasicGeoposition()
                {
                    Latitude=centerLatitude+0.0005, Longitude=centerLongitude-0.001
                },
                new BasicGeoposition()
                {
                    Latitude=centerLatitude+0.0005, Longitude=centerLongitude+0.001
                },
                new BasicGeoposition()
                {
                    Latitude=centerLatitude-0.0005, Longitude=centerLongitude+0.001
                },
                new BasicGeoposition()
                {
                    Latitude=centerLatitude-0.0005, Longitude=centerLongitude-0.001
                }
            });
            mapPolyLine.StrokeColor = Colors.Black;
            mapPolyLine.StrokeThickness = 3;
            mapPolyLine.StrokeDashed = true;
            mapa.MapElements.Add(mapPolyLine);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged ([CallerMemberName] string memberName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
