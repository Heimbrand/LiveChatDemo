using LiveChatDemo.Api.DataAccess;
using LiveChatDemo.Api.DataAccess.Entities;
using LiveChatDemo.Shared.ChatContracts;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccess(); // Extension method to add the ChatMessageRepository to the DI container.

var app = builder.Build();

app.MapPost("/message", async (IChattMessageRepository repo, ChatMessage message) =>
{
    await repo.AddAsync(message);
});

app.MapGet("/message", async (IChattMessageRepository repo,int start, int count) =>
{
    return await repo.GetManyAsync(start, count);
});

app.Run();
