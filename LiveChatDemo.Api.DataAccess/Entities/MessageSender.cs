using LiveChatDemo.Shared.ChatContracts;

namespace LiveChatDemo.Api.DataAccess.Entities;

public class MessageSender : IMessageSender
{
    public string Name { get;set; } = default!;
}