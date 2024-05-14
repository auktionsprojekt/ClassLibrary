using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuctionServiceClassLibrary;

public class Bid
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public long AuctionId { get; set; }

    public DateTime DateSent { get; set; }

    public long UserId { get; set; }

    public int Amount { get; set; }
}

