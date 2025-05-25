using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi601.Entities
{
	public class Customer
	{
        //MongoDb'de Id'ler string olarak tutulur
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; } //attribute'lar ile CustomerId'yi benzersiz bir alana dönüştürdük
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerCity { get; set; }
        public decimal CustomerBalance { get; set; }
        public int CustomerShoppingCount { get; set; }
    }
}
