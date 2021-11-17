// https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-net-6-preview-4/
// using Hubs;

using Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR(); // .net 6 變成這樣添加 DI service

var app = builder.Build();

// .Net 6 use this way to set MiddleWare 
app.UseStaticFiles();
app.UseDefaultFiles();

app.MapGet("/", () => "Hello World!");
app.MapHub<ChatHub>("/chathub");

app.Run();
