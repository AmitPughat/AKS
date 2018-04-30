using System;
using MongoDB.Driver;
using MongoDB.Bson;
//using MongoDB.Bson.Serialization;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

using AKS_API.Model;

namespace AKS_API.Data
{
    public class HeroRepository
    {
        readonly string _connectionString = "mongodb://172.20.0.2:27017";
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<Hero> _heroCollection;

        public HeroRepository()
        {
            _client = new MongoClient(_connectionString);
            _database = _client.GetDatabase("webratings");
            _heroCollection = _database.GetCollection<Hero>("heroes");
        }

        public IEnumerable<Hero> GiveMeAllHeroes()
        {
            return _heroCollection.Find(new BsonDocument()).ToList();
            
        }

    }
}
