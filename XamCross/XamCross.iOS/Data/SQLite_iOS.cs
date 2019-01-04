using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamCross.Data;

[assembly: Dependency(typeof(XamCross.iOS.Data.SQLite_iOS))]

namespace XamCross.iOS.Data
{
    public class SQLite_iOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "TestDB.db3";
            var documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);

            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}