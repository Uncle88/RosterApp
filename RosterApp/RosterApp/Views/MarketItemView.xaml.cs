using System;
using System.Collections.Generic;
using RosterApp.Models;
using RosterApp.ViewModels;
using Xamarin.Forms;

namespace RosterApp.Views
{
    public partial class MarketItemView : ContentPage
    {
        public MarketItemView(Market item)
        {
            InitializeComponent();
            this.BindingContext = new MarketItemViewModel(item);
        }

        public MarketItemView()
        {
            InitializeComponent();
            BindingContext = new MarketItemViewModel(Navigation);
        }
    }
}
