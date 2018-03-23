using RosterApp.Models;
using RosterApp.Services.DataBase;
using Xamarin.Forms;

namespace RosterApp.ViewModels
{
    public class MarketItemViewModel : BaseViewModel
    {
        private readonly IDataBaseService _dataBaseService;

        public MarketItemViewModel(){}

        public MarketItemViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _dataBaseService = new DataBaseService();
        }

        public INavigation Navigation { get; set; }

        private string _item;
        public string Item     
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }

        private Command _saveCommand;
        public Command SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new Command(async () =>
                {
                    var _saveItem = new Market();
                    _saveItem.Name = Item;
                    _dataBaseService.SaveItemToDB(_saveItem);


                    var markET = _dataBaseService.GetList();


                    await Navigation.PopAsync();
                }));
            }
        }

        private Command _deleteCommand;
        public Command DeleteCommand
        {
            get
            {
                return _deleteCommand ?? (_deleteCommand = new Command(async () =>
                {
                    if (Item !=null)
                    {
                        //_dataBaseService.DeleteItemFromDB(Item);
                    }
                    await Navigation.PopAsync();
                }));
            }
        }

        private Command _cancelCommand;
        public Command CancelCommand
        {
            get
            {
                return _cancelCommand ?? (_cancelCommand = new Command(() =>
                {
                    Device.BeginInvokeOnMainThread(async () => await Navigation.PopAsync());
                }));
            }
        }
    }
}
