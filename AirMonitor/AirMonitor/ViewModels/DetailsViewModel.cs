using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    class DetailsViewModel : INotifyPropertyChanged
    {
     
        private int _CAQI;
        private int _pm25;
        private int _pm10;
        private double _wilgotnosc;
        private int _cisnienie;
        public event PropertyChangedEventHandler PropertyChanged;

        public int CAQI
        {
            get
            {
                return _CAQI;
            }
            set
            {
                _CAQI = value;
                OnPropertyChanged("CAQI");
            }
        }

        public int Pm25
        {
            get
            {
                return _pm25;
            }
            set
            {
                _pm25 = value;
                OnPropertyChanged("PM25");
            }
        }

        public int Pm10
        {
            get
            {
                return _pm10;
            }
            set
            {
                _pm10 = value;
                OnPropertyChanged("PM10");
            }
        }

        public double Wilgotnosc
        {
            get
            {
                return _wilgotnosc;
            }
            set
            {
                _wilgotnosc = value;
                OnPropertyChanged("Wilgotność");
            }
        }

        public int Cisnienie
        {
            get
            {
                return _cisnienie;
            }
            set
            {
                _cisnienie = value;
                OnPropertyChanged("Ciśnienie");
            }
        }

        public DetailsViewModel() { }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
