using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    class DetailsViewModel
    {
        private readonly INavigation _navigation;
        public DetailsViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
    }
}
