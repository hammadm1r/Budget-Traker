using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace BudgetApp.Models
{
    public class Transaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Type { get; set; } // "income" or "expense"
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
