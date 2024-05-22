namespace LiveChatDemo.Shared.ChatContracts;

public interface IChatMessage
{
    IMessageSender Sender { get; set; }
    string Message { get; set; }
    DateTime SentAt { get; set; }
}