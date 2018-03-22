using RosterApp.Models;
using RosterApp.Services.DataBase;
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
            _dataBaseService = new DataBaseService();
        }

        readonly IDataBaseService _dataBaseService;
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

        private Command _clickSaveBatton;
        public Command ClickSaveBatton
        {
            get
            {
                return _clickSaveBatton ?? (_clickSaveBatton = new Command(async() =>
                {
                    if (Name != null)
                    {
                        _dataBaseService.SaveItemToDB(Name);
                    }
                    await Navigation.PopAsync();
                }));
            }
        }

        private Command _clickDeleteBatton;
        public Command ClickDeleteBatton
        {
            get
            {
                return _clickDeleteBatton ?? (_clickDeleteBatton = new Command(async () =>
                {
                    if (Name != null)
                    {
                        _dataBaseService.DeleteItemFromDB(Name);
                    }
                    await Navigation.PopAsync();
                }));
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
