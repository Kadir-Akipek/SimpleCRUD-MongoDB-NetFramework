using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi601.Services
{
	public class MongoDbConnection
	{
		private IMongoDatabase _database;
        public MongoDbConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017"); //veritabanı bağlantı adresimiz
            _database = client.GetDatabase("Db601Customer"); //veriTabanımızı oluşturduk
        }
        public IMongoCollection<BsonDocument> GetCustomersCollection() //koleksiyon oluşturma(çağırma) metodumuz
        {
            return _database.GetCollection<BsonDocument>("Customers"); //Db601 veritbanımızın içine kolkesiyon ekledik
        }
    }
}
