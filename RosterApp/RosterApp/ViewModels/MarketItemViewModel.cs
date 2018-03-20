using System;
namespace RosterApp.ViewModels
{
    public class MarketItemViewModel : BaseViewModel
    {
        public MarketItemViewModel()
        {
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
    }
}
