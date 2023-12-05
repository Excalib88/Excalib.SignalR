namespace Excalib.SignalR.Server.Entities;

public class UserEntity : BaseEntity
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string Token { get; set; } = null!;
}