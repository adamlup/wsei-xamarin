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
                OnPropertyChanged(CAQI.ToString());
            }
        }
        public DetailsViewModel() { }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
