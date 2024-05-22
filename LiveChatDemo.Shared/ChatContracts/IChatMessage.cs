using System.Text.Json.Serialization;
using LiveChatDemo.Shared.Dtos;

namespace LiveChatDemo.Shared.ChatContracts;

public interface IChatMessage
{
    // [JsonConverter(typeof(MessageSender))] Possible solution instead of using a custom converter
    MessageSenderDto Sender { get; set; }
    string Message { get; set; }
    DateTime SentAt { get; set; }
}