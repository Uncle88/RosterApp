using RosterApp.Models;
using RosterApp.Services.DataBase;
using Xamarin.Forms;

namespace RosterApp.ViewModels
{
    public class MarketItemViewModel : BaseViewModel
    {
        private readonly IDataBaseService _dataBaseService;

        public MarketItemViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _dataBaseService = new DataBaseService();
        }

        public MarketItemViewModel(INavigation navigation,Market item) : this(navigation)
        {
            Item = item;
            ItemName = item.Name;
            IsDone = item.IsDone;
        }

        public INavigation Navigation { get; set; }

        private Market _item;
        public Market Item     
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }

        private string _itemName;
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                _itemName = value;
                OnPropertyChanged();
            }
        }

        private bool _done;
        public bool IsDone
        {
            get { return _done; }
            set 
            {
                _done = value;
                OnPropertyChanged();
            }
        }

        private Command _updateCommand;
        public Command UpdateCommand
        {
            get
            {
                return _updateCommand ?? (_updateCommand = new Command(async () =>
                {
                    if (Item != null)
                    {
                        Item.Name = ItemName;
                        Item.IsDone = IsDone;
                        _dataBaseService.SaveItemToDB(Item);
                    }
                    await Navigation.PopAsync();
                }));
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
                    if (ItemName != null)
                    {
                        _saveItem.Name = ItemName;
                        _saveItem.IsDone = IsDone;
                        _dataBaseService.SaveItemToDB(_saveItem);
                    }

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
                    _dataBaseService.DeleteItemFromDB(Item);
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
