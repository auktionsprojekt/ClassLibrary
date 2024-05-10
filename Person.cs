using System;
using System.Security.Cryptography.X509Certificates;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public class Person
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }

    public Person(int id, string name, string role)
    {
        Id = id;
        Name = name;
        Role = role;
    }
}

public class Seller : Person
{
    public string CVR {get; set;}

    public Seller(int id, string name, string cvr) : base(id, name, "Seller")
    {
        CVR = cvr;
    }
}

public class User : Person
{
    public User(int id, string name) : base(id, name, "User")
    {

    }
}

public class Admin : Person
{
    public Admin(int id, string name) : base(id, name, "Admin")
    {
        
    }
}
