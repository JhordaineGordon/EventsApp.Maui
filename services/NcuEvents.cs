using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp.Maui.services
{
    public class NcuEvents
    {
         SQLiteConnection _conn;
        string _dbPath;
        string StatusMessage;

        public NcuEvents(string dbPath)
        {
            _dbPath = dbPath;
        }
        private void Init()
        { 
            if (_conn != null)
            return;

            _conn = new SQLiteConnection(_dbPath);
            _conn.CreateTable<NcuEvents>();
    }
        public List<NcuEvents> GetEvents()
        {
         try
            {
                Init();
                return conn.Table<NcuEvents>().ToList();
            }
            catch (Exception)
        {
                StatusMessage = "Failed to retrieve data.";
        }
        return new List<NcuEvents>();

        }
 
    
    }
    namespace NcuEventsMaui.Models
    {
        public class NcuEventsDatabase
        {
            readonly SQLiteAsyncConnection _database;

            public NcuEventsDatabase(string dbPath)
            {
                _database = new SQLiteAsyncConnection(dbPath);
                _database.CreateTableAsync<NcuEvents>().Wait();
            }

            public Task<List<NcuEvents>> GetNcuEventsAsync()
            {
                return _database.Table<NcuEvents>().ToListAsync();
            }

            public Task<int> SaveNcuEventsAsync(NcuEvents ncuEvents)
            {
                if (NcuEvents.Id != 0)
                {
                    return _database.UpdateAsync(NcuEvents);
                }
                else
                {
                    return _database.InsertAsync(NcuEvents);
                }
            }

            public Task<int> DeleteNcuEventsAsync(NcuEvents ncuEvents)
            {
                return _database.DeleteAsync(NcuEvents);
            }
        }
    }


}
