using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AKS_API.Model
{
    public class Hero
    {
        [BsonId]
        public Object Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("uid")]
        public double Uid { get; set; }
        [BsonElement("img")]
        public string Img { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("aliases")]
        public string Aliases { get; set; }
    }

}
