using System;
using System.Collections.Generic;
using RosterApp.Models;
using RosterApp.ViewModels;
using Xamarin.Forms;

namespace RosterApp.Views
{
    public partial class MarketItemView : BaseView
    {
        public MarketItemView(Market item)
        {
            InitializeComponent();
            BindingContext = new MarketItemViewModel(Navigation);
        }

        public MarketItemView()
        {
            InitializeComponent();
            BindingContext = new MarketItemViewModel(Navigation);
        }
    }
}
