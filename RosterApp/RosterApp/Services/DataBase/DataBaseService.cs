using System;
using System.Collections.Generic;
using System.Linq;
using RosterApp.Models;
using RosterApp.Services.DataBasePath;
using SQLite;
using Xamarin.Forms;

namespace RosterApp.Services.DataBase
{
    public class DataBaseService : IDataBaseService
    {

        private readonly IDataBasePathService _dataBasePathSevice = DependencyService.Get<IDataBasePathService>();
        private readonly SQLiteConnection _dataBaseConnection;

        public DataBaseService()
        {
            _dataBaseConnection = new SQLiteConnection(_dataBasePathSevice.DataBasePath);
            _dataBaseConnection.CreateTable<Market>();
        }

        public List<Market> GetList()
        {
            return _dataBaseConnection.Table<Market>().ToList();
        }

        public void DeleteItemFromDB(List<Market> item)
        {
            _dataBaseConnection.Delete(item);
        }

        public void SaveItemToDB(List<Market> item)
        {
            _dataBaseConnection.Insert(item);
        }
    }
}
