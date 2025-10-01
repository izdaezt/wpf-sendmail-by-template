using System;

namespace SharedKernel.Entities;

public class AuditableEntity : Entity, ICreatedEntity, IUpdatedEntity
{
    public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
}

public class AuditableEntity<T> : Entity<T>, ICreatedEntity, IUpdatedEntity
{
    public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
}