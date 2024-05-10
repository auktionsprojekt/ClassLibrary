using System;
using System.Security.Cryptography.X509Certificates;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }

    public User(string id, string name, string role)
    {
        Id = id;
        Name = name;
        Role = role;
    }
}

public class Seller : User
{
    public string CVR {get; set;}

    public Seller(string id, string name, string cvr) : base(id, name, "Seller")
    {
        CVR = cvr;
    }
}

public class Bidder : User
{
    public Bidder(string id, string name) : base(id, name, "Bidder")
    {

    }
}

public class Admin : User
{
    public Admin(string id, string name) : base(id, name, "Admin")
    {
        
    }
}
