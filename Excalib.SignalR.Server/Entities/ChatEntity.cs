namespace Excalib.SignalR.Server.Entities;

public class ChatEntity : BaseEntity
{
    public ChatType Type { get; set; } = ChatType.Personal;
    public string? Name { get; set; }
    public string? Description { get; set; }
    
    /// <summary>
    /// Имя группы в SignalR
    /// </summary>
    public string UniqueName { get; set; } = null!;
}