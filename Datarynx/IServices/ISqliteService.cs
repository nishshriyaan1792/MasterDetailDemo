using System;
using SQLite;

namespace Datarynx.IServices
{
    public class ISqliteService
    {
        public interface ISQLiteService
        {
            SQLiteConnection GetConnection(string databaseName);
        }
    }
}
