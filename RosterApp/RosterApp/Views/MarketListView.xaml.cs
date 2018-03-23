using System;
using System.Collections.Generic;
using RosterApp.ViewModels;
using Xamarin.Forms;

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
