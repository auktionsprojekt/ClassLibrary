using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public List<string>? Category { get; set; }

    public int ValuationPrice { get; set; }

    public User? User { get; set; }

    public int SalePrice { get; set; }

    public string? Description { get; set; }

    public User? Seller { get; set; }

    public DateTime SaleDate { get; set; }

    public bool Approved { get; set; }

    public List<string>? Status { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}

