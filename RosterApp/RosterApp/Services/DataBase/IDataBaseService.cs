using System;
using System.Collections.Generic;
using RosterApp.Models;

namespace RosterApp.Services.DataBase
{
    public interface IDataBaseService
    {
        void SaveItemToDB(List<Market> item);
        void DeleteItemFromDB(List<Market> item);
    }
}
