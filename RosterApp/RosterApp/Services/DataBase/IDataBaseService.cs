using System;
using System.Collections.Generic;
using RosterApp.Models;

namespace RosterApp.Services.DataBase
{
    public interface IDataBaseService
    {
        List<Market> GetList();
        int SaveItemToDB(Market item);
        void DeleteItemFromDB(Market item);
    }
}
