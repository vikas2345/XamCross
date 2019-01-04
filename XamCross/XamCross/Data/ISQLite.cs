using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamCross.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
