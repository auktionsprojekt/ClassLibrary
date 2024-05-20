using System;
using System.Security.Cryptography.X509Certificates;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string GivenName { get; set; }

    public string Address { get; set; }

    public DateTime BirthDate { get; set; }

    public int Telephone { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
    public string Role { get; set; }

    public DateTime RegistrationDate { get; set; }

    public User(string id, string name, string address, DateTime birthdate, int telephone, string email, string password, string role, DateTime registrationDate)
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

        public User()
    {

    }
}

public class Seller : User
{
    public string CVR {get; set;}

    public Seller(string id, string name, string address, DateTime birthdate, int telephone, string email, string password, string role, string cvr, DateTime registrationDate) : base(id, name, address, birthdate, telephone, email, password, "Seller", registrationDate)
    {
        CVR = cvr;
    }
}

public class Bidder : User
{
    public Bidder(string id, string name, string address, DateTime birthdate, int telephone, string email, string password, string role, DateTime registrationDate) : base(id, name, address, birthdate, telephone, email, password,  "Bidder", registrationDate)
    {

    }
}

public class Admin : User
{
    public Admin(string id, string name, string address, DateTime birthdate, int telephone, string email, string password, string role, DateTime registrationDate) : base(id, name, address, birthdate, telephone, email, password, "Admin", registrationDate)
    {
        
    }
}
