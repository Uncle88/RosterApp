using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RosterApp.ViewModels
{
    public class BaseView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
