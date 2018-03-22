using System;
using RosterApp.Models;
using RosterApp.Views;
using Xamarin.Forms;

namespace RosterApp.ViewModels
{
    public class MarketItemViewModel : BaseViewModel
    {
        public MarketItemViewModel(Market item)
        {
            Name = item;
        }

        public MarketItemViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public INavigation Navigation { get; set; }

        private Market _name;
        public Market Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private MarketListViewModel _marketListVM;
        public MarketListViewModel marketListViewModel
        {
            get { return _marketListVM; }
            set
            {
                if (value != _marketListVM)
                {
                    _marketListVM = value;
                    OnPropertyChanged();
                }
            }
        }

        //private Command _clickSaveBatton;
        public Command ClickSaveBatton
        {
            get
            {
                return null;
            }
        }

        //private Command _clickDeleteBatton;
        public Command ClickDeleteBatton
        {
            get
            {
                return null;
            }
        }

        private Command _clickCancelBatton;
        public Command ClickCancelBatton
        {
            get
            {
                return _clickCancelBatton ?? (_clickCancelBatton = new Command(() =>
                {
                    Device.BeginInvokeOnMainThread(async () => await Navigation.PopAsync());
                }));
            }
        }
    }
}
