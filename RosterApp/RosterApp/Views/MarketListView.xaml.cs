using RosterApp.ViewModels;

namespace RosterApp.Views
{
    public partial class MarketListView : BaseView
    {
        public MarketListView()
        {
            InitializeComponent();
            BindingContext = new MarketListViewModel(this.Navigation);
        }
    }
}
