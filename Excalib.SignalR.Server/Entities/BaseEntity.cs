﻿namespace Excalib.SignalR.Server.Entities;

public class BaseEntity
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}