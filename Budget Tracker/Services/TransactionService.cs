using MongoDB.Driver;
using BudgetApp.Models;
using BudgetApp.Settings;
using Microsoft.Extensions.Options;

namespace BudgetApp.Services
{
    public class TransactionService
    {
        private readonly IMongoCollection<Transaction> _collection;

        public TransactionService(IOptions<MongoDBSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var db = client.GetDatabase(settings.Value.DatabaseName);
            _collection = db.GetCollection<Transaction>("Transactions");
        }

        public async Task<List<Transaction>> GetAllAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public async Task AddAsync(Transaction t) =>
            await _collection.InsertOneAsync(t);
    }
}
