using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace server.Model
{
    public class Student
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string StudentId { get; set; } = string.Empty;

        public string Grade { get; set; } = string.Empty;
    }
}