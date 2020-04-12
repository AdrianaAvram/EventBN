using SQLite.Net;
using EventBN.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EventBN
{
    public class DbService
    {
        SQLiteConnection dbConnection;
        public DbService()
        {
            dbConnection = DependencyService.Get<ISQLite>().GetConnection();
        }
        
        public List<Account> GetAllEvent()
        {
            return dbConnection.Query<Account>("Select * From [Account]");
        }
    }
}
