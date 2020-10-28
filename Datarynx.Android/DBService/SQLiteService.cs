using System;
using System.IO;
using SQLite;
using Xamarin.Forms;

using static Datarynx.IServices.ISqliteService;

namespace Datarynx.iOS.DBService
{
    public class SQLiteService: ISQLiteService
    {
       string GetPath(string databaseName)
        {
            if (string.IsNullOrWhiteSpace(databaseName))
            {
                throw new ArgumentException("Invalid database name", nameof(databaseName));
            }
            var sqliteFilename = $"{databaseName}.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }

        public SQLiteConnection GetConnection(string databaseName)
        {
            return new SQLiteConnection(GetPath(databaseName));
        }

    }
}
   