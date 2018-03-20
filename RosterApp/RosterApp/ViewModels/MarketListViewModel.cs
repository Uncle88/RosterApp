using System;
using Xamarin.Forms;

namespace RosterApp.ViewModels
{
    public class MarketListViewModel : BaseViewModel
    {
        public MarketListViewModel()
        {
        }

        public INavigation Navigation { get; private set; }

        private Command _clickADDCommand;
        public Command ClickADDCommand
        {
            get
            {
                return _clickADDCommand ?? (_clickADDCommand = new Command(Navigation.PushAsync(new MarketItemView(new MarketItemViewModel()))));
            }
        }
    }
}
