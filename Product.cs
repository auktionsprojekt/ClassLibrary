using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public enum ProductCategory
{
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Furniture,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Jewelry,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Art,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Collectibles
}

public enum ProductStatus
{
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Registered,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    PendingAuction,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    InAuction,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Sold,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Denied
}

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public ProductCategory Category { get; set; }

    public int ValuationPrice { get; set; }

    public User? User { get; set; }

    public int SalePrice { get; set; }

    public string? Description { get; set; }

    public User? Seller { get; set; }

    public DateTime SaleDate { get; set; }

    public bool Evaluation { get; set; }

    public ProductStatus Status { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}

