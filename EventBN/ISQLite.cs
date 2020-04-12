using SQLite;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBN
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
