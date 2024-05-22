using System.Text.Json.Serialization;
using LiveChatDemo.CommonInterfaces;
using LiveChatDemo.Shared.ChatContracts;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LiveChatDemo.Api.DataAccess.Entities;

public class ChatMessage : IChatMessage, IEntity<string>
{
    [BsonRepresentation(BsonType.ObjectId), BsonId]
    public string Id { get; set; }

    public IMessageSender Sender { get; set; }
    public string Message { get; set; }
    public DateTime SentAt { get; set; } = DateTime.UtcNow;

}