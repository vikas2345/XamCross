using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using XamCross.Data;

namespace XamCross.Droid.Data
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "Testdb.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var path = Path.Combine(documentPath, sqliteFileName);
        }
    }
}