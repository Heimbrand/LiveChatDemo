using LiveChatDemo.Shared.ChatContracts;

namespace LiveChatDemo.Shared.Dtos;

public class MessageSenderDto : IMessageSender
{
    public string Name { get; set ; }
}