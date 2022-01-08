using System;
using System.Collections.Generic;
using System.Text;
using Bank_App.Models;
using System.Threading.Tasks;
using SQLite;

namespace Bank_App.Data
{
     public class BankDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public BankDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Carduri>().Wait();
            _database.CreateTableAsync<Tranzactii>().Wait();
        }
        public Task<List<Carduri>> GetCardsAsync()
        {
            return _database.Table<Carduri>().ToListAsync();
        }
        public Task<Carduri> GetCardAsync(int id)
        {
            return _database.Table<Carduri>()
            .Where(i => i.ID_Card == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCardAsync(Carduri slist)
        {
            if (slist.ID_Card != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteCardAsync(Carduri slist)
        {
            return _database.DeleteAsync(slist);
        }


        public Task<List<Tranzactii>> GeTranzactiisAsync()
        {
            return _database.Table<Tranzactii>().ToListAsync();
        }
        public Task<Tranzactii> GetTranzactiiAsync(int id)
        {
            return _database.Table<Tranzactii>()
            .Where(i => i.ID_tranzactie == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveTranzactiiAsync(Tranzactii slist)
        {
            if (slist.ID_tranzactie != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteTranzactiiAsync(Tranzactii slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
