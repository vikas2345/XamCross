using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamCross.Model.SQLite
{
    public class Token
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }
    }
}
