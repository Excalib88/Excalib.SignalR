using Excalib.SignalR.Server;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ChatDbContext>(o => 
    o.UseNpgsql(builder.Configuration.GetConnectionString("Db")));
builder.Services.AddControllers();
builder.Services.AddCors(o => o.AddPolicy("cors", p =>
{
    p.AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .WithOrigins(builder.Configuration.GetSection("Cors:Origins").Get<string[]>() ?? new []{"http://localhost:3000"});
}));
builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors("cors");
app.MapControllers();
app.MapHub<ChatHub>("chat");
app.Run();