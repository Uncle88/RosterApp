using System;
using System.Collections.Generic;
using RosterApp.Models;
using RosterApp.Services.DataBase;
using RosterApp.Views;
using Xamarin.Forms;

namespace RosterApp.ViewModels
{
    public class MarketListViewModel : BaseViewModel
    {
        readonly IDataBaseService _dataBaseService;

        public MarketListViewModel(){}

        public MarketListViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _dataBaseService = new DataBaseService();
        }

        public override void OnAppearing()
        {
            base.OnAppearing();

            Markets = _dataBaseService.GetList();
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

        private List<Market> _markets;
        public List<Market> Markets
        {
            get { return _markets; }
            set 
            {
                _markets = value;
                OnPropertyChanged();
            }
        }

        private Market _selectedItemMarket;
        public Market SelectedItemMarket
        {
            get
            {
                return _selectedItemMarket;
            }
            set
            {
                if (_selectedItemMarket != value)
                {
                    _selectedItemMarket = value;
                    OnPropertyChanged();
                    if (value != null)
                    {
                        OnItemSelected();
                    }
                }
            }
        }

        async void OnItemSelected()
        {
            await Navigation.PushAsync(new MarketItemView(SelectedItemMarket));
            SelectedItemMarket = null;
        }
    }
}
