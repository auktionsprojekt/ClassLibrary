using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public class AuctionBidDTO
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public DateTime AuctionEndDate { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string? BidderId { get; set; }

    public int Amount { get; set; }
}

