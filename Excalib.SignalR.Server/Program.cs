using Excalib.SignalR.Server;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors(o => o.AddPolicy("cors", p =>
{
    p.AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .WithOrigins("http://localhost:3000");
}));
builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors("cors");
app.MapControllers();
app.MapHub<ChatHub>("chat");
app.Run();