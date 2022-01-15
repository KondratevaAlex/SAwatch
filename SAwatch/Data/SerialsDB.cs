using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SAwatch.Models;
using SQLite;

namespace SAwatch.Data
{
    public class SerialsDB
    {
        readonly SQLiteAsyncConnection dbserials;

        public SerialsDB(string connectionString)
        {
            dbserials = new SQLiteAsyncConnection(connectionString);
            dbserials.CreateTableAsync<Serials>().Wait();
        }
        public Task<List<Serials>> GetSerialsAsync()
        {
            return dbserials.Table<Serials>().ToListAsync();
        }
        public Task<int> SaveSerialAsync(Serials serial)
        {
            if (serial.SerialsID == 0)
            {
                return dbserials.InsertAsync(serial);
            }
            else
            {
                return dbserials.UpdateAsync(serial);
            }
        }
    }
}
