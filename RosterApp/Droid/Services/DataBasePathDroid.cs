using System;
using System.IO;
using RosterApp.Droid.Services;
using RosterApp.Services.DataBasePath;


[assembly: Xamarin.Forms.Dependency(typeof(DataBasePathDroid))]
namespace RosterApp.Droid.Services
{
    public class DataBasePathDroid : IDataBasePathService
    {
        public string DataBasePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "RosterDB.db");
    }
}
