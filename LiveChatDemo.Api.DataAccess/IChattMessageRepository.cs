using LiveChatDemo.Api.DataAccess.Entities;
using LiveChatDemo.CommonInterfaces;
using LiveChatDemo.Shared.ChatContracts;

namespace LiveChatDemo.Api.DataAccess;

public interface IChattMessageRepository : IRepository<ChatMessage, string>
{
    void SetCollectionName(string name);

}