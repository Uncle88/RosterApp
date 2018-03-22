using System;
using System.Collections.Generic;
using RosterApp.Models;

namespace RosterApp.Services.DataBase
{
    public interface IDataBaseService
    {
        List<Market> GetList();
        void SaveItemToDB(List<Market> item);
        void DeleteItemFromDB(List<Market> item);
    }
}
