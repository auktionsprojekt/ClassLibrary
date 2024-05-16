using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace AuctionServiceClassLibrary;

public class AuctionBidDTO
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public Bid bid {get; set;}
    
    public DateTime AuctionEndDate { get; set; }
}

