using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;

namespace AuctionServiceClassLibrary;

public class Auction
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public Product? Product { get; set; }

    public DateTime DateCreated { get; set; }

    public List<string>? Status { get; set; }

    public int StartPrice { get; set; }

}

