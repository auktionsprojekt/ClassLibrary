using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using System.Text.Json.Serialization;

namespace AuctionServiceClassLibrary;

public enum AuctionStatus
{
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Ongoing,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    ToBeStarted,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Annulled,
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    Finished
}

public class Auction
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public Product? Product { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public AuctionStatus Status { get; set; }
    public int StartPrice { get; set; }


    // When you create a auction, needs to have the admin user who created it
    // openapi requirements
    public User createdBy { get; set; }

}

