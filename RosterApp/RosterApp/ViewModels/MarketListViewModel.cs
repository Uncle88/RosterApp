using System;
using RosterApp.Views;
using Xamarin.Forms;

namespace RosterApp.ViewModels
{
    public class MarketListViewModel : BaseViewModel
    {
        public MarketListViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public INavigation Navigation { get; private set; }

        private Command _clickADDCommand;
        public Command ClickADDCommand
        {
            get
            {
                return _clickADDCommand ?? (_clickADDCommand = new Command(async () =>
                {
                    await Navigation.PushAsync(new MarketItemView());
                }));
            }
        }
    }
}
