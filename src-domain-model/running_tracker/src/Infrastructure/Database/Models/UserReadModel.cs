﻿namespace Infrastructure.Database.Models;

internal sealed class UserReadModel
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public bool HasPublicProfile { get; set; }
}