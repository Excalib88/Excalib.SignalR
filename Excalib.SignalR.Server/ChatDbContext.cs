using Excalib.SignalR.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace Excalib.SignalR.Server;

public class ChatDbContext : DbContext
{
    public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; } = null!;
    public DbSet<ChatEntity> Chats { get; set; } = null!;
}