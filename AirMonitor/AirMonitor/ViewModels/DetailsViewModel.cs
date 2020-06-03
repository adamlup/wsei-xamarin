using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    class DetailsViewModel : INotifyPropertyChanged
    {
     
        private int _CAQI;
        private int _pm25 = 34;
        private int _pm25Percent = 137;
        private int _pm10 = 67;
        private int _pm10Percent = 135;
        private double _wilgotnosc = 0.95;
        private int _cisnienie = 1027;
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        
        public int Pm25Percent
        {
            get
            {
                return _pm25Percent;
            }
            set
            {
                _pm25Percent = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public int Pm10Percent
        {
            get
            {
                return _pm10Percent;
            }
            set
            {
                _pm10Percent = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public DetailsViewModel() { }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
