using System;

namespace SharedKernel.Entities;

public interface ICreatedEntity
{
    DateTime? CreatedAt { get; set; }
    string? CreatedBy { get; set; }
}
