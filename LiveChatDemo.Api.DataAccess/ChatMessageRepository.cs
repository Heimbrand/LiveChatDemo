using LiveChatDemo.Api.DataAccess.Entities;
using MongoDB.Driver;

namespace LiveChatDemo.Api.DataAccess;

public class ChatMessageRepository : IChattMessageRepository
{

    private readonly IMongoDatabase _database;
    private string _collectionName;
    public ChatMessageRepository()
    {
        IMongoClient client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase("LiveChatDemo");
        _collectionName = "Lobby";
    }

    public async Task AddAsync(ChatMessage entity)
    {
        var collection = _database.GetCollection<ChatMessage>(_collectionName, new MongoCollectionSettings() { AssignIdOnInsert = true });
        await collection.InsertOneAsync(entity);

    }

    public async Task<ChatMessage> GetByIdAsync(string id)
    {
        var collection = _database.GetCollection<ChatMessage>(_collectionName);
        var messages = await collection.FindAsync(id);
        var message = messages.FirstOrDefaultAsync();
        return await message;
    }

    public async Task<IEnumerable<ChatMessage>> GetManyAsync(int start, int count)
    {
        var collection = _database.GetCollection<ChatMessage>(_collectionName);
        var messages = await collection.Find(_ => true).Skip(start).Limit(count).ToListAsync(); //Pagination, better than GetAll.
        return messages;
    }

    public void SetCollectionName(string name)
    {
        _collectionName = name;
    }
}