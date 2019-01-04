using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using XamCross.Model.SQLite;

namespace XamCross.Data
{
   public class EmployeeDatabaseController
    {
        readonly SQLiteAsyncConnection database;

        public EmployeeDatabaseController( string dbfilePath)
        {
            database = new SQLiteAsyncConnection(dbfilePath);

            database.CreateTableAsync<Employee>().Wait();
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            return database.Table<Employee>().ToListAsync();
        }

        public Task<Employee> GetEmployeeAsync(int id)
        {
            return database.Table<Employee>().Where(i => i.EmpID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveEmployeeAsync(Employee employee)
        {
            if(employee.EmpID == 0)
            {
                return database.InsertAsync(employee);
            }
            else
            {
                return database.UpdateAsync(employee);
            }
        }


        public Task<int> DeleteEmployeeAsync(Employee employee)
        {
            return database.DeleteAsync(employee);
        }
    }
}
