using System;
using System.IO;
using RosterApp.iOS.Services;
using RosterApp.Services.DataBasePath;


[assembly: Xamarin.Forms.Dependency(typeof(DataBasePathiOS))]
namespace RosterApp.iOS.Services
{
    public class DataBasePathiOS : IDataBasePathService
    {
        public string DataStoragePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "RosterDB.db");
    }
}
