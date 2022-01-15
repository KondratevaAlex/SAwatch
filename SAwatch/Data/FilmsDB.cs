using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SAwatch.Models;
using SQLite;

namespace SAwatch.Data
{
    public class FilmsDB
    {
        readonly SQLiteAsyncConnection dbfilms;

        public FilmsDB(string connectionString)
        {
            dbfilms = new SQLiteAsyncConnection(connectionString);
            dbfilms.CreateTableAsync<Films>().Wait();
        }
        public Task<List<Films>> GetFilmsAsync()
        {
            return dbfilms.Table<Films>().ToListAsync();
        }
        public Task<int> SaveNoteAsync(Films film)
        {
            if (film.FilmID == 0)
            {
                return dbfilms.InsertAsync(film);
            }
            else
            {
                return dbfilms.UpdateAsync(film);
            }
        }
    }
}
