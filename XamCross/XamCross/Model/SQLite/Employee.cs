using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamCross.Model.SQLite
{
   public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmpID { get; set; }

        public string EmpName { get; set; }
        public string Designation { get; set; }
        public double Age { get; set; }
    }
}
