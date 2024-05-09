using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public class Person
{
    public string? GivenName { get; set; }

    public string? Address { get; set; }

    public DateTime BirthDate { get; set; }

    public int Telephone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }


    public class Seller : Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string? CVR { get; set; }
    }

    public class Admin : Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
    }

    public class User : Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
    }
}

