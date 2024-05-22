using System;
using System.Security.Cryptography.X509Certificates;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public enum Role
{
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Bidder,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Seller,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Admin,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Legal
}

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string? GivenName { get; set; }

    public string? Address { get; set; }

    public DateTime BirthDate { get; set; }

    public int Telephone { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public Role Role { get; set; }

    public DateTime RegistrationDate { get; set; }


    public User(string id, string name, string address, DateTime birthdate, int telephone, string email,
        string password, Role role, DateTime registrationDate)
    {
        Id = id;
        GivenName = name;
        Address = address;
        BirthDate = birthdate;
        Telephone = telephone;
        Email = email;
        Password = password;
        Role = role;
        RegistrationDate = registrationDate;
    }
}
